#pragma checksum "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "059fdcf89ba095f16ce14f4dd91f1fe4d57423dd"
// <auto-generated/>
#pragma warning disable 1591
namespace EazyAppRegistrationsPortal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using EazyAppRegistrationsPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using EazyAppRegistrationsPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using EazyAppRegistrationsPortal.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using EazyAppRegistrationsPortal.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using EazyAppRegistrationsPortal.Utils;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/{Id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/home/{Id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/index/{Id}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "h5");
            __builder.AddContent(3, "Hello, ");
            __builder.AddContent(4, 
#nullable restore
#line 11 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Index.razor"
                fullname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(8, "role", "alert");
            __builder.AddMarkupContent(9, "\r\n        <span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\r\n        ");
            __builder.AddMarkupContent(10, "<strong>Welcome to Eazy App Registration Portal</strong>\r\n\r\n        ");
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "class", "text-nowrap");
            __builder.AddMarkupContent(13, "\r\n            Start by viewing\r\n");
#nullable restore
#line 19 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Index.razor"
             if (roleId == 2)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                ");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "class", "font-weight-bold");
            __builder.AddAttribute(17, "href", "uncheckedapprovals/" + (
#nullable restore
#line 21 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Index.razor"
                                                                      Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Unchecked approvals");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 22 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Index.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "class", "font-weight-bold");
            __builder.AddAttribute(23, "href", "checkedapprovals/" + (
#nullable restore
#line 25 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Index.razor"
                                                                    Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Checked approvals");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 26 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Index.razor"
       

    [Parameter]
    public string Id { get; set; }

    int roleId;
    string fullname;

    protected override async Task OnInitializedAsync()
    {
        SessionBridgeVm sessionBridge = SessionBridgeVmManager.GetFromBasket(Id);
        if (sessionBridge == null)
        {
            NavigationManager.NavigateTo(ConfigReader.Read("VasPortalUrl"));
            return;
        }

        roleId = sessionBridge.RoleId;
        fullname = sessionBridge.FullName ?? string.Empty;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (Id.ToString() == ConfigReader.Read("DefaultGuid")) return;

        await JSRuntime.InvokeAsync<object>("BufferUrlKey", $"{Id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionBridgeVmManager SessionBridgeVmManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfigReader ConfigReader { get; set; }
    }
}
#pragma warning restore 1591