# Plano de Testes de Software


A seguir, apresentamos os casos de testes de software para avaliação do sistema. Todos os testes estão associados a um ou mais requisitos funcionais. 

Caso de Teste | CT-01: Cadastro de cliente da oficina
---|---
Requisitos Associados | RF-01: Incluir/Excluir/Alterar dados em uma tela de manutenção de funcionário e do cliente da oficina. 
Objetivo do Teste | Verificar se as funções Incluir/Excluir/Alterar estão operando corretamente.
Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>2.	Ir para a tela de manutenção; <br>3.	Incluir/Excluir/Alterar dados de funcionário/cliente.
Critérios de Êxito | •	As funções de Incluir, Excluir e Alterar dados devem <br> •	Acessar e modificar os dados de funcionário/cliente na base de dados; <br> •	Os dados alterados na base de dados devem ser atualizados na página de manutenção.

Caso de Teste | CT-02: Emissão de relatório de cliente
---|---
Requisitos Associados | RF-02: Emissão de relatórios de clientes. <br>RF-09: Consultar os clientes cadastrados no sistema.
Objetivo do Teste | Verificar se os relatórios de clientes estão sendo gerados corretamente.
Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>2.	Ir para a tela de menu; <br>	3.	Escolher a opção de Emissão de Relatório de Cliente.
Critérios de Êxito | •	Ao escolher a função de Emissão de Relatório de Cliente, o site deve iniciar o carregamento de um arquivo .pdf para download.

Caso de Teste | CT-03: Consulta de saldo ou estoque.
---|---
Requisitos Associados | RF-04: Consulta de saldo ou estoque.
Objetivo do Teste | Verificar se é possível o gestor e funcionário consultarem o estoque de materiais da oficina.
Passos | 1.	Fazer login no sistema com uma conta de Gestor/Funcionário; <br>2.	Ir para a tela de menu; <br>3.	Escolher a opção Consultar Estoque; <br>4. Especificar a peça que se quer consultar.
Critérios de Êxito | •	Ao escolher a função de Consultar Estoque, uma página de consulta deve ser aberta; <br>•	Depois de digitar o nome ou identificador da peça, o site deve apresentar seus dados (e.g.: nome ou imagem), incluindo a quantidade em estoque.

Caso de Teste | CT-04: Cadastro de tarefas pelo cliente.
---|---
Requisitos Associados | RF-05: Permitir que o usuário cadastre tarefas.
Objetivo do Teste | Verificar se é possível que o cliente solicite novos serviços de maneira online.
Passos | 1.	Fazer login no sistema com uma conta de Cliente; <br>2.	Ir para a tela de menu; <br>	3.	Escolher a opção de Adicionar Tarefa; <br> 4.	Especificar o serviço solicitado.
Critérios de Êxito | •	Ao especificar o serviço solicitado, uma mensagem de sucesso ou de falha deve ser exibida ao usuário.

Caso de Teste | CT-05: Emissão de lembrete anual
---|---
Requisitos Associados | RF-06: Emitir lembretes após passarem-se 11 meses desde a última revisão anual.
Objetivo do Teste | Verificar se o lembrete é enviado corretamente na data prevista.
Passos | 1.	Definir, no sistema, uma data e hora específicas para o lembrete ser enviado; <br>	2.	Fazer login no sistema com uma conta de Cliente na data e hora especificadas.
Critérios de Êxito | •	Na data e hora especificadas, um lembrete deve aparecer na tela inicial do Cliente.

Caso de Teste | CT-06: Cadastro de oficinas no sistema
---|---
Requisitos Associados | RF-07: Efetuar o cadastro, alteração e exclusão de oficinas no sistema.
Objetivo do Teste | Verificar se o Gestor é capaz de cadastrar novas oficinas em seu nome.
Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>	2.	Ir para a página de Menu; <br>3.	Selecionar a opção de Cadastrar Oficina; <br>4.	Inserir os dados da nova oficina.
Critérios de Êxito | •	Depois de preencher o formulário com os dados da nova oficina, o sistema deve informar se ela foi criada com sucesso ou não; <Br> •	Novas tabelas devem ser criadas no banco de dados, referentes à nova oficina.
 
Caso de Teste | CT-07: Serviços da oficina
---|---
Requisitos Associados | RF-08: Efetuar o cadastro, alteração e exclusão dos serviços disponibilizados pela oficina.
Objetivo do Teste | Verificar se o Gestor é capaz de cadastrar, alterar e excluir os serviços disponibilizados pela oficina.
Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>	2.	Ir para a página de Menu; <br>3.	Selecionar a opção de Serviços; <br>4.	Escolher a função Cadastrar/Alterar/Excluir Serviço.
Critérios de Êxito | •	Depois de cadastrar, alterar ou excluir um serviço da oficina, o site deve apresentar esse serviço na página de serviços da oficina.
 
