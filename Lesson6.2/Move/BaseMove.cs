using System;

namespace Lesson6._2.Move
{
    abstract class BaseMove
    {
        public virtual void Move()
        {
            Console.WriteLine("Работает метод базового класса Move");
        }
    }
}
