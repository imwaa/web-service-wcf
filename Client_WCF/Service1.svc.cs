using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Client_WCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Client> GetClients(int clientID)
        {
            string chConn = @"data source = DESKTOP-6GVOGV5; database=Hotel_Management_;integrated security = True";


            List<Client> ListeClients = new List<Client>();

            SqlConnection conn = new SqlConnection(chConn);

            conn.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM Clients_ WHERE Client_ID =" + clientID.ToString(), conn);

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                Client p = new Client();

                p.Client_ID = Int32.Parse(dr["Client_ID"].ToString());
                p.Nom = dr["Nom"].ToString();
                p.Prenom = dr["Prenom"].ToString();
                p.Adresse = dr["Adresse"].ToString();
                p.Mail = dr["Mail"].ToString();
                p.GSM = dr["GSM"].ToString();


                ListeClients.Add(p);

            }

            dr.Close();

            conn.Close();

            return ListeClients;

        }

    }
}
