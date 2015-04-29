namespace One_Stop_Shop_Queue_Management_System
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timeRefresh = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCallClient = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.lblCounterNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "One Stop Shop Queue Management System";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(8, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(244, 298);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(573, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 303);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Logs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clients On Queue:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Client";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Accept Client Transfer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Finish Transaction";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(100, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "Requeue";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(263, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 37);
            this.button5.TabIndex = 10;
            this.button5.Text = "Transfer Client";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 412);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 32);
            this.button7.TabIndex = 12;
            this.button7.Text = "Edit Client";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(616, 458);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(99, 17);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "<Time Today>";
            // 
            // timeRefresh
            // 
            this.timeRefresh.Tick += new System.EventHandler(this.timeRefresh_Tick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(694, 368);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 37);
            this.button6.TabIndex = 14;
            this.button6.Text = "Generate Log";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(258, 61);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(309, 303);
            this.listView2.TabIndex = 15;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Clients To Transfer:";
            // 
            // txtCallClient
            // 
            this.txtCallClient.Location = new System.Drawing.Point(8, 450);
            this.txtCallClient.Name = "txtCallClient";
            this.txtCallClient.Size = new System.Drawing.Size(90, 33);
            this.txtCallClient.TabIndex = 17;
            this.txtCallClient.Text = "Call Client";
            this.txtCallClient.UseVisualStyleBackColor = true;
            this.txtCallClient.Click += new System.EventHandler(this.txtCallClient_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(573, 369);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 37);
            this.button8.TabIndex = 18;
            this.button8.Text = "Lock System";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(264, 410);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(134, 34);
            this.button9.TabIndex = 19;
            this.button9.Text = "Remove Transfer";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(404, 450);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(163, 34);
            this.button10.TabIndex = 20;
            this.button10.Text = "Edit Transfer Data";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(404, 410);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(163, 34);
            this.button11.TabIndex = 21;
            this.button11.Text = "Generate Transfer File";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(404, 367);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(163, 37);
            this.button12.TabIndex = 22;
            this.button12.Text = "Return to Queue";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(264, 449);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(134, 34);
            this.button13.TabIndex = 23;
            this.button13.Text = "Modify Transfer";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // lblCounterNo
            // 
            this.lblCounterNo.AutoSize = true;
            this.lblCounterNo.Location = new System.Drawing.Point(616, 427);
            this.lblCounterNo.Name = "lblCounterNo";
            this.lblCounterNo.Size = new System.Drawing.Size(96, 17);
            this.lblCounterNo.TabIndex = 24;
            this.lblCounterNo.Text = "<Counter No>";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 484);
            this.Controls.Add(this.lblCounterNo);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txtCallClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "OSS QuMaSy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timeRefresh;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button txtCallClient;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label lblCounterNo;
    }
}

