/**
 *  @file           Form1.cs / FormMegaManIIPassGenGB
 *  @brief          Password Generator for the Nintendo Gameboy Game MegaMan II
 *  @copyright      Shawn M. Crawford 2019
 *  @date           04/11/2019
 *
 *  @remark Author  Shawn M. Crawford (sleepy9090)
 *
 *  @note           N/A
 *
 */
using System;
using System.Windows.Forms;

namespace MegaManIIPassGenGB
{
    public partial class FormMegaManIIPassGenGB : Form
    {
        public FormMegaManIIPassGenGB()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            DisablePasswordCheckboxes();
            SetComboBoxes();
        }

        private void DisablePasswordCheckboxes()
        {
            checkBoxA1.Enabled = false;
            checkBoxA2.Enabled = false;
            checkBoxA3.Enabled = false;
            checkBoxA4.Enabled = false;

            checkBoxB1.Enabled = false;
            checkBoxB2.Enabled = false;
            checkBoxB3.Enabled = false;
            checkBoxB4.Enabled = false;

            checkBoxC1.Enabled = false;
            checkBoxC2.Enabled = false;
            checkBoxC3.Enabled = false;
            checkBoxC4.Enabled = false;

            checkBoxD1.Enabled = false;
            checkBoxD2.Enabled = false;
            checkBoxD3.Enabled = false;
            checkBoxD4.Enabled = false;
        }

        private void ClearPasswordCheckboxes()
        {
            checkBoxA1.Checked = false;
            checkBoxA2.Checked = false;
            checkBoxA3.Checked = false;
            checkBoxA4.Checked = false;

            checkBoxB1.Checked = false;
            checkBoxB2.Checked = false;
            checkBoxB3.Checked = false;
            checkBoxB4.Checked = false;

            checkBoxC1.Checked = false;
            checkBoxC2.Checked = false;
            checkBoxC3.Checked = false;
            checkBoxC4.Checked = false;

            checkBoxD1.Checked = false;
            checkBoxD2.Checked = false;
            checkBoxD3.Checked = false;
            checkBoxD4.Checked = false;
        }

