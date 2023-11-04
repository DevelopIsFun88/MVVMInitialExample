using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMInitialExample
{
    public class MainWindowVM
    {
        public ObservableCollection<Model> Lst { get; set; }
        public MainWindowVM() 
        {
            LoadData();
        }

        private void LoadData()
        {
            Lst = new ObservableCollection<Model>();
            for (int i = 1; i < 20; i++)
            {
                Lst.Add(new Model("Title" + i.ToString(), "Description" + i.ToString(), i * 50 - 2 * i));
            }
        }
    }
}
