using iTextSharp.text;
using iTextSharp.text.pdf;
using System;

namespace CRM_Auto.Models
{
    public class EventosDePagina : PdfPageEventHelper
    {
        private BaseFont fonteBaseRodape { get; set; }
        private iTextSharp.text.Font fonteRodape { get; set; }
        public int totalPaginas { get; set; }

        public EventosDePagina(int totalPaginas)
        {
            fonteBaseRodape = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            fonteRodape = new iTextSharp.text.Font(fonteBaseRodape, 8f,
                iTextSharp.text.Font.NORMAL, BaseColor.Black);

            this.totalPaginas = totalPaginas;
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);
            var textoMomentoGeracao = $"Gerado em {DateTime.Now.ToShortDateString()} às " +
                $"{DateTime.Now.ToShortTimeString()}";

            writer.DirectContent.BeginText();
            writer.DirectContent.SetFontAndSize(fonteRodape.BaseFont, fonteRodape.Size);
            writer.DirectContent.SetTextMatrix(document.LeftMargin, document.BottomMargin * 0.75f);
            writer.DirectContent.ShowText(textoMomentoGeracao);
            writer.DirectContent.EndText();

            AdicionarNumeroDasPaginas(writer, document);
        }

        private void AdicionarNumeroDasPaginas(PdfWriter writer, Document document)
        {
            int paginaAtual = writer.PageNumber;
            var textoPaginacao = $"Página {paginaAtual} de {totalPaginas}";

            float larguraTextoPaginacao = fonteBaseRodape.GetWidthPoint(textoPaginacao, fonteRodape.Size);
            var tamanhoPagina = document.PageSize;

            writer.DirectContent.BeginText();
            writer.DirectContent.SetFontAndSize(fonteRodape.BaseFont, fonteRodape.Size);
            writer.DirectContent.SetTextMatrix(tamanhoPagina.Width - document.RightMargin - larguraTextoPaginacao,
                document.BottomMargin * 0.75f);
            writer.DirectContent.ShowText(textoPaginacao);
            writer.DirectContent.EndText();
        }

    }
}
