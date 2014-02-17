using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PsychoTest
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string querystringvalue = "";
            int score = 0;
            string text = "";
            if (NavigationContext.QueryString.TryGetValue("score", out querystringvalue))
            {
                score = int.Parse(querystringvalue);
                text = string.Format("{0} point", score);
                if (score > 1) {
                    text += "s";
                }
                scoreBox.DataContext = text;

                if (score > 6)
                {
                    scoreText.DataContext = "Higher than the average";
                }
                else if (score > 20)
                {
                    scoreText.DataContext = "Very High";
                }
                else if (score > 30)
                {
                    scoreText.DataContext = "Psychopath";
                }
                else
                {
                    scoreText.DataContext = "Normal";
                }
            }
        }

    }
}