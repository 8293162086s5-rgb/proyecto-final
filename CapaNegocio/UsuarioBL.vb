Imports CapaEntidades
Imports CapaDatos

Namespace CapaNegocio

    Public Class UsuarioBL
        Private dao As New UsuarioDAO()

        Public Function Login(nombreUsuario As String, contrasena As String) As Usuario
            If String.IsNullOrWhiteSpace(nombreUsuario) Then Throw New Exception("El usuario es obligatorio.")
            If String.IsNullOrWhiteSpace(contrasena) Then Throw New Exception("La contraseña es obligatoria.")
            Return dao.Login(nombreUsuario, contrasena)
        End Function

    End Class

End Namespace
