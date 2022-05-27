namespace KioscoDBF.Data
{
    public class Conexion
    {
        public string cadenaSQL = string.Empty;

        public Conexion()
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var builder = configurationBuilder.AddJsonFile("appsettings.Development.json", optional:true)
                .Build();
            cadenaSQL = builder.GetSection("conection:cadenaConexion").Value;
        }

        public string GetConection()
        {
            return cadenaSQL;
        }
    }
}
