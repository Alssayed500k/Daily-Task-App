using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_BoxList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum enCompoBoxMode { Add,Edit}
        enum enMyWonScialMedia { linkededIn , github,Whatsapp}

        enCompoBoxMode eMode = enCompoBoxMode.Add;

        private string FileName = "Daily Task.txt";
       
        private void UpDateToProgress( int TaskNumber ,int TotalCompeletedTask)
        {
            byte Percentage;

            progressBar1.Maximum = TaskNumber;
            progressBar1.Value = TotalCompeletedTask;

            Percentage = Convert.ToByte(TotalCompeletedTask * 100 / TaskNumber);
            lbRate.Text = Percentage + "%".ToString();
            
        }
        private void UpdateToTaskNumber()
        {
            lbTasksNumber.Text = cbBody.Items.Count.ToString();
   
        }
        private void UpDateToCompeletedTask(ItemCheckEventArgs e)
        {
            int Counter = cbBody.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked)
            {
                Counter++;
            }

            else
                Counter--;
            lbTaskChecked.Text = Counter.ToString();

            UpDateToProgress(cbBody.Items.Count ,Counter );
           
        }
        private void SaveTask(enCompoBoxMode eMode )
        {
            if (!string.IsNullOrEmpty(tbAddTask.Text ) && eMode == enCompoBoxMode.Add)
            {

                cbBody.Items.Add(tbAddTask.Text);
                UpdateToTaskNumber();
                
            }
            else if (!string.IsNullOrEmpty(tbAddTask.Text) && eMode == enCompoBoxMode.Edit)
            {
                EditTask();
            }
            else
            {
                MessageBox.Show("Invalid add task!" , "Error",MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }
            tbpnl.Visible = false;
            SaveAllDataInDatabase();
    

        }
        private void AddNewTask()
        {
            tbpnl.Visible = true;
           
        }
        private void DeleteTask()
        {


            try
            {
                cbBody.Items.RemoveAt(cbBody.SelectedIndex);
            }
             catch 
            {
                MessageBox.Show("First Select Item To delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UpdateToTaskNumber();
            SaveAllDataInDatabase();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(45,125, 255);
            cbBody.BackColor = Color.FromArgb(248, 249, 250);

            if (!File.Exists(FileName ))
                return;

            LoadAllDataFromDatabase(FileName);
            UpDateToProgress(cbBody.Items.Count , cbBody.CheckedItems.Count);
            UpdateToTaskNumber();
            lbTaskChecked.Text = cbBody.CheckedItems.Count.ToString();
           
            
        }
        private void CheckedAllItems()
        {
          
            
              for(short i =0 ; i < cbBody.Items.Count; i++)
              {
                cbBody.SetItemChecked(i, true);
              }
        }
        private void UncheckedAllItems()
        {
            for (short i =0 ;i < cbBody.Items.Count;i++)
            {
                cbBody.SetItemChecked(i, false);
            }
        }
        private void EditTask()
        {
     
            try
            {
                cbBody.Items[cbBody.SelectedIndex] = tbAddTask.Text;
            }
            catch
            {
                MessageBox.Show("First Select Item To Edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
 
           
        }
        private void ClearAllItems()
        {
            if ( cbBody.Items.Count > 0)
            {
                cbBody.Items.Clear();
                File.Delete(FileName);//Delete file
            }

        }
         private void SaveAllDataInDatabase( string FileName = "Daily Task.txt")
         {
          
            if ( cbBody.Items.Count > 0 )
            {
                string CheckedItem = "1";
                string UnCheckedItem ;

                File.Delete(FileName);
                
                for (short i =0; i < cbBody.Items.Count; ++i)
                {
                    if (cbBody.GetItemChecked(i))
                    {
                        CheckedItem += cbBody.Items[i].ToString();
                        File.AppendAllText(FileName, CheckedItem + Environment.NewLine);
                    }
                    else
                    {
                        UnCheckedItem = cbBody.Items[i].ToString();
                        File.AppendAllText(FileName, UnCheckedItem + Environment.NewLine);
                    }
                    CheckedItem = "1";

                  
                }
            }    
         }
        private void LoadAllDataFromDatabase(string FileName)
        {
            if (!File.Exists(FileName))
                return;

            using (StreamReader Reader = new StreamReader(FileName))
            {
                string Line = "";

                //Read from file
                while ((Line = Reader.ReadLine()) != null)
                {

                    if (!string.IsNullOrEmpty(Line))
                    {
                        if (Line[0] == '1')
                        {
                            cbBody.Items.Add(Line.Substring(1, Line.Length - 1));//Add item

                            cbBody.SetItemChecked(cbBody.Items.Count - 1, true);//Checked item

                        }
                        else
                        {
                            cbBody.Items.Add(Line);
                        }
                    }

                }
            }
            
        }

        private void MyAccountInSocialMedia(enMyWonScialMedia eAccount)
        {
            switch (eAccount)
            {
                case  enMyWonScialMedia.github:
                    System.Diagnostics.Process.Start("https://github.com/Alssayed500k");
                    break;
                case enMyWonScialMedia.linkededIn:
                    System.Diagnostics.Process.Start("https://linkedin.com/in/anwer-el-sayed-a63106227");
                    break;
            }
            

            }
        private void button2_Click(object sender, EventArgs e)
        {
            eMode = enCompoBoxMode.Add;
            AddNewTask();
            
        }

        private void tbAddTask_TextChanged(object sender, EventArgs e)
        {
            lbInsidetb.Visible = false;
            SaveAllDataInDatabase();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (eMode==enCompoBoxMode.Add)
                 SaveTask(enCompoBoxMode.Add);
            else
                SaveTask(enCompoBoxMode.Edit);

        }

        private void cbBody_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
            UpDateToCompeletedTask(e);
            BeginInvoke(new Action(() =>
            {
                SaveAllDataInDatabase();
            }));
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteTask();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            eMode = enCompoBoxMode.Edit;
            AddNewTask();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAllItems();
        }

        private void btnChected_Click_1(object sender, EventArgs e)
        {
            CheckedAllItems();
        }

        private void btnUnSelected_Click(object sender, EventArgs e)
        {
            UncheckedAllItems();
        }

        private void pcGithub_Click(object sender, EventArgs e)
        {
            MyAccountInSocialMedia(enMyWonScialMedia.github);
        }

        private void pcLinkedin_Click(object sender, EventArgs e)
        {
            MyAccountInSocialMedia(enMyWonScialMedia.linkededIn);
        }
    }
}
