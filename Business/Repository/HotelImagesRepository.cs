using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class HotelImagesRepository : IHotelImagesRepository
    {
        private readonly ApplicationDataContext _db;
        private readonly IMapper _mapper;

        public HotelImagesRepository(ApplicationDataContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<int> CreateHotelRoomImage(HotelRoomImageDTO imageDTO)
        {
            var image = _mapper.Map<HotelRoomImageDTO, HotelRoomImage>(imageDTO);
            await _db.HotelRoomImages.AddAsync(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteAllImages(int RoomID)
        {
            var image = await _db.HotelRoomImages.Where(x => x.RoomId == RoomID).ToListAsync();
            _db.HotelRoomImages.RemoveRange(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteHotelRoomImage(int imageID)
        {
            var image = await _db.HotelRoomImages.FindAsync(imageID);
            _db.HotelRoomImages.Remove(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<HotelRoomImageDTO>> GetallRoomImages(int RoomID)
        {
            return _mapper.Map<IEnumerable<HotelRoomImage>, IEnumerable<HotelRoomImageDTO>>(
            await _db.HotelRoomImages.Where(x => x.RoomId == RoomID).ToListAsync());
        }
    }
}