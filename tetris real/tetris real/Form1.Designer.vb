<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        avatar = New PictureBox()
        enemy = New PictureBox()
        Timer1 = New Timer(components)
        enemytwo = New PictureBox()
        CType(avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemytwo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' avatar
        ' 
        avatar.Image = CType(resources.GetObject("avatar.Image"), Image)
        avatar.Location = New Point(65, 13)
        avatar.Name = "avatar"
        avatar.Size = New Size(90, 120)
        avatar.SizeMode = PictureBoxSizeMode.StretchImage
        avatar.TabIndex = 0
        avatar.TabStop = False
        ' 
        ' enemy
        ' 
        enemy.Image = CType(resources.GetObject("enemy.Image"), Image)
        enemy.Location = New Point(240, 17)
        enemy.Name = "enemy"
        enemy.Size = New Size(113, 123)
        enemy.SizeMode = PictureBoxSizeMode.StretchImage
        enemy.TabIndex = 1
        enemy.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 500
        ' 
        ' enemytwo
        ' 
        enemytwo.Image = CType(resources.GetObject("enemytwo.Image"), Image)
        enemytwo.Location = New Point(401, 17)
        enemytwo.Name = "enemytwo"
        enemytwo.Size = New Size(113, 123)
        enemytwo.SizeMode = PictureBoxSizeMode.StretchImage
        enemytwo.TabIndex = 2
        enemytwo.TabStop = False
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(enemytwo)
        Controls.Add(enemy)
        Controls.Add(avatar)
        Name = "form1"
        Text = "Form1"
        CType(avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(enemytwo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents avatar As PictureBox
    Friend WithEvents enemy As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents enemytwo As PictureBox

End Class
