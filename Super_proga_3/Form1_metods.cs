using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Super_Proga_3
{
    public partial class Form1 : Form
    {
       

        /// <summary>
        /// создание массива панелей с текст боксами
        /// </summary>
        void Toolstrip_collection()
        {
            toolStrips.Add(toolStrip3);
            toolStrips.Add(toolStrip4);
        }

        /// <summary>
        /// получение данных пользователя для расчетов
        /// </summary>
        void Reading_Data()
        {
            count++;

            if (count == 1)
            {
                Label_info.Text = width;
                if (current != null) current.length = Convert.ToInt32(Get_dataTextBox.Text);
            }
            if (count == 2)
            {
                Label_info.Text = qt;
                Label_info2.Text = pcs;
                if (current != null) current.width = Convert.ToInt32(Get_dataTextBox.Text);
            }

            if (count == 3)
            {
                Label_info.Text = length;
                Label_info2.Text = mm;
                if (current != null) current.quantity = Convert.ToInt32(Get_dataTextBox.Text);
                count = 0;

                Calculations();
                Info_about_the_current_object();
                Creating_a_line();
                Write_string_line();
            }

            Get_dataTextBox.Clear();
        }

      
        /// <summary>
        /// вычисление результата из введенных данных пользователя
        /// </summary>
        void Calculations()
        {
            if (current != null)
            {
                current.Square = current.length * current.width * current.quantity * 0.000001;
                current.Amount = current.Square * current.Price;
                current.TotalSquare += current.Square;
                current.TotalAmount += current.Amount;                
                current.volume = current.Square * current.thickness * 0.001 * 1.75;
                current.TotalVolume += current.volume;
            }
        }


        /// <summary>
        /// создание строки расчета
        /// </summary>
        void Creating_a_line()
        {            
            Str.List = current.id + " " + current.Name + " "+current.Price +" "+ current.length+ " " + current.width + " " + current.quantity +" "
            + current.Square + " " + current.Amount + " " + current.thickness + " " + current.volume+ " \n";           
        }


        /// <summary>
        /// запись в файл текущей строки расчета
        /// </summary>
        void Write_string_line()
        {
            using (StreamWriter write = new StreamWriter(Str.Path_name, true))
            {
                write.Write(Str.List);               
            }

            if (File.Exists(Str.Path_name)) Str.Get_path_text = File.ReadAllText(Str.Path_name);                          
        }


        /// <summary>
        /// вывод данных о текщем объекте
        /// </summary>
        void Info_about_the_current_object()
        {
            A0.Text = current.Name;
            A1.Text = current.Price.ToString();
            A2.Text = current.Square.ToString();
            A3.Text = current.TotalSquare.ToString();
            A4.Text = current.Amount.ToString();
            A5.Text = current.TotalAmount.ToString();
            A6.Text = current.thickness.ToString();
            A7.Text = current.TotalVolume.ToString();
        }


        /// <summary>
        /// Включение или отключение панели выбора толщины
        /// </summary>
        /// <param name="panel"></param>
        void Choose_the_thickness(bool panel = true)
        {
            if (panel)
            {
                panel1.Visible = true;
                info.Visible = false; 
                toolStrip1.Visible = toolStrip2.Visible = false; 
            }
            else
            {
                panel1.Visible = false;
                info.Visible = true;
                toolStrip1.Visible = toolStrip2.Visible = true;               
            }           
        }


        /// <summary>
        /// создание объекта или выбор из списка обьектов
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        void Creating_or_selecting_an_object(in string name, ref int price)
        {          
            bool search = false;

            for (int i = 0; i < woods.Count; i++)
            {
                if (woods[i].Name == name && woods[i].Price == price)
                {
                   search = true;                    
                   current = woods[i]; break;
                }
            }

            if (current == null || !search)
            {                
                woods.Add(new Wood(name, price));               
                current = woods[woods.Count - 1];
                current.thickness = Convert.ToInt32(comboBox1.SelectedItem);
            }

            current.id = (100 * (iterator_type_wood + 1)) + (Convert.ToInt32(comboBox1.SelectedIndex) + 1)+(0.00001 * current.Price);          
        }


        /// <summary>
        /// получение  выбранной толщины
        /// </summary>
       


        /// <summary>
        /// получение имени файла из пути файла
        /// </summary>
        void File_name()
        {
            string[] s = Str.Path_name.Split('\\');
            string stroka = s[6];
            Current_file.Text = stroka;           
        }


        /// <summary>
        /// удаление текущих обьктов и очиска информаццонной панели 
        /// </summary>
        void Clear_form1()
        {
            info.Visible = false;
            woods.Clear();
            for (int i = 0; i < toolStrip1.Items.Count; i++) toolStrip1.Items[i].Text = "";
        }


        /// <summary>
        /// включение или отключение элементов меню ("выбор породы","лист расчетов")
        /// </summary>
        /// <param name="enabled"></param>
        void Enabled_menu(bool enabled = false)
        {                      
             Menu_type_wood.Enabled = enabled;
             Menu_List_rashet.Enabled = enabled;
        }


        /// <summary>
        /// метод получает в переменную новый прайс после редактирования в TextBoxes
        /// </summary>
        /// <param name="toolstrips"></param>
        void Return_new_Price(ref string price_text )
        {
            Str.Price_text = string.Empty;

            for (int i = 0; i < toolStrips.Count; i++)
            {
                for (int j = 1; j < toolStrips[i].Items.Count; j++)
                {
                    price_text += toolStrips[i].Items[j] + " ";
                }
                price_text += "\n";
            }
            
        }

        /// <summary>
        /// метод перезаписывает массив с ценами из переменной полученной из редактированных TextBoxes 
        /// 
        /// </summary>
        /// <param name="arrprice"></param>
        void New_arr_Price(ref string price_text, ref double[] arrprice,ref int[] pricevork)
        {
          

            string[] s = price_text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < s.Length; i++)
            {
                string[] temp = s[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < temp.Length; j++)
                {
                    if (i == 0) arrprice [j] = Convert.ToInt32(temp[j]);
                    if (i == 1) pricevork[j] = Convert.ToInt32(temp[j]);
                } 
            }         
        }


        /// <summary>
        /// TextBoxes получают данные из массива прайса
        /// </summary>
        /// <param name="arr_price_m3"></param>
        /// <param name="toolstrips"></param>
        void Toolstrip_Extracts_data_array(ref int []arr_price_worc,ref double[] arr_price_m3, ref List<ToolStrip> toolstrips)
        {
            for (int j = 1; j < toolStrip3.Items.Count; j++)
            {
                toolStrip3.Items[j].Text = arr_price_m3[j-1].ToString();
                toolStrip4.Items[j].Text = arr_price_worc[j-1].ToString();                      
            }
        }


        /// <summary>
        /// получает в переменную данные из массива прайса
        /// </summary>
        /// <param name="arr_price"></param>
        /// <param name="All_text"></param>
        void Price_text_ecstracts_Array_data_Price(ref double[] arr_price, ref string All_text)
        {            
                for (int j = 0; j < arr_price.GetLength(0); j++)
                {
                    All_text += arr_price[j].ToString() + " ";
                }
                All_text += "\n";            
        }

        /// <summary>
        /// метод для создания папок в desktop and app data local
        /// </summary>
        /// <param name="path"></param>
        void Creating_a_Folder(string path)
        {
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
        }


       void Create_Price()
        {
            for(int i = 0;i< Arr_Furniture_Panel.GetLength(1); i++)
            {
                for(int j = 0; j < Arr_Furniture_Panel.GetLength(2); j++)
                {                     
                    double temp = Convert.ToDouble(Price_of_the_board[i] * Arr_thickess[j] * 0.00175);

                    Arr_Furniture_Panel[0,i, j] = Arr_Furniture_Panel[1, i, j]  = Convert.ToInt32(temp);
                   
                    Arr_Furniture_Panel[1,i, j] += Convert.ToInt32( Arr_price_work[i] * Cooficient_work[j]);
                                           
                    Rounding(ref Arr_Furniture_Panel[1,i, j],false);

                    Rounding(ref Arr_Furniture_Panel[0, i, j],false);
                }
            }
        }


        /// <summary>
        /// когда истинно округляет до ближайшей  500 или 1000 когда ложно округляет до ближайшего 100
        /// </summary>
        /// <param name="value"></param>
        /// <param name="rounding_1000"></param>
        void Rounding(ref int value,bool rounding_1000 = true)
        {                       
           if(rounding_1000)
           { 
             int temp  = value;
             temp  = (temp / 1000 * 1000);
             if (value - temp > 700) value = temp += 1000;
             else if (value - temp < 200) value = temp;
             else value = temp += 500;
           }
           else value = (value / 100 * 100) + 100;
        }



        void Price_open()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    toolStrip6.Items[i + 1].Text += "\n" + Arr_Furniture_Panel[1, j, i];
                }
            }
            for (int i = 0; i < 6; i++) toolStrip6.Items[0].Text += "\n" + ArrName[i];
        }

        void Clear_tablo()
        {
            for (int i = 0; i < 11; i++)
            {
                ArrClear[i] = toolStrip6.Items[i].Text;
            }
        }

        void Default_tablo()
        {
            for (int i = 0; i < 11; i++)
            {
                toolStrip6.Items[i].Text = ArrClear[i];
            }
        }



    }
}
