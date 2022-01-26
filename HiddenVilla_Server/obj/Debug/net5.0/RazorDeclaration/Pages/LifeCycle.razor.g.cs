// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Server.Pages
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
#nullable restore
#line 2 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LifeCycle.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/LifeCycle")]
    public partial class LifeCycle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LifeCycle.razor"
       
    private int currentCount = 0;
    private int count { get; set; } = 5;
    List<string> EvenType = new List<string>();
    private void IncrementCount()
    {
        currentCount++;
    }
    protected override void OnInitialized()
    {
        EvenType.Add("On Init Normal is called");
    }
    protected override async Task OnInitializedAsync()
    {
        EvenType.Add("On Init Async is called");
        await Task.Delay(1000);
    }
     protected override void OnParametersSet()
    {
       EvenType.Add("On ParamSet is called");
    }
     protected override async Task OnParametersSetAsync()
    {
       EvenType.Add("On ParamSet is called");
        await Task.Delay(1000);
    }
    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            currentCount = 111;
        }
        else
        {
            currentCount = 222;
        }
        EvenType.Add("On after render normal");
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        EvenType.Add("On after render async");
        await Task.Delay(1000);
    }
    protected override bool ShouldRender()
    {
        EvenType.Add("Should render has been called");
        return true;
    }
    void StartCountDown()
    {
        var timer = new Timer(TimerCallBack, null, 1000, 1000);
    }
    void TimerCallBack(object state)
    {
        if (count > 0)
        {
            count--;
            InvokeAsync(StateHasChanged);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591