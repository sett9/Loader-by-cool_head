Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace You_Clean_PC
	' Token: 0x02000009 RID: 9
	Friend MustInherit Class Theme
		Inherits ContainerControl

		' Token: 0x060000B1 RID: 177 RVA: 0x00006AC2 File Offset: 0x00004CC2
		Public Sub New()
			Me._Resizable = True
			Me._MoveHeight = 24
			MyBase.SetStyle(139270, True)
		End Sub

		' Token: 0x060000B2 RID: 178 RVA: 0x00006AE8 File Offset: 0x00004CE8
		Protected Overrides Sub OnHandleCreated(e As EventArgs)
			Me.Dock = 5
			Me.ParentIsForm = (TypeOf MyBase.Parent Is Form)
			Dim parentIsForm As Boolean = Me.ParentIsForm
			If parentIsForm Then
				Dim flag As Boolean = Not(Me._TransparencyKey = Color.Empty)
				If flag Then
					MyBase.ParentForm.TransparencyKey = Me._TransparencyKey
				End If
				MyBase.ParentForm.FormBorderStyle = 0
			End If
			MyBase.OnHandleCreated(e)
		End Sub

		' Token: 0x1700004B RID: 75
		' (get) Token: 0x060000B3 RID: 179 RVA: 0x00006B5C File Offset: 0x00004D5C
		' (set) Token: 0x060000B4 RID: 180 RVA: 0x00006B74 File Offset: 0x00004D74
		Public Overrides Property Text As String
			Get
				Return MyBase.Text
			End Get
			Set(value As String)
				MyBase.Text = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x1700004C RID: 76
		' (get) Token: 0x060000B5 RID: 181 RVA: 0x00006B88 File Offset: 0x00004D88
		' (set) Token: 0x060000B6 RID: 182 RVA: 0x00006BA0 File Offset: 0x00004DA0
		Public Property Resizable As Boolean
			Get
				Return Me._Resizable
			End Get
			Set(value As Boolean)
				Me._Resizable = value
			End Set
		End Property

		' Token: 0x1700004D RID: 77
		' (get) Token: 0x060000B7 RID: 183 RVA: 0x00006BAC File Offset: 0x00004DAC
		' (set) Token: 0x060000B8 RID: 184 RVA: 0x00006BC4 File Offset: 0x00004DC4
		Public Property MoveHeight As Integer
			Get
				Return Me._MoveHeight
			End Get
			Set(value As Integer)
				Me._MoveHeight = value
				Me.Header = New Rectangle(7, 7, MyBase.Width - 14, Me._MoveHeight - 7)
			End Set
		End Property

		' Token: 0x060000B9 RID: 185 RVA: 0x00006BEC File Offset: 0x00004DEC
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			Dim flag As Boolean = e.Button <> 1048576
			If Not flag Then
				Dim parentIsForm As Boolean = Me.ParentIsForm
				If parentIsForm Then
					Dim flag2 As Boolean = MyBase.ParentForm.WindowState = 2
					If flag2 Then
						Return
					End If
				End If
				Dim flag3 As Boolean = Me.Header.Contains(e.Location)
				If flag3 Then
					Me.Flag = New IntPtr(2)
				Else
					Dim flag4 As Boolean = Me.Current.Position = 0 Or Not Me._Resizable
					If flag4 Then
						Return
					End If
					Me.Flag = New IntPtr(CInt(Me.Current.Position))
				End If
				MyBase.Capture = False
				Dim message As Message = Message.Create(MyBase.Parent.Handle, 161, Me.Flag, Nothing)
				Me.DefWndProc(message)
				MyBase.OnMouseDown(e)
			End If
		End Sub

		' Token: 0x060000BA RID: 186 RVA: 0x00006CD0 File Offset: 0x00004ED0
		Private Function GetPointer() As Theme.Pointer
			Me.PTC = MyBase.PointToClient(Control.MousePosition)
			Me.F1 = (Me.PTC.X < 7)
			Me.F2 = (Me.PTC.X > MyBase.Width - 7)
			Me.F3 = (Me.PTC.Y < 7)
			Me.F4 = (Me.PTC.Y > MyBase.Height - 7)
			Dim flag As Boolean = Me.F1 And Me.F3
			Dim result As Theme.Pointer
			If flag Then
				result = New Theme.Pointer(Cursors.SizeNWSE, 13)
			Else
				Dim flag2 As Boolean = Me.F1 And Me.F4
				If flag2 Then
					result = New Theme.Pointer(Cursors.SizeNESW, 16)
				Else
					Dim flag3 As Boolean = Me.F2 And Me.F3
					If flag3 Then
						result = New Theme.Pointer(Cursors.SizeNESW, 14)
					Else
						Dim flag4 As Boolean = Me.F2 And Me.F4
						If flag4 Then
							result = New Theme.Pointer(Cursors.SizeNWSE, 17)
						Else
							Dim f As Boolean = Me.F1
							If f Then
								result = New Theme.Pointer(Cursors.SizeWE, 10)
							Else
								Dim f2 As Boolean = Me.F2
								If f2 Then
									result = New Theme.Pointer(Cursors.SizeWE, 11)
								Else
									Dim f3 As Boolean = Me.F3
									If f3 Then
										result = New Theme.Pointer(Cursors.SizeNS, 12)
									Else
										Dim f4 As Boolean = Me.F4
										If f4 Then
											result = New Theme.Pointer(Cursors.SizeNS, 15)
										Else
											result = New Theme.Pointer(Cursors.[Default], 0)
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x060000BB RID: 187 RVA: 0x00006E5C File Offset: 0x0000505C
		Private Sub SetCurrent()
			Me.Pending = Me.GetPointer()
			Dim flag As Boolean = Me.Current.Position = Me.Pending.Position
			If Not flag Then
				Me.Current = Me.GetPointer()
				Me.Cursor = Me.Current.Cursor
			End If
		End Sub

		' Token: 0x060000BC RID: 188 RVA: 0x00006EB4 File Offset: 0x000050B4
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			Dim resizable As Boolean = Me._Resizable
			If resizable Then
				Me.SetCurrent()
			End If
			MyBase.OnMouseMove(e)
		End Sub

		' Token: 0x060000BD RID: 189 RVA: 0x00006EDC File Offset: 0x000050DC
		Protected Overrides Sub OnSizeChanged(e As EventArgs)
			Dim flag As Boolean = MyBase.Width = 0 OrElse MyBase.Height = 0
			If Not flag Then
				' The following expression was wrapped in a checked-expression
				Me.Header = New Rectangle(7, 7, MyBase.Width - 14, Me._MoveHeight - 7)
				MyBase.Invalidate()
				MyBase.OnSizeChanged(e)
			End If
		End Sub

		' Token: 0x060000BE RID: 190
		Public MustOverride Sub PaintHook()

		' Token: 0x060000BF RID: 191 RVA: 0x00006F34 File Offset: 0x00005134
		Protected NotInheritable Overrides Sub OnPaint(e As PaintEventArgs)
			Dim flag As Boolean = MyBase.Width = 0 OrElse MyBase.Height = 0
			If Not flag Then
				Me.G = e.Graphics
				Me.PaintHook()
			End If
		End Sub

		' Token: 0x1700004E RID: 78
		' (get) Token: 0x060000C0 RID: 192 RVA: 0x00006F70 File Offset: 0x00005170
		' (set) Token: 0x060000C1 RID: 193 RVA: 0x00006F88 File Offset: 0x00005188
		Public Property TransparencyKey As Color
			Get
				Return Me._TransparencyKey
			End Get
			Set(value As Color)
				Me._TransparencyKey = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x1700004F RID: 79
		' (get) Token: 0x060000C2 RID: 194 RVA: 0x00006F9C File Offset: 0x0000519C
		' (set) Token: 0x060000C3 RID: 195 RVA: 0x00006FB4 File Offset: 0x000051B4
		Public Property Image As Image
			Get
				Return Me._Image
			End Get
			Set(value As Image)
				Me._Image = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x17000050 RID: 80
		' (get) Token: 0x060000C4 RID: 196 RVA: 0x00006FC8 File Offset: 0x000051C8
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

		' Token: 0x060000C5 RID: 197 RVA: 0x00006FF8 File Offset: 0x000051F8
		Protected Sub DrawCorners(c As Color, rect As Rectangle)
			Me._Brush = New SolidBrush(c)
			Me.G.FillRectangle(Me._Brush, rect.X, rect.Y, 1, 1)
			Me.G.FillRectangle(Me._Brush, rect.X + (rect.Width - 1), rect.Y, 1, 1)
			Me.G.FillRectangle(Me._Brush, rect.X, rect.Y + (rect.Height - 1), 1, 1)
			Me.G.FillRectangle(Me._Brush, rect.X + (rect.Width - 1), rect.Y + (rect.Height - 1), 1, 1)
		End Sub

		' Token: 0x060000C6 RID: 198 RVA: 0x000070C4 File Offset: 0x000052C4
		Protected Sub DrawBorders(p1 As Pen, p2 As Pen, rect As Rectangle)
			' The following expression was wrapped in a checked-statement
			Me.G.DrawRectangle(p1, rect.X, rect.Y, rect.Width - 1, rect.Height - 1)
			Me.G.DrawRectangle(p2, rect.X + 1, rect.Y + 1, rect.Width - 3, rect.Height - 3)
		End Sub

		' Token: 0x060000C7 RID: 199 RVA: 0x00007130 File Offset: 0x00005330
		Protected Sub DrawText(a As HorizontalAlignment, c As Color, x As Integer)
			Me.DrawText(a, c, x, 0)
		End Sub

		' Token: 0x060000C8 RID: 200 RVA: 0x00007140 File Offset: 0x00005340
		Protected Sub DrawText(a As HorizontalAlignment, c As Color, x As Integer, y As Integer)
			Dim flag As Boolean = String.IsNullOrEmpty(Me.Text)
			If Not flag Then
				Me._Size = Me.G.MeasureString(Me.Text, Me.Font).ToSize()
				Me._Brush = New SolidBrush(c)
				Select Case a
					Case 0
						Me.G.DrawString(Me.Text, Me.Font, Me._Brush, CSng(x), CSng((Me._MoveHeight / 2 - Me._Size.Height / 2 + y)))
					Case 1
						Me.G.DrawString(Me.Text, Me.Font, Me._Brush, CSng((MyBase.Width - Me._Size.Width - x)), CSng((Me._MoveHeight / 2 - Me._Size.Height / 2 + y)))
					Case 2
						Me.G.DrawString(Me.Text, Me.Font, Me._Brush, CSng((MyBase.Width / 2 - Me._Size.Width / 2 + x)), CSng((Me._MoveHeight / 2 - Me._Size.Height / 2 + y)))
				End Select
			End If
		End Sub

		' Token: 0x060000C9 RID: 201 RVA: 0x00007292 File Offset: 0x00005492
		Protected Sub DrawIcon(a As HorizontalAlignment, x As Integer)
			Me.DrawIcon(a, x, 0)
		End Sub

		' Token: 0x060000CA RID: 202 RVA: 0x000072A0 File Offset: 0x000054A0
		Protected Sub DrawIcon(a As HorizontalAlignment, x As Integer, y As Integer)
			Dim flag As Boolean = Me._Image Is Nothing
			If Not flag Then
				Select Case a
					Case 0
						Me.G.DrawImage(Me._Image, x, Me._MoveHeight / 2 - Me._Image.Height / 2 + y)
					Case 1
						Me.G.DrawImage(Me._Image, MyBase.Width - Me._Image.Width - x, Me._MoveHeight / 2 - Me._Image.Height / 2 + y)
					Case 2
						Me.G.DrawImage(Me._Image, MyBase.Width / 2 - Me._Image.Width / 2, Me._MoveHeight / 2 - Me._Image.Height / 2)
				End Select
			End If
		End Sub

		' Token: 0x060000CB RID: 203 RVA: 0x00007390 File Offset: 0x00005590
		Protected Sub DrawGradient(c1 As Color, c2 As Color, x As Integer, y As Integer, width As Integer, height As Integer, angle As Single)
			Me._Rectangle = New Rectangle(x, y, width, height)
			Me._Gradient = New LinearGradientBrush(Me._Rectangle, c1, c2, angle)
			Me.G.FillRectangle(Me._Gradient, Me._Rectangle)
		End Sub

		' Token: 0x04000050 RID: 80
		Protected G As Graphics

		' Token: 0x04000051 RID: 81
		Private ParentIsForm As Boolean

		' Token: 0x04000052 RID: 82
		Private _Resizable As Boolean

		' Token: 0x04000053 RID: 83
		Private _MoveHeight As Integer

		' Token: 0x04000054 RID: 84
		Private Flag As IntPtr

		' Token: 0x04000055 RID: 85
		Private F1 As Boolean

		' Token: 0x04000056 RID: 86
		Private F2 As Boolean

		' Token: 0x04000057 RID: 87
		Private F3 As Boolean

		' Token: 0x04000058 RID: 88
		Private F4 As Boolean

		' Token: 0x04000059 RID: 89
		Private PTC As Point

		' Token: 0x0400005A RID: 90
		Private Current As Theme.Pointer

		' Token: 0x0400005B RID: 91
		Private Pending As Theme.Pointer

		' Token: 0x0400005C RID: 92
		Protected Header As Rectangle

		' Token: 0x0400005D RID: 93
		Private _TransparencyKey As Color

		' Token: 0x0400005E RID: 94
		Private _Image As Image

		' Token: 0x0400005F RID: 95
		Private _Size As Size

		' Token: 0x04000060 RID: 96
		Private _Rectangle As Rectangle

		' Token: 0x04000061 RID: 97
		Private _Gradient As LinearGradientBrush

		' Token: 0x04000062 RID: 98
		Private _Brush As SolidBrush

		' Token: 0x0200001A RID: 26
		Private Structure Pointer
			' Token: 0x06000154 RID: 340 RVA: 0x0000A792 File Offset: 0x00008992
			Public Sub New(c As Cursor, p As Byte)
				Me = Nothing
				Me.Cursor = c
				Me.Position = p
			End Sub

			' Token: 0x04000088 RID: 136
			Public Cursor As Cursor

			' Token: 0x04000089 RID: 137
			Public Position As Byte
		End Structure
	End Class
End Namespace
