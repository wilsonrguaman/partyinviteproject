using System;
using System.Collections.Generic;
namespace PartyInvites_Ass2_WilsonGuaman.Models
{
    public class Repository
    {
        private static List<GuestRespose> responses = new List<GuestRespose>();
        public static IEnumerable<GuestRespose> Resposes => responses;
        public static void AddResponse(GuestRespose response)
        {
            responses.Add(response);
        }
        
    }
}
