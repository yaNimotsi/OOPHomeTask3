using System;
using System.Collections.Generic;
using System.Text;
using Lesson4._2.CreatorClasses;

namespace Lesson4._2
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new BuildingCreator());

            Console.WriteLine("");
            
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
