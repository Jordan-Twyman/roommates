using System;
using System.Collections.Generic;
using Roommates.Models;
using Roommates.Repositories;

namespace Roommates.Repositories
{
    class Program
    {
        /// <summary>
        ///  This is the address of the database.
        ///  We define it here as a constant since it will never change.
        /// </summary>
        private const string CONNECTION_STRING = @"server=localhost\SQLExpress;database=Roommates;integrated security=true;TrustServerCertificate=True";

        static void Main(string[] args)
        {
            RoomRepository roomRepo = new RoomRepository(CONNECTION_STRING);

            




            Console.WriteLine("Getting All Rooms:");
            Console.WriteLine();

            List<Room> allRooms = roomRepo.GetAll();

            foreach (Room room in allRooms)
            {
                Console.WriteLine($"{room.Name} has an Id of {room.Id} and a max occupancy of {room.MaxOccupancy}");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Getting Room with Id 1");

            Room singleRoom = roomRepo.GetById(1);

            Console.WriteLine($"{singleRoom.Id} {singleRoom.Name} {singleRoom.MaxOccupancy}");


            //Room bathroom = new Room
            //{
            //    Name = "bathroom",
            //    MaxOccupancy = 1
            //};

            //roomRepo.Insert(bathroom);

            //bathroom.Name = "room";
            //roomRepo.Update(bathroom);
            //singleRoom = roomRepo.GetById(1);
            //Console.WriteLine($"{bathroom.Id} {bathroom.Name} {bathroom.MaxOccupancy}");
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine($"Added the new Room with id {bathroom.Id}");


            //Console.WriteLine("Please select an ID of a room to delete");
            //int deleteRoom = Int32.Parse(Console.ReadLine());
            roomRepo.Delete(10);



            //Console.WriteLine("-------------------------------");
            //Console.WriteLine($"Deleted the new Room with id {deleteRoom}");
        }
    }
}