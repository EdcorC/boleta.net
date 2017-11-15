Public Class boleta
    Private Sub btnaceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnaceptar.Click
        Dim ht As Integer
        'Se declara la variable para el ingreso de decimales
        Dim ph As Decimal
        ht = txthoras.Text
        ph = txtpagohora.Text
        txtsueldoneto.Text = ht * ph
    End Sub

    Private Sub btnsalir_Click(sender As System.Object, e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnlimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnlimpiar.Click

    End Sub
End Class