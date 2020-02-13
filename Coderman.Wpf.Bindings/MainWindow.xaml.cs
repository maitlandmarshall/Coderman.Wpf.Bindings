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
            if (this.viewModel.SelectedPerson == null)
                return;

            if (this.viewModel.NotAwesomePeople.Contains(this.viewModel.SelectedPerson))
                return;

            Person person = this.viewModel.SelectedPerson;

            this.viewModel.AwesomePeople.Remove(person);
            this.viewModel.NotAwesomePeople.Add(person);
        }

        private void RemoveFromNotAwesome_Click(object sender, RoutedEventArgs e)
        {
            if (this.viewModel.SelectedPerson == null)
                return;

            if (this.viewModel.AwesomePeople.Contains(this.viewModel.SelectedPerson))
                return;

            Person person = this.viewModel.SelectedPerson;

            this.viewModel.NotAwesomePeople.Remove(person);
            this.viewModel.AwesomePeople.Add(person);
        }
    }
}
