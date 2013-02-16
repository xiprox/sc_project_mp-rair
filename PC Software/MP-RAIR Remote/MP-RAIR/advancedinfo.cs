using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MP_RAIR
{
    public partial class advancedinfo : Form
    {
        public advancedinfo()
        {
            InitializeComponent();
        }



        private void Control_Load(object sender, EventArgs e)
        {

        
       }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {

                case Keys.Up:
                    {
                        //Up Arrow is pressed. Therefore car needs to accelerate...
                        try
                        {
                            if (!serialPort1.IsOpen)
                            {
                                serialPort1.Open();
                                serialPort1.Write("1");
                                serialPort1.Close();
                            }
                        }
                        catch (Exception)
                        {
                            
                            throw;
                        }

                    } break;
                case Keys.Down:
                    {
                        //Down Arrow is pressed. Therefore car needs to decelerate...
                        try
                        {
                            if (!serialPort1.IsOpen)
                            {
                                serialPort1.Open();
                                serialPort1.Write("2");
                                serialPort1.Close();
                            }
                        }
                        catch (Exception)
                        {
                            
                            throw;
                        }

                    } break;
                case Keys.Right:
                    {
                        //Right Arrow is pressed. Therefore car needs to steer right...
                        try
                        {
                            if (!serialPort1.IsOpen)
                            {
                                serialPort1.Open();
                                serialPort1.Write("3");
                                serialPort1.Close();
                            }

                        }
                        catch (Exception)
                        {
                            
                            throw;
                        }
                    } break;
                case Keys.Left:
                    {
                        //Left Arrow is pressed. Therefore car needs to steer left...
                        try
                        {
                            if (!serialPort1.IsOpen)
                            {
                                serialPort1.Open();
                                serialPort1.Write("4");
                                serialPort1.Close();
                            }

                        }
                        catch (Exception)
                        {
                            
                            throw;
                        }
                    } break;

                default:
                    return true;
            };





            return base.ProcessCmdKey(ref msg, keyData);
        }
    
    
    }
}
