﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._4.View.Pages.TaskPages
{
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(TbA.Text);
                int N = Convert.ToInt32(TbN.Text);
                double c = 1, d = 1;
                for(int i = 1; i <= N; i++) 
                { 
                    c += A*i;
                    if(i % 2 != 0)
                    {
                        d += -1*A*i;
                    }
                    else 
                    {
                        d += A * i;
                    }
                }
                MessageBox.Show($"Сумма1 = {c}, Сумма2 = {d}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                if (N < 0)
                    MessageBox.Show($"Число N не может быть отрицательным", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);

                TbA.Text = string.Empty;
                TbN.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
