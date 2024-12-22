using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Super_Proga_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           

            Toolstrip_collection();
          
            Creating_a_Folder(Str.path_desktop_save);

            Creating_a_Folder(Str.Path_App_Data_Super_Proga);

            if (!File.Exists(Str.Path_App_Data_Super_Proga_Price_txt) || File.ReadAllText(Str.Path_App_Data_Super_Proga_Price_txt) == string.Empty)
            {                              
                Price_text_ecstracts_Array_data_Price(ref Price_of_the_board,ref Str.Price_text);

                File.WriteAllText(Str.Path_App_Data_Super_Proga_Price_txt, Str.Price_text);                                                               
            }

            else
            {
                Str.Price_text = File.ReadAllText(Str.Path_App_Data_Super_Proga_Price_txt);

                if (Str.Price_text!=string.Empty) New_arr_Price(ref Str.Price_text, ref Price_of_the_board, ref Arr_price_work);                               
            }

            Clear_tablo();
            Create_Price();
            Price_open();

            Str.Price_text = string.Empty;
        }


              
        /// <summary>
        /// валидация ввода (только цифры)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Get_dataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// считывание текста textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Get_dataTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Get_dataTextBox.Text != "")
            {
                e.Handled = true; e.SuppressKeyPress = true;
                Reading_Data();
            }
        }


        /// <summary>
        /// инициализация   выбранного обьекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {                                                                                                                                 
               Creating_or_selecting_an_object(in ArrName[iterator_type_wood],ref Arr_Furniture_Panel[1,iterator_type_wood,comboBox1.SelectedIndex]);
                                           
               Info_about_the_current_object();
                                
               Choose_the_thickness(false);

               Get_dataTextBox.Focus();                                                
        }


        #region type wood button click
        
        private void Sosna_button_Click(object sender, EventArgs e)
        {
            iterator_type_wood = _sosna;
           
            Choose_the_thickness();
        }

        private void Bereza_button_Click(object sender, EventArgs e)
        {
            iterator_type_wood = _bereza;

            Choose_the_thickness();
        }

        private void Listw_button_Click(object sender, EventArgs e)
        {
            iterator_type_wood = _listw;

            Choose_the_thickness();
        }

        private void Buc_button_Click(object sender, EventArgs e)
        {
            iterator_type_wood = _buc;
            Choose_the_thickness();
        }

        private void Yasen_button_Click(object sender, EventArgs e)
        {
            iterator_type_wood = _yasen;
            Choose_the_thickness();
        }

        private void Dub_button_Click(object sender, EventArgs e)
        {
            iterator_type_wood = _dub;
            Choose_the_thickness();
        }
        #endregion


        #region create end open file
        private void Open_file_Click(object sender, EventArgs e)
        {
            open_file = true;

            if (file_click)
            {                              
                Clear_form1();

                OpenFileDialog openFileDialog = new OpenFileDialog

                {   InitialDirectory = Str.path_desktop_save  }; // открываеть нужную папку с файлами
                                  
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Str.Path_name = openFileDialog.FileName; 

                    Str.Get_path_text = File.ReadAllText(Str.Path_name); 

                    File_name();

                    file_click = false;

                    Enabled_menu(true);

                    toolStrip1.Visible = toolStrip2.Visible = true;
                }
            }

            else 
            {               
                panel2.Visible = true;

                label2.Text = " вы хотите загрузить новый?";
            }
        }

       

        private void Create_file_Click(object sender, EventArgs e)
        {
            open_file = false;

            if (file_click)
            {
                Clear_form1();
              
                toolStrip1.Visible = toolStrip2.Visible = panel2.Visible =  false;

                File_creation_window.Visible = true;

                toolStripTextBox1.Focus();                             
            }

            else {  panel2.Visible = true; label2.Text = " вы хотите создать новый?"; }
            
        }

        private void Creating_file_TextBox1_KeyDown(object sender, KeyEventArgs e)
        {          
            if (e.KeyCode == Keys.Enter)
            {
                Str.Path_name = Str.path_desktop_save + toolStripTextBox1.Text + ".txt";
               
                StreamWriter file = new StreamWriter(Str.Path_name);

                if (File.Exists(Str.Path_name))
                {
                    file.Close();
                    
                    File_name();

                    toolStripTextBox1.Clear();
                    
                    File_creation_window.Visible = false; 

                    toolStrip1.Visible = toolStrip2.Visible = true;

                    file_click = false;

                    Enabled_menu(true);
                }
            }
        }
        #endregion

        /// <summary>
        /// скрыть все открытые панели 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            File_creation_window.Visible = false;

            panel1.Visible = panel2.Visible = false;
           
            tableLayoutPanel1.Visible = false;

            info.Visible = false;

            flowLayoutPanel1.Visible = false;
        }

        /// <summary>
        /// открытие формы 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void List_rashet_Click(object sender, EventArgs e)
        {
            form2 = new Form2
            {
                Tag = this
            };

            form2.Show(this);
            Hide();
        }

        /// <summary>
        /// показать  или радактировать прайс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Change_All_Price_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
           
           Toolstrip_Extracts_data_array(ref Arr_price_work,ref Price_of_the_board,ref toolStrips);
        }
           
        
        /// <summary>
        /// подтверждение изменения прайса и перезапись массива Price_of_the_board и File_price.txt новыми ценами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            Return_new_Price(ref Str.Price_text);

            New_arr_Price(ref Str.Price_text, ref Price_of_the_board,ref Arr_price_work);

            File.WriteAllText(Str.Path_App_Data_Super_Proga_Price_txt, Str.Price_text);

            Str.Price_text = string.Empty;

            toolStrip1.Visible = toolStrip2.Visible = false;

            tableLayoutPanel1.Visible = false;

            Create_Price();
            Default_tablo();
            Price_open();
        }

              
        private void Button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;    
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            file_click = true;  

            if (open_file)   Open_file_Click(this, e); 

            else Create_file_Click(this, e);  

            panel2.Visible = false;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;           
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            toolStrip1.Visible=toolStrip2.Visible = false;
        }

    }
}
