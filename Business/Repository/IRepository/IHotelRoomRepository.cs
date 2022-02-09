using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHotelRoomRepository
    {
        public Task<HotelRoomDTO> CreateHotelRoom(HotelRoomDTO hotelroomdto);
        public Task<HotelRoomDTO> UpdateHotelRoom(int roomID, HotelRoomDTO hotelroomdto);
        public Task<HotelRoomDTO> GetHotelRoom (int roomID);
        public Task<int> DeleteHotelRoom(int roomID);
        public Task<IEnumerable<HotelRoomDTO>> GetAllHotelRooms();
        public Task<HotelRoomDTO> IsSameNameRoomAlreadyPresent (string roomname);
    }
}
