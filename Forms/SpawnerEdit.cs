using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HNFQuestEditor
{
	public partial class SpawnerEdit : Form
	{
		public ComboBox[] mFish;
		public NumericUpDown[] mChances;

		public SpawnerEdit()
		{
			InitializeComponent();

            mFish = new ComboBox[10];
            mChances = new NumericUpDown[10];

            mFish[0] = drpFish1;
            mFish[1] = drpFish2;
            mFish[2] = drpFish3;
            mFish[3] = drpFish4;
            mFish[4] = drpFish5;
            mFish[5] = drpFish6;
            mFish[6] = drpFish7;
            mFish[7] = drpFish8;
            mFish[8] = drpFish9;
            mFish[9] = drpFish10;

            mChances[0] = numFish1;
            mChances[1] = numFish2;
            mChances[2] = numFish3;
            mChances[3] = numFish4;
            mChances[4] = numFish5;
            mChances[5] = numFish6;
            mChances[6] = numFish7;
            mChances[7] = numFish8;
            mChances[8] = numFish9;
            mChances[9] = numFish10;
        }

        public SpawnerEdit(List<string> fishList) : this()
        {
            for (int i = 0; i < 10; i++)
            {
                mFish[i].Items.Clear();
                mFish[i].Items.Add("-----------------");
                mFish[i].Items.AddRange(fishList.ToArray());
            }
        }

		private void SpawnerEdit_Load(object sender, EventArgs e)
		{

        }

		private void btnSave_Click(object sender, EventArgs e)
		{

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{

		}

		private void numFish_ValueChanged(object sender, EventArgs e)
		{
            //Replace this with a thing that only changes the caller's index
            //Go through each of the fish and add up the percent totals
            int total = 0;
			for (int i = 0; i < 10; i++)
			{
                total += (int) mChances[i].Value;
			}

            lblTotal.Text = "Total: " + total;
            if (total == 100)
            {
                lblTotal.ForeColor = Color.Green;
            }
            else if (total < 100)
            { 
                lblTotal.ForeColor = SystemColors.ControlText;
            }
            else if (total > 100)
            {
                lblTotal.ForeColor = Color.Red;
            }
        }
	}
}