        private void SetComboBoxes()
        {
            for (int x = 0; x <=4; x++)
            {
                comboBoxAmountEnergyTanks.Items.Add(x);
            }
            comboBoxAmountEnergyTanks.SelectedIndex = 0;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int energyTankAmount = (int)comboBoxAmountEnergyTanks.SelectedItem;

            bool hasMetalBlade = checkBoxMetalBlade.Checked;
            bool hasLeafShield = checkBoxLeafShield.Checked;
            bool hasAirShooter = checkBoxAirShooter.Checked;
            bool hasCrashBomber = checkBoxCrashBomber.Checked;
            bool hasHardKnuckle = checkBoxHardKnuckle.Checked;
            bool hasTopSpin = checkBoxTopSpin.Checked;
            bool hasNeedleCannon = checkBoxNeedleCannon.Checked;
            bool hasMagnetMissile = checkBoxMagnetMissile.Checked;

            // If any of the last four weapons are selected, then the first four weapons must be selected as well.
            if ((hasHardKnuckle || hasTopSpin || hasNeedleCannon || hasMagnetMissile) &&
                    (!hasMetalBlade || !hasLeafShield || !hasAirShooter || !hasCrashBomber))
            {
                MessageBox.Show("Selecting secondary weapons requires acquirement of all the primary weapons.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                checkBoxMetalBlade.Checked = true;
                checkBoxLeafShield.Checked = true;
                checkBoxAirShooter.Checked = true;
                checkBoxCrashBomber.Checked = true;

                return;
            }

            if (energyTankAmount == 0)
            {
                checkBoxA1.Checked = true;
                checkBoxB3.Checked = true;
                checkBoxB4.Checked = true;
                checkBoxC3.Checked = true;
                checkBoxD2.Checked = true;
                checkBoxD4.Checked = true;

                if (hasAirShooter)
                {
                    checkBoxA1.Checked = false;
                    checkBoxA2.Checked = true;
                    checkBoxB1.Checked = true;
                }

                if (hasCrashBomber)
                {
                    checkBoxD1.Checked = true;
                }

                if (hasLeafShield)
                {
                    checkBoxA3.Checked = true;
                    checkBoxB4.Checked = false;
                }

                if (hasMetalBlade)
                {
                    checkBoxA3.Checked = true;
                    checkBoxB3.Checked = false;
                    checkBoxB4.Checked = false;
                }

                if (hasLeafShield && hasMetalBlade)
                {
                    checkBoxB4.Checked = true;
                }

                if (hasHardKnuckle)
                {
                    checkBoxC3.Checked = false;
                    checkBoxC4.Checked = true;
                }

                if (hasTopSpin)
                {
                    checkBoxA1.Checked = true;
                    checkBoxB1.Checked = false;
                }

                if (hasNeedleCannon)
                {
                    checkBoxC2.Checked = true;
                    checkBoxD2.Checked = false;
                }

                if (hasMagnetMissile)
                {
                    checkBoxC3.Checked = false;
                }

                if (hasHardKnuckle && hasMagnetMissile)
                {
                    checkBoxC3.Checked = true;
                    checkBoxC4.Checked = true;
                    checkBoxD4.Checked = false;
                }
            }
            else if (energyTankAmount == 1)
            {
                checkBoxA2.Checked = true;
                checkBoxB1.Checked = true;
                checkBoxB4.Checked = true;
                checkBoxC1.Checked = true;
                checkBoxC3.Checked = true;
                checkBoxD1.Checked = true;
                checkBoxD4.Checked = true;

                if (hasAirShooter)
                {
                    checkBoxB3.Checked = true;
                    checkBoxB4.Checked = false;
                }

                if (hasCrashBomber)
                {
                    checkBoxC3.Checked = false;
                }

                if (hasLeafShield)
                {
                    checkBoxD2.Checked = true;
                }

                if (hasMetalBlade)
                {
                    checkBoxC2.Checked = true;
                    checkBoxD1.Checked = false;
                    checkBoxD2.Checked = false;
                }

                if (hasLeafShield && hasMetalBlade)
                {
                    checkBoxD1.Checked = true;
                }

                if (hasHardKnuckle)
                {
                    checkBoxA1.Checked = true;
                    checkBoxA2.Checked = false;
                    checkBoxB1.Checked = false;
                }

                if (hasTopSpin)
                {
                    checkBoxA3.Checked = true;
                    checkBoxB3.Checked = false;
                    checkBoxB4.Checked = true;
                }

                if (hasNeedleCannon)
                {
                    checkBoxC3.Checked = true;
                    checkBoxD4.Checked = false;
                }

                if (hasMagnetMissile)
                {
                    checkBoxA2.Checked = false;
                    checkBoxB1.Checked = true;
                }

                if (hasHardKnuckle && hasMagnetMissile)
                {
                    checkBoxA1.Checked = false;
                    checkBoxA2.Checked = true;
                    checkBoxB1.Checked = false;
                }
            }
            else if (energyTankAmount == 2)
            {
                checkBoxB1.Checked = true;
                checkBoxB2.Checked = true;
                checkBoxC4.Checked = true;
                checkBoxD2.Checked = true;
                checkBoxD3.Checked = true;
                checkBoxD4.Checked = true;

                if (hasAirShooter)
                {
                    checkBoxD1.Checked = true;
                }

                if (hasCrashBomber)
                {
                    checkBoxA2.Checked = true;
                    checkBoxB1.Checked = false;
                }

                if (hasLeafShield)
                {
                    checkBoxC3.Checked = true;
                    checkBoxC4.Checked = false;
                    checkBoxD4.Checked = false;
                }

                if (hasMetalBlade)
                {
                    checkBoxC4.Checked = true;
                    checkBoxD4.Checked = false;
                }

                if (hasHardKnuckle)
                {
                    checkBoxA3.Checked = true;
                    checkBoxB3.Checked = true;
                }

                if (hasTopSpin)
                {
                    checkBoxC2.Checked = true;
                    checkBoxD1.Checked = false;
                }

                if (hasNeedleCannon)
                {
                    checkBoxB1.Checked = true;
                }

                if (hasMagnetMissile)
                {
                    checkBoxA3.Checked = true;
                    checkBoxB3.Checked = false;
                }

                if (hasHardKnuckle && hasMagnetMissile)
                {
                    checkBoxA3.Checked = false;
                    checkBoxB4.Checked = true;
                }
            }
            else if (energyTankAmount == 3)
            {
                checkBoxA1.Checked = true;
                checkBoxA3.Checked = true;
                checkBoxA4.Checked = true;
                checkBoxB1.Checked = true;
                checkBoxC1.Checked = true;
                checkBoxC3.Checked = true;
                checkBoxC4.Checked = true;

                if (hasAirShooter)
                {
                    checkBoxC4.Checked = false;
                    checkBoxD4.Checked = true;
                }

                if (hasCrashBomber)
                {
                    checkBoxA3.Checked = false;
                    checkBoxB3.Checked = true;
                    checkBoxB4.Checked = true;
                }

                if (hasLeafShield)
                {
                    checkBoxA1.Checked = false;
                }

                if (hasMetalBlade)
                {
                    checkBoxA1.Checked = true;
                    checkBoxA2.Checked = true;
                    checkBoxB1.Checked = false;
                }

                if (hasLeafShield && hasMetalBlade)
                {
                    checkBoxA2.Checked = false;
                }

                if (hasHardKnuckle)
                {
                    checkBoxD1.Checked = true;
                }

                if (hasTopSpin)
                {
                    checkBoxC3.Checked = false;
                    checkBoxC4.Checked = true;
                }

                if (hasNeedleCannon)
                {
                    checkBoxA3.Checked = true;
                    checkBoxB4.Checked = false;
                }

                if (hasMagnetMissile)
                {
                    checkBoxD2.Checked = true;
                }
            }
            else if (energyTankAmount == 4)
            {
                checkBoxA2.Checked = true;
                checkBoxA4.Checked = true;
                checkBoxB3.Checked = true;
                checkBoxB4.Checked = true;
                checkBoxC1.Checked = true;
                checkBoxC2.Checked = true;
                checkBoxD2.Checked = true;
                checkBoxD3.Checked = true;

                if (hasAirShooter)
                {
                    checkBoxA2.Checked = false;
                    checkBoxB1.Checked = true;
                }

                if (hasCrashBomber)
                {
                    checkBoxC4.Checked = true;
                }

                if (hasLeafShield)
                {
                    checkBoxC2.Checked = false;
                    checkBoxD1.Checked = true;
                    checkBoxD2.Checked = false;
                }

                if (hasMetalBlade)
                {
                    checkBoxC2.Checked = true;
                    checkBoxD2.Checked = false;
                }

                if (hasTopSpin)
                {
                    checkBoxA1.Checked = true;
                    checkBoxB1.Checked = false;
                }

                if (hasNeedleCannon)
                {
                    checkBoxC3.Checked = true;
                    checkBoxC4.Checked = false;
                }

                if (hasMagnetMissile)
                {
                    checkBoxA3.Checked = true;
                    checkBoxB3.Checked = false;
                    checkBoxB4.Checked = false;
                }

                if (hasHardKnuckle)
                {
                    checkBoxB3.Checked = true;
                    checkBoxB4.Checked = false;
                }
            }
        }
    }
}
