using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_And_Seek
{
    class ProgramUI
    {
        Dictionary<string, House> rooms = new Dictionary<string, House>
        {
            { "LivingRoom" , LivingRoom },
            {"FrontYard" , FrontYard },
            {"Kitchen" , Kitchen },
            {"MasterBedroom" , MasterBedroom },
            {"Bedroom" , Bedroom },
            {"LongHallWay" , LongHallWay },
            {"BathRoom" , BathRoom },
            {"BackYard" , BackYard },

        };
        public static House BackYard = new House(new List<string> { "Couch", "Entertainment center", "Closet" },
          new List<string> { "Front Yard", "Kitchen" },
          new List<string> { "Front Yard Exit", "Kitchen Exit", "Master Bedroom Exit", "Bedroom Exit" },
          "You are in the Living Room. It has a lamp, a long brown leather couch against the wall, " +
          "an entertainment center with a tv on top, a front door leading to the driveway, and a closet near the front door");
        public static House BathRoom = new House(new List<string> { "Couch", "Entertainment center", "Closet" },
          new List<string> { "Front Yard", "Kitchen" },
          new List<string> { "Front Yard Exit", "Kitchen Exit", "Master Bedroom Exit", "Bedroom Exit" },
          "You are in the Living Room. It has a lamp, a long brown leather couch against the wall, " +
          "an entertainment center with a tv on top, a front door leading to the driveway, and a closet near the front door");

        public static House Bedroom = new House(new List<string> { "Couch", "Entertainment center", "Closet" },
          new List<string> { "Front Yard", "Kitchen" },
          new List<string> { "Front Yard Exit", "Kitchen Exit", "Master Bedroom Exit", "Bedroom Exit" },
          "You are in the Living Room. It has a lamp, a long brown leather couch against the wall, " +
          "an entertainment center with a tv on top, a front door leading to the driveway, and a closet near the front door");

        public static House FrontYard = new House(new List<string> { "Couch", "Entertainment center", "Closet" },
          new List<string> { "Front Yard", "Kitchen" },
          new List<string> { "Front Yard Exit", "Kitchen Exit", "Master Bedroom Exit", "Bedroom Exit" },
          "You are in the Living Room. It has a lamp, a long brown leather couch against the wall, " +
          "an entertainment center with a tv on top, a front door leading to the driveway, and a closet near the front door");

        public static House LivingRoom = new House(new List<string> { "Couch", "Entertainment center", "Closet" },
            new List<string> { "Front Yard", "Kitchen" },
            new List<string> { "Front Yard Exit", "Kitchen Exit", "Master Bedroom Exit", "Bedroom Exit" },
            "You are in the Living Room. It has a lamp, a long brown leather couch against the wall, " +
            "an entertainment center with a tv on top, a front door leading to the driveway, and a closet near the front door");



        public static House Kitchen = new House(new List<string> { "cabinets", "island", "oven" },
            new List<string> { "LivingRoom" },
            new List<string> { "Living Room Exit" },

            "You are in the kitchen. Along the wall is a section of cabinets with enough space to hide in them.\n\n" +
           "on top of the cabinets is cooking surface with a microwave, coffee maker, sink, and dishes.\n\n +" +
            " In the middle of the kitchen is an island. It has chairs on all sides. You can not see \n\n" +
            "what is on the other side of the island. \n\n" +
            "You can go back into the Living Room \n\n" +
            "You can try to find the computer behind the island. \n\n" +
            "you can try to find the computer in the cabinets \n\n" +
            "you can try to find the computer inside the oven\n\n");

        public static House LongHallWay = new House(
            new List<string> { },
            new List<string> { "LivingRoom", "Master Bedroom", "Bedroom", "Bathroom", "Back yard" },
            new List<string> { "Master Bedroom Exit", "Bedroom Exit", "Bathroom" },
            "You are in the long Hallway that leads to the Master Bed Room, another Bedroom, a bathroom, and has a door leading to the back yard\n\n" +
            "The floor is made of tile and the halway is about 6 feet wide and is 30 feet long \n\n" +
            "There is nowhere to hide in the hall way\n\n" +
            "You can go into the back yard\n" +
            "You can go into the Master Bedroom\n" +
            "You can go into the BedRoom\n" +
            "You can go into the Bathroom");
        public static House MasterBedroom = new House(
            new List<string> { "Dresser one", "Dresser Two", "Closet", "Bed" },
            new List<string> { "Hallway" },
            new List<string> { "Hallway Exit" },
            "You are in the Master Bedroom\n" +
            "It has a king size bed. It has two windows. It has two dressers. It has one closet\n\n" +
            "You can check under the bed\n" +
            "you can check behind Dresser number one\n" +
            "You can check behind Dresser number two\n" +
            "You can check inside the closet\n" +
            "You can go back into the hallway"
            );
        //string place;


        public void Run()
        {
            homescreensplash();
            Console.ReadKey();
            House currentroom = LivingRoom;
            string hiddingplace=" ";

            var randomroom = new Random();
            var roomlist = new List<string> { "MasterBedroom", "Bedroom", "Kitchen", "BathRoom", "FrontYard", "BackYard", "LivingRoom" };
            int roomindex = randomroom.Next(0,roomlist.Count-1);
            
            string room = roomlist[roomindex];
            //if (room == "MasterBedroom")
            //{
            //    var randomhideout = new Random();
            //    int hideout = randomhideout.Next(1,MasterBedroom.HidingObjects.Count);
            //     hiddingplace = MasterBedroom.HidingObjects[hideout];
            //}
            //else if (room == "Bedroom")
            //{
            //    var randomhideout = new Random();
            //    int hideout = randomhideout.Next(1,Bedroom.HidingObjects.Count);
            //     hiddingplace = MasterBedroom.HidingObjects[hideout];

            //}
            //else if (room == "Kitchen")
            //{
            //    var randomhideout = new Random();
            //    int hideout = randomhideout.Next(1,Kitchen.HidingObjects.Count);
            //     hiddingplace = MasterBedroom.HidingObjects[hideout];

            //}
            //else if (room == "BathRoom")
            //{
            //    var randomhideout = new Random();
            //    int hideout = randomhideout.Next(1,BathRoom.HidingObjects.Count);
            //     hiddingplace = MasterBedroom.HidingObjects[hideout];

            //}
            //else if (room == "LongHallWay")
            //{
            //    var randomhideout = new Random();
            //    int hideout = randomhideout.Next(1,LongHallWay.HidingObjects.Count);
            //     hiddingplace = MasterBedroom.HidingObjects[hideout];

            //}
            //else if (room == "FrontYard")
            //{
            //    var randomhideout = new Random();
            //    int hideout = randomhideout.Next(1,FrontYard.HidingObjects.Count);
            //     hiddingplace = MasterBedroom.HidingObjects[hideout];

            //}
            //else if (room == "BackYard")
            //{
            //    var randomhideout = new Random();
            //    int hideout = randomhideout.Next(1,BackYard.HidingObjects.Count);
            //     hiddingplace = MasterBedroom.HidingObjects[hideout];

            //}
            //else if (room == "LivingRoom")
            //{
            //    var randomhideout = new Random();
            //    int hideout = randomhideout.Next(1,LivingRoom.HidingObjects.Count);
            //     hiddingplace = MasterBedroom.HidingObjects[hideout];

            //}
            


            bool foundComputer = false;
            House PresentHouse = LivingRoom;
            bool continueplaying = true;
            while (continueplaying)
            {
                Console.WriteLine(LivingRoom.Message);
                bool keeprunning = true;
                while (keeprunning)
                {
                    Console.WriteLine("Open the hideout in the Living room to look for Mr Computer and enter the hideout from this list");
                    string response2 = Console.ReadLine().ToLower().Replace(" ","");
                    if (response2==RandomString(room))
                    {
                        Console.WriteLine("Hey you Won!");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Else do you still need to keep seraching. Do you still need to seach for him? y for yes and n for no");
                        string response3 = Console.ReadLine().ToLower();
                        if (response3 == "n")
                        {
                            keeprunning = false;
                        }
                    }


                    Console.WriteLine("Move tho the next room ");
                    string response = Console.ReadLine().ToLower();
                   

                    //string interactnavcommand = Console.ReadLine().ToLower();
                    //if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" masterbedroom"))
                    //{
                    //    Console.WriteLine(MasterBedroom.Message);
                    //}
                    //else if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" bedroom"))
                    //{
                    //    Console.WriteLine(Bedroom.Message);
                    //}
                    //else if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" kitchen"))
                    //{
                    //    Console.WriteLine(Kitchen.Message);
                    //}
                    //else if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" bathroom"))
                    //{
                    //    Console.WriteLine(BathRoom.Message);
                    //}
                    //else if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" long hall way"))
                    //{
                    //    Console.WriteLine(LongHallWay.Message);
                    //}
                    //else if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" front yard"))
                    //{
                    //    Console.WriteLine(FrontYard.Message);
                    //}
                    //else if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" back yard"))
                    //{
                    //    Console.WriteLine(BackYard.Message);
                    //}
                    //else if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" living room"))
                    //{
                    //    Console.WriteLine(LivingRoom.Message);
                    //}

                }



            }
        }

        public string RandomString(string room)
        {
            House house = rooms[room];
            var randomhideout = new Random();
            int hideout = randomhideout.Next(0,house.HidingObjects.Count-1);
           string place = house.HidingObjects[hideout];
            return place;
        }

        //private void MovetoNextRoom(string roomname)
        //{

        //    if (roomname.Contains(roomname))
        //    {
        //        House house = rooms[roomname];
        //        Console.WriteLine(house.Message);
        //        Console.WriteLine("Do you want to check if he's inside the this room? enter y for yes and n for no ,");
        //        string response1 = Console.ReadLine();
        //        if (response1 == "y")
        //        {
        //            bool keeprunning = true;
        //            while (keeprunning)
        //            {
        //                Console.WriteLine("Open each hideout by pressing check + hideout");
        //                string response2 = Console.ReadLine();
        //                if (response2.Contains(place))
        //                {
        //                    Console.WriteLine("Hey you Won!");
        //                    break;

        //                }
        //                else
        //                {
        //                    Console.WriteLine(" you missed him,  do you still need to keep seraching Do you still need to seach for him? y for yes and n for no");
        //                    string response3 = Console.ReadLine().ToLower();
        //                    if (response3 == "n")
        //                    {
        //                        keeprunning = false;
        //                    }
        //                }

        //            }
        //        }




        //    }

        //}

        public void homescreensplash()
            {
                Console.WriteLine("Welcome to hide and seek!\n\n" +
                   "In this game you will be playing hide and seek with the computer\n" +
                   "Each time you begin a new game the computer will be hiding somewhere else\n\n" +

                   "You will begin the game in the Living Room\n" +
                   "When you enter each room places to seek for the hiding computer as \n" +
                   "well as places you can go will be diplayed\n\n " +

                   "To move to a different room enter 'move to' followed by the \n" +
                   "name of the room. ex. 'move to kitchen'.\n\n" +

                   "To check objects in the room for the hiding computer enter 'check'\n" +
                   "followed by the name of the object. ex. 'check couch'.\n\n" +

                   "When you do find the computer you will be sent back to this splash screen\n\n" +

                   "GOOD LUCK!"
                   );
            }












    }

}

