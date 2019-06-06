<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/TBExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/TBExample/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/TBExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/TBExample/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Bind TileBar to a Collection of Items


To use [TileBar](https://documentation.devexpress.com/WPF/115595/Controls-and-Libraries/Navigation-Controls/Tile-Bar) according to the MVVM pattern, you can generate TileBarItems from a collection. To accomplish this task, assign a collection to the **TileBar.ItemsSource** property. 

To change properties of generated [TileBarItems](https://documentation.devexpress.com/#WPF/clsDevExpressXpfNavigationTileBarItemtopic), use the **TileBar.ItemContainerStyle** property. 

If you want to build a multi-level hierarchy, put the TileBar into [TileBarItem.FlyoutContentTemplate](https://documentation.devexpress.com/WPF/DevExpress.Xpf.Navigation.TileBarItem.FlyoutContentTemplate.property).
