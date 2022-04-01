Imports System.Data
Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class HomeController



    Inherits System.Web.Mvc.Controller

    Public Function Index() As ActionResult
        Dim customers As List(Of clsCustomerModel) = New List(Of clsCustomerModel)()
        Dim constr As String = ConfigurationManager.ConnectionStrings("mysqlDB").ConnectionString

        Using con As MySqlConnection = New MySqlConnection(constr)
            Dim query As String = "SELECT user_id,user_name FROM tbl_dashboard "

            Using cmd As MySqlCommand = New MySqlCommand(query)
                cmd.Connection = con
                con.Open()

                Using sdr As MySqlDataReader = cmd.ExecuteReader()

                    While sdr.Read()
                        customers.Add(New clsCustomerModel With {
                    .UserID = sdr(Replace("user_id", "'", "\'")).ToString(),
                    .UserName = sdr(Replace("user_name", "'", "\'")).ToString()
                })
                    End While
                End Using

                con.Close()
            End Using
        End Using

        Return View(customers)
    End Function




End Class
