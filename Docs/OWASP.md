# Análise de riscos OWASP

## Após análise do projeto, foram identificados três riscos de segurança conforme os principais riscos listados no OWASP Top 10 de 2021:

### A03:2021 – Injeção:

A aplicação pode estar vulnerável a ataques de injeção se os dados fornecidos pelo usuário não forem devidamente validados, filtrados ou higienizados. Isso inclui injeções de SQL, NoSQL, comandos do sistema operacional, entre outros.

Evidência: A aplicação aceita entradas do usuário para, por exemplo, cadastrar ou consultar transações financeiras, e essas entradas são diretamente utilizadas em consultas ou comandos sem validação adequada, onde há risco de injeção.

Mitigação: Implementar validação rigorosa de todas as entradas fornecidas pelo usuário. Utilizar consultas parametrizadas ou prepared statements para interações com bancos de dados. Evitar a construção dinâmica de comandos ou consultas utilizando dados não confiáveis.

### A05:2021 – Configuração Incorreta de Segurança:

A aplicação pode estar vulnerável se houver configurações de segurança inadequadas ou padrões inseguros. Isso inclui a exposição de mensagens de erro detalhadas, habilitação de recursos desnecessários ou uso de contas padrão com senhas não alteradas.

Evidência: A aplicação está configurada para exibir mensagens de erro detalhadas que revelem informações sensíveis ou técnicas, isso indica uma configuração de segurança inadequada.

Mitigação: Desabilitar a exibição de mensagens de erro detalhadas para os usuários finais. Garantir que todas as contas utilizem senhas fortes e únicas, alterando as senhas padrão.

### A04:2021 – Design Inseguro:

A aplicação pode apresentar falhas de design que comprometem a segurança, como a ausência de controles de segurança essenciais ou a falta de validação em fluxos críticos.

Evidência: A aplicação não implementa controles de acesso adequados, permitindo que usuários não autorizados acessem funcionalidades restritas, além de não haver validação suficiente em processos críticos, como transações financeiras, isso indica um design inseguro.

Mitigação: Realizar uma modelagem de ameaças para identificar possíveis falhas no design. Implementar controles de segurança desde as fases iniciais do desenvolvimento, garantindo que todas as funcionalidades críticas possuam validações e restrições adequadas.