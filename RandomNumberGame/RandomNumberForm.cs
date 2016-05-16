using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGame
{//begin game
    public partial class RandomNumberForm : Form
    {//begin form
        int guessCount = 0;
        //Initialize the variable guessCount to 0, as no guesses have been made yet.
        int randomNumber;
        //Initialize randomNumber variable.
        int userInput;
        //Initialize userInputVariable
        Random random = new Random();
        //Initialize random variable.
        public RandomNumberForm()
        {
            InitializeComponent();
            //Initialize the components of the form.
            randomNumber = random.Next(1, 100);
            //Choose a random number for the game.
        }

        private void btnSubmit_Click(object sender, EventArgs e)
            //When the submit button is clicked..
        {
            try
                //Try the following
            {
                guessCount++;
                //Increase guess number by one, as the submit button is how we'll count the number of guesses.
                userInput = int.Parse(txtUserInput.Text);
                //Convert the user input to a variable that we can compare against.
                if (userInput == randomNumber)
                    //If the user input is the same as our random number..
                {
                    lblResult.Text = "You chose the correct number! It was indeed "+ randomNumber+"!";
                    //Change the result label's text to the appropriate message
                    randomNumber = random.Next(1, 100);
                    //Choose a new random number
                    lblNumGuesses.Text = "Number of Guesses:"; 
                    lblNumGuessesResult.Text = guessCount.ToString();
                    //Change the guess count labels to the correct messages.
                    guessCount = 0;
                    //Reset the guess count
                }//end if correct
                else if (userInput > randomNumber && userInput < 100 && userInput > 0)
                    //If the user input was in range and is higher than the random number
                {
                    lblResult.Text = "Your guess was too high!";
                    //Display the appropriate message
                }//end else if higher
                else if (userInput < randomNumber && userInput < 100 && userInput > 0)
                //If the user input was in range and is lower than the random number..
                {
                    lblResult.Text = "Your guess was too low!";
                    //Display the appropriate message.
                }//end else if lower
                else if (userInput < 0 || userInput > 100)
                    //If the user input was out of range..
                {
                    MessageBox.Show("Please enter a valid, non-negative whole number between 1 and 100.");
                    //Prompt the user for another guess.
                    if (guessCount > 0)
                    {//begin if the guesscount is greater than zero
                        guessCount--;
                        //subtract the invalid guess
                    }//end if
                    else
                    {//begin else
                        guessCount = 0;
                        //reset the guess count to 0
                    }//end else
                    //Subtract the invalid guess from the total guess count, or keep it at 0 if no guess has been made prior.
                }//end else if
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(txtUserInput.Text))
                    //If the user input is null..
                {
                    MessageBox.Show("You must enter a valid guess in order to play.  Please enter a valid, non-negative whole number between 1-100");
                    //Display an appropriate error message
                    if (guessCount > 0)
                    {//begin if the guesscount is greater than zero
                        guessCount--;
                        //subtract the invalid guess
                    }//end if
                    else
                    {//begin else
                        guessCount = 0;
                        //reset the guess count to 0
                    }//end else
                    //Subtract the invalid guess from the total guess count, or keep it at 0 if no guess has been made prior.                
                }//end blank user input error
                else
                    //If any other error is caught
                {
                    MessageBox.Show("Error Message: " + ex);
                    //Display the error message so we can figure out what to do with it.
                    if (guessCount > 0)
                    {//begin if the guesscount is greater than zero
                        guessCount--;
                        //subtract the invalid guess
                    }//end if
                    else
                    {//begin else
                        guessCount = 0;
                        //reset the guess count to 0
                    }//end else
                    //Subtract the invalid guess from the total guess count, or keep it at 0 if no guess has been made prior.
                }//end any other error
            }//end catch
        }

        private void btnNewNumber_Click(object sender, EventArgs e)
        {   //If the New Number button is clicked..
            guessCount = 0;
            //Set the guess count to 0.  With a new number, we should have a new count.
            randomNumber = random.Next(0, 100);
            //Pick a new random number.
            lblResult.Text = "";
            //Clear the result label.
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
            //If the user clicks the Give Up button..
        {
   lblResult.Text = "Your random number was " + randomNumber+".";
            //Let them know what the number was
            //Don't clear anything, because..  we wanted to be nice and let someone have a win.
            //Also don't change the random number, because they haven't asked us to explicitly. New Number
            //button exists for that purpose.
        }

        private void txtUserInput_KeyPress(object sender, KeyPressEventArgs e)//On keypress within the user input text box
        {
            //Allow control characters, e.g. backspace
            if (Char.IsControl(e.KeyChar)) return;
            //Allow numbers, but not letters.
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Please enter a valid, non-negative whole number between 1 and 100.");
                e.KeyChar = (char)0;
            }//end allow numbers, not letters
        }//end keypress
    

    }//end form
}//end game
