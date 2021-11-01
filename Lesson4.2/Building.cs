using Lesson4._2.Interfaces;

namespace Lesson4._2
{
    internal class Building : IBuilding
    {
        private static int _buildingNumber;
        private double _buildingHeight;
        private int _numberOfFloor;
        private int _numberApartments;
        private int _numberEntrances;


        public int BuildingNumber => _buildingNumber;
        
        public double BuildingHeight 
        {
            get => _buildingHeight;
            set => _buildingHeight = value;
        }

        public int NumberOfFloor
        {
            get => _numberOfFloor;
            set => _numberOfFloor = value;
        }

        public int NumberApartments
        {
            get => _numberApartments;
            set => _numberApartments = value;
        }

        public int NumberEntrances
        {
            get => _numberEntrances;
            set => _numberEntrances = value;
        }

        private Building()
        {

        }

        protected internal  Building(double buildingHeight, int numberOfFloor, int numberApartments, int numberEntrances)
        {
            _buildingHeight = buildingHeight;
            _numberOfFloor = numberOfFloor;
            _numberApartments = numberApartments;
            _numberEntrances = numberEntrances;
            
            GenerateBuildingNumber();
        }

        private void GenerateBuildingNumber()
        {
            _buildingNumber++;
        }

        /// <summary>
        /// Return the height of the floor
        /// </summary>
        /// <returns>Height of the floor</returns>
        public double GetHeightFloor()
        {
            if (_buildingHeight > 0 && _numberOfFloor > 0)
            {
                return _buildingHeight / _numberOfFloor;
            }
            
            return 0;
        }

        /// <summary>
        /// Return number apartments in entrance
        /// </summary>
        /// <returns>Number of appartments in the Entrance</returns>
        public int GetCountApartmentInEntrance()
        {
            if (_numberApartments > 0 && _numberEntrances > 0)
            {
                return _numberApartments / _numberEntrances;
            }
            
            return 0;
        }

        /// <summary>
        /// Rreturn count apartment in floor
        /// </summary>
        /// <returns> Number of appartments on the floor</returns>
        public int GetCountApartmentInFloor()
        {
            var apartmentInEntrance = GetCountApartmentInEntrance();

            if (apartmentInEntrance > 0)
            {
                return apartmentInEntrance / _numberOfFloor;
            }

            return 0;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            var build = (Building)obj;

            return _buildingNumber == build.BuildingNumber;
        }


        public override int GetHashCode()
        {
            var result = 0;
            if (this.BuildingNumber != 0)
            {
                result +=BuildingNumber.GetHashCode();
            }
            if (this.BuildingHeight != 0)
            {
                result += BuildingHeight.GetHashCode();
            }
            if (this.NumberOfFloor != 0)
            {
                result += NumberOfFloor.GetHashCode();
            }
            if (this.NumberApartments != 0)
            {
                result += BuildingNumber.GetHashCode();
            }
            if (this.NumberEntrances != 0)
            {
                result += NumberEntrances.GetHashCode();
            }

            return result;
        }
    }
}
/*
 * 2. * Для реализованного класса создать новый класс Creator,
 * который будет являться фабрикой объектов класса здания.
 * Для этого изменить модификатор доступа к конструкторам класса,
 * в новый созданный класс добавить перегруженные фабричные методы CreateBuild
 * для создания объектов класса здания. В классе Creator все методы сделать статическими,
 * конструктор класса сделать закрытым. Для хранения объектов класса здания в классе
 * Creator использовать хеш-таблицу. Предусмотреть возможность удаления объекта здания
 * по его уникальному номеру из хеш-таблицы.
 * Создать тестовый пример, работающий с созданными классами.
 * */