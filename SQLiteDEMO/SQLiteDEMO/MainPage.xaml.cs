﻿using SQLite.Net.Attributes;
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

namespace SQLiteDEMO
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;


        public MainPage()
        {
            this.InitializeComponent();


            path = 
            Path.Combine
            (Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite"); 
            
            conn = 
            new SQLite.Net.SQLiteConnection
            (new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);

            conn.CreateTable<Customer>();
        }

        private void Retrieve_Click(object sender, RoutedEventArgs e)
        {
            var query = conn.Table<Customer>(); 
            string id = ""; 
            string name = ""; 
            string Phone_number = "";
            
            foreach (var message in query)
            {
                id = id + " " + message.Id;
                name = name + " " + message.Name;
                Phone_number = Phone_number + " " + message.Phone_number;
            }
            textBlock2.Text = "ID: " + id + "\nName: " + name + "\nPhone_number: " + Phone_number;
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var s = conn.Insert(new Customer()
            {
                Name = textBox.Text,
                Phone_number = textBox1.Text
            });
        }


        private void lv_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(TheSearch));
        }



        public class Customer
        {
            [PrimaryKey, AutoIncrement] public int Id { get; set; }
            public string Name { get; set; }
            [Unique] public string Phone_number { get; set; }
        } 

    }


}
