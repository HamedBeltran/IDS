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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ActiveCaptionText
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(613, 373)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos personales"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "CDMX", "Chiapas", "Chihuahua", "Coahuila", "Colima", "Durango", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "Estado de México", "Michoacán", "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro", "Quintana Roo", "San Luis Potosí", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas"})
        ComboBox1.Location = New Point(23, 239)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(216, 29)
        ComboBox1.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 204)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 21)
        Label1.TabIndex = 6
        Label1.Text = "Estado"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(386, 228)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 100)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Horario"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(17, 61)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(88, 21)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Vespertino"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(17, 28)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(78, 21)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Matutino"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.White
        TextBox3.Location = New Point(211, 168)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(375, 29)
        TextBox3.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.Location = New Point(211, 113)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(375, 29)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.Location = New Point(211, 59)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(375, 29)
        TextBox1.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(90, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 21)
        Label4.TabIndex = 2
        Label4.Text = "Direccion"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(5, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 21)
        Label3.TabIndex = 1
        Label3.Text = "Fecha de nacimiento"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 21)
        Label2.TabIndex = 0
        Label2.Text = "Nombre completo"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(273, 344)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 41)
        Button1.TabIndex = 2
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(662, 397)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Expediente de alumno"
        TransparencyKey = Color.Black
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox

End Class
