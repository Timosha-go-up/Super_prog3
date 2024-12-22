using System;

namespace Super_Proga_3
    
{
    internal class Str
    {
        /// <summary>
        /// переменная получает строку расчетов для записи в файл
        /// </summary>
        public static string List;

        /// <summary>
        ///переменная получает имя файла
        /// </summary>
        public static string Path_name;

        /// <summary>
        /// переменная получает содержимое файла
        /// </summary>
        public static string Get_path_text;

        /// <summary>
        /// переменная получает последний сохраненный прайс лист
        /// </summary>
        public static string Price_text;

        static public string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);    
        static public string path_desktop_save = path_desktop + "\\save\\";

                    
        static public string path_App_Data = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string Path_App_Data_Super_Proga = path_App_Data + "\\Super Proga\\";

        /// <summary>
        /// путь к файлу с прайс листом
        /// </summary>
        public static string Path_App_Data_Super_Proga_Price_txt = Path_App_Data_Super_Proga + "Price.txt";



       
    }
}
