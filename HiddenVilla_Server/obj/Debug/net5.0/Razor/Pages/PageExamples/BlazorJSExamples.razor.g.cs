#pragma checksum "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\PageExamples\BlazorJSExamples.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ed3f4f5e6e45b00c2f813af277b564329727ee5"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 13 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Helper;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/blazorjs")]
    public partial class BlazorJSExamples : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>BlazorJSExamples</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row mt-4");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "button btn-secondary");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\PageExamples\BlazorJSExamples.razor"
                                                   (()=>TaskConfirmBox(ConfirmMessage))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Test Confirm Button");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row mt-4");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "button btn-success");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\PageExamples\BlazorJSExamples.razor"
                                                 TestSuccess

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Test Confirm Button");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "button btn-danger");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\PageExamples\BlazorJSExamples.razor"
                                                TestFailure

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Test Confirm Button");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row mt-4");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "button btn-success");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\PageExamples\BlazorJSExamples.razor"
                                                 SwalSuc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Sweet Success");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "button btn-danger");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\PageExamples\BlazorJSExamples.razor"
                                                SwalError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Sweet Failed");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, ">\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "row");
#nullable restore
#line 18 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\PageExamples\BlazorJSExamples.razor"
     if(Confirm)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "<p>Confirmation Affirmative</p>");
#nullable restore
#line 21 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\PageExamples\BlazorJSExamples.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "<p>Negative</p>");
#nullable restore
#line 25 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\PageExamples\BlazorJSExamples.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\PageExamples\BlazorJSExamples.razor"
       
    private string ConfirmMessage  = "Are you Sure?";
    private bool Confirm { get; set; }
    private async Task TaskConfirmBox(string message)
    {
        Confirm = await JsRuntimes.InvokeAsync<bool>("confirm",ConfirmMessage);
    }
    private async Task TestSuccess()
    {
        await JsRuntimes.ToastrSuccess("Success Message");
    }
    private async Task TestFailure()
    {
        await JsRuntimes.ToastrFailure("Failed Message");
    }
    private async Task SwalSuc()
    {
        await JsRuntimes.SwalSuc("SwalSuccess");
    }
    private async Task SwalError()
    {
        await JsRuntimes.SwalError("SwalSuccess");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntimes { get; set; }
    }
}
#pragma warning restore 1591
