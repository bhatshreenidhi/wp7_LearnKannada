using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace LearnKannada
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnNumbers_Click(object sender, RoutedEventArgs e)
        {
            DisplayPage.selectedType = DisplayPage.TYPE.NUMBERS;
            NavigationService.Navigate(new Uri("/DisplayPage.xaml",UriKind.Relative));
        }

        private void btnVegetables_Click(object sender, RoutedEventArgs e)
        {
            DisplayPage.selectedType = DisplayPage.TYPE.VEGETABLES;
            NavigationService.Navigate(new Uri("/DisplayPage.xaml", UriKind.Relative));
        }

        private void btnRelationships_Click(object sender, RoutedEventArgs e)
        {
            DisplayPage.selectedType = DisplayPage.TYPE.RELATIONSHIPS;
            NavigationService.Navigate(new Uri("/DisplayPage.xaml", UriKind.Relative));
        }

        private void btnWords_Click(object sender, RoutedEventArgs e)
        {
            DisplayPage.selectedType = DisplayPage.TYPE.WORDS;
            NavigationService.Navigate(new Uri("/DisplayPage.xaml", UriKind.Relative));
        }

        private void btnQuestions_Click(object sender, RoutedEventArgs e)
        {
            DisplayPage.selectedType = DisplayPage.TYPE.QUESTIONS;
            NavigationService.Navigate(new Uri("/DisplayPage.xaml", UriKind.Relative));
        }

        private void btnSentences_Click(object sender, RoutedEventArgs e)
        {
            DisplayPage.selectedType = DisplayPage.TYPE.SENTENCES;
            NavigationService.Navigate(new Uri("/DisplayPage.xaml", UriKind.Relative));
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AboutPage.xaml", UriKind.Relative));
        }
    }
}