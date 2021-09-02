
namespace WindowsFormsApp2
{
    partial class departForm
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
            this.labeldepart = new System.Windows.Forms.Label();
            this.grpboxAddDepart = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.errorProviderCourse = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDuration = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpboxAddDepart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // labeldepart
            // 
            this.labeldepart.AutoSize = true;
            this.labeldepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldepart.Location = new System.Drawing.Point(600, 27);
            this.labeldepart.Name = "labeldepart";
            this.labeldepart.Size = new System.Drawing.Size(186, 29);
            this.labeldepart.TabIndex = 1;
            this.labeldepart.Text = "DEPARTMENT";
            this.labeldepart.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpboxAddDepart
            // 
            this.grpboxAddDepart.Controls.Add(this.btnReset);
            this.grpboxAddDepart.Controls.Add(this.btnCancel);
            this.grpboxAddDepart.Controls.Add(this.textBoxDuration);
            this.grpboxAddDepart.Controls.Add(this.labelDuration);
            this.grpboxAddDepart.Controls.Add(this.btnAdd);
            this.grpboxAddDepart.Controls.Add(this.textBoxCourse);
            this.grpboxAddDepart.Controls.Add(this.labelCourse);
            this.grpboxAddDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxAddDepart.Location = new System.Drawing.Point(160, 115);
            this.grpboxAddDepart.Name = "grpboxAddDepart";
            this.grpboxAddDepart.Size = new System.Drawing.Size(1117, 485);
            this.grpboxAddDepart.TabIndex = 2;
            this.grpboxAddDepart.TabStop = false;
            this.grpboxAddDepart.Text = "Add Department";
            this.grpboxAddDepart.Enter += new System.EventHandler(this.grpboxAddDepart_Enter);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(746, 194);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(164, 51);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(746, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 51);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(299, 252);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(303, 30);
            this.textBoxDuration.TabIndex = 1;
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(746, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 51);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(299, 168);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(307, 30);
            this.textBoxCourse.TabIndex = 0;
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
            // errorProviderCourse
            // 
            this.errorProviderCourse.ContainerControl = this;
            // 
            // errorProviderDuration
            // 
            this.errorProviderDuration.ContainerControl = this;
            // 
            // departForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 716);
            this.Controls.Add(this.grpboxAddDepart);
            this.Controls.Add(this.labeldepart);
            this.Name = "departForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "departForm";
            this.Load += new System.EventHandler(this.departForm_Load);
            this.grpboxAddDepart.ResumeLayout(false);
            this.grpboxAddDepart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeldepart;
        private System.Windows.Forms.GroupBox grpboxAddDepart;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProviderCourse;
        private System.Windows.Forms.ErrorProvider errorProviderDuration;
    }
}