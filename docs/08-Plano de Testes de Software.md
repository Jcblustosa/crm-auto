# Plano de Testes de Software


A seguir, apresentamos os casos de testes de software para avaliação do sistema. Todos os testes estão associados a um ou mais requisitos funcionais. 

Caso de Teste | CT-01: Cadastro de cliente da oficina
---|---
Requisitos Associados | RF-05: O sistema deve permitir a inserção, alteração e exclusão dos dados dos clientes. 
Objetivo do Teste | Verificar se as funções Incluir/Excluir/Alterar estão operando corretamente.
Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>2.	Ir para a tela de manutenção; <br>3.	Incluir/Excluir/Alterar dados de funcionário/cliente.
Critérios de Êxito | •	As funções de Incluir, Excluir e Alterar dados devem <br> •	Acessar e modificar os dados de funcionário/cliente na base de dados; <br> •	Os dados alterados na base de dados devem ser atualizados na página de manutenção.

Caso de Teste | CT-02: Cadastro de oficinas no sistema
---|---
Requisitos Associados | RF-06: O sistema deve permitir o cadastro, alteração e exclusão de oficinas.
Objetivo do Teste | Verificar se o funcionário é capaz de cadastrar novas oficinas.
Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>	2.	Ir para a página de Menu; <br>3.	Selecionar a opção de Cadastrar Oficina; <br>4.	Inserir os dados da nova oficina.
Critérios de Êxito | •	Depois de preencher o formulário com os dados da nova oficina, o sistema deve informar se ela foi criada com sucesso ou não; <Br> •	Novas tabelas devem ser criadas no banco de dados, referentes à nova oficina.
 
Caso de Teste | CT-03: Cadastro de veículo de cliente
---|---
Requisitos Associados | RF-09: O sistema deve permitir o cadastro de veículo (s) para o cliente.
Objetivo do Teste | Verificar se o Gestor e Funcionário são capazes de cadastrar um novo veículo no sistema, associando-o a um cliente.
Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>	2.	Ir para a página de Menu; <br>3.	Selecionar a opção de Cadastrar Veículo; <br>4.	Preencher as informações do formulário.
Critérios de Êxito | •	Depois de cadastrar o veículo, suas informações devem aparecer ao se consultar o perfil do dono (cliente); <br>•	O cadastro do veículo deve ser feito também no banco de dados do sistema.
 
Caso de Teste | CT-04: Processo de manutenção
---|---
Requisitos Associados | RF-10: O sistema deve permitir a inserção, alteração e exclusão das informações sobre o andamento de um determinado serviço.
Objetivo do Teste | Verificar se o Gestor e Funcionário são capazes de inserir, alterar ou excluir informações do processo que descreve o andamento da manutenção do veículo.
Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>	2.	Ir para a página de Menu; <br>3.	Selecionar a opção Processos em Andamento; <br>4.	Selecionar um processo para ser visualizado; <br>5.	Editar o processo.
Critérios de Êxito | •	Ao editar as informações do processo de manutenção, as informações atualizadas deverão aparecer para o Gestor/Funcionário; <br>•	As informações atualizadas deverão aparecer para o Cliente.
 
Caso de Teste | CT-05: Visualização do processo de manutenção
---|---
Requisitos Associados | RF-11: O sistema deve permitir o acompanhamento do andamento de um serviço e a data prevista para finalização.
Objetivo do Teste | Verificar se o Cliente é capaz de visualizar a descrição do andamento da manutenção.
Passos | 1.	Fazer login no sistema com uma conta de Cliente; <br>	2.	Ir para a página de Menu; <br>3.	Selecionar a opção Processos em Andamento; <br>4.	Selecionar um processo para ser visualizado.
Critérios de Êxito | •	Ao abrir a página de Processo, uma descrição detalhada com informação a respeito de serviços e data prevista deverá aparecer para o Cliente.
 
 Caso de Teste | CT-06: Login de colaborador
