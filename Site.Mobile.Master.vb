Imports System.Data.SqlClient

Public Class Site_Mobile
    Inherits System.Web.UI.MasterPage

    'Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    If Not IsPostBack Then
    '        ' If session expired or accessed directly
    '        If Me.Page.Session("UserFirstName") Is Nothing Then
    '            Me.Page.ClientScript.RegisterStartupScript(
    '                Me.Page.GetType(),
    '                "alertRedirect",
    '                $"setTimeout(function(){{ showAlert('{HttpUtility.JavaScriptStringEncode("请登录以使用系统功能。")}', function() {{ window.location='login.aspx'; }}); }}, 150);",
    '                True
    '            )
    '        End If

    '        If Session("UserChineseName") Is Nothing OrElse Session("UserRole") Is Nothing Then
    '            ' Session expired → redirect to login
    '            Response.Redirect("~/Pages/login.aspx")
    '            Return
    '        End If
    '        UserName.Text = Session("UserChineseName").ToString()

    '        Dim URole As String = Session("UserRole").ToString()
    '        Select Case URole
    '            Case "Principal"
    '                UserRole.Text = "校长"
    '            Case "Teacher"
    '                UserRole.Text = "老师"
    '            Case "Teaching assistants"
    '                UserRole.Text = "协助"
    '            Case Else
    '                UserRole.Text = "其他" ' optional fallback for unexpected values
    '        End Select
    '    End If
    'End Sub

    Protected Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        ' Convert UTC to Singapore/Malaysia time
        Dim utcNow As DateTime = DateTime.UtcNow
        Dim singaporeTime As DateTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time"))

        ' Save logout timestamp in session
        Session("LogoutTime") = singaporeTime

        ' Update DB only if user logged in
        If Session("Username") IsNot Nothing Then
            Dim connectionString As String = DbHelper.GetConnectionString()
            Dim updateSql As String =
                "UPDATE dbo.login SET logout_time = @logoutTime WHERE username = @username"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(updateSql, connection)
                    command.Parameters.AddWithValue("@logoutTime", singaporeTime)
                    command.Parameters.AddWithValue("@username", Session("Username").ToString())
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        End If

        ' Clear session
        Session.Clear()
        Session.Abandon()

        ' Redirect to login page
        Response.Redirect("~/index.aspx")

    End Sub


End Class