Caso de Teste | CT-08: Cadastro de veículo de cliente
---|---
Requisitos Associados | RF-10: Realizar o cadastro de veículo (s) para um determinado cliente no sistema.
Objetivo do Teste | Verificar se o Gestor e Funcionário são capazes de cadastrar um novo veículo no sistema, associando-o a um cliente.
Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>	2.	Ir para a página de Menu; <br>3.	Selecionar a opção de Cadastrar Veículo; <br>4.	Preencher as informações do formulário.
Critérios de Êxito | •	Depois de cadastrar o veículo, suas informações devem aparecer ao se consultar o perfil do dono (cliente); <br>•	O cadastro do veículo deve ser feito também no banco de dados do sistema.
 
Caso de Teste | CT-09: Processo de manutenção
---|---
Requisitos Associados | RF-11: Inserir, alterar e excluir informações sobre o andamento de um determinado serviço no sistema.
Objetivo do Teste | Verificar se o Gestor e Funcionário são capazes de inserir, alterar ou excluir informações do processo que descreve o andamento da manutenção do veículo.
Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>	2.	Ir para a página de Menu; <br>3.	Selecionar a opção Processos em Andamento; <br>4.	Selecionar um processo para ser visualizado; <br>5.	Editar o processo.
Critérios de Êxito | •	Ao editar as informações do processo de manutenção, as informações atualizadas deverão aparecer para o Gestor/Funcionário; <br>•	As informações atualizadas deverão aparecer para o Cliente.
 
Caso de Teste | CT-10: Visualização do processo de manutenção
---|---
Requisitos Associados | RF-12: Acompanhar o andamento do serviço solicitado à oficina e a data prevista para finalização.
Objetivo do Teste | Verificar se o Cliente é capaz de visualizar a descrição do andamento da manutenção.
Passos | 1.	Fazer login no sistema com uma conta de Cliente; <br>	2.	Ir para a página de Menu; <br>3.	Selecionar a opção Processos em Andamento; <br>4.	Selecionar um processo para ser visualizado.
Critérios de Êxito | •	Ao abrir a página de Processo, uma descrição detalhada com informação a respeito de serviços e data prevista deverá aparecer para o Cliente.
 
 Caso de Teste | CT-11: Login de colaborador
---|---
Requisitos Associados | RF-13: O sistema deve permitir o login de colaborador da oficina.
Objetivo do Teste | Verificar se o colaborador é capaz de realizar login no sistema.
Passos | 1.	Executar a aplicação; <br>	2.	Clicar no botão "Sou colaborador da empresa"; <br>3.	Preencher os campos Login e Senha; <br>4.	Clicar em Log in.
Critérios de Êxito | •	Se o registro de usuário existir no banco de dados, o sistema deve permitir que o funcionário acesse a página de menu principal da oficina. Caso as informações de Login e Senha estejam incorretas, a página de login é recarregada para que os campos sejam preenchidos novamente.

Caso de Teste | CT-12: Login de cliente da oficina
---|---
Requisitos Associados | RF-14: O sistema deve permitir o login como cliente da oficina.
Objetivo do Teste | Verificar se o cliente é capaz de realizar login no sistema.
Passos | 1.	Executar a aplicação; <br>	2.	Clicar no botão "Sou cliente"; <br>3.	Preencher os campos Login e Senha; <br>4.	Clicar em Entrar.
Critérios de Êxito | •	Se o registro de usuário existir no banco de dados, o sistema deve permitir que o cliente acesse a página de cliente da oficina. Caso as informações de Login e Senha estejam incorretas, a página de login é recarregada para que os campos sejam preenchidos novamente.

Caso de Teste | CT-13: Cadastro de funcionário da oficina
---|---
Requisitos Associados | RF-01: O sistema deve permitir Incluir/Excluir/Alterar dados de um funcionário ou cliente da oficina.
Objetivo do Teste | Garantir que o sistema permite a inclusão do cadastro de um funcionário para determinada oficina
Passos | 1.	Executar a aplicação; <br>	2.	Fazer login no sistema com uma conta de Gestor; <br>3.	No painel de controle, selecionar a opção Cadastrar Funcionário; <br>4. Preencher corretamente o formulário de cadastro;<br>5. Clicar em Inserir.
Critérios de Êxito | •	Se as informações forem preenchidas corretamente, o sistema deve direcionar o usuário para uma tela onde constará uma mensagem de sucesso relativa à inserção do funcionário. Após a inserção ser efetuada, as informações inseridas no formulário devem ser registradas no banco de dados na tabela [CRM_AUTO].[dbo].[FUNCIONARIO].
 
 Caso de Teste | CT-14: Consulta e alteração de dados de cliente da oficina
---|---
Requisitos Associados | RF-03: O sistema deve fazer consulta e alterações de dados pessoais de clientes. 
Objetivo do Teste | Verificar se o sistema permite ao funcionário visualizar e alterar dados de um cliente quando necessário.
Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>2.	Ir para a tela de cadastro de clientes; <br>3.	Escolher a opção "Clientes" na barra lateral; <br>4. Buscar cliente pelo nome; <br>5. Alterar dados de cliente; <br>6. Salvar
Critérios de Êxito | •	Os dados de cliente deverão ser exibidos para o funcionário <br> •	Os dados alterados deverão ser atualizados na base de dados.
 
## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
