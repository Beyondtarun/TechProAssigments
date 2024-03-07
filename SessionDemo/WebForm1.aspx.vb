Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim name As String = Request.QueryString("UserName")
        If name Is Nothing OrElse name.Length = 0 Then
            Response.Redirect("Login.aspx")
        Else
            Label1.Text = "Welcome " & name
        End If
    End Sub
    Protected Sub LogoutButtonClick(sender As Object, e As EventArgs)
        Session.Abandon()
        Response.Redirect("Login.aspx")
    End Sub

End Class