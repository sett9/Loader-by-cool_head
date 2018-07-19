Imports System
Imports System.Drawing

Namespace You_Clean_PC
	' Token: 0x02000014 RID: 20
	Friend Class StatusBar
		Inherits ThemeControl

		' Token: 0x0600012C RID: 300 RVA: 0x00009339 File Offset: 0x00007539
		Public Sub New()
			Me.Dock = 2
			MyBase.Size = New Size(MyBase.Width, 20)
		End Sub

		' Token: 0x0600012D RID: 301 RVA: 0x00009360 File Offset: 0x00007560
		Public Overrides Sub PaintHook()
			Me.Font = New Font("Arial", 10F)
			Me.G.Clear(Me.BackColor)
			Me.G.SmoothingMode = 2
			Select Case Me.MouseState
				Case ThemeControl.State.MouseNone
					MyBase.DrawGradient(Color.FromArgb(20, 82, 179), Color.FromArgb(58, 110, 195), 0, 0, MyBase.Width, MyBase.Height, 270F)
					Me.G.DrawRectangle(New Pen(Color.FromArgb(12, 69, 180)), 0, 0, MyBase.Width - 1, MyBase.Height - 1)
					MyBase.DrawText(0, Color.FromArgb(240, 240, 240), 1)
				Case ThemeControl.State.MouseOver
					MyBase.DrawGradient(Color.FromArgb(21, 79, 177), Color.FromArgb(76, 128, 218), 0, 0, MyBase.Width, MyBase.Height, 270F)
					Me.G.DrawRectangle(New Pen(Color.FromArgb(12, 69, 180)), 0, 0, MyBase.Width - 1, MyBase.Height - 1)
					MyBase.DrawText(0, Color.FromArgb(250, 250, 250), 1)
				Case ThemeControl.State.MouseDown
					MyBase.DrawGradient(Color.FromArgb(19, 75, 172), Color.FromArgb(70, 110, 198), 0, 0, MyBase.Width, MyBase.Height, 270F)
					Me.G.DrawRectangle(New Pen(Color.FromArgb(12, 69, 180)), 0, 0, MyBase.Width - 1, MyBase.Height - 1)
					MyBase.DrawText(0, Color.FromArgb(232, 232, 232), 1)
			End Select
			Me.G.DrawLine(New Pen(Color.FromArgb(50, 255, 255, 255)), 1, 1, MyBase.Width - 3, 1)
		End Sub
	End Class
End Namespace
