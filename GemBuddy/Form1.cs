/* Copyright 2013 uberamd
 * This file is part of GemBuddy.
 * 
 * GemBuddy is free software: you can redistribute it and/or 
 * modify it under the terms of the GNU General Public License 
 * as published by the Free Software Foundation, either version 3 
 * of the License, or (at your option) any later version.
 * 
 * GemBuddy is distributed in the hope that it will be useful, 
 * but WITHOUT ANY WARRANTY; without even the implied warranty 
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See 
 * the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License 
 * along with GemBuddy. If not, see http://www.gnu.org/licenses/.
*/

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
using System.Diagnostics; // debugging

namespace GemBuddy
{
    public partial class Form1 : Form
    {

        // Needed to move cursor around and click
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        // This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }

        // Dictionary used to store XY positions
        Dictionary<string, int> posDic = new Dictionary<string, int>();

        // Other variable declarations
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

        // In order to introduce some semblence of humanness lets sleep
        // the mouse clicks when selecting then ext gem type. By default
        // we'll sleep for between 4 and 12 seconds, though you can 
        // deviate if you want
        private void genRandomSleepValue(int low = 4000, int high = 12000)
        {
            gemTimer.Enabled = false;
            Random seed = new Random();
            System.Threading.Thread.Sleep(seed.Next(low, high));
            gemTimer.Enabled = true;
        }

        private void gemTimer_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("--> Ticked! Counter => " + counter.ToString() + " tier1 => " + tier1.ToString() + " tier2 => " + tier2.ToString() + " tier3 => " + tier3.ToString());
            if (counter < tier1 && posDic.ContainsKey("pos1X"))
            {
                // Works pretty simply, if gem1 hasn't been picked
                // we'll pick the gem by clicking the coords
                // then we'll move on to the lame "craft" button
                // clicking. Once the counter reaches a [tier1]
                // it'll fail to the next else if, etc.
                if (!hasPicked1)
                {
                    Debug.WriteLine("----> Moving into notHasPicked1");
                    LeftMouseClick(posDic["pos1X"], posDic["pos1Y"]);
                    hasPicked1 = true;
                    genRandomSleepValue();
                }
                Debug.WriteLine("----> Clicking tier1 with values " + tier1.ToString() + " " + counter.ToString());
                LeftMouseClick(posDic["btnX"], posDic["btnY"]);
                counter++;
                lbl1Set.Text = (tier1 - counter).ToString();
            } 
            else if(counter < tier2 && posDic.ContainsKey("pos2X")) 
            {
                if (!hasPicked2)
                {
                    LeftMouseClick(posDic["pos2X"], posDic["pos2Y"]);
                    hasPicked2 = true;
                    genRandomSleepValue();
                }
                LeftMouseClick(posDic["btnX"], posDic["btnY"]);
                counter++;
                lbl2Set.Text = (tier2 - counter).ToString();
            }
            else if (counter < tier3 && posDic.ContainsKey("pos3X"))
            {
                if (!hasPicked3)
                {
                    LeftMouseClick(posDic["pos3X"], posDic["pos3Y"]);
                    hasPicked3 = true;
                    genRandomSleepValue();
                }
                LeftMouseClick(posDic["btnX"], posDic["btnY"]);
                counter++;
                lbl3Set.Text = (tier3 - counter).ToString();
            } else {
                // after we've iterated through reset the data
                resetData();
            }
        }

        private void addCoords(int x, int y, char set)
        {
            try
            {
                // Attempt removal of key
                posDic.Remove("pos" + set + "X");
                posDic.Remove("pos" + set + "Y");
            }
            catch (Exception e) { Debug.WriteLine(e.ToString());  }

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

        // This is incredibly ugly and makes me sad, but here goes the reasoning:
        // We need to lose focus from the textbox in order for the application to
        // capture keypress events. The easiest way to lose textbox focus? 
        // Click another control that can gain focus, aka a button. So we make
        // the user click btnSet so it steals focus allowing us to capture keystrokes
        // Blah.
        private void btnSet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            // User uses 1, 2, and 3 to set the gem locations
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

            // User presses 4 to set the craft button coords
            if (key == '4')
            {
                try
                {
                    // Attempt removal of key
                    posDic.Remove("btnX");
                    posDic.Remove("btnY");
                }
                catch (Exception ex) { Debug.WriteLine(ex.ToString()); }

                posDic.Add("btnX", Cursor.Position.X);
                posDic.Add("btnY", Cursor.Position.Y);
                lblCraftBtn.Text = "SET";
            }

            // The 9 key will start/stop the program
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

    } // end partial class
} // end gembuddy namespace
