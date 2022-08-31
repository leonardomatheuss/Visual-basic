<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Btm_NumersInteiros = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Btm_PontoFlutuante = New System.Windows.Forms.Button()
        Me.Btm_ConversaoNumeros = New System.Windows.Forms.Button()
        Me.Txt_Numerador = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Txt_Denominador = New System.Windows.Forms.TextBox()
        Me.Btm_Resultado = New System.Windows.Forms.Button()
        Me.Txt_ResultadoDecimal = New System.Windows.Forms.TextBox()
        Me.Txt_ResultadoDouble = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btm_NumersInteiros
        '
        Me.Btm_NumersInteiros.Location = New System.Drawing.Point(12, 41)
        Me.Btm_NumersInteiros.Name = "Btm_NumersInteiros"
        Me.Btm_NumersInteiros.Size = New System.Drawing.Size(156, 39)
        Me.Btm_NumersInteiros.TabIndex = 0
        Me.Btm_NumersInteiros.Text = "Exemplos Números Inteiros"
        Me.Btm_NumersInteiros.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(104, 13)
        Me.Lbl_NomeProjeto.TabIndex = 2
        Me.Lbl_NomeProjeto.Text = "2 - Criando Variáveis"
        '
        'Btm_PontoFlutuante
        '
        Me.Btm_PontoFlutuante.Location = New System.Drawing.Point(12, 120)
        Me.Btm_PontoFlutuante.Name = "Btm_PontoFlutuante"
        Me.Btm_PontoFlutuante.Size = New System.Drawing.Size(156, 39)
        Me.Btm_PontoFlutuante.TabIndex = 3
        Me.Btm_PontoFlutuante.Text = "Exemplos Números Ponto Flutuantes"
        Me.Btm_PontoFlutuante.UseVisualStyleBackColor = True
        '
        'Btm_ConversaoNumeros
        '
        Me.Btm_ConversaoNumeros.Location = New System.Drawing.Point(12, 201)
        Me.Btm_ConversaoNumeros.Name = "Btm_ConversaoNumeros"
        Me.Btm_ConversaoNumeros.Size = New System.Drawing.Size(156, 39)
        Me.Btm_ConversaoNumeros.TabIndex = 4
        Me.Btm_ConversaoNumeros.Text = "Exemplos  de conversão de numeros"
        Me.Btm_ConversaoNumeros.UseVisualStyleBackColor = True
        '
        'Txt_Numerador
        '
        Me.Txt_Numerador.Location = New System.Drawing.Point(410, 57)
        Me.Txt_Numerador.Name = "Txt_Numerador"
        Me.Txt_Numerador.Size = New System.Drawing.Size(200, 20)
        Me.Txt_Numerador.TabIndex = 5
        Me.Txt_Numerador.Text = "4"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Txt_Denominador
        '
        Me.Txt_Denominador.Location = New System.Drawing.Point(410, 98)
        Me.Txt_Denominador.Name = "Txt_Denominador"
        Me.Txt_Denominador.Size = New System.Drawing.Size(200, 20)
        Me.Txt_Denominador.TabIndex = 7
        '
        'Btm_Resultado
        '
        Me.Btm_Resultado.Location = New System.Drawing.Point(410, 136)
        Me.Btm_Resultado.Name = "Btm_Resultado"
        Me.Btm_Resultado.Size = New System.Drawing.Size(200, 22)
        Me.Btm_Resultado.TabIndex = 8
        Me.Btm_Resultado.Text = "Resultado"
        Me.Btm_Resultado.UseVisualStyleBackColor = True
        '
        'Txt_ResultadoDecimal
        '
        Me.Txt_ResultadoDecimal.Location = New System.Drawing.Point(409, 182)
        Me.Txt_ResultadoDecimal.Name = "Txt_ResultadoDecimal"
        Me.Txt_ResultadoDecimal.Size = New System.Drawing.Size(320, 20)
        Me.Txt_ResultadoDecimal.TabIndex = 9
        '
        'Txt_ResultadoDouble
        '
        Me.Txt_ResultadoDouble.Location = New System.Drawing.Point(409, 220)
        Me.Txt_ResultadoDouble.Name = "Txt_ResultadoDouble"
        Me.Txt_ResultadoDouble.Size = New System.Drawing.Size(320, 20)
        Me.Txt_ResultadoDouble.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 336)
        Me.Controls.Add(Me.Txt_ResultadoDouble)
        Me.Controls.Add(Me.Txt_ResultadoDecimal)
        Me.Controls.Add(Me.Btm_Resultado)
        Me.Controls.Add(Me.Txt_Denominador)
        Me.Controls.Add(Me.Txt_Numerador)
        Me.Controls.Add(Me.Btm_ConversaoNumeros)
        Me.Controls.Add(Me.Btm_PontoFlutuante)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_NumersInteiros)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação Alô mundo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_NumersInteiros As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Btm_PontoFlutuante As Button
    Friend WithEvents Btm_ConversaoNumeros As Button
    Friend WithEvents Txt_Numerador As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Txt_Denominador As TextBox
    Friend WithEvents Btm_Resultado As Button
    Friend WithEvents Txt_ResultadoDecimal As TextBox
    Friend WithEvents Txt_ResultadoDouble As TextBox
End Class
