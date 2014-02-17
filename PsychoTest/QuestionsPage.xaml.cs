using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PsychoTest.Resources;

namespace PsychoTest
{
    public partial class QuestionsPage : PhoneApplicationPage
    {
        public int questionNumber = -1;

        // Constructor
        public QuestionsPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // When page is navigated to set data context to selected item in list
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string querystringvalue = "";
            if (NavigationContext.QueryString.TryGetValue("question", out querystringvalue))
            {
                questionNumber = int.Parse(querystringvalue);
            }

            if (questionNumber >= 0)
            {
                DataContext = App.ViewModel.Items[questionNumber];
            }
        }

        private void NotApply_Click(object sender, RoutedEventArgs e)
        {
            SetScore(0);
            GoNextQuestion();
        }

        private void GoNextQuestion()
        {
            if (questionNumber < App.ViewModel.Items.Count - 1)
            {
                NavigationService.Navigate(new Uri("/QuestionsPage.xaml?question=" + (questionNumber + 1), UriKind.Relative));
            }
            else
            {
                NavigationService.Navigate(new Uri("/ResultPage.xaml?score=" + CalcScore(), UriKind.Relative));
            }
        }

        private void PartiallyApply_Click(object sender, RoutedEventArgs e)
        {
            SetScore(1);
            GoNextQuestion();
        }

        private void PerfectMatch_Click(object sender, RoutedEventArgs e)
        {
            SetScore(2);
            GoNextQuestion();
        }

        private int CalcScore()
        {
            return App.score.Sum();
        }

        private void SetScore(int value)
        {
            App.score[questionNumber] = value;
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}