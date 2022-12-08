using System;

namespace LibrarieTestUnitaires
{
    public class Prenom
    {
        private string prenom;

        public string unPrenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public Prenom(string prenom)
        {
            this.prenom = prenom;
        }

        public string HelloPrenom()
        {
            string res = null;

            if (prenom == "" || prenom.Length > 30)
            {
                throw new Exception("Prénom de plus de 30 lettres ou vide");
            }
            else
            {
                res = "Hello " + prenom;
            }

            return res;
        }

    }
}
