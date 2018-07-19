Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace You_Clean_PC
	' Token: 0x0200000E RID: 14
	Friend Class MultiTxtBox
		Inherits ThemeControl

		' Token: 0x1700005B RID: 91
		' (get) Token: 0x06000105 RID: 261 RVA: 0x00008206 File Offset: 0x00006406
		' (set) Token: 0x06000106 RID: 262 RVA: 0x00008210 File Offset: 0x00006410
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

		' Token: 0x1700005C RID: 92
		' (get) Token: 0x06000107 RID: 263 RVA: 0x00008254 File Offset: 0x00006454
		' (set) Token: 0x06000108 RID: 264 RVA: 0x0000826C File Offset: 0x0000646C
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

		' Token: 0x1700005D RID: 93
		' (get) Token: 0x06000109 RID: 265 RVA: 0x00008290 File Offset: 0x00006490
		' (set) Token: 0x0600010A RID: 266 RVA: 0x000082A8 File Offset: 0x000064A8
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

		' Token: 0x1700005E RID: 94
		' (get) Token: 0x0600010B RID: 267 RVA: 0x000082CC File Offset: 0x000064CC
		' (set) Token: 0x0600010C RID: 268 RVA: 0x000082E4 File Offset: 0x000064E4
		Public Property TextAlignment As HorizontalAlignment
			Get
				Return Me._align
			End Get
			Set(value As HorizontalAlignment)
				Me._align = value
				MyBase.Invalidate()
			End Set
		End Property

		' Token: 0x0600010D RID: 269 RVA: 0x00003196 File Offset: 0x00001396
		Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
		End Sub

		' Token: 0x0600010E RID: 270 RVA: 0x00007E71 File Offset: 0x00006071
		Protected Overrides Sub OnTextChanged(e As EventArgs)
			MyBase.OnTextChanged(e)
			MyBase.Invalidate()
		End Sub

		' Token: 0x0600010F RID: 271 RVA: 0x000082F5 File Offset: 0x000064F5
		Protected Overrides Sub OnBackColorChanged(e As EventArgs)
			MyBase.OnBackColorChanged(e)
			Me.txtbox.BackColor = Me.BackColor
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000110 RID: 272 RVA: 0x00008319 File Offset: 0x00006519
		Protected Overrides Sub OnForeColorChanged(e As EventArgs)
			MyBase.OnForeColorChanged(e)
			Me.txtbox.ForeColor = Me.ForeColor
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000111 RID: 273 RVA: 0x0000833D File Offset: 0x0000653D
		Protected Overrides Sub OnFontChanged(e As EventArgs)
			MyBase.OnFontChanged(e)
			Me.txtbox.Font = Me.Font
		End Sub

		' Token: 0x06000112 RID: 274 RVA: 0x0000835A File Offset: 0x0000655A
		Protected Overrides Sub OnGotFocus(e As EventArgs)
			MyBase.OnGotFocus(e)
			Me.txtbox.Focus()
		End Sub

		' Token: 0x06000113 RID: 275 RVA: 0x00008371 File Offset: 0x00006571
		Public Sub TextChngTxtBox()
			Me.Text = Me.txtbox.Text
		End Sub

		' Token: 0x06000114 RID: 276 RVA: 0x00008386 File Offset: 0x00006586
		Public Sub TextChng()
			Me.txtbox.Text = Me.Text
		End Sub

		' Token: 0x06000115 RID: 277 RVA: 0x0000839C File Offset: 0x0000659C
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

		' Token: 0x06000116 RID: 278 RVA: 0x000083E0 File Offset: 0x000065E0
		Public Sub New()
			MyBase.TextChanged += Sub(a0 As Object, a1 As EventArgs)
				Me.TextChng()
			End Sub
			Me.txtbox = New TextBox()
			Me._passmask = False
			Me._maxchars = 32767
			MyBase.Controls.Add(Me.txtbox)
			Dim txtbox As TextBox = Me.txtbox
			txtbox.ScrollBars = 2
			txtbox.Multiline = True
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

		' Token: 0x06000117 RID: 279 RVA: 0x000084F0 File Offset: 0x000066F0
		Public Overrides Sub PaintHook()
			Me.BackColor = Color.White
			Me.G.Clear(MyBase.Parent.BackColor)
			Dim pen As Pen = New Pen(Color.FromArgb(204, 204, 204), 1F)
			Dim pen2 As Pen = New Pen(Color.FromArgb(252, 252, 252), 7F)
			Me.G.FillPath(Brushes.White, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 2))
			Me.G.DrawPath(pen2, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 2))
			Me.G.DrawPath(pen, Draw.RoundRect(New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1), 2))
			Dim font As Font = New Font("Tahoma", 9F, 0)
			Dim txtbox As TextBox = Me.txtbox
			txtbox.Size = New Size(MyBase.Width - 10, MyBase.Height - 14)
			txtbox.ForeColor = Color.FromArgb(72, 72, 72)
			txtbox.Font = font
			txtbox.TextAlign = Me.TextAlignment
			txtbox.UseSystemPasswordChar = Me.UseSystemPasswordChar
			MyBase.DrawCorners(MyBase.Parent.BackColor, MyBase.ClientRectangle)
		End Sub

		' Token: 0x04000076 RID: 118
		Private _passmask As Boolean

		' Token: 0x04000077 RID: 119
		Private _maxchars As Integer

		' Token: 0x04000078 RID: 120
		Private _align As HorizontalAlignment
	End Class
End Namespace
