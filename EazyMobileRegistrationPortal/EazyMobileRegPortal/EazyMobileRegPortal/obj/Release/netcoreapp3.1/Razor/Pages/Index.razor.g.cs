#pragma checksum "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c12c7b3457226f5ed35889f5cb89eb9ac8837d8c"
// <auto-generated/>
#pragma warning disable 1591
namespace EazyMobileRegPortal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using EazyMobileRegPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using EazyMobileRegPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using EazyMobileRegPortal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using EazyMobileRegPortal.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using EazyMobileRegPortal.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using EazyMobileRegPortal.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/{Key}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/home/{Key}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/index/{Key}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h5");
            __builder.AddContent(1, "Hello, ");
            __builder.AddContent(2, 
#nullable restore
#line 10 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\Index.razor"
            fullname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(6, "role", "alert");
            __builder.AddMarkupContent(7, "\r\n    <span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\r\n    ");
            __builder.AddMarkupContent(8, "<strong>Welcome to EazyMobile Registration Portal</strong>\r\n\r\n    ");
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "class", "text-nowrap");
            __builder.AddMarkupContent(11, "\r\n        Start by viewing\r\n");
#nullable restore
#line 18 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\Index.razor"
         if (roleId == 2)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "        ");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "class", "font-weight-bold");
            __builder.AddAttribute(15, "href", "uncheckedapprovals/" + (
#nullable restore
#line 20 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\Index.razor"
                                                              Key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Unchecked approvals");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 21 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\Index.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "        ");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "class", "font-weight-bold");
            __builder.AddAttribute(21, "href", "checkedapprovals/" + (
#nullable restore
#line 24 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\Index.razor"
                                                            Key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Checked approvals");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 25 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\Index.razor"
       

    int roleId;
    string fullname;

    [Parameter]
    public string Key { get; set; }

    protected override void OnInitialized()
    {
        SessionBridgeVm sessionBridge = SessionBridgeVmManager.GetFromBasket(Key);
        if (sessionBridge == null)
        {
            NavigationManager.NavigateTo(ConfigReader.Read("VasPortalUrl"));
            return;
        }

        roleId =sessionBridge.RoleId;
        fullname = sessionBridge.FullName ?? string.Empty;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (string.IsNullOrEmpty(Key)) return;

        await JSRuntime.InvokeAsync<object>("BufferUrlKey", $"{Key}");
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
