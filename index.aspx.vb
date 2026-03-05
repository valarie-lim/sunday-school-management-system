Public Class index
    Inherits System.Web.UI.Page

    Private Sub BtnGeneralAccess_Click(sender As Object, e As EventArgs) Handles BtnGeneralAccess.Click
        Response.Redirect(ResolveUrl("~/Pages/login-general.aspx"))
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Response.Redirect(ResolveUrl("~/Pages/login.aspx"))
    End Sub

End Class