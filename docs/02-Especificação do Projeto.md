# Especificações do Projeto

## Personas

 As personas representam os perfis de usuários-alvo, baseados em pesquisas e comportamentos reais. Elas guiam o desenvolvimento de soluções que atendem de forma eficaz às necessidades e expectativas dos usuários. As personas criadas para nosso projeto são: 

#### 1 - Pedro Martins
![1](https://github.com/user-attachments/assets/67e8b9fb-cd53-4fe6-a508-0053331e2b23)

#### 2 - Ana Sousa
![2](https://github.com/user-attachments/assets/2935f780-7599-4873-a61b-90dcc1a61b37)

#### 3 - Luís Ferreira
![3](https://github.com/user-attachments/assets/ea9cf6e7-87e4-4c58-adab-1a1876b359d2)

#### 4 - Marta Oliveira
![4](https://github.com/user-attachments/assets/026c1cc5-eccb-4763-8320-47e0d2fb0fc2)

#### 5 - Ricardo Almeida
![5](https://github.com/user-attachments/assets/2ca3a824-42f3-4daf-abec-2a978e3d1818)

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
|RF-003| O sistema permitirá o usuário gerenciar seus produtos  | MÉDIA |
|RF-004| O sistema permitirá o usuário a visualizar seu inventário em tempo real | MÉDIA |
|RF-005| O sistema permitirá o usuário adicionar itens ao seu inventário| MÉDIA |
|RF-006| O sistema permitirá o usuário deletar itens do seu inventário | MÉDIA |
|RF-007| O sistema permitirá o usuário gerenciar a categoria do seu produto| BAIXA |
|RF-008| O sistema permitirá o usuário gerar um relatório dos seus itens cadastrados | MÉDIA |
|RF-009| O sistema permitirá o usuário gerenciar fornecedores| MÉDIA |
|RF-010| O sistema permitirá o usuário pesquisar produtos no inventário usando filtros como nome, categoria ou fornecedor | BAIXA |
|RF-011| O sistema permitirá o usuário configurar alertas para produtos com estoque baixo | MÉDIA |
|RF-012| O sistema permitirá o usuário configurar alertas para produtos próximos ao vencimento | MÉDIA |
|RF-013| O sistema permitirá o usuário exportar dados de inventário em formatos .TXT | MÉDIA |


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
|02| O projeto não poderá usar frameworks                  |
|03| O projeto deverá acessível para web                   |
|04| O estoque de itens não poderá ser negativo            |
|05| O orçamento do projeto não deve ser superior a R$4000,00 |
|06| O sistema de inventário deve estar em conformidade com as normas técnicas e regulatórias, como as da ABNT |


## Diagrama de Casos de Uso

O diagrama de caso de uso descreve um sistema de inventário, onde o **Funcionário** interage com várias funcionalidades do sistema. Aqui estão as principais funcionalidades e suas interações:

1. **Cadastrar Empresa**: O funcionário pode registrar uma nova empresa no sistema.
2. **Login**: Acesso ao sistema por meio de login.
3. **Gerenciar Produtos**: Permite a gestão completa dos produtos, incluindo:
   - **Adicionar Produto**: Adicionar novos produtos ao inventário.
   - **Editar Produto**: Atualizar informações dos produtos existentes.
   - **Excluir Produto**: Remover produtos do inventário.
   - **Visualizar Inventário**: Acesso à visualização detalhada do inventário.
   - **Gerar Relatório**: Criar relatórios baseados nos dados do inventário.
   - **Exportar em formato .TXT**: Exportar relatórios e dados em formato de texto.
4. **Categorizar Produto**: Organização dos produtos em categorias, incluindo:
   - **Criar Categoria Personalizada**: Criar novas categorias específicas para os produtos.
   - **Configurar Alertas**: Definir alertas para eventos relacionados aos produtos.
5. **Filtrar Produto**: Permite a filtragem de produtos no inventário com base em critérios específicos.
6. **Gerenciar Fornecedores**: Gestão dos fornecedores associados aos produtos, incluindo:
   - **Adicionar Fornecedores**: Inserir novos fornecedores no sistema.
   - **Editar Fornecedores**: Atualizar informações dos fornecedores.
   - **Excluir Fornecedores**: Remover fornecedores do sistema.

Cada uma dessas funcionalidades está interligada, e algumas delas incluem ou estendem outras operações, permitindo uma gestão completa e personalizada do inventário e dos fornecedores associados.

![sistema de inventário (1)](https://github.com/user-attachments/assets/f5fa7ea6-560b-4c12-8ba5-4858abf6d065)

