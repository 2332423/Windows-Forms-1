using System;
using System.Windows.Forms;

namespace laba_31
{
    public partial class Form1 : Form
    {
        // ����������� �����
        public Form1()
        {
            InitializeComponent(); // ������������� ����������� �� ���������

            // �������������� ������������� ��� �������������
            InitializeCustomComponents();
        }

        // ����� ��� �������������� ������������� �����������
        private void InitializeCustomComponents()
        {
            // ������ ���������� ��������� ���������� ����������
            var btn = new Button
            {
                Text = "����� ����",
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(100, 30)
            };
            btn.Click += Btn_Click;

            this.Controls.Add(btn);
        }

        // ���������� ������� ������
        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� ���������!");
        }

        // ������ ���������� ���������������� ������
        private void CustomMethod()
        {
            // ��� ��� �����
        }

        // �������������� ������ � ����������� �������...
    }
}