﻿using AJ8AND.Models;
using AJ8AND.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AJ8AND
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public List<TodoItem> Todos { get; set; } = new List<TodoItem>()
 {
 new TodoItem()
 {
 Id = 1,
 Title = "Buy milk",
 Description = "If it’s egg, then buy 10! ",
 Priority = Priority.Normal,
 IsDone = true,
 Deadline = DateTimeOffset.Now + TimeSpan.FromDays(1)
 },
 new TodoItem()
 {
 Id = 2,
 Title = "Write the dissertaion",
 Description = "At least 40 pages, with many nice screenshots",
 Priority = Priority.High,
 IsDone = false,
 Deadline = new DateTime(2017, 12, 08, 12, 00, 00, 00)
 }
 };


        public MainPage()
        {
            this.InitializeComponent();
            DataContext = this;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TodoDetailsPage), null);
        }



    }
}
