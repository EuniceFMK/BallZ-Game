using GDIDrawer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Eunice_Fmukam_Lab3
{
   
    public partial class Form1 : Form
    {
        const int height = 600;                        //Constant for the width of the window
        const int width = 800;                        //Constant for the size of the window

        const int size = 50;                        //Constant for the ball's size

        const int col = width / size;               //Constant for columns
        const int row = height / size;             //constant for rows

        private enum eState { alive, dead };            //enum for the state of the objects screen

        int score = 0;                        //Variable to keep track of the player's score
        CDrawer canvas;

        public int DropDelay = 100;            //Variable to control the drop delay of the balls

        string highScoreName = "";             //Variable to store the player's name for high score
        bool gameOver = false;                 //Variable to check if the game is over

        private struct Ball                      //Struct to represent each ball
        {
            public Color bColor;
            public eState bState;
        }

        private Ball[,] ballArray = new Ball[row, col];       //2D array to hold the balls
        public int mode;                                      //Variable to hold the difficulty mode
        Random rnd = new Random();                            //Random number generator 
        public List<Color> ListColors = new List<Color>();   // List to hold colors for the balls


        UI_SelectDifficulty_ModelessDialog diffmodedlg = null;    // Difficulty selection dialog
        UI_AnimationSp_ModelessDialogForm animDlg = null;        // Animation speed dialog
        UI_Score_ModelessDialogForm scoreDlg = null;               // Score display dialog

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "CMPE1666 Lab3 - Ballz";      // Set the title of the window
            if (canvas == null)
                canvas = new CDrawer(width, height, true);        // Initialize the drawing canvas

            if (!File.Exists("highscores.txt"))                   
                File.WriteAllText("highscores.txt", "");           // Create the high score file if it doesn't exist
        }

        /// <summary>
        /// Event handler for the Play button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Play_Btn_Click(object sender, EventArgs e)
        {
            score = 0;               // Reset score
            gameOver = false;       // Reset game over flag

            if (diffmodedlg == null)
            {
                diffmodedlg = new UI_SelectDifficulty_ModelessDialog();       // Initialize difficulty selection dialog
                diffmodedlg._delm = new DelMode(diffmode);                     // Set delegate for difficulty selection
            }

            if (diffmodedlg.ShowDialog() == DialogResult.OK)
            {               
                canvas.Clear();                               // Clear the canvas
                UI_Timer_Tim.Start();                        // Start the game timer
                Randomize(ballArray, row, col);             // Randomize the balls
                Display();                                 // Display the balls
                UI_Play_Btn.Enabled = false;              // Disable the Play button
            }           
                
            if (animDlg != null)
                animDlg._delDelay = new delUpdateSlip(this.UpdateDropDelay);   //   Set delegate for animation speed update

        }

        /// <summary>
        /// difficulty mode setter
        /// </summary>
        /// <param name="i">the integer which represents the number of balls colors</param>
        public void diffmode(int i)
        {
            mode = i;             // Set the difficulty mode
        }

        /// <summary>
        /// Event handler for the Show Score checkbox state change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_ShowScore_Chbx_CheckedChanged(object sender, EventArgs e)
        {
            if (scoreDlg == null)                                     // Initialize score display dialog if not already done
            {
                scoreDlg = new UI_Score_ModelessDialogForm();         // Create score dialog
                scoreDlg._deluncheck = new delUncheck(Uncheckscore);   //   Set delegate for unchecking the checkbox
            }

            // Show or hide the score dialog based on the checkbox state
            if (UI_ShowScore_Chbx.Checked)
            {
                scoreDlg.Show();                            // Show the score dialog   
            }
            else
            {
                scoreDlg.Hide();                          // Hide the score dialog
            }
        }

        /// <summary>
        /// Event handler for the Show Animation Speed checkbox state change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_ShowAnimSp_Chbx_CheckedChanged(object sender, EventArgs e)
        {
            // Initialize animation speed dialog if not already done
            if (animDlg == null)
            {
                animDlg = new UI_AnimationSp_ModelessDialogForm();         // Create animation speed dialog
                animDlg._delUnchA = new delUncheckA(UncheckAnim);         //   Set delegate for unchecking the checkbox

                // Set delegate for updating drop delay
                if (diffmodedlg != null)
                    animDlg._delDelay = new delUpdateSlip(this.UpdateDropDelay);    // Set delegate for animation speed update
            }

            // Show or hide the animation speed dialog based on the checkbox state
            if (UI_ShowAnimSp_Chbx.Checked)
            {
                animDlg.Show(); // Show the animation speed dialog

            }
            else
            {
                animDlg.Hide();    // Hide the animation speed dialog
            }
        }

        /// <summary>
        /// Uncheckscore method to uncheck the score checkbox
        /// </summary>
        /// <param name="s"></param>
        public void Uncheckscore(bool s)
        {
            UI_ShowScore_Chbx.Checked = s;  // Uncheck the score checkbox
        }

        /// <summary>
        /// UncheckAnim method to uncheck the animation speed checkbox
        /// </summary>
        /// <param name="b"></param>
        public void UncheckAnim(bool b)
        {
            UI_ShowAnimSp_Chbx.Checked = b; // Uncheck the animation speed checkbox
        }

        private void UI_SelectDifficulty_ModelessDialog_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Randomize method to randomize the balls' colors and states
        /// </summary>
        /// <param name="bArray">array of balls </param>
        /// <param name="x"> x paramter</param>
        /// <param name="y">y parameter </param>
        private void Randomize(Ball[,] bArray, int x, int y)
        {
            Color[] ballColor = new Color[5] { Color.HotPink, Color.LightSkyBlue, Color.LimeGreen, Color.Orange, Color.Violet };  // Array of possible ball colors

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    int rndc = rnd.Next(0, mode);     // Generate a random index for ball color based on difficulty mode
                    bArray[i, j].bState = eState.alive;         //  Set ball state to alive
                    bArray[i, j].bColor = ballColor[rndc];     // Assign a random color to the ball
                }
            }
        }

        /// <summary>
        /// Display method to render the balls on the canvas
        /// </summary>
        private void Display()
        {
            canvas.Clear();                      // Clear the canvas before drawing
            int xPos = 25;                     //Initial x position
            int yPos = 25;                    //Initial y position

            // Nested loops to iterate through the ball array and draw each ball
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (ballArray[i, j].bState == eState.alive)                 
                    {
                        canvas.AddCenteredEllipse(xPos, yPos, 50, 50, ballArray[i, j].bColor);      //Draw the balls


                    }
                    xPos = xPos + 50;               //Increment the x position
                }
                yPos = yPos + 50;                 //Increment the x position 
                xPos = 25;                     //Reset the y position to 25
            }
        }

        /// <summary>
        /// BallsAlive method to count the number of alive balls in the array
        /// </summary>
        /// <param name="bArray">ball array</param>
        /// <param name="x">x parameter</param>
        /// <param name="y"> y parameter</param>
        /// <returns></returns>
        private int BallsAlive(Ball[,] bArray, int x, int y)
        {
            int aliveCount = 0;          // Counter for alive balls
            // Nested loops to iterate through the ball array and count alive balls
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (bArray[i, j].bState == eState.alive)           // Check if the ball is alive
                        aliveCount++;                                 // Increment the counter if the ball is alive
                }
            }
            return aliveCount;                                     // Return the total count of alive balls
        }

        /// <summary>
        /// CheckBalls method to check and eliminate connected balls of the same color
        /// </summary>
        /// <param name="row">The row targeted</param>
        /// <param name="col">the col targeted</param>
        /// <param name="checkColor">the color targeted</param>
        /// <returns></returns>
        private int CheckBalls(int row, int col, Color checkColor)
        {
            int numKilled = 0;             // Counter for the number of balls killed

            // Base cases for recursion
            if (row >= 12 || row < 0 || col >= 16 || col < 0)     
                return 0;
            else if (ballArray[row, col].bState == eState.dead)     // If the ball is already dead
                return 0;
            else if (ballArray[row, col].bColor != checkColor)      // If the ball color does not match the target color
                return 0;
            else
            {
                ballArray[row, col].bState = eState.dead;       // Mark the ball as dead
                numKilled = 1;                              // Increment the killed counter
                int abv = CheckBalls(row - 1, col, checkColor);          // Check the ball above
                int bel = CheckBalls(row + 1, col, checkColor);              // Check the ball below
                int left = CheckBalls(row, col - 1, checkColor);          // Check the ball to the left
                int right = CheckBalls(row, col + 1, checkColor);            // Check the ball to the right
                return numKilled + abv + bel + left + right;         // Return the total number of balls killed
            }

        }

        /// <summary>
        /// StepDown method to drop the balls down after eliminations
        /// </summary>
        /// <returns>the number of balls dropped</returns>
        private int StepDown()
        {
            int numDropped = 0;                       // Counter for the number of balls dropped
            // Nested loops to iterate through the ball array from bottom to top
            for (int i = 11; i >= 0; i--)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (ballArray[i, j].bState == eState.dead)       // If the ball is dead
                    {
                        if (i == 0)
                        {
                        }
                        else if (i > 0)
                        {
                            if (ballArray[i - 1, j].bState == eState.alive)           // If the ball above is alive
                            {
                                ballArray[i, j] = ballArray[i - 1, j];               // Move the ball down
                                ballArray[i - 1, j].bState = eState.dead;             // Move the ball down
                                numDropped++;                                          // Increment the dropped counter

                            }
                        }
                    }
                }
            }
            Thread.Sleep(DropDelay);                            // Delay for drop animation
            Display();                                          // Update the display after dropping
            return numDropped;                                //    Return the total number of balls dropped

        }

        /// <summary>
        /// FallDown method to continue dropping balls until no more can be dropped
        /// </summary>
        /// <returns>the number of balls falled</returns>
        private int FallDown()
        {
            int countStDown = 0;                          // Counter for the number of drop steps
            int countDropped = 0;                        // Counter for the number of balls dropped in each step
            countDropped = StepDown();                  // Initial drop step
            while (countDropped != 0)                  // Continue dropping until no more balls can be dropped
            {
                countDropped = StepDown();                 //   Drop step
                countStDown++;                         // Increment the step counter
            }
            return countStDown;                       // Return the total number of drop steps
        }

        /// <summary>
        /// Pick method to handle ball selection and scoring
        /// </summary>
        /// <returns>The number of killed*the number of falled</returns>
        private int Pick()
        {
            Point click;                          // Variable to store the click position
            if (canvas.GetLastMouseLeftClick(out click))               // Check if there was a left mouse click
            {
                int clickrow = click.Y / size;                        // Calculate the row of the clicked ball
                int clickcol = click.X / size;                        //    Calculate the column of the clicked ball

                if (clickrow < 0 || clickrow >= row || clickcol < 0 || clickcol >= col)           // Check for out-of-bounds click
                    return 0;                                                         // Return 0 if out of bounds

                Color ch = ballArray[clickrow, clickcol].bColor;                      // Get the color of the clicked ball
                int killed = CheckBalls(clickrow, clickcol, ch);                     // Check and eliminate connected balls of the same color
                int fall = FallDown();                                              // Drop the balls down after eliminations

                return killed * fall;                                           // Return the score based on killed balls and fall steps
            }
            return 0;                                                  // Return 0 if no click was detected
        }
        /// <summary>
        /// Timer tick event handler for game updates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Timer_Tim_Tick(object sender, EventArgs e)
        {
            int scoreThisClick = Pick();                 // Handle ball selection and scoring
            if (scoreThisClick > 0)                           //    If there was a score from the click
            {
                score += scoreThisClick;                    // Update the total score
                if (scoreDlg._delsc != null)              
                    scoreDlg._delsc(score);                  // Update the score display dialog
            }

            Display();
            canvas.Render();

            // Check for game over condition
            if (!gameOver&&BallsAlive(ballArray, row, col) == 0)
            {
                gameOver = true;                                 // Set game over flag
                UI_Timer_Tim.Stop();                            // Stop the game timer
                canvas.AddText("Game Over!", 50, Color.Yellow);     // Display game over message
                int bestScore = ReadBestScoreForMode(mode);             // Read the best score for the current mode

                // Check if the current score is a new high score
                if (score > bestScore)
                {
                    UI_HighScore_ModelessDialogForm dlg =
                        new UI_HighScore_ModelessDialogForm();          // Create high score dialog

                    dlg._delSave = ReceiveHighScoreName;         // Set delegate to receive the player's name

                    if (dlg.ShowDialog() == DialogResult.OK)           //   Show the dialog and check for OK result
                    {
                        SaveScore(highScoreName, mode, score);          // Save the new high score
                    }
                }
                UI_Play_Btn.Enabled = true;                           // Re-enable the Play button
            }
        }

        /// <summary>
        /// update drop delay method
        /// </summary>
        /// <param name="v"></param>
        public void UpdateDropDelay(int v)
        {
            DropDelay = v;       // Update the drop delay
        }
        /// <summary>
        /// ReceiveHighScoreName method to receive the player's name for high score
        /// </summary>
        /// <param name="name"></param>
        public void ReceiveHighScoreName(string name)
        {
            highScoreName = name;               // Store the player's name
        }
        /// <summary>
        /// SaveScore method to save the high score to a file
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mode"></param>
        /// <param name="score"></param>
        private void SaveScore(string name, int mode, int score)
        {
            string line = $"{name},{mode},{score}";                        // Format the score entry            
            File.AppendAllText("highscores.txt", line + Environment.NewLine);           // Append the score entry to the file
        }

        /// <summary>
        /// ReadBestScoreForMode method to read the best score for a given mode from the file
        /// </summary>
        /// <param name="mode"></param>
        /// <returns>The best score according to the mode</returns>
        private int ReadBestScoreForMode(int mode)
        {
            int best = 0;                               // Variable to store the best score

            string[] lines = File.ReadAllLines("highscores.txt");   // Read all lines from the high score file

            foreach (string line in lines)                           // Iterate through each line
            {
                string[] parts = line.Split(',');                         // Split the line into parts
                 
                if (parts.Length == 3)                                // Check if the line has the correct format
                {
                    int fileMode = int.Parse(parts[1]);                  // Parse the mode from the file
                    int fileScore = int.Parse(parts[2]);                     // Parse the score from the file
                    if (fileMode == mode && fileScore > best)              // Update the best score if the mode matches and the score is higher          
                        best = fileScore;                                 // Update the best score
                }           
            }

            return best;                                        // Return the best score for the given mode
        }

    }
}
