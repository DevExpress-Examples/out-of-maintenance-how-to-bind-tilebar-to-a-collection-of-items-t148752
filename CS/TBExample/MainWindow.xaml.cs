using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using System.Windows;

namespace TBExample {
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

    public class Item : BindableBase
    {
        public Item()
        {
            Command = new DelegateCommand(CommandAction);
        }

        protected string _Name;
        public string Name
        {
            get { return this._Name; }
            set { this.SetProperty(ref this._Name, value, "Name"); }
        }

        protected string _Group;
        public string Group
        {
            get { return this._Group; }
            set { this.SetProperty(ref this._Group, value, "Group"); }
        }


        protected ObservableCollection<Item> _Children;
        public ObservableCollection<Item> Children
        {
            get { return this._Children; }
            set { this.SetProperty(ref this._Children, value, "Children"); }
        }
        public bool IsHasChildren
        {
            get
            {
                return Children != null && Children.Count != 0;
            }
        }


        protected DelegateCommand _Command;
        public DelegateCommand Command
        {
            get { return this._Command; }
            set { this.SetProperty(ref this._Command, value, "Command"); }
        }

        public void CommandAction()
        {
            MessageBox.Show(Name);
        }
    }
}
