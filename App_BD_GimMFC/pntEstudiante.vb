Imports System.Data.SqlClient

Public Class pntEstudiante
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    ' este botón sirve para buscar un estudiante por su id
    ' al encontrarlo, muestra sus datos en un mensaje

    Private Sub btnBuscarEstudiante_Click(sender As Object, e As EventArgs)
        ' crear conexión a la base de datos gimnasio
        Dim conexion As New SqlConnection("Data Source=DESKTOP-M9E0OMK\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True")

        ' consulta sql con parámetro para evitar inyección
        Dim Query As String = "SELECT IdEstudiante, Nombre_Estudiante, Direccion, FechNac, Contacto, Fecha_Ingreso
                           FROM Estudiante
                           WHERE IdEstudiante=@id"

        Dim cmd As New SqlClient.SqlCommand(Query, conexion)
        cmd.Parameters.AddWithValue("@id", txtIdEstudiante.Text)

        Try
            conexion.Open() ' abrir conexión
            Dim sqlread As SqlDataReader = cmd.ExecuteReader()

            If sqlread.HasRows Then
                While sqlread.Read()
                    ' armar mensaje con los datos del estudiante
                    Dim mensaje As String = "id: " & sqlread("IdEstudiante").ToString() & vbCrLf &
                                        "nombre: " & sqlread("Nombre_Estudiante").ToString() & vbCrLf &
                                        "dirección: " & sqlread("Direccion").ToString() & vbCrLf &
                                        "fecha nacimiento: " & Convert.ToDateTime(sqlread("FechNac")).ToShortDateString() & vbCrLf &
                                        "contacto: " & sqlread("Contacto").ToString() & vbCrLf &
                                        "fecha ingreso: " & Convert.ToDateTime(sqlread("Fecha_Ingreso")).ToShortDateString()

                    MsgBox(mensaje, MsgBoxStyle.Information, "datos del estudiante")
                End While
            Else
                MsgBox("no se encontró estudiante con ese id.", MsgBoxStyle.Exclamation, "aviso")
                txtIdEstudiante.Focus() ' regresar el cursor a la caja de id
            End If

            sqlread.Close()
        Catch ex As Exception
            MsgBox("error al buscar estudiante: " & ex.Message, MsgBoxStyle.Critical, "error")
        Finally
            conexion.Close() ' cerrar conexión
        End Try
    End Sub


    Private Sub btnRegistrarEstudiante_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtIdEstudiante_TextChanged(sender As Object, e As EventArgs) Handles txtIdEstudiante.TextChanged

    End Sub

    Private Sub btnRegresarEst_Click(sender As Object, e As EventArgs) Handles btnRegresarEst.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarEstudiante_Click_1(sender As Object, e As EventArgs) Handles btnBuscarEstudiante.Click



        ' crear conexión a la base de datos gimnasio
        Dim conexion As New SqlConnection("Data Source=DESKTOP-M9E0OMK\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True")

        ' consulta sql con parámetro para evitar inyección
        Dim Query As String = "SELECT IdEstudiante, Nombre_Estudiante, Direccion, FechNac, Contacto, Fecha_Ingreso
                           FROM Estudiante
                           WHERE IdEstudiante=@id"

        Dim cmd As New SqlClient.SqlCommand(Query, conexion)
        cmd.Parameters.AddWithValue("@id", txtIdEstudiante.Text)

        Try
            conexion.Open() ' abrir conexión
            Dim sqlread As SqlDataReader = cmd.ExecuteReader()

            If sqlread.HasRows Then
                While sqlread.Read()
                    ' asignar los valores a los cuadros de texto y controles
                    txtIdEstudiante.Text = sqlread("IdEstudiante").ToString()
                    txtNombreEstudiantes.Text = sqlread("Nombre_Estudiante").ToString()
                    txtDireccion.Text = sqlread("Direccion").ToString()
                    dtpFechaNac.Value = Convert.ToDateTime(sqlread("FechNac"))
                    txtContacto.Text = sqlread("Contacto").ToString()
                    dtpFechaIngreso.Value = Convert.ToDateTime(sqlread("Fecha_Ingreso"))
                End While
            Else
                MsgBox("no se encontró estudiante con ese id.", MsgBoxStyle.Exclamation, "aviso")
                txtIdEstudiante.Focus() ' regresar el cursor a la caja de id
            End If

            sqlread.Close()
        Catch ex As Exception
            MsgBox("error al buscar estudiante: " & ex.Message, MsgBoxStyle.Critical, "error")
        Finally
            conexion.Close() ' cerrar conexión
        End Try
    End Sub

    Private Sub btnRegistrarEstudiante_Click_1(sender As Object, e As EventArgs) Handles btnRegistrarEstudiante.Click
        ' 1. Validar que todos los campos estén llenos
        If String.IsNullOrWhiteSpace(txtNombreEstudiantes.Text) OrElse
       String.IsNullOrWhiteSpace(txtDireccion.Text) OrElse
       String.IsNullOrWhiteSpace(txtContacto.Text) OrElse
       String.IsNullOrWhiteSpace(txtIdEmpleado.Text) Then

            MsgBox("Por favor, complete todos los campos antes de registrar.", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        ' 2. Crear conexión
        Dim conexion As New SqlConnection("Data Source=DESKTOP-P1KRNOI\SQLEXPRESS;Initial Catalog=GimnasioBD;Integrated Security=True")

        Try
            conexion.Open()

            ' 3. Verificar si ya existe un estudiante con el mismo nombre y fecha de nacimiento
            Dim QueryVerificar As String = "SELECT COUNT(*) FROM Estudiante WHERE Nombre_Estudiante=@nombre AND FechNac=@fechNac"
            Dim cmdVerificar As New SqlClient.SqlCommand(QueryVerificar, conexion)
            cmdVerificar.Parameters.AddWithValue("@nombre", txtNombreEstudiantes.Text)
            cmdVerificar.Parameters.AddWithValue("@fechNac", dtpFechaNac.Value)

            Dim resultado As Object = cmdVerificar.ExecuteScalar()
            Dim existe As Integer = If(IsDBNull(resultado), 0, Convert.ToInt32(resultado))

            If existe > 0 Then
                ' 4. Ya existe un estudiante con ese nombre y fecha de nacimiento
                MsgBox("El estudiante ya existe en la base de datos.", MsgBoxStyle.Critical, "Duplicado")
            Else
                ' 5. Obtener el próximo IdEstudiante manualmente
                Dim QueryMaxId As String = "SELECT ISNULL(MAX(IdEstudiante),0) + 1 FROM Estudiante"
                Dim cmdMaxId As New SqlClient.SqlCommand(QueryMaxId, conexion)
                Dim nuevoId As Integer = Convert.ToInt32(cmdMaxId.ExecuteScalar())

                ' 6. Insertar nuevo estudiante con el Id calculado
                Dim QueryInsertar As String = "INSERT INTO Estudiante (IdEstudiante, Nombre_Estudiante, Direccion, FechNac, Contacto, Fecha_Ingreso, IdEmpleado)
                                           VALUES (@idEstudiante, @nombre, @direccion, @fechNac, @contacto, @fechaIngreso, @idEmpleado)"

                Dim cmdInsertar As New SqlClient.SqlCommand(QueryInsertar, conexion)
                cmdInsertar.Parameters.AddWithValue("@idEstudiante", nuevoId)
                cmdInsertar.Parameters.AddWithValue("@nombre", txtNombreEstudiantes.Text)
                cmdInsertar.Parameters.AddWithValue("@direccion", txtDireccion.Text)
                cmdInsertar.Parameters.AddWithValue("@fechNac", dtpFechaNac.Value)
                cmdInsertar.Parameters.AddWithValue("@contacto", txtContacto.Text)
                cmdInsertar.Parameters.AddWithValue("@fechaIngreso", dtpFechaIngreso.Value)
                cmdInsertar.Parameters.AddWithValue("@idEmpleado", Convert.ToInt32(txtIdEmpleado.Text))

                cmdInsertar.ExecuteNonQuery()

                ' 7. Mensaje de éxito con el ID y el nombre
                MsgBox("Estudiante registrado correctamente." & vbCrLf &
                   "ID asignado: " & nuevoId & vbCrLf &
                   "Nombre: " & txtNombreEstudiantes.Text,
                   MsgBoxStyle.Information, "Éxito")
            End If

        Catch ex As Exception
            ' 8. Capturar errores
            MsgBox("Error al registrar estudiante: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            conexion.Close()

            ' 9. Limpiar todos los campos siempre
            txtNombreEstudiantes.Clear()
            txtDireccion.Clear()
            txtContacto.Clear()
            txtIdEmpleado.Clear()
            txtIdEstudiante.Clear()
            dtpFechaNac.Value = DateTime.Now
            dtpFechaIngreso.Value = DateTime.Now
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNombreEstudiantes.TextChanged

    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    End Sub

    Private Sub dtpFechaNac_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaNac.ValueChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtIdEmpleado.TextChanged

    End Sub

    Private Sub dtpFechaIngreso_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaIngreso.ValueChanged

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        ' Validar que se haya buscado un estudiante primero
        If String.IsNullOrWhiteSpace(txtIdEstudiante.Text) Then
            MsgBox("Primero busque un estudiante por su ID antes de actualizar.", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        ' Validar que los campos estén llenos
        If String.IsNullOrWhiteSpace(txtNombreEstudiantes.Text) OrElse
           String.IsNullOrWhiteSpace(txtDireccion.Text) OrElse
           String.IsNullOrWhiteSpace(txtContacto.Text) OrElse
           String.IsNullOrWhiteSpace(txtIdEmpleado.Text) Then

            MsgBox("Por favor, complete todos los campos antes de actualizar.", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        Dim conexion As New SqlConnection("Data Source=DESKTOP-P1KRNOI\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True")

        Try
            conexion.Open()

            ' Consulta SQL para actualizar los datos del estudiante
            Dim QueryActualizar As String = "UPDATE Estudiante 
                                         SET Nombre_Estudiante=@nombre,
                                             Direccion=@direccion,
                                             FechNac=@fechNac,
                                             Contacto=@contacto,
                                             Fecha_Ingreso=@fechaIngreso,
                                             IdEmpleado=@idEmpleado
                                         WHERE IdEstudiante=@idEst"

            Dim cmdActualizar As New SqlClient.SqlCommand(QueryActualizar, conexion)
            cmdActualizar.Parameters.AddWithValue("@nombre", txtNombreEstudiantes.Text)
            cmdActualizar.Parameters.AddWithValue("@direccion", txtDireccion.Text)
            cmdActualizar.Parameters.AddWithValue("@fechNac", dtpFechaNac.Value)
            cmdActualizar.Parameters.AddWithValue("@contacto", txtContacto.Text)
            cmdActualizar.Parameters.AddWithValue("@fechaIngreso", dtpFechaIngreso.Value)
            cmdActualizar.Parameters.AddWithValue("@idEmpleado", Convert.ToInt32(txtIdEmpleado.Text))
            cmdActualizar.Parameters.AddWithValue("@idEst", Convert.ToInt32(txtIdEstudiante.Text))

            Dim filasAfectadas As Integer = cmdActualizar.ExecuteNonQuery()

            If filasAfectadas > 0 Then
                MsgBox("Datos del estudiante actualizados correctamente.", MsgBoxStyle.Information, "Éxito")
            Else
                MsgBox("No se encontró el estudiante para actualizar.", MsgBoxStyle.Exclamation, "Aviso")
            End If

        Catch ex As Exception
            MsgBox("Error al actualizar estudiante: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            conexion.Close()

            ' Limpiar todos los campos siempre
            txtNombreEstudiantes.Clear()
            txtDireccion.Clear()
            txtContacto.Clear()
            txtIdEmpleado.Clear()
            txtIdEstudiante.Clear()
            dtpFechaNac.Value = DateTime.Now
            dtpFechaIngreso.Value = DateTime.Now
        End Try
    End Sub
End Class