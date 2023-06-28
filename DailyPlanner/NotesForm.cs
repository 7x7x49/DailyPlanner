using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyPlanner
{
    public partial class NotesForm : Form
    {
        private SQLiteConnection connection;
        private static string logFile = "log.txt";
        public NotesForm(string taskDate)
        {
            InitializeComponent();

        }



    }
}
