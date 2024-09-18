# Plano de Testes de Usabilidade

Após a execução dos testes de usabilidade, foi gerado um relatório com base nas avaliações realizadas. Para isso, foi seguido o roteiro previamente estabelecido no plano de testes de usabilidade.

### **Caso de Teste: CT-01 – Responsividade do sistema**

| **Requisito Associado** 	| RNF-001 - O sistema deve ser responsivo. |
|:---:	|:---:	|
| **Descrição** 	| Verificar se o sistema se adapta de forma adequada a diferentes tamanhos de tela (desktop, tablet, smartphones). |
| **Prioridade** 	| Média |
| **Ambiente de Teste** 	| Diversos dispositivos (desktop, tablet, smartphone) e resoluções de tela. |
| **Critérios de Aceitação** 	| O sistema deve apresentar layout consistente, funcionalidade completa e sem distorções visuais em todos os dispositivos testados. |
| **Ação** 	| Acessar o sistema em diferentes dispositivos e navegadores e verificar a responsividade do layout e elementos interativos. |
| **Resultado Esperado** 	| O sistema deve ajustar-se automaticamente a cada dispositivo, sem perda de funcionalidade ou distorção de design. |


### **Caso de Teste: CT-02 – Compatibilidade de navegadores**

| **Requisito Associado** 	| RNF-002 - O sistema deve ser compatível com os principais navegadores do mercado: Google Chrome, Firefox e Microsoft Edge. |
|:---:	|:---:	|
| **Descrição** 	| Validar a compatibilidade do sistema com os navegadores mencionados, garantindo que ele funcione corretamente em todos. |
| **Prioridade** 	| Média |
| **Ambiente de Teste** 	| Google Chrome, Firefox e Microsoft Edge, nas versões mais recentes. |
| **Critérios de Aceitação** 	| O sistema deve funcionar de forma consistente em todos os navegadores testados, sem erros visuais ou funcionais. |
| **Ação** 	| Acessar o sistema nos navegadores indicados e verificar o comportamento de todas as funcionalidades e o layout da interface. |
| **Resultado Esperado** 	| O sistema deve apresentar o mesmo comportamento e aparência em todos os navegadores testados. |


### **Caso de Teste: CT-03 – Intuitividade e facilidade de uso**

| **Requisito Associado** 	| RNF-003 - O sistema deve ser intuitivo e fácil de usar, garantindo uma experiência agradável ao usuário. |
|:---:	|:---:	|
| **Descrição** 	| Testar a usabilidade geral do sistema, focando em quão intuitiva é a navegação e a realização de tarefas pelo usuário. |
| **Prioridade** 	| Média |
| **Ambiente de Teste** 	| Desktop e dispositivos móveis. |
| **Critérios de Aceitação** 	| O usuário deve conseguir navegar e completar tarefas comuns com facilidade, sem necessitar de treinamento prévio. |
| **Ação** 	| Simular fluxos de trabalho comuns, como cadastro, consulta e navegação no sistema, verificando a facilidade de uso. |
| **Resultado Esperado** 	| O sistema deve ser fácil de usar, com menus claros, navegação intuitiva e respostas rápidas às ações do usuário. |


### **Caso de Teste: CT-04 – Publicação em ambiente acessível ao público**

| **Requisito Associado** 	| RNF-004 - O sistema deve ser publicado em ambiente acessível ao público na Internet. |
|:---:	|:---:	|
| **Descrição** 	| Verificar se o sistema está disponível e acessível ao público através de navegadores comuns. |
| **Prioridade** 	| Alta |
| **Ambiente de Teste** 	| Internet pública (usando redes Wi-Fi e dados móveis). |
| **Critérios de Aceitação** 	| O sistema deve estar disponível e acessível a qualquer pessoa com conexão à Internet, sem restrições indevidas. |
| **Ação** 	| Tentar acessar o sistema a partir de diferentes redes e dispositivos para validar sua disponibilidade e acessibilidade. |
| **Resultado Esperado** 	| O sistema deve ser acessível em redes públicas e privadas, sem problemas de conexão ou acesso restrito. |


### **Caso de Teste: CT-05 – Contraste entre elementos da tela**

| **Requisito Associado** 	| RNF-005 - O sistema deve apresentar um bom nível de contraste entre os elementos da tela. |
|:---:	|:---:	|
| **Descrição** 	| Verificar se os elementos visuais do sistema apresentam contraste adequado para facilitar a leitura e uso, especialmente por pessoas com deficiências visuais. |
| **Prioridade** 	| Média |
| **Ambiente de Teste** 	| Desktop e dispositivos móveis. |
| **Critérios de Aceitação** 	| Todos os textos e ícones devem ser legíveis, com contraste suficiente entre o fundo e os elementos na tela. |
| **Ação** 	| Analisar o design do sistema em diferentes dispositivos, verificando o contraste de cores conforme padrões de acessibilidade (WCAG). |
| **Resultado Esperado** 	| O sistema deve ter um nível de contraste apropriado entre o fundo e o texto ou ícones, facilitando a leitura e navegação. |


### **Caso de Teste: CT-06 – Prevenção de duplicação de itens no Estoque**

| **Requisito Associado** 	| RNF-006 - O sistema deve garantir que não ocorra duplicação de itens no Estoque. |
|:---:	|:---:	|
| **Descrição** 	| Verificar se o sistema previne a duplicação de itens durante a adição ou movimentação de produtos no estoque. |
| **Prioridade** 	| Alta |
| **Ambiente de Teste** 	| Módulo de Estoque do sistema. |
| **Critérios de Aceitação** 	| O sistema deve alertar o usuário e evitar a duplicação de itens no estoque. |
| **Ação** 	| Tentar adicionar itens duplicados no estoque e verificar se o sistema impede a operação e exibe um aviso. |
| **Resultado Esperado** 	| O sistema deve impedir a duplicação de itens no estoque, exibindo uma mensagem de erro ou notificação ao usuário. |
