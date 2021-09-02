
namespace WindowsFormsApp2
{
    partial class departUpdateForm
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
            this.grpboxUpdateDepart = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labeldepart = new System.Windows.Forms.Label();
            this.errorProviderCourseupdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUpdateDur = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpboxUpdateDepart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCourseupdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUpdateDur)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxUpdateDepart
            // 
            this.grpboxUpdateDepart.Controls.Add(this.btnView);
            this.grpboxUpdateDepart.Controls.Add(this.btnDelete);
            this.grpboxUpdateDepart.Controls.Add(this.btnReset);
            this.grpboxUpdateDepart.Controls.Add(this.btnCancel);
            this.grpboxUpdateDepart.Controls.Add(this.textBoxDuration);
            this.grpboxUpdateDepart.Controls.Add(this.labelDuration);
            this.grpboxUpdateDepart.Controls.Add(this.btnUpdate);
            this.grpboxUpdateDepart.Controls.Add(this.textBoxCourse);
            this.grpboxUpdateDepart.Controls.Add(this.labelCourse);
            this.grpboxUpdateDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxUpdateDepart.Location = new System.Drawing.Point(110, 146);
            this.grpboxUpdateDepart.Name = "grpboxUpdateDepart";
            this.grpboxUpdateDepart.Size = new System.Drawing.Size(1117, 485);
            this.grpboxUpdateDepart.TabIndex = 4;
            this.grpboxUpdateDepart.TabStop = false;
            this.grpboxUpdateDepart.Text = "Update/delete Department";
            this.grpboxUpdateDepart.Enter += new System.EventHandler(this.grpboxUpdateDepart_Enter);
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.Location = new System.Drawing.Point(354, 394);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(164, 51);
            this.btnView.TabIndex = 8;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(770, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 51);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(770, 240);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(164, 51);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(770, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 51);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(303, 252);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(303, 30);
            this.textBoxDuration.TabIndex = 4;
            this.textBoxDuration.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDuration_Validating);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(125, 252);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(85, 25);
            this.labelDuration.TabIndex = 3;
            this.labelDuration.Text = "Duration";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(770, 66);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 51);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(299, 168);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(307, 30);
            this.textBoxCourse.TabIndex = 1;
            this.textBoxCourse.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCourse_Validating);
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourse.Location = new System.Drawing.Point(125, 168);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(76, 25);
            this.labelCourse.TabIndex = 0;
            this.labelCourse.Text = "Course";
            // 
            // labeldepart
            // 
            this.labeldepart.AutoSize = true;
            this.labeldepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldepart.Location = new System.Drawing.Point(550, 68);
            this.labeldepart.Name = "labeldepart";
            this.labeldepart.Size = new System.Drawing.Size(186, 29);
            this.labeldepart.TabIndex = 3;
            this.labeldepart.Text = "DEPARTMENT";
            this.labeldepart.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // errorProviderCourseupdate
            // 
            this.errorProviderCourseupdate.ContainerControl = this;
            // 
            // errorProviderUpdateDur
            // 
            this.errorProviderUpdateDur.ContainerControl = this;
            // 
            // departUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 709);
            this.Controls.Add(this.grpboxUpdateDepart);
            this.Controls.Add(this.labeldepart);
            this.Name = "departUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "departUpdateForm";
            this.grpboxUpdateDepart.ResumeLayout(false);
            this.grpboxUpdateDepart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCourseupdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUpdateDur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxUpdateDepart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labeldepart;
        private System.Windows.Forms.ErrorProvider errorProviderCourseupdate;
        private System.Windows.Forms.ErrorProvider errorProviderUpdateDur;
        public System.Windows.Forms.TextBox textBoxDuration;
        public System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnView;
    }
}