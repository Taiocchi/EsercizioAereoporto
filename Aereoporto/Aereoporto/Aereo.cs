using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aereoporto
{
    public class Aereo
    {
        private string marca;
        private string modello;
        private bool richiediAtterraggio = false;
        private bool richiediDecollo = false;
        private string nome;
        StazioneDiControllo stazione;

        public string Modello
        {
            get { return modello; }
        }

        public string Marca
        {
            get { return marca; }
        }
        public string Nome
        {
            get { return nome; }
        }

        public bool RichiediAtterraggio
        {
            get { return richiediAtterraggio; }
        }
        public bool RichiediDecollo
        {
            get { return richiediDecollo; }
        }
        public void RichiestaAtterraggio()
        {
            richiediAtterraggio = true;
            stazione.RichiestaAtterraggio(this);

        }

        public void RichiestaDecollo()
        {
            richiediDecollo = true;
            stazione.RichiestaDecollo(this);
        }

        public Aereo(string marca, string modello, StazioneDiControllo stazione)
        {
            this.modello = modello;
            this.marca = marca;
            this.stazione = stazione;
            nome = marca + " - " + modello;
        }
    }
}
