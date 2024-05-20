using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MetroFramework;
using Guna;
using Guna.UI2.WinForms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Security.RightsManagement;

namespace ProjectRestaurantMS
{
    public partial class EmployeeRegistration : Form
    {
        public EmployeeRegistration()
        {
            InitializeComponent();
        }

        //create the database connections
        SqlConnection connection =  new SqlConnection("Data Source=DESKTOP-DPD4LNN;Initial Catalog=RestaurantManagementSystem;Integrated Security=True");
        SqlCommand command;
        string sql;

        private void guna_TopPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna_backButton_Click(object sender, EventArgs e)
        {
            ManagerMain main = new ManagerMain();
            if (!string.IsNullOrEmpty(txt_fname.Text) || !string.IsNullOrEmpty(txt_lname.Text) || !string.IsNullOrEmpty(txt_fname.Text) || !string.IsNullOrEmpty(txt_email.Text) ||
                !string.IsNullOrEmpty(txt_tp.Text) || !string.IsNullOrEmpty(txt_address.Text) ||  !string.IsNullOrEmpty(txt_username.Text) || 
                !string.IsNullOrEmpty(txt_password.Text) || !string.IsNullOrEmpty(txt_confirmPassword.Text))
            {
                DialogResult result = MessageBox.Show("Do you wish to exit the form?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    main.Show();
                }
            }
            else if (string.IsNullOrEmpty(txt_fname.Text) || string.IsNullOrEmpty(txt_lname.Text) || string.IsNullOrEmpty(txt_fname.Text) || string.IsNullOrEmpty(txt_email.Text) ||
                string.IsNullOrEmpty(txt_tp.Text) || string.IsNullOrEmpty(txt_address.Text)  ||
                string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_password.Text) || string.IsNullOrEmpty(txt_confirmPassword.Text))
            {
                this.Close();
                main.Show();
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try 
            {
                //MANAGER                               //CASHIER                         //FRONT STAFF                         //KITCHEN STAFF
                if(cmb_Position.SelectedIndex == 0 || cmb_Position.SelectedIndex == 1 || cmb_Position.SelectedIndex == 2 || cmb_Position.SelectedIndex == 3) 
                {
                    //first name validations
                    if (string.IsNullOrEmpty(txt_fname.Text))
                    {
                        MetroMessageBox.Show(this, "Please enter your first name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_fname.Focus();
                    }
                    else if (txt_fname.Text.Any(char.IsDigit))
                    {
                        MetroMessageBox.Show(this, "Your first name cannot have numbers!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_fname.Focus();
                    }
                    else if(txt_fname.Text.Length <=1)
                    {
                        MetroMessageBox.Show(this, "Please enter your first name correctly!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_fname.Focus();
                    }

                    //last name validations
                    else if (string.IsNullOrEmpty(txt_lname.Text))
                    {
                        MetroMessageBox.Show(this, "Please enter your last name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_lname.Focus();
                    }
                    else if (txt_lname.Text.Any(char.IsDigit))
                    {
                        MetroMessageBox.Show(this, "Your last name cannot have numbers!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_lname.Focus();
                    }
                    else if (txt_lname.Text.Length <= 1)
                    {
                        MetroMessageBox.Show(this, "Please enter your last name correctly!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_fname.Focus();
                    }

                    //gender validations
                    else if((!btn_genderMale.Checked) && (!btn_genderFemale.Checked) && (!btn_genderOther.Checked))
                    {
                        MetroMessageBox.Show(this, "Please select a gender category!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //email validations
                    else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                    {
                        MetroMessageBox.Show(this, "Please enter a valid Email! \n Example: abc123@gmail.com", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_email.Focus();
                    }

                    //telephone verification
                    else if (!Regex.IsMatch(txt_tp.Text, @"^[0-9]{10}$"))
                    {
                        MetroMessageBox.Show(this, "Please enter a valid Telephone number! \n Your number should only have 10 digits!\n " +
                            "Your number should not have any characters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_tp.Focus();
                    }

                    //address validation
                    else if (string.IsNullOrEmpty(txt_address.Text))
                    {
                        MetroMessageBox.Show(this, "Please enter your address!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_address.Focus();
                    }
                    else if (txt_address.Text.Length <= 1)
                    {
                        MetroMessageBox.Show(this, "Please enter your address correctly!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_address.Focus();
                    }

                    //date of birth validation
                    else if((DateTime.Now.Year - txt_DOB.Value.Year) < 20 || (DateTime.Now.Year - txt_DOB.Value.Year) < 0)
                    {
                        MetroMessageBox.Show(this, "This age does not meet with our recruitment standards! \n Please enter a valid age!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_DOB.Focus();
                    }

                    //username validation
                    else if (string.IsNullOrEmpty(txt_username.Text))
                    {
                        MetroMessageBox.Show(this, "Please enter a username!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Focus();
                    }
                    else if (txt_username.Text.Length <= 1)
                    {
                        MetroMessageBox.Show(this, "Please enter a valid username!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Focus();
                    }

                    //password validation
                    else if(string.IsNullOrEmpty(txt_password.Text))
                    {
                        MetroMessageBox.Show(this, "Please enter a password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_password.Focus();
                    }
                    else if(!Regex.IsMatch(txt_password.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
                    {
                        MetroMessageBox.Show(this, "Password is not strong enough! \n Password does not meet requirements!\n" +
                            "Password needs at least one Uppercase letter\n " +
                            "Password needs at least one Lowercase letter\n " +
                            "Password needs to have at least one digit and at least one special character!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_password.Focus();
                    }

                    //confirm password validation
                    else if (string.IsNullOrEmpty(txt_confirmPassword.Text))
                    {
                        MetroMessageBox.Show(this, "Please enter a password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_confirmPassword.Focus();
                    }
                    else if (txt_confirmPassword.Text != txt_password.Text)
                    {
                        MetroMessageBox.Show(this, "The password does not match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_confirmPassword.Focus();
                    }
                    else if(register_picturebox.Image == null)
                    {
                        MetroMessageBox.Show(this, "Please upload a picture!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        connection.Open();
                        string radio_value = string.Empty;

                        if (btn_genderMale.Checked)
                        {
                            radio_value = "Male";
                        }
                        else if (btn_genderFemale.Checked)
                        {
                            radio_value = "Female";
                        }
                        else if (btn_genderOther.Checked)
                        {
                            radio_value = "Other";
                        }

                        string employee_ID = txt_ID.Text;
                        Image image = register_picturebox.Image;
                        if (image != null)
                        {
                            
                            byte[] imageData = ImageToByteArray(image);

                            command = new SqlCommand("Insert into EmployeeReg values (@Emp_ID, '" + cmb_Position.SelectedItem + "', " +
                                "'" + txt_fname.Text + "', '" + txt_lname.Text + "', @Gender, '" + txt_email.Text + "', '" + txt_tp.Text + "', " +
                                "'" + txt_address.Text + "', '" + txt_DOB.Value + "', '" + txt_age.Text + "', '" + txt_username.Text + "', " +
                                "'" + txt_password.Text + "', @User_Image)", connection);
                            command.Parameters.AddWithValue("@Emp_ID", employee_ID);
                            command.Parameters.AddWithValue("@Gender", radio_value);
                            command.Parameters.AddWithValue("@User_Image", imageData);

                            int i = command.ExecuteNonQuery();
                            if (i == 1)
                            {
                                MetroMessageBox.Show(this, "Your data has been saved!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_fname.Clear();
                                txt_age.Clear();
                                txt_address.Clear();
                                txt_email.Clear();
                                txt_lname.Clear();
                                txt_password.Clear();
                                txt_confirmPassword.Clear();
                                txt_tp.Clear();
                                txt_username.Clear();

                                Employee_ID();
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Please upload an image!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            register_picturebox.Focus();
                        }

                        connection.Close();
                    }
                }
            }
            catch (FormatException)
            {
                MetroMessageBox.Show(this, "Please enter correct values!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(SqlException)
            {
                MetroMessageBox.Show(this, "There is a database error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*catch(Exception)
            {
                MetroMessageBox.Show(this, "There has been an error, Please check again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
           
        }

        private byte[] ImageToByteArray(Image image)
        {
            MemoryStream stream = new MemoryStream();
            image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg); // Change format if required
            return stream.ToArray();
        }

        private void btn_Upload_Click(object sender, EventArgs e)   //UPLOAD BUTTON CODE
        {
            try
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Filter = "JPEG Files (*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG Files (*.png)|*.png";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openfile.FileName;

                    // Check if the selected file has a valid extension
                    if (selectedFilePath.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                        selectedFilePath.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                        selectedFilePath.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                    {
                        // Load the image into PictureBox
                        try
                        {
                            Image image = Image.FromFile(selectedFilePath);
                            register_picturebox.Image = image;
                        }
                        catch (Exception ex)
                        {
                            // Handle any errors that may occur while loading the image
                            MessageBox.Show("An error occurred while loading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Display an error message for invalid file types
                        MessageBox.Show("Please select a JPEG or PNG image file.", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(ArgumentException)
            {
                MetroMessageBox.Show(this, "Please select the correct file format!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(NotSupportedException)
            {
                MetroMessageBox.Show(this, "There is an error in uploading this image!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MetroMessageBox.Show(this, "An error has occured, Please try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   //CLOSE UPLOAD BUTTON


        private void txt_DOB_ValueChanged(object sender, EventArgs e)   //DATE TO CALCULATE AGE CODE
        {
            txt_age.Text = (DateTime.Now.Year - txt_DOB.Value.Year).ToString();
        }



        private void cmb_Position_SelectedIndexChanged(object sender, EventArgs e)  //WHEN NEW OPTION SELECTED CLEAR EVERYTHING
        {
            txt_fname.Text = string.Empty;
            txt_age.Text = string.Empty;
            txt_address.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_lname.Text = string.Empty;
            txt_password.Text = string.Empty;
            txt_confirmPassword.Text = string.Empty;
            txt_tp.Text = string.Empty;
            txt_username.Text = string.Empty;
        }

        private void btn_clear_Click(object sender, EventArgs e)    //CLEAR BUTTON CODE
        {
            txt_fname.Clear();
            txt_age.Clear();
            txt_address.Clear();
            txt_email.Clear();
            txt_lname.Clear();
            txt_password.Clear();
            txt_confirmPassword.Clear();
            txt_tp.Clear();
            txt_username.Clear();
        }

        
        private void EmployeeRegistration_Load(object sender, EventArgs e)  //PREPARE THE EMPLOYEE ID FIELD WHEN FORM LOADS
        {
            sql = "select MAX(Employee_ID) from EmployeeReg";
            command = new SqlCommand(sql, connection);

            connection.Open();
            var maxid = command.ExecuteScalar() as string;

            if (maxid == null)
            {
                txt_ID.Text = "EMP00001";
            }
            else
            {
                int intval = int.Parse(maxid.Substring(3, 5));
                intval++;
                txt_ID.Text = String.Format("EMP{0:00000}", intval);
            }
            connection.Close();
        }

        public void Employee_ID()   //SAME CODE AS THE ONE ABOVE, BUT THIS IS TO AUTO INCREMENT
        {
            sql = "select MAX(Employee_ID) from EmployeeReg";
            command = new SqlCommand(sql, connection);

            //connection.Open();
            var maxid = command.ExecuteScalar() as string;

            if (maxid == null)
            {
                txt_ID.Text = "EMP00001";
            }
            else
            {
                int intval = int.Parse(maxid.Substring(3, 5));
                intval++;
                txt_ID.Text = String.Format("EMP{0:00000}", intval);
            }
            //connection.Close();
        }

        //Address validation part 2
        private void txt_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsSpecialCharacter(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
                MessageBox.Show("Special characters are not allowed in the address.");
            }
        }
        private bool IsSpecialCharacter(char c)
        {
            // Define the list of special characters you want to restrict
            char[] specialCharacters = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', ',', '.', '?', '"', '\'', ':', '{', '}', '|', '<', '>' };

            return specialCharacters.Contains(c);
        }
    }
}
