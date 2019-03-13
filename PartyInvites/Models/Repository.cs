using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static IList<PartyInviteModel> _guests = new List<PartyInviteModel>();

        public static IList<PartyInviteModel> All()
        {
            return _guests;
        }

        public static void Add(PartyInviteModel guest)
        {
            _guests.Add(guest);
        }
    }
}
