using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDoumaAssignment3
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        int numberOfMoves = 0;
        // alternates between placing an x and an o in the picturebox
        // if there isn't an image already in it
        private void Move_Click(object sender, EventArgs e)
        {
            if((sender as PictureBox).Image == null)
            {
                numberOfMoves++;
                if (numberOfMoves % 2 != 0)
                {
                    (sender as PictureBox).Image = Properties.Resources.x;
                    (sender as PictureBox).Tag = "x";
                    lblTurn.Text = "It's O's Turn!";
                }
                else
                {
                    (sender as PictureBox).Image = Properties.Resources.o;
                    (sender as PictureBox).Tag = "o";
                    lblTurn.Text = "It's X's Turn!";
                }                             
                CheckWinner();                         
            }

        }

        private void CheckWinner()
        {

            if ((tile00.Tag == tile01.Tag && tile00.Tag == tile02.Tag) || //first horizontal
                (tile10.Tag == tile11.Tag && tile10.Tag == tile12.Tag) || //second horizontal
                (tile20.Tag == tile21.Tag && tile20.Tag == tile22.Tag) || //third horizontal
                (tile00.Tag == tile10.Tag && tile00.Tag == tile20.Tag) || //first vertical
                (tile01.Tag == tile11.Tag && tile01.Tag == tile21.Tag) || //second vertical
                (tile02.Tag == tile12.Tag && tile02.Tag == tile22.Tag) || //third vertical
                (tile00.Tag == tile11.Tag && tile00.Tag == tile22.Tag) || //first diagonal
                (tile02.Tag == tile11.Tag && tile02.Tag == tile20.Tag))   //second diagonal
            {
                if (numberOfMoves % 2 != 0)
                {
                    MessageBox.Show("X Wins!");
                    NewGame();
                }
                else
                {
                    MessageBox.Show("0 Wins!");
                    NewGame();
                }
            }
            else if ((tile00.Image != null) && (tile01.Image != null) &&
                (tile02.Image != null) && (tile10.Image != null) &&
                (tile11.Image != null) && (tile12.Image != null) &&
                (tile20.Image != null) && (tile21.Image != null) &&
                (tile22.Image != null))
            {
                MessageBox.Show("Cat's Game!");
                NewGame();
            }
        }

        private void NewGame()
        {
            tile00.Tag = 1;
            tile01.Tag = 2;
            tile02.Tag = 3;
            tile10.Tag = 4;
            tile11.Tag = 5;
            tile12.Tag = 6;
            tile20.Tag = 7;
            tile21.Tag = 8;
            tile22.Tag = 9;

            tile00.Image = null;
            tile01.Image = null;
            tile02.Image = null;
            tile10.Image = null;
            tile11.Image = null;
            tile12.Image = null;
            tile20.Image = null;
            tile21.Image = null;
            tile22.Image = null;

            numberOfMoves = 0;

            lblTurn.Text = "It's X's Turn!";
        }


    }
}
