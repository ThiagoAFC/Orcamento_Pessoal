# Análise do versionamento Semântico

## .NET

### Ciclos de vida de versão do .NET

O *.NET utiliza um versionamento semântico* onde as versões do .NET adotam o ciclo de vida moderno em vez do ciclo de vida fixo usado para versões do .NET Framework. Os produtos que adotam um ciclo de vida moderno têm um modelo de suporte semelhante a um serviço, com períodos de suporte mais curtos e versões mais frequentes.

Por adotar este ciclo de vida, vemos uma maior atualização da versão major do versionamento do que estamos habituados, para contornar esta situação, apesar de realizarem constantemente a mudança de major, a equipe de desenvolvimento busca sempre ao máximo evitar problemas de compatibilidade.

### Faixas de versão

Há duas faixas de suporte para versões:

Versões do Suporte a Termos Padrão (STS)

Essas versões têm suporte até 6 meses após a próxima versão principal ou secundária.

Exemplo:

O .NET 5 é uma versão STS e foi lançado em novembro de 2020. Ele teve suporte por 18 meses, até maio de 2022.
O .NET 7 é uma versão STS e foi lançado em novembro de 2022. Ele tem suporte por 18 meses, até maio de 2024.
Versões com LTS (suporte de longo prazo)

Essas versões têm suporte por no mínimo 3 anos, ou 1 ano após a próxima versão LTS ser enviada, se essa data for inferior.

Exemplo:

O .NET Core 3.1 é uma versão LTS e foi lançado em dezembro de 2019. Ele teve suporte por 3 anos, até dezembro de 2022.
O .NET 6 é uma versão LTS e foi lançado em novembro de 2021. Ele tem suporte por 3 anos, até novembro de 2024.

As versões alternam entre LTS e STS, portanto, é possível que uma versão anterior tenha suporte por mais tempo do que uma posterior. Por exemplo, o .NET Core 3.1 era uma versão LTS com suporte até dezembro de 2022. A versão do .NET 5 foi enviada quase um ano depois, mas deixou de ter suporte antes, em maio de 2022.

### Histórico de versões

A última versão LTS lançada foi a .NET 8 em novembro de 2023 que consta com o último patch liberado o 8.0.12, e terá suporte até novembro de 2026, em contrapartida, a última versão STS lançada foi a .NET 9 que consta com o versionamento atual o patch 9.0.1 e foi lançada em novembro de 2024 e terá suporte até maio de 2026, no link abaixo podemos visualizar o histórico de atualizações e a previsão de liberações das novas versões:

https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core#lifecycle.

## C#

O *C# não utiliza versionamento semântico*, pois não controla as versões utilizando o versionamento com major, minor e patch, a numeração das versões do C# segue um esquema incremental, mas não segue exatamente o SemVer.

Em vez disso, a Microsoft define versões do C# de acordo com as mudanças no próprio compilador e na linguagem. Por exemplo:

C# 10 → Lançado com .NET 6
C# 11 → Lançado com .NET 7
C# 12 → Lançado com .NET 8

Isso significa que a versão do C# está atrelada à versão do .NET, e a Microsoft não segue um sistema explícito de versão maior (major), menor (minor) e correção (patch) conforme o SemVer tradicional.

No link abaixo estão as principais alterações e detalhes de cada versão:

https://learn.microsoft.com/pt-br/dotnet/csharp/whats-new/csharp-version-history