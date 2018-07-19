Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace You_Clean_PC
	' Token: 0x02000010 RID: 16
	Friend Class GroupDropBox
		Inherits ThemeContainerControl

		' Token: 0x1700005F RID: 95
		' (get) Token: 0x0600011C RID: 284 RVA: 0x00008778 File Offset: 0x00006978
		' (set) Token: 0x0600011D RID: 285 RVA: 0x00008790 File Offset: 0x00006990
		Public Property Checked As Boolean
			Get
				Return Me._Checked
			End Get
			Set(value As Boolean)
				Me._Checked = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x17000060 RID: 96
		' (get) Token: 0x0600011E RID: 286 RVA: 0x000087A4 File Offset: 0x000069A4
		' (set) Token: 0x0600011F RID: 287 RVA: 0x000087BC File Offset: 0x000069BC
		Public Property OpenSize As Size
			Get
				Return Me._OpenedSize
			End Get
			Set(value As Size)
				Me._OpenedSize = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x06000120 RID: 288 RVA: 0x000087D0 File Offset: 0x000069D0
		Public Sub New()
			MyBase.Resize += AddressOf Me.meResize
			MyBase.MouseDown += Sub(a0 As Object, a1 As MouseEventArgs)
				Me.changeCheck()
			End Sub
			MyBase.AllowTransparent()
			MyBase.Size = New Size(90, 30)
			Me.MinimumSize = New Size(5, 30)
			Me._Checked = True
		End Sub

		' Token: 0x06000121 RID: 289 RVA: 0x00008838 File Offset: 0x00006A38
		Public Overrides Sub PaintHook()
			Me.Font = New Font("Tahoma", 10F)
			Me.ForeColor = Color.FromArgb(40, 40, 40)
			Dim checked As Boolean = Me._Checked
			If checked Then
				Me.G.SmoothingMode = 4
				Me.G.Clear(Color.FromArgb(245, 245, 245))
				Me.G.FillRectangle(New SolidBrush(Color.FromArgb(231, 231, 231)), New Rectangle(0, 0, MyBase.Width, 30))
				Me.G.DrawLine(New Pen(Color.FromArgb(237, 237, 237)), 1, 1, MyBase.Width - 2, 1)
				Me.G.DrawRectangle(New Pen(Color.FromArgb(214, 214, 214)), 0, 0, MyBase.Width - 1, MyBase.Height - 1)
				Me.G.DrawRectangle(New Pen(Color.FromArgb(214, 214, 214)), 0, 0, MyBase.Width - 1, 30)
				MyBase.Size = Me._OpenedSize
				Me.G.DrawString("t", New Font("Marlett", 12F), New SolidBrush(Me.ForeColor), CSng((MyBase.Width - 25)), 5F)
			Else
				Me.G.SmoothingMode = 4
				Me.G.Clear(Color.FromArgb(245, 245, 245))
				Me.G.FillRectangle(New SolidBrush(Color.FromArgb(231, 231, 231)), New Rectangle(0, 0, MyBase.Width, 30))
				Me.G.DrawLine(New Pen(Color.FromArgb(237, 237, 237)), 1, 1, MyBase.Width - 2, 1)
				Me.G.DrawRectangle(New Pen(Color.FromArgb(214, 214, 214)), 0, 0, MyBase.Width - 1, MyBase.Height - 1)
				Me.G.DrawRectangle(New Pen(Color.FromArgb(214, 214, 214)), 0, 0, MyBase.Width - 1, 30)
				MyBase.Size = New Size(MyBase.Width, 30)
				Me.G.DrawString("u", New Font("Marlett", 12F), New SolidBrush(Me.ForeColor), CSng((MyBase.Width - 25)), 5F)
			End If
			Me.G.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), 7F, 6F)
		End Sub

		' Token: 0x06000122 RID: 290 RVA: 0x00008B38 File Offset: 0x00006D38
		Private Sub meResize(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me._Checked
			If checked Then
				Me._OpenedSize = MyBase.Size
			End If
		End Sub

		' Token: 0x06000123 RID: 291 RVA: 0x00008B61 File Offset: 0x00006D61
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			Me.X = e.X
			Me.y = e.Y
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000124 RID: 292 RVA: 0x00008B8C File Offset: 0x00006D8C
		Public Sub changeCheck()
			' The following expression was wrapped in a checked-expression
			Dim flag As Boolean = Me.X >= MyBase.Width - 22
			If flag Then
				Dim flag2 As Boolean = Me.y <= 30
				If flag2 Then
					Dim checked As Boolean = Me.Checked
					If checked Then
						If checked Then
							Me.Checked = False
						End If
					Else
						Me.Checked = True
					End If
				End If
			End If
		End Sub

		' Token: 0x0400007A RID: 122
		Private _Checked As Boolean

		' Token: 0x0400007B RID: 123
		Private X As Integer

		' Token: 0x0400007C RID: 124
		Private y As Integer

		' Token: 0x0400007D RID: 125
		Private _OpenedSize As Size
	End Class
End Namespace
