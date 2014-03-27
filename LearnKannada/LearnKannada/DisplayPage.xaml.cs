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
using System.Xml.Linq;
using System.Collections.ObjectModel;

namespace LearnKannada
{
    public partial class DisplayPage : PhoneApplicationPage
    {

        ObservableCollection<Model.Translate> lstNum = new ObservableCollection<Model.Translate>();
        ObservableCollection<Model.Translate> lstVeg = new ObservableCollection<Model.Translate>();
        ObservableCollection<Model.Translate> lstRelationships = new ObservableCollection<Model.Translate>();
        ObservableCollection<Model.Translate> lstWords = new ObservableCollection<Model.Translate>();
        ObservableCollection<Model.Translate> lstSentences = new ObservableCollection<Model.Translate>();
        ObservableCollection<Model.Translate> lstQuestions = new ObservableCollection<Model.Translate>();

        public enum TYPE
        {
            NUMBERS = 0,
            RELATIONSHIPS,
            VEGETABLES,
            WORDS,
            QUESTIONS,
            SENTENCES

        };

        public static TYPE selectedType;

        public DisplayPage()
        {
            InitializeComponent();

            LoadDisplayPage();
        }

        private void LoadDisplayPage()
        {
            if (selectedType == DisplayPage.TYPE.NUMBERS)
                loadNumbers();
            else if (selectedType == DisplayPage.TYPE.QUESTIONS)
                loadQuestions();
            else if (selectedType == DisplayPage.TYPE.RELATIONSHIPS)
                loadRelationaships();
            else if (selectedType == DisplayPage.TYPE.VEGETABLES)
                loadVegetables();
            else if (selectedType == DisplayPage.TYPE.WORDS)
                loadWords();
            else if (selectedType == DisplayPage.TYPE.SENTENCES)
                loadSentences();
        }


        private void loadSentences()
        {
            lstSentences.Clear();

            PageTitle.Text = "sentences";

            XElement element = XElement.Load("sentences.xml");

            var nodeLists = from ele1 in element.Descendants("Item")
                            select new
                            {
                                el = ele1.Element("EL").Value,
                                tl = ele1.Element("NL").Value
                            };

            foreach (var nod in nodeLists)
            {
                Model.Translate number = new Model.Translate();
                number.engText = nod.el;
                number.kanText = nod.tl;
                lstSentences.Add(number);
            }

            lstDisplay.ItemsSource = lstSentences;
        }

        private void loadWords()
        {
            lstWords.Clear();
            PageTitle.Text = "general words";

            XElement element = XElement.Load("words.xml");

            var nodeLists = from ele1 in element.Descendants("Item")
                            select new
                            {
                                el = ele1.Element("EL").Value,
                                tl = ele1.Element("NL").Value
                            };

            foreach (var nod in nodeLists)
            {
                Model.Translate number = new Model.Translate();
                number.engText = nod.el;
                number.kanText = nod.tl;
                lstWords.Add(number);
            }

            lstDisplay.ItemsSource = lstWords;
        }

        private void loadQuestions()
        {
            lstQuestions.Clear();

            PageTitle.Text = "general questions";

            XElement element = XElement.Load("generalQuestions.xml");

            var nodeLists = from ele1 in element.Descendants("Item")
                            select new
                            {
                                el = ele1.Element("EL").Value,
                                tl = ele1.Element("NL").Value
                            };

            foreach (var nod in nodeLists)
            {
                Model.Translate number = new Model.Translate();
                number.engText = nod.el;
                number.kanText = nod.tl;
                lstQuestions.Add(number);
            }

            lstDisplay.ItemsSource = lstQuestions;
        }

        private void loadRelationaships()
        {
            lstRelationships.Clear();

            PageTitle.Text = "know the relations";

            XElement element = XElement.Load("relationships.xml");

            var nodeLists = from ele1 in element.Descendants("Item")
                            select new
                            {
                                el = ele1.Element("EL").Value,
                                tl = ele1.Element("NL").Value
                            };

            foreach (var nod in nodeLists)
            {
                Model.Translate number = new Model.Translate();
                number.engText = nod.el;
                number.kanText = nod.tl;
                lstRelationships.Add(number);
            }

            lstDisplay.ItemsSource = lstRelationships;
        }

        
        private void loadNumbers()
        {
            lstVeg.Clear();

            PageTitle.Text = "learn numbers";

            XElement element = XElement.Load("numbers.xml");

            var nodeLists = from ele1 in element.Descendants("Item")
                            select new
                            {
                                el = ele1.Element("EL").Value,
                                tl = ele1.Element("NL").Value
                            };

            foreach (var nod in nodeLists)
            {
                Model.Translate number = new Model.Translate();
                number.engText = nod.el;
                number.kanText = nod.tl;
                lstVeg.Add(number);
            }

            lstDisplay.ItemsSource = lstVeg;
        }

        private void loadVegetables()
        {
            lstNum.Clear();

            PageTitle.Text = "veggies in kannada";

            XElement element = XElement.Load("vegetables.xml");

            var nodeLists = from ele1 in element.Descendants("Item")
                            select new
                            {
                                el = ele1.Element("EL").Value,
                                tl = ele1.Element("NL").Value
                            };

            foreach (var nod in nodeLists)
            {
                Model.Translate number = new Model.Translate();
                number.engText = nod.el;
                number.kanText = nod.tl;
                lstNum.Add(number);
            }

            lstDisplay.ItemsSource = lstNum;
        }
    }
}