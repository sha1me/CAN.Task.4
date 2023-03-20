﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._4.View.Pages.TaskPages
{
    public partial class Task13Page : Page
    {
        public Task13Page()
        {
            InitializeComponent();
        }

        private void BtnTask13_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double X = Convert.ToDouble(TbX.Text);
                int N = Convert.ToInt32(TbN.Text);
                double a = 1;
                if (N > 0)
                {
                    for (int i = 0; i <= N; i += 2)
                    {
                        a += -1 * i * Math.Pow(X, i * i) / 2 * i;
                    }
                    MessageBox.Show($" Произведение = {a}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                if (N < 0)
                    MessageBox.Show($"Число N не может быть отрицательным", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);

                TbN.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
