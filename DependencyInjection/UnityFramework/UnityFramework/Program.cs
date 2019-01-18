using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace UnityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a Unity Container
            var unityContainer = new UnityContainer();

            // Inject a property when dependency is resolved
            //InjectionProperty injectionProperty = new InjectionProperty("Name", "Great Ball of modern myanmar.");
            //unityContainer.RegisterType<IGame, UnitedMyanmar>(injectionProperty);

            //// Register IGame so when dependecy is detected
            //// it provides a UnitedMyanmar instance
            unityContainer.RegisterType<IGame, UnitedMyanmar>();

            //// Make Unity resolve the interface, providing an instance
            //// of UnitedMyanmar class
            ////Type resolution
            ////Unity to resolve an IGame interface, the framework will check if the IGame interface is registered, and, in possitive match, it will provide an instance of the mapped class (in this case, UnitedMyanmar):
            //var game = unityContainer.Resolve<IGame>();

            //game.addPlayer();
            //game.addPlayer();
            //Console.WriteLine(string.Format("{0} play at {1}", game.CurrentPlayers, game.Name));
            //Console.ReadLine();



 

            //// Instance a GameOrg class object through Unity
            ////Unity is also able to resolve types indirectly. 
            ////IGame is registered to inject a UnitedMyanmar instance. 
            ////gameOrg (instance from GameOrg class) got a reference to an IGame interface, which was injected through its constructor.
            //var gameOrg = unityContainer.Resolve<GameOrg>();


            //Parameter injection

            //Another possibility that we have when we inject a dependency is making the injection just in the moment we are resolving it.
            //Until now we've seen the case where the default instanced game is UnitedMyanmar. However, there may be cases where we want IGame to be assigned to another game. We can ask Unity to provide us an instance of TicTacToe just injecting the constructor parameters when the dependency is resolved.

            //// Override the constructor parameter of GameOrg class
            //var gameOrg2 = unityContainer.Resolve<GameOrg>(new ParameterOverride("game", new YoungUprising()));

            //gameOrg.AddPlayer();
            //gameOrg.AddPlayer();
            //gameOrg.Play();

            //Console.WriteLine(table.GameStatus());

            //Console.ReadLine();
        }
    }
}
