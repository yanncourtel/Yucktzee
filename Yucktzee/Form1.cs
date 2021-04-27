using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzeemk2
{

    public partial class Form1 : Form
    {

        int begrollcount = 3;
        int holdcount1 = new int();
        int holdcount2 = new int();
        int holdcount3 = new int();
        int holdcount4 = new int();
        int holdcount5 = new int();
        int yzbonuscount = 0;
        int yzbonus = 0;

        int threekcnt = 0;
        int fourkcnt = 0;
        int eventscount = 0;
        int fullhousecount = 0;
        int smllstraightcount = 0;
        int lrgstraightcount = 0;
        int othcount = 0;
        int yzcount = 0;
        int fvonecount = 0;
        int fvtwocount = 0;
        int fvthreecount = 0;
        int fvfourcount = 0;
        int fvfivecount = 0;
        int fvsixcount = 0;
        Stack<int> frank = new Stack<int>();
 



        public Form1()
        {
            InitializeComponent();
            button13.Hide();
            //calling the function rolls to play randomize a stack of 195 rolls of the dice
            rolls();
            
            
        }
        private void rolls()
        {
            //the stack is a global variable and is populated with in this function
            Stack<Int32> mcsc = new Stack<int>();
            //the random sorts out the one through 6
            Random mark = new Random();
            //the array of 195
            int[] rolls = new int[195];
            //running through the array to make 195 attempts
            for (int i = 0; i < 195; i++)
            {
                rolls[i] = mark.Next(1, 7);
            }
            //filling the stack
            foreach (int element in rolls)
            {
                mcsc.Push(element);
            }

            frank = mcsc;
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            // simulating the roll of the die a 1 through 6 will appear in the textbox
            if (holdcount1 < 1)
            {
                int francis1 = frank.Pop();
                textBox1.Text = francis1.ToString();
            }
            if (holdcount2 < 1)
            {
                int francis2 = frank.Pop();
                textBox2.Text = francis2.ToString();
            }
            if (holdcount3 < 1)
            {
                int francis3 = frank.Pop();
                textBox3.Text = francis3.ToString();
            }


            if (holdcount4 < 1)
            {
                int francis4 = frank.Pop();
                textBox4.Text = francis4.ToString();
            }
            if (holdcount5 < 1)
            {
                int francis5 = frank.Pop();
                textBox5.Text = francis5.ToString();
            }
            // after tree rolls the button to roll goes away
            begrollcount -= 1;
            if (begrollcount == 0)
            {
                panel1.Show();
                button1.Hide();

            }

            
            

        }
       
        //button 2 through 6 are my hold buttons they work off a counter which tell the roll not to put a face value there
        private void button2_Click(object sender, EventArgs e)
        {
            holdcount1 += 1;
            button11.Show();
            button2.Hide();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            holdcount2 += 1;
            button10.Show();
            button3.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            holdcount3 += 1;
            button9.Show();
            button4.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            holdcount4 += 1;
            button8.Show();
            button5.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            holdcount5 += 1;
            button7.Show();
            button6.Hide();

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            // hide the unhold buttons
            button11.Hide();
            button10.Hide();
            button9.Hide();
            button8.Hide();
            button7.Hide();

        }
        //buttons 7 - 11 are release the hold and again use the counter to accept a face value of the rspective die
        private void button7_Click(object sender, EventArgs e)
        {
            holdcount5 -= 1;
            button6.Show();
            button7.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            holdcount4 -= 1;
            button5.Show();
            button8.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            holdcount3 -= 1;
            button4.Show();
            button9.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            holdcount2 -= 1;
            button3.Show();
            button10.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            holdcount1 -= 1;
            button11.Hide();
            button2.Show();
        }
        // generate a score 
        private void button12_Click(object sender, EventArgs e)
        {
            //create a 1d array to capture the results in and 5 single integers to fill these values
            int[] resultset = new int[5];
            int rs1 = new int();
            int rs2 = new int();
            int rs3 = new int();
            int rs4 = new int();
            int rs5 = new int();
            //below we convert the textbox digits to an int for comarison purposes and totalling
            // the try and catch is in palce as a good code measure and should not be needed as the 
            // computer generates the digits
            try
            {
                rs1 = Convert.ToInt32(textBox1.Text);
                rs2 = Convert.ToInt32(textBox2.Text);
                rs3 = Convert.ToInt32(textBox3.Text);
                rs4 = Convert.ToInt32(textBox4.Text);
                rs5 = Convert.ToInt32(textBox5.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Converion Issue", "Problems");
            }
            //fillt the array with int values
            resultset[0] = rs1;
            resultset[1] = rs2;
            resultset[2] = rs3;
            resultset[3] = rs4;
            resultset[4] = rs5;


            //the checkbox has a counter and when pressed it makes it one it one to run this piece of code.  After it has run the the counter is resent so it 
            // does not run again.  The checkbox is also hidden.  That the same for the next 13 if statements as the code call the result methods and the yahtzee
            // bonus method.

            if (threekcnt == 1)
            {
                bonuscheck(rs1, rs2, rs3, rs4, rs5);
                ResultClass alfa = new ResultClass();
                int rolledscore = new int();
                rolledscore = alfa.threeofakind(resultset);
                label24.Text = rolledscore.ToString();

            }

            if (fourkcnt == 1)
            {
                bonuscheck(rs1,rs2,rs3,rs4,rs5);
                ResultClass beta = new ResultClass();
                int rolledscore = new int();
                rolledscore = beta.fourofakind(resultset);
                label23.Text = rolledscore.ToString();

            }
            if (fullhousecount == 1)
            {
                bonuscheck(rs1,rs2,rs3,rs4,rs5);
                ResultClass gamma = new ResultClass();
                int rolledscore = new int();
                rolledscore = gamma.fullhouse(resultset);
                label22.Text = rolledscore.ToString();

            }

            if (smllstraightcount == 1)
            {
                bonuscheck(rs1,rs2,rs3,rs4,rs5);
                ResultClass delta = new ResultClass();
                int rolledscore = new int();
                rolledscore = delta.smallstraight(resultset);
                label21.Text = rolledscore.ToString();

            }

            if (lrgstraightcount == 1)
            {
                bonuscheck(rs1,rs2,rs3,rs4,rs5);
                ResultClass epsilon = new ResultClass();
                int rolledscore = new int();
                rolledscore = epsilon.largestraight(resultset);
                label20.Text = rolledscore.ToString();

            }

            if (othcount == 1)
            {
                bonuscheck(rs1,rs2,rs3,rs4,rs5);
                ResultClass zeta = new ResultClass();
                int rolledscore = new int();
                rolledscore = zeta.other(resultset);
                label17.Text = rolledscore.ToString();

            }

            if (yzcount == 1)
            {
                ResultClass eta = new ResultClass();
                int rolledscore = new int();
                rolledscore = eta.allFive(resultset);
                label19.Text = rolledscore.ToString();
                if (rolledscore == 50)
                {
                    yzbonuscount += 1;
                    label51.Text = yzbonuscount.ToString();
                }
            }
            // the facevalue methods have and extra piece of code to add a bonus yahtzee if you have rolled a yahtzee previously
            if (fvonecount ==1)
            {
                int fv = 1;
                ResultClass theta = new ResultClass();
                int rolledscore = new int();
                rolledscore = theta.faceval(resultset,fv);
                label13.Text = rolledscore.ToString();
                if (yzbonuscount >= 1 && rs1 == rs2 && rs2 == rs3 && rs3 == rs4 && rs4 == rs5)
                {
                    yzbonus += 100;
                    label51.Text = yzbonuscount.ToString();
                }
            }
            if (fvtwocount == 1)
            {
                int fv = 2;
                ResultClass iota = new ResultClass();
                int rolledscore = new int();
                rolledscore = iota.faceval(resultset, fv);
                label12.Text = rolledscore.ToString();
                if (yzbonuscount >= 1 && rs1 == rs2 && rs2 == rs3 && rs3 == rs4 && rs4 == rs5)
                {
                    yzbonus += 100;
                    label51.Text = yzbonuscount.ToString();
                }
            }
            if (fvthreecount == 1)
            {
                int fv = 3;
                ResultClass kappa = new ResultClass();
                int rolledscore = new int();
                rolledscore = kappa.faceval(resultset, fv);
                label11.Text = rolledscore.ToString();
                if (yzbonuscount >= 1 && rs1 == rs2 && rs2 == rs3 && rs3 == rs4 && rs4 == rs5)
                {
                    yzbonus += 100;
                    label51.Text = yzbonuscount.ToString();
                }
            }
            if (fvfourcount == 1)
            {
                int fv = 4;
                ResultClass lamba = new ResultClass();
                int rolledscore = new int();
                rolledscore = lamba.faceval(resultset, fv);
                label10.Text = rolledscore.ToString();
                if (yzbonuscount >= 1 && rs1 == rs2 && rs2 == rs3 && rs3 == rs4 && rs4 == rs5)
                {
                    yzbonus += 100;
                    label51.Text = yzbonuscount.ToString();
                }
            }
            if (fvfivecount == 1)
            {
                int fv = 5;
                ResultClass mu = new ResultClass();
                int rolledscore = new int();
                rolledscore = mu.faceval(resultset, fv);
                label9.Text = rolledscore.ToString();
                if (yzbonuscount >= 1 && rs1 == rs2 && rs2 == rs3 && rs3 == rs4 && rs4 == rs5)
                {
                    yzbonus += 100;
                    label51.Text = yzbonuscount.ToString();
                }
            }
            if (fvsixcount == 1)
            {
                int fv = 6;
                ResultClass nu = new ResultClass();
                int rolledscore = new int();
                rolledscore = nu.faceval(resultset, fv);
                label8.Text = rolledscore.ToString();
                if (yzbonuscount >= 1 && rs1 == rs2 && rs2 == rs3 && rs3 == rs4 && rs4 == rs5)
                {
                    yzbonus += 100;
                    label51.Text = yzbonuscount.ToString();
                }
            }
             
        }
        // methods for the check boxs to plus the counter press result, hide checkbox, add to the events count which at 13 and scores the results and forwards
        //play to the next roll unless events count is equal to 13

        private void ThreeofAKind_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Please Confirm you wish to Score or Use three of a kind", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                threekcnt += 1;
                button12_Click(sender, e);
                ThreeofAKind.Hide();
                eventscount += 1;
            }

            if (res == DialogResult.No)
            {
                MessageBox.Show("Please Choose another option");
                return;
            }

            if (eventscount <= 13)
            {
                begrollcount = 3;
                button1.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                if (holdcount1 >= 1)
                    button11_Click(sender, e);
                if (holdcount2 >= 1)
                    button10_Click(sender, e);
                if (holdcount3 >= 1)
                    button9_Click(sender, e);
                if (holdcount4 >= 1)
                    button8_Click(sender, e);
                if (holdcount5 >= 1)
                    button7_Click(sender, e);
                label36.Text = threekcnt.ToString();
                threekcnt -= 1;

            }

            if (eventscount == 13)
            {
                button13_Click(sender, e);
            }
           



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Please Confirm you wish to Score or Use Four of a kind", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                fourkcnt += 1;
                button12_Click(sender, e);
                checkBox1.Hide();
                eventscount += 1;
            }

            if (res == DialogResult.No)
            {
                MessageBox.Show("Please Choose another option");
                return;
            }
            if (eventscount <= 13)
            {
                begrollcount = 3;
                button1.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                if (holdcount1 >= 1)
                    button11_Click(sender, e);
                if (holdcount2 >= 1)
                    button10_Click(sender, e);
                if (holdcount3 >= 1)
                    button9_Click(sender, e);
                if (holdcount4 >= 1)
                    button8_Click(sender, e);
                if (holdcount5 >= 1)
                    button7_Click(sender, e);
                label37.Text = fourkcnt.ToString();
                fourkcnt -= 1;
            }

            if (eventscount == 13)
            {
                button13_Click(sender, e);
            }

            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Please Confirm you wish to Score or Use the Full House", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                fullhousecount += 1;
                button12_Click(sender, e);
                checkBox2.Hide();
                eventscount += 1;
            }

            if (res == DialogResult.No)
            {
                MessageBox.Show("Please Choose another option");
                return;
            }
            if (eventscount <= 13)
            {
                begrollcount = 3;
                button1.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                if (holdcount1 >= 1)
                    button11_Click(sender, e);
                if (holdcount2 >= 1)
                    button10_Click(sender, e);
                if (holdcount3 >= 1)
                    button9_Click(sender, e);
                if (holdcount4 >= 1)
                    button8_Click(sender, e);
                if (holdcount5 >= 1)
                    button7_Click(sender, e);
                label38.Text = fullhousecount.ToString();
                fullhousecount -= 1;

            }
            if (eventscount == 13)
            {
                button13_Click(sender, e);
            }

            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Please Confirm you wish to Score or Use the Small Straight", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                smllstraightcount += 1;
                button12_Click(sender, e);
                checkBox3.Hide();
                eventscount += 1;
            }

            if (res == DialogResult.No)
            {
                MessageBox.Show("Please Choose another option");
                return;
            }
            if (eventscount <= 13)
            {
                begrollcount = 3;
                button1.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                if (holdcount1 >= 1)
                    button11_Click(sender, e);
                if (holdcount2 >= 1)
                    button10_Click(sender, e);
                if (holdcount3 >= 1)
                    button9_Click(sender, e);
                if (holdcount4 >= 1)
                    button8_Click(sender, e);
                if (holdcount5 >= 1)
                    button7_Click(sender, e);
                label39.Text = smllstraightcount.ToString();
                smllstraightcount -= 1;
            }
            if (eventscount == 13)
            {
                button13_Click(sender, e);
            }
           


        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Please Confirm you wish to Score or Use the Large Straight", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                lrgstraightcount += 1;
                button12_Click(sender, e);
                checkBox4.Hide();
                eventscount += 1;
            }

            if (res == DialogResult.No)
            {
                MessageBox.Show("Please Choose another option");
                return;
            }
            if (eventscount <= 13)
            {
                begrollcount = 3;
                button1.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                if (holdcount1 >= 1)
                    button11_Click(sender, e);
                if (holdcount2 >= 1)
                    button10_Click(sender, e);
                if (holdcount3 >= 1)
                    button9_Click(sender, e);
                if (holdcount4 >= 1)
                    button8_Click(sender, e);
                if (holdcount5 >= 1)
                    button7_Click(sender, e);
                label40.Text = lrgstraightcount.ToString();
                lrgstraightcount -= 1;
            }
            if (eventscount == 13)
            {
                button13_Click(sender, e);
            }




        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Please Confirm you wish to Score or Use the Extra Score", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                othcount += 1;
                button12_Click(sender, e);
                checkBox6.Hide();
                eventscount += 1;
            }

            if (res == DialogResult.No)
            {
                MessageBox.Show("Please Choose another option");
                return;
            }
            if (eventscount <= 13)
            {
                begrollcount = 3;
                button1.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                if (holdcount1 >= 1)
                    button11_Click(sender, e);
                if (holdcount2 >= 1)
                    button10_Click(sender, e);
                if (holdcount3 >= 1)
                    button9_Click(sender, e);
                if (holdcount4 >= 1)
                    button8_Click(sender, e);
                if (holdcount5 >= 1)
                    button7_Click(sender, e);
                label42.Text = othcount.ToString();
                othcount -= 1;
            }
            if (eventscount == 13)
            {
                button13_Click(sender, e);
            }
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Please Confirm you wish to Score or Use a yahtzee", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                yzcount += 1;
                button12_Click(sender, e);
                checkBox5.Hide();
                eventscount += 1;
            }

            if (res == DialogResult.No)
            {
                MessageBox.Show("Please Choose another option");
                return;
            }
            if (eventscount <= 13)
            {
                begrollcount = 3;
                button1.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                if (holdcount1 >= 1)
                    button11_Click(sender, e);
                if (holdcount2 >= 1)
                    button10_Click(sender, e);
                if (holdcount3 >= 1)
                    button9_Click(sender, e);
                if (holdcount4 >= 1)
                    button8_Click(sender, e);
                if (holdcount5 >= 1)
                    button7_Click(sender, e);
                label41.Text = yzcount.ToString();
                yzcount -= 1;
            }
            if (eventscount == 13)
            {
                button13_Click(sender, e);
            }
            
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Please Confirm you wish to use ONE to score the face value points?", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                fvonecount += 1;
                button12_Click(sender, e);
                checkBox7.Hide();
                eventscount += 1;
            }

            if (res == DialogResult.No)
            {
                MessageBox.Show("Please Choose another option");
                return;
            }
            if (eventscount <= 13)
            {
                begrollcount = 3;
                button1.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                if (holdcount1 >= 1)
                    button11_Click(sender, e);
                if (holdcount2 >= 1)
                    button10_Click(sender, e);
                if (holdcount3 >= 1)
                    button9_Click(sender, e);
                if (holdcount4 >= 1)
                    button8_Click(sender, e);
                if (holdcount5 >= 1)
                    button7_Click(sender, e);
                label48.Text = fvonecount.ToString();
                fvonecount -= 1;
            }
            if (eventscount == 13)
            {
                button13_Click(sender, e);
            }
            

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Please Confirm you wish to use TWO to score the face value points?", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                fvtwocount += 1;
                button12_Click(sender, e);
                checkBox9.Hide();
                eventscount += 1;
            }

            if (res == DialogResult.No)
            {
                MessageBox.Show("Please Choose another option");
                return;
            }
            if (eventscount <= 13)
            {
                begrollcount = 3;
                button1.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                if (holdcount1 >= 1)
                    button11_Click(sender, e);
                if (holdcount2 >= 1)
                    button10_Click(sender, e);
                if (holdcount3 >= 1)
                    button9_Click(sender, e);
                if (holdcount4 >= 1)
                    button8_Click(sender, e);
                if (holdcount5 >= 1)
                    button7_Click(sender, e);
                label47.Text = fvtwocount.ToString();
                fvtwocount -= 1;
            }

            if (eventscount == 13)
            {
                button13_Click(sender, e);
            }
           
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Please Confirm you wish to use THREE to score the face value points?", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                fvthreecount += 1;
                button12_Click(sender, e);
                checkBox11.Hide();
                eventscount += 1;
            }

            if (res == DialogResult.No)
            {
                MessageBox.Show("Please Choose another option");
                return;
            }
            if (eventscount <= 13)
            {
                begrollcount = 3;
                button1.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                if (holdcount1 >= 1)
                    button11_Click(sender, e);
                if (holdcount2 >= 1)
                    button10_Click(sender, e);
                if (holdcount3 >= 1)
                    button9_Click(sender, e);
                if (holdcount4 >= 1)
                    button8_Click(sender, e);
                if (holdcount5 >= 1)
                    button7_Click(sender, e);
                label46.Text = fvthreecount.ToString();
                fvthreecount -= 1;
            }
            if (eventscount == 13)
            {
                button13_Click(sender, e);
            }
            
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Please Confirm you wish to use FOUR to score the face value points?", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                fvfourcount += 1;
                button12_Click(sender, e);
                checkBox8.Hide();
                eventscount += 1;
            }

            if (res == DialogResult.No)
            {
                MessageBox.Show("Please Choose another option");
                return;
            }
            if (eventscount <= 13)
            {
                begrollcount = 3;
                button1.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                if (holdcount1 >= 1)
                    button11_Click(sender, e);
                if (holdcount2 >= 1)
                    button10_Click(sender, e);
                if (holdcount3 >= 1)
                    button9_Click(sender, e);
                if (holdcount4 >= 1)
                    button8_Click(sender, e);
                if (holdcount5 >= 1)
                    button7_Click(sender, e);
                label45.Text = fvfourcount.ToString();
                fvfourcount -= 1;
            }
            if (eventscount == 13)
            {
                button13_Click(sender, e);
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Please Confirm you wish to use FIVE to score the face value points?", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                fvfivecount += 1;
                button12_Click(sender, e);
                checkBox10.Hide();
                eventscount += 1;
            }

            if (res == DialogResult.No)
            {
                MessageBox.Show("Please Choose another option");
                return;
            }
            if (eventscount <= 13)
            {
                begrollcount = 3;
                button1.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                if (holdcount1 >= 1)
                    button11_Click(sender, e);
                if (holdcount2 >= 1)
                    button10_Click(sender, e);
                if (holdcount3 >= 1)
                    button9_Click(sender, e);
                if (holdcount4 >= 1)
                    button8_Click(sender, e);
                if (holdcount5 >= 1)
                    button7_Click(sender, e);
                label44.Text = fvfivecount.ToString();
                fvfivecount -= 1;
            }

            if (eventscount == 13)
            {
                button13_Click(sender, e);
            }
            
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Please Confirm you wish to use SIX to score the face value points?", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                fvsixcount += 1;
                button12_Click(sender, e);
                checkBox12.Hide();
                eventscount += 1;
            }

            if (res == DialogResult.No)
            {
                MessageBox.Show("Please Choose another option");
                return;
            }
            if (eventscount <= 13)
            {
                begrollcount = 3;
                button1.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                if (holdcount1 >= 1)
                    button11_Click(sender, e);
                if (holdcount2 >= 1)
                    button10_Click(sender, e);
                if (holdcount3 >= 1)
                    button9_Click(sender, e);
                if (holdcount4 >= 1)
                    button8_Click(sender, e);
                if (holdcount5 >= 1)
                    button7_Click(sender, e);
                    label43.Text = fvsixcount.ToString();
                 fvsixcount -= 1;
            }
            if (eventscount == 13)
            {
                button13_Click(sender, e);
            }
            
        }
        //scoring button
        private void button13_Click(object sender, EventArgs e)
        {
            
            // fscore means face score oscore for other score
            int fscores1 = new int();
            int fscores2 = new int();
            int fscores3 = new int();
            int fscores4 = new int();
            int fscores5 = new int();
            int fscores6 = new int();
            int oscores1 = new int();
            int oscores2 = new int();
            int oscores3 = new int();
            int oscores4 = new int();
            int oscores5 = new int();
            int oscores6 = new int();
            int oscores7 = new int();
            int totfscores = new int();
            int oscores = new int();
            int totscores = new int();
            int tfbonus = 35;


            // again I am converting text to numbers to tally them up
            try
            {
                fscores1 = Convert.ToInt32(label13.Text);
                fscores2 = Convert.ToInt32(label12.Text);
                fscores3 = Convert.ToInt32(label11.Text);
                fscores4 = Convert.ToInt32(label10.Text);
                fscores5 = Convert.ToInt32(label9.Text);
                fscores6 = Convert.ToInt32(label8.Text);
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Converion Issue", "Problems");
            }
            totfscores = fscores1 + fscores2 + fscores3 + fscores4 + fscores5 + fscores6;
            //logic to see if you get the face value bonus
            if (totfscores >= 63)
            {
                totfscores = totfscores + tfbonus;
            }
            label16.Text = totfscores.ToString();
            //conversion of the other scores
            try
            {
                oscores1 = Convert.ToInt32(label24.Text);
                oscores2 = Convert.ToInt32(label23.Text);
                oscores3 = Convert.ToInt32(label22.Text);
                oscores4 = Convert.ToInt32(label21.Text);
                oscores5 = Convert.ToInt32(label20.Text);
                oscores6 = Convert.ToInt32(label19.Text);
                oscores7 = Convert.ToInt32(label17.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Converion Issue", "Problems");
            }
            //making the scores + converting to text
            oscores = oscores1 + oscores2 + oscores3 + oscores4 + oscores5 + oscores6 + oscores7;
            totscores = oscores + totfscores + yzbonus;
            label35.Text = yzbonus.ToString();
            label33.Text = oscores.ToString();
            label31.Text = totscores.ToString();
            button1.Hide();
            
        }
        // resume play
        private void button14_Click(object sender, EventArgs e)
        {
            rolls();
            begrollcount = 3;
            button1.Show();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            panel1.Hide();
            eventscount = 0;
            yzbonuscount = 0;
            yzbonus = 0;
            label13.Text = "0";
            label12.Text = "0";
            label11.Text = "0";
            label10.Text = "0";
            label9.Text =  "0";
            label8.Text =  "0";
            label16.Text = "0";
            label24.Text = "0";
            label23.Text = "0";
            label22.Text = "0";
            label21.Text = "0";
            label20.Text = "0";
            label19.Text = "0";
            label17.Text = "0";
            label31.Text = "0";
            label33.Text = "0";
            label35.Text = "0";

            label48.Text = "0";
            label47.Text = "0";
            label46.Text = "0";
            label45.Text = "0";
            label44.Text = "0";
            label43.Text = "0";
            label42.Text = "0";
            label41.Text = "0";
            label40.Text = "0";
            label39.Text = "0";
            label38.Text = "0";
            label37.Text = "0";
            label36.Text = "0";
            label51.Text = "0";
            if (holdcount1 >= 1)
                button11_Click(sender, e);
            if (holdcount2 >= 1)
                button10_Click(sender, e);
            if (holdcount3 >= 1)
                button9_Click(sender, e);
            if (holdcount4 >= 1)
                button8_Click(sender, e);
            if (holdcount5 >= 1)
                button7_Click(sender, e);

            ThreeofAKind.Show();
            
            checkBox1.Show();
            
            checkBox2.Show();
            checkBox3.Show();
            checkBox4.Show();
            checkBox5.Show();
            checkBox6.Show();
            checkBox7.Show();
            checkBox8.Show();
            checkBox9.Show();
            checkBox10.Show();
            checkBox11.Show();
            checkBox12.Show();
            int threekcnt = 0;
            int fourkcnt = 0;
            int fullhousecount = 0;
            int smllstraightcount = 0;
            int lrgstraightcount = 0;
            int othcount = 0;
            int yzcount = 0;
            int fvonecount = 0;
            int fvtwocount = 0;
            int fvthreecount = 0;
            int fvfourcount = 0;
            int fvfivecount = 0;
            int fvsixcount = 0;
            


        }
        private void bonuscheck(int r1, int r2, int r3, int r4, int r5)
        {

            int nopssthroughchk = 1;
            if(r1 == 1 && label13.Text == "0" || r1 == 2 && label12.Text == "0" ||r1 == 3 && label11.Text == "0" ||r1 == 4 && label10.Text == "0" ||
                r1 == 5 && label9.Text == "0" || r1 == 6 && label8.Text == "0" )
            {
                nopssthroughchk -= 1;
            }

            
            if (yzbonuscount == 1 &&  r1 == r2 && r2 ==r3 && r3 == r4 && r4 == r5 && nopssthroughchk == 1)
            {
                yzbonus += 100;
                label35.Text = yzbonus.ToString();

            }
        }

      

        
    }

}
    

