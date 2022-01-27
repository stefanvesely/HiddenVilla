#pragma checksum "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\RazorComponentFolder\AmenityComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a253517c102cb02f21f8ddd71bdd1b42c28045e"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.RazorComponentFolder
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
    public partial class AmenityComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light border p-2 col-5 offset-1");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\RazorComponentFolder\AmenityComponent.razor"
                                                          (args)=> AmenitySelctionChanged(args, Amenity.Name)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(3, "h4");
            __builder.AddAttribute(4, "class", "text-secondary");
            __builder.AddContent(5, " Amenity - ");
            __builder.AddContent(6, 
#nullable restore
#line 2 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\RazorComponentFolder\AmenityComponent.razor"
                                           Amenity.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\t\t\t");
            __builder.AddContent(8, 
#nullable restore
#line 3 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\RazorComponentFolder\AmenityComponent.razor"
             Amenity.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "<br>\r\n\t\t\t");
            __builder.AddContent(10, 
#nullable restore
#line 4 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\RazorComponentFolder\AmenityComponent.razor"
             Amenity.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "<br>\r\n\t\t\t");
            __builder.OpenElement(12, "span");
            __builder.AddContent(13, "Render Fragments from Parents ");
            __builder.AddContent(14, 
#nullable restore
#line 5 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\RazorComponentFolder\AmenityComponent.razor"
                                                 FirstFragment

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, " - ");
            __builder.AddContent(16, 
#nullable restore
#line 5 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\RazorComponentFolder\AmenityComponent.razor"
                                                                  SecondFragment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\RazorComponentFolder\AmenityComponent.razor"
       
	[Parameter]
	public BlazorAmenities Amenity { get; set; }
    [Parameter]
	public EventCallback<string> OnAmenitySelection { get; set; }
    [Parameter]
	public RenderFragment FirstFragment { get; set; }
	[Parameter]
	public RenderFragment SecondFragment { get; set; }

	protected async Task AmenitySelctionChanged(MouseEventArgs e, string Name)
	{
		await OnAmenitySelection.InvokeAsync(Name.ToString());
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
