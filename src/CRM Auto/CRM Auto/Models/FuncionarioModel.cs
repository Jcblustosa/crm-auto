
using CRM_Auto.Util;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace CRM_Auto.Models
{
    public class FuncionarioModel
    {
        public int Id_funcionario { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public string Id_oficina { get; set; }
        public string Login_usuario { get; set; }
        public string Nome_oficina { get; set; }
        public string Apelido { get; set; }
        public string Senha_usuario { get; set; }

        public BaseFont fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

        public FuncionarioModel(int Id_funcionario, string Nome, string Funcao, string Id_oficina, string Nome_oficina, string Apelido, string Login_usuario)
        {
            this.Id_funcionario = Id_funcionario;
            this.Nome = Nome;
            this.Funcao = Funcao;
            this.Id_oficina = Id_oficina;
            this.Nome_oficina = Nome_oficina;
            this.Apelido = Apelido;
            this.Login_usuario = Login_usuario;
        }

        public FuncionarioModel()
        {

        }

        public void InserirFuncionario(FuncionarioModel funcionario)
        {

            CNN cnn = new CNN();
            DataTable Id_oficina = cnn.GetData($"SELECT ID_OFICINA FROM OFICINA WHERE ID_OFICINA = '{funcionario.Id_oficina}'");

            string command = $"INSERT INTO FUNCIONARIO (NOME, FUNCAO, ID_OFICINA) " +
                $"VALUES ('{funcionario.Nome}', '{funcionario.Funcao}', '{funcionario.Id_oficina}')";

            //DAL dal = new DAL();
            //dal.InsertData(command);

            CNN cnn1 = new CNN();
            cnn1.InsertData(command);
        }

        public bool ValidarInsercaoFuncionario(FuncionarioModel funcionario)
        {
            string command = $"SELECT NOME, FUNCAO " +
                $"FROM FUNCIONARIO " +
                $"WHERE NOME = '{funcionario.Nome}' AND FUNCAO = '{funcionario.Funcao}'";

            //DAL dal = new DAL();
            //DataTable dt = dal.GetData(command);

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            if (dt != null)
            {
                if (dt.Rows.Count >= 1)
                {
                    //Cria um usuario para o funcionário inserido no método anterior
                    CNN cnn1 = new CNN();
                    DataTable Id_funcionario = cnn1.GetData($"SELECT ID_FUNCIONARIO FROM FUNCIONARIO WHERE NOME = '{funcionario.Nome}' AND FUNCAO = '{funcionario.Funcao}'");

                    string command2 = $"INSERT INTO USUARIO (ID_FUNCIONARIO, LOGIN_USUARIO, SENHA_USUARIO, CLIENTE_OU_FUNCIONARIO)" +
                    $"VALUES ('{Id_funcionario.Rows[0]["Id_funcionario"]}','{funcionario.Login_usuario}', '{funcionario.Senha_usuario}', 'F')";

                    //DAL dal = new DAL();
                    //dal.InsertData(command);

                    CNN cnn2 = new CNN();
                    cnn.InsertData(command2);

                    return true;
                }
            }
            return false;
        }

        public List<FuncionarioModel> BuscarFuncionarios()
        {
            ArrayList<FuncionarioModel> funcionarios = new ArrayList<FuncionarioModel>();

            string command = $"SELECT F.ID_FUNCIONARIO, F.NOME, F.FUNCAO, O.ID_OFICINA, O.NOME_OFICINA, O.APELIDO, U.LOGIN_USUARIO " +
                $"FROM FUNCIONARIO F " +
                $"INNER JOIN OFICINA O ON F.ID_OFICINA = O.ID_OFICINA " +
                $"INNER JOIN USUARIO U ON F.ID_FUNCIONARIO = U.ID_FUNCIONARIO " +
                $"ORDER BY F.NOME";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                FuncionarioModel funcionario = new FuncionarioModel(int.Parse(dt.Rows[i]["Id_funcionario"].ToString()),
                    dt.Rows[i]["Nome"].ToString(),
                    dt.Rows[i]["Funcao"].ToString(),
                    dt.Rows[i]["Id_oficina"].ToString(),
                    dt.Rows[i]["Nome_oficina"].ToString(),
                    dt.Rows[i]["Apelido"].ToString(),
                    dt.Rows[i]["Login_usuario"].ToString());

                funcionarios.Add(funcionario);
            }

            return funcionarios;
        }

        public void AlterarFuncionario(FuncionarioModel funcionario)
        {
            string command = $"UPDATE FUNCIONARIO " +
                $"SET NOME = '{funcionario.Nome}', FUNCAO = '{funcionario.Funcao}' , ID_OFICINA = '{funcionario.Id_oficina}' " +
                $"WHERE ID_FUNCIONARIO = '{funcionario.Id_funcionario}'";

            //DAL dal = new DAL();
            //dal.InsertData(command);

            CNN cnn1 = new CNN();
            cnn1.InsertData(command);
        }

        public void ExcluirFuncionario(FuncionarioModel funcionario)
        {

            //Exclui o usuário (necessário excluir antes porque o id_funcionario é chave estrangeira na tabela Usuario)
            string command = $"DELETE FROM USUARIO " +
                $"WHERE ID_FUNCIONARIO = {funcionario.Id_funcionario}";

            //Exclui o funcionário
            string command2 = $"DELETE FROM FUNCIONARIO " +
                $"WHERE ID_FUNCIONARIO = {funcionario.Id_funcionario}";


            //DAL dal = new DAL();
            //dal.InsertData(command);

            CNN cnn = new CNN();
            cnn.InsertData(command);

            CNN cnn2 = new CNN();
            cnn2.InsertData(command2);
        }

        public void GerarRelatorioEmPDF()
        {
            FuncionarioModel funcionarios = new FuncionarioModel();

            var funcionariosLista = funcionarios.BuscarFuncionarios().ToList();

            if (funcionariosLista.Count > 0)
            {
                //Cálculo da quantidade total de páginas
                int totalPaginas = 1;
                int totalLinhas = funcionariosLista.Count;
                if (totalLinhas > 24)
                    totalPaginas += (int)Math.Ceiling((totalLinhas - 24) / 29F);


                //Configuração do documento PDF
                var pxPorMm = 72 / 25.2F;
                var pdf = new Document(PageSize.A4, 15 * pxPorMm, 15 * pxPorMm,
                    15 * pxPorMm, 20 * pxPorMm);

                //Configuração do nome do arquivo
                var nomeArquivo = $"Funcionarios.{DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss")}.pdf";

                //Criação do objeto que representa o arquivo
                var arquivo = new FileStream(nomeArquivo, FileMode.Create);

                //Associação do documento PDF que está sendo criado ao arquivo que está sendo criado (tudo que for feito no documento PDF, será salvo no arquivo)
                var writer = PdfWriter.GetInstance(pdf, arquivo);

                writer.PageEvent = new EventosDePagina(totalPaginas);

                //Inicialização do objeto para que ele possa receber conteúdo
                pdf.Open();
  
                //Adição do título
                var fonteParagrafo = new iTextSharp.text.Font(fonteBase, 15,
                    iTextSharp.text.Font.BOLD, BaseColor.Black);
                var titulo = new Paragraph("Relatório de Funcionários\n\n", fonteParagrafo);
                titulo.SpacingAfter = 4;
                pdf.Add(titulo);

                //Adição da logo
                var caminhoImagem = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "crmauto.jpg");

                if (File.Exists(caminhoImagem))
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(caminhoImagem);
                    float razaoAlturaLargura = logo.Width / logo.Height;
                    float alturaLogo = 35;
                    float larguraLogo = alturaLogo * razaoAlturaLargura;
                    logo.ScaleToFit(larguraLogo, alturaLogo);
                    var margemEsquerda = pdf.PageSize.Width - pdf.RightMargin - larguraLogo;
                    var margemTopo = pdf.PageSize.Height - pdf.TopMargin - 35;
                    logo.SetAbsolutePosition(margemEsquerda, margemTopo);
                    writer.DirectContent.AddImage(logo, false);
                }

                //Adição da tabela de dados
                var tabela = new PdfPTable(5);
                float[] largurasColunas = { 0.7f, 1.9f, 1.9f, 1.9f, 2.9f };
                tabela.SetWidths(largurasColunas);
                tabela.DefaultCell.BorderWidth = 0;
                tabela.WidthPercentage = 100;

                //Adição das células de títulos das colunas
                CriarCelula(tabela, "ID", PdfCell.ALIGN_CENTER, true);
                CriarCelula(tabela, "Nome", PdfCell.ALIGN_LEFT, true);
                CriarCelula(tabela, "Função", PdfCell.ALIGN_LEFT, true);
                CriarCelula(tabela, "Nome da oficina", PdfCell.ALIGN_LEFT, true);
                CriarCelula(tabela, "E-mail", PdfCell.ALIGN_LEFT, true);

                foreach (var funcionario in funcionariosLista)
                {
                    CriarCelula(tabela, funcionario.Id_funcionario.ToString(), PdfCell.ALIGN_CENTER, true);
                    CriarCelula(tabela, funcionario.Nome.ToString());
                    CriarCelula(tabela, funcionario.Funcao.ToString());
                    CriarCelula(tabela, funcionario.Nome_oficina.ToString());
                    CriarCelula(tabela, funcionario.Login_usuario.ToString());
                }

                pdf.Add(tabela);

                pdf.Close();
                arquivo.Close();

                //Abre o PDF no visualizador padrão
                if (File.Exists(nomeArquivo))
                {
                    Process.Start(new ProcessStartInfo()
                    {
                        Arguments = $"/c start {nomeArquivo}",
                        FileName = "cmd.exe",
                        CreateNoWindow = true
                    });
                }
            }
        }

        public void CriarCelula(PdfPTable tabela, string texto, int alinhamentoHorizontal = PdfPCell.ALIGN_LEFT,
            bool negrito = false, bool italico = false, int tamanhoFonte = 10, int alturaCelula = 25)

        {
            int estilo = iTextSharp.text.Font.NORMAL;
            if (negrito && italico)
            {
                estilo = iTextSharp.text.Font.BOLDITALIC;
            }
            else if (negrito)
            {
                estilo = iTextSharp.text.Font.BOLD;
            }
            else if (italico)
            {
                estilo = iTextSharp.text.Font.ITALIC;
            }

            var fonteCelula = new iTextSharp.text.Font(fonteBase, tamanhoFonte,
                    estilo, BaseColor.Black);

            var bgColor = iTextSharp.text.BaseColor.White;
            if (tabela.Rows.Count % 2 == 1)
                bgColor = new BaseColor(0.95f, 0.95f, 0.95f);

            var celula = new PdfPCell(new Phrase(texto, fonteCelula));
            celula.HorizontalAlignment = alinhamentoHorizontal;
            celula.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            celula.Border = 0;
            celula.BorderWidthBottom = 1;
            celula.FixedHeight = alturaCelula;
            celula.PaddingBottom = 5;
            celula.BackgroundColor = bgColor;
            tabela.AddCell(celula);
            
        }
    }
}
