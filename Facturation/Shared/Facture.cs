using System;
using System.Collections.Generic;

namespace Facturation
{
    public class Facture
    {
        public string Client { get; set; }
        public string numero { get; set; }
        public DateTime dateEmission { get; }
        public DateTime dateAttendu { get; }
        public float MontantDu { get; }
        public float MontantRegle { get; }



        public Facture(string client,string numero,string dateEmission,string dateAttendu,float montantDu,float montantRegle)
        {
            if (DateTime.TryParse(dateEmission, out DateTime dtEmission) && DateTime.TryParse(dateAttendu, out DateTime dtReglement))
            {
                this.Client = client;
                this.numero = numero;
                this.dateEmission = dtEmission;
                this.dateAttendu = dtReglement;
                this.MontantDu = montantDu;
                this.MontantRegle = montantRegle;
            }
        }
        
    }
}