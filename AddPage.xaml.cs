namespace BurgerApp;

public partial class AddPage : ContentPage
{
    int Mode = 0;
	public AddPage()
	{
		InitializeComponent();
    }

    private void MinusSalad_Clicked(object sender, EventArgs e)
    {
        if (int.Parse(countSalad.Text) != 0)
        {
            int count = int.Parse(countSalad.Text);
            count--;
            countSalad.Text = count.ToString();

            BurgerPrice.Text = (int.Parse(BurgerPrice.Text) - 10).ToString();
            totalBurgerPrice.Text = (int.Parse(countBurgerPrice.Text) * int.Parse(BurgerPrice.Text)).ToString();
        }
    }
    private void PlusSalad_Clicked(object sender, EventArgs e)
    {
        if (int.Parse(countSalad.Text) != 9)
        {
            int count = int.Parse(countSalad.Text);
            count++;
            countSalad.Text = count.ToString();

            BurgerPrice.Text = (int.Parse(BurgerPrice.Text) + 10).ToString();
            totalBurgerPrice.Text = (int.Parse(countBurgerPrice.Text) * int.Parse(BurgerPrice.Text)).ToString();
        }
    }

    private void MinusTomato_Clicked(object sender, EventArgs e)
    {
        if (int.Parse(countTomato.Text) != 0)
        {
            int count = int.Parse(countTomato.Text);
            count--;
            countTomato.Text = count.ToString();

            BurgerPrice.Text = (int.Parse(BurgerPrice.Text) - 5).ToString();
            totalBurgerPrice.Text = (int.Parse(countBurgerPrice.Text) * int.Parse(BurgerPrice.Text)).ToString();
        }
    }
    private void PlusTomato_Clicked(object sender, EventArgs e)
    {
        if (int.Parse(countTomato.Text) != 9)
        {
            int count = int.Parse(countTomato.Text);
            count++;
            countTomato.Text = count.ToString();

            BurgerPrice.Text = (int.Parse(BurgerPrice.Text) + 5).ToString();
            totalBurgerPrice.Text = (int.Parse(countBurgerPrice.Text) * int.Parse(BurgerPrice.Text)).ToString();
        }
    }

    private void MinusOnion_Clicked(object sender, EventArgs e)
    {
        if (int.Parse(countOnion.Text) != 0)
        {
            int count = int.Parse(countOnion.Text);
            count--;
            countOnion.Text = count.ToString();

            BurgerPrice.Text = (int.Parse(BurgerPrice.Text) - 5).ToString();
            totalBurgerPrice.Text = (int.Parse(countBurgerPrice.Text) * int.Parse(BurgerPrice.Text)).ToString();
        }
    }
    private void PlusOnion_Clicked(object sender, EventArgs e)
    {
        if (int.Parse(countOnion.Text) != 9)
        {
            int count = int.Parse(countOnion.Text);
            count++;
            countOnion.Text = count.ToString();

            BurgerPrice.Text = (int.Parse(BurgerPrice.Text) + 5).ToString();
            totalBurgerPrice.Text = (int.Parse(countBurgerPrice.Text) * int.Parse(BurgerPrice.Text)).ToString();
        }
    }

    private void MinusCucumber_Clicked(object sender, EventArgs e)
    {
        if (int.Parse(countCucumber.Text) != 0)
        {
            int count = int.Parse(countCucumber.Text);
            count--;
            countCucumber.Text = count.ToString();

            BurgerPrice.Text = (int.Parse(BurgerPrice.Text) - 15).ToString();
            totalBurgerPrice.Text = (int.Parse(countBurgerPrice.Text) * int.Parse(BurgerPrice.Text)).ToString();
        }
    }
    private void PlusCucumber_Clicked(object sender, EventArgs e)
    {
        if (int.Parse(countCucumber.Text) != 9)
        {
            int count = int.Parse(countCucumber.Text);
            count++;
            countCucumber.Text = count.ToString();

            BurgerPrice.Text = (int.Parse(BurgerPrice.Text) + 15).ToString();
            totalBurgerPrice.Text = (int.Parse(countBurgerPrice.Text) * int.Parse(BurgerPrice.Text)).ToString();
        }
    }

    private void MinusCount_Clicked(object sender, EventArgs e)
    {
        if (int.Parse(countBurger.Text) != 0)
        {
            int count = int.Parse(countBurger.Text);
            count--;
            countBurger.Text = count.ToString();

            countBurgerPrice.Text = count.ToString();
            totalBurgerPrice.Text = (count * int.Parse(BurgerPrice.Text)).ToString();
        }
    }
    private void PlusCount_Clicked(object sender, EventArgs e)
    {
        if (int.Parse(countBurger.Text) != 9)
        {
            int count = int.Parse(countBurger.Text);
            count++;
            countBurger.Text = count.ToString();

            countBurgerPrice.Text = count.ToString();
            totalBurgerPrice.Text = (count * int.Parse(BurgerPrice.Text)).ToString();
        }
    }

    private void beefPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(beefPicker.SelectedIndex == 1 && Mode == 0)
        {
            BurgerPrice.Text = (int.Parse(BurgerPrice.Text) - 60).ToString();
            totalBurgerPrice.Text = (int.Parse(countBurgerPrice.Text) * int.Parse(BurgerPrice.Text)).ToString();
            Mode = 1;
        }
        if (beefPicker.SelectedIndex == 2 && Mode == 0)
        {
            BurgerPrice.Text = (int.Parse(BurgerPrice.Text) - 100).ToString();
            totalBurgerPrice.Text = (int.Parse(countBurgerPrice.Text) * int.Parse(BurgerPrice.Text)).ToString();
            Mode = 2;
        }
        if (beefPicker.SelectedIndex == 0 && Mode == 1)
        {
            BurgerPrice.Text = (int.Parse(BurgerPrice.Text) + 60).ToString();
            totalBurgerPrice.Text = (int.Parse(countBurgerPrice.Text) * int.Parse(BurgerPrice.Text)).ToString();
            Mode = 0;
        }
        if (beefPicker.SelectedIndex == 2 && Mode == 1)
        {
            BurgerPrice.Text = (int.Parse(BurgerPrice.Text) - 40).ToString();
            totalBurgerPrice.Text = (int.Parse(countBurgerPrice.Text) * int.Parse(BurgerPrice.Text)).ToString();
            Mode = 2;
        }
        if (beefPicker.SelectedIndex == 0 && Mode == 2)
        {
            BurgerPrice.Text = (int.Parse(BurgerPrice.Text) + 100).ToString();
            totalBurgerPrice.Text = (int.Parse(countBurgerPrice.Text) * int.Parse(BurgerPrice.Text)).ToString();
            Mode = 0;
        }
        if (beefPicker.SelectedIndex == 1 && Mode == 2)
        {
            BurgerPrice.Text = (int.Parse(BurgerPrice.Text) + 40).ToString();
            totalBurgerPrice.Text = (int.Parse(countBurgerPrice.Text) * int.Parse(BurgerPrice.Text)).ToString();
            Mode = 1;
        }
    }

    private void AddOrder_Clicked(object sender, EventArgs e)
    {
        string nameBurger = "";
        int priceBeef = 0;
        if (beefPicker.SelectedIndex == 0 || beefPicker.SelectedIndex == -1)
        {
            nameBurger = "Бургер из говядины";
            priceBeef = 300;
        }
        else if(beefPicker.SelectedIndex == 1)
        {
            nameBurger = "Бургер из свинины";
            priceBeef = 240;
        }
        else if (beefPicker.SelectedIndex == 2)
        {
            nameBurger = "Бургер с курицей";
            priceBeef = 200;
        }

        if(int.Parse(countBurger.Text) > 0)
        {
            Burger burger = new Burger(nameBurger, priceBeef, int.Parse(countSalad.Text), int.Parse(countTomato.Text), int.Parse(countOnion.Text), int.Parse(countCucumber.Text), int.Parse(countBurger.Text));

            MessagingCenter.Send(this, "AddPage", burger);
        }

        Navigation.PopAsync();
    }
}