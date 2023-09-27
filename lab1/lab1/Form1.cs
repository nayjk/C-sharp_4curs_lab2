using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        Label label1 = new Label();
        Button button1 = new Button();
        Button button2 = new Button();
        Button button3 = new Button();
        Button button4 = new Button();
        Button button5 = new Button();
        Button button6 = new Button();
        Button button7 = new Button();
        Button button8 = new Button();
        Button button9 = new Button();
        Button button10 = new Button();
        Button button11 = new Button();
        DataGridView dataGridView1 = new DataGridView();
        DataGridViewTextBoxColumn Column1 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn Column2 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn Column3 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn Column4 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn gridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn gridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn gridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn gridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        CheckBox checkBox1 = new CheckBox();
        CheckBox checkBox2 = new CheckBox();
        public Form1()
        {
            InitializeComponent();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new Point(160, 27);
            this.label1.Name = "label1";
            this.label1.Size = new Size(201, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Абонент THC";
            // 
            // button1
            // 
            this.button1.Location = new Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new Size(130, 93);
            this.button1.TabIndex = 1;
            this.button1.Text = "Логотип THC";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new Point(12, 169);
            this.button2.Name = "button2";
            this.button2.Size = new Size(130, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Абоненты";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new Point(12, 111);
            this.button3.Name = "button3";
            this.button3.Size = new Size(130, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Управление оборудованием";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new Point(12, 227);
            this.button4.Name = "button4";
            this.button4.Size = new Size(130, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "Активы";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new Point(12, 285);
            this.button5.Name = "button5";
            this.button5.Size = new Size(130, 52);
            this.button5.TabIndex = 5;
            this.button5.Text = "Биллинг";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new Point(12, 343);
            this.button6.Name = "button6";
            this.button6.Size = new Size(130, 52);
            this.button6.TabIndex = 6;
            this.button6.Text = "Поддержка пользователей";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new Point(12, 401);
            this.button7.Name = "button7";
            this.button7.Size = new Size(130, 52);
            this.button7.TabIndex = 7;
            this.button7.Text = "CRM";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new Point(157, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new Size(513, 342);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ФИО";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Абонентский номер";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Лицевой счёт";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Услуги";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // button8
            // 
            this.button8.Location = new Point(687, 139);
            this.button8.Name = "button8";
            this.button8.Size = new Size(141, 74);
            this.button8.TabIndex = 9;
            this.button8.Text = "Собрание менеджеров в 10:00";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new Point(687, 219);
            this.button9.Name = "button9";
            this.button9.Size = new Size(141, 74);
            this.button9.TabIndex = 10;
            this.button9.Text = "Отчёт по инвентаризации";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new Point(687, 299);
            this.button10.Name = "button10";
            this.button10.Size = new Size(141, 74);
            this.button10.TabIndex = 11;
            this.button10.Text = "Собрание акционеров 12:00";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new Point(687, 379);
            this.button11.Name = "button11";
            this.button11.Size = new Size(141, 74);
            this.button11.TabIndex = 12;
            this.button11.Text = "Отчёт по Адмиралтейскому району";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new Point(166, 459);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(93, 20);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Активные";
            this.checkBox1.UseVisualStyleBackColor = true;

            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new Point(289, 459);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Size(110, 20);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Неактивные";
            this.checkBox2.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(840, 484);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
