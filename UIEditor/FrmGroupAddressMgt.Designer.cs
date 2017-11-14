﻿namespace UIEditor
{
    partial class FrmGroupAddressMgt
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGroupAddressMgt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGroupAddress = new System.Windows.Forms.DataGridView();
            this.palTop = new System.Windows.Forms.Panel();
            this.btnExportAddr = new System.Windows.Forms.Button();
            this.flpToolbar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnImportETSProject = new System.Windows.Forms.Button();
            this.palContent = new System.Windows.Forms.Panel();
            this.flpSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmsDgvGroupAddress = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbbFilterType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupAddress)).BeginInit();
            this.palTop.SuspendLayout();
            this.flpToolbar.SuspendLayout();
            this.palContent.SuspendLayout();
            this.flpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGroupAddress
            // 
            this.dgvGroupAddress.AllowUserToAddRows = false;
            this.dgvGroupAddress.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvGroupAddress.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGroupAddress.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupAddress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGroupAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGroupAddress.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.dgvGroupAddress, "dgvGroupAddress");
            this.dgvGroupAddress.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvGroupAddress.MultiSelect = false;
            this.dgvGroupAddress.Name = "dgvGroupAddress";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupAddress.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvGroupAddress.RowTemplate.Height = 23;
            this.dgvGroupAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupAddress.StandardTab = true;
            this.dgvGroupAddress.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupAddress_CellClick);
            this.dgvGroupAddress.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupAddress_CellContentClick);
            this.dgvGroupAddress.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupAddress_CellDoubleClick);
            this.dgvGroupAddress.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGroupAddress_CellMouseDown);
            this.dgvGroupAddress.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvGroupAddress_CellPainting);
            this.dgvGroupAddress.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGroupAddress_ColumnHeaderMouseClick);
            this.dgvGroupAddress.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvGroupAddress_ColumnWidthChanged);
            this.dgvGroupAddress.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvGroupAddress_DataBindingComplete);
            this.dgvGroupAddress.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvGroupAddress_RowPostPaint);
            this.dgvGroupAddress.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvGroupAddress_Scroll);
            this.dgvGroupAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvGroupAddress_KeyDown);
            this.dgvGroupAddress.MouseEnter += new System.EventHandler(this.dgvGroupAddress_MouseEnter);
            this.dgvGroupAddress.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.dgvGroupAddress_MouseWheel);
            // 
            // palTop
            // 
            this.palTop.Controls.Add(this.btnExportAddr);
            this.palTop.Controls.Add(this.flpToolbar);
            resources.ApplyResources(this.palTop, "palTop");
            this.palTop.Name = "palTop";
            // 
            // btnExportAddr
            // 
            resources.ApplyResources(this.btnExportAddr, "btnExportAddr");
            this.btnExportAddr.Name = "btnExportAddr";
            this.btnExportAddr.UseVisualStyleBackColor = true;
            this.btnExportAddr.Click += new System.EventHandler(this.btnExportAddr_Click);
            // 
            // flpToolbar
            // 
            resources.ApplyResources(this.flpToolbar, "flpToolbar");
            this.flpToolbar.Controls.Add(this.btnAdd);
            this.flpToolbar.Controls.Add(this.btnModify);
            this.flpToolbar.Controls.Add(this.btnSave);
            this.flpToolbar.Controls.Add(this.btnDelete);
            this.flpToolbar.Controls.Add(this.btnImportETSProject);
            this.flpToolbar.Name = "flpToolbar";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            resources.ApplyResources(this.btnModify, "btnModify");
            this.btnModify.Name = "btnModify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnImportETSProject
            // 
            resources.ApplyResources(this.btnImportETSProject, "btnImportETSProject");
            this.btnImportETSProject.Name = "btnImportETSProject";
            this.btnImportETSProject.UseVisualStyleBackColor = true;
            this.btnImportETSProject.Click += new System.EventHandler(this.btnImportETSProject_Click);
            // 
            // palContent
            // 
            this.palContent.Controls.Add(this.dgvGroupAddress);
            resources.ApplyResources(this.palContent, "palContent");
            this.palContent.Name = "palContent";
            // 
            // flpSearch
            // 
            this.flpSearch.Controls.Add(this.cbbFilterType);
            this.flpSearch.Controls.Add(this.txtSearch);
            this.flpSearch.Controls.Add(this.btnFilter);
            resources.ApplyResources(this.flpSearch, "flpSearch");
            this.flpSearch.Name = "flpSearch";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // btnFilter
            // 
            resources.ApplyResources(this.btnFilter, "btnFilter");
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cmsDgvGroupAddress
            // 
            this.cmsDgvGroupAddress.Name = "contextMenuStrip1";
            this.cmsDgvGroupAddress.ShowImageMargin = false;
            resources.ApplyResources(this.cmsDgvGroupAddress, "cmsDgvGroupAddress");
            // 
            // cbbFilterType
            // 
            this.cbbFilterType.FormattingEnabled = true;
            resources.ApplyResources(this.cbbFilterType, "cbbFilterType");
            this.cbbFilterType.Name = "cbbFilterType";
            this.cbbFilterType.SelectedIndexChanged += new System.EventHandler(this.cbbFilterType_SelectedIndexChanged);
            // 
            // FrmGroupAddressMgt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.palContent);
            this.Controls.Add(this.palTop);
            this.Controls.Add(this.flpSearch);
            this.Name = "FrmGroupAddressMgt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMgrGroupAddresses_FormClosing);
            this.Load += new System.EventHandler(this.FrmGroupAddressMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupAddress)).EndInit();
            this.palTop.ResumeLayout(false);
            this.palTop.PerformLayout();
            this.flpToolbar.ResumeLayout(false);
            this.palContent.ResumeLayout(false);
            this.flpSearch.ResumeLayout(false);
            this.flpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGroupAddress;
        private System.Windows.Forms.Panel palTop;
        private System.Windows.Forms.FlowLayoutPanel flpToolbar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel palContent;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImportETSProject;
        private System.Windows.Forms.FlowLayoutPanel flpSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ContextMenuStrip cmsDgvGroupAddress;
        private System.Windows.Forms.Button btnExportAddr;
        private System.Windows.Forms.ComboBox cbbFilterType;

    }
}