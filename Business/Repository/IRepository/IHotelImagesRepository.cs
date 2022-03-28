using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHotelImagesRepository
    {
        public Task<int> CreateHotelRoomImage(HotelRoomImageDTO image);

        public Task<int> DeleteHotelRoomImage(int imageID);

        public Task<int> DeleteAllImages(int RoomID);

        public Task<IEnumerable<HotelRoomImageDTO>> GetallRoomImages(int RoomID);
    }
}