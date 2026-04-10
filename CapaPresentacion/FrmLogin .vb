Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmLogin

    Dim bl As New UsuarioBL()
    Dim intentos As Integer = 0
    Dim maxIntentos As Integer = 3

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Seleccionar "Administrador" por defecto
        rbAdmin.Checked = True
        txtUsuario.Focus()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ValidarLogin()
    End Sub

    Private Sub txtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then ValidarLogin()
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then txtContrasena.Focus()
    End Sub

    Private Sub ValidarLogin()
        Try
            Dim usuario = bl.Login(txtUsuario.Text.Trim(), txtContrasena.Text.Trim())

            If usuario IsNot Nothing Then
                ' Verificar que el rol coincida con la opción seleccionada
                Dim rolSeleccionado As String = If(rbAdmin.Checked, "Admin", "Empleado")

                If usuario.Rol.ToLower() <> rolSeleccionado.ToLower() Then
                    intentos += 1
                    Dim restantes As Integer = maxIntentos - intentos
                    If intentos >= maxIntentos Then
                        MessageBox.Show("Ha superado el número máximo de intentos." & Environment.NewLine &
                                        "El sistema se cerrará.", "Acceso bloqueado",
                                        MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Application.Exit()
                    Else
                        MessageBox.Show($"Este usuario no tiene acceso como {rolSeleccionado}." & Environment.NewLine &
                                        $"Le quedan {restantes} intento(s).", "Acceso denegado",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtContrasena.Clear()
                        txtContrasena.Focus()
                        ActualizarIntentos()
                    End If
                    Return
                End If

                ' Abrir menú pasando el rol del usuario
                Dim menu As New FrmMenu(usuario.Rol, usuario.NombreCompleto)
                Me.Hide()
                menu.ShowDialog()
                Me.Close()
            Else
                intentos += 1
                Dim restantes As Integer = maxIntentos - intentos

                If intentos >= maxIntentos Then
                    MessageBox.Show("Ha superado el número máximo de intentos." & Environment.NewLine &
                                    "El sistema se cerrará.", "Acceso bloqueado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Application.Exit()
                Else
                    MessageBox.Show("Usuario o contraseña incorrectos." & Environment.NewLine &
                                    $"Le quedan {restantes} intento(s).", "Acceso denegado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtContrasena.Clear()
                    txtContrasena.Focus()
                    ActualizarIntentos()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ActualizarIntentos()
        lblIntentos.Text = $"Intentos fallidos: {intentos} / {maxIntentos}"
        lblIntentos.ForeColor = If(intentos = 2, Color.Red, Color.OrangeRed)
        lblIntentos.Visible = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Application.Exit()
    End Sub

End Class
