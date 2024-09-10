# Plano de Testes de Software

<span style="color:red">Pré-requisitos: [Especificação do Projeto](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t1-pmv-ads-2024-2-e2-proj-int-t1-estoque/blob/main/docs/02-Especifica%C3%A7%C3%A3o%20do%20Projeto.md), [Projeto de Interface](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t1-pmv-ads-2024-2-e2-proj-int-t1-estoque/blob/main/docs/04-Projeto%20de%20Interface.md)


| **Caso de Teste**  | **CT-01 - Cadastrar Empresa**                                                                          |
|--------------------|-----------------------------------------------------------------------------------------------------|
| Requisito Associado| RF-001 - O sistema permitirá o usuário a cadastrar sua empresa.                                       |
| Objetivo do Teste  | Verificar se o usuário pode cadastrar sua empresa corretamente.                                       |
| Passos             | 1. Acessar o navegador <br> 2. Informar o endereço do site <br> 3. Acessar a página de cadastro <br> 4. Preencher os dados e confirmar o cadastro |
| Critério de Êxito  | A empresa deve ser cadastrada com sucesso e a confirmação do cadastro deve ser exibida.              |


| **Caso de Teste**  | **CT-02 - Login na Conta da Empresa**                                                                 |
|--------------------|-----------------------------------------------------------------------------------------------------|
| Requisito Associado| RF-002 - O sistema permitirá o usuário a logar na conta da empresa.                                   |
| Objetivo do Teste  | Verificar se o usuário consegue fazer login na conta da empresa.                                      |
| Passos             | 1. Acessar o navegador <br> 2. Informar o endereço do site <br> 3. Acessar a página de login <br> 4. Inserir as credenciais da empresa <br> 5. Confirmar o login |
| Critério de Êxito  | O usuário deve ser redirecionado para a página inicial da conta após login com sucesso.              |


| **Caso de Teste**  | **CT-03 - Gerenciar Produtos**                                                                        |
|--------------------|-----------------------------------------------------------------------------------------------------|
| Requisito Associado| RF-003 - O sistema permitirá o usuário gerenciar seus produtos.                                       |
| Objetivo do Teste  | Verificar se o usuário pode adicionar, editar e remover produtos.                                     |
| Passos             | 1. Fazer login na conta da empresa <br> 2. Acessar a área de gerenciamento de produtos <br> 3. Adicionar, editar e remover produtos |
| Critério de Êxito  | As operações de adicionar, editar e remover produtos devem ser realizadas com sucesso e refletidas na interface. |


| **Caso de Teste**  | **CT-04 - Visualizar Estoque em Tempo Real**                                                          |
|--------------------|-----------------------------------------------------------------------------------------------------|
| Requisito Associado| RF-004 - O sistema permitirá o usuário visualizar seu estoque em tempo real.                         |
| Objetivo do Teste  | Verificar se o usuário consegue visualizar o estoque de produtos em tempo real.                      |
| Passos             | 1. Fazer login na conta da empresa <br> 2. Acessar a página de visualização de estoque               |
| Critério de Êxito  | O estoque deve ser exibido corretamente, refletindo a quantidade real de produtos no sistema.        |


| **Caso de Teste**  | **CT-05 - Adicionar Itens ao Estoque**                                                                |
|--------------------|-----------------------------------------------------------------------------------------------------|
| Requisito Associado| RF-005 - O sistema permitirá o usuário adicionar itens ao seu estoque.                               |
| Objetivo do Teste  | Verificar se o usuário pode adicionar novos itens ao estoque.                                         |
| Passos             | 1. Fazer login na conta da empresa <br> 2. Acessar a área de gerenciamento de estoque <br> 3. Adicionar um novo item ao estoque |
| Critério de Êxito  | O novo item deve ser adicionado com sucesso ao estoque e ser exibido na lista de produtos.           |


| **Caso de Teste**  | **CT-06 - Deletar Itens do Estoque**                                                                  |
|--------------------|-----------------------------------------------------------------------------------------------------|
| Requisito Associado| RF-006 - O sistema permitirá o usuário deletar itens do seu estoque.                                 |
| Objetivo do Teste  | Verificar se o usuário consegue deletar itens do estoque.                                            |
| Passos             | 1. Fazer login na conta da empresa <br> 2. Acessar a área de gerenciamento de estoque <br> 3. Selecionar um item e deletá-lo |
| Critério de Êxito  | O item selecionado deve ser removido do estoque com sucesso.                                         |


