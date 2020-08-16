using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revolver_assignment_1
{
   public class fire
    {
        //instance of the random class
        Random obj = new Random();
        //array that is used to store the random no
        int[] trig = new int[2];

        int shotCunt = 0, shotAwayCount = 0;

        //flag to start the game 
        public int start(PictureBox photo) {
            //load the photo in  the picture box
            photo.Image = Revolver_assignment_1.Properties.Resources.revolver1;
            return 1;
        }

        //flag to Load the bullet with guns
        public int Load(PictureBox photo)
        {
            //generate the random no to fire 
            trig[0] = obj.Next(1, 6);
            trig[1] = obj.Next(1, 4);
            //load the photo in  the picture box
            photo.Image = Revolver_assignment_1.Properties.Resources.revolver2;
            return 1;
        }

        //flag to spin the game 
        public int spin(PictureBox photo)
        {
            //load the photo in  the picture box
            photo.Image = Revolver_assignment_1.Properties.Resources.revolver3;
            return 1;
        }

        // flag to shoot the trigger have 4 bullet to shoot 
        public int shoot(Button btn) {
            shotCunt++;
            //genreate the sound of the bullet 
            System.Media.SoundPlayer Sound = new System.Media.SoundPlayer(Revolver_assignment_1.Properties.Resources.fire);
            Sound.Play();

            if (shotCunt == trig[0])
            {
                MessageBox.Show("Sorry you lose the game ");
                btn.Enabled = false;
                return 1;
            }
            else if (shotCunt == 4)
            {
                MessageBox.Show("Hurry you won the game and got 1000 Marks ");
                btn.Enabled = false;
                return 1;
            }
            else
            {
                return 0;
            }
        }
        // flag to shoot the trigger have 4 bullet to shoot 
        public int shootAway(Button btn)
        {
            //genreate the sound of the bullet 
            System.Media.SoundPlayer Sound = new System.Media.SoundPlayer(Revolver_assignment_1.Properties.Resources.fire);
            Sound.Play();

            shotAwayCount++;
            if (shotAwayCount == trig[1])
            {

                MessageBox.Show("Sorry you lose the game ");
                btn.Enabled = false;
                return 1;
            }
            else if (shotAwayCount == 2)
            {
                MessageBox.Show("Hurry you won the game and got 1000 Marks ");
                btn.Enabled = false;
                return 1;
            }

            else {

                return 0;
            }
            
        }

    }
}
