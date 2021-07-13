<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxDistance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxSpeed = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTime = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonTime = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSpeed = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDistance = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonClean = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxDistance)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxSpeed)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxTime)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 297)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los valores respectivos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(736, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "min"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(424, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Km/h"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Km"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Distancia"
        '
        'TextBoxDistance
        '
        Me.TextBoxDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDistance.Location = New System.Drawing.Point(32, 243)
        Me.TextBoxDistance.Name = "TextBoxDistance"
        Me.TextBoxDistance.Size = New System.Drawing.Size(100, 34)
        Me.TextBoxDistance.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(318, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Velocidad"
        '
        'TextBoxSpeed
        '
        Me.TextBoxSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSpeed.Location = New System.Drawing.Point(318, 243)
        Me.TextBoxSpeed.Name = "TextBoxSpeed"
        Me.TextBoxSpeed.Size = New System.Drawing.Size(100, 34)
        Me.TextBoxSpeed.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(630, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tiempo"
        '
        'TextBoxTime
        '
        Me.TextBoxTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTime.Location = New System.Drawing.Point(630, 243)
        Me.TextBoxTime.Name = "TextBoxTime"
        Me.TextBoxTime.Size = New System.Drawing.Size(100, 34)
        Me.TextBoxTime.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButtonTime)
        Me.GroupBox2.Controls.Add(Me.RadioButtonSpeed)
        Me.GroupBox2.Controls.Add(Me.RadioButtonDistance)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(764, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione el valor que desea calcular"
        '
        'RadioButtonTime
        '
        Me.RadioButtonTime.AutoSize = True
        Me.RadioButtonTime.Location = New System.Drawing.Point(632, 49)
        Me.RadioButtonTime.Name = "RadioButtonTime"
        Me.RadioButtonTime.Size = New System.Drawing.Size(126, 21)
        Me.RadioButtonTime.TabIndex = 2
        Me.RadioButtonTime.TabStop = True
        Me.RadioButtonTime.Text = "Calcular tiempo"
        Me.RadioButtonTime.UseVisualStyleBackColor = True
        '
        'RadioButtonSpeed
        '
        Me.RadioButtonSpeed.AutoSize = True
        Me.RadioButtonSpeed.Location = New System.Drawing.Point(312, 49)
        Me.RadioButtonSpeed.Name = "RadioButtonSpeed"
        Me.RadioButtonSpeed.Size = New System.Drawing.Size(144, 21)
        Me.RadioButtonSpeed.TabIndex = 1
        Me.RadioButtonSpeed.TabStop = True
        Me.RadioButtonSpeed.Text = "Calcular velocidad"
        Me.RadioButtonSpeed.UseVisualStyleBackColor = True
        '
        'RadioButtonDistance
        '
        Me.RadioButtonDistance.AutoSize = True
        Me.RadioButtonDistance.Location = New System.Drawing.Point(26, 49)
        Me.RadioButtonDistance.Name = "RadioButtonDistance"
        Me.RadioButtonDistance.Size = New System.Drawing.Size(140, 21)
        Me.RadioButtonDistance.TabIndex = 0
        Me.RadioButtonDistance.TabStop = True
        Me.RadioButtonDistance.Text = "Calcular distancia"
        Me.RadioButtonDistance.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(719, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Programa que calcula la velocidad, espacio y tiempo de un vehículo que mueve de u" &
    "n punto A hasta un Punto B."
        '
        'ButtonClean
        '
        Me.ButtonClean.Location = New System.Drawing.Point(667, 335)
        Me.ButtonClean.Name = "ButtonClean"
        Me.ButtonClean.Size = New System.Drawing.Size(75, 29)
        Me.ButtonClean.TabIndex = 6
        Me.ButtonClean.Text = "Limpiar"
        Me.ButtonClean.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 393)
        Me.Controls.Add(Me.ButtonClean)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tiempo, velocidad y espacio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxTime As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButtonTime As RadioButton
    Friend WithEvents RadioButtonSpeed As RadioButton
    Friend WithEvents RadioButtonDistance As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxDistance As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxSpeed As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonClean As Button
End Class
