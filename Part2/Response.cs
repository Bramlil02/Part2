using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{//start of namespace
    public class Response
    {//start of class

        public Response(ArrayList reply, ArrayList ignore)
        {//start of constructor

            //call the methods to fill the lists
            answers(reply);
            words(ignore);

        }//end of constructor
        private void words(ArrayList ignoring)
        {//start of method

            //add words to ignore list
            ignoring.Add("hi");
            ignoring.Add("whats up");
            ignoring.Add("Heyyyyyy");
            ignoring.Add("Whats good");
            ignoring.Add("hello");
            ignoring.Add("Sup");
            ignoring.Add("dope");

        }
        public void answers(ArrayList answers)
        {//start of method

            //add responses to the answer list
            answers.Add("Im good how are you.");
            answers.Add("You can ask me about passwords, phishing, and safe browsing.");
            answers.Add("Thats good to hear! How can I assist you with cybersecurity today?");
            answers.Add("My purpose is to teach you about cybersecurity and how to stay safe online.");
            answers.Add(" Use strong password with letters, numbers, and symbols. Never share your password!");
            answers.Add("Phishing is when attackers trick you into giving personal info. Always check emails and links carefully.");
            answers.Add("Only visit secure websites (https://) and avoid clicking suspicious links.");
            answers.Add("Sorry, I dont understand.Could you repharse? or just stick to cybersecurity topics.");


            

            //sentimated responses for different emotions

            answers.Add("frustrated i understand you're frustrated. let's work through the issue step by step.");
            answers.Add("frustrated it's okay to feel frustrated when things aren't working. i'm here to help.");
            answers.Add("frustrated take a breath, we'll fix this together.");


            answers.Add("confused that's okay, confusion is normal. i'll explain it clearly for you.");
            answers.Add("confused let me break it down step by step so it makes sense.");
            answers.Add("confused no worries, i'll help you understand it better.");


            answers.Add("worried it's okay to feel worried. i'm here to help you stay safe online.");
            answers.Add("worried don't panic, most cybersecurity issues can be fixed quickly.");
            answers.Add("worried i understand your concern. let's make sure your information is safe.");


            answers.Add("happy that's great to hear! i'm glad things are going well.");
            answers.Add("happy awesome! positivity is always good.");
            answers.Add("happy i'm happy for you! let me know if you need anything.");


            answers.Add("sad i'm sorry you're feeling this way. i'm here for you.");
            answers.Add("sad that sounds tough, take things one step at a time.");
            answers.Add("sad i hope things improve soon. you can talk to me anytime.");


            answers.Add("angry i understand you're angry. let's try solve the issue together.");
            answers.Add("angry it's okay to feel angry, but i'll help you fix the problem.");
            answers.Add("angry take your time, i'm here to help you sort it out.");



        }//end of method
    }//end of class
}//end of namespace