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

        public static House LivingRoom = new House(new List<string> { "Couch", "Entertainmentcenter", "Closet" },
            new List<string> { "Front Yard", "Kitchen" },
            new List<string> { "Front Yard Exit", "Kitchen Exit", "Master Bedroom Exit", "Bedroom Exit" },
            "You are in the Living Room. It has a lamp,\n a long brown leather couch against the wall, " +
            "an entertainment center with a tv on top, \n a front door leading to the driveway, and a closet near the front door");



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
            HomeScreenSplash();
            Console.ReadKey();
           
            
            // Random generator for the room
            var randomroom = new Random();
            var roomlist = new List<string> { "MasterBedroom", "Bedroom", "Kitchen", "BathRoom", "FrontYard", "BackYard", "LivingRoom" };
            int roomindex = randomroom.Next(0,roomlist.Count-1);
            // Calling the random generator  for the hideout
            string room = roomlist[roomindex];
            var result = RandomString(room);

            


            
            House PresentHouse = LivingRoom;
            bool continueplaying = true;
            Console.WriteLine(" ");
            Console.WriteLine(LivingRoom.Message);
            while (continueplaying)
            {
                
                bool keeprunning = true;
                int count = 0;
                
                while (keeprunning)
                {
                    
                    Console.WriteLine("Open the hideout in the Living room to look for Mr Computer and enter the hideout from this list {Couch :Enteratinment:Cabinet}");
                    string response = Console.ReadLine().ToLower();
                    count = count + 1;
                    if ( response == result)
                    {
                       
                        Console.WriteLine("Congratulation you Won!");

                        break;
                    }
                    else
                    {

                        Console.WriteLine("He is not there, you will have to check other areas in the room");

                        if (count == LivingRoom.HidingObjects.Count)
                        {
                            break;
                        }
                            
                    }
                   
                }
                bool running = true;
                Console.Clear();
                while (running)
                {
                    Console.WriteLine("It seem he is not in the living room, Use one  of the exit door to search for him in the Kitchen: Enter  Kitchen to go to to Ktchen");
                    string kitchen = Console.ReadLine().ToLower();
                    if (kitchen.Contains("kitchen"))
                    {
                        Console.WriteLine(Kitchen.Message);
                        break;
                    }
                    
                    
                }
                bool looking = true;
                int total = 0;
                while (looking)
                {
                    
                    Console.WriteLine("Open the hideout in the Kitchen to look for Mr Computer and enter the hideout from this list {Island Oven:Cabinet}");
                    string kitchenhideout = Console.ReadLine();
                    total = total + 1;
                    if (kitchenhideout == result)
                    {
                        Console.WriteLine("Congratulation you Won!");

                        break;
                    }
                    else
                    {

                        Console.WriteLine("He is not there, you will have to check other areas in the room");

                        if (total == Kitchen.HidingObjects.Count)
                        {
                            looking = false;
                            break;
                        }



                    }

                }
                Console.Clear();
                bool searching = true;

                while (searching)
                {
                    Console.WriteLine("It seem he is not in the Kitchen , go back to the Living room: Enter LivingRoom  to Go back:");
                    string Living = Console.ReadLine().ToLower();
                    if (Living.Contains("livingroom"))
                    {
                        Console.WriteLine("You can  go through the hallway to the MasterBedroom");
                        break;
                    }


                }
                bool search = true;
                while (search)
                {
                    Console.WriteLine("Enter MasterBedroom to go MasterBedroom");
                    string masterBedroom = Console.ReadLine().ToLower();
                    if (masterBedroom.Contains("masterbedroom"))
                    {
                        Console.WriteLine(MasterBedroom.Message);
                        break;
                    }


                }
                bool search2 = true;
                int counting = 0;
                while (search2)
                {
                    Console.WriteLine("\n\nCheck for him by entering any of the hideout places\n\n");
                    string masterBedroomHideout = Console.ReadLine().ToLower().Replace(" ","");
                    counting = counting + 1;
                    if(masterBedroomHideout == result)
                    {
                        Console.WriteLine("Congratulation you Won!");

                        break;
                    }
                    else
                    {

                        Console.WriteLine("\n\nHe is not there, you will have to check other areas in the room\n\n");

                        if (counting == MasterBedroom.HidingObjects.Count)

                        {
                            
                            search2 = false;
                            break;
                        }

                    }
                }
                Console.Clear();
                bool searching1 = true;

                while (searching1)
                {
                    Console.WriteLine("\nGo back to the Hallway, he might have run away!, Enter Hallway to Open the door\n");
                    string hallway = Console.ReadLine().ToLower();
                    if (hallway.Contains("hallway"))
                    {
                        Console.WriteLine(LongHallWay.Message);
                        Console.WriteLine("\n Search for him from the second Bedroom , He might be hiding there\n");
                        break;
                    }


                }
                bool search3 = true;
                while (search3)
                {
                    Console.WriteLine("Enter Bedroom to go Bedroom");
                    string bedroom = Console.ReadLine().ToLower();
                    if (bedroom.Contains("bedroom"))
                    {
                        Console.WriteLine(Bedroom.Message);
                        break;
                    }


                }
                Console.Clear();
                bool search4 = true;
                int counting4 = 0;
                while (search4)
                {
                    Console.WriteLine("\n\nCheck for him by entering any of the hideout places\n\n");
                    string bedroomHideout = Console.ReadLine().ToLower().Replace(" ", "");
                    counting4 = counting4 + 1;
                    if (bedroomHideout == result)
                    {
                        Console.WriteLine("Congratulation you Won!");

                        break;
                    }
                    else
                    {

                        Console.WriteLine("\n\nHe is not there, you will have to check other areas in the room\n\n");

                        if (counting4 == Bedroom.HidingObjects.Count)

                        {

                            search2 = false;
                            break;
                        }

                    }
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

        

        public void HomeScreenSplash()
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

