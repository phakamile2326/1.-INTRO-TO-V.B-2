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
        CheckBox1 = New CheckBox()
        btnClickHere = New Button()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        RadioButton1 = New RadioButton()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(402, 297)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(67, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Sign Up"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' btnClickHere
        ' 
        btnClickHere.Location = New Point(394, 346)
        btnClickHere.Name = "btnClickHere"
        btnClickHere.Size = New Size(75, 23)
        btnClickHere.TabIndex = 1
        btnClickHere.Text = "Click Here"
        btnClickHere.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"18-25", "25-35", "40+"})
        ComboBox1.Location = New Point(332, 235)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(235, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 3
        Label1.Text = "Name"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(595, 115)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(53, 19)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "Black"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("SimSun", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        TextBox1.Location = New Point(340, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(323, 38)
        TextBox1.TabIndex = 5
        TextBox1.Text = "Community development"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(355, 107)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(355, 189)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 5
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(666, 231)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(235, 193)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 3
        Label2.Text = "Qualification"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(235, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 3
        Label3.Text = "Ward"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(595, 140)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(56, 19)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "White"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(595, 201)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(74, 19)
        RadioButton3.TabIndex = 4
        RadioButton3.TabStop = True
        RadioButton3.Text = "Coloured"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(595, 176)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(58, 19)
        RadioButton4.TabIndex = 4
        RadioButton4.TabStop = True
        RadioButton4.Text = "Indian"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(968, 311)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 5
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(353, 145)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(235, 243)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 15)
        Label5.TabIndex = 6
        Label5.Text = "Age Group"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(569, 234)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 15)
        Label6.TabIndex = 7
        Label6.Text = "If Other, Specify"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox6)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Controls.Add(btnClickHere)
        Controls.Add(CheckBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnClickHere As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
