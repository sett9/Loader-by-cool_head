Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace You_Clean_PC
	' Token: 0x02000013 RID: 19
	Friend Class ButtonBlue
		Inherits ThemeControl

		' Token: 0x0600012B RID: 299 RVA: 0x00009060 File Offset: 0x00007260
		Public Overrides Sub PaintHook()
			Me.Font = New Font("Arial", 10F)
			Me.G.Clear(Me.BackColor)
			Me.G.SmoothingMode = 2
			Select Case Me.MouseState
				Case ThemeControl.State.MouseNone
					Dim pen As Pen = New Pen(Color.FromArgb(34, 112, 171), 1F)
					Dim linearGradientBrush As LinearGradientBrush = New LinearGradientBrush(MyBase.ClientRectangle, Color.FromArgb(51, 159, 231), Color.FromArgb(33, 128, 206), 1)
					Me.G.FillPath(linearGradientBrush, Draw.RoundRect(MyBase.ClientRectangle, 4))
					Me.G.DrawPath(pen, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 3))
					Me.G.DrawLine(New Pen(Color.FromArgb(131, 197, 241)), 2, 1, MyBase.Width - 3, 1)
					MyBase.DrawText(2, Color.FromArgb(240, 240, 240), 0)
				Case ThemeControl.State.MouseOver
					Dim pen2 As Pen = New Pen(Color.FromArgb(34, 112, 171), 1F)
					Dim linearGradientBrush2 As LinearGradientBrush = New LinearGradientBrush(MyBase.ClientRectangle, Color.FromArgb(54, 167, 243), Color.FromArgb(35, 165, 217), 1)
					Me.G.FillPath(linearGradientBrush2, Draw.RoundRect(MyBase.ClientRectangle, 4))
					Me.G.DrawPath(pen2, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 3))
					Me.G.DrawLine(New Pen(Color.FromArgb(131, 197, 241)), 2, 1, MyBase.Width - 3, 1)
					MyBase.DrawText(2, Color.FromArgb(240, 240, 240), -1)
				Case ThemeControl.State.MouseDown
					Dim pen3 As Pen = New Pen(Color.FromArgb(34, 112, 171), 1F)
					Dim linearGradientBrush3 As LinearGradientBrush = New LinearGradientBrush(MyBase.ClientRectangle, Color.FromArgb(37, 124, 196), Color.FromArgb(53, 153, 219), 1)
					Me.G.FillPath(linearGradientBrush3, Draw.RoundRect(MyBase.ClientRectangle, 4))
					Me.G.DrawPath(pen3, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 3))
					MyBase.DrawText(2, Color.FromArgb(250, 250, 250), 1)
			End Select
			Me.Cursor = Cursors.Hand
		End Sub
	End Class
End Namespace
