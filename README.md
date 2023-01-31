# Proposta do Projeto

O Desafio API Loja Integrada tem como objetivo desenvolver API's que façam papéis cruciais no sistema principal de uma empresa.

# Passo a Passo

Guia de Como Instalar e Configurar a plataforma Visual Studio com os Frameworks e Repositórios:

1.	Instalar o ambiente de desenvolvimento Visual Studio. (Versão Utilizada: Visual Studio 2022 Versão 17.4)
2.	No Ambiente "Criar um Novo Projeto" selecionar a opção "Biblioteca de Classes" e escolher a versão do .NET (Versão Utilizada: .NET 6.0).
3.  Intalar a Extensão EF Power Tools. <https://marketplace.visualstudio.com/items?itemName=ErikEJ.EFCorePowerTools>
4.	Instalar o SQL Server e um ambiente de edição SQL. (Versões Utilizadas: SQL Server 2022 | SQL Server Management Studio Management Studio 19)
5.	No Visual Studio, criar um novo projeto, selecionar a opção "Aplicativo Web do ASP.NET Core (Model-View-Controller)" e escolher a versão do .NET (Versão Utilizada: .NET 6.0)
6.  No Visual Studio, na seção do Gerenciador de Soluções, selecionar o projeto da biblioteca de classes e "Gerenciar Pacotes do NuGet".
7.  Instalar os pacotes listados acima. 
8.  Fazer o mesmo procedimento no projeto do API ASP.NET.
9.  Criar um banco de dados com relacionamento no SSMS.
10. Selecionar o projeto das classes e escolher a opção "EFCorePowerTools -> Reverse Engineer".
11. Adicionar o Banco de Dados com as Credenciais e verificar se as tabelas e colunas estão inclusas, ao criar será formado um conjunto de bibliotecas de classes para cada tabela.

# Procedimento

1.  Criar um repositório base e incluir as funções que serão exercidas para o objeto. Criar uma interface de modelo, para adicionar os métodos utilizados nos repositórios. Depois criar uma interface para cada tabela, incluindo o relacionamento
e referenciar o modelo criado anteriormente. No repositório base, referenciar a interface modelo e incluir um construtor para o contexto criado pelo 'EF Power Tools'. Depois criar um repositório para cada tabela, incluindo o relacionamento, e
referenciando o repositório base e a respectiva interface.

2. Criar um diretório de serviços, criar um serviço para cada tabela e instanciar o repositório respectivo para cada tabela, e um construtor para o repositório.

3. Criar um Controller para cada tabela, declarar a função controller, referenciar o serviço respectivo e criar interfaces de resultado de uma ação para cada interação do usuário com o sistema.

4. Para toda interface criada, retornar uma View que contenha o 'HTML' que será acessado pelo cliente, além das funções exercidas. (Exibição do Razor Utilizada).

5. No diretório Views, no Projeto Web, irão conter todas as views criadas e um diretório shared, que contém o layout padrão do sistema, podendo ser alterado.

6. Desenvolver o Projeto.

# Referências e Links Importantes

Youtube: 'Playlist ASP.NET CORE MVC DO ZERO!' -> Café Com Bug | <https://www.youtube.com/playlist?list=PLhna1crYw0SP_CN5q8_DfF2aMQ2ez_6Wd>
Youtube: Configurações do Git  'Mód02' -> Marco Bruno | <https://www.youtube.com/@MarcoBrunoDev>
Youtube: 'Curso de C# Para Iniciantes - C# 10 .NET 6 e VS Code' -> Fredi | <https://www.youtube.com/watch?v=oTivhgjbhIg&t=5470s>
Youtube: 'Curso de C# - Aprenda o essencial em 5 HORAS' -> Victor Lima - Guia do Programador | <https://www.youtube.com/watch?v=PKMm-cHe56g>
Youtube: C#, .NET, Azure, Moq, etc. -> Código Fonte TV | <https://www.youtube.com/@codigofontetv>

- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)