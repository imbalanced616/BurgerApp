namespace BurgerApp;

public partial class MainPage : ContentPage
{
	public static List<Burger> Burgers = new List<Burger>();
    public static Burger burger;

    public MainPage()
	{
		InitializeComponent();

        Burgers.Add(new Burger("Бургер из говядины", 300, 1, 1, 0, 2, 2));
        Burgers.Add(new Burger("Бургер из свинины", 240, 0, 1, 0, 0, 2));
        Burgers.Add(new Burger("Бургер с курицей", 200, 2, 2, 1, 1, 1));

        MessagingCenter.Subscribe<AddPage, Burger>(this, "AddPage", (page, burger) => 
        {
            lstBurgers.ItemsSource = null;
            Burgers.Add(burger);
            lstBurgers.ItemsSource = Burgers;

            int totalPrice = 0;
            foreach (var b in Burgers) totalPrice += b.PRICE;
            TotalPrice.Text = totalPrice.ToString();
        });

        lstBurgers.ItemsSource = Burgers;

        int totalPrice = 0;
        foreach (var b in Burgers) totalPrice += b.PRICE;
        TotalPrice.Text = totalPrice.ToString();

        var tapAddBurger = new TapGestureRecognizer();
        tapAddBurger.Tapped += async (s, e) =>
        {
            await Navigation.PushAsync(new AddPage());
        };
        addBurgerImage.GestureRecognizers.Add(tapAddBurger);
    }
}

