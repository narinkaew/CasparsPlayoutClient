﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not IsNothing(sc.getTicker) Then RemoveHandler sc.getTicker.frameTick, AddressOf onTick
        sc.close()
        logger.close()
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.layoutPlaylistSplit = New System.Windows.Forms.SplitContainer()
        Me.layoutUpDownSplit = New System.Windows.Forms.SplitContainer()
        Me.layoutCgLib = New System.Windows.Forms.SplitContainer()
        Me.lsvPlayingMedia = New System.Windows.Forms.ListView()
        Me.layoutButtonsPanel = New System.Windows.Forms.Panel()
        Me.layoutButtonsFlow = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmbConnect = New System.Windows.Forms.Button()
        Me.cmbDisconnect = New System.Windows.Forms.Button()
        Me.cmdClearAll = New System.Windows.Forms.Button()
        Me.cbbClearChannel = New System.Windows.Forms.ComboBox()
        Me.cmbClearChannel = New System.Windows.Forms.Button()
        Me.nudLayerClear = New System.Windows.Forms.NumericUpDown()
        Me.cmbClearLayer = New System.Windows.Forms.Button()
        Me.layoutAdressPanel = New System.Windows.Forms.Panel()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        CType(Me.layoutPlaylistSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layoutPlaylistSplit.Panel2.SuspendLayout()
        Me.layoutPlaylistSplit.SuspendLayout()
        CType(Me.layoutUpDownSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layoutUpDownSplit.Panel1.SuspendLayout()
        Me.layoutUpDownSplit.Panel2.SuspendLayout()
        Me.layoutUpDownSplit.SuspendLayout()
        CType(Me.layoutCgLib, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layoutCgLib.Panel1.SuspendLayout()
        Me.layoutCgLib.SuspendLayout()
        Me.layoutButtonsPanel.SuspendLayout()
        Me.layoutButtonsFlow.SuspendLayout()
        CType(Me.nudLayerClear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layoutAdressPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'layoutPlaylistSplit
        '
        Me.layoutPlaylistSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.layoutPlaylistSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layoutPlaylistSplit.Location = New System.Drawing.Point(0, 0)
        Me.layoutPlaylistSplit.Name = "layoutPlaylistSplit"
        Me.layoutPlaylistSplit.Panel1MinSize = 260
        '
        'layoutPlaylistSplit.Panel2
        '
        Me.layoutPlaylistSplit.Panel2.Controls.Add(Me.layoutUpDownSplit)
        Me.layoutPlaylistSplit.Size = New System.Drawing.Size(926, 562)
        Me.layoutPlaylistSplit.SplitterDistance = 305
        Me.layoutPlaylistSplit.TabIndex = 0
        '
        'layoutUpDownSplit
        '
        Me.layoutUpDownSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.layoutUpDownSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layoutUpDownSplit.Location = New System.Drawing.Point(0, 0)
        Me.layoutUpDownSplit.Name = "layoutUpDownSplit"
        Me.layoutUpDownSplit.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'layoutUpDownSplit.Panel1
        '
        Me.layoutUpDownSplit.Panel1.Controls.Add(Me.layoutCgLib)
        '
        'layoutUpDownSplit.Panel2
        '
        Me.layoutUpDownSplit.Panel2.Controls.Add(Me.layoutButtonsPanel)
        Me.layoutUpDownSplit.Panel2.Controls.Add(Me.layoutAdressPanel)
        Me.layoutUpDownSplit.Panel2MinSize = 75
        Me.layoutUpDownSplit.Size = New System.Drawing.Size(617, 562)
        Me.layoutUpDownSplit.SplitterDistance = 469
        Me.layoutUpDownSplit.TabIndex = 0
        '
        'layoutCgLib
        '
        Me.layoutCgLib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.layoutCgLib.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layoutCgLib.Location = New System.Drawing.Point(0, 0)
        Me.layoutCgLib.Name = "layoutCgLib"
        '
        'layoutCgLib.Panel1
        '
        Me.layoutCgLib.Panel1.Controls.Add(Me.lsvPlayingMedia)
        Me.layoutCgLib.Size = New System.Drawing.Size(617, 469)
        Me.layoutCgLib.SplitterDistance = 542
        Me.layoutCgLib.TabIndex = 0
        '
        'lsvPlayingMedia
        '
        Me.lsvPlayingMedia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvPlayingMedia.GridLines = True
        Me.lsvPlayingMedia.Location = New System.Drawing.Point(0, 0)
        Me.lsvPlayingMedia.Name = "lsvPlayingMedia"
        Me.lsvPlayingMedia.Size = New System.Drawing.Size(540, 467)
        Me.lsvPlayingMedia.TabIndex = 1
        Me.lsvPlayingMedia.UseCompatibleStateImageBehavior = False
        '
        'layoutButtonsPanel
        '
        Me.layoutButtonsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.layoutButtonsPanel.AutoScroll = True
        Me.layoutButtonsPanel.Controls.Add(Me.layoutButtonsFlow)
        Me.layoutButtonsPanel.Location = New System.Drawing.Point(3, 48)
        Me.layoutButtonsPanel.Name = "layoutButtonsPanel"
        Me.layoutButtonsPanel.Size = New System.Drawing.Size(609, 36)
        Me.layoutButtonsPanel.TabIndex = 2
        '
        'layoutButtonsFlow
        '
        Me.layoutButtonsFlow.Controls.Add(Me.cmbConnect)
        Me.layoutButtonsFlow.Controls.Add(Me.cmbDisconnect)
        Me.layoutButtonsFlow.Controls.Add(Me.cmdClearAll)
        Me.layoutButtonsFlow.Controls.Add(Me.cbbClearChannel)
        Me.layoutButtonsFlow.Controls.Add(Me.cmbClearChannel)
        Me.layoutButtonsFlow.Controls.Add(Me.nudLayerClear)
        Me.layoutButtonsFlow.Controls.Add(Me.cmbClearLayer)
        Me.layoutButtonsFlow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layoutButtonsFlow.Location = New System.Drawing.Point(0, 0)
        Me.layoutButtonsFlow.MinimumSize = New System.Drawing.Size(0, 30)
        Me.layoutButtonsFlow.Name = "layoutButtonsFlow"
        Me.layoutButtonsFlow.Size = New System.Drawing.Size(609, 36)
        Me.layoutButtonsFlow.TabIndex = 0
        '
        'cmbConnect
        '
        Me.cmbConnect.Location = New System.Drawing.Point(3, 3)
        Me.cmbConnect.Name = "cmbConnect"
        Me.cmbConnect.Size = New System.Drawing.Size(75, 23)
        Me.cmbConnect.TabIndex = 0
        Me.cmbConnect.Text = "Connect"
        Me.cmbConnect.UseVisualStyleBackColor = True
        '
        'cmbDisconnect
        '
        Me.cmbDisconnect.Location = New System.Drawing.Point(84, 3)
        Me.cmbDisconnect.Name = "cmbDisconnect"
        Me.cmbDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.cmbDisconnect.TabIndex = 1
        Me.cmbDisconnect.Text = "Disconnect"
        Me.cmbDisconnect.UseVisualStyleBackColor = True
        '
        'cmdClearAll
        '
        Me.cmdClearAll.Location = New System.Drawing.Point(165, 3)
        Me.cmdClearAll.Name = "cmdClearAll"
        Me.cmdClearAll.Size = New System.Drawing.Size(75, 23)
        Me.cmdClearAll.TabIndex = 2
        Me.cmdClearAll.Text = "CLEAR ALL"
        Me.cmdClearAll.UseVisualStyleBackColor = True
        '
        'cbbClearChannel
        '
        Me.cbbClearChannel.FormattingEnabled = True
        Me.cbbClearChannel.Location = New System.Drawing.Point(246, 4)
        Me.cbbClearChannel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.cbbClearChannel.Name = "cbbClearChannel"
        Me.cbbClearChannel.Size = New System.Drawing.Size(121, 21)
        Me.cbbClearChannel.TabIndex = 3
        '
        'cmbClearChannel
        '
        Me.cmbClearChannel.Location = New System.Drawing.Point(373, 3)
        Me.cmbClearChannel.Name = "cmbClearChannel"
        Me.cmbClearChannel.Size = New System.Drawing.Size(75, 23)
        Me.cmbClearChannel.TabIndex = 4
        Me.cmbClearChannel.Text = "CLEAR CH."
        Me.cmbClearChannel.UseVisualStyleBackColor = True
        '
        'nudLayerClear
        '
        Me.nudLayerClear.Location = New System.Drawing.Point(454, 5)
        Me.nudLayerClear.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.nudLayerClear.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLayerClear.Name = "nudLayerClear"
        Me.nudLayerClear.Size = New System.Drawing.Size(36, 20)
        Me.nudLayerClear.TabIndex = 5
        '
        'cmbClearLayer
        '
        Me.cmbClearLayer.Location = New System.Drawing.Point(496, 3)
        Me.cmbClearLayer.Name = "cmbClearLayer"
        Me.cmbClearLayer.Size = New System.Drawing.Size(99, 23)
        Me.cmbClearLayer.TabIndex = 6
        Me.cmbClearLayer.Text = "CLEAR LAYER"
        Me.cmbClearLayer.UseVisualStyleBackColor = True
        '
        'layoutAdressPanel
        '
        Me.layoutAdressPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.layoutAdressPanel.Controls.Add(Me.lblAddress)
        Me.layoutAdressPanel.Controls.Add(Me.txtPort)
        Me.layoutAdressPanel.Controls.Add(Me.txtAddress)
        Me.layoutAdressPanel.Location = New System.Drawing.Point(2, 1)
        Me.layoutAdressPanel.MinimumSize = New System.Drawing.Size(0, 40)
        Me.layoutAdressPanel.Name = "layoutAdressPanel"
        Me.layoutAdressPanel.Size = New System.Drawing.Size(610, 40)
        Me.layoutAdressPanel.TabIndex = 1
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(3, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(122, 13)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Server Adresse und Port"
        '
        'txtPort
        '
        Me.txtPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPort.Location = New System.Drawing.Point(556, 16)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(36, 20)
        Me.txtPort.TabIndex = 1
        Me.txtPort.Text = "5250"
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.Location = New System.Drawing.Point(6, 16)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(544, 20)
        Me.txtAddress.TabIndex = 0
        Me.txtAddress.Text = "localhost"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(926, 562)
        Me.Controls.Add(Me.layoutPlaylistSplit)
        Me.Name = "MainWindow"
        Me.Text = "Caspar's PlayoutClient"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.layoutPlaylistSplit.Panel2.ResumeLayout(False)
        CType(Me.layoutPlaylistSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layoutPlaylistSplit.ResumeLayout(False)
        Me.layoutUpDownSplit.Panel1.ResumeLayout(False)
        Me.layoutUpDownSplit.Panel2.ResumeLayout(False)
        CType(Me.layoutUpDownSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layoutUpDownSplit.ResumeLayout(False)
        Me.layoutCgLib.Panel1.ResumeLayout(False)
        CType(Me.layoutCgLib, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layoutCgLib.ResumeLayout(False)
        Me.layoutButtonsPanel.ResumeLayout(False)
        Me.layoutButtonsFlow.ResumeLayout(False)
        CType(Me.nudLayerClear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layoutAdressPanel.ResumeLayout(False)
        Me.layoutAdressPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents layoutPlaylistSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents layoutUpDownSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents layoutCgLib As System.Windows.Forms.SplitContainer

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub
    Friend WithEvents lsvPlayingMedia As System.Windows.Forms.ListView
    Friend WithEvents layoutButtonsPanel As System.Windows.Forms.Panel
    Friend WithEvents layoutAdressPanel As System.Windows.Forms.Panel
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents layoutButtonsFlow As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cmbConnect As System.Windows.Forms.Button
    Friend WithEvents cmbDisconnect As System.Windows.Forms.Button
    Friend WithEvents cmdClearAll As System.Windows.Forms.Button
    Friend WithEvents cbbClearChannel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbClearChannel As System.Windows.Forms.Button
    Friend WithEvents nudLayerClear As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbClearLayer As System.Windows.Forms.Button
End Class
