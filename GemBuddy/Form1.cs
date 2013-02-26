using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GemBuddy
{
    public partial class Form1 : Form
    {

        //This is a replacement for Cursor.Position in WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }

        Dictionary<string, int> posDic = new Dictionary<string, int>();

        int counter = 0;
        int tier1 = 0;
        int tier2 = 0;
        int tier3 = 0;

        bool hasPicked1 = false;
        bool hasPicked2 = false;
        bool hasPicked3 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void gemTimer_Tick(object sender, EventArgs e)
        {
            if(counter < tier1)
            {
                if (!hasPicked1)
                {
                    LeftMouseClick(posDic["pos1X"], posDic["pos1Y"]);
                    hasPicked1 = true;
                }
                LeftMouseClick(posDic["btnX"], posDic["btnY"]);
                counter++;
                lbl1Set.Text = (tier1 - counter).ToString();
            } else if(counter < tier2) {
                if (!hasPicked2)
                {
                    LeftMouseClick(posDic["pos2X"], posDic["pos2Y"]);
                    hasPicked2 = true;
                }
                LeftMouseClick(posDic["btnX"], posDic["btnY"]); ;
                counter++;
                lbl2Set.Text = (tier2 - counter).ToString();
            } else if(counter < tier3) {
                if (!hasPicked3)
                {
                    LeftMouseClick(posDic["pos3X"], posDic["pos3Y"]);
                    hasPicked3 = true;
                }
                LeftMouseClick(posDic["btnX"], posDic["btnY"]);
                counter++;
                lbl3Set.Text = (tier3 - counter).ToString();
            } else {
                gemTimer.Enabled = false;
                hasPicked1 = false;
                hasPicked2 = false;
                hasPicked3 = false;
                counter = 0;
                tier1 = 0;
                tier2 = 0;
                tier3 = 0;
            }
        }

        private void addCoords(int x, int y, char set)
        {
            posDic.Add("pos" + set + "X", x);
            posDic.Add("pos" + set + "Y", y);
        }

        private void resetData()
        {
            gemTimer.Enabled = false;
            hasPicked1 = false;
            hasPicked2 = false;
            hasPicked3 = false;
            counter = 0;
            tier1 = 0;
            tier2 = 0;
            tier3 = 0;
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            MessageBox.Show(key.ToString());

            if (key == '1' || key == '2' || key == '3')
            {
                addCoords(Cursor.Position.X, Cursor.Position.Y, key);

                if(key == '1')
                    lbl1Set.Text = "SET";
                else if(key == '2')
                    lbl2Set.Text = "SET";
                else if (key == '3')
                    lbl3Set.Text = "SET";
            }

            if (key == '4')
            {
                posDic.Add("btnX", Cursor.Position.X);
                posDic.Add("btnY", Cursor.Position.Y);
                lblCraftBtn.Text = "SET";
            }

            if (e.KeyChar == '9')
            {
                if (gemTimer.Enabled)
                {
                    resetData();
                }
                else
                {
                    // Set the tier crafting counts
                    tier1 = Convert.ToInt32(txtGemCount.Text.ToString());
                    tier2 = (tier1 / 3) + tier1;
                    tier3 = (tier2 - tier1) / 3 + tier2;

                    // Give the user some info on the crap UI
                    lbl1Set.Text = tier1.ToString();
                    lbl2Set.Text = (tier2 - tier1).ToString();
                    lbl3Set.Text = (tier3 - tier2).ToString();
                    gemTimer.Enabled = true;
                }
            }
        }

    }
}
