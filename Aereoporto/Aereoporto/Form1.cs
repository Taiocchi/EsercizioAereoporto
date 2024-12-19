using System;
using System.Threading;
using System.Windows.Forms;

namespace Aereoporto
{
    public partial class Form1 : Form
    {
        private Thread controllo;
        private StazioneDiControllo stazione = new StazioneDiControllo(); 
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            controllo = new Thread(() => stazione.GestisciPista());
            controllo.Start(); // Avvia il thread di gestione della pista
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
            string Modello = dati[0];
            string Marca = dati[1];

            comboBox1.Items.Remove(selezionato);

            Aereo aereo = new Aereo(Modello, Marca);
            aereo.RichiestaDecollo();

            stazione.RichiestaDecollo(aereo);
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
            string Modello = dati[0];
            string Marca = dati[1];

            comboBox1.Items.Remove(selezionato);

            Aereo aereo = new Aereo(Modello, Marca);
            aereo.RichiestaAtterraggio();

            stazione.RichiestaAtterraggio(aereo);
            AggiornaInterfaccia();
        }

        // Metodo per aggiornare la UI. Usa Invoke per garantire che l'aggiornamento avvenga nel thread principale
        private void AggiornaInterfaccia()
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
