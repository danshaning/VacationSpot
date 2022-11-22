using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VacationSpot_ShaningA
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class VacationSpots
        {
            private string _place;
            private string _bestTime;
            private string _mustSee;
            private Image _vacPic;

            //ctor for Vacation spot

            //default ctor
            public VacationSpots () 
            {
               
            }

            //overload ctor
            public VacationSpots(string p, string b, string m, Image v) 
            {
                _place = p;
                _bestTime = b;
                _mustSee = m;
                _vacPic = v;
            }



            //***************PROPERTY BLOCKS**********
            public string p { get => _place; set => _place = value; }
            public string b { get => _bestTime; set => _bestTime = value; }
            public string m { get => _mustSee; set => _mustSee = value; }
            public Image v { get => _vacPic; set => _vacPic = value; }
        }

        //create an array to hold 7 Vacation Spots
        VacationSpots[] spot = new VacationSpots[7];
        int spotsCount = 0;



        private void Form1_Load(object sender, EventArgs e)
        {


            spot[0] = new VacationSpots("Zanzibar Island", "Anytime, its Africa!", "Prison Island, Stone Town", Image.FromFile("vacpic1.jpeg"));

            spot[1] = new VacationSpots("Greece", "Summer", "Mykonos, Santorini volcano", Image.FromFile("vacpic2.jpeg"));

            spot[2] = new VacationSpots("Norway", "Summer", "Pulpit rock, Lofoten Islands", Image.FromFile("vacpic3.jpg"));

            spot[3] = new VacationSpots("Benin Republic", "Anytime, its Africa!", "Kota Falls, Pendjari Park", Image.FromFile("vacpic4.jpeg"));

            spot[4] = new VacationSpots("US Hawai", "Summer", "Honolulu, Lanai, Maui", Image.FromFile("vacpic5.jpg"));

            spot[5] = new VacationSpots("Dubai", "Anytime", "Burj Khalifa tower, The Dubai Mall", Image.FromFile("vacpic6.jpeg"));

            spot[6] = new VacationSpots("Egypt", "Anytime, its Africa!", "Pyramids of Giza, Aswan town, Red sea", Image.FromFile("vacpic7.jpeg"));

            updateControls();

        }//end of Form load

        private void updateControls()
        {
            lbl_place.Text = "Place:\n"+ spot[spotsCount].p;
            lbl_bestTime.Text ="Best Time to go:\n" + spot[spotsCount].b;
            lbl_mustSee.Text = "Must absolutely See:\n" + spot[spotsCount].m;
            VacPicBox.Image = spot[spotsCount].v;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            spotsCount++;

            if (spotsCount == 6)
                btnForward.Enabled = false;

            if (btnBack.Enabled == false)
                btnBack.Enabled = true;

            updateControls();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            spotsCount--;

            if (spotsCount == 0)
                btnBack.Enabled = false;

            if (btnForward.Enabled == false)
                btnForward.Enabled = true;

            updateControls();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_bestTime_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAbt abt = new FormAbt();
            abt.Show();
        }
    }
}
