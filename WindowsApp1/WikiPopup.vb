﻿Public Class WikiPopup
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Const CS_DROPSHADOW = &H20000
            Dim cp As CreateParams = MyBase.CreateParams

            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim p As New Pen(Color.Gray, 1)
        e.Graphics.DrawLine(p, 20, 100, GamesTable.Width + 10, 100)
    End Sub
End Class