using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace TipCalculator
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int selectedIntex = ComboMeal.SelectedIndex;
            double basePrice = 0;
            double tip = 0;
            double extraEveningTip = 0;
            switch (selectedIntex)
            {
                case 0:
                    basePrice = 22.00;
                    break;
                case 1:
                    basePrice = 12.00;
                    break;
                case 2:
                    basePrice = 15.00;
                    break;
                case 3:
                    basePrice = 17.00;
                    break;
            }

            double serviceGrade = ServiceRating.Value;
            if(serviceGrade < 0)
            {
                serviceGrade = 0;
            }
            double mealGrade = MealRating.Value;
            if(mealGrade < 0)
            {
                mealGrade = 0;
            }
            double localGrade = LocalRating.Value;
            if(localGrade < 0)
            {
                localGrade = 0;
            }
            TimeSpan mealDateTime = MealTimePicker.Time;
            int hour = mealDateTime.Hours;
            if(hour > 20)
            {
                extraEveningTip = 2;
            }

            tip = 0.25 * basePrice * (serviceGrade + mealGrade + localGrade) / 15.0 + extraEveningTip;
            TipTextBox.Text = Convert.ToString(tip);

        }
    }
}
