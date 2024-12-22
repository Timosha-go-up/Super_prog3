using System;
using System.Windows.Forms;

namespace Super_Proga_3
{
    public partial class Form2 : Form
    {

        string[][] STR;
        static readonly int Length = 13;
        string[] a;
       bool Sorted = false;
        bool Unsorted_detected = true;
        const int square = 6;
        const int amount = 7;
        const int volume = 9;
        const int id = 0;
        const int Tsquare = 10;
        const int Tamount = 11;
        const int Tvolume = 12;
        double[,] Result;



        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Copy_label_Text();

            if (Str.Get_path_text != null)
            {
                Filling_the_Array();
                Output(10);
            }
          
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Tag;
            form1.Show();
            Close();

        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_SortList_Click(object sender, EventArgs e)
        {
            Default_label_Text();

            Sort_method();

            Output(10);

            Sorted = true;
        }


        private void Button_Recalculate_Click(object sender, EventArgs e)
        {
            Sorted_ok();

            if(Sorted || Unsorted_detected) 
            { 
                Default_label_Text();
                Get_Array_Data();
                Calculation();
                Return_result_To_Array();
                 Output(13);
            }

            else MessageBox.Show("Сначала отсортируйте");
        }






        void Copy_label_Text()
        {
            a = new string[Length];

            for (int j = 0; j < Length-1; j++)
            {
                a[j] = toolStrip2.Items[j].Text;
            }

        }

        /// <summary>
        /// заполнение массива
        /// </summary>
        void Filling_the_Array()
        {

            string[] temp = Str.Get_path_text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            STR = new string[temp.Length][];

            for (int i = 0; i < temp.Length; i++)
            {
                string[] s = temp[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                STR[i] = new string[Length];

                for (int j = 0; j < s.Length; j++) STR[i][j] = s[j];
            }
        }
        /// <summary>
        /// вывод листа расчетов на форме
        /// </summary>
        /// <param name="lengthLine"></param>
        void Output(int lengthLine)
        {

            if (STR.Length == 1)  for (int j = 0; j < lengthLine - 1; j++) toolStrip2.Items[j].Text += "\n\n" + STR[0][j + 1];
           

            for (int i = 0; i < STR.Length - 1; i++)
            {
                for (int j = 0; j < lengthLine - 1; j++)
                {
                    if (i==0) toolStrip2.Items[j].Text += "\n";

                    toolStrip2.Items[j].Text += "\n" + STR[i][j + 1];

                    if (STR[i][0] != STR[i + 1][0]) toolStrip2.Items[j].Text += "\n";
                   
                    if (STR.Length - 2 == i) toolStrip2.Items[j].Text += "\n" + STR[i + 1][j+1];                   
                }
            }
        }


        void Default_label_Text()
        {
            for (int j = 0; j < Length-1; j++)
            {
                toolStrip2.Items[j].Text = a[j];
            }
        }


        void Sort_method()
        {
            string[] temp = new string[10];

            for (int k = 0; k < STR.Length - 1; k++)
            {
                for (int i = 0; i < STR.Length - 1; i++)
                {
                    if (Convert.ToDouble(STR[i][0]) > Convert.ToDouble(STR[i + 1][0]))
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            temp[j] = STR[i][j];

                            STR[i][j] = STR[i + 1][j];

                            STR[i + 1][j] = temp[j];
                        }
                    }
                }
            }


        }


        void Get_Array_Data()
        {
             Result = new double[ STR.Length,7];

            for (int i = 0; i < STR.Length; i++)
            {
                Result[i, 0] = Convert.ToDouble(STR[i][id]);
                Result[i, 1] = Convert.ToDouble(STR[i][square]);
                Result[i, 2] = Convert.ToDouble(STR[i][amount]);
                Result[i, 3] = Convert.ToDouble(STR[i][volume]);
            }


        }

        void Return_result_To_Array()
        {
            if(STR.Length > 1)
            { 
                 for (int i = 0; i < STR.Length; i++)
                 {
                    for (int j = 0; j < 3; j++) STR[i][j + 10] = Result[i, j + 4].ToString();                                                          
                 }
            }

            else
            {
               STR[0][Tsquare] = STR[0][square];
               STR[0][Tamount] = STR[0][amount];
               STR[0][Tvolume] = STR[0][volume];
            }
        }


        void Calculation()
        {
            double[]TempRez = new double[3];          
            bool b2 = false;

            if (Result.GetLength(0) == 1)
            {
                for (int i = 0; i < 3; i++) Result[0, i + 3] = Result[0, i + 1];                          
            }


            for (int i = 0; i < Result.GetLength(0) - 1; i++)
            {

                if (Result[i, 0] == Result[i + 1, 0])
                {
                    b2 = true;

                    for (int j = 0; j < 3; j++) TempRez[j] += Result[i, j + 1];

                                                        
                    if (i == Result.GetLength(0) - 2)
                    {
                        Return_result_Arr(i,1);
                    }
                }

                else
                {
                    if (!b2)
                    {
                        for (int j = 0; j < 3; j++) Result[i, j + 4] = Result[i, j + 1];

                        Getlength_Minus_2(i);
                    }

                    else
                    {
                        Return_result_Arr(i);
                        Getlength_Minus_2(i);
                    }
                }
            }




            void Getlength_Minus_2(int iterator)
            {
                if (iterator == Result.GetLength(0) - 2)
                {
                    for (int j = 0; j < 3; j++) Result[iterator + 1, j + 4] = Result[iterator + 1, j + 1];
                }
            }

            void Return_result_Arr(int iterator, int plus_one = 0) 
            {
                for (int j = 0; j < 3; j++)
                {                                        
                   TempRez[j] += Result[iterator + plus_one, j + 1];
                   Result[iterator + plus_one, j + 4] = TempRez[j];
                   TempRez[j] = 0;                                     
                }
            }
        }


        void Sorted_ok()
        {
            for (int i = 0; i < STR.Length - 1; i++)
            {
                if (Convert.ToDouble(STR[i][0]) > Convert.ToDouble(STR[i + 1][0]))
                {
                    Unsorted_detected = false; break;
                }
            }
        }




    }
}
