using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFO_Clicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Заполняю выбиралку клавишами от F1 до F12
            for (int i = 112; i <= 123; i++)
            {
                this.pressButtonPicker.Items.Add((Keys)i);
            }

            SetConfigValuesToForm();
        }


        private void startClickingButton_Click(object sender, EventArgs e)
        {
            if (Clicker.IsActivated)
            {
                MessageBox.Show("Кликер уже запущен");
                return;
            }

            UpdateConfig();

            Clicker.FocusOnTargetWindow();

            Thread clickingThread = new Thread(new ThreadStart(Clicker.StartClicking));
            clickingThread.Start();
        }
        private void stopClickingButton_Click(object sender, EventArgs e)
        {
            Clicker.StopClicking();
        }

        // Проверка при вводе значения в интервал. В случае что-то что не цифра - очищать поле
        private void intervalTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                int temp;

                if (!int.TryParse(textBox.Text, out temp))
                {
                    textBox.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Неизвестная ошибка при интерпритации interval textbox");
            }
        }


        public void UpdateConfig()
        {
            if (pressButtonPicker.SelectedItem != null)
            {
                Config.PressButton = (Keys)pressButtonPicker.SelectedItem;
            }

            try
            {
                Config.IntervalMinTime = int.Parse(intervalMinTimeTextBox.Text);
                Config.IntervalMaxTime = int.Parse(intervalMaxTimeTextBox.Text);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Некорректные данные в диапазоне. Только числа");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неизвестная ошибка при парсинге интервала \n\n {ex.Message}");
            }
        }
        public void SetConfigValuesToForm()
        {
            intervalMinTimeTextBox.Text = Config.IntervalMinTime.ToString();
            intervalMaxTimeTextBox.Text = Config.IntervalMaxTime.ToString();

            pressButtonPicker.SelectedItem = Config.PressButton;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clicker.IsMainFormClosed = true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clicker.IsMainFormClosed = true;
        }
    }
}
