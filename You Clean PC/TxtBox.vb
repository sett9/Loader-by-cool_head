Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace You_Clean_PC
	' Token: 0x0200000D RID: 13
	Friend Class TxtBox
		Inherits ThemeControl

		' Token: 0x17000057 RID: 87
		' (get) Token: 0x060000F0 RID: 240 RVA: 0x00007D81 File Offset: 0x00005F81
		' (set) Token: 0x060000F1 RID: 241 RVA: 0x00007D8C File Offset: 0x00005F8C
		Private Overridable Property txtbox As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtbox
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = Sub(a0 As Object, a1 As EventArgs)
					Me.TextChngTxtBox()
				End Sub
				Dim txtbox As TextBox = Me._txtbox
				If txtbox IsNot Nothing Then
					txtbox.TextChanged -= eventHandler
				End If
				Me._txtbox = value
				txtbox = Me._txtbox
				If txtbox IsNot Nothing Then
					txtbox.TextChanged += eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000058 RID: 88
		' (get) Token: 0x060000F2 RID: 242 RVA: 0x00007DD0 File Offset: 0x00005FD0
		' (set) Token: 0x060000F3 RID: 243 RVA: 0x00007DE8 File Offset: 0x00005FE8
		Public Property UseSystemPasswordChar As Boolean
			Get
				Return Me._passmask
			End Get
			Set(value As Boolean)
				Me.txtbox.UseSystemPasswordChar = Me.UseSystemPasswordChar
				Me._passmask = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x17000059 RID: 89
		' (get) Token: 0x060000F4 RID: 244 RVA: 0x00007E0C File Offset: 0x0000600C
		' (set) Token: 0x060000F5 RID: 245 RVA: 0x00007E24 File Offset: 0x00006024
		Public Property MaxLength As Integer
			Get
				Return Me._maxchars
			End Get
			Set(value As Integer)
				Me._maxchars = value
				Me.txtbox.MaxLength = Me.MaxLength
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x1700005A RID: 90
		' (get) Token: 0x060000F6 RID: 246 RVA: 0x00007E48 File Offset: 0x00006048
		' (set) Token: 0x060000F7 RID: 247 RVA: 0x00007E60 File Offset: 0x00006060
		Public Property TextAlignment As HorizontalAlignment
			Get
				Return Me._align
			End Get
			Set(value As HorizontalAlignment)
				Me._align = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x060000F8 RID: 248 RVA: 0x00003196 File Offset: 0x00001396
		Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
		End Sub

		' Token: 0x060000F9 RID: 249 RVA: 0x00007E71 File Offset: 0x00006071
		Protected Overrides Sub OnTextChanged(e As EventArgs)
			MyBase.OnTextChanged(e)
			MyBase.Invalidate()
		End Sub

		' Token: 0x060000FA RID: 250 RVA: 0x00007E83 File Offset: 0x00006083
		Protected Overrides Sub OnBackColorChanged(e As EventArgs)
			MyBase.OnBackColorChanged(e)
			Me.txtbox.BackColor = Me.BackColor
			MyBase.Invalidate()
		End Sub

		' Token: 0x060000FB RID: 251 RVA: 0x00007EA7 File Offset: 0x000060A7
		Protected Overrides Sub OnForeColorChanged(e As EventArgs)
			MyBase.OnForeColorChanged(e)
			Me.txtbox.ForeColor = Me.ForeColor
			MyBase.Invalidate()
		End Sub

		' Token: 0x060000FC RID: 252 RVA: 0x00007ECB File Offset: 0x000060CB
		Protected Overrides Sub OnFontChanged(e As EventArgs)
			MyBase.OnFontChanged(e)
			Me.txtbox.Font = Me.Font
		End Sub

		' Token: 0x060000FD RID: 253 RVA: 0x00007EE8 File Offset: 0x000060E8
		Protected Overrides Sub OnGotFocus(e As EventArgs)
			MyBase.OnGotFocus(e)
			Me.txtbox.Focus()
		End Sub

		' Token: 0x060000FE RID: 254 RVA: 0x00007EFF File Offset: 0x000060FF
		Public Sub TextChngTxtBox()
			Me.Text = Me.txtbox.Text
		End Sub

		' Token: 0x060000FF RID: 255 RVA: 0x00007F14 File Offset: 0x00006114
		Public Sub TextChng()
			Me.txtbox.Text = Me.Text
		End Sub

		' Token: 0x06000100 RID: 256 RVA: 0x00007F2C File Offset: 0x0000612C
		Protected Overrides Sub WndProc(ByRef m As Message)
			Dim msg As Integer = m.Msg
			If msg <> 15 Then
				MyBase.WndProc(m)
			Else
				MyBase.Invalidate()
				MyBase.WndProc(m)
				Me.PaintHook()
			End If
		End Sub

		' Token: 0x06000101 RID: 257 RVA: 0x00007F70 File Offset: 0x00006170
		Public Sub New()
			MyBase.TextChanged += Sub(a0 As Object, a1 As EventArgs)
				Me.TextChng()
			End Sub
			Me.txtbox = New TextBox()
			Me._passmask = False
			Me._maxchars = 32767
			MyBase.Controls.Add(Me.txtbox)
			Dim txtbox As TextBox = Me.txtbox
			txtbox.Multiline = False
			txtbox.BackColor = Color.FromArgb(0, 0, 0)
			txtbox.ForeColor = Me.ForeColor
			txtbox.Text = String.Empty
			txtbox.TextAlign = 2
			txtbox.BorderStyle = 0
			txtbox.Location = New Point(5, 8)
			txtbox.Font = New Font("Arial", 8.25F, 1)
			txtbox.Size = New Size(MyBase.Width - 8, MyBase.Height - 11)
			txtbox.UseSystemPasswordChar = Me.UseSystemPasswordChar
			Me.Text = ""
			Me.DoubleBuffered = True
		End Sub

		' Token: 0x06000102 RID: 258 RVA: 0x00008078 File Offset: 0x00006278
		Public Overrides Sub PaintHook()
			Me.BackColor = Color.White
			Me.G.Clear(MyBase.Parent.BackColor)
			Dim pen As Pen = New Pen(Color.FromArgb(204, 204, 204), 1F)
			Dim pen2 As Pen = New Pen(Color.FromArgb(252, 252, 252), 7F)
			Me.G.FillPath(Brushes.White, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 2))
			Me.G.DrawPath(pen2, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 2))
			Me.G.DrawPath(pen, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 2))
			MyBase.Height = Me.txtbox.Height + 16
			Dim font As Font = New Font("Tahoma", 9F, 0)
			Dim txtbox As TextBox = Me.txtbox
			txtbox.Width = MyBase.Width - 12
			txtbox.ForeColor = Color.FromArgb(72, 72, 72)
			txtbox.Font = font
			txtbox.TextAlign = Me.TextAlignment
			txtbox.UseSystemPasswordChar = Me.UseSystemPasswordChar
			MyBase.DrawCorners(MyBase.Parent.BackColor, MyBase.ClientRectangle)
		End Sub

		' Token: 0x04000072 RID: 114
		Private _passmask As Boolean

		' Token: 0x04000073 RID: 115
		Private _maxchars As Integer

		' Token: 0x04000074 RID: 116
		Private _align As HorizontalAlignment
	End Class
End Namespace
