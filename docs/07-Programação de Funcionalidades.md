# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descritas por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos os artefatos criados (código fonte) além das estruturas de dados utilizadas e as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

Para cada requisito funcional, pode ser entregue um artefato desse tipo.

| | Login de colaborador
---|---
Requisitos Associados| RF-01: O sistema deve permitir que um colaborador cadastrado faça login. 
Objetivo da Funcionalidade | Implementação realizada para permitir que um colaborador faça login no sistema
Artefatos MVC | • **Model:** UsuarioModel <br>• **View:** LoginColaborador <br>• **Controller:** OficinaController
Tabelas de banco de dados associadas | [CRM_AUTO].[dbo].[USUARIO]

| | Login de cliente
---|---
Requisitos Associados| RF-02: O sistema deve permitir que um cliente cadastrado faça login. 
Objetivo da Funcionalidade | Implementação realizada para permitir que um cliente cadastrado faça login no sistema
Artefatos MVC | • **Model:** UsuarioModel <br>• **View:** LoginCliente <br>• **Controller:** ClienteController
Tabelas de banco de dados associadas | [CRM_AUTO].[dbo].[USUARIO]

| | Inserção, alteração e exclusão de funcionários
---|---
Requisitos Associados| RF-03: O sistema deve permitir a inserção, alteração e exclusão dos dados dos funcionários
Objetivo da Funcionalidade | Implementação realizada para permitir a inclusão de um novo funcionário e a alteração e exclusão de dados de um funcionário já cadastrado
Artefatos MVC | • **Model:** FuncionarioModel <br>• **View:** CadastroDeFuncionario <br>• **Controller:** OficinaController
Tabelas de banco de dados associadas | [CRM_AUTO].[dbo].[FUNCIONARIO]

| | Emissão de relatório
---|---
Requisitos Associados| RF-04: O sistema deve permitir a emissão de relatório contendo as informações dos funcionários.
Objetivo da Funcionalidade | Implementação realizada para permitir a emissão de relatórios em .pdf contendo as informações dos funcionários cadastrados em cada oficina
Artefatos MVC | • **Model:** FuncionarioModel <br>• **View:** CadastroDeFuncionario <br>• **Controller:** OficinaController
Tabelas de banco de dados associadas | [CRM_AUTO].[dbo].[FUNCIONARIO]

| | Inserção, alteração e exclusão de clientes
---|---
Requisitos Associados| RF-05: O sistema deve permitir a inserção, alteração e exclusão dos dados dos clientes.
Objetivo da Funcionalidade | Implementação realizada para permitir a inclusão de um novo cliente e a alteração e exclusão de dados de um cliente já cadastrado
Artefatos MVC | • **Model:** ClienteModel <br>• **View:** CadastroCliente <br>• **Controller:** ClienteController
Tabelas de banco de dados associadas | [CRM_AUTO].[dbo].[CLIENTE]

| | Inserção e alteração de oficinas
---|---
Requisitos Associados| RF-06: O sistema deve permitir o cadastro e a alteração de oficinas.
Objetivo da Funcionalidade | Implementação realizada para permitir a inclusão de uma nova oficina e a alteração de dados de uma oficina já cadastrada
Artefatos MVC | • **Model:** OficinaModel <br>• **View:** CadastroDeOficina <br>• **Controller:** OficinaController
Tabelas de banco de dados associadas | [CRM_AUTO].[dbo].[OFICINA]

| | Inserção de um novo serviço
---|---
Requisitos Associados| RF-07: O sistema deve permitir o cadastro de um novo serviço disponibilizado pelas oficinas.
Objetivo da Funcionalidade | Implementação realizada para permitir a inclusão de um novo serviço disponibilizado pelas oficinas
Artefatos MVC | • **Model:** ServicoModel <br>• **View:** Servicos <br>• **Controller:** OficinaController
Tabelas de banco de dados associadas | [CRM_AUTO].[dbo].[SERVICO]

| | Consulta de clientes
---|---
Requisitos Associados| RF-08: O sistema deve permitir a consulta dos clientes cadastrados.
Objetivo da Funcionalidade | Implementação realizada para permitir a consulta dos clientes cadastrados
Artefatos MVC | • **Model:** ClienteModel <br>• **View:** CadastroCliente <br>• **Controller:** ClienteController
Tabelas de banco de dados associadas | [CRM_AUTO].[dbo].[CLIENTE]

| | Cadastro de veículos
---|---
Requisitos Associados| RF-09: O sistema deve permitir o cadastro de veículo (s) para o cliente.
Objetivo da Funcionalidade | Implementação realizada para permitir o cadastro de veículos para os clientes da oficina
Artefatos MVC | • **Model:** VeiculoModel <br>• **View:** CadastroVeiculo <br>• **Controller:** OficinaController
Tabelas de banco de dados associadas | [CRM_AUTO].[dbo].[VEICULO]

| | Acompanhamento do serviço pelo cliente
---|---
Requisitos Associados| RF-10: O sistema deve permitir o acompanhamento do andamento de um serviço pelo cliente e a data prevista para finalização.
Objetivo da Funcionalidade | Implementação realizada para permitir ao cliente acompanhar o andamento do seu serviço
Artefatos MVC | • **Model:** DetalhamentoModel e OrdemServico <br>• **View:** ConsultaServico <br>• **Controller:** ClienteController
Tabelas de banco de dados associadas | [CRM_AUTO].[dbo].[DETALHE_OS]<br> [CRM_AUTO].[dbo].[ORDEM_SERVICO]

| | Criação de ordens de serviços
---|---
Requisitos Associados| RF-13: O sistema deve permitir que o colaborador crie ordens de serviço
Objetivo da Funcionalidade | Implementação realizada para permitir a criação de uma nova ordem de serviço
Artefatos MVC | • **Model:** DetalhamentoModel e OrdemServico <br>• **View:** OrdemServico <br>• **Controller:** OficinaController
Tabelas de banco de dados associadas | [CRM_AUTO].[dbo].[DETALHE_OS]<br> [CRM_AUTO].[dbo].[ORDEM_SERVICO]

| | Edição de ordens de serviços
---|---
Requisitos Associados| RF-14: O sistema deve permitir que o colaborador edite informações de uma ordem de serviço existente
Objetivo da Funcionalidade | Implementação realizada para permitir a edição de uma ordem de serviço já cadastrada
Artefatos MVC | • **Model:** DetalhamentoModel e OrdemServico <br>• **View:** EditarOS <br>• **Controller:** OficinaController
Tabelas de banco de dados associadas | [CRM_AUTO].[dbo].[DETALHE_OS]<br> [CRM_AUTO].[dbo].[ORDEM_SERVICO]

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)
