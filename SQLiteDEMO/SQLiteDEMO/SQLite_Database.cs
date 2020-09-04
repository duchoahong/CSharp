﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDEMO
{
    class SQLite_Database
    {
        string path =
        Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path,
        "db.sqlite");
        SQLite.Net.SQLiteConnection conn = new SQLite.Net.SQLiteConnection(new
        SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);

        conn.CreateTable<Customer>(); 

        conn.Insert(new Customer()
        {
            Name = textBox.Text, 
            Phone_number = textBoxl.Text
        }); 


        
        var query = conn.Table<Customer>();
        string id = ""; 
        string name = "";
        string Phone_number= "";

        string question = "";
        string mark = "";
        



        foreach (var message in query) { 
            id = id + " " + message.Id; 
            name = name + " " + message.Name; 
            Phone_number = Phonenumber + " " + message.Phone_number; 

            string question = "" + message.Question;
            string mark = "" + message.Mark;


    }
}
