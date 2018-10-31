using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IAmenities
    {
        Task AddAmenity(Amenities amenity);

        Task UpdateAmenity(Amenities amenity);

        Task DeleteAmenity(int id);

        Task<List<Amenities>> GetAmenities();

        Task<Amenities> GetAmenity(int? id);
    }
}
