﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursach
{
    public class QuestionData
    {
        public int[] id = new int[Program.AmountOfQuestion];
        public string[] question = new string[Program.AmountOfQuestion];
        public List<string[]> variant = new List<string[]> { new string[Program.AmountOfQuestion],
         new string[Program.AmountOfQuestion],  new string[Program.AmountOfQuestion], new string[Program.AmountOfQuestion]};      
        public int[] correct = new int[Program.AmountOfQuestion];
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
        static public int AmountOfQuestion { get; private set ; } = 10;
        static int number = 5;
        static  int themenumber = 0;
        //возвращает количество тем в самой программе
        static public int AmountOfTheme { get => number;  /*set => number = value;*/ }
        //дает номер темы, которая выбрана в main
        static public int ThemeNumber
        {
            set
            {
                if (value < 1 || value > number)
                {
                    Console.WriteLine("Wrong numbertheme was send");
                    return;
                }
                else
                    themenumber = value;
            }
            get
            {
                return themenumber;
            }
        }
    }
}

/// <summary>
/// MyData For using SqlReader, is not usable>
/// </summary>
//    class MyData
//    {
//        public int id { get; set; }
//        public string question { get; set; }
//        public string variant1 { get; set; }
//        public string variant2 { get; set; }
//        public string variant3 { get; set; }
//        public string variant4 { get; set; }
//        public int correct { get; set; }
//    }
////////////////////////////////
/// ///////////////////////////////////
////Using Mysqldatareader to get rows into MyData Class
//MySqlCommand command = connection.CreateCommand();
//command.CommandText = cmd;
//var Data = new List<MyData>();
//using (MySqlDataReader reader = command.ExecuteReader())
//{
//    while (reader.Read())
//    {
//        Data.Add(new MyData
//        {
//            id = reader.GetInt32(reader.GetOrdinal("Id")),
//            question = reader.GetString(reader.GetOrdinal("Question")),
//            variant1 = reader.GetString(reader.GetOrdinal("Variant1")),
//            variant2 = reader.GetString(reader.GetOrdinal("Variant2")),
//            variant3 = reader.GetString(reader.GetOrdinal("Variant3")),
//            variant4 = reader.GetString(reader.GetOrdinal("Variant4")),
//            correct = reader.GetInt32(reader.GetOrdinal("Correct")),
//        });
//    }
//}
//////////////////////////////////////////////////////
///////////Convert Table into string array(just function)
//string[] arrray = ViewTable.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
/////////////////////////////////////