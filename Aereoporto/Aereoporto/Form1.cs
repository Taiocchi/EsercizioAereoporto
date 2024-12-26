using System;
using System.Threading;
using System.Windows.Forms;

namespace Aereoporto
{
    public partial class Form1 : Form
    {
        private StazioneDiControllo stazione;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            stazione = new StazioneDiControllo(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Decolla_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Seleziona un aereo dalla lista!");
                return;
            }

            string selezionato = comboBox1.SelectedItem.ToString();
            string[] dati = selezionato.Split(" - ");
            string Marca = dati[0];
            string Modello = dati[1];

            comboBox1.Items.Remove(selezionato); 

            Aereo aereo = new Aereo(Marca, Modello);
            aereo.RichiestaDecollo();

            stazione.RichiestaDecollo(aereo);

            Thread threadAereo = new Thread(() =>
            {
                stazione.GestisciPista();
                AggiornaInterfaccia();
            });


            threadAereo.Start();
            AggiornaInterfaccia();
        }

        private void Atterra_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Seleziona un aereo dalla lista!");
                return;
            }

            string selezionato = comboBox1.SelectedItem.ToString();
            string[] dati = selezionato.Split(" - ");
            string Marca = dati[0];
            string Modello = dati[1];

            comboBox1.Items.Remove(selezionato);

            Aereo aereo = new Aereo(Marca, Modello);
            aereo.RichiestaAtterraggio();

            stazione.RichiestaAtterraggio(aereo);

            Thread threadAereo = new Thread(() =>
            {
                stazione.GestisciPista();
                AggiornaInterfaccia();
            });

            threadAereo.Start();
            AggiornaInterfaccia();
        }

        public void AggiungiComboBox(string stringa)
        {
            comboBox1.Items.Add(stringa);
        }

        // Metodo per aggiornare la UI. Usa Invoke per garantire che l'aggiornamento avvenga nel thread principale
        public void AggiornaInterfaccia()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(AggiornaInterfaccia));
                return;
            }

            // Aggiornamento delle listbox
            ListaDecolli.DataSource = null;
            ListaDecolli.DataSource = stazione.ListaDecollo;
            ListaDecolli.DisplayMember = "Nome";

            ListaAtterraggi.DataSource = null;
            ListaAtterraggi.DataSource = stazione.ListaAtterraggio;
            ListaAtterraggi.DisplayMember = "Nome";
        }
    }
}
