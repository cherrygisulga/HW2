<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.AgeBox = New System.Windows.Forms.TextBox()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.TextButtton = New System.Windows.Forms.Button()
        Me.XMLButton = New System.Windows.Forms.Button()
        Me.JSONButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(22, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(22, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address:"
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(103, 34)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(195, 20)
        Me.NameBox.TabIndex = 3
        '
        'AgeBox
        '
        Me.AgeBox.Location = New System.Drawing.Point(103, 69)
        Me.AgeBox.Name = "AgeBox"
        Me.AgeBox.Size = New System.Drawing.Size(195, 20)
        Me.AgeBox.TabIndex = 4
        '
        'AddressBox
        '
        Me.AddressBox.Location = New System.Drawing.Point(103, 100)
        Me.AddressBox.Multiline = True
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(195, 75)
        Me.AddressBox.TabIndex = 5
        '
        'TextButtton
        '
        Me.TextButtton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.TextButtton.FlatAppearance.BorderSize = 0
        Me.TextButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TextButtton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextButtton.Location = New System.Drawing.Point(26, 215)
        Me.TextButtton.Name = "TextButtton"
        Me.TextButtton.Size = New System.Drawing.Size(75, 30)
        Me.TextButtton.TabIndex = 6
        Me.TextButtton.Text = "Text"
        Me.TextButtton.UseVisualStyleBackColor = False
        '
        'XMLButton
        '
        Me.XMLButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.XMLButton.FlatAppearance.BorderSize = 0
        Me.XMLButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.XMLButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XMLButton.Location = New System.Drawing.Point(128, 215)
        Me.XMLButton.Name = "XMLButton"
        Me.XMLButton.Size = New System.Drawing.Size(75, 30)
        Me.XMLButton.TabIndex = 7
        Me.XMLButton.Text = "XML"
        Me.XMLButton.UseVisualStyleBackColor = False
        '
        'JSONButton
        '
        Me.JSONButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.JSONButton.FlatAppearance.BorderSize = 0
        Me.JSONButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JSONButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.JSONButton.Location = New System.Drawing.Point(223, 215)
        Me.JSONButton.Name = "JSONButton"
        Me.JSONButton.Size = New System.Drawing.Size(75, 30)
        Me.JSONButton.TabIndex = 8
        Me.JSONButton.Text = "JSON"
        Me.JSONButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(328, 270)
        Me.Controls.Add(Me.JSONButton)
        Me.Controls.Add(Me.XMLButton)
        Me.Controls.Add(Me.TextButtton)
        Me.Controls.Add(Me.AddressBox)
        Me.Controls.Add(Me.AgeBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "HW2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents AgeBox As TextBox
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents TextButtton As Button
    Friend WithEvents XMLButton As Button
    Friend WithEvents JSONButton As Button
End Class
