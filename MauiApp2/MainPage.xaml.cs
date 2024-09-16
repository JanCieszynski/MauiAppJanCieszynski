namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Random r = new Random();
            int jancieszynski = r.Next(1,7);
            rollValueLabel.Text = "Wylosowany rzut: " + jancieszynski.ToString();
            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnCounterClicked1(object sender, EventArgs e)
        {
            Random r = new Random();
            int jancieszynski = r.Next(1, 5);
            rollValueLabel.Text = "Wylosowany rzut: " + jancieszynski.ToString();
            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnCounterClicked3(object sender, EventArgs e)
        {
            Random r = new Random();
            int jancieszynski = r.Next(1, 11);
            rollValueLabel.Text = "Wylosowany rzut: " + jancieszynski.ToString();
            SemanticScreenReader.Announce(CounterBtn.Text);
        }

    }

}
