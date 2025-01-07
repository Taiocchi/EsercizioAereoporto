﻿using System;
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
        private readonly object lockObj = new object(); //Per far in modo che la pista sia occupato da un aereo alla volta

        private Form1 form;

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
            if (!ListaDecollo.Contains(aereo) && aereo.RichiediAtterraggio)
                listaAtterraggio.Add(aereo);
        }
        public void RichiestaDecollo(Aereo aereo)
        {
            if (!ListaDecollo.Contains(aereo) && aereo.RichiediDecollo)
                listaDecollo.Add(aereo);
        }

        public void GestisciPista()
        {
            lock (lockObj)
            {
                if (statoPista == false)
                {
                    if (listaAtterraggio.Count > 0)
                    {
                        Aereo aereoAtterraggio = listaAtterraggio[0]; // Prendi il primo elemento
                        statoPista = true;

                        if (aereoAtterraggio != null) MessageBox.Show("L'aereo " + aereoAtterraggio.Nome + " sta atterrando");

                        if (aereoAtterraggio != null) form.PosizioneInizialeAtterraggio(aereoAtterraggio.Nome);

                        for (int i = 1; i < 5; i++)
                        {
                            Thread.Sleep(1000);
                            form.SpostaImmaggineAtterraggio();
                        }

                        statoPista = false;

                        if (aereoAtterraggio != null) MessageBox.Show("L'aereo " + aereoAtterraggio.Nome + " è atterrato");

                        listaAtterraggio.RemoveAt(0); // Rimuovi il primo elemento

                        form.AggiornaInterfaccia();

                        if (aereoAtterraggio != null) form.AggiungiComboBox(aereoAtterraggio.Nome);
                    }
                    else if (listaDecollo.Count > 0)
                    {
                        foreach (Aereo a in listaDecollo)
                        {
                            MessageBox.Show(a.Nome);
                        }

                        Aereo aereoDecollo = listaDecollo[0]; // Prendi il primo elemento
                        statoPista = true;

                        if (aereoDecollo != null) MessageBox.Show("L'aereo " + aereoDecollo.Nome + " sta decollando");

                        if (aereoDecollo != null) form.PosizioneInizialeDecollo(aereoDecollo.Nome);

                        for (int i = 1; i < 5; i++)
                        {
                            Thread.Sleep(1000);
                            form.SpostaImmaggineDecollo();
                        }

                        statoPista = false;

                        if (aereoDecollo != null) MessageBox.Show("L'aereo " + aereoDecollo.Nome + " è decollato");

                        listaDecollo.RemoveAt(0); // Rimuovi il primo elemento

                        form.AggiornaInterfaccia();

                        if (aereoDecollo != null) form.AggiungiComboBox(aereoDecollo.Nome);
                    }
                }
            }
        }

        public StazioneDiControllo(Form1 form)
        {
            this.form = form;
        }
    }
}
