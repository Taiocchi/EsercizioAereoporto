using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aereoporto
{
    class StazioneDiControllo
    {
        private List<Aereo> listaDecollo = new List<Aereo>();
        private List<Aereo> listaAtterraggio = new List<Aereo>();
        private bool statoPista = false; //Se false allora pista libera, se true allora pista occupata

        public List<Aereo> ListaDecollo
        {
            get { return listaDecollo; }
        }

        public List<Aereo> ListaAtterraggio
        {
            get { return listaAtterraggio; }
        }

        public bool StatoPista
        {
            get { return statoPista; }
        }

        public void RichiestaAtterraggio(Aereo aereo)
        {
            listaAtterraggio.Add(aereo);
        }
        public void RichiestaDecollo(Aereo aereo)
        {
            listaDecollo.Add(aereo);
        }

        public void GestisciPista()
        {
            if(statoPista == false)
            {
                if (listaAtterraggio.Count > 0)
                {
                    Aereo aereoAtterraggio = listaAtterraggio[0]; // Prendi il primo elemento
                    listaAtterraggio.RemoveAt(0); // Rimuovi il primo elemento
                    statoPista = true;
                    MessageBox.Show("L'aereo sta atterrando");
                    Thread.Sleep(2000);
                    statoPista = false;
                    MessageBox.Show("L'aereo è atterrato");
                }
                else if (listaDecollo.Count > 0)
                {
                    Aereo aereoDecollo = listaDecollo[0]; // Prendi il primo elemento
                    listaDecollo.RemoveAt(0); // Rimuovi il primo elemento
                    statoPista = true;
                    MessageBox.Show("L'aereo sta decollando");
                    Thread.Sleep(2000);
                    statoPista = false;
                    MessageBox.Show("L'aereo è decollato");
                }
            }
            else
            {
                MessageBox.Show("La pista è gia occupata");
            }
        }

        public StazioneDiControllo()
        {
            
        }
    }
}
