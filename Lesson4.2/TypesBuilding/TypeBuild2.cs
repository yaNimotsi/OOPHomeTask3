﻿using System;
using Lesson4._2.Interfaces;

namespace Lesson4._2.TypesBuilding
{
    class TypeBuild2 : IBuilding
    {
        private static int _buildingNumber;

        private void GenerateBuildingNumber()
        {
            _buildingNumber++;
        }

        protected internal TypeBuild2()
        {
            GenerateBuildingNumber();
        }

        public double GetHeightFloor()
        {
            throw new NotImplementedException();
        }

        public int GetCountApartmentInEntrance()
        {
            throw new NotImplementedException();
        }

        public int GetCountApartmentInFloor()
        {
            throw new NotImplementedException();
        }
    }
}