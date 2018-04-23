Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace TBExample
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
    Public Class ViewModel
        Public Sub New()
            Items = New ObservableCollection(Of Item)()
            Items.Add(New Item() With {.Name = "Home"})

            Dim item1 As New Item() With {.Name = "Item1", .Group = "Group1"}
            item1.Children = New ObservableCollection(Of Item)()
            item1.Children.Add(New Item() With {.Name = "Item1Child1"})
            item1.Children.Add(New Item() With {.Name = "Item1Child2"})
            Items.Add(item1)

            item1 = New Item() With {.Name = "Item2", .Group = "Group2"}
            item1.Children = New ObservableCollection(Of Item)()
            item1.Children.Add(New Item() With {.Name = "Item2Child1"})
            Items.Add(item1)

        End Sub
        Public Property Items() As ObservableCollection(Of Item)
    End Class

    Public Class Item
        Public Sub New()
            Command = New DelegateCommand(AddressOf CommandAction)
        End Sub
        Public Property Name() As String
        Public Property Group() As String

        Public Property Children() As ObservableCollection(Of Item)
        Public ReadOnly Property IsHasChildren() As Boolean
            Get
                Return Children IsNot Nothing AndAlso Children.Count <> 0
            End Get
        End Property

        Public Property Command() As ICommand
        Public Sub CommandAction()
            MessageBox.Show(Name)
        End Sub
    End Class
End Namespace
