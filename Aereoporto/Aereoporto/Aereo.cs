using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aereoporto
{
    class Aereo
    {
        private string marca;
        private string modello;
        private bool richiediAtterraggio = false;
        private bool richiediDecollo = false;
        private string nome;

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
        }
        
        public void RichiestaDecollo()
        {
            richiediDecollo = true;
        }

        public Aereo(string modello, string marca)
        {
            this.modello = modello;
            this.marca = marca;

            nome = marca + " - " + modello;
        }
    }
}
