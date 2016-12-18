Public Class frmImg
    Private Sub frmImg_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not doReset Then
            Using mem As New IO.MemoryStream
                Dim img As Image = My.Resources.defaultImage
                img.RotateFlip(RotateFlipType.Rotate180FlipNone)
                img.Save(mem, Imaging.ImageFormat.Png)

                My.Settings.Img = New SettingsByteArray With {.Data = mem.GetBuffer}
            End Using
        End If

    End Sub

    Private Sub frmImg_Load(sender As Object, e As EventArgs) Handles Me.Load

        If My.Settings.Img IsNot Nothing Then
            Using mem As New IO.MemoryStream(My.Settings.Img.Data)
                pbxCat.Image = CType(Image.FromStream(mem).Clone, Image)
            End Using
        End If
    End Sub
    Dim doReset As Boolean
    Private Sub pbxCat_Click(sender As Object, e As EventArgs) Handles pbxCat.Click
        My.Settings.Reset()
        My.Settings.Save()
        doReset = True
    End Sub
End Class
