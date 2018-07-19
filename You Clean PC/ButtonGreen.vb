Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace You_Clean_PC
	' Token: 0x02000012 RID: 18
	Friend Class ButtonGreen
		Inherits ThemeControl

		' Token: 0x06000129 RID: 297 RVA: 0x00008D60 File Offset: 0x00006F60
		Public Overrides Sub PaintHook()
			Me.Font = New Font("Arial", 10F)
			Me.G.Clear(Me.BackColor)
			Me.G.SmoothingMode = 2
			Select Case Me.MouseState
				Case ThemeControl.State.MouseNone
					Dim pen As Pen = New Pen(Color.FromArgb(120, 159, 22), 1F)
					Dim linearGradientBrush As LinearGradientBrush = New LinearGradientBrush(MyBase.ClientRectangle, Color.FromArgb(157, 209, 57), Color.FromArgb(130, 181, 18), 1)
					Me.G.FillPath(linearGradientBrush, Draw.RoundRect(MyBase.ClientRectangle, 4))
					Me.G.DrawPath(pen, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 3))
					Me.G.DrawLine(New Pen(Color.FromArgb(190, 232, 109)), 2, 1, MyBase.Width - 3, 1)
					MyBase.DrawText(2, Color.FromArgb(240, 240, 240), 0)
				Case ThemeControl.State.MouseOver
					Dim pen2 As Pen = New Pen(Color.FromArgb(120, 159, 22), 1F)
					Dim linearGradientBrush2 As LinearGradientBrush = New LinearGradientBrush(MyBase.ClientRectangle, Color.FromArgb(165, 220, 59), Color.FromArgb(137, 191, 18), 1)
					Me.G.FillPath(linearGradientBrush2, Draw.RoundRect(MyBase.ClientRectangle, 4))
					Me.G.DrawPath(pen2, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 3))
					Me.G.DrawLine(New Pen(Color.FromArgb(190, 232, 109)), 2, 1, MyBase.Width - 3, 1)
					MyBase.DrawText(2, Color.FromArgb(240, 240, 240), -1)
				Case ThemeControl.State.MouseDown
					Dim pen3 As Pen = New Pen(Color.FromArgb(120, 159, 22), 1F)
					Dim linearGradientBrush3 As LinearGradientBrush = New LinearGradientBrush(MyBase.ClientRectangle, Color.FromArgb(125, 171, 25), Color.FromArgb(142, 192, 40), 1)
					Me.G.FillPath(linearGradientBrush3, Draw.RoundRect(MyBase.ClientRectangle, 4))
					Me.G.DrawPath(pen3, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 3))
					Me.G.DrawLine(New Pen(Color.FromArgb(142, 172, 30)), 2, 1, MyBase.Width - 3, 1)
					MyBase.DrawText(2, Color.FromArgb(250, 250, 250), 1)
			End Select
			Me.Cursor = Cursors.Hand
		End Sub
	End Class
End Namespace
