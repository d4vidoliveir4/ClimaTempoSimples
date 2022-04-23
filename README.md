# ClimaTempoSimples
 
O projeto esta usando uma string de conexão do SQLServer Express, para alteração mudar no Web.Config na tag <connectionStrings>. Caso necessario alterar de acordo com o exemplo para SQLServer:
 
 <connectionStrings>
    <add name="ClimaTempoSimplesContext" connectionString="Data Source=<Instancia>;Initial Catalog=<Banco de dados>;Integrated Security=True;User ID=<Usuario>;Password=<Senha>" providerName="System.Data.SqlClient" />
  </connectionStrings>
 
 Para executar o projeto basta abrir a Solução no Visual Studio e executar o projeto. Será criado o banco de dados e serão incluidos alguns dados de exemplo.
