﻿/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 12/18/2018
 * Time: 10:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace nyax
{
	partial class editcategoryform
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editcategoryform));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbostatus = new System.Windows.Forms.ComboBox();
			this.txtcategoryname = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnupdate = new System.Windows.Forms.Button();
			this.btnclose = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cbostatus);
			this.groupBox1.Controls.Add(this.txtcategoryname);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(415, 92);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(53, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "status";
			// 
			// cbostatus
			// 
			this.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbostatus.FormattingEnabled = true;
			this.cbostatus.Location = new System.Drawing.Point(99, 53);
			this.cbostatus.Name = "cbostatus";
			this.cbostatus.Size = new System.Drawing.Size(265, 21);
			this.cbostatus.TabIndex = 2;
			// 
			// txtcategoryname
			// 
			this.txtcategoryname.Location = new System.Drawing.Point(99, 18);
			this.txtcategoryname.Name = "txtcategoryname";
			this.txtcategoryname.Size = new System.Drawing.Size(265, 20);
			this.txtcategoryname.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "category name";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnupdate);
			this.groupBox2.Controls.Add(this.btnclose);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 92);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(415, 57);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			// 
			// btnupdate
			// 
			this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnupdate.ForeColor = System.Drawing.Color.Black;
			this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
			this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnupdate.Location = new System.Drawing.Point(140, 13);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(75, 35);
			this.btnupdate.TabIndex = 0;
			this.btnupdate.Text = "update";
			this.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnupdate.UseVisualStyleBackColor = true;
			this.btnupdate.Click += new System.EventHandler(this.BtnupdateClick);
			// 
			// btnclose
			// 
			this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnclose.ForeColor = System.Drawing.Color.Black;
			this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
			this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnclose.Location = new System.Drawing.Point(236, 13);
			this.btnclose.Name = "btnclose";
			this.btnclose.Size = new System.Drawing.Size(75, 35);
			this.btnclose.TabIndex = 1;
			this.btnclose.Text = "close";
			this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnclose.UseVisualStyleBackColor = true;
			this.btnclose.Click += new System.EventHandler(this.BtncloseClick);
			// 
			// editcategoryform
			// 
			this.AcceptButton = this.btnupdate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnclose;
			this.ClientSize = new System.Drawing.Size(415, 149);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "editcategoryform";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "edit category";
			this.Load += new System.EventHandler(this.EditcategoryformLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnclose;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtcategoryname;
		private System.Windows.Forms.ComboBox cbostatus;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