| **Caso de Teste** 	| **CT-07 - Gerenciar Categoria de Produto**                                                     	|
|--------------------|----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-007 - O sistema permitirá o usuário gerenciar a categoria do seu produto.                      |
| Objetivo do Teste 	| Verificar se o usuário pode criar, editar e deletar categorias de produtos.                         |
| Passos 	           | 1. Fazer login na conta da empresa <br> 2. Acessar a área de gerenciamento de categorias <br> 3. Adicionar, editar ou remover uma categoria de produto |
| Critério de Êxito  | As categorias devem ser gerenciadas corretamente, sendo exibidas nas opções disponíveis para os produtos. |


| **Caso de Teste** 	| **CT-08 - Gerar Relatório de Itens Cadastrados**                                               	|
|--------------------|----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-008 - O sistema permitirá o usuário gerar um relatório dos seus itens cadastrados.             |
| Objetivo do Teste 	| Verificar se o sistema gera relatórios de itens cadastrados corretamente.                           |
| Passos 	           | 1. Fazer login na conta da empresa <br> 2. Acessar a área de relatórios <br> 3. Gerar um relatório dos itens cadastrados |
| Critério de Êxito  | O relatório deve ser gerado corretamente, contendo todos os itens cadastrados com informações detalhadas. |


| **Caso de Teste** 	| **CT-09 - Gerenciar Fornecedores**                                                               	|
|--------------------|----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-009 - O sistema permitirá o usuário gerenciar fornecedores.                                    |
| Objetivo do Teste 	| Verificar se o usuário pode adicionar, editar e remover fornecedores.                              |
| Passos 	           | 1. Fazer login na conta da empresa <br> 2. Acessar a área de gerenciamento de fornecedores <br> 3. Adicionar, editar ou remover um fornecedor |
| Critério de Êxito  | O sistema deve permitir o gerenciamento completo dos fornecedores com sucesso.                      |


| **Caso de Teste** 	| **CT-10 - Pesquisar Produtos no Estoque com Filtros**                                            	|
|--------------------|----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-010 - O sistema permitirá o usuário pesquisar produtos no estoque usando filtros como nome, categoria ou fornecedor. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar buscas por produtos utilizando os filtros disponíveis.      |
| Passos 	           | 1. Fazer login na conta da empresa <br> 2. Acessar a área de pesquisa de produtos <br> 3. Realizar buscas utilizando diferentes filtros (nome, categoria, fornecedor) |
| Critério de Êxito  | O sistema deve retornar resultados corretos e relevantes com base nos filtros aplicados.            |


| **Caso de Teste** 	| **CT-11 - Configurar Alertas de Estoque Baixo**                                                   	|
|--------------------|----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-011 - O sistema permitirá o usuário configurar alertas para produtos com estoque baixo.         |
| Objetivo do Teste 	| Verificar se o usuário pode configurar alertas de estoque baixo.                                    |
| Passos 	           | 1. Fazer login na conta da empresa <br> 2. Acessar a área de alertas de estoque <br> 3. Configurar um alerta para produtos com estoque baixo |
| Critério de Êxito  | O alerta deve ser configurado corretamente e notificar o usuário quando o estoque atingir o limite configurado. |


| **Caso de Teste** 	| **CT-12 - Configurar Alertas para Produtos Próximos ao Vencimento**                               	|
|--------------------|----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-012 - O sistema permitirá o usuário configurar alertas para produtos próximos ao vencimento.    |
| Objetivo do Teste 	| Verificar se o usuário pode configurar alertas para produtos que estão perto de vencer.             |
| Passos 	           | 1. Fazer login na conta da empresa <br> 2. Acessar a área de alertas de vencimento <br> 3. Configurar um alerta para produtos próximos ao vencimento |
| Critério de Êxito  | O alerta deve ser configurado corretamente e notificar o usuário quando os produtos estiverem próximos ao vencimento. |


| **Caso de Teste** 	| **CT-13 - Exportar Dados de Estoque em Formato .TXT**                                             	|
|--------------------|----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-013 - O sistema permitirá o usuário exportar dados de estoque em formatos .TXT.                |
| Objetivo do Teste 	| Verificar se o usuário consegue exportar dados do estoque no formato .TXT.                          |
| Passos 	           | 1. Fazer login na conta da empresa <br> 2. Acessar a área de exportação de dados <br> 3. Selecionar a opção de exportar em formato .TXT |
| Critério de Êxito  | O arquivo .TXT deve ser gerado corretamente com os dados de estoque.                                |
