
# Projeto de Interface

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Visão geral da interação do usuário pelas telas do sistema e protótipo interativo das telas com as funcionalidades que fazem parte do sistema (wireframes).

 Apresente as principais interfaces da plataforma. Discuta como ela foi elaborada de forma a atender os requisitos funcionais, não funcionais e histórias de usuário abordados nas <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a>.

## Diagrama de Fluxo

O diagrama apresenta o estudo do fluxo de interação do usuário com o sistema interativo e  muitas vezes sem a necessidade do desenho do design das telas da interface. Isso permite que o design das interações seja bem planejado e gere impacto na qualidade no design do wireframe interativo que será desenvolvido logo em seguida.

<p align="center">
  <img src="https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/Fluxo%20-%20Oficina.png">
</p>
<p align="center">Figura 1 - Diagrama de fluxo - Oficina</p>


<p align="center">
  <img src="https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/Fluxo%20-%20Cliente.png">
</p>
<p align="center">Figura 2 - Diagrama de fluxo - Cliente</p>


> **Links Úteis**:
> - [Fluxograma online: seis sites para fazer gráfico sem instalar nada | Produtividade | TechTudo](https://www.techtudo.com.br/listas/2019/03/fluxograma-online-seis-sites-para-fazer-grafico-sem-instalar-nada.ghtml)

## Fluxo do Usuário
O diagrama apresentado na Figura 3 mostra o fluxo de interação do usuário pelas telas do sistema. Cada uma das telas deste fluxo é detalhada na seção de Wireframes que se segue. Para visualizar o wireframe interativo, acesse o ambiente MarvelApp do projeto.

## Wireframes

Conforme fluxo de telas do projeto, apresentado no item anterior, as telas do sistema são apresentadas em detalhes nos itens que se seguem. As telas do sistema apresentam uma estrutura comum que é apresentada na Figura 4. Nesta estrutura, existem 3 grandes blocos, descritos a seguir. São eles:

> -	Cabeçalho - local onde são dispostos elementos fixos de identidade (logo) e navegação principal do site (menu da aplicação);
> -	Conteúdo - apresenta o conteúdo da tela em questão;
> -	Barra lateral - apresenta os elementos de navegação secundária, geralmente associados aos elementos do bloco de conteúdo.

<p align="center">
  <img src="/docs/img/lyt01_Tamplate.PNG" width="380" alt="Estrutura do site"/>
  <p align="center">Estrutura padrão do sistema</p>
</p>

## Tela - Oção de login

A tela de acesso ao sistema foi desenvolvida para permitir que tanto o funcionário da oficina e o cliente da mesma tenham acesso ao sistema. Cada um terá um acesso limitado de acordo com as suas credenciais configuradas no sistema.

<p align="center">
  <img src="/docs/img/lyt02_opcao_login.PNG" width="380" alt="Estrutura do site"/>
  <p align="center">Opção de acesso ao sistema</p>
</p>

## Tela - Login de usuários

No momento que o funcionário da oficina, ou o cliente acessarem o endereço do site, lhes será dado a opção de acessar o sistema como colaborador ou cliente. O cliente terá acesso limitado ao sistema, de forma que ele visualizará somente àquilo que lhe compete.

<p align="center">
  <img src="/docs/img/lyt04_login_colaborador.PNG" width="380" alt="Estrutura do site"/>
  <p align="center">Tela de login dos usuários</p>
</p>

## Tela - Acompanhamento de ordens de serviços

Na tela de acompanhamento de ordens de serviços estarão todas as ordens de serviços em abertos. Selecionando uma OS, o sistema mostra o detalhamento da OS e o seu orçamento, se existir.

<p align="center">
  <img src="/docs/img/lyt08_lista_os.PNG" width="380" alt="Estrutura do site"/>
  <p align="center">Módulo de acompamanhamento das ordens de serviços</p>
</p>

## Tela - Lista de clientes

Através do menu, é possível acessar a opção clientes para listar todos os clientes e acessar todas as informações necessárias como: cadastro, veículos, serviços realizados, faturamentos e etc.

<p align="center">
  <img src="/docs/img/lyt06_lista_cliente.PNG" width="380" alt="Lista de clientes"/>
  <p align="center">Cadastro de oficina</p>
</p>

## Tela - Cadasto de clientes

Assim que o colaborador receber o veículo do cliente, será necessário fazer um cadastro do mesmo informando dados básicos para faturamento do serviço.

<p align="center">
  <img src="/docs/img/lyt05_cadastro_cliente.PNG" width="380" alt="Cadastro de clientes"/>
  <p align="center">Cadastro de clientes</p>
</p>

## Tela - Cadasto de veículos por clientes

Após efetuar o cadastro inicial do cliente, deve-se cadastrar também o seu veículo utiizando a tela de cadastro de veículos que poderá ser acessada diretamente do cadastro do cliente ou pelo menu lateral da janela do sistema.

<p align="center">
  <img src="/docs/img/lyt05_cadastro_cliente.PNG" width="380" alt="Cadastro de veículos"/>
  <p align="center">Cadastro de veículos</p>
</p>

## Tela - Cadasto de oficina

O sistema permitirá cadastrar mais de uma oficina de uma rede. Assim, o sistema poderá concentrar a movimentação de toda a sua rede em uma única base de dados.

<p align="center">
  <img src="/docs/img/lyt09_cadastro_oficina.PNG" width="380" alt="Cadastro de oficina"/>
  <p align="center">Cadastro de oficina</p>
</p>

## Tela - Ordem de serviço

Com o cliente e veículo cadastrado no sistema, a ordem de serviço poderá ser registrada no sistema pelo módulo Ordem de Serviço. Nele, o colaborador poderá incluir os serviços solicitados pelo cliente e orçar as peças a serem usadas nos serviços.

<p align="center">
  <img src="/docs/img/lyt10_ordem_servico.png" width="380" alt="Ordem de serviço"/>
  <p align="center">Abertura de ordem de serviço</p>
</p>

## Tela - Ordem de serviço (cliente)

Este modulo permitirá que o cliente acesse a sua ordem de serviço aberta para conferência dos serviços solicitados.

O cliente terá acesso também ao histórico de todas as suas solicitações no passado: serviços solicitado, pagamentos realizados e etc.

<p align="center">
  <img src="/docs/img/lyt11_ordem_servico_cliente.png" width="600px;" alt="Ordem de serviço"/>
  <p align="center">Ordem de serviço (cliente)</p>
</p>

São protótipos usados em design de interface para sugerir a estrutura de um site web e seu relacionamentos entre suas páginas. Um wireframe web é uma ilustração semelhante do layout de elementos fundamentais na interface.
 
> **Links Úteis**:
> - [Protótipos vs Wireframes](https://www.nngroup.com/videos/prototypes-vs-wireframes-ux-projects/)
> - [Ferramentas de Wireframes](https://rockcontent.com/blog/wireframes/)
> - [MarvelApp](https://marvelapp.com/developers/documentation/tutorials/)
> - [Figma](https://www.figma.com/)
> - [Adobe XD](https://www.adobe.com/br/products/xd.html#scroll)
> - [Axure](https://www.axure.com/edu) (Licença Educacional)
> - [InvisionApp](https://www.invisionapp.com/) (Licença Educacional)
