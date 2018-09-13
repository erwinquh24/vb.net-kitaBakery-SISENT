Imports System.Data.Odbc
'Imports MySql.Data.MySqlClient
Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_batal.Click
        Me.Close()
    End Sub

    Private Sub Button_login_Click_1(sender As Object, e As EventArgs) Handles Button_login.Click
        Call koneksi()

        Try
            If TextBox_uName.Text = "" Or TextBox_Pass.Text = "" Then
               
                textRed()
                MsgBox("Username atau Password Belum lengkap", MsgBoxStyle.Information, "Peringatan!!")
                textWhite()
            Else

                oc = New OdbcCommand("SELECT * FROM login WHERE username = '" + TextBox_uName.Text + "' AND password = '" + TextBox_Pass.Text + "'", conn)
                dr = oc.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    Me.Hide()

                    If dr("role").ToString = "admin" Then
                        MsgBox("Halo" & TextBox_uName.Text & "!", MsgBoxStyle.Information, "Welcome")
                        HomeAdmin.Show()
                        'ViewDetail_POProduct.Show()

                    ElseIf dr("role").ToString = "mmanagement" Then
                        MsgBox("Halo Material Management !", MsgBoxStyle.Information, "Welcome")
                        HomeMM.Show()

                    ElseIf dr("role").ToString = "sdistribution" Then
                        MsgBox("Halo Sales Distribution !", MsgBoxStyle.Information, "Welcome")
                        HomeSalesDistribution.Show()

                    ElseIf dr("role").ToString = "production" Then
                        MsgBox("Halo Production !", MsgBoxStyle.Information, "Welcome")
                        ViewDetail_PProduct.Show()

                    Else
                        Me.Show()
                    End If
                Else
                    textRed()
                    MsgBox("Username atau Password yang anda masukan salah, Mohon periksa kembali", MsgBoxStyle.Information, "Peringatan!!")
                    textWhite()
                End If
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub textWhite()
        TextBox_uName.BackColor = Color.White
        TextBox_Pass.BackColor = Color.White
    End Sub

    Private Sub textRed()
        TextBox_uName.BackColor = Color.Red
        TextBox_Pass.BackColor = Color.Red
    End Sub

End Class
