using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Client_WCF
{
    public class Client
    {
        private int _Client_ID;
        private string _Nom;
        private string _Prenom;
        private string _Adresse;
        private string _Mail;
        private string _GSM;

        [DataMember]
        public int Client_ID
        {
            get { return _Client_ID; }
            set { _Client_ID = value; }
        }

        [DataMember]

        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        [DataMember]

        public string Prenom
        {
            get { return _Prenom; }
            set { _Prenom = value; }
        }

        [DataMember]

        public string Adresse
        {
            get { return _Adresse; }
            set { _Adresse = value; }
        }

        [DataMember]

        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }

        [DataMember]

        public string GSM
        {
            get { return _GSM; }
            set { _GSM = value; }
        }

    }
}