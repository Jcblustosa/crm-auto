# Plano de Testes de Usabilidade

O teste de usabilidade permite avaliar a qualidade da interface com o usuário da aplicação por meio da simulação de seus fluxos. Assim, é possível avaliar, interpretar e propor melhorias ou correções à experiência de usuários com o produto. Será considerada a abordagem das Heurísticas de Nielsen para o desenvolvimento e a avaliação das interfaces deste projeto.

Para esses testes, serão coletados dados _in person_ por meio de observações anotadas por um membro do grupo, encontrando participantes por conveniência. Conforme estudado por Nielsen, a aplicação será testada com, no mínimo, 6 usuários, já que essa quantidade é suficiente para identificar 85% de erros e melhorias a serem feitas. Considerando os resultados obtidos, o grupo adicionará com prioridade as alterações necessárias ao _sprint_ em que estiver.

Assim, esses testes objetivam avaliar a qualidade da interface com o usuário da aplicação desenvolvida de modo a otimizar a experiência dos usuários, minimizando erros e melhorando os fluxos.


## Métricas

As métricas de usabilidade se referem à performance do usuário mediante a performance esperada. A tarefa do teste é finalizada quando o participante alcança seu objetivo. 

São considerados erros não-críticos os desvios do fluxo planejado, erros de confusão (como quando não ficou claro o tipo de input necessário/aceito). Caso o participante precise de ajuda ou obtenha valores incorretos aos pedidos na tarefa, consideram-se erros críticos. São comuns a todos os casos de teste as seguintes métricas, a serem complementadas com quaisquer observações relevantes feitas durante o teste:

- Finalização da tarefa
- Quantidade de erros por tarefa
- Tempo para completar a tarefa
- Feedback de como foi a experiência para os participantes, em uma pergunta aberta de modo a não influenciar sua resposta.

Em relação à severidade dos problemas encontrados, define-se seu impacto como alto na presença de erros críticos, moderado com a dificuldade mas finalização da tarefa e baixo caso os problemas encontrados sejam mínimos e em nada interfiram na finalização da tarefa. Também será considerada a frequência do problema: alta caso mais de 30% dos participantes encontrem-no, moderada se de 11% a 30%, e baixa se menos de 10% encontrem-no (0 participantes caso sejam encontradas até 10 pessoas).

## Testes de Usabilidade

| **Caso de Teste** | **CX-01: Alteração de dados de oficina/funcionário/cliente (Oficina)**|
|---|---|
| Objetivo do Teste | Verificar se as CTA (_call to action_) e fluxos de inserção ou alteração de dados no sistema são claros para o usuário. |
| Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>2.	Ir para a tela de manutenção; <br>3.	Incluir/Excluir/Alterar dados de oficina/funcionário/cliente. |
| Critérios de Êxito | •	A pessoa conseguiu executar a tarefa sem ajuda. <br> • É claro para o usuário qual o perfil de pessoa (funcionário/cliente) está sendo alterado.  <br> •	Fica claro para o usuário que a alteração foi realizada com sucesso. |
|||
|**Caso de Teste** | **CX-02: Emissão de relatório de cliente (Oficina)**|
|Objetivo do Teste | Verificar se as CTA (_call to action_) e fluxos da emissão de relatórios são claros para o usuário.|
|Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>2.	Ir para a tela do menu; <br>3.	Escolher a opção de Emissão de Relatório de Cliente.|
|Critérios de Êxito | •	A pessoa conseguiu visualizar o relatório sem ajuda.|
| ||
|**Caso de Teste** | **CX-03: Consulta de saldo ou estoque de peças (Oficina)**|
|Objetivo do Teste | Verificar se as CTA (_call to action_) e fluxos da verificação de peças são claros para o usuário.|
|Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>2.	Ir para a tela de manutenção; <br> 3. Escolher a opção Consultar Estoque; <br> 4. Especificar a peça a consultar. <br> 5. Visualizar os resultados que contenham o _input_ inserido.|
|Critérios de Êxito | •	A pessoa conseguiu visualizar o saldo ou estoque de peças sem ajuda. <br> • Caso não seja encontrado nenhum resultado equivalente ao procurado, isso ficaa claro para o usuário.|
| |
|**Caso de Teste** | **CX-04: Atualização de processos (Oficina)**|
|Objetivo do Teste | Verificar se as CTA (_call to action_) e fluxos da manutenção do processo são claros para o usuário. |
|Passos | 1.	Fazer login no sistema com uma conta de Gestor; <br>	2.	Ir para a página de Menu; <br>3.	Selecionar a opção Processos em Andamento; <br> 4.	Selecionar um processo para ser visualizado; <br> 5.	Editar o processo. <br> 6. Receber confirmação da alteração do processo.|
|Critérios de Êxito | •A pessoa conseguiu executar a tareda sem ajuda.  <br> • É claro para o usuário qual processo está sendo alterado.  <br> •	Fica claro para o usuário que a alteração foi realizada com sucesso.|
| |
|**Caso de Teste** | **CX-05:  Visualização do processo em andamento (Cliente)**|
|Objetivo do Teste | Verificar se as CTA (_call to action_) e fluxos da visualização do processo são claros para o usuário. |
|Passos | 1. Fazer login no sistema com uma conta de Cliente; <br> 2. Ir para a página de Menu; <br> 3. Selecionar a opção Processos em Andamento; <br> 4. Selecionar um processo para ser visualizado.|
|Critérios de Êxito | •	O usuário conseguiu acessar as informações necessárias no sistema.|
| |
|**Caso de Teste** | **CX-06:  Solicitação de novo orçamento em processo em andamento (Cliente)**|
|Objetivo do Teste | Verificar se as CTA (_call to action_) e fluxos da solicitação de um novo orçamento em processo em andamento são claros para o usuário.|
|Passos | 1. Fazer login no sistema com uma conta de Cliente; <br> 2. Ir para a página de Menu; <br> 3. Selecionar a opção Adicionar Tarefa; <br> 4. Especificar o serviço cujo orçamento foi solicitado.|
|Critérios de Êxito | •	O usuário conseguiu solicitar o orçamento do serviço no sistema.|
| |
|**Caso de Teste** | **CX-07:  Serviços da oficina**|
|Objetivo do Teste |Verificar se as CTA (_call to action_) e fluxos de cadastrar, alterar e excluir os serviços disponibilizados são claros para o usuário.|
|Passos | 1. Fazer login no sistema com uma conta de Gestor; <br> 2. Ir para a página de Menu; <br> 3. Selecionar a opção Serviços; <br> 4. Escolher a função Cadastrar/Alterar/Excluir Serviço. <br> 5. Receber a confirmação da alteração no sistema.|
|Critérios de Êxito | •	O usuário conseguiu alterar as informações necessárias no sistema sem ajudas. <br> •	Fica claro para o usuário que a alteração foi realizada com sucesso. |
| |
|**Caso de Teste** | **CX-08:  Cadastro de novo veículo (Oficina)**|
|Objetivo do Teste | Verificar se as CTA (_call to action_) e fluxos da inserção de veículo para cliente existente são claros para o usuário.|
|Passos | 1. Fazer login no sistema com uma conta de Gestor; <br> 2. Ir para a página de Menu; <br> 3. Selecionar a opção Cadastrar Veículo; <br> 4. Preencher as informações necessárias no formulário do sistema. <br> 5. Receber a confirmação da alteração no sistema. |
|Critérios de Êxito | •	O usuário conseguiu alterar as informações necessárias no sistema sem ajuda.  <br> •	Fica claro para o usuário que a alteração foi realizada com sucesso.|

