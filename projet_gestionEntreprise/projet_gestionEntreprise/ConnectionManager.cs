using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_gestionEntreprise
{
    class ConnectionManager
    {
        private string connectionString;
        public ConnectionManager()
        {
            // Retrieve connection string from app.config
            connectionString = ConfigurationManager.ConnectionStrings["projet_gestionEntreprise.Properties.Settings.gestionEntrepriseConnectionString1"].ConnectionString;
        }
        public string getConnectionString()
        {
            return connectionString;
        }
    }
}
