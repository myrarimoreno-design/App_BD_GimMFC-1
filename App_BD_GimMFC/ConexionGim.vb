Module ConexionGim
    'La variable conexion es la que permite conectarnos a nuestro sql 

    Public conexion As New SqlClient.SqlConnection("data source=DESKTOP-P1KRNOI\SQLEXPRESS; initial catalog =Gimnasio; integrated security=SSPI; persist security info = false; trusted_connection = yes;")

    'Nos permite ejecutar los comandos que tiene que ver con los procedimientos  almacenados de sql 

    Public cmd As SqlClient.SqlCommand

    'Permite leer los datos 

    Public sqlread As SqlClient.SqlDataReader

    Public Query As String
End Module
