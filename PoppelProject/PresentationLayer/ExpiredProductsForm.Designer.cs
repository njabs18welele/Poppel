﻿namespace PoppelProject.PresentationLayer
{
    partial class ExpiredProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpiredProductsForm));
            this.itemsListView = new System.Windows.Forms.ListView();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsListView
            // 
            this.itemsListView.HideSelection = false;
            this.itemsListView.Location = new System.Drawing.Point(28, 76);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(382, 233);
            this.itemsListView.TabIndex = 0;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(189, 324);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(59, 29);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Expired List:";
            // 
            // ExpiredProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(442, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.itemsListView);
            this.Name = "ExpiredProductsForm";
            this.Text = "Expired Products";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExpiredProductsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView itemsListView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
    }
}