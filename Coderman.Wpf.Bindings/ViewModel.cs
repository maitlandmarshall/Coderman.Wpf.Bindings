using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Coderman.Wpf.Bindings
{
    internal class ViewModel
    {
        public IList<Person> AwesomePeople { get; set; }
        public IList<Person> NotAwesomePeople { get; set; }

        public Person SelectedPerson { get; set; }
    }
}
