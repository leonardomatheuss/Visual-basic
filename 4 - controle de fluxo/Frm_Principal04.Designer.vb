<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal04
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btm_Principal = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Lbl_idade = New System.Windows.Forms.Label()
        Me.Txt_idade = New System.Windows.Forms.TextBox()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.Lbl_resultado = New System.Windows.Forms.Label()
        Me.Grp_Pais = New System.Windows.Forms.GroupBox()
        Me.Rdb_Nao = New System.Windows.Forms.RadioButton()
        Me.Rdb_Sim = New System.Windows.Forms.RadioButton()
        Me.Grp_Pais.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btm_Principal
        '
        Me.Btm_Principal.Location = New System.Drawing.Point(7, 110)
        Me.Btm_Principal.Name = "Btm_Principal"
        Me.Btm_Principal.Size = New System.Drawing.Size(208, 43)
        Me.Btm_Principal.TabIndex = 0
        Me.Btm_Principal.Text = "Clique aqui!"
        Me.Btm_Principal.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(98, 13)
        Me.Lbl_NomeProjeto.TabIndex = 1
        Me.Lbl_NomeProjeto.Text = "1 - Primeiro Projeto "
        '
        'Lbl_idade
        '
        Me.Lbl_idade.AutoSize = True
        Me.Lbl_idade.Location = New System.Drawing.Point(12, 48)
        Me.Lbl_idade.Name = "Lbl_idade"
        Me.Lbl_idade.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_idade.TabIndex = 2
        Me.Lbl_idade.Text = "Label1"
        '
        'Txt_idade
        '
        Me.Txt_idade.Location = New System.Drawing.Point(7, 75)
        Me.Txt_idade.Name = "Txt_idade"
        Me.Txt_idade.Size = New System.Drawing.Size(103, 20)
        Me.Txt_idade.TabIndex = 3
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Location = New System.Drawing.Point(7, 208)
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.Size = New System.Drawing.Size(439, 20)
        Me.Txt_Resultado.TabIndex = 4
        '
        'Lbl_resultado
        '
        Me.Lbl_resultado.AutoSize = True
        Me.Lbl_resultado.Location = New System.Drawing.Point(4, 192)
        Me.Lbl_resultado.Name = "Lbl_resultado"
        Me.Lbl_resultado.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_resultado.TabIndex = 5
        Me.Lbl_resultado.Text = "Label1"
        '
        'Grp_Pais
        '
        Me.Grp_Pais.Controls.Add(Me.Rdb_Nao)
        Me.Grp_Pais.Controls.Add(Me.Rdb_Sim)
        Me.Grp_Pais.Location = New System.Drawing.Point(116, 37)
        Me.Grp_Pais.Name = "Grp_Pais"
        Me.Grp_Pais.Size = New System.Drawing.Size(201, 58)
        Me.Grp_Pais.TabIndex = 6
        Me.Grp_Pais.TabStop = False
        Me.Grp_Pais.Text = "GroupBox1"
        '
        'Rdb_Nao
        '
        Me.Rdb_Nao.AutoSize = True
        Me.Rdb_Nao.Location = New System.Drawing.Point(105, 29)
        Me.Rdb_Nao.Name = "Rdb_Nao"
        Me.Rdb_Nao.Size = New System.Drawing.Size(90, 17)
        Me.Rdb_Nao.TabIndex = 7
        Me.Rdb_Nao.TabStop = True
        Me.Rdb_Nao.Text = "RadioButton1"
        Me.Rdb_Nao.UseVisualStyleBackColor = True
        '
        'Rdb_Sim
        '
        Me.Rdb_Sim.AutoSize = True
        Me.Rdb_Sim.Location = New System.Drawing.Point(9, 29)
        Me.Rdb_Sim.Name = "Rdb_Sim"
        Me.Rdb_Sim.Size = New System.Drawing.Size(90, 17)
        Me.Rdb_Sim.TabIndex = 7
        Me.Rdb_Sim.TabStop = True
        Me.Rdb_Sim.Text = "RadioButton1"
        Me.Rdb_Sim.UseVisualStyleBackColor = True
        '
        'Frm_Principal04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 336)
        Me.Controls.Add(Me.Grp_Pais)
        Me.Controls.Add(Me.Lbl_resultado)
        Me.Controls.Add(Me.Txt_Resultado)
        Me.Controls.Add(Me.Txt_idade)
        Me.Controls.Add(Me.Lbl_idade)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_Principal)
        Me.Name = "Frm_Principal04"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação Alô mundo"
        Me.Grp_Pais.ResumeLayout(False)
        Me.Grp_Pais.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Lbl_idade As Label
    Friend WithEvents Txt_idade As TextBox
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Lbl_resultado As Label
    Friend WithEvents Grp_Pais As GroupBox
    Friend WithEvents Rdb_Sim As RadioButton
    Friend WithEvents Rdb_Nao As RadioButton
End Class

