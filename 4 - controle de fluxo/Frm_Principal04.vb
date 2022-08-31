Public Class Frm_Principal04
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Lbl_NomeProjeto.Text = "4 - controle de fluxo"
        Btm_Principal.Text = "Checagem da permissão de entrada"
        Me.Text = "4 - controle de fluxo"

        'Inicializando dos componentes da aplicação

        Lbl_idade.Text = "idade"
        Lbl_resultado.Text = "Resultado"
        Grp_Pais.Text = "Acompanhado dos pais? "
        Rdb_Sim.Text = "Sim"
        Rdb_Nao.Text = "Não"





    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click
        Txt_Resultado.Text = ""

        Dim idade As Integer
        idade = Txt_idade.Text

        Dim acompanhadopais As String
        If Rdb_Sim.Checked Then
            acompanhadopais = "s"

        Else
            acompanhadopais = "n"

        End If


        Dim PodeEntrar As Boolean = (idade >= 18) Or (acompanhadopais = "s" And idade >= 16)
        Dim NaoPodeEntrar As Boolean = (acompanhadopais = "n" And idade >= 16) Or idade < 16

        Dim MensagemAdicional As String
        If acompanhadopais = "s" Then
            MensagemAdicional = " Esta acompanhado"
        Else
            MensagemAdicional = " Não esta acompanhado"
        End If


        If PodeEntrar Then
            Txt_Resultado.ForeColor = Color.Green
            Txt_Resultado.Text = "Pode entrar." + MensagemAdicional

        Else


            If NaoPodeEntrar Then
                Txt_Resultado.ForeColor = Color.Red
                Txt_Resultado.Text = "Não pode entrar." + MensagemAdicional


            End If

        End If





    End Sub


End Class
