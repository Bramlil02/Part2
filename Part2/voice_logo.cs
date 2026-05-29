using System;
using System.Drawing;
using System.Media;

namespace Part2
{//start of namespace
    public class voice_logo
    {//start of class
        public void greet()
        { //star of greet method

            //get the path of the audio file
            string auto_path = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", @"/greet.wav");

            //create an instance for the soundPlayer class
            SoundPlayer greetMe = new SoundPlayer(auto_path);
            //then greet
            greetMe.Play();
            

        }//end of greet method



    }//end of class
}//end of namespace
    

