using DevExpress.Mvvm;
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

namespace TBExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    public class ViewModel
    {
        public ViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item() { Name = "Home" });

            Item item1 = new Item() { Name = "Item1", Group = "Group1" };
            item1.Children = new ObservableCollection<Item>();
            item1.Children.Add(new Item() { Name = "Item1Child1" });
            item1.Children.Add(new Item() { Name = "Item1Child2" });
            Items.Add(item1);

            item1 = new Item() { Name = "Item2", Group = "Group2" };
            item1.Children = new ObservableCollection<Item>();
            item1.Children.Add(new Item() { Name = "Item2Child1" });
            Items.Add(item1);

        }
        public ObservableCollection<Item> Items
        {
            get;
            set;
        }
    }

    public class Item
    {
        public Item()
        {
            Command = new DelegateCommand(CommandAction);
        }
        public string Name
        {
            get;
            set;
        }
        public string Group
        {
            get;
            set;
        }

        public ObservableCollection<Item> Children
        {
            get;
            set;
        }
        public bool IsHasChildren
        {
            get
            {
                return Children != null && Children.Count != 0;
            }
        }

        public ICommand Command
        {
            get;
            set;
        }
        public void CommandAction()
        {
            MessageBox.Show(Name);
        }
    }
}
