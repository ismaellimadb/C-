﻿namespace WindowsFormsApplication1
{
    partial class frmAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAluno));
            System.Windows.Forms.Label idAlunoLabel;
            System.Windows.Forms.Label nomeAlunoLabel;
            System.Windows.Forms.Label sobrenomeAlunoLabel;
            System.Windows.Forms.Label telefoneAlunoLabel;
            this.dBCadastrarAulaDataSet = new WindowsFormsApplication1.DBCadastrarAulaDataSet();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter = new WindowsFormsApplication1.DBCadastrarAulaDataSetTableAdapters.AlunoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.DBCadastrarAulaDataSetTableAdapters.TableAdapterManager();
            this.alunoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.alunoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idAlunoLabel1 = new System.Windows.Forms.Label();
            this.nomeAlunoTextBox = new System.Windows.Forms.TextBox();
            this.sobrenomeAlunoTextBox = new System.Windows.Forms.TextBox();
            this.telefoneAlunoTextBox = new System.Windows.Forms.TextBox();
            idAlunoLabel = new System.Windows.Forms.Label();
            nomeAlunoLabel = new System.Windows.Forms.Label();
            sobrenomeAlunoLabel = new System.Windows.Forms.Label();
            telefoneAlunoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCadastrarAulaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingNavigator)).BeginInit();
            this.alunoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dBCadastrarAulaDataSet
            // 
            this.dBCadastrarAulaDataSet.DataSetName = "DBCadastrarAulaDataSet";
            this.dBCadastrarAulaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "Aluno";
            this.alunoBindingSource.DataSource = this.dBCadastrarAulaDataSet;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunoTableAdapter = this.alunoTableAdapter;
            this.tableAdapterManager.AulaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProfessorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.DBCadastrarAulaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alunoBindingNavigator
            // 
            this.alunoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.alunoBindingNavigator.BindingSource = this.alunoBindingSource;
            this.alunoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alunoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.alunoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.alunoBindingNavigatorSaveItem});
            this.alunoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.alunoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alunoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alunoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alunoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alunoBindingNavigator.Name = "alunoBindingNavigator";
            this.alunoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alunoBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.alunoBindingNavigator.TabIndex = 0;
            this.alunoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // alunoBindingNavigatorSaveItem
            // 
            this.alunoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alunoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("alunoBindingNavigatorSaveItem.Image")));
            this.alunoBindingNavigatorSaveItem.Name = "alunoBindingNavigatorSaveItem";
            this.alunoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.alunoBindingNavigatorSaveItem.Text = "Save Data";
            this.alunoBindingNavigatorSaveItem.Click += new System.EventHandler(this.alunoBindingNavigatorSaveItem_Click);
            // 
            // idAlunoLabel
            // 
            idAlunoLabel.AutoSize = true;
            idAlunoLabel.Location = new System.Drawing.Point(12, 49);
            idAlunoLabel.Name = "idAlunoLabel";
            idAlunoLabel.Size = new System.Drawing.Size(49, 13);
            idAlunoLabel.TabIndex = 1;
            idAlunoLabel.Text = "Id Aluno:";
            // 
            // idAlunoLabel1
            // 
            this.idAlunoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "IdAluno", true));
            this.idAlunoLabel1.Location = new System.Drawing.Point(67, 49);
            this.idAlunoLabel1.Name = "idAlunoLabel1";
            this.idAlunoLabel1.Size = new System.Drawing.Size(100, 23);
            this.idAlunoLabel1.TabIndex = 2;
            this.idAlunoLabel1.Text = "label1";
            // 
            // nomeAlunoLabel
            // 
            nomeAlunoLabel.AutoSize = true;
            nomeAlunoLabel.Location = new System.Drawing.Point(12, 72);
            nomeAlunoLabel.Name = "nomeAlunoLabel";
            nomeAlunoLabel.Size = new System.Drawing.Size(66, 13);
            nomeAlunoLabel.TabIndex = 3;
            nomeAlunoLabel.Text = "nome Aluno:";
            // 
            // nomeAlunoTextBox
            // 
            this.nomeAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "nomeAluno", true));
            this.nomeAlunoTextBox.Location = new System.Drawing.Point(84, 69);
            this.nomeAlunoTextBox.Name = "nomeAlunoTextBox";
            this.nomeAlunoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeAlunoTextBox.TabIndex = 4;
            // 
            // sobrenomeAlunoLabel
            // 
            sobrenomeAlunoLabel.AutoSize = true;
            sobrenomeAlunoLabel.Location = new System.Drawing.Point(12, 101);
            sobrenomeAlunoLabel.Name = "sobrenomeAlunoLabel";
            sobrenomeAlunoLabel.Size = new System.Drawing.Size(92, 13);
            sobrenomeAlunoLabel.TabIndex = 5;
            sobrenomeAlunoLabel.Text = "sobrenome Aluno:";
            // 
            // sobrenomeAlunoTextBox
            // 
            this.sobrenomeAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "sobrenomeAluno", true));
            this.sobrenomeAlunoTextBox.Location = new System.Drawing.Point(110, 98);
            this.sobrenomeAlunoTextBox.Name = "sobrenomeAlunoTextBox";
            this.sobrenomeAlunoTextBox.Size = new System.Drawing.Size(100, 20);
            this.sobrenomeAlunoTextBox.TabIndex = 6;
            // 
            // telefoneAlunoLabel
            // 
            telefoneAlunoLabel.AutoSize = true;
            telefoneAlunoLabel.Location = new System.Drawing.Point(12, 129);
            telefoneAlunoLabel.Name = "telefoneAlunoLabel";
            telefoneAlunoLabel.Size = new System.Drawing.Size(78, 13);
            telefoneAlunoLabel.TabIndex = 7;
            telefoneAlunoLabel.Text = "telefone Aluno:";
            // 
            // telefoneAlunoTextBox
            // 
            this.telefoneAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "telefoneAluno", true));
            this.telefoneAlunoTextBox.Location = new System.Drawing.Point(96, 126);
            this.telefoneAlunoTextBox.Name = "telefoneAlunoTextBox";
            this.telefoneAlunoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneAlunoTextBox.TabIndex = 8;
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(telefoneAlunoLabel);
            this.Controls.Add(this.telefoneAlunoTextBox);
            this.Controls.Add(sobrenomeAlunoLabel);
            this.Controls.Add(this.sobrenomeAlunoTextBox);
            this.Controls.Add(nomeAlunoLabel);
            this.Controls.Add(this.nomeAlunoTextBox);
            this.Controls.Add(idAlunoLabel);
            this.Controls.Add(this.idAlunoLabel1);
            this.Controls.Add(this.alunoBindingNavigator);
            this.Name = "frmAluno";
            this.Text = "Cadastrar Aluno";
            this.Load += new System.EventHandler(this.frmAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCadastrarAulaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingNavigator)).EndInit();
            this.alunoBindingNavigator.ResumeLayout(false);
            this.alunoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBCadastrarAulaDataSet dBCadastrarAulaDataSet;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private DBCadastrarAulaDataSetTableAdapters.AlunoTableAdapter alunoTableAdapter;
        private DBCadastrarAulaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alunoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton alunoBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idAlunoLabel1;
        private System.Windows.Forms.TextBox nomeAlunoTextBox;
        private System.Windows.Forms.TextBox sobrenomeAlunoTextBox;
        private System.Windows.Forms.TextBox telefoneAlunoTextBox;
    }
}