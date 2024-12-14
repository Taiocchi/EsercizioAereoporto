using System.Windows.Forms;

namespace Aereoporto
{
    public partial class Form1 : Form
    {
        private Thread controllo;
        StazioneDiControllo stazione = new StazioneDiControllo();
        public Form1()
        {
            InitializeComponent();
            controllo = new Thread(() => stazione.GestisciPista());//Sintassi corretta, in questo modo passa un delegato. SBAGLIATO: Thread threadAereo = new Thread(stazione.GestisciPista())
            controllo.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AggiungiAereo_Click(object sender, EventArgs e)
        {
            string selezionato = comboBox1.SelectedItem.ToString();

            string[] dati = selezionato.Split(" - "); //In questo modo posso dividere il tipo e il numero seriale di ogni prodotto inseriti tramite la comboBox1 

            string Modello = dati[0];
            string Marca = dati[1];

            Aereo aereo = new Aereo(Modello, Marca);
            aereo.RichiestaDecollo();

            Thread threadAereo = new Thread(() => aereo.Operare(stazione)); //Sintassi corretta, in questo modo passa un delegato. SBAGLIATO: Thread threadAereo = new Thread(aereo.Operare(stazione))
            threadAereo.Start();

            AggiornaInterfaccia();
        }

        private void Atterra_Click(object sender, EventArgs e)
        {
            string selezionato = comboBox1.SelectedItem.ToString();

            string[] dati = selezionato.Split(" - "); //In questo modo posso dividere il tipo e il numero seriale di ogni prodotto inseriti tramite la comboBox1 

            string Modello = dati[0];
            string Marca = dati[1];

            Aereo aereo = new Aereo(Modello, Marca);
            aereo.RichiestaAtterraggio();

            Thread threadAereo = new Thread(() => aereo.Operare(stazione)); //Sintassi corretta, in questo modo passa un delegato. SBAGLIATO: Thread threadAereo = new Thread(aereo.Operare(stazione))
            threadAereo.Start();

            AggiornaInterfaccia();
        }

        private void AggiornaInterfaccia()
        {
            ListaDecolli.DataSource = null;
            ListaDecolli.DataSource = stazione.ListaDecollo;
            ListaDecolli.DisplayMember = "Nome";

            ListaAtterraggi.DataSource = null;
            ListaAtterraggi.DataSource = stazione.ListaAtterraggio;
            ListaAtterraggi.DisplayMember = "Nome";
        }
    }
}