---|---
Requisitos Associados | RF-01: O sistema deve permitir que um colaborador cadastrado faça login.
Objetivo do Teste | Verificar se o colaborador é capaz de realizar login no sistema.
Passos | 1.	Executar a aplicação; <br>	2.	Clicar no botão "Sou colaborador da empresa"; <br>3.	Preencher os campos Login e Senha; <br>4.	Clicar em Log in.
Critérios de Êxito | •	Se o registro de usuário existir no banco de dados, o sistema deve permitir que o funcionário acesse a página de menu principal da oficina. Caso as informações de Login e Senha estejam incorretas, a página de login é recarregada para que os campos sejam preenchidos novamente.

Caso de Teste | CT-07: Login de cliente da oficina
---|---
Requisitos Associados | RF-02: O sistema deve permitir que um cliente cadastrado faça login.
Objetivo do Teste | Verificar se o cliente é capaz de realizar login no sistema.
Passos | 1.	Executar a aplicação; <br>	2.	Clicar no botão "Sou cliente"; <br>3.	Preencher os campos Login e Senha; <br>4.	Clicar em Entrar.
Critérios de Êxito | •	Se o registro de usuário existir no banco de dados, o sistema deve permitir que o cliente acesse a página de cliente da oficina. Caso as informações de Login e Senha estejam incorretas, a página de login é recarregada para que os campos sejam preenchidos novamente.
 
 Caso de Teste | CT-08: Consulta e alteração de dados de cliente da oficina
---|---
Requisitos Associados | RF-05: O sistema deve permitir a inserção, alteração e exclusão dos dados dos clientes.
Objetivo do Teste | Verificar se o sistema permite ao funcionário visualizar e alterar dados de um cliente quando necessário.
Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>2.	Ir para a tela de cadastro de clientes; <br>3.	Escolher a opção "Clientes" na barra lateral; <br>4. Buscar cliente pelo nome; <br>5. Alterar dados de cliente; <br>6. Salvar
Critérios de Êxito | •	Os dados de cliente deverão ser exibidos para o funcionário <br> •	Os dados alterados deverão ser atualizados na base de dados.
 
 Caso de Teste | CT09: Cadastro de funcionário
---|---
Requisitos Associados | RF-03: O sistema deve permitir a inserção, alteração e exclusão dos dados dos funcionários.
Objetivo do Teste | Garantir que o sistema permite a inclusão do cadastro de um novo funcionário para determinada oficina
Passos | 1.	Executar a aplicação <br>	2.	Fazer login no sistema <br>3.	No painel de controle, selecionar a opção Menu Funcionários <br>4. Clicar no botão "Novo funcionário"<br>5. Preencher corretamente o formulário de cadastro<br>6. Clicar em Inserir
Critérios de Êxito | •	Se as informações forem preenchidas corretamente, o sistema deve apresentar ao usuário uma mensagem de sucesso relativa à inserção do funcionário. Após a inserção ser efetuada, as informações inseridas no formulário devem ser registradas no banco de dados na tabela [CRM_AUTO].[dbo].[FUNCIONARIO].
 
  Caso de Teste | CT-10: Alteração de funcionário
---|---
Requisitos Associados | RF-03: O sistema deve permitir a inserção, alteração e exclusão dos dados dos funcionários.
Objetivo do Teste | Garantir que o sistema permite a alteração do cadastro de um funcionário da oficina
Passos | 1.	Executar a aplicação <br>	2.	Fazer login no sistema <br>3.	No painel de controle, selecionar a opção Menu Funcionários <br>4. Clicar no botão para editar as informações de um funcionário<br>5. Preencher corretamente o formulário de alteração com os novos dados<br>6. Clicar em Alterar
Critérios de Êxito | •	Se as informações forem preenchidas corretamente, o sistema deve apresentar ao usuário uma mensagem de sucesso relativa à alteração do funcionário. Após a alteração ser efetuada, as informações do usuário devem ser atualizadas na tabela [CRM_AUTO].[dbo].[FUNCIONARIO].
 
   Caso de Teste | CT-11: Exclusão de funcionário
