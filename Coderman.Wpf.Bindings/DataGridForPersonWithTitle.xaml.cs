using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for DataGridForPersonWithTitle.xaml
    /// </summary>
    public partial class DataGridForPersonWithTitle : UserControl
    {
        public static readonly DependencyProperty DataGridTitleProperty = 
            DependencyProperty.Register(nameof(DataGridTitle), typeof(string), typeof(DataGridForPersonWithTitle));

        public static readonly DependencyProperty PeopleProperty =
            DependencyProperty.Register(nameof(People), typeof(IEnumerable<Person>), typeof(DataGridForPersonWithTitle));

        public static readonly DependencyProperty SelectedPersonProperty =
            DependencyProperty.Register(nameof(SelectedPerson), typeof(Person), typeof(DataGridForPersonWithTitle));

        public string DataGridTitle { get; set; }
        public IEnumerable<Person> People { get; set; }
        public Person SelectedPerson { get; set; }

        public DataGridForPersonWithTitle()
        {
            InitializeComponent();
            (this.Content as Grid).DataContext = this;
        }
    }
}
