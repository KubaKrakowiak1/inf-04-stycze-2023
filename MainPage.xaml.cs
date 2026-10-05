namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        public List<string> Elementy { get; set; }
        public MainPage()
        {
            InitializeComponent();

            Elementy = new List<string>
            {
                "Zakupy: chleb, masło, ser",
                "Do zrobienia: obiad, umyć podłogi",
                "Weekend: kino, spacer z psem"
            };
            lista.ItemsSource = Elementy;


        }

        public void Dodaj(Object sender, EventArgs e)
        {
            Elementy.Add(nowy.Text);
            
            lista.ItemsSource = null;
            lista.ItemsSource = Elementy;
            nowy.Text = string.Empty;
        }
    }
}
