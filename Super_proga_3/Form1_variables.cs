using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Super_Proga_3
{
    public partial class Form1 : Form
    {
        Form2 form2;

        public const  int _sosna  = 0;
        public const  int _bereza = 1;
        public const  int _listw  = 2;
        public const  int _buc    = 3;
        public const  int _yasen  = 4;
        public const  int _dub    = 5;


        /// <summary>
        /// массив панелей с текст боксами для создания из них двуменного массива
        /// </summary>
        List<ToolStrip> toolStrips = new List<ToolStrip>();

        /// <summary>
        /// массив имен пород древесины
        /// </summary>
        public string[] ArrName = {"_Сосна","_Береза","_Листвн.","_Бук","_Ясень","_Дуб"};

        /// <summary>
        ///  прайс цены за доску
        /// </summary>
        public static double[] Price_of_the_board = new double[]{ 20000,35000,40000,90000,145000,190000 };
         /// <summary>
         /// прайс цены за работу
         /// </summary>
        public int[] Arr_price_work = new int[] {3000,3500,3500,5000,5000,6000};
        /// <summary>
        /// коофициент умножения работы на толщину
        /// </summary>
        public double[] Cooficient_work = new double[] {1,1,1,1,1.25,1.5,1.75,2,2.25,2.5,2.75,3,3.25,3.5,3.75};

        /// <summary>
        /// массив вариантов толщины щита
        /// </summary>
        public static double[] Arr_thickess = new double[]  {20,25,30,40,50,60,70,80,90,100,110,120,130,140,150};

       

        /// <summary>
        /// массив с прайсами 
        /// в первом индексе  (цена за м2 древесины)
        /// во втором индексе (цена за м2 древесины + цена за работу за м2)
        /// </summary>
        public int[,,] Arr_Furniture_Panel = new int[2,6,15];

         

        /// <summary>
        /// счетчик текущей порода древесины
        /// </summary>
        int iterator_type_wood;




        /// <summary>
        /// массив объектов пород древесины
        /// </summary>
        List<Wood> woods = new List<Wood>();

      

        /// <summary>
        /// указатель на выбранный объект породы древесины
        /// </summary>
        Wood current;
       
        

        /// <summary>
        /// счетчик этапа ввода данных пользователем
        /// </summary>
        int count;
            

        const string    length = "Введите длину";
        const string    width  = "Введите ширину";
        const string    qt     = "Введите кол-во";
        const string    pcs    = "шт";
        const string    mm     = "мм";

        /// <summary>
        ///  когда ложно в приложение уже создан новый или открыт сущесвующий файл
        /// </summary>
        bool file_click = true;

        /// <summary>
        /// когда истинно значит нажата кнопка открыть файл иначе нажата кнопка создать файл
        /// </summary>
        bool open_file = false;

        /// <summary>
        /// массив дефолтных названий таблицы прайса
        /// </summary>
        string[]ArrClear = new string[11];
    }

   
}
