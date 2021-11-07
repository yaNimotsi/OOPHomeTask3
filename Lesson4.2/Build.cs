
namespace Lesson4._2
{
    internal class Build : BaseBuild
    {
        public Build(int buildingNumber, double buildingHeight, int numberOfFloor, int numberApartments,
            int numberEntrances) : base(buildingNumber,
            buildingHeight, numberOfFloor, numberApartments, numberEntrances)
        {

        }

        /// <summary>
        ///     Return the height of the floor
        /// </summary>
        /// <returns>Height of the floor</returns>
        public override double GetHeightFloor()
        {
            if (BuildingHeight > 0 && NumberOfFloor > 0) return BuildingHeight / NumberOfFloor;

            return 0;
        }

        /// <summary>
        ///     Return number apartments in entrance
        /// </summary>
        /// <returns>Number of appartments in the Entrance</returns>
        public override int GetCountApartmentInEntrance()
        {
            if (NumberApartments > 0 && NumberEntrances > 0) return NumberApartments / NumberEntrances;

            return 0;
        }

        /// <summary>
        ///     Rreturn count apartment in floor
        /// </summary>
        /// <returns> Number of appartments on the floor</returns>
        public override int GetCountApartmentInFloor()
        {
            var apartmentInEntrance = GetCountApartmentInEntrance();

            if (apartmentInEntrance > 0) return apartmentInEntrance / NumberOfFloor;

            return 0;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (obj.GetType() != GetType()) return false;

            var build = (Build)obj;

            return BuildingNumber == build.BuildingNumber;
        }


        public override int GetHashCode()
        {
            var result = 0;
            if (BuildingNumber != 0) result += BuildingNumber.GetHashCode();
            if (BuildingHeight != 0) result += BuildingHeight.GetHashCode();
            if (NumberOfFloor != 0) result += NumberOfFloor.GetHashCode();
            if (NumberApartments != 0) result += BuildingNumber.GetHashCode();
            if (NumberEntrances != 0) result += NumberEntrances.GetHashCode();

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