Imports System.Reflection.Emit

Public Class HiddenState
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        hiddentext.Value = DateTime.Now.ToString()
        Label1.Text = "Hidden field Value " + hiddentext.Value
    End Sub

End Class