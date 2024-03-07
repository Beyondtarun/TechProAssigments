Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub LOGIN(ByVal sender As Object, ByVal e As System.EventArgs)
        If Textbox2.Text.ToString() = "pass" AndAlso Textbox1.Text.ToString() IsNot "" Then
            Session("UserName") = Textbox1.Text.ToUpper()
            Response.Redirect("WebForm1.aspx?UserName=" & Textbox1.Text.ToString())
        Else
            Label1.Text = "WRONG PASSWORD"


        End If
    End Sub


End Class