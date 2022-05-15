# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A determinação exata do problema, suas personas, requisitos funcionais e não-funcionais foram acordadas em reuniões online entre os membros da equipe. Foram reunidas informações e observações dos membros sobre aspectos relevantes na relação de clientes e oficinas, buscando entender as necessidades, insatisfações e sucessos de todas as partes envolvidas. Os detalhes levantados nesse processo auxiliaram na construção de personas e histórias de usuários mais completas e úteis para o projeto a ser desenvolvido.

## Personas

| Jade Miranda | Gaspar Rocha | Ênio Braga |
| ---        |    ----   |          --- |
| <img src="/docs/img/gerente.jpg" alt="Jade Miranda" width="100" height="100"/>     | <img src="/docs/img/cliente.jpg" alt="Gaspar Rocha" width="100" height="100"/>       | <img src="/docs/img/enio.jpg" alt="Ênio Braga" width="100" height="100"/> |
| Idade: 44 anos <br>Ocupação: Gerente de Oficina Automobilística| Idade: 26 anos <br>Ocupação: Representante comercial       | Idade: 34 anos <br>Ocupação: Mecânico |
| Hobbies, História:<br><ul><li>Assistir séries</li><li>Praticar Muay-Thai</li></ul> | Hobbies, História:<br><ul><li>Jogar RPG de mesa</li><li>Fazer trilhas</li></ul>  | Hobbies, História:<br><ul><li>Tocar violão</li><li>Jogar Video game</li></ul> |
| Motivações: <br><ul><li>Conseguir dar _feedbacks_ mais rápidos e precisos a clientes</li><li> Manter um bom equilíbrio entre trabalho e vida pessoal</li><li> Fidelizar clientes com a qualidade do atendimento</li></ul> | Motivações: <br><ul><li>Poder viajar pelo estado em finais de semana e feriados</li><li>Uma rotina de trabalho equilibrada</li></ul>           | Motivações: <br><ul><li>Se especializar no conserto de carros antigos</li><li>Conseguir maior flexibilidade no trabalho</li></ul>   |
| Frustrações: <br><ul><li>Não conseguir organizar bem a jornada de trabalho e serviços pendentes</li><li>Não ter um canal de comunicação mais eficiente com clientes</li><li>Não fidelizar a quantidade de clientes que considera possível com a oficina </li></ul> | Frustrações: <br><ul><li>Nunca lembrar de manutenções e ter problemas com o carro por causa disso</li><li>Não ter uma oficina de sua confiança</li><li>Não poder viajar de carro sempre que quiser</li></ul> | Frustrações:  <br><ul><li>Dificuldade de compartilhar informações sobre com agilidade serviços entre colegas e com a gerência</li><li> Não ter um bom canal de comunicação sobre a fila de serviços a serem feitos na oficina</li><li>Não conseguir atualizar a gerÊncia e os clientes sobre problemas emergentes com rapidez</li></ul>  |

## Histórias de Usuários

