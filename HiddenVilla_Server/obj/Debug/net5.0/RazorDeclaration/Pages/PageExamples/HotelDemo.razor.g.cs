// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Server.Pages.PageExamples
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.RazorComponentFolder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/HotelDemo")]
    public partial class HotelDemo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\PageExamples\HotelDemo.razor"
 
	public int RoomsSelected = 0;
	List<BlazorRoom> RoomsList = new List<BlazorRoom>();
	List<BlazorAmenities> AmenityList = new List<BlazorAmenities>();
	protected override void OnInitialized()
	{
		base.OnInitialized();
		RoomsList.Add(new BlazorRoom()
		{
			Id = 1,
			RoomName = "Suite1",
			IsActive = true,
			Price = 499,
			RoomProps = new List<RoomProperites>
			{
				new RoomProperites{Id=1, Name="Footage", Value ="100"},
				new RoomProperites{Id=2, Name="Occupancy", Value ="3"}
			}

		});
		RoomsList.Add(new BlazorRoom()
		{
			Id = 2,
			RoomName = "Suit2",
			IsActive = true,
			Price = 1009,
			RoomProps = new List<RoomProperites>
			{
				new RoomProperites{Id=1, Name="Footage", Value ="200"},
				new RoomProperites{Id=2, Name="Occupancy", Value ="6"}
			}

		});

		AmenityList.Add(new BlazorAmenities()
		{
			Id = 1,
			Name = "Gym",
            Description = "24X7 Gym"			
		});
		AmenityList.Add(new BlazorAmenities()
		{
			Id = 2,
			Name = "Pool",
            Description = "There is an indoor pool open from 6pm till 10am"			
		});
		AmenityList.Add(new BlazorAmenities()
		{
			Id = 3,
			Name = "Free Breakfast",
            Description = "Nom nom in da' morning, nom nom till you be full Yo!"			
		});
	}

	protected void RoomSelectionCounterChanged(bool isRoomSelected)
	{
		if (isRoomSelected)
		{
			RoomsSelected++;
		}
		else
		{
			RoomsSelected--;
		}
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
