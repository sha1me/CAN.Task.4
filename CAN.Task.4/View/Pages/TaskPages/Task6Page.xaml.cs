using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._4.View.Pages.TaskPages
{
    public partial class Task6Page : Page
    {
        public Task6Page()
        {
            InitializeComponent();
        }

        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(TbN.Text);
                int M = Convert.ToInt32(TbM.Text);
                int K = 0, c = 0;
                for (int i = 0; i < N; i++)
                {
                    while (3*K <= i)
                    {
                        K++;
                        c++;
                    }
                }
                MessageBox.Show($"k = {K}, наименьшее целое = {c} ", "Системное сообщение",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information);
                TbN.Text = string.Empty;
                TbM.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
