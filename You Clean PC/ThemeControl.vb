Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace You_Clean_PC
	' Token: 0x0200000B RID: 11
	Friend MustInherit Class ThemeControl
		Inherits Control

		' Token: 0x060000CD RID: 205 RVA: 0x000074F6 File Offset: 0x000056F6
		Public Sub New()
			MyBase.SetStyle(139270, True)
			Me.B = New Bitmap(1, 1)
			Me.G = Graphics.FromImage(Me.B)
		End Sub

		' Token: 0x060000CE RID: 206 RVA: 0x0000752B File Offset: 0x0000572B
		Public Sub AllowTransparent()
			MyBase.SetStyle(4, False)
			MyBase.SetStyle(2048, True)
		End Sub

		' Token: 0x17000051 RID: 81
		' (get) Token: 0x060000CF RID: 207 RVA: 0x00007544 File Offset: 0x00005744
		' (set) Token: 0x060000D0 RID: 208 RVA: 0x00006B74 File Offset: 0x00004D74
		Public Overrides Property Text As String
			Get
				Return MyBase.Text
			End Get
			Set(value As String)
				MyBase.Text = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x060000D1 RID: 209 RVA: 0x0000755C File Offset: 0x0000575C
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			Me.ChangeMouseState(ThemeControl.State.MouseNone)
			MyBase.OnMouseLeave(e)
		End Sub

		' Token: 0x060000D2 RID: 210 RVA: 0x0000756F File Offset: 0x0000576F
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			Me.ChangeMouseState(ThemeControl.State.MouseOver)
			MyBase.OnMouseEnter(e)
		End Sub

		' Token: 0x060000D3 RID: 211 RVA: 0x00007582 File Offset: 0x00005782
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			Me.ChangeMouseState(ThemeControl.State.MouseOver)
			MyBase.OnMouseUp(e)
		End Sub

		' Token: 0x060000D4 RID: 212 RVA: 0x00007598 File Offset: 0x00005798
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			Dim flag As Boolean = e.Button = 1048576
			If flag Then
				Me.ChangeMouseState(ThemeControl.State.MouseDown)
			End If
			MyBase.OnMouseDown(e)
		End Sub

		' Token: 0x060000D5 RID: 213 RVA: 0x000075C7 File Offset: 0x000057C7
		Private Sub ChangeMouseState(e As ThemeControl.State)
			Me.MouseState = e
			MyBase.Invalidate()
		End Sub

		' Token: 0x060000D6 RID: 214
		Public MustOverride Sub PaintHook()

		' Token: 0x060000D7 RID: 215 RVA: 0x000075D8 File Offset: 0x000057D8
		Protected NotInheritable Overrides Sub OnPaint(e As PaintEventArgs)
			Dim flag As Boolean = MyBase.Width = 0 OrElse MyBase.Height = 0
			If Not flag Then
				Me.PaintHook()
				e.Graphics.DrawImage(Me.B, 0, 0)
			End If
		End Sub

		' Token: 0x060000D8 RID: 216 RVA: 0x0000761C File Offset: 0x0000581C
		Protected Overrides Sub OnSizeChanged(e As EventArgs)
			Dim flag As Boolean = MyBase.Width <> 0 AndAlso MyBase.Height <> 0
			If flag Then
				Me.B = New Bitmap(MyBase.Width, MyBase.Height)
				Me.G = Graphics.FromImage(Me.B)
				MyBase.Invalidate()
			End If
			MyBase.OnSizeChanged(e)
		End Sub

		' Token: 0x17000052 RID: 82
		' (get) Token: 0x060000D9 RID: 217 RVA: 0x0000767C File Offset: 0x0000587C
		' (set) Token: 0x060000DA RID: 218 RVA: 0x00007694 File Offset: 0x00005894
		Public Property NoRounding As Boolean
			Get
				Return Me._NoRounding
			End Get
			Set(value As Boolean)
				Me._NoRounding = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x17000053 RID: 83
		' (get) Token: 0x060000DB RID: 219 RVA: 0x000076A8 File Offset: 0x000058A8
		' (set) Token: 0x060000DC RID: 220 RVA: 0x000076C0 File Offset: 0x000058C0
		Public Property Image As Image
			Get
				Return Me._Image
			End Get
			Set(value As Image)
				Me._Image = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x17000054 RID: 84
		' (get) Token: 0x060000DD RID: 221 RVA: 0x000076D4 File Offset: 0x000058D4
		Public ReadOnly Property ImageWidth As Integer
			Get
				Dim flag As Boolean = Me._Image Is Nothing
				Dim result As Integer
				If flag Then
					result = 0
				Else
					result = Me._Image.Width
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000055 RID: 85
		' (get) Token: 0x060000DE RID: 222 RVA: 0x00007704 File Offset: 0x00005904
		Public ReadOnly Property ImageTop As Integer
			Get
				Dim flag As Boolean = Me._Image Is Nothing
				Dim result As Integer
				If flag Then
					result = 0
				Else
					' The following expression was wrapped in a checked-expression
					result = MyBase.Height / 2 - Me._Image.Height / 2
				End If
				Return result
			End Get
		End Property

		' Token: 0x060000DF RID: 223 RVA: 0x00007740 File Offset: 0x00005940
		Protected Sub DrawCorners(c As Color, rect As Rectangle)
			Dim noRounding As Boolean = Me._NoRounding
			If Not noRounding Then
				Me.B.SetPixel(rect.X, rect.Y, c)
				Me.B.SetPixel(rect.X + (rect.Width - 1), rect.Y, c)
				Me.B.SetPixel(rect.X, rect.Y + (rect.Height - 1), c)
				Me.B.SetPixel(rect.X + (rect.Width - 1), rect.Y + (rect.Height - 1), c)
			End If
		End Sub

		' Token: 0x060000E0 RID: 224 RVA: 0x000077F4 File Offset: 0x000059F4
		Protected Sub DrawBorders(p1 As Pen, p2 As Pen, rect As Rectangle)
			' The following expression was wrapped in a checked-statement
			Me.G.DrawRectangle(p1, rect.X, rect.Y, rect.Width - 1, rect.Height - 1)
			Me.G.DrawRectangle(p2, rect.X + 1, rect.Y + 1, rect.Width - 3, rect.Height - 3)
		End Sub

		' Token: 0x060000E1 RID: 225 RVA: 0x00007860 File Offset: 0x00005A60
		Protected Sub DrawText(a As HorizontalAlignment, c As Color, x As Integer)
			Me.DrawText(a, c, x, 0)
		End Sub

		' Token: 0x060000E2 RID: 226 RVA: 0x00007870 File Offset: 0x00005A70
		Protected Sub DrawText(a As HorizontalAlignment, c As Color, x As Integer, y As Integer)
			Dim flag As Boolean = String.IsNullOrEmpty(Me.Text)
			If Not flag Then
				Me._Size = Me.G.MeasureString(Me.Text, Me.Font).ToSize()
				Me._Brush = New SolidBrush(c)
				Select Case a
					Case 0
						Me.G.DrawString(Me.Text, Me.Font, Me._Brush, CSng(x), CSng((MyBase.Height / 2 - Me._Size.Height / 2 + y)))
					Case 1
						Me.G.DrawString(Me.Text, Me.Font, Me._Brush, CSng((MyBase.Width - Me._Size.Width - x)), CSng((MyBase.Height / 2 - Me._Size.Height / 2 + y)))
					Case 2
						Me.G.DrawString(Me.Text, Me.Font, Me._Brush, CSng((MyBase.Width / 2 - Me._Size.Width / 2 + x)), CSng((MyBase.Height / 2 - Me._Size.Height / 2 + y)))
				End Select
			End If
		End Sub

		' Token: 0x060000E3 RID: 227 RVA: 0x000079C2 File Offset: 0x00005BC2
		Protected Sub DrawIcon(a As HorizontalAlignment, x As Integer)
			Me.DrawIcon(a, x, 0)
		End Sub

		' Token: 0x060000E4 RID: 228 RVA: 0x000079D0 File Offset: 0x00005BD0
		Protected Sub DrawIcon(a As HorizontalAlignment, x As Integer, y As Integer)
			Dim flag As Boolean = Me._Image Is Nothing
			If Not flag Then
				Select Case a
					Case 0
						Me.G.DrawImage(Me._Image, x, MyBase.Height / 2 - Me._Image.Height / 2 + y)
					Case 1
						Me.G.DrawImage(Me._Image, MyBase.Width - Me._Image.Width - x, MyBase.Height / 2 - Me._Image.Height / 2 + y)
					Case 2
						Me.G.DrawImage(Me._Image, MyBase.Width / 2 - Me._Image.Width / 2, MyBase.Height / 2 - Me._Image.Height / 2)
				End Select
			End If
		End Sub

		' Token: 0x060000E5 RID: 229 RVA: 0x00007AC0 File Offset: 0x00005CC0
		Protected Sub DrawGradient(c1 As Color, c2 As Color, x As Integer, y As Integer, width As Integer, height As Integer, angle As Single)
			Me._Rectangle = New Rectangle(x, y, width, height)
			Me._Gradient = New LinearGradientBrush(Me._Rectangle, c1, c2, angle)
			Me.G.FillRectangle(Me._Gradient, Me._Rectangle)
		End Sub

		' Token: 0x04000063 RID: 99
		Protected G As Graphics

		' Token: 0x04000064 RID: 100
		Protected B As Bitmap

		' Token: 0x04000065 RID: 101
		Protected MouseState As ThemeControl.State

		' Token: 0x04000066 RID: 102
		Private _NoRounding As Boolean

		' Token: 0x04000067 RID: 103
		Private _Image As Image

		' Token: 0x04000068 RID: 104
		Private _Size As Size

		' Token: 0x04000069 RID: 105
		Private _Rectangle As Rectangle

		' Token: 0x0400006A RID: 106
		Private _Gradient As LinearGradientBrush

		' Token: 0x0400006B RID: 107
		Private _Brush As SolidBrush

		' Token: 0x0200001B RID: 27
		Protected Enum State As Byte
			' Token: 0x0400008B RID: 139
			MouseNone
			' Token: 0x0400008C RID: 140
			MouseOver
			' Token: 0x0400008D RID: 141
			MouseDown
		End Enum
	End Class
End Namespace
