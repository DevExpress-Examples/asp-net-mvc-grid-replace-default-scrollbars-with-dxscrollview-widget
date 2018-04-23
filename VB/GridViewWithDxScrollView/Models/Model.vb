Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace GridViewWithDxScrollView.Models
	Public NotInheritable Class ModelRepository

		Private Sub New()
		End Sub

		Public Shared Function GetData() As List(Of Model)
			Dim rnd As New Random()
			Return Enumerable.Range(1, 50).Select(Function(i) New Model With {.ID = Guid.NewGuid(), .Text = "Text " & i, .Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", .Price = i * rnd.NextDouble()}).ToList()
		End Function
	End Class
	Public Class Model
		Public Property ID() As Guid
		Public Property Text() As String
		Public Property Description() As String
		Public Property Price() As Double
	End Class
End Namespace