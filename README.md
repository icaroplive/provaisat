# ISAT Developer Exam #

### O que é este projeto

Este projeto visa instigar o desenvolvedor a demostrar seus conhecimentos.

### Resumo do projeto
Este projeto está construído em NetCore na **versão 3.1.401**, com esquema de arquitetura inspirada em **Clean Architecture**, ao qual este conta com 3 sub projetos:
- ISAT.Developer.Exam.Core
- ISAT.Developer.Exam.Infrastructure
- ISAT.Developer.Exam.Web

Ferramentas que podem ser usadas para desenvolver:
- VSCode.
- VS 2019.
- Sua criatividade.

### Utilitários
- Arquivo docker compose: **isat-developer-exam\solution-utilities\docker**
- Minificador de CSS e JS no projeto **ISAT.Developer.Exam.Web** bundleconfig.json
- Projeto **ISAT.Developer.Exam.Core** conta com FluentValidation.

### Esperamos que você
- Implemente a solução descrita.
- Entretanto, o mais importante é conseguirmos analisar a maneira que você codifica, não tem problema se não for possível terminar tudo no tempo determinado.

### Você pode
- Utilizar pacotes NuGet (https://www.nuget.org/) que julgar necessário.
- Utilizar alguma framework para construção do FrontEnd: VueJS ou Angular. Mas caso queira pode-se utilizar o bom e velho razor do AspNet Core.
- No acesso à banco de dados, você pode usar algum ORM: EF Core, NHibenate, Dapper ou outro, assim como fazer manualmente utilizando ADO. O projeto está com esquema para EF Core, porem pode ser alterado de acordo com sua escolha.
- Utilizar Dependency Injection.
- Utilizar FluentValidation.

### Observações
- O banco de dados utilizado é: SQLServer 2017 em docker, que já existe no arquivo yml.
- Caso queira pode executar em algum outro banco (SQLServer) de sua escolha e depois enviar atrelado ao projeto o arquivo .sql.(Caso utilizar database first)

### Desafio
Eu como administrador desejo que seja possível listar usuários cadastrados na plataforma, bem como realizar criação, edição e exclusão do mesmo.
Os campos de cadastro do usuário são:
- Nome *
- Sobrenome *
- E-mail *
- Idade 

Obs: Campos * são obrigatórios.

**Critérios de aceite:**
- Não pode existir dois ou mais usuários com mesmo e-mail. Caso ocorra exibir uma mensagem informando que o e-mail já existe cadastrado.
- Não pode existir dois ou mais usuários com mesmo nome e sobrenome. Caso ocorra exibir uma mensagem informando que o nome e sobrenome já existe cadastrado.
- Idade não pode ser menor que 10 e maior que 100. Caso ocorra informar que a idade é inválida.
- Os campos nome, sobrenome e email não pode ter mais que 255 caracteres. Caso ocorra informar que o limite de caracteres foi atingido.

**Boa Prova!**

**Sucesso!**

Powered by ISAT