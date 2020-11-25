namespace InventorySimulation
{
    partial class Inverntory_Problem
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
            this.run_program = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rd_data = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sim_table = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.c_delay_cost = new System.Windows.Forms.Label();
            this.c_bear_cost = new System.Windows.Forms.Label();
            this.shortage_avg = new System.Windows.Forms.TextBox();
            this.Ending_avg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.show_outputs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sim_table)).BeginInit();
            this.SuspendLayout();
            // 
            // run_program
            // 
            this.run_program.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.run_program.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run_program.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_program.ForeColor = System.Drawing.Color.Navy;
            this.run_program.Location = new System.Drawing.Point(61, 343);
            this.run_program.Name = "run_program";
            this.run_program.Size = new System.Drawing.Size(213, 48);
            this.run_program.TabIndex = 108;
            this.run_program.Text = "Run";
            this.run_program.UseVisualStyleBackColor = false;
            this.run_program.Click += new System.EventHandler(this.run_program_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Location = new System.Drawing.Point(12, 212);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 24);
            this.panel5.TabIndex = 104;
            // 
            // rd_data
            // 
            this.rd_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rd_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rd_data.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_data.ForeColor = System.Drawing.Color.Navy;
            this.rd_data.Location = new System.Drawing.Point(61, 116);
            this.rd_data.Name = "rd_data";
            this.rd_data.Size = new System.Drawing.Size(213, 48);
            this.rd_data.TabIndex = 110;
            this.rd_data.Text = "Read Data";
            this.rd_data.UseVisualStyleBackColor = false;
            this.rd_data.Click += new System.EventHandler(this.rd_data_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 109;
            this.label3.Text = "Click to Run the Simulation";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(18, 370);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 53);
            this.panel3.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 106;
            this.label2.Text = "Click to Read Data from file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 103;
            this.label1.Text = "Input Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(15, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 32);
            this.panel2.TabIndex = 105;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(300, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 415);
            this.panel1.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Menu;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 30);
            this.label4.TabIndex = 116;
            this.label4.Text = "Output Data";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(338, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(652, 32);
            this.panel4.TabIndex = 115;
            // 
            // sim_table
            // 
            this.sim_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sim_table.Location = new System.Drawing.Point(338, 85);
            this.sim_table.Name = "sim_table";
            this.sim_table.Size = new System.Drawing.Size(652, 195);
            this.sim_table.TabIndex = 118;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(335, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 117;
            this.label5.Text = "Simulation Table";
            // 
            // c_delay_cost
            // 
            this.c_delay_cost.AutoSize = true;
            this.c_delay_cost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_delay_cost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_delay_cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.c_delay_cost.Location = new System.Drawing.Point(337, 365);
            this.c_delay_cost.Name = "c_delay_cost";
            this.c_delay_cost.Size = new System.Drawing.Size(179, 17);
            this.c_delay_cost.TabIndex = 147;
            this.c_delay_cost.Text = "Shortage Quantity Average ";
            // 
            // c_bear_cost
            // 
            this.c_bear_cost.AutoSize = true;
            this.c_bear_cost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_bear_cost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_bear_cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.c_bear_cost.Location = new System.Drawing.Point(337, 334);
            this.c_bear_cost.Name = "c_bear_cost";
            this.c_bear_cost.Size = new System.Drawing.Size(173, 17);
            this.c_bear_cost.TabIndex = 146;
            this.c_bear_cost.Text = "Ending Inventory Average ";
            // 
            // shortage_avg
            // 
            this.shortage_avg.Location = new System.Drawing.Point(516, 362);
            this.shortage_avg.Name = "shortage_avg";
            this.shortage_avg.ReadOnly = true;
            this.shortage_avg.Size = new System.Drawing.Size(192, 20);
            this.shortage_avg.TabIndex = 145;
            // 
            // Ending_avg
            // 
            this.Ending_avg.Location = new System.Drawing.Point(516, 334);
            this.Ending_avg.Name = "Ending_avg";
            this.Ending_avg.ReadOnly = true;
            this.Ending_avg.Size = new System.Drawing.Size(192, 20);
            this.Ending_avg.TabIndex = 144;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(333, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 27);
            this.label10.TabIndex = 143;
            this.label10.Text = "Performance Measures";
            // 
            // show_outputs
            // 
            this.show_outputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.show_outputs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_outputs.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_outputs.ForeColor = System.Drawing.Color.Navy;
            this.show_outputs.Location = new System.Drawing.Point(852, 286);
            this.show_outputs.Name = "show_outputs";
            this.show_outputs.Size = new System.Drawing.Size(139, 34);
            this.show_outputs.TabIndex = 148;
            this.show_outputs.Text = "Show Outputs";
            this.show_outputs.UseVisualStyleBackColor = false;
            this.show_outputs.Click += new System.EventHandler(this.show_outputs_Click);
            // 
            // Inverntory_Problem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 429);
            this.Controls.Add(this.show_outputs);
            this.Controls.Add(this.c_delay_cost);
            this.Controls.Add(this.c_bear_cost);
            this.Controls.Add(this.shortage_avg);
            this.Controls.Add(this.Ending_avg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sim_table);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.run_program);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.rd_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "Inverntory_Problem";
            this.Text = "Inventory_Problem";
            this.Load += new System.EventHandler(this.Inverntory_Problem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sim_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button run_program;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button rd_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView sim_table;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label c_delay_cost;
        private System.Windows.Forms.Label c_bear_cost;
        private System.Windows.Forms.TextBox shortage_avg;
        private System.Windows.Forms.TextBox Ending_avg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button show_outputs;
    }
}