# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Relatório com as evidências dos testes de software realizados no sistema pela equipe, baseado em um plano de testes pré-definido.

## Avaliação

Discorra sobre os resultados do teste. Ressaltando pontos fortes e fracos identificados na solução. Comente como o grupo pretende atacar esses pontos nas próximas iterações. Apresente as falhas detectadas e as melhorias geradas a partir dos resultados obtidos nos testes.


### CT-11: Login de Colaborador

Ao executar a aplicação, o usuário terá acesso às opções de login de colaborador e login de cliente. 
![img1](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/registro%20de%20testes/CT%2011/img1.png)
<p align="center">Evidência de teste 1 - Homepage com as opções de login</p>

Ao clicar no botão "Sou Colaborador", uma página de login aparecerá e os campos de login e senha deverão ser preenchidos.

![img2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/registro%20de%20testes/CT%2011/img2.png)
<p align="center">Evidência de teste 2 - Login de funcionário</p>
<p align="center">
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/registro%20de%20testes/CT%2011/ev1.png">
</p>
<p align="center"> Evidência de teste 3 - Registro de usuário cadastrado no banco de dados</p>

Se os dados de login estiverem corretos, o funcionário é direcionado para a página principal da oficina. 
![img3](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/registro%20de%20testes/CT%2011/img3.png)

Pontos a melhorar

1) O campo de senha deve ocultar os caracteres digitados pelo usuário;
2) Em caso de Login ou Senha incorretos, o sistema deve fornecer um retorno ao usuário, indicando que as informações não são válidas.

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

Se os dados de login estiverem corretos, o cliente é direcionado à página de cliente.

![img6](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/registro%20de%20testes/CT%2012/img3.png)
<p align="center">Evidência de teste 4 - Página de Cliente</p>

Pontos a melhorar

1) O campo de senha deve ocultar os caracteres digitados pelo usuário;
2) Em caso de Login ou Senha incorretos, o sistema deve fornecer um retorno ao usuário, indicando que as informações não são válidas;
3) Finalizar a página de cliente.

### CT-13: Cadastro de funcionário da oficina

Login efetuado com uma conta de Gestor:

<p align="center">
  <img src="https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/Evidencia1_CadastroFuncionario.png?raw=true" alt="Evidência de teste 1 - Login com uma conta de Gestor">
</p>
<p align="center">Evidência de teste 1 - Login com uma conta de Gestor</p>
<br/>

<p align="center">
  <img src="https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/Evidencia2_CadastroFuncionario.png?raw=true" alt="Evidência de teste 2 - Informações do usuário no banco de dados">
</p>
<p align="center">Evidência de teste 2 - Informações do usuário no banco de dados</p>
<br/>

No painel de controle, a opção 'Cadastrar Funcionário' é selecionada:

<p align="center">
  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/blob/main/docs/img/Evidencia3_CadastroFuncionario.png" alt="Evidência de teste 3 - Opção selecionada no painel de controle">
</p>
<p align="center">Evidência de teste 3 - Opção selecionada no painel de controle</p>
<br/>

Na tela de cadastro de funcionários, após o preenchimento correto das informações, a opção 'Inserir' é selecionada:

<p align="center">
  <img src="https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/Evidencia4_CadastroFuncionario.png?raw=true" alt="Evidência de teste 4 - Preenchimento do formulário">
</p>
<p align="center">Evidência de teste 4 - Preenchimento do formulário</p>
<br/>

**Critério de êxito:** Se as informações forem preenchidas corretamente, o sistema deve direcionar o usuário para uma tela onde constará uma mensagem de sucesso relativa à inserção do funcionário. Após a inserção ser efetuada, as informações inseridas no formulário devem ser registradas no banco de dados na tabela [CRM_AUTO].[dbo].[FUNCIONARIO].

Usuário direcionado para a tela de sucesso:

<p align="center">
  <img src="https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/Evidencia5_CadastroFuncionario.png?raw=true" alt="Evidência de teste 5 - Tela de sucesso apresentada para o usuário">
</p>
<p align="center">Evidência de teste 5 - Tela de sucesso apresentada para o usuário</p>
<br/>

Registro inserido na tabela do banco de dados:

<p align="center">
  <img src="https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-crm-auto/main/docs/img/Evidencia6_CadastroFuncionario.png?raw=true" alt="Evidência de teste 6 - Inserção do registro na tabela">
</p>
<p align="center">Evidência de teste 6 - Inserção do registro na tabela</p>
<br/>

Melhorias identificadas com os testes:

1) Necessário ajustar e finalizar os layouts das telas: painel de cotrole da oficina e cadastro de funcionários
2) Implementar as demais funcionalidades disponíveis na tela de cadastro de funcionários
<br/>



> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
