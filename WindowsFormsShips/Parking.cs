using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShips
{
    public class Parking<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Parking<T>>
        where T : class, IShip { 
        /// <summary>         /// Массив объектов, которые храним         /// </summary>    
        private Dictionary<int, T> _places; 
        /// <summary>         /// Максимальное количество мест на парковке         /// </summary>   
        private int _maxCount; 

        /// <summary>         /// Ширина окна отрисовки         /// </summary>         
        private int PictureWidth { get; set; }
        /// <summary>         /// Высота окна отрисовки         /// </summary>         
        private int PictureHeight { get; set; }

        /// <summary>         /// Размер парковочного места (ширина)         /// </summary> 
        private const int _placeSizeWidth = 210;
        /// <summary>         /// Размер парковочного места (высота)         /// </summary>        
        /// <summary>         /// Размер парковочного места (ширина)         /// </summary> 
        private const int _placeSizeWidth = 210;
       /// <summary>         /// Размер парковочного места (высота)         /// </summary>        
        private const int _placeSizeHeight = 80;
        private int _currentIndex;
        public int GetKey
        {
            get
            {
                return _places.Keys.ToList()[_currentIndex];
            }
        }
        /// <param name="pictureWidth">Рамзер парковки - ширина</param>    
        /// <param name="pictureHeight">Рамзер парковки - высота</param>        
        public Parking(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }
        /// <summary>         /// Перегрузка оператора сложения         /// Логика действия: на парковку добавляется автомобиль   
        /// </summary>         /// <param name="p">Парковка</param>     
        /// <param name="ship">Добавляемый автомобиль</param>         /// <returns></returns>   
        public static int operator +(Parking<T> p, T ship)
        {
            if (p._places.Count == p._maxCount)
            {
                throw new ParkingOverflowException();
            }
            if (p._places.ContainsValue(ship))
            {
                throw new ParkingAlreadyHaveException();
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, ship);
                    p._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5, i % 5 * _placeSizeHeight + 35, p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        /// <summary>         /// Перегрузка оператора вычитания    
        /// Логика действия: с парковки забираем автомобиль 
        /// </summary>         /// <param name="p">Парковка</param>    
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>   
        /// <returns></returns>      
        public static T operator - (Parking<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T ship = p._places[index];
                p._places.Remove(index);
                return ship;
            }
            throw new ParkingNotFoundException(index);
        }
        /// <summary>     
        /// Метод проверки заполнености парковочного места (ячейки массива)         /// </summary>    
        /// <param name="index">Номер парковочного места (порядковый номер в массиве)</param>         /// <returns></returns>  
        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }

        /// Метод отрисовки парковки   
        /// </summary>   
        /// <param name="g"></param>   
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            foreach (var ship in _places)
            {
                ship.Value.DrawShip(g);
            }
        }
        /// <summary> 
        /// Метод отрисовки разметки парковочных мест         /// </summary>         /// <param name="g"></param>  
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы праковки    
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 5; i++)
            {//отрисовываем, по 5 мест на линии        
                for (int j = 0; j < 6; ++j)
                {//линия рамзетки места                
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,      
                        i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400); 
            }
        }
        /// <summary>         /// Индексатор         /// </summary>      
        /// /// <param name="ind"></param>         /// <returns></returns>     
        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                throw new ParkingNotFoundException(ind);
            }

            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5 * _placeSizeHeight + 35, PictureWidth, PictureHeight);
                }
                else
                {
                    throw new ParkingOccupiedPlaceException(ind);
                }
            }
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5 * _placeSizeHeight + 15, PictureWidth, PictureHeight);

                 }
             }
        }

        public T Current
        {
            get
            {
                return _places[_places.Keys.ToList()[_currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            _places.Clear();
        }
        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                Reset(); return false;
            }
            _currentIndex++;
            return true;
        }
        public void Reset()
        {
            _currentIndex = -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int CompareTo(Parking<T> other)
        {
            if (_places.Count > other._places.Count) { return -1; }
            else if (_places.Count < other._places.Count)
            {
                return 1;
            }
            else if (_places.Count > 0)
            {
                var thisKeys = _places.Keys.ToList();
                var otherKeys = other._places.Keys.ToList();
                for (int i = 0; i < _places.Count; ++i)
                {
                    if (_places[thisKeys[i]] is War_Ship && other._places[thisKeys[i]] is Lincor)
                    {
                        return 1;
                    }
                    if (_places[thisKeys[i]] is Lincor && other._places[thisKeys[i]] is War_Ship)
                    {
                        return -1;
                    }
                    if (_places[thisKeys[i]] is War_Ship && other._places[thisKeys[i]] is War_Ship)
                    {
                        return (_places[thisKeys[i]] is War_Ship).CompareTo(other._places[thisKeys[i]] is War_Ship);
                    }
                    if (_places[thisKeys[i]] is Lincor && other._places[thisKeys[i]] is Lincor)
                    {
                        return (_places[thisKeys[i]] is Lincor).CompareTo(other._places[thisKeys[i]] is Lincor);
                    }
                }
            }
            return 0;
        }
    }
}
