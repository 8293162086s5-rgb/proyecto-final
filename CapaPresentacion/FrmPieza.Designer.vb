<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPieza
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTitulo = New Panel()
        Me.lblTitulo = New Label()
        Me.pnlFormulario = New Panel()
        Me.lblNombre = New Label()
        Me.txtNombre = New TextBox()
        Me.lblDescripcion = New Label()
        Me.txtDescripcion = New TextBox()
        Me.lblEpoca = New Label()
        Me.txtEpoca = New TextBox()
        Me.lblMaterial = New Label()
        Me.txtMaterial = New TextBox()
        Me.lblEstadoConservacion = New Label()
        Me.cboEstadoConservacion = New ComboBox()
        Me.lblUbicacion = New Label()
        Me.txtUbicacion = New TextBox()
        Me.lblValor = New Label()
        Me.txtValor = New TextBox()
        Me.pnlBotones = New Panel()
        Me.btnNuevo = New Button()
        Me.btnGuardar = New Button()
        Me.btnEditar = New Button()
        Me.btnEliminar = New Button()
        Me.btnCancelar = New Button()
        Me.lblBuscar = New Label()
        Me.txtBuscar = New TextBox()
        Me.dgvPiezas = New DataGridView()
        Me.SuspendLayout()

        Dim labelFont As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim inputFont As New Font("Segoe UI", 10)
        Dim inputSize As New Size(220, 28)

        ' pnlTitulo
        Me.pnlTitulo.BackColor = Color.FromArgb(0, 131, 143)
        Me.pnlTitulo.Dock = DockStyle.Top
        Me.pnlTitulo.Height = 55
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)

        Me.lblTitulo.Text = "🏺  Gestión de Piezas"
        Me.lblTitulo.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White
        Me.lblTitulo.Location = New Point(15, 12)
        Me.lblTitulo.AutoSize = True

        ' pnlFormulario
        Me.pnlFormulario.Location = New Point(10, 65)
        Me.pnlFormulario.Size = New Size(500, 380)
        Me.pnlFormulario.BorderStyle = BorderStyle.FixedSingle
        Me.pnlFormulario.BackColor = Color.White

        ' Nombre
        Me.lblNombre.Text = "Nombre *" : Me.lblNombre.Font = labelFont : Me.lblNombre.Location = New Point(15, 15) : Me.lblNombre.AutoSize = True
        Me.txtNombre.Location = New Point(15, 35) : Me.txtNombre.Size = New Size(460, 28) : Me.txtNombre.Font = inputFont

        ' Descripción
        Me.lblDescripcion.Text = "Descripción" : Me.lblDescripcion.Font = labelFont : Me.lblDescripcion.Location = New Point(15, 80) : Me.lblDescripcion.AutoSize = True
        Me.txtDescripcion.Location = New Point(15, 100) : Me.txtDescripcion.Size = New Size(460, 50) : Me.txtDescripcion.Font = inputFont : Me.txtDescripcion.Multiline = True

        ' Época
        Me.lblEpoca.Text = "Época" : Me.lblEpoca.Font = labelFont : Me.lblEpoca.Location = New Point(15, 165) : Me.lblEpoca.AutoSize = True
        Me.txtEpoca.Location = New Point(15, 185) : Me.txtEpoca.Size = inputSize : Me.txtEpoca.Font = inputFont

        ' Material
        Me.lblMaterial.Text = "Material" : Me.lblMaterial.Font = labelFont : Me.lblMaterial.Location = New Point(255, 165) : Me.lblMaterial.AutoSize = True
        Me.txtMaterial.Location = New Point(255, 185) : Me.txtMaterial.Size = inputSize : Me.txtMaterial.Font = inputFont

        ' Estado Conservación
        Me.lblEstadoConservacion.Text = "Estado de Conservación *" : Me.lblEstadoConservacion.Font = labelFont : Me.lblEstadoConservacion.Location = New Point(15, 230) : Me.lblEstadoConservacion.AutoSize = True
        Me.cboEstadoConservacion.Location = New Point(15, 250) : Me.cboEstadoConservacion.Size = inputSize : Me.cboEstadoConservacion.Font = inputFont : Me.cboEstadoConservacion.DropDownStyle = ComboBoxStyle.DropDownList

        ' Ubicación
        Me.lblUbicacion.Text = "Ubicación" : Me.lblUbicacion.Font = labelFont : Me.lblUbicacion.Location = New Point(255, 230) : Me.lblUbicacion.AutoSize = True
        Me.txtUbicacion.Location = New Point(255, 250) : Me.txtUbicacion.Size = inputSize : Me.txtUbicacion.Font = inputFont

        ' Valor
        Me.lblValor.Text = "Valor Estimado (RD$)" : Me.lblValor.Font = labelFont : Me.lblValor.Location = New Point(15, 295) : Me.lblValor.AutoSize = True
        Me.txtValor.Location = New Point(15, 315) : Me.txtValor.Size = inputSize : Me.txtValor.Font = inputFont : Me.txtValor.Text = "0.00"

        Me.pnlFormulario.Controls.AddRange({Me.lblNombre, Me.txtNombre, Me.lblDescripcion, Me.txtDescripcion,
                                             Me.lblEpoca, Me.txtEpoca, Me.lblMaterial, Me.txtMaterial,
                                             Me.lblEstadoConservacion, Me.cboEstadoConservacion,
                                             Me.lblUbicacion, Me.txtUbicacion, Me.lblValor, Me.txtValor})

        ' pnlBotones
        Me.pnlBotones.Location = New Point(10, 455)
        Me.pnlBotones.Size = New Size(500, 50)

        Dim btnSize As New Size(90, 38)
        Dim btnFont As New Font("Segoe UI", 9, FontStyle.Bold)

        Me.btnNuevo.Size = btnSize : Me.btnNuevo.Location = New Point(0, 0) : Me.btnNuevo.Text = "➕  Nuevo"
        Me.btnNuevo.BackColor = Color.FromArgb(30, 136, 229) : Me.btnNuevo.ForeColor = Color.White
        Me.btnNuevo.FlatStyle = FlatStyle.Flat : Me.btnNuevo.FlatAppearance.BorderSize = 0 : Me.btnNuevo.Font = btnFont : Me.btnNuevo.Cursor = Cursors.Hand

        Me.btnGuardar.Size = btnSize : Me.btnGuardar.Location = New Point(100, 0) : Me.btnGuardar.Text = "💾  Guardar"
        Me.btnGuardar.BackColor = Color.FromArgb(67, 160, 71) : Me.btnGuardar.ForeColor = Color.White
        Me.btnGuardar.FlatStyle = FlatStyle.Flat : Me.btnGuardar.FlatAppearance.BorderSize = 0 : Me.btnGuardar.Font = btnFont : Me.btnGuardar.Cursor = Cursors.Hand

        Me.btnEditar.Size = btnSize : Me.btnEditar.Location = New Point(200, 0) : Me.btnEditar.Text = "✏️  Editar"
        Me.btnEditar.BackColor = Color.FromArgb(251, 140, 0) : Me.btnEditar.ForeColor = Color.White
        Me.btnEditar.FlatStyle = FlatStyle.Flat : Me.btnEditar.FlatAppearance.BorderSize = 0 : Me.btnEditar.Font = btnFont : Me.btnEditar.Cursor = Cursors.Hand

        Me.btnEliminar.Size = btnSize : Me.btnEliminar.Location = New Point(300, 0) : Me.btnEliminar.Text = "🗑  Eliminar"
        Me.btnEliminar.BackColor = Color.FromArgb(211, 47, 47) : Me.btnEliminar.ForeColor = Color.White
        Me.btnEliminar.FlatStyle = FlatStyle.Flat : Me.btnEliminar.FlatAppearance.BorderSize = 0 : Me.btnEliminar.Font = btnFont : Me.btnEliminar.Cursor = Cursors.Hand

        Me.btnCancelar.Size = btnSize : Me.btnCancelar.Location = New Point(400, 0) : Me.btnCancelar.Text = "❌  Cancelar"
        Me.btnCancelar.BackColor = Color.FromArgb(97, 97, 97) : Me.btnCancelar.ForeColor = Color.White
        Me.btnCancelar.FlatStyle = FlatStyle.Flat : Me.btnCancelar.FlatAppearance.BorderSize = 0 : Me.btnCancelar.Font = btnFont : Me.btnCancelar.Cursor = Cursors.Hand
        Me.btnCancelar.Visible = False

        Me.pnlBotones.Controls.AddRange({Me.btnNuevo, Me.btnGuardar, Me.btnEditar, Me.btnEliminar, Me.btnCancelar})

        ' Búsqueda
        Me.lblBuscar.Text = "🔍  Buscar:" : Me.lblBuscar.Font = labelFont : Me.lblBuscar.Location = New Point(520, 70) : Me.lblBuscar.AutoSize = True
        Me.txtBuscar.Location = New Point(520, 90) : Me.txtBuscar.Size = New Size(460, 28) : Me.txtBuscar.Font = inputFont

        ' DataGridView
        Me.dgvPiezas.Location = New Point(520, 125)
        Me.dgvPiezas.Size = New Size(460, 380)
        Me.dgvPiezas.AllowUserToAddRows = False
        Me.dgvPiezas.ReadOnly = True
        Me.dgvPiezas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvPiezas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPiezas.BackgroundColor = Color.White
        Me.dgvPiezas.BorderStyle = BorderStyle.None
        Me.dgvPiezas.RowHeadersVisible = False
        Me.dgvPiezas.Font = New Font("Segoe UI", 9)
        Me.dgvPiezas.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvPiezas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 131, 143)
        Me.dgvPiezas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvPiezas.EnableHeadersVisualStyles = False
        Me.dgvPiezas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 255, 255)

        ' FrmPieza
        Me.ClientSize = New Size(1000, 520)
        Me.Controls.AddRange({Me.pnlTitulo, Me.pnlFormulario, Me.pnlBotones, Me.lblBuscar, Me.txtBuscar, Me.dgvPiezas})
        Me.Text = "Gestión de Piezas"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlFormulario As Panel
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblEpoca As Label
    Friend WithEvents txtEpoca As TextBox
    Friend WithEvents lblMaterial As Label
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents lblEstadoConservacion As Label
    Friend WithEvents cboEstadoConservacion As ComboBox
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents lblValor As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents pnlBotones As Panel
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvPiezas As DataGridView

End Class
