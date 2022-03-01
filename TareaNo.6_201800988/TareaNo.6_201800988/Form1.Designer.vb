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
        Me.Menos1 = New System.Windows.Forms.Button()
        Me.Mas1 = New System.Windows.Forms.Button()
        Me.Menos2 = New System.Windows.Forms.Button()
        Me.Mas2 = New System.Windows.Forms.Button()
        Me.Suma1 = New System.Windows.Forms.Button()
        Me.Resta1 = New System.Windows.Forms.Button()
        Me.Multiplicación1 = New System.Windows.Forms.Button()
        Me.División1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Num1 = New System.Windows.Forms.Label()
        Me.Num2 = New System.Windows.Forms.Label()
        Me.A = New System.Windows.Forms.Label()
        Me.B = New System.Windows.Forms.Label()
        Me.ResultadoTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Limpiar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Menos1
        '
        Me.Menos1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Menos1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menos1.Location = New System.Drawing.Point(204, 99)
        Me.Menos1.Name = "Menos1"
        Me.Menos1.Size = New System.Drawing.Size(60, 56)
        Me.Menos1.TabIndex = 0
        Me.Menos1.Text = "-"
        Me.Menos1.UseVisualStyleBackColor = False
        '
        'Mas1
        '
        Me.Mas1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Mas1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mas1.Location = New System.Drawing.Point(367, 99)
        Me.Mas1.Name = "Mas1"
        Me.Mas1.Size = New System.Drawing.Size(60, 56)
        Me.Mas1.TabIndex = 1
        Me.Mas1.Text = "+"
        Me.Mas1.UseVisualStyleBackColor = False
        '
        'Menos2
        '
        Me.Menos2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Menos2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menos2.Location = New System.Drawing.Point(204, 271)
        Me.Menos2.Name = "Menos2"
        Me.Menos2.Size = New System.Drawing.Size(60, 56)
        Me.Menos2.TabIndex = 2
        Me.Menos2.Text = "-"
        Me.Menos2.UseVisualStyleBackColor = False
        '
        'Mas2
        '
        Me.Mas2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Mas2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mas2.Location = New System.Drawing.Point(367, 271)
        Me.Mas2.Name = "Mas2"
        Me.Mas2.Size = New System.Drawing.Size(60, 56)
        Me.Mas2.TabIndex = 3
        Me.Mas2.Text = "+"
        Me.Mas2.UseVisualStyleBackColor = False
        '
        'Suma1
        '
        Me.Suma1.BackColor = System.Drawing.SystemColors.Info
        Me.Suma1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Suma1.Location = New System.Drawing.Point(496, 109)
        Me.Suma1.Name = "Suma1"
        Me.Suma1.Size = New System.Drawing.Size(184, 37)
        Me.Suma1.TabIndex = 4
        Me.Suma1.Text = "Suma"
        Me.Suma1.UseVisualStyleBackColor = False
        '
        'Resta1
        '
        Me.Resta1.BackColor = System.Drawing.SystemColors.Info
        Me.Resta1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resta1.Location = New System.Drawing.Point(496, 170)
        Me.Resta1.Name = "Resta1"
        Me.Resta1.Size = New System.Drawing.Size(184, 36)
        Me.Resta1.TabIndex = 5
        Me.Resta1.Text = "Resta"
        Me.Resta1.UseVisualStyleBackColor = False
        '
        'Multiplicación1
        '
        Me.Multiplicación1.BackColor = System.Drawing.SystemColors.Info
        Me.Multiplicación1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiplicación1.Location = New System.Drawing.Point(496, 229)
        Me.Multiplicación1.Name = "Multiplicación1"
        Me.Multiplicación1.Size = New System.Drawing.Size(184, 34)
        Me.Multiplicación1.TabIndex = 6
        Me.Multiplicación1.Text = "Multiplicación"
        Me.Multiplicación1.UseVisualStyleBackColor = False
        '
        'División1
        '
        Me.División1.BackColor = System.Drawing.SystemColors.Info
        Me.División1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.División1.Location = New System.Drawing.Point(496, 290)
        Me.División1.Name = "División1"
        Me.División1.Size = New System.Drawing.Size(184, 37)
        Me.División1.TabIndex = 7
        Me.División1.Text = "División"
        Me.División1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.TareaNo._6_201800988.My.Resources.Resources.Usac
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(-52, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 91)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Num1
        '
        Me.Num1.AutoSize = True
        Me.Num1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Num1.Location = New System.Drawing.Point(294, 109)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(44, 46)
        Me.Num1.TabIndex = 9
        Me.Num1.Text = "0"
        '
        'Num2
        '
        Me.Num2.AutoSize = True
        Me.Num2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Num2.Location = New System.Drawing.Point(294, 278)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(44, 46)
        Me.Num2.TabIndex = 10
        Me.Num2.Text = "0"
        '
        'A
        '
        Me.A.AutoSize = True
        Me.A.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A.Location = New System.Drawing.Point(149, 100)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(49, 46)
        Me.A.TabIndex = 11
        Me.A.Text = "A"
        '
        'B
        '
        Me.B.AutoSize = True
        Me.B.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B.Location = New System.Drawing.Point(149, 278)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(49, 46)
        Me.B.TabIndex = 12
        Me.B.Text = "B"
        '
        'ResultadoTotal
        '
        Me.ResultadoTotal.AutoSize = True
        Me.ResultadoTotal.BackColor = System.Drawing.Color.Transparent
        Me.ResultadoTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultadoTotal.ForeColor = System.Drawing.Color.SeaGreen
        Me.ResultadoTotal.Location = New System.Drawing.Point(150, 340)
        Me.ResultadoTotal.Name = "ResultadoTotal"
        Me.ResultadoTotal.Size = New System.Drawing.Size(333, 46)
        Me.ResultadoTotal.TabIndex = 13
        Me.ResultadoTotal.Text = "El resultado es: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(152, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(510, 32)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Sebastián Gabriel Garcia Villalobos "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(325, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 32)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "201800988"
        '
        'Limpiar
        '
        Me.Limpiar.BackColor = System.Drawing.SystemColors.Info
        Me.Limpiar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpiar.Location = New System.Drawing.Point(546, 396)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(90, 42)
        Me.Limpiar.TabIndex = 16
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ResultadoTotal)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.Num1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.División1)
        Me.Controls.Add(Me.Multiplicación1)
        Me.Controls.Add(Me.Resta1)
        Me.Controls.Add(Me.Suma1)
        Me.Controls.Add(Me.Mas2)
        Me.Controls.Add(Me.Menos2)
        Me.Controls.Add(Me.Mas1)
        Me.Controls.Add(Me.Menos1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menos1 As Button
    Friend WithEvents Mas1 As Button
    Friend WithEvents Menos2 As Button
    Friend WithEvents Mas2 As Button
    Friend WithEvents Suma1 As Button
    Friend WithEvents Resta1 As Button
    Friend WithEvents Multiplicación1 As Button
    Friend WithEvents División1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Num1 As Label
    Friend WithEvents Num2 As Label
    Friend WithEvents A As Label
    Friend WithEvents B As Label
    Friend WithEvents ResultadoTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Limpiar As Button
End Class
