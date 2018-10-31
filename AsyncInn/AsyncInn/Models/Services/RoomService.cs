using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncInn.Models.Interfaces;
using AsyncInn.Data;

namespace AsyncInn.Models.Services
{
    public class RoomService : IRoom
    {
        private AsyncInnDbContext _context;

        public RoomService(AsyncInnDbContext context)
        {
            _context = context;
        }
    }
}
