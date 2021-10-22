namespace Lesson4._1
{
    internal class Building
    {
        private static int _buildingNumber;
        private double _buildingHeight;
        private int _numberOfFloor;
        private int _numberApartments;
        private int _numberEntrances;

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

        public static int BuildingNumber => _buildingNumber;

        public Building()
        {
            GenerateBuildingNumber();
        }

        private void GenerateBuildingNumber()
        {
            _buildingNumber++;
        }

        /// <summary>
        /// Return the height of the floor
        /// </summary>
        /// <returns></returns>
        public double GetHeightFloor()
        {
            if (_buildingHeight > 0 && _numberOfFloor > 0)
            {
                return _buildingHeight / _numberOfFloor;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Return number apartments in entrance
        /// </summary>
        /// <returns></returns>
        public int GetCountApartmentInEntrance()
        {
            if (_numberApartments > 0 && _numberEntrances > 0)
            {
                return _numberApartments / _numberEntrances;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Rreturn count apartment in floor
        /// </summary>
        /// <returns></returns>
        public int GetCountApartmentInFloor()
        {
            var apartmentInEntrance = GetCountApartmentInEntrance();

            if (apartmentInEntrance > 0)
            {
                return apartmentInEntrance / _numberOfFloor;
            }

            return 0;
        }
    }
}
/*
 * 1. Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов).
 * Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати.
 * Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д.
 * Предусмотреть возможность, чтобы уникальный номер здания генерировался программно. Для этого в классе предусмотреть
 * статическое поле, которое бы хранило последний использованный номер здания, и предусмотреть метод, который увеличивал бы значение этого поля.
 * */