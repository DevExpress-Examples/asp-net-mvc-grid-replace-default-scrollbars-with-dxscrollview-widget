Imports DevExpress.Web.Mvc
Imports GridViewWithDxScrollView.Models
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace GridViewWithDxScrollView.Controllers
	Public Class HomeController
		Inherits Controller

		' GET: Home
		Public Function Index() As ActionResult
			Return View()
		End Function

		<ValidateInput(False)>
		Public Function GridViewPartial() As ActionResult
			Dim model = ModelRepository.GetData()
			Return PartialView("_GridViewPartial", model)
		End Function
	End Class
End Namespace