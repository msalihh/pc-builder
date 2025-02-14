namespace newbuild
{
    partial class LoadSystemsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadSystemsForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            gridControl2 = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            Cpu = new DevExpress.XtraGrid.Columns.GridColumn();
            MotherBoard = new DevExpress.XtraGrid.Columns.GridColumn();
            Memory = new DevExpress.XtraGrid.Columns.GridColumn();
            Gpu = new DevExpress.XtraGrid.Columns.GridColumn();
            Ssd = new DevExpress.XtraGrid.Columns.GridColumn();
            Monitor = new DevExpress.XtraGrid.Columns.GridColumn();
            DateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            Price = new DevExpress.XtraGrid.Columns.GridColumn();
            addBtnCpu = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            addBtnMotherBoard = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            closeButton = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addBtnCpu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addBtnMotherBoard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // gridControl2
            // 
            gridControl2.Dock = DockStyle.Fill;
            gridControl2.EmbeddedNavigator.Appearance.BackColor = Color.White;
            gridControl2.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            gridControl2.EmbeddedNavigator.BackgroundImageLayout = ImageLayout.Center;
            gridControl2.EmbeddedNavigator.Margin = new Padding(6, 3, 6, 3);
            gridControl2.Location = new Point(0, 0);
            gridControl2.MainView = gridView2;
            gridControl2.Margin = new Padding(6, 3, 6, 3);
            gridControl2.Name = "gridControl2";
            gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { addBtnCpu, addBtnMotherBoard });
            gridControl2.Size = new Size(1466, 724);
            gridControl2.TabIndex = 4;
            gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            gridControl2.Load += gridControl2_Load;
            // 
            // gridView2
            // 
            gridView2.Appearance.EvenRow.BackColor = Color.DeepSkyBlue;
            gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            gridView2.Appearance.EvenRow.Options.UseTextOptions = true;
            gridView2.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Appearance.HeaderPanel.BorderColor = Color.Transparent;
            gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridView2.Appearance.OddRow.BackColor = Color.White;
            gridView2.Appearance.OddRow.Options.UseBackColor = true;
            gridView2.AppearancePrint.EvenRow.BackColor = Color.DeepSkyBlue;
            gridView2.AppearancePrint.EvenRow.Options.UseBackColor = true;
            gridView2.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            gridView2.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.AppearancePrint.GroupRow.BorderColor = Color.FromArgb(255, 255, 192);
            gridView2.AppearancePrint.HeaderPanel.BorderColor = Color.FromArgb(255, 192, 192);
            gridView2.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            gridView2.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gridView2.ColumnPanelRowHeight = 45;
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Cpu, MotherBoard, Memory, Gpu, Ssd, Monitor, DateTime, Price });
            gridView2.DetailHeight = 528;
            gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            gridView2.GridControl = gridControl2;
            gridView2.Name = "gridView2";
            gridView2.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.False;
            gridView2.OptionsEditForm.PopupEditFormWidth = 1243;
            gridView2.OptionsMenu.DialogFormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            gridView2.OptionsPrint.EnableAppearanceEvenRow = true;
            gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView2.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridView2.OptionsView.EnableAppearanceEvenRow = true;
            gridView2.OptionsView.EnableAppearanceOddRow = true;
            gridView2.OptionsView.ShowAutoFilterRow = true;
            gridView2.OptionsView.ShowFooter = true;
            gridView2.OptionsView.ShowGroupPanel = false;
            gridView2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            gridView2.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            gridView2.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            gridView2.RowHeight = 60;
            // 
            // Cpu
            // 
            Cpu.AppearanceCell.BackColor = Color.Transparent;
            Cpu.AppearanceCell.BorderColor = Color.White;
            Cpu.AppearanceCell.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Cpu.AppearanceCell.Options.UseBackColor = true;
            Cpu.AppearanceCell.Options.UseBorderColor = true;
            Cpu.AppearanceCell.Options.UseFont = true;
            Cpu.AppearanceCell.Options.UseTextOptions = true;
            Cpu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Cpu.AppearanceHeader.BackColor = Color.DodgerBlue;
            Cpu.AppearanceHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Cpu.AppearanceHeader.FontStyleDelta = FontStyle.Bold;
            Cpu.AppearanceHeader.ForeColor = Color.White;
            Cpu.AppearanceHeader.Options.UseBackColor = true;
            Cpu.AppearanceHeader.Options.UseFont = true;
            Cpu.AppearanceHeader.Options.UseForeColor = true;
            Cpu.AppearanceHeader.Options.UseTextOptions = true;
            Cpu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Cpu.Caption = "Cpu";
            Cpu.FieldName = "Cpu";
            Cpu.MinWidth = 134;
            Cpu.Name = "Cpu";
            Cpu.OptionsColumn.AllowEdit = false;
            Cpu.OptionsColumn.ShowInExpressionEditor = false;
            Cpu.Visible = true;
            Cpu.VisibleIndex = 0;
            Cpu.Width = 200;
            // 
            // MotherBoard
            // 
            MotherBoard.AppearanceCell.BackColor = Color.Transparent;
            MotherBoard.AppearanceCell.BorderColor = Color.White;
            MotherBoard.AppearanceCell.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            MotherBoard.AppearanceCell.Options.UseBackColor = true;
            MotherBoard.AppearanceCell.Options.UseBorderColor = true;
            MotherBoard.AppearanceCell.Options.UseFont = true;
            MotherBoard.AppearanceCell.Options.UseTextOptions = true;
            MotherBoard.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            MotherBoard.AppearanceHeader.BackColor = Color.DodgerBlue;
            MotherBoard.AppearanceHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            MotherBoard.AppearanceHeader.FontStyleDelta = FontStyle.Bold;
            MotherBoard.AppearanceHeader.ForeColor = Color.White;
            MotherBoard.AppearanceHeader.Options.UseBackColor = true;
            MotherBoard.AppearanceHeader.Options.UseFont = true;
            MotherBoard.AppearanceHeader.Options.UseForeColor = true;
            MotherBoard.AppearanceHeader.Options.UseTextOptions = true;
            MotherBoard.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            MotherBoard.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            MotherBoard.Caption = "Mother Board";
            MotherBoard.FieldName = "MotherBoard";
            MotherBoard.MinWidth = 134;
            MotherBoard.Name = "MotherBoard";
            MotherBoard.OptionsColumn.AllowEdit = false;
            MotherBoard.OptionsColumn.ShowInExpressionEditor = false;
            MotherBoard.Visible = true;
            MotherBoard.VisibleIndex = 1;
            MotherBoard.Width = 195;
            // 
            // Memory
            // 
            Memory.AppearanceCell.BackColor = Color.Transparent;
            Memory.AppearanceCell.BorderColor = Color.White;
            Memory.AppearanceCell.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Memory.AppearanceCell.Options.UseBackColor = true;
            Memory.AppearanceCell.Options.UseBorderColor = true;
            Memory.AppearanceCell.Options.UseFont = true;
            Memory.AppearanceCell.Options.UseTextOptions = true;
            Memory.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Memory.AppearanceHeader.BackColor = Color.DodgerBlue;
            Memory.AppearanceHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Memory.AppearanceHeader.FontStyleDelta = FontStyle.Bold;
            Memory.AppearanceHeader.ForeColor = Color.White;
            Memory.AppearanceHeader.Options.UseBackColor = true;
            Memory.AppearanceHeader.Options.UseFont = true;
            Memory.AppearanceHeader.Options.UseForeColor = true;
            Memory.AppearanceHeader.Options.UseTextOptions = true;
            Memory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Memory.Caption = "Memory";
            Memory.FieldName = "Memory";
            Memory.MinWidth = 80;
            Memory.Name = "Memory";
            Memory.OptionsColumn.AllowEdit = false;
            Memory.OptionsColumn.ShowInExpressionEditor = false;
            Memory.Visible = true;
            Memory.VisibleIndex = 2;
            Memory.Width = 200;
            // 
            // Gpu
            // 
            Gpu.AppearanceCell.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Gpu.AppearanceCell.Options.UseFont = true;
            Gpu.AppearanceCell.Options.UseTextOptions = true;
            Gpu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Gpu.AppearanceHeader.BackColor = Color.DodgerBlue;
            Gpu.AppearanceHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Gpu.AppearanceHeader.Options.UseBackColor = true;
            Gpu.AppearanceHeader.Options.UseFont = true;
            Gpu.AppearanceHeader.Options.UseTextOptions = true;
            Gpu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Gpu.Caption = "Gpu";
            Gpu.FieldName = "Gpu";
            Gpu.MinWidth = 26;
            Gpu.Name = "Gpu";
            Gpu.Visible = true;
            Gpu.VisibleIndex = 3;
            Gpu.Width = 200;
            // 
            // Ssd
            // 
            Ssd.AppearanceCell.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Ssd.AppearanceCell.Options.UseFont = true;
            Ssd.AppearanceCell.Options.UseTextOptions = true;
            Ssd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Ssd.AppearanceHeader.BackColor = Color.DodgerBlue;
            Ssd.AppearanceHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Ssd.AppearanceHeader.Options.UseBackColor = true;
            Ssd.AppearanceHeader.Options.UseFont = true;
            Ssd.AppearanceHeader.Options.UseTextOptions = true;
            Ssd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Ssd.Caption = "Ssd";
            Ssd.FieldName = "Ssd";
            Ssd.MinWidth = 26;
            Ssd.Name = "Ssd";
            Ssd.Visible = true;
            Ssd.VisibleIndex = 4;
            Ssd.Width = 200;
            // 
            // Monitor
            // 
            Monitor.AppearanceCell.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Monitor.AppearanceCell.Options.UseFont = true;
            Monitor.AppearanceCell.Options.UseTextOptions = true;
            Monitor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Monitor.AppearanceHeader.BackColor = Color.DodgerBlue;
            Monitor.AppearanceHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Monitor.AppearanceHeader.Options.UseBackColor = true;
            Monitor.AppearanceHeader.Options.UseFont = true;
            Monitor.AppearanceHeader.Options.UseTextOptions = true;
            Monitor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Monitor.Caption = "Monitor";
            Monitor.FieldName = "Monitor";
            Monitor.MinWidth = 26;
            Monitor.Name = "Monitor";
            Monitor.Visible = true;
            Monitor.VisibleIndex = 5;
            Monitor.Width = 200;
            // 
            // DateTime
            // 
            DateTime.AppearanceCell.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DateTime.AppearanceCell.Options.UseFont = true;
            DateTime.AppearanceCell.Options.UseTextOptions = true;
            DateTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            DateTime.AppearanceHeader.BackColor = Color.DodgerBlue;
            DateTime.AppearanceHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DateTime.AppearanceHeader.Options.UseBackColor = true;
            DateTime.AppearanceHeader.Options.UseFont = true;
            DateTime.AppearanceHeader.Options.UseTextOptions = true;
            DateTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            DateTime.Caption = "DateTime";
            DateTime.FieldName = "DateTime";
            DateTime.MinWidth = 26;
            DateTime.Name = "DateTime";
            DateTime.Visible = true;
            DateTime.VisibleIndex = 6;
            DateTime.Width = 106;
            // 
            // Price
            // 
            Price.AccessibleDescription = "Price";
            Price.AppearanceCell.BackColor = Color.Transparent;
            Price.AppearanceCell.BorderColor = Color.White;
            Price.AppearanceCell.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Price.AppearanceCell.Options.UseBackColor = true;
            Price.AppearanceCell.Options.UseBorderColor = true;
            Price.AppearanceCell.Options.UseFont = true;
            Price.AppearanceCell.Options.UseTextOptions = true;
            Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Price.AppearanceHeader.BackColor = Color.DodgerBlue;
            Price.AppearanceHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Price.AppearanceHeader.FontStyleDelta = FontStyle.Bold;
            Price.AppearanceHeader.ForeColor = Color.White;
            Price.AppearanceHeader.Options.UseBackColor = true;
            Price.AppearanceHeader.Options.UseFont = true;
            Price.AppearanceHeader.Options.UseForeColor = true;
            Price.AppearanceHeader.Options.UseTextOptions = true;
            Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Price.Caption = "Price";
            Price.FieldName = "Price";
            Price.MinWidth = 80;
            Price.Name = "Price";
            Price.OptionsColumn.AllowEdit = false;
            Price.OptionsColumn.ShowInExpressionEditor = false;
            Price.Visible = true;
            Price.VisibleIndex = 7;
            Price.Width = 80;
            // 
            // addBtnCpu
            // 
            addBtnCpu.Appearance.BackColor = Color.White;
            addBtnCpu.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            addBtnCpu.Appearance.Options.UseBackColor = true;
            addBtnCpu.Appearance.Options.UseFont = true;
            addBtnCpu.AutoHeight = false;
            addBtnCpu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions1.Image = (Image)resources.GetObject("editorButtonImageOptions1.Image");
            editorButtonImageOptions1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            serializableAppearanceObject1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            serializableAppearanceObject1.ForeColor = Color.DodgerBlue;
            serializableAppearanceObject1.Options.UseBackColor = true;
            serializableAppearanceObject1.Options.UseFont = true;
            serializableAppearanceObject1.Options.UseForeColor = true;
            addBtnCpu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Add", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            addBtnCpu.LookAndFeel.SkinMaskColor = Color.White;
            addBtnCpu.LookAndFeel.SkinMaskColor2 = Color.FromArgb(192, 255, 255);
            addBtnCpu.LookAndFeel.SkinName = "Office 2013";
            addBtnCpu.LookAndFeel.UseDefaultLookAndFeel = false;
            addBtnCpu.Name = "addBtnCpu";
            addBtnCpu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // addBtnMotherBoard
            // 
            addBtnMotherBoard.AutoHeight = false;
            addBtnMotherBoard.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions2.Image = (Image)resources.GetObject("editorButtonImageOptions2.Image");
            addBtnMotherBoard.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            addBtnMotherBoard.LookAndFeel.SkinName = "Office 2019 Colorful";
            addBtnMotherBoard.LookAndFeel.UseDefaultLookAndFeel = false;
            addBtnMotherBoard.Name = "addBtnMotherBoard";
            addBtnMotherBoard.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            closeButton.Appearance.BackColor = Color.LightSkyBlue;
            closeButton.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            closeButton.Appearance.Options.UseBackColor = true;
            closeButton.Appearance.Options.UseFont = true;
            closeButton.Location = new Point(598, 24);
            closeButton.Margin = new Padding(5, 3, 5, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(225, 51);
            closeButton.TabIndex = 5;
            closeButton.Text = "Close";
            closeButton.Click += closeButton_Click;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(closeButton);
            panelControl1.Dock = DockStyle.Bottom;
            panelControl1.Location = new Point(0, 555);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(1466, 169);
            panelControl1.TabIndex = 6;
            // 
            // LoadSystemsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 724);
            Controls.Add(panelControl1);
            Controls.Add(gridControl2);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 3, 5, 3);
            Name = "LoadSystemsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Saved Systems";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)gridControl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)addBtnCpu).EndInit();
            ((System.ComponentModel.ISupportInitialize)addBtnMotherBoard).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Cpu;
        private DevExpress.XtraGrid.Columns.GridColumn MotherBoard;
        private DevExpress.XtraGrid.Columns.GridColumn Memory;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit addBtnCpu;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit addBtnMotherBoard;
        private DevExpress.XtraGrid.Columns.GridColumn Gpu;
        private DevExpress.XtraGrid.Columns.GridColumn Ssd;
        private DevExpress.XtraGrid.Columns.GridColumn Monitor;
        private DevExpress.XtraGrid.Columns.GridColumn DateTime;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}