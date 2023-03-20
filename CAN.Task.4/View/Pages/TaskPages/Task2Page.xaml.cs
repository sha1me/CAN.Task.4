using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._4.View.Pages.TaskPages
{
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(TbA.Text);
                int B = Convert.ToInt32(TbB.Text);
                int N = 0;
                A += 1;
                for (int i = A; i < B; i++)
                {
                    N += 1;
                }
                MessageBox.Show($"Количество чисел = {N}", "Системное сообщение",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information);
                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
