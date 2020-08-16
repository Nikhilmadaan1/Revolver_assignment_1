using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revolver_assignment_1
{
    public partial class Form1 : Form
    {
        // intance of the fire class
        fire obj = new fire();
        public Form1()
        {
            InitializeComponent();
            //disable the trigger untill we start the game 
            loadBtn.Enabled = false;
            spinButton.Enabled = false;
            shootBtn.Enabled = false;
            ShotAwayBtn.Enabled = false;

        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            //if flag is active then load buton enalbe to fire 
            if (obj.start(GunBox)==1) {
                loadBtn.Enabled = true;
                startbtn.Enabled = false;
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            //if flag is active then load the bullet and roller will ative 
            if (obj.Load(GunBox) == 1)
            {
                loadBtn.Enabled = false;
               spinButton.Enabled =true;
            }
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            //if flag is active then enable the spinner to roller the  gun 
            if (obj.start(GunBox) == 1)
            {

                spinButton.Enabled = false;
                shootBtn.Enabled = true;
                ShotAwayBtn.Enabled = true;
            }
        }

        private void shootBtn_Click(object sender, EventArgs e)
        {
            //trigger the gun 
            if (obj.shoot(shootBtn)==1)
            {
                startbtn.Enabled = true;

            } 
         
        }

        private void ShotAwayBtn_Click(object sender, EventArgs e)
        {

            //trigger the gun 
            if (obj.shootAway(ShotAwayBtn) == 1)
            {
                startbtn.Enabled = true;

            }
            
        }
    }
}
