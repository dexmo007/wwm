using System;
using System.Data;
using System.Data.OleDb;

namespace WerWirdMillionaer
{
    public class QstnUtil
    {
        private static readonly OleDbConnection Connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\qstnDB.accdb;Persist Security Info = False;");
        private static readonly OleDbCommand Command = Connection.CreateCommand();

        private const string Columns =
            "question_text, correct_answer, false_answer1, false_answer2, false_answer3, gewinnstufe";

        public static void AddQuestion(Question qstnData)
        {
            

            try
            {
                Command.CommandText =
                    "INSERT INTO Question (" + Columns + ") " + "VALUES(" + qstnData + ")";
                Command.CommandType = CommandType.Text;
                Connection.Open();
                Command.ExecuteNonQuery();
            }
            finally
            {
                Connection?.Close();
            }
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public string Correct { get; set; }
        public string False1 { get; set; }
        public string False2 { get; set; }
        public string False3 { get; set; }
        public int Gewinnstufe { get; set; }

        public override string ToString()
        {
            return "'" + Text + "','" + Correct + "','" + False1 + "','" + False2 + "','" + False3 + "'," + Gewinnstufe;
        }
    }
}
