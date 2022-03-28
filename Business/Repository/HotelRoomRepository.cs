using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class HotelRoomRepository : IHotelRoomRepository
    {
        private readonly ApplicationDataContext _db;
        private readonly IMapper _mapper;

        public HotelRoomRepository(ApplicationDataContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<HotelRoomDTO> CreateHotelRoom(HotelRoomDTO hotelroomdto)
        {
            HotelRoom htroom = _mapper.Map<HotelRoomDTO, HotelRoom>(hotelroomdto);
            htroom.CreatedDate = DateTime.Now;
            htroom.CreatedBy = "no one yet";
            var addedhotelroom = await _db.HotelRooms.AddAsync(htroom);
            await _db.SaveChangesAsync();
            return _mapper.Map<HotelRoom, HotelRoomDTO>(addedhotelroom.Entity);
        }

        public async Task<int> DeleteHotelRoom(int roomID)
        {
            try
            {
                var roomdeet = await _db.HotelRooms.FindAsync(roomID);
                if (roomdeet != null)
                {
                    _db.HotelRooms.Remove(roomdeet);
                    return await _db.SaveChangesAsync();
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<IEnumerable<HotelRoomDTO>> GetAllHotelRooms()
        {
            try
            {
                IEnumerable<HotelRoomDTO> hotelRoomDTOs = _mapper.Map<IEnumerable<HotelRoom>, IEnumerable<HotelRoomDTO>>(_db.HotelRooms);
                return hotelRoomDTOs;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<HotelRoomDTO> GetHotelRoom(int roomID)
        {
            try
            {
                HotelRoomDTO htroomdto = _mapper.Map<HotelRoom, HotelRoomDTO>(
                   await _db.HotelRooms.FirstOrDefaultAsync(x => x.Id == roomID));
                return htroomdto;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<HotelRoomDTO> IsSameNameRoomAlreadyPresent(string roomname, int roomId = 0)
        {
            try
            {
                if (roomId == 0)
                {
                    HotelRoomDTO htroomdto = _mapper.Map<HotelRoom, HotelRoomDTO>(
                        await _db.HotelRooms.FirstOrDefaultAsync(x => x.Name.ToLower() == roomname.ToLower()));
                    return htroomdto;
                }
                else
                {
                    HotelRoomDTO htroomdto = _mapper.Map<HotelRoom, HotelRoomDTO>(
                       await _db.HotelRooms.FirstOrDefaultAsync(x => x.Name.ToLower() == roomname.ToLower()
                       && x.Id != roomId));
                    return htroomdto;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<HotelRoomDTO> UpdateHotelRoom(int roomID, HotelRoomDTO hotelroomdto)
        {
            try
            {
                if (roomID == hotelroomdto.Id)
                {
                    HotelRoom roomDetails = await _db.HotelRooms.FindAsync(roomID);
                    HotelRoom room = _mapper.Map<HotelRoomDTO, HotelRoom>(hotelroomdto, roomDetails);
                    room.UpdatedBy = "";
                    room.UpdatedDate = DateTime.Now;
                    var UpdatedRoom = _db.HotelRooms.Update(room);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<HotelRoom, HotelRoomDTO>(UpdatedRoom.Entity);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}