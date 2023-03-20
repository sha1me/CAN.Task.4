﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._4.View.Pages.TaskPages
{
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }
        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(TbA.Text);
                int N = Convert.ToInt32(TbN.Text);
                    MessageBox.Show($" A в степени N= {Math.Pow(A,N)}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                if(N < 0)
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