using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_form_test
{
    public partial class Form1 : Form
    {
        private TableLayoutPanel tableLayout;

        public Form1()
        {
            InitializeComponent();
            tableLayout = tableLayoutStart();
            this.Controls.Add(tableLayout);
        }

        private TextBox userTextBox()
        {
          TextBox textBox = new TextBox();

          return textBox;
        }

        private Button loginButton()
        {
          Button button = new Button();
          button.Height = 50;
          button.Width = 150;
          button.Text = "Login";
          button.Font = new Font("Comic Sans MS" , 12);
          button.BackColor = Color.Blue;
          button.ForeColor = Color.White; //text's color
          button.Padding = new Padding(6);

          return button;
        }

        private TableLayoutPanel tableLayoutStart()
        {
          TableLayoutPanel layout = new TableLayoutPanel();
          layout.BackColor = Color.Black; //debug position
          layout.Controls.Add(loginButton(), 0, 0);

          return layout;
        }

    }
}
