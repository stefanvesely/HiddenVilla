using System.Collections.Generic;

namespace HiddenVilla_Server.Model
{
    public class BlazorRoom
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public List<RoomProperites> RoomProps { get; set; }
    }
}