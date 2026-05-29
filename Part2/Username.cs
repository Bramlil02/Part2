using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Part2
{//start of namespace
    public class Username
    {//start of class

        public string Submit_name(TextBox Username, ListView chats)
        {//start of method

            //temp variable for the filename 
            string fn = "Username.txt";

            //if the file does not exist then create the file and write auto_create in the file
            if (!File.Exists(fn))
            {
                //if the file does not exist then create the file and write auto_create in the file
                File.AppendAllText(fn, "auto_create\n");

            }//end 

            //temp variables
            string name = Username.Text.ToString();
            bool found = check_name(name);

            //if the name is not found then write the name in the text file and welcome the user
            if (!found)
            {//start of if

                //if the name is not found then write the name in the text file
                File.AppendAllText(fn, name + "\n");

                //if the name is not found then welcome the user
                error_method("PBot:", "Hello " + name + " Welcome to the Cybersecurity Awareness Bot. How can I assist you with cybersecurity today?. ", chats);

            }//end of if
            else
            {//start of else

                //if the name is found then welcome the user back
                error_method("PBot:", "Hello " + name + " welcome back, how can I assist you with cybersecurity today?", chats);

            }//end of else


            //return name
            return name;



        }//end of

        //method to check the name of the user in the text file
        private Boolean check_name(string name)
        {//start

            //temp variable for the filename
            string fn = "Username.txt";

            //boolean variable to check if the name is found or not
            bool found_name = false;


            //store or get all the names in the text file and store in an 1D array
            string[] names = File.ReadAllLines(fn);

            //foreach to search the name of the user
            foreach (string name_found in names)
            { //start of loop

                //if statement to check for the username
                if (name_found.ToLower() == name.ToLower())
                {//start if

                    //if the name is found then change the value of found_name to true
                    found_name = true;

                }//end of if

            }//end of the loop




            //return the value of found_name
            return found_name;

        }//end check method


        //method to display the message in the chatbox
        private void error_method(string name, string message, ListView chats)
        {//star of error mehtod

            //create a border for the message
            Border messageBorder = new Border
            {
                Margin = new Thickness(0, 2, 0, 2),
                Padding = new Thickness(5, 3, 5, 3),
                CornerRadius = new CornerRadius(5)
            };

            // Set different background and border colors for user vs bot
            if (name.ToLower().Contains("pbot") || name.ToLower().Contains("chat"))
            {// Sea Green
                messageBorder.Background = new SolidColorBrush(Color.FromRgb(46, 139, 87));
                messageBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(34, 120, 87));
            }
            else
            {    // Light Blue
                messageBorder.Background = new SolidColorBrush(Color.FromRgb(173, 216, 230));
                messageBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(135, 206, 235));
            }
            messageBorder.BorderThickness = new Thickness(1);

            TextBlock messageText = new TextBlock
            {
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(2)
            };

            // Set different text color for user vs bot
            Brush nameColor = (name.ToLower().Contains("pbot") || name.ToLower().Contains("chat")) ?
                              Brushes.LightSkyBlue : Brushes.DarkGray;

            Brush messageColor = Brushes.Black;

            messageText.Inlines.Add(new Run
            {
                Text = name + ": ",
                Foreground = nameColor,
                FontWeight = FontWeights.Bold
            });

            messageText.Inlines.Add(new Run
            {
                Text = message,
                Foreground = messageColor
            });

            messageBorder.Child = messageText;
            chats.Items.Add(messageBorder);

        }//end of error method




    }//end of class

}//end of namespace

