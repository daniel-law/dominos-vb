<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.staffWelcomeDetails = New System.Windows.Forms.Label()
        Me.ordersPlaced = New System.Windows.Forms.Label()
        Me.ordersDataGridView = New System.Windows.Forms.DataGridView()
        Me.totalTakings = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usersDataGridView = New System.Windows.Forms.DataGridView()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Postcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserReference = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pizzas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Drinks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sides = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dips = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ordersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'staffWelcomeDetails
        '
        Me.staffWelcomeDetails.AutoSize = True
        Me.staffWelcomeDetails.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffWelcomeDetails.Location = New System.Drawing.Point(20, 19)
        Me.staffWelcomeDetails.Name = "staffWelcomeDetails"
        Me.staffWelcomeDetails.Size = New System.Drawing.Size(638, 29)
        Me.staffWelcomeDetails.TabIndex = 20
        Me.staffWelcomeDetails.Text = "Welcome to the Dominos system management screen, {user}."
        '
        'ordersPlaced
        '
        Me.ordersPlaced.AutoSize = True
        Me.ordersPlaced.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ordersPlaced.Location = New System.Drawing.Point(22, 77)
        Me.ordersPlaced.Name = "ordersPlaced"
        Me.ordersPlaced.Size = New System.Drawing.Size(317, 29)
        Me.ordersPlaced.TabIndex = 50
        Me.ordersPlaced.Text = "Orders Placed ({value} in total)"
        '
        'ordersDataGridView
        '
        Me.ordersDataGridView.AllowUserToAddRows = False
        Me.ordersDataGridView.AllowUserToDeleteRows = False
        Me.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ordersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserReference, Me.Pizzas, Me.Drinks, Me.Sides, Me.Dips, Me.TotalPrice})
        Me.ordersDataGridView.Location = New System.Drawing.Point(27, 127)
        Me.ordersDataGridView.Name = "ordersDataGridView"
        Me.ordersDataGridView.ReadOnly = True
        Me.ordersDataGridView.Size = New System.Drawing.Size(1301, 188)
        Me.ordersDataGridView.TabIndex = 51
        '
        'totalTakings
        '
        Me.totalTakings.AutoSize = True
        Me.totalTakings.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalTakings.Location = New System.Drawing.Point(1107, 32)
        Me.totalTakings.Name = "totalTakings"
        Me.totalTakings.Size = New System.Drawing.Size(221, 29)
        Me.totalTakings.TabIndex = 52
        Me.totalTakings.Text = "Total Takings: {value}"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 29)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Users in the System"
        '
        'usersDataGridView
        '
        Me.usersDataGridView.AllowUserToAddRows = False
        Me.usersDataGridView.AllowUserToDeleteRows = False
        Me.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.usersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserID, Me.CustomerName, Me.Email, Me.Address, Me.Postcode, Me.PhoneNo})
        Me.usersDataGridView.Location = New System.Drawing.Point(27, 403)
        Me.usersDataGridView.Name = "usersDataGridView"
        Me.usersDataGridView.ReadOnly = True
        Me.usersDataGridView.Size = New System.Drawing.Size(1054, 197)
        Me.usersDataGridView.TabIndex = 54
        '
        'UserID
        '
        Me.UserID.HeaderText = "User ID"
        Me.UserID.Name = "UserID"
        Me.UserID.ReadOnly = True
        Me.UserID.Width = 50
        '
        'CustomerName
        '
        Me.CustomerName.HeaderText = "Customer Name"
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.ReadOnly = True
        Me.CustomerName.Width = 200
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 300
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 250
        '
        'Postcode
        '
        Me.Postcode.HeaderText = "Postcode"
        Me.Postcode.Name = "Postcode"
        Me.Postcode.ReadOnly = True
        Me.Postcode.Width = 60
        '
        'PhoneNo
        '
        Me.PhoneNo.HeaderText = "Phone Number"
        Me.PhoneNo.Name = "PhoneNo"
        Me.PhoneNo.ReadOnly = True
        Me.PhoneNo.Width = 150
        '
        'UserReference
        '
        Me.UserReference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.UserReference.HeaderText = "User ID"
        Me.UserReference.Name = "UserReference"
        Me.UserReference.ReadOnly = True
        Me.UserReference.Width = 40
        '
        'Pizzas
        '
        Me.Pizzas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Pizzas.HeaderText = "Pizza(s) Requested"
        Me.Pizzas.Name = "Pizzas"
        Me.Pizzas.ReadOnly = True
        Me.Pizzas.Width = 113
        '
        'Drinks
        '
        Me.Drinks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Drinks.HeaderText = "Drinks(s) Requested"
        Me.Drinks.Name = "Drinks"
        Me.Drinks.ReadOnly = True
        Me.Drinks.Width = 117
        '
        'Sides
        '
        Me.Sides.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Sides.HeaderText = "Side(s) Requested"
        Me.Sides.Name = "Sides"
        Me.Sides.ReadOnly = True
        Me.Sides.Width = 109
        '
        'Dips
        '
        Me.Dips.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Dips.HeaderText = "Dip(s) Requested"
        Me.Dips.Name = "Dips"
        Me.Dips.ReadOnly = True
        Me.Dips.Width = 105
        '
        'TotalPrice
        '
        Me.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TotalPrice.HeaderText = "TOTAL"
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        Me.TotalPrice.Width = 67
        '
        'StaffView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 626)
        Me.Controls.Add(Me.usersDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.totalTakings)
        Me.Controls.Add(Me.ordersDataGridView)
        Me.Controls.Add(Me.ordersPlaced)
        Me.Controls.Add(Me.staffWelcomeDetails)
        Me.Name = "StaffView"
        Me.Text = "StaffView"
        CType(Me.ordersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents staffWelcomeDetails As Label
    Friend WithEvents ordersPlaced As Label
    Friend WithEvents ordersDataGridView As DataGridView
    Friend WithEvents totalTakings As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents usersDataGridView As DataGridView
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Postcode As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNo As DataGridViewTextBoxColumn
    Friend WithEvents UserReference As DataGridViewTextBoxColumn
    Friend WithEvents Pizzas As DataGridViewTextBoxColumn
    Friend WithEvents Drinks As DataGridViewTextBoxColumn
    Friend WithEvents Sides As DataGridViewTextBoxColumn
    Friend WithEvents Dips As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
End Class
