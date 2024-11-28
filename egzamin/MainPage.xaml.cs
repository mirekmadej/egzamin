namespace egzamin
{
    class Lakier
    {
        public int nr { get; private set; }
        public string img { get; private set; }
        public string odcien { get; private set; }
        public string nazwa { get; private set; }
        public string reklama { get; private set; }
        public string opis { get; private set; }
        public double cena { get; private set; }
        public Lakier(int nr, string img, string odcien, string nazwa, string opis, string reklama,  double cena)
        {
            this.nr = nr;
            this.img = img;
            this.odcien = odcien;
            this.nazwa = nazwa;
            this.reklama = reklama;
            this.opis = opis;
            this.cena = cena;
        }

    }  
    public partial class MainPage : ContentPage
    {
        private static List<Lakier> lakiery = new List<Lakier>();
        private static int numer = 1000000;
        private static int ileKoszyk = 0;
        private static double cena = 0;
        private static int ileLakierow = 0;

        public MainPage()
        {
            lakiery.Add(new Lakier(1,"f1.jpg","fioletowy","No risk No Story", "Oszczedzasz 33%", "Bestseller", 27.29));
            lakiery.Add(new Lakier(2,"f2.jpg","fioletowy", "Moony Whispers", "Mój wybór Kasia Kot", "PROMOCJA", 27.29));
            lakiery.Add(new Lakier(3,"f3.jpg","fioletowy", "Midnight Love", "XMAS Trend", "", 27.29));
            ileLakierow = lakiery.Count;
            InitializeComponent();
        }

        private void btnPoprzedni(object sender, EventArgs e)
        {
            numer--;
            Lakier lakier = lakiery[numer % ileLakierow];
            imgLakier.Source = lakier.img;
            lblNazwa.Text = lakier.nazwa;
            lblCena.Text = lakier.cena.ToString("#.00") + " PLN";
            lblOpis.Text = lakier.opis;
            if (lakier.reklama.Length > 0)
            {
                lblReklama.IsVisible = true;
                lblReklama.Text = lakier.reklama;
            }
            else
                lblReklama.IsVisible = false;
        }
        private void btnNastepny(object sender, EventArgs e)
        {
            numer++;
            Lakier lakier = lakiery[numer%ileLakierow];
            imgLakier.Source = lakier.img;
            lblNazwa.Text = lakier.nazwa;
            lblCena.Text = lakier.cena.ToString("#.00") + " PLN";
            lblOpis.Text = lakier.opis;
            if(lakier.reklama.Length > 0 )
            {
                lblReklama.IsVisible = true;
                lblReklama.Text = lakier.reklama;
            }
            else
                lblReklama.IsVisible=false;

        }
        private void btnDoKoszyka(object sender, EventArgs e)
        {
            Lakier lakier = lakiery[numer % ileLakierow];
            cena += lakier.cena;
            ileKoszyk++;
            string s = $"w koszyku: {ileKoszyk.ToString()} szt.";
            s += $"\n {cena.ToString("0.00")} PLN";
            lblKoszyk.Text = s;
        }
    }

}
