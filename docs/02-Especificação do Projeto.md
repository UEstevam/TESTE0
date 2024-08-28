# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

 As personas representam os perfis de usuários-alvo, baseados em pesquisas e comportamentos reais. Elas guiam o desenvolvimento de soluções que atendem de forma eficaz às necessidades e expectativas dos usuários. As personas criadas para nosso projeto são: 

#### 1 - Pedro Martins
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t1-pmv-ads-2024-2-e2-proj-int-t1-estoque/blob/main/docs/img/Pedro%20Martins.png" alt="Persona1"/>

#### 2 - Ana Sousa
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t1-pmv-ads-2024-2-e2-proj-int-t1-estoque/blob/main/docs/img/AnaSousa.png" alt="Persona2"/>

#### 3 - Luís Ferreira
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t1-pmv-ads-2024-2-e2-proj-int-t1-estoque/blob/main/docs/img/Lu%C3%ADs%20Ferreria.png" alt="Persona3"/>

#### 4 - Marta Oliveira
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t1-pmv-ads-2024-2-e2-proj-int-t1-estoque/blob/main/docs/img/Marta%20Oliveira.png" alt="Persona4"/>

#### 5 - Ricardo Almeida
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t1-pmv-ads-2024-2-e2-proj-int-t1-estoque/blob/main/docs/img/Ricardo%20Almeida.png" alt="Persona5"/>

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

| EU COMO... `PERSONA`                             | QUERO/PRECISO ... `FUNCIONALIDADE`                                              | PARA ... `MOTIVO/VALOR`                                                                 |
|--------------------------------------------------|---------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------|
| Pedro  Martins    | Preciso de um sistema que me permita controlar o inventário de forma simples e automática.               | Evitar rupturas de estoque e desperdícios, assegurando que sempre tenha os produtos certos disponíveis para os meus clientes, sem comprometer o meu orçamento. |
| Pedro  Martins    | Um sistema de gerenciamento de inventário que me permita categorizar os produtos de forma fácil e intuitiva.               | Organizar o inventário de maneira eficiente, facilitando a localização e controle dos produtos por categoria, o que melhora a gestão e evita erros no estoque. |
| Ana    Sousa    | Quero um sistema que rastreie os prazos de validade dos produtos e otimize a organização do armazém.      | Minimizar desperdícios, melhorar a eficiência operacional e garantir a conformidade com as normas regulatórias.          |
| Ana    Sousa    | Um sistema de gerenciamento de inventário que me permita gerar relatórios dos itens cadastrados.      | Analisar o desempenho do inventário, identificar tendências e tomar decisões informadas para melhorar a gestão de estoque e otimizar recursos.          |
| Luís   Ferreira    | Um sistema de gerenciamento de inventário que me permita gerenciar e acompanhar meus fornecedores de forma centralizada.  | Manter um controle eficiente sobre os fornecedores, facilitando a negociação, o acompanhamento de entregas e a reposição de estoque, garantindo que sempre haja produtos disponíveis quando necessário.   |
| Luís   Ferreira    | Preciso de uma funcionalidade que me forneça previsões precisas de demanda com base em dados históricos.  | Realizar compras mais eficientes, evitando excesso de estoque ou falta de produtos, e assim otimizar o fluxo de caixa.   |
| Marta  Oliveira    | Quero uma solução que integre e sincronize o inventário entre o armazém físico e a loja online.           | Garantir que o estoque esteja sempre atualizado, evitando a venda de produtos fora de estoque e melhorando a satisfação dos clientes. |
| Marta  Oliveira    | Um sistema de gerenciamento de inventário que me permita pesquisar produtos usando filtros como nome, categoria ou fornecedor.          | Localizar rapidamente os produtos no inventário, agilizando o processo de consulta e tomada de decisões, e garantindo uma gestão mais eficiente e precisa dos itens em estoque. |
| Ricardo Almeida    | Preciso de uma ferramenta que me forneça dados precisos e em tempo real do inventário.                    | Realizar análises detalhadas que suportem decisões estratégicas e melhorem a eficiência operacional da empresa.           |
| Ricardo Almeida    | Cadastrar e configurar as informações da minha empresa no sistema de gerenciamento de inventário.                    | Garantir que o sistema atenda às necessidades específicas da minha empresa.           |




## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema permitirá o usuário a cadastrar sua empresa | ALTA | 
|RF-002| O sistema permitirá o usuário a logar na conta da empresa  | ALTA |
|RF-003| O sistema permitirá o usuário gerenciar seus produtos  | ALTA |
|RF-004| O sistema permitirá o usuário a visualizar seu inventário em tempo real | ALTA |
|RF-005| O sistema permitirá o usuário adicionar itens ao seu inventário| ALTA |
|RF-006| O sistema permitirá o usuário deletar itens do seu inventário | ALTA |
|RF-007| O sistema permitirá o usuário gerenciar a categoria do seu produto| ALTA |
|RF-008| O sistema permitirá o usuário gerar um relatório dos seus itens cadastrados | MÉDIA|
|RF-009| O sistema permitirá o usuário gerenciar fornecedores| ALTA |
|RF-010|  permitirá ao usuário pesquisar produtos no inventário usando filtros como nome, categoria ou fornecedor |  MÉDIA |



### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo | ALTA | 
|RNF-002| Deve ser compatível com os principais navegadores do mercado: Google Chrome, Firefox e Microsoft Edge. | MÉDIA |  
|RNF-003| O sistema deve ser intuitivo e fácil de usar, garantindo uma experiência agradável ao usuário. |  MÉDIA | 
 <!-- alterei o RFN-006 para RFN-003 porque não sei se ele deve permanecer -->




## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
