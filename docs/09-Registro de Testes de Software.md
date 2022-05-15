# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Relatório com as evidências dos testes de software realizados no sistema pela equipe, baseado em um plano de testes pré-definido.

## Avaliação

Discorra sobre os resultados do teste. Ressaltando pontos fortes e fracos identificados na solução. Comente como o grupo pretende atacar esses pontos nas próximas iterações. Apresente as falhas detectadas e as melhorias geradas a partir dos resultados obtidos nos testes.


### CT-11: Login de Colaborador

Ao acessar o site, o funcionário terá acesso às opções de login de colaborador e login de cliente. 

IMG1

Ao clicar no botão "Sou Colaborador", os campos de login e senha deverão ser preenchidos.

IMG2

Se os dados de login estiverem corretos, o funcionário é direcionado para a página principal da oficina. Se estiverem incorretos, a página de login é recarregada.

IMG3

Pontos a melhorar

1) O campo de senha deve ocultar os caracteres digitados pelo usuário;
2) Em caso de Login ou Senha incorretos, o sistema deve fornecer um retorno ao usuário, indicando que as informações não são válidas.

### CT-12: Login de cliente da oficina

Ao acessar o site, o cliente terá acesso às opções de login de colaborador e login de cliente. 

IMG1

Ao clicar no botão "Sou Cliente", os campos de login e senha deverão ser preenchidos.

IMG2

Se os dados de login estiverem corretos, o cliente é direcionado à página de cliente. Se estiverem incorretos, a página de login é recarregada.

IMG3

Pontos a melhorar

1) O campo de senha deve ocultar os caracteres digitados pelo usuário;
2) Em caso de Login ou Senha incorretos, o sistema deve fornecer um retorno ao usuário, indicando que as informações não são válidas.



> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
