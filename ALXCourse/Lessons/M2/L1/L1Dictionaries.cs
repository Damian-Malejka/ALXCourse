using ALXCourse.Lessons.M2.L1.ClassesAndEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.M2.L1
{
    public class L1Dictionaries
    {
        public static void Run()
        {
            var fruitDictionary = new Dictionary<int, string>()
            {
                {1,"Banana"},
                {2,"Apple"},
                {3,"Strawbery"},
                {4,"Melon"},
                {5,"Tomato"},
                {6,"Kiwi"},
                {7,"Peach"},
                {8,"Blueberry"},
                {9,"Pineapple"},
                {0,"Waterlemon"},
                {11,"Guanabanana"}
            };

            Console.WriteLine(fruitDictionary[1]);
            fruitDictionary.Add(34, "Raspberry");

        }

        public static void Run1()
        {
            UserDTO userDTO = new UserDTO
            {
                Name = "aB@somedomain.com",
                Role = "Data contractor"
            };
            var user = MapDTO(userDTO);
            Console.WriteLine($"User: \n\t:{user.Name}\n\trole:{user.Role}");
        }
        private static User MapDTO(UserDTO userDTO)
        {
            var user = new User();
            user.Name = userDTO.Name;

            Dictionary<string, UserRoles> mapDictionary = new Dictionary<string, UserRoles>()
            {
                {"administrator", UserRoles.ADMINISTRATOR },
                {"user", UserRoles.USER },
                {"supervisor",UserRoles.SUPERVISOR},
                {"datacontractor", UserRoles.DATA_CONTRACTOR},
            };

            var roleFromDTO = userDTO.Role.ToLower().Replace(" ",""); //zamieniamy na male litery wszystko zeby nie bylo bledow jak beda duze wprowadzone i wywolujemy od razu metode Replace do zmiany spacji na bez spacji jakby ktos zapomnial
            user.Role = mapDictionary[roleFromDTO];
            return user;
        }

    
    }
}
