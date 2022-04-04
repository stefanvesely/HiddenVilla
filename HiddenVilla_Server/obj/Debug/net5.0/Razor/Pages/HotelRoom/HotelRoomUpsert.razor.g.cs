#pragma checksum "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26aca0f5f572375b790d7a1e357854cca81b83e3"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.HotelRoom
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
#nullable restore
#line 3 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using HiddenVilla_Server.Service.IService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/edit/{id:int}")]
    public partial class HotelRoomUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-2 mb-5");
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "class", "card-title text-info mb-3 ml-3");
            __builder.AddContent(4, 
#nullable restore
#line 12 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " Hotel Room");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                  HotelRoomModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                                  HandleRoomUpsert

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label>Name</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                HotelRoomModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.Name = __value, HotelRoomModel.Name))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomModel.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 22 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                ()=>HotelRoomModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                     ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label>Occupancy</label>\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateInputNumber_1(__builder2, 34, 35, "form-control", 36, 
#nullable restore
#line 26 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                  HotelRoomModel.Occupancy

#line default
#line hidden
#nullable disable
                , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.Occupancy = __value, HotelRoomModel.Occupancy)), 38, () => HotelRoomModel.Occupancy);
                __builder2.AddMarkupContent(39, "\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_2(__builder2, 40, 41, 
#nullable restore
#line 27 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                ()=>HotelRoomModel.Occupancy

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                     ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label>Rate</label>\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateInputNumber_3(__builder2, 46, 47, "form-control", 48, 
#nullable restore
#line 31 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                  HotelRoomModel.RegularRate

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.RegularRate = __value, HotelRoomModel.RegularRate)), 50, () => HotelRoomModel.RegularRate);
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_4(__builder2, 52, 53, 
#nullable restore
#line 32 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                ()=>HotelRoomModel.RegularRate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                     ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "<label>Square Feet</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "class", "form-control");
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                HotelRoomModel.SqFt

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.SqFt = __value, HotelRoomModel.SqFt))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomModel.SqFt));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                    ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.AddMarkupContent(66, "<label>Details</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(67);
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                    HotelRoomModel.Details

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.Details = __value, HotelRoomModel.Details))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomModel.Details));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                     ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(75);
                __builder2.AddAttribute(76, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                            HandleImageUpload

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(77, "multiple", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n                       ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "row");
#nullable restore
#line 47 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                            if(HotelRoomModel.ImageUrls != null && HotelRoomModel.ImageUrls.Count > 0 )
                            {
                                int serial = 1;
                                foreach(var roomimage in HotelRoomModel.ImageUrls)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "col-md-2 mt-3");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "room-image");
                __builder2.AddAttribute(85, "style", "background:" + " url(\'" + (
#nullable restore
#line 53 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                                                         roomimage

#line default
#line hidden
#nullable disable
                ) + "\')" + " 50%" + " 50%;" + " ");
                __builder2.OpenElement(86, "span");
                __builder2.AddAttribute(87, "class", "room-image-title");
                __builder2.AddContent(88, 
#nullable restore
#line 54 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                                            serial

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                                        ");
                __builder2.AddMarkupContent(90, "<button type=\"button\" class=\"btn btn-outline-danger btn-block mt-4\">Delete</button>");
                __builder2.CloseElement();
#nullable restore
#line 58 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                    serial++;
                                }
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                    ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-group");
                __builder2.OpenElement(94, "button");
                __builder2.AddAttribute(95, "class", "btn btn-primary");
                __builder2.AddContent(96, 
#nullable restore
#line 64 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                         Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(97, " Room");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(99);
                __builder2.AddAttribute(100, "href", "hotel-room");
                __builder2.AddAttribute(101, "class", "btn btn-secondary");
                __builder2.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(103, "Back to Room List");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\Steff\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
       
    [Parameter]
    public int? id { get; set; }


    private HotelRoomDTO HotelRoomModel { get; set; } = new HotelRoomDTO();
    private string Title { get; set; } = "Create";

    protected async override Task OnInitializedAsync()
    {
        
        if (id != null)
        {
            Title = "Update/Edit";
            HotelRoomModel = await HotelRoomRepository.GetHotelRoom(id.Value);
        }
        else
        {
            HotelRoomModel = new HotelRoomDTO();
        }
    }

    private async Task HandleRoomUpsert()
    {
       
       try
       {
            var RoomDetailsByName = await HotelRoomRepository.IsSameNameRoomAlreadyPresent(HotelRoomModel.Name, HotelRoomModel.Id);
            if(RoomDetailsByName!=null)
            {
                await JsRuntime.ToastrFailure("Room Name Exists");
                return;
            }        
            if (HotelRoomModel.Id!=0 && Title == "Update/Edit")
            {
                var UpdateRoomResult = await HotelRoomRepository.UpdateHotelRoom(HotelRoomModel.Id, HotelRoomModel);
                await JsRuntime.ToastrSuccess("Room Updated!");
            }
            else
            {
                var createdresult = await HotelRoomRepository.CreateHotelRoom(HotelRoomModel);
                await JsRuntime.ToastrSuccess("Room Created!");
            }

       }
       catch
       {
            
       }
       
       NavigationManager.NavigateTo("hotel-room");        
    }
    private async Task HandleImageUpload(InputFileChangeEventArgs e)
    {
        try
        {
         var image = new List<string>();
         if (e.GetMultipleFiles().Count > 0)
            {
                foreach (var file in e.GetMultipleFiles())
                {
                    System.IO.FileInfo fileinfo = new System.IO.FileInfo(file.Name);
                    if(fileinfo.Extension.ToLower() == ".jpg" || fileinfo.Extension.ToLower() == ".png" || fileinfo.Extension.ToLower() == ".jpeg")
                    {
                        var uploadimagepath = await FileUpload.UploadFile(file);
                        image.Add(uploadimagepath);
                    }
                    else
                    {
                        await JsRuntime.ToastrFailure("Please select only images with .png , .jpg, or .jpeg extensions.");                        
                    }
                }
                if (image.Any())
                {
                    if(HotelRoomModel.ImageUrls!=null && HotelRoomModel.ImageUrls.Any())
                    {
                        HotelRoomModel.ImageUrls.AddRange(image);
                    }
                    else
                    {
                        HotelRoomModel.ImageUrls = new List<string>();
                        HotelRoomModel.ImageUrls.AddRange(image);
                    }
                }
                else
                {
                    await JsRuntime.ToastrFailure("Image Uploading Failed");
                    return;
                }
            }
        }
        catch (Exception ex)
        {
            await JsRuntime.ToastrFailure(ex.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository HotelRoomRepository { get; set; }
    }
}
namespace __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
