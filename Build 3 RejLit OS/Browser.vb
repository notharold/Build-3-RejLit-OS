Public Class Browser
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim url As String = txtURL.Text
        If Not url.StartsWith("http://") AndAlso Not url.StartsWith("https://") Then
            url = "http://" & url
        End If

        Try
            WebView21.Source = New Uri(url)
        Catch ex As UriFormatException
            MessageBox.Show("The URL format is invalid. Please enter a valid URL.", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Browser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the WebView2 control
        WebView21.Source = New Uri("https://www.bing.com")
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        WebView21.Source = New Uri("https://www.bing.com")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If WebView21.CanGoBack Then
            WebView21.GoBack()
        End If
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        If WebView21.CanGoForward Then
            WebView21.GoForward()
        End If
    End Sub
End Class