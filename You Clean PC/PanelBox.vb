Imports System
Imports System.Drawing

Namespace You_Clean_PC
	' Token: 0x0200000F RID: 15
	Friend Class PanelBox
		Inherits ThemeContainerControl

		' Token: 0x0600011A RID: 282 RVA: 0x00008677 File Offset: 0x00006877
		Public Sub New()
			MyBase.AllowTransparent()
		End Sub

		' Token: 0x0600011B RID: 283 RVA: 0x00008688 File Offset: 0x00006888
		Public Overrides Sub PaintHook()
			Me.Font = New Font("Tahoma", 10F)
			Me.ForeColor = Color.FromArgb(40, 40, 40)
			Me.G.SmoothingMode = 4
			Me.G.FillRectangle(New SolidBrush(Color.FromArgb(235, 235, 235)), New Rectangle(2, 0, MyBase.Width, MyBase.Height))
			Me.G.FillRectangle(New SolidBrush(Color.FromArgb(249, 249, 249)), New Rectangle(1, 0, MyBase.Width - 3, MyBase.Height - 4))
			Me.G.DrawRectangle(New Pen(Color.FromArgb(214, 214, 214)), 0, 0, MyBase.Width - 2, MyBase.Height - 3)
		End Sub

		' Token: 0x04000079 RID: 121
		Private _Checked As Boolean
	End Class
End Namespace
