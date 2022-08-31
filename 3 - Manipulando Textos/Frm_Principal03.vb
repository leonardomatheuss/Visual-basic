Public Class Frm_Principal03

    Dim ListaCurso As String


    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Lbl_NomeProjeto.Text = "3 - Manipulando Textos"
        Btm_Principal.Text = "Clique para ver os resultados"
        Me.Text = "3 - Manipulando Textos"
        Btm_Char.Text = "Clique para obeter o char"
        Lbl_Curso.Text = "Digite o seu curso preferido"
        Btm_Adicionar.Text = "Adicione a sua lista"
        Btm_MostraLista.Text = "Mostra a lista atual"
        Btm_GuardarVariaveis.Text = "Clique aqui"

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click
        Dim Primeiraletra As Char = "a"
        MsgBox("O caracter da variável Primeiraletra é " + Primeiraletra)

        Dim segundaletra As Char = Chr(65)
        MsgBox("O caracter número 65 é " + segundaletra)

        Dim Numerochar As Integer
        Numerochar = 65

        Dim terceiraletra As Char = Chr(Numerochar)

        Numerochar = Numerochar + 1

        Dim quartaletra As Char = Chr(Numerochar)
        MsgBox("O caracter número 65 é " + terceiraletra + " e o 66 é " + quartaletra)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btm_Char.Click

        Dim Valorchar As Integer = Val(Txt_Numero_Char.Text)
        Dim quintaletra As Char = Chr(Valorchar)

        MsgBox("O caracter para o número " + Valorchar.ToString + " é " + quintaletra)

    End Sub

    Private Sub Txt_Numero_Char_TextChanged(sender As Object, e As EventArgs) Handles Txt_Numero_Char.TextChanged

    End Sub

    Private Sub Btm_Adicionar_Click(sender As Object, e As EventArgs) Handles Btm_Adicionar.Click
        Dim CursoDigitado As String = Txt_Curso.Text
        ListaCurso = ListaCurso + CursoDigitado + vbCrLf
        Txt_Lista.Text = ListaCurso




    End Sub

    Private Sub Btm_MostraLista_Click(sender As Object, e As EventArgs) Handles Btm_MostraLista.Click

        MsgBox(ListaCurso)
    End Sub

    Private Sub Btm_GuardarVariaveis_Click(sender As Object, e As EventArgs) Handles Btm_GuardarVariaveis.Click

        Dim idade As Integer = 32
        Dim idadegustavo As Integer

        idadegustavo = idade

        MsgBox("idade é igual a " + idade.ToString + " enquanto a idadegustavo é " + idadegustavo.ToString)

        idade = 20

        MsgBox("Idade é igual a " + idade.ToString + " enquanto a idadegustavo é " + idadegustavo.ToString)


    End Sub
End Class
