using System;
using System.Windows.Forms;

namespace laba_31
{
    public partial class Form1 : Form
    {
        // Конструктор формы
        public Form1()
        {
            InitializeComponent(); // Инициализация компонентов из дизайнера

            // Дополнительная инициализация при необходимости
            InitializeCustomComponents();
        }

        // Метод для дополнительной инициализации компонентов
        private void InitializeCustomComponents()
        {
            // Пример добавления элементов управления программно
            var btn = new Button
            {
                Text = "Нажми меня",
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(100, 30)
            };
            btn.Click += Btn_Click;

            this.Controls.Add(btn);
        }

        // Обработчик события кнопки
        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Действие выполнено!");
        }

        // Пример добавления пользовательской логики
        private void CustomMethod()
        {
            // Ваш код здесь
        }

        // Дополнительные методы и обработчики событий...
    }
}