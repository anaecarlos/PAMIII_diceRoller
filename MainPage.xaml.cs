using System;
using Microsoft.Maui.Controls;

namespace diceRoller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void RollDiceButton_Clicked(object sender, EventArgs e)
        {
            if (SidesPicker.SelectedItem != null)
            {
                int selectSides = Convert.ToInt32(SidesPicker.SelectedItem);

                Random random = new Random();
                int drawnNumber = random.Next(1, selectSides + 1);

                ResultLabel.Text = drawnNumber.ToString();
            }
            else
            {
                ResultLabel.Text = "Selecione o numero de lados.";
            }
        }
    }
}
