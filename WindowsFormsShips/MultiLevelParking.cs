using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShips
{
    class MultiLevelParking
    {
        /// <summary>         /// Список с уровнями парковки         /// </summary>    
        List<Parking<IShip>> parkingStages;

        /// <summary>         /// Сколько мест на каждом уровне         /// </summary> 

        private const int countPlaces = 20;

        /// <summary>         /// Ширина окна отрисовки         /// </summary>       
        private int pictureWidth; 

        /// <summary>         /// Высота окна отрисовки         /// </summary>  
       private int pictureHeight; 

        /// <summary>         /// Конструктор         /// </summary>    
        /// /// <param name="countStages">Количество уровенй парковки</param>   
        /// /// <param name="pictureWidth"></param>  
        /// /// <param name="pictureHeight"></param>  
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<IShip>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<IShip>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        /// <summary>         /// Индексатор         /// </summary>         /// <param name="ind"></param>  
        /// /// <returns></returns>   
        public Parking<IShip> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        /// <summary>         /// Сохранение информации по автомобилям на парковках в файл         /// </summary>    
        /// <param name="filename">Путь и имя файла</param>         /// <returns></returns>   
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename))
            {
                //Записываем количество уровней
                fs.WriteLine("CountLevels:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    //Начинаем уровень
                    fs.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var plane = level[i];
                        if (plane != null)
                        {
                            //если место не пустое
                            //Записываем тип мшаины
                            if (plane.GetType().Name == "War_Ship")
                            {
                                fs.Write("e:" + i + ":War_Ship:");
                            }
                            if (plane.GetType().Name == "Lincor")
                            {
                                fs.Write("e:" + i + ":Lincor:");
                            }
                            //Записываемые параметры
                            fs.Write(plane + Environment.NewLine);
                        }
                    }
                }
                return true;
            }
        }
        /// <summary>         /// Метод записи информации в файл         /// </summary>  
        /// /// <param name="text">Строка, которую следует записать</param>    
        /// /// <param name="stream">Поток для записи</param>   
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        /// <summary>         /// Загрузка нформации по автомобилям на парковках из файла      
        /// /// </summary>         /// <param name="filename"></param> 
        /// /// <returns></returns>   
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string bufferTextFromFile = "";
            int counter = -1;
            using (StreamReader fs = new StreamReader(filename))
            {

                while (bufferTextFromFile != null)
                {
                    bufferTextFromFile = fs.ReadLine();
                    if (bufferTextFromFile == null)
                    {
                        break;
                    }

                    IShip ship = null;
                    int count = 0;
                    var strs = bufferTextFromFile.Split(':');
                    switch (strs[0])
                    {

                        case "CountLeveles":
                            count = Convert.ToInt32(strs[1]);
                            if (parkingStages != null)
                            {
                                parkingStages.Clear();
                            }
                            parkingStages = new List<Parking<IShip>>(count);
                            break;
                        case "Level":
                            counter++;

                            break;
                        case "e":

                            if (strs[2] == "War_Ship")
                            {
                                ship = new War_Ship(strs[3]);
                            }
                            else if (strs[2] == "Lincor")
                            {
                                ship = new Lincor(strs[3]);
                            }
                            parkingStages[counter][Convert.ToInt32(strs[1])] = ship;

                            break;
                    }
                }
            }
            return true;
        }
    }
}


