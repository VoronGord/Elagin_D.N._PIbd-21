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
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
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
            using (StreamWriter sw = new StreamWriter(filename))
            {
                //Записываем количество уровней
                sw.WriteLine("CountLevels:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    //Начинаем уровень
                    sw.WriteLine("Level");
                    foreach (IShip ship in level)
                    {
                        try
                        {
                            
                            if (ship != null)
                            {
                                if (ship.GetType().Name == "War_Ship")
                                {
                                    sw.Write(level.GetKey + ":War_Ship:");
                                }
                                if (ship.GetType().Name == "Lincor")
                                {
                                    sw.Write(level.GetKey + ":Lincor:");
                                }
                                //Записываемые параметры
                                sw.WriteLine(ship);
                            }
                            //Записываем тип машины

                        }
                        catch { }
                       
                    }
                }
            }
            return true;
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
            string buffer = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                if ((buffer = sr.ReadLine()).Contains("CountLevels"))
                {
                    int count = Convert.ToInt32(buffer.Split(':')[1]);
                    if (parkingStages!= null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages= new List<Parking<IShip>>(count);
                }
                else
                {
                    //если нет такой записи, то это не те данные   
                    throw new Exception("Неверный формат файла");
                }   
                
                int counter = -1;
                IShip ship = null;
                while ((buffer = sr.ReadLine()) != null)
                {
                    if (buffer == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Parking<IShip>(countPlaces,
                            pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(buffer)) continue;
                    if (buffer.Split(':')[1] == "War_Ship")
                    {
                        Console.WriteLine(buffer.Split(':')[2]);
                        ship = new War_Ship(buffer.Split(':')[2]);
                    }
                    else if (buffer.Split(':')[1] == "Lincor")
                    {
                        ship = new Lincor(buffer.Split(':')[2]);
                    }
                    parkingStages[counter][Convert.ToInt32(buffer.Split(':')[0])] = ship;
                }
                return true;
            }
        }

        public void Sort()
        {
            parkingStages.Sort();
        }
    }  
 }


