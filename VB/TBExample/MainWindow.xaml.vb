Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel
Imports System.Windows

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

			Dim item1 As New Item() With {
				.Name = "Item1",
				.Group = "Group1"
			}
			item1.Children = New ObservableCollection(Of Item)()
			item1.Children.Add(New Item() With {.Name = "Item1Child1"})
			item1.Children.Add(New Item() With {.Name = "Item1Child2"})
			Items.Add(item1)

			item1 = New Item() With {
				.Name = "Item2",
				.Group = "Group2"
			}
			item1.Children = New ObservableCollection(Of Item)()
			item1.Children.Add(New Item() With {.Name = "Item2Child1"})
			Items.Add(item1)

		End Sub
		Public Property Items() As ObservableCollection(Of Item)
	End Class

	Public Class Item
		Inherits BindableBase

		Public Sub New()
			Command = New DelegateCommand(AddressOf CommandAction)
		End Sub

		Protected _Name As String
		Public Property Name() As String
			Get
				Return Me._Name
			End Get
			Set(ByVal value As String)
				Me.SetProperty(Me._Name, value, "Name")
			End Set
		End Property

		Protected _Group As String
		Public Property Group() As String
			Get
				Return Me._Group
			End Get
			Set(ByVal value As String)
				Me.SetProperty(Me._Group, value, "Group")
			End Set
		End Property


		Protected _Children As ObservableCollection(Of Item)
		Public Property Children() As ObservableCollection(Of Item)
			Get
				Return Me._Children
			End Get
			Set(ByVal value As ObservableCollection(Of Item))
				Me.SetProperty(Me._Children, value, "Children")
			End Set
		End Property
		Public ReadOnly Property IsHasChildren() As Boolean
			Get
				Return Children IsNot Nothing AndAlso Children.Count <> 0
			End Get
		End Property


		Protected _Command As DelegateCommand
		Public Property Command() As DelegateCommand
			Get
				Return Me._Command
			End Get
			Set(ByVal value As DelegateCommand)
				Me.SetProperty(Me._Command, value, "Command")
			End Set
		End Property

		Public Sub CommandAction()
			MessageBox.Show(Name)
		End Sub
	End Class
End Namespace
