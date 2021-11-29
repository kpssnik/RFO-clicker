using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFO_Clicker
{
    public static class Clicker
    {
        // WinApi методы 
  
        [DllImport("user32.dll", SetLastError = true)]
        // Для установки фокуса на окно, принимает процесс через process.MainWindowHandle
        private static extern int SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        // Метод нажатия кнопки, bVK - код кнопки. bScan dwExtraInfo по нулям. dwFlags (1 - нажать. 2 - отпустить)
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        //////////////////////////////////////////////////////////

        // Флаг, запущен ли процесс кликинга
        public static bool IsActivated { get; set; } = false;

        // Флаг, закрыто ли главное окно. Служит для остановки потока кликинга
        public static bool IsMainFormClosed { get; set; } = false;

        //////////////////////////////////////////////////////////

        // Фокус на нужном окне, в котором надо кликать
        public static void FocusOnTargetWindow()
        {
            Process targetProcess = Process.GetProcessesByName(Config.TargetProcessName).FirstOrDefault();

            if(targetProcess == null)
            {
                MessageBox.Show($"Процес {Config.TargetProcessName} не найден. Запустите приложение и попробуйте еще раз.");
                return;
            }

            // Фокус на окно таргет процесса, задержка секунда на открытие
            SetForegroundWindow(targetProcess.MainWindowHandle);
            Thread.Sleep(1000);
        }

        public static void StartClicking()
        {
            IsActivated = true;

            // Для генерации случайного интервала между нажатиями
            Random random = new Random();

            // Пока активирован кликер и не закрыта форма
            while (IsActivated && !IsMainFormClosed)
            {
                // Нажималки, параметры описаны комментариями в объявлении функции выше
                keybd_event((byte)Config.PressButton, 0, 1, 0);
                keybd_event((byte)Config.PressButton, 0, 2, 0);

                // Пауза между нажатиями
                int waitTime = random.Next(Config.IntervalMinTime, Config.IntervalMaxTime);

                Thread.Sleep(waitTime);
            }
        }

        public static void StopClicking()
        {
            // Как только флаг станет false, цикл кликинга завершится
            IsActivated = false;
        }

    }
}