---|---
Requisitos Associados | RF-03: O sistema deve permitir a inserção, alteração e exclusão dos dados dos funcionários.
Objetivo do Teste | Garantir que o sistema permite a exclusão do cadastro de um funcionário da oficina
Passos | 1.	Executar a aplicação <br>	2.	Fazer login no sistema <br>3.	No painel de controle, selecionar a opção Menu Funcionários <br>4. Clicar no botão para editar as informações de um funcionário<br>5. Validar as informações carregadas automaticamente do funcionário que deseja excluir<br>6. Clicar em Excluir
Critérios de Êxito | •	Após clicar em excluir, o sistema deve apresentar ao usuário uma mensagem de sucesso relativa à exclusão do funcionário. Após a exclusão ser efetuada, o registro do funcionário deve ser excluído na tabela [CRM_AUTO].[dbo].[FUNCIONARIO].
 
 Caso de Teste | CT-12: Emissão de relatório dos Funcionários
---|---
Requisitos Associados | RF-04: O sistema deve permitir a emissão de relatório contendo as informações dos funcionários. <br>
Objetivo do Teste | Verificar se o relatório de funcionários está sendo gerado corretamente.
Passos | 1.	Executar a aplicação <br>	2.	Fazer login no sistema <br>3.	No painel de controle, selecionar a opção Menu Funcionários <br>4. Clicar no ícone "Relatórios"
Critérios de Êxito | •	O sistema deve gerar um arquivo em formato .pdf contendo as informações dos funcionários em uma tabela. O relatório deve conter também a data e hora de geração do arquivo.
 
 Caso de Teste | CT-13: Cadastro de serviços da oficina
---|---
Requisitos Associados | RF-07: O sistema deve permitir o cadastro, alteração e exclusão dos serviços disponibilizados pelas oficinas.
Objetivo do Teste | Garantir que o sistema permite a inclusão do cadastro de um novo serviço para as oficinas
Passos | 1.	Executar a aplicação <br>	2.	Fazer login no sistema <br>3.	No painel de controle, selecionar a opção Menu Serviços <br>4. Clicar no botão "Novo serviço"<br>5. Preencher corretamente o formulário de cadastro<br>6. Clicar em Inserir
Critérios de Êxito | •	Se as informações forem preenchidas corretamente, o sistema deve apresentar ao usuário uma mensagem de sucesso relativa à inserção do serviço. Após a inserção ser efetuada, as informações inseridas no formulário devem ser registradas no banco de dados na tabela [CRM_AUTO].[dbo].[SERVICO].
 
  Caso de Teste | CT-14: Cadastro de ordem de serviço
---|---
Requisitos Associados | RF-14: O sistema deve permitir que o colaborador crie ordens de serviço.
Objetivo do Teste | Garantir que o sistema permita a criação de uma ordem de serviço no cpf de um cliente da oficina
Passos | 1.	Executar a aplicação <br>	2.	Fazer login no sistema <br>3.	Escolher a opção "Nova O.S." <br>4. Preencher os dados do formulário <br>5. Clicar em Salvar<br>
Critérios de Êxito | •	Se as informações forem preenchidas corretamente, o sistema deve apresentar ao usuário uma mensagem de sucesso relativa à criação da O.S. Todas as informações inseridas no formulário devem ser registradas no banco de dados na tabela [CRM_AUTO].[dbo].[ORDEM_SERVICO].
 
   Caso de Teste | CT-15: Edição de ordem de serviço
---|---
Requisitos Associados | RF-15: O sistema deve permitir que o colaborador edite informações de uma ordem de serviço existente.
Objetivo do Teste | Garantir que o sistema permita a edição de uma ordem de serviço existente.
Passos | 1.	Executar a aplicação <br>	2.	Fazer login no sistema <br>3.	Escolher a opção "Editar" ao lado da ordem de serviço escolhida <br>4. Preencher os dados do formulário <br>5. Clicar em Salvar<br>
Critérios de Êxito | •	Se as informações forem preenchidas corretamente, o sistema deve apresentar ao usuário uma mensagem de sucesso relativa à edição da O.S. Todas as informações inseridas no formulário devem ser registradas no banco de dados na tabela [CRM_AUTO].[dbo].[ORDEM_SERVICO].
 
## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
