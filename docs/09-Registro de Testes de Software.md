# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Relatório com as evidências dos testes de software realizados no sistema pela equipe, baseado em um plano de testes pré-definido.

## Avaliação

Discorra sobre os resultados do teste. Ressaltando pontos fortes e fracos identificados na solução. Comente como o grupo pretende atacar esses pontos nas próximas iterações. Apresente as falhas detectadas e as melhorias geradas a partir dos resultados obtidos nos testes.

### CT-08: Cadastro de veículo de cliente

Ao executar a aplicação, o usuário deverá fazer login como Colaborador, preenchendo os campos solicitados.

![img1](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/registro%20de%20testes/CT%2008/login.png)
<p align="center">Evidência de teste 8.1 - Login de funcionário</p>
<p align="center">
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/registro%20de%20testes/CT%2008/evidenciaLogin.png">
</p>
<p align="center"> Evidência de teste 8.2 - Registro de usuário cadastrado no banco de dados</p>

Após clicar em Log in, o usuário é direcionado à página de menu principal da oficina. A opção "Cadastrar Veículo" deve ser selecionada:

![img3](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/registro%20de%20testes/CT%2008/menuPrincipal.png)
<p align="center"> Evidência de teste 8.3 - Página de menu principal da oficina</p>

Na página de cadastro de veículo, as informações devem ser corretamente preenchidas. Após isso, clicar em "Ok".

![img4](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/registro%20de%20testes/CT%2008/cadastroVeiculo.png)
<p align="center"> Evidência de teste 8.4 - Página de cadastro de veículo com os campos preenchidos</p>

Uma mensagem de sucesso é apresentada.

![img5](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/registro%20de%20testes/CT%2008/msgSucesso.png)
<p align="center"> Evidência de teste 8.5 - Página de cadastro de veículo com mensagem de sucesso</p>

**Critério de êxito:** Se as informações forem preenchidas corretamente, o sistema deve armazenar um novo registro no banco de dados, contendo as informações fornecidas pelo usuário:

![img5](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/registro%20de%20testes/CT%2008/evidenciaCadastro.png)
<p align="center"> Evidência de teste 8.6 - Registro de veículo no banco de dados</p>

Pontos a melhorar

1) As configurações de estilo da página de cadastro de veículo devem ser corretamente aplicadas;

### CT-11: Login de Colaborador

**Objetivo:** Verificar se o colaborador é capaz de realizar login no sistema

**Passos:** 
1.	Executar a aplicação
2.	Clicar no botão "Sou colaborador da empresa"
3.	Preencher os campos Login e Senha
4.	Clicar em Log in

**Critério de êxito:** Se as informações forem preenchidas corretamente, o sistema deve direcionar o usuário para o painel de controle da oficina

**Resultado do teste:** *Passou*

**Evidências:**

Após a execução da aplicação, a homepage é apresentada ao usuário:

![img1](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia1.png)
<p align="center">Evidência de teste 1 - Homepage com as opções de login</p>
</br>

Ao clicar no botão "Sou colaborador da empresa", a página de login é exibida:

![img2](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia2.png)
<p align="center">Evidência de teste 2 - Selecionando a opção "Sou colaborador"</p>
</br>

![img3](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia3.png)
<p align="center">Evidência de teste 3 - Tela de login de colaborador apresentada</p>
</br>

Um usuário válido (existente no banco de dados) é informado:

![img4](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia4.png)
<p align="center">Evidência de teste 4 - Preenchimento das informações de login</p>
</br>

![img5](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia5.png)
<p align="center">Evidência de teste 5 - Informações do usuário no banco de dados</p>
</br>

Após clicar em Log in, o painel de controle da oficina é apresentado ao colaborador logado:

![img6](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia6.png)
<p align="center">Evidência de teste 6 - Painel de controle da oficina apresentado ao colaborador logado</p>
</br>

**Observações:**

Pontos a melhorar

1) Em caso de Login ou Senha incorretos, o sistema deve fornecer um retorno ao usuário, indicando que as informações não são válidas.

### CT-12: Login de cliente da oficina

Ao executar a aplicação, o usuário terá acesso às opções de login de colaborador e login de cliente. 

![img4](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/registro%20de%20testes/CT%2012/img1.png)
<p align="center">Evidência de teste 1 - Homepage com as opções de login</p>

Ao clicar no botão "Sou Cliente", uma página de login aparecerá e os campos de login e senha deverão ser preenchidos.

![img5](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/registro%20de%20testes/CT%2012/img2.png)
<p align="center">Evidência de teste 2 - Login de cliente</p>

