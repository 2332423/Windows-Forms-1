using System;
using System.Windows.Forms;

namespace SeriesCalculation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void trackBarN_Scroll(object sender, EventArgs e)
        {
            lblN.Text = $"Значение n: {trackBarN.Value}";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int n = trackBarN.Value;

            // Вычисление циклом
            long cycleSum = 0;
            for (int i = 1; i <= n; i++)
            {
                long term = 2 * i - 1;
                cycleSum += term * term;
            }

            // Вычисление по формуле
            long formulaSum = n * (4 * n * n - 1) / 3;

            // Вывод результатов
            tbCycleResult.Text = cycleSum.ToString("N0");
            tbFormulaResult.Text = formulaSum.ToString("N0");

            // Сравнение результатов
            lblComparison.Text = cycleSum == formulaSum
                ? "Результаты совпадают!"
                : "Ошибка! Результаты не совпадают!";
        }
    }
}