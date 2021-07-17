namespace BDtoDatagridView
{
    partial class sistema
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.vista = new System.Windows.Forms.DataGridView();
            this.bdproyecto01DataSet = new BDtoDatagridView.bdproyecto01DataSet();
            this.bdproyecto01DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdproyecto01DataSet1 = new BDtoDatagridView.bdproyecto01DataSet1();
            this.baseMedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.base_MedTableAdapter = new BDtoDatagridView.bdproyecto01DataSet1TableAdapters.Base_MedTableAdapter();
            this.iDMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indicacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viayDosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRiesgoEmbarazoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efectosAdversosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contradiccionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precaucionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interaccionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdproyecto01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdproyecto01DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdproyecto01DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseMedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vista
            // 
            this.vista.AutoGenerateColumns = false;
            this.vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMedDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripciónDataGridViewTextBoxColumn,
            this.indicacionesDataGridViewTextBoxColumn,
            this.viayDosisDataGridViewTextBoxColumn,
            this.generalidadesDataGridViewTextBoxColumn,
            this.iDRiesgoEmbarazoDataGridViewTextBoxColumn,
            this.efectosAdversosDataGridViewTextBoxColumn,
            this.contradiccionesDataGridViewTextBoxColumn,
            this.precaucionesDataGridViewTextBoxColumn,
            this.interaccionesDataGridViewTextBoxColumn,
            this.iDGrupoDataGridViewTextBoxColumn});
            this.vista.DataSource = this.baseMedBindingSource;
            this.vista.Location = new System.Drawing.Point(12, 55);
            this.vista.Name = "vista";
            this.vista.Size = new System.Drawing.Size(776, 383);
            this.vista.TabIndex = 0;
            // 
            // bdproyecto01DataSet
            // 
            this.bdproyecto01DataSet.DataSetName = "bdproyecto01DataSet";
            this.bdproyecto01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdproyecto01DataSetBindingSource
            // 
            this.bdproyecto01DataSetBindingSource.DataSource = this.bdproyecto01DataSet;
            this.bdproyecto01DataSetBindingSource.Position = 0;
            // 
            // bdproyecto01DataSet1
            // 
            this.bdproyecto01DataSet1.DataSetName = "bdproyecto01DataSet1";
            this.bdproyecto01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baseMedBindingSource
            // 
            this.baseMedBindingSource.DataMember = "Base_Med";
            this.baseMedBindingSource.DataSource = this.bdproyecto01DataSet1;
            // 
            // base_MedTableAdapter
            // 
            this.base_MedTableAdapter.ClearBeforeFill = true;
            // 
            // iDMedDataGridViewTextBoxColumn
            // 
            this.iDMedDataGridViewTextBoxColumn.DataPropertyName = "ID_Med";
            this.iDMedDataGridViewTextBoxColumn.HeaderText = "ID_Med";
            this.iDMedDataGridViewTextBoxColumn.Name = "iDMedDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripciónDataGridViewTextBoxColumn
            // 
            this.descripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción";
            this.descripciónDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripciónDataGridViewTextBoxColumn.Name = "descripciónDataGridViewTextBoxColumn";
            // 
            // indicacionesDataGridViewTextBoxColumn
            // 
            this.indicacionesDataGridViewTextBoxColumn.DataPropertyName = "Indicaciones";
            this.indicacionesDataGridViewTextBoxColumn.HeaderText = "Indicaciones";
            this.indicacionesDataGridViewTextBoxColumn.Name = "indicacionesDataGridViewTextBoxColumn";
            // 
            // viayDosisDataGridViewTextBoxColumn
            // 
            this.viayDosisDataGridViewTextBoxColumn.DataPropertyName = "ViayDosis";
            this.viayDosisDataGridViewTextBoxColumn.HeaderText = "ViayDosis";
            this.viayDosisDataGridViewTextBoxColumn.Name = "viayDosisDataGridViewTextBoxColumn";
            // 
            // generalidadesDataGridViewTextBoxColumn
            // 
            this.generalidadesDataGridViewTextBoxColumn.DataPropertyName = "Generalidades";
            this.generalidadesDataGridViewTextBoxColumn.HeaderText = "Generalidades";
            this.generalidadesDataGridViewTextBoxColumn.Name = "generalidadesDataGridViewTextBoxColumn";
            // 
            // iDRiesgoEmbarazoDataGridViewTextBoxColumn
            // 
            this.iDRiesgoEmbarazoDataGridViewTextBoxColumn.DataPropertyName = "ID_Riesgo_Embarazo";
            this.iDRiesgoEmbarazoDataGridViewTextBoxColumn.HeaderText = "ID_Riesgo_Embarazo";
            this.iDRiesgoEmbarazoDataGridViewTextBoxColumn.Name = "iDRiesgoEmbarazoDataGridViewTextBoxColumn";
            // 
            // efectosAdversosDataGridViewTextBoxColumn
            // 
            this.efectosAdversosDataGridViewTextBoxColumn.DataPropertyName = "EfectosAdversos";
            this.efectosAdversosDataGridViewTextBoxColumn.HeaderText = "EfectosAdversos";
            this.efectosAdversosDataGridViewTextBoxColumn.Name = "efectosAdversosDataGridViewTextBoxColumn";
            // 
            // contradiccionesDataGridViewTextBoxColumn
            // 
            this.contradiccionesDataGridViewTextBoxColumn.DataPropertyName = "Contradicciones";
            this.contradiccionesDataGridViewTextBoxColumn.HeaderText = "Contradicciones";
            this.contradiccionesDataGridViewTextBoxColumn.Name = "contradiccionesDataGridViewTextBoxColumn";
            // 
            // precaucionesDataGridViewTextBoxColumn
            // 
            this.precaucionesDataGridViewTextBoxColumn.DataPropertyName = "Precauciones";
            this.precaucionesDataGridViewTextBoxColumn.HeaderText = "Precauciones";
            this.precaucionesDataGridViewTextBoxColumn.Name = "precaucionesDataGridViewTextBoxColumn";
            // 
            // interaccionesDataGridViewTextBoxColumn
            // 
            this.interaccionesDataGridViewTextBoxColumn.DataPropertyName = "Interacciones";
            this.interaccionesDataGridViewTextBoxColumn.HeaderText = "Interacciones";
            this.interaccionesDataGridViewTextBoxColumn.Name = "interaccionesDataGridViewTextBoxColumn";
            // 
            // iDGrupoDataGridViewTextBoxColumn
            // 
            this.iDGrupoDataGridViewTextBoxColumn.DataPropertyName = "ID_Grupo";
            this.iDGrupoDataGridViewTextBoxColumn.HeaderText = "ID_Grupo";
            this.iDGrupoDataGridViewTextBoxColumn.Name = "iDGrupoDataGridViewTextBoxColumn";
            // 
            // sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vista);
            this.Name = "sistema";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.sistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdproyecto01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdproyecto01DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdproyecto01DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseMedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vista;
        private System.Windows.Forms.BindingSource bdproyecto01DataSetBindingSource;
        private bdproyecto01DataSet bdproyecto01DataSet;
        private bdproyecto01DataSet1 bdproyecto01DataSet1;
        private System.Windows.Forms.BindingSource baseMedBindingSource;
        private bdproyecto01DataSet1TableAdapters.Base_MedTableAdapter base_MedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indicacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viayDosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generalidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRiesgoEmbarazoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efectosAdversosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contradiccionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precaucionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interaccionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGrupoDataGridViewTextBoxColumn;
    }
}

