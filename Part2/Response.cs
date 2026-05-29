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

            //greeting 
            answers.Add("Im good how are you.");
            
            //Topics to discuss
            answers.Add("You can ask me about passwords, phishing, and safe browsing.");
            
            //default response
            answers.Add("Sorry, I dont understand.Could you repharse? or just stick to cybersecurity topics.");
            
            //purpose of Cyber awareness bot
            answers.Add("purpose my purpose is to educate you on how to stay safe online and guide your cybersecurity questions.");
            answers.Add("purpose i help users understand online safety and digital protection.");
            answers.Add("purpose i assist with cybersecurity awareness and safety guidance.");

            //cybersecurity related responses
            answers.Add("cybersecurity cybersecurity is about protecting systems and networks from digital threats.");
            answers.Add("cybersecurity it involves protecting devices and online accounts from attacks.");
            answers.Add("cybersecurity it focuses on securing digital information and systems.");
            
            //phishing
            answers.Add("phishing phishing is a scam where attackers pretend to be trusted sources to steal information.");
            answers.Add("phishing it uses fake messages or websites to trick users into revealing sensitive data.");
            answers.Add("phishing attackers use deception to make users believe they are legitimate.");
            
            //firewall
            answers.Add("firewall a firewall controls network traffic based on security rules.");
            answers.Add("firewall it helps block unwanted access to your device or network.");
            answers.Add("firewall it acts as a protective barrier between trusted and untrusted networks.");
            
            //password
            answers.Add("password a password is used to secure access to your accounts or devices.");
            answers.Add("password it should be strong, long and not easy to guess.");
            answers.Add("password avoid using personal details when creating one.");
            
            //hacked account
            answers.Add("hacked account immediately secure your account and log out of all devices.");
            answers.Add("hacked account contact support if your account has been compromised.");
            answers.Add("hacked account enable extra security like two-factor authentication.");
            
            //fraud
            answers.Add("fraud contact your bank immediately if fraud is detected.");
            answers.Add("fraud report suspicious financial activity to the authorities.");
            answers.Add("fraud monitor your accounts for unusual activity.");
            
            //malicious Cyber awareness bot
            answers.Add("malicious Cyber awareness bot malicious bots often create urgency to trick users.");
            answers.Add("malicious Cyber awareness bot fake chatbots may ask for sensitive information.");
            answers.Add("malicious Cyber awareness bot be cautious if a bot pressures you for personal data.");
            
            //vpn
            answers.Add("vpn a vpn helps protect your privacy on public wi-fi.");
            answers.Add("vpn it encrypts your internet traffic for safety.");
            answers.Add("vpn it improves security when using public networks.");

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