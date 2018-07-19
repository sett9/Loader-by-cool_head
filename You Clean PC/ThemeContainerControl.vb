Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace You_Clean_PC
	' Token: 0x0200000C RID: 12
	Friend MustInherit Class ThemeContainerControl
		Inherits ContainerControl

		' Token: 0x060000E6 RID: 230 RVA: 0x00007B0D File Offset: 0x00005D0D
		Public Sub New()
			MyBase.SetStyle(139270, True)
			Me.B = New Bitmap(1, 1)
			Me.G = Graphics.FromImage(Me.B)
		End Sub

		' Token: 0x060000E7 RID: 231 RVA: 0x0000752B File Offset: 0x0000572B
		Public Sub AllowTransparent()
			MyBase.SetStyle(4, False)
			MyBase.SetStyle(2048, True)
		End Sub

		' Token: 0x060000E8 RID: 232
		Public MustOverride Sub PaintHook()

		' Token: 0x060000E9 RID: 233 RVA: 0x00007B44 File Offset: 0x00005D44
		Protected NotInheritable Overrides Sub OnPaint(e As PaintEventArgs)
			Dim flag As Boolean = MyBase.Width = 0 OrElse MyBase.Height = 0
			If Not flag Then
				Me.PaintHook()
				e.Graphics.DrawImage(Me.B, 0, 0)
			End If
		End Sub

		' Token: 0x060000EA RID: 234 RVA: 0x00007B88 File Offset: 0x00005D88
		Protected Overrides Sub OnSizeChanged(e As EventArgs)
			Dim flag As Boolean = MyBase.Width <> 0 AndAlso MyBase.Height <> 0
			If flag Then
				Me.B = New Bitmap(MyBase.Width, MyBase.Height)
				Me.G = Graphics.FromImage(Me.B)
				MyBase.Invalidate()
			End If
			MyBase.OnSizeChanged(e)
		End Sub

		' Token: 0x17000056 RID: 86
		' (get) Token: 0x060000EB RID: 235 RVA: 0x00007BE8 File Offset: 0x00005DE8
		' (set) Token: 0x060000EC RID: 236 RVA: 0x00007C00 File Offset: 0x00005E00
		Public Property NoRounding As Boolean
			Get
				Return Me._NoRounding
			End Get
			Set(value As Boolean)
				Me._NoRounding = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x060000ED RID: 237 RVA: 0x00007C14 File Offset: 0x00005E14
		Protected Sub DrawCorners(c As Color, rect As Rectangle)
			Dim noRounding As Boolean = Me._NoRounding
			If Not noRounding Then
				Me.B.SetPixel(rect.X, rect.Y, c)
				Me.B.SetPixel(rect.X + (rect.Width - 1), rect.Y, c)
				Me.B.SetPixel(rect.X, rect.Y + (rect.Height - 1), c)
				Me.B.SetPixel(rect.X + (rect.Width - 1), rect.Y + (rect.Height - 1), c)
			End If
		End Sub

		' Token: 0x060000EE RID: 238 RVA: 0x00007CC8 File Offset: 0x00005EC8
		Protected Sub DrawBorders(p1 As Pen, p2 As Pen, rect As Rectangle)
			' The following expression was wrapped in a checked-statement
			Me.G.DrawRectangle(p1, rect.X, rect.Y, rect.Width - 1, rect.Height - 1)
			Me.G.DrawRectangle(p2, rect.X + 1, rect.Y + 1, rect.Width - 3, rect.Height - 3)
		End Sub

		' Token: 0x060000EF RID: 239 RVA: 0x00007D34 File Offset: 0x00005F34
		Protected Sub DrawGradient(c1 As Color, c2 As Color, x As Integer, y As Integer, width As Integer, height As Integer, angle As Single)
			Me._Rectangle = New Rectangle(x, y, width, height)
			Me._Gradient = New LinearGradientBrush(Me._Rectangle, c1, c2, angle)
			Me.G.FillRectangle(Me._Gradient, Me._Rectangle)
		End Sub

		' Token: 0x0400006C RID: 108
		Protected G As Graphics

		' Token: 0x0400006D RID: 109
		Protected B As Bitmap

		' Token: 0x0400006E RID: 110
		Private _NoRounding As Boolean

		' Token: 0x0400006F RID: 111
		Private _Rectangle As Rectangle

		' Token: 0x04000070 RID: 112
		Private _Gradient As LinearGradientBrush
	End Class
End Namespace