Com base na análise das personas foram identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE`                                                                       |PARA ... `MOTIVO/VALOR`                                                                        |
|--------------------|----------------------------------------------------------------------------------------------------------|-----------------------------------------------|
|Gestor da oficina |Efetuar o cadastro, alteração e exclusão de oficinas no sistema |Que a gestão da oficina matriz e das oficinas filiais seja realizada de forma centralizada em um único sistema|
|Gestor da oficina | Efetuar o cadastro, alteração e exclusão de funcionários no sistema |Conseguir realizar a gestão dos meus funcionários de maneira facilitada|
|Gestor da oficina | Efetuar o cadastro, alteração e exclusão dos serviços disponibilizados pela oficina |Que seja possível incluir, alterar e excluir informações de um determinado serviço|
|Gestor da oficina| Gerar relatórios sobre os serviços realizados pela oficina| Obter informações relevantes da minha empresa|
|Gestor da oficina| Gerar relatórios sobre os clientes da oficina | Obter informações relevantes dos meus clientes|
|Gestor da oficina / Funcionário da oficina| Efetuar o cadastro, alteração e exclusão de clientes no sistema| Que seja possível incluir e alterar informações de um determinado cliente|
|Gestor da oficina / Funcionário da oficina| Consultar os clientes cadastrados no sistema| Conseguir realizar a gestão dos clientes de maneira otimizada|      
|Funcionário da oficina |Realizar o cadastro de veículo (s) para um determinado cliente no sistema| Conseguir realizar a inclusão dos serviços solicitados para o veículo|
|Funcionário da oficina| Inserir, alterar e excluir informações sobre o andamento de um determinado serviço no sistema| Que o registro dessas informações esteja sempre atualizado|
|Cliente da oficina| Acompanhar o andamento do serviço solicitado à oficina e a data prevista para finalização| Que eu tenha informações relevantes sobre a evolução do serviço contratado|
|Cliente da oficina| Visualizar o histórico de serviços efetuados/concluídos no (s) meu (s) veículo (s) nos últimos 5 anos| Que eu consiga consultar os registros de forma fácil e centralizada em um único sistema|  
|Cliente da oficina| Visualizar no detalhamento do serviço informações como: peças trocadas, serviços efetuados, mecânico responsável e valores das peças e serviços |Que eu consiga consultar informações relevantes sobre os serviços que foram efetuados no (s) meu (s) veículo (s)|
|Cliente da oficina |Receber lembretes automáticos sobre revisões e serviços recomendados para o (s) meu (s) veículo (s) |Que eu seja lembrado de realizar serviços importantes para a correta manutenção do (s) meu (s) veículo (s)|

## Requisitos

As tabelas que a seguir apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID  | Descrição do Requisito | PRIORIDADE |  
|---|---|---|
| RF-01 | O sistema deve permitir Incluir/Excluir/Alterar dados de um funcionário ou cliente da oficina. |  MÉDIA| 
| RF-02 | O sistema deve emitir relatórios de clientes. | ALTA | | 
| RF-03 | O sistemea deve fazer consulta e alterações de dados pessoais de clientes.  | ALTA |  
| RF-04 | O sistema deve realizar consulta de saldo ou estoque. |  ALTA|
| RF-05 | O sistema deve permitir que o usuário cadastre tarefas. | ALTA  | 
| RF-06 | O sistema deve emitir lembretes após passarem-se 11 meses desde a última revisão anual. | ALTA  | 
| RF-07 | O sistema deve efetuar o cadastro, alteração e exclusão de oficinas no sistema.  | ALTA  |
| RF-08 | O sistema deve efetuar o cadastro, alteração e exclusão dos serviços disponibilizados pela oficina.  | ALTA |
| RF-09 | O sistema deve consultar os clientes cadastrados no sistema.| ALTA |
| RF-10  | O sistema deve realizar o cadastro de veículo (s) para um determinado cliente no sistema.| ALTA |
| RF-11  |O sistema deve inserir, alterar e excluir informações sobre o andamento de um determinado serviço no sistema.| ALTA |
| RF-12  |O sistema deve acompanhar o andamento do serviço solicitado à oficina e a data prevista para finalização.| ALTA |
| RF-13  |O sistema deve permitir o login de colaborador da oficina.| ALTA |
| RF-14  |O sistema deve permitir o login como cliente da oficina.| ALTA |

### Requisitos não Funcionais

| ID  | Descrição do Requisito | PRIORIDADE | 
|---|---|---|
| RNF-01 | Deve ser possível usar um módulo de informações cadastrais em modo off-line. |  MÉDIA  | 
| RNF-02 | O sistema deve ter implementado com C# e JavaScript, complementado com front-end em Html e CSS. | ALTA |
| RNF-03 | O sistema deverá se comunicar com o banco SQL. | ALTA | 
| RNF-04 | Um relatório de surpervisão deverá ser fornecido toda sexta-feira.  | ALTA | 
| RNF-05 | O sistema deve ser responsivo para rodar no navegador de um dispositivos móvel. | ALTA | 
| RNF-06 | Deve processar requisições do usuário em no máximo 5s. |  ALTA  | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
| RE-01 | O projeto deverá ser entregue até o final do semestre. |
| RE-02 | O projeto deverá ser implementado com uso de tecnologias web, Front End e Back-End. |

## Diagrama de Casos de Uso

![Diagrama1](../docs/img/func.png)

![Diagrama2](../docs/img/Gestor.png)
