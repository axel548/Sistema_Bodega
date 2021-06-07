Imports System.Threading

Public Class Carga

#Region "Variables"
    Dim err As String
    Public Func As New DAtos
#End Region


#Region "Load"
    Private Sub Carga_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Bf_Prbar.Value = 0
            Me.Opacity = 0
            Timer1.Start()
            CargaBD()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Timers"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Bf_Prbar.Value += 1
            If Me.Opacity < 1 Then
                Me.Opacity += 0.5
            End If
            If Bf_Prbar.Value = 100 Then
                Timer1.Stop()
                Timer2.Start()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.1
        Dim frm As New Login
        Try
            If My.Settings.cargaBd = True And My.Settings.cargaRed = True And My.Settings.cargaFiles = True And My.Settings.cargaInternet = True Then
                If Me.Opacity = 0 Then
                    Timer2.Stop()
                    Bf_Animation.Show(pctb_logo)
                    frm.Show()
                    Hide()
                End If
            ElseIf my.Settings.cargaBd = False Then
                If Me.Opacity = 0 Then
                    Timer2.Stop()
                    Bf_Animation.Show(pctb_logo)
                    If MessageBox.Show("La conexión a Base de datos no se pudo realizar." & vbNewLine & " Reinicie el programa o consulte a soporte Técnico", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                        Application.Exit()
                    End If
                End If
            ElseIf my.Settings.cargaRed = False Or my.Settings.cargaInternet Then
                If Me.Opacity = 0 Then
                    Timer2.Stop()
                    If MessageBox.Show("La conexión a Internet y/o Red no se realizó" & vbNewLine & "Verifique su conexión", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                        Bf_Animation.Show(pctb_logo)
                        frm.Show()
                        Hide()
                    End If
                End If
            End If
        Catch ex As Exception
            frm.Dispose()
        End Try
    End Sub
#End Region
    '--------------------------------------
#Region "Verificación de conexión a BD"

    Private Sub CargaBD()
        Try
            tmrBD.Enabled = True
            tmrBD.Start()
            'My.Settings.conexionglobal = "Data Source=.;Initial Catalog=Bodega;Integrated Security=True"
            'My.Settings.Save()
            'My.Settings.Reload()
            'Lbl_Cargando.Text = "Preparando 1/3"
            'Lbl_Descriptivo.Text = "Inicializando conexiones"
            Thread.Sleep(5000)
            If Func.Conec() = True Then
                Lbl_Cargando.Text = "Preparando..."
                Lbl_Descriptivo.Text = "Conexion hacia el servidor establecida"
                My.Settings.cargaBd = True
            Else
                Lbl_Cargando.Text = "Preparando..."
                Lbl_Descriptivo.Text = "Conexion hacia el servidor no establecida"
                My.Settings.ErrorBD = "1"
                My.Settings.Save()
                My.Settings.Reload()
                My.Settings.cargaBd = False
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
            tmrBD.Stop()
        End Try
    End Sub
    Private Sub TmrBD_Tick(sender As Object, e As EventArgs) Handles tmrBD.Tick
        Try
            Cargawireless()
            tmrBD.Stop()
            tmrBD.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
    '--------------------------------------------
#Region "Verificación de Conexión a Internet"

    Private Sub Cargawireless()
        Try
            tmrInternet.Enabled = True
            tmrInternet.Start()

            If err = "1" Then
                Lbl_Cargando.Text = "Preparando..."
            Else
                Lbl_Cargando.Text = "Preparando..."
                Lbl_Descriptivo.Text = "Comprobando conexión a Internet"
                If My.Computer.Network.IsAvailable Then
                    My.Settings.cargaRed = True
                    If My.Computer.Network.Ping("www.google.com", 1000) = True Then
                        My.Settings.cargaInternet = True
                        Lbl_Descriptivo.Text = "Conexión a Internet Establecida"
                    Else
                        Lbl_Descriptivo.Text = "Conexión a Internet Fallida"
                    End If
                Else
                    Lbl_Descriptivo.Text = "Conexión no Establecida"
                    My.Settings.cargaInternet = False
                    My.Settings.cargaRed = False
                End If
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
            tmrInternet.Stop()
        End Try
    End Sub
    Private Sub TmrInternet_Tick(sender As Object, e As EventArgs) Handles tmrInternet.Tick
        Try
            CargaArchivos()
            tmrInternet.Stop()
            tmrInternet.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
    '------------------------------------------
#Region "Verificación de Carga de Archivos"

    Private Sub CargaArchivos()
        Try
            tmrArchivos.Enabled = True
            tmrArchivos.Start()
            My.Settings.cargaFiles = True
            Lbl_Cargando.Text = "Preparando..."
            Lbl_Descriptivo.Location = New Point(35, 161)
            Lbl_Descriptivo.Text = "Verificando sistema de archivos desactivada"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TmrArchivos_Tick(sender As Object, e As EventArgs) Handles tmrArchivos.Tick
        Try
            tmrArchivos.Stop()
            tmrArchivos.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
    '--------------------------
End Class