<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/TBExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/TBExample/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/TBExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/TBExample/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Bind TileBar to a Collection of Items


<p>To use <a href="https://documentation.devexpress.com/WPF/115595/Controls-and-Libraries/Navigation-Controls/Tile-Bar">TileBar</a> according to the MVVM, pattern, you can generate TileBarItems from a collection. To accomplish this task, assign a collection to the TileBar.ItemsSource property. To change properties of generated TileBarItems, use the TileBar.ItemContainerStyle property. If it's necessary to build a multi-level hierarchy, put TileBar into TileBarItem.FlyoutContentTemplate. </p>

<br/>


