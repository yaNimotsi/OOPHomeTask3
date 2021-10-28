using System;
using System.Collections.Generic;
using System.Text;
using Lesson4._2.CreatorClasses;
using Lesson4._2.TypesBuilding;

namespace Lesson4._2
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new CreatorTypeBuild1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new CreatorTypeBuild2());
        }

        public void ClientCode(Creator creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                              "but it still works.\n" + creator.CreateBuild());
            // ...
        }
    }
}