<p align="center">
  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/registro%20de%20testes/CT%2012/ev1.png">
  </p>
<p align="center">Evidência de teste 3 - Registro de usuário no banco de dados</p>

**Critério de êxito:** Se as informações forem preenchidas corretamente, o sistema deve direcionar o usuário para a página de cliente da oficina:

![img6](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/registro%20de%20testes/CT%2012/img3.png)
<p align="center">Evidência de teste 4 - Página de Cliente</p>

Pontos a melhorar

1) O campo de senha deve ocultar os caracteres digitados pelo usuário;
2) Em caso de Login ou Senha incorretos, o sistema deve fornecer um retorno ao usuário, indicando que as informações não são válidas;
3) Finalizar a página de cliente.

### CT-14: Cadastro de funcionário

**Objetivo:** Garantir que o sistema permite a inclusão do cadastro de um novo funcionário para determinada oficina

**Passos:** 
1. Executar a aplicação
2. Fazer login no sistema
3. No painel de controle, selecionar a opção Menu Funcionários
4. Clicar no botão "Novo funcionário"
5. Preencher corretamente o formulário de cadastro
6. Clicar em Inserir

**Critério de êxito:** Se as informações forem preenchidas corretamente, o sistema deve direcionar o usuário para uma tela onde constará uma mensagem de sucesso relativa à inserção do funcionário. Após a inserção ser efetuada, as informações inseridas no formulário devem ser registradas no banco de dados na tabela [CRM_AUTO].[dbo].[FUNCIONARIO].

**Resultado do teste:** *Passou*

**Evidências:**

Após efetuar login no sistema, o Menu Funcionários é selecionado no Painel de Controle:

![img1](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia1_CT14.png)
<p align="center">Evidência de teste 1 - Selecionando o Menu Funcionários no Painel de Controle</p>
</br>

Ao clicar no botão "Novo funcionário", o formulário de cadastro é apresentado:

![img2](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia2_CT14.png)
<p align="center">Evidência de teste 2 - Clicando no botão "Novo Funcionário"</p>
</br>

![img3](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia3_CT14.png)
<p align="center">Evidência de teste 3 - Formulário de cadastro é apresentado</p>
</br>

Os dados do novo funcionário são preenchidos:

![img4](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia4_CT14.png)
<p align="center">Evidência de teste 4 - Preenchimento das informações do novo funcionário</p>
</br>

Após clicar em Inserir, o usuário é direcionado para uma tela onde é apresentada a mensagem de sucesso na inclusão do novo funcionário:

![img5](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia5_CT14.png)
<p align="center">Evidência de teste 5 - Mensagem de sucesso apresentada ao usuário</p>
</br>

Funcionário cadastrado é apresentado na tela:

![img6](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia7_CT14.png)
<p align="center">Evidência de teste 6 - Funcionário apresentado na tela</p>
</br>

Funcionário cadastrado inserido na tabela [CRM_AUTO].[dbo].[FUNCIONARIO]:

![img7](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia6_CT14.png)
<p align="center">Evidência de teste 7 - Funcionário inserido no banco de dados</p>
</br>

**Observações:**

Pontos a melhorar

1) Apresentar um combobox com as funções existentes na oficina, de forma que o usuário não tenha que digitar esse campo no formulário e apenas selecionar uma opção dentre as apresentadas.


### CT-15: Alteração de funcionário

**Objetivo:** Garantir que o sistema permite a alteração do cadastro de um funcionário da oficina

**Passos:** 
1. Executar a aplicação
2. Fazer login no sistema
3. No painel de controle, selecionar a opção Menu Funcionários
4. Clicar no botão para editar as informações de um funcionário
5. Preencher corretamente o formulário de alteração com os novos dados
6. Clicar em Alterar

**Critério de êxito:** Se as informações forem preenchidas corretamente, o sistema deve direcionar o usuário para uma tela onde constará uma mensagem de sucesso relativa à alteração do funcionário. Após a alteração ser efetuada, as informações do usuário devem ser atualizadas na tabela [CRM_AUTO].[dbo].[FUNCIONARIO].

**Resultado do teste:** *Passou*

**Evidências:**

Após efetuar login no sistema, o Menu Funcionários é selecionado no Painel de Controle:

![img1](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia1_CT14.png)
<p align="center">Evidência de teste 1 - Selecionando o Menu Funcionários no Painel de Controle</p>
</br>

Ao clicar no botão de edição do funcionário, o formulário é apresentado e as informações atuais do funcionário são carregadas automaticamente:

