using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Coderman.Wpf.Bindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            this.viewModel = new ViewModel
            {
                AwesomePeople = new ObservableCollection<Person>()
                {
                    new Person
                    {
                        Name = "Coderman"
                    },
                    new Person
                    {
                        Name = "Not Coderman"
                    }
                },
                NotAwesomePeople = new ObservableCollection<Person>()
            };

            this.DataContext = this.viewModel;
        }

        private void MoveToNotAwesome_Click(object sender, RoutedEventArgs e)
        {
            this.AddToList(this.viewModel.NotAwesomePeople, this.viewModel.AwesomePeople, this.viewModel.SelectedPerson);
        }

        private void RemoveFromNotAwesome_Click(object sender, RoutedEventArgs e)
        {
            this.AddToList(this.viewModel.AwesomePeople, this.viewModel.NotAwesomePeople, this.viewModel.SelectedPerson);
        }

        private void AddToList(IList<Person> listToAddTo, IList<Person> listToRemoveFrom, Person personToAdd)
        {
            if (personToAdd is null)
                return;

            if (listToAddTo.Contains(personToAdd))
                return;

            listToRemoveFrom.Remove(personToAdd);
            listToAddTo.Add(personToAdd);
        }
    }
}
