using Syncfusion.WinForms.Core;
using Syncfusion.WinForms.ListView;
using Syncfusion.WinForms.ListView.Enums;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace SfComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Data Setting 

        List<State> GetData()
        {
            List<State> states = new List<State>();
            states.Add(new State("Alaska", "AK"));
            states.Add(new State("Arizona", "AZ"));
            states.Add(new State("Colorado", "CO"));
            states.Add(new State("Connecticut", "CT"));
            states.Add(new State("Delaware", "DE"));
            states.Add(new State("Florida", "FL"));
            states.Add(new State("Georgia", "GA"));
            states.Add(new State("Hawaii", "HI"));
            states.Add(new State("Idaho", "ID"));
            states.Add(new State("Illinois", "IL"));
            states.Add(new State("Indiana", "IN"));
            states.Add(new State("Iowa", "IA"));
            states.Add(new State("Kansas", "KA"));
            return states;
        }

        public class State
        {
            private string shortName;
            private string longName;

            public State(string LongName, string ShortName)
            {
                this.longName = LongName;
                this.shortName = ShortName;
            }

            public string ShortName
            {
                get { return shortName; }
            }

            public string LongName
            {
                get { return longName; }
            }
        }
        #endregion
    }
}