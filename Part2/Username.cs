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
{
    public class Username
    {

        public string Submit_name(TextBox Username, ListView chats)
        {//start of

            //temp variables 
            string fn = "Username.txt";

            //check if the filename exists or not , then auto create
            if (!File.Exists(fn))
            {
                //auto create the file using AppendAllText() function
                File.AppendAllText(fn, "auto_create\n");

            }//end 

            //temp variables
            string name = Username.Text.ToString();
            bool found = check_name(name);

            //check if the user is found or not and write the name in a text file
            if (!found)
            {//start of if
                //write the name in a text file
                File.AppendAllText(fn, name + "\n");
                //then welcome the user
                error_method("PBot:", "Hello " + name + " Welcome to the Cybersecurity Awareness Bot. How can I assist you with cybersecurity today?. ", chats);

            }//end of if
            else
            {//start of else

                //welcome the user back
                error_method("PBot:", "Hello " + name + " welcome back, how can I assist you with cybersecurity today?", chats);

            }//end of else


            //return name
            return name;



        }//end of

        //method to check name of the user
        private Boolean check_name(string name)
        {//start

            //temp variable
            string fn = "Username.txt";

            bool found_name = false;


            //store or get all the names in the text file and store in an 1D array
            string[] names = File.ReadAllLines(fn);

            //foreach to search the name of the user
            foreach (string name_found in names)
            { //start of loop

                //if statement to check for the username
                if (name_found.ToLower() == name.ToLower())
                {//start if

                    //found_name set to true
                    found_name = true;

                }//end of if

            }//end of the loop





            //return the status of found or not [ true or false ]
            return found_name;

        }//end check method



        //error method
        private void error_method(string name, string message, ListView chats)
        {//star of error mehtod

            // Create a border for chats
            Border messageBorder = new Border
            {
                Margin = new Thickness(0, 2, 0, 2),
                Padding = new Thickness(5, 3, 5, 3),
                CornerRadius = new CornerRadius(5)
            };

            // Set different background for user vs bot
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

            // Set color based on sender
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




    }

}

