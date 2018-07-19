Imports System
Imports System.Drawing

Namespace You_Clean_PC
	' Token: 0x02000011 RID: 17
	Friend Class GroupPanelBox
		Inherits ThemeContainerControl

		' Token: 0x06000126 RID: 294 RVA: 0x00008677 File Offset: 0x00006877
		Public Sub New()
			MyBase.AllowTransparent()
		End Sub

		' Token: 0x06000127 RID: 295 RVA: 0x00008BFC File Offset: 0x00006DFC
		Public Overrides Sub PaintHook()
			Me.Font = New Font("Tahoma", 10F)
			Me.ForeColor = Color.FromArgb(40, 40, 40)
			Me.G.SmoothingMode = 4
			Me.G.Clear(Color.FromArgb(245, 245, 245))
			Me.G.FillRectangle(New SolidBrush(Color.FromArgb(231, 231, 231)), New Rectangle(0, 0, MyBase.Width, 30))
			Me.G.DrawLine(New Pen(Color.FromArgb(233, 238, 240)), 1, 1, MyBase.Width - 2, 1)
			Me.G.DrawRectangle(New Pen(Color.FromArgb(214, 214, 214)), 0, 0, MyBase.Width - 1, MyBase.Height - 1)
			Me.G.DrawRectangle(New Pen(Color.FromArgb(214, 214, 214)), 0, 0, MyBase.Width - 1, 30)
			Me.G.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), 7F, 6F)
		End Sub

		' Token: 0x0400007E RID: 126
		Private _Checked As Boolean
	End Class
End Namespace
