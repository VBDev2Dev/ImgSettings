﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pbxCat = New System.Windows.Forms.PictureBox()
        CType(Me.pbxCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxCat
        '
        Me.pbxCat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxCat.Image = Global.imgSettings.My.Resources.Resources.defaultImage
        Me.pbxCat.Location = New System.Drawing.Point(0, 0)
        Me.pbxCat.Name = "pbxCat"
        Me.pbxCat.Size = New System.Drawing.Size(600, 457)
        Me.pbxCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxCat.TabIndex = 0
        Me.pbxCat.TabStop = False
        '
        'frmImg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 457)
        Me.Controls.Add(Me.pbxCat)
        Me.Name = "frmImg"
        Me.Text = "frmImg"
        CType(Me.pbxCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxCat As PictureBox
End Class