![img2](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia1_CT15.png)
<p align="center">Evidência de teste 2 - Clicando no botão de edição do funcionário</p>
</br>

![img3](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia2_CT15.png)
<p align="center">Evidência de teste 3 - Formulário de cadastro é apresentado e as informações carregadas automaticamente</p>
</br>

Informações atuais do funcionário na tabela [CRM_AUTO].[dbo].[FUNCIONARIO]:

![img4](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia3_CT15.png)
<p align="center">Evidência de teste 4 - Informações atuais do funcionário no banco de dados</p>
</br>

Os dados 'função' e 'oficina' do funcionário são alterados:

![img5](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia4_CT15.png)
<p align="center">Evidência de teste 4 - Alteração das informações</p>
</br>

Após clicar em Alterar, o usuário é direcionado para uma tela onde é apresentada a mensagem de sucesso na alteração do funcionário:

![img6](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia5_CT15.png)
<p align="center">Evidência de teste 5 - Mensagem de sucesso apresentada ao usuário</p>
</br>

Informações atualizadas na tela:

![img7](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia6_CT15.png)
<p align="center">Evidência de teste 6 - Informações atualizadas na tela</p>
</br>

Informações atualizadas na tabela [CRM_AUTO].[dbo].[FUNCIONARIO]:

![img8](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia7_CT15.png)
<p align="center">Evidência de teste 7 - Informações atualizadas no banco de dados</p>
</br>

**Observações:**

Pontos a melhorar

1) Apresentar um combobox com as funções existentes na oficina, de forma que o usuário não tenha que digitar esse campo no formulário e apenas selecionar uma opção dentre as apresentadas.

### CT-16: Exclusão de funcionário

**Objetivo:** Garantir que o sistema permite a exclusão do cadastro de um funcionário da oficina

**Passos:** 
1. Executar a aplicação
2. Fazer login no sistema
3. No painel de controle, selecionar a opção Menu Funcionários
4. Clicar no botão para editar as informações de um funcionário
5. Validar as informações carregadas automaticamente do funcionário que deseja excluir
6. Clicar em Excluir

**Critério de êxito:** Após clicar em excluir, o sistema deve direcionar o usuário para uma tela onde constará uma mensagem de sucesso relativa à exclusão do funcionário. Após a exclusão ser efetuada, o registro do funcionário deve ser excluído na tabela [CRM_AUTO].[dbo].[FUNCIONARIO].

**Resultado do teste:** *Passou*

**Evidências:**

Após efetuar login no sistema, o Menu Funcionários é selecionado no Painel de Controle:

![img1](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia1_CT14.png)
<p align="center">Evidência de teste 1 - Selecionando o Menu Funcionários no Painel de Controle</p>
</br>

Ao clicar no botão de edição do funcionário, o formulário é apresentado e as informações atuais do funcionário são carregadas automaticamente:

![img2](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia2_CT16.png)
<p align="center">Evidência de teste 2 - Clicando no botão de edição do funcionário</p>
</br>

![img3](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia3_CT16.png)
<p align="center">Evidência de teste 3 - Formulário de cadastro é apresentado e as informações carregadas automaticamente</p>
</br>

Registro do funcionário na tabela [CRM_AUTO].[dbo].[FUNCIONARIO]:

![img4](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia5_CT16.png)
<p align="center">Evidência de teste 4 - Registro do funcionário no banco de dados</p>
</br>

Após clicar em Excluir, o usuário é direcionado para uma tela onde é apresentada a mensagem de sucesso na alteração do funcionário:

![img5](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia4_CT16.png)
<p align="center">Evidência de teste 5 - Clicando no botão Excluir</p>
</br>

![img6](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia6_CT16.png)
<p align="center">Evidência de teste 6 - Mensagem de sucesso apresentada ao usuário</p>
</br>

Funcionário não é mais na tela:

![img7](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia7_CT16.png)
<p align="center">Evidência de teste 7 - Lista de funcionários atualizada</p>
</br>

Registro excluído na tabela [CRM_AUTO].[dbo].[FUNCIONARIO]:

![img8](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/registro%20de%20testes/CT%2011/Evidencia8_CT16.png)
<p align="center">Evidência de teste 8 - Registro excluído no banco de dados</p>
</br>

**Observações:**

Pontos a melhorar

1) Apresentar o botão de excluir na coluna de opções da tabela de funcionários e não dentro do modal, afim de simplificar a experiência do usuário.


> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
