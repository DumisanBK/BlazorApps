#pragma checksum "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "064bc252628df306a4c736762fce300660a748d7"
// <auto-generated/>
#pragma warning disable 1591
namespace BancaPortal.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancaPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancaPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancaPortal.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancassuranceApi.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancassuranceApi.Mappers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancassuranceApi.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancassuranceApi.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancassuranceApi.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancassuranceApi.Expressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancassuranceLib.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "wrapper");
            __builder.AddMarkupContent(2, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(3, "nav");
            __builder.AddAttribute(4, "class", "main-header navbar navbar-expand navbar-white navbar-light");
            __builder.AddMarkupContent(5, "\r\n        \r\n        ");
            __builder.OpenElement(6, "ul");
            __builder.AddAttribute(7, "class", "navbar-nav ml-auto");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "li");
            __builder.AddAttribute(10, "class", "nav-item");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-link nav-item");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Shared\MainLayout.razor"
                                                                RefreshApp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(15, "\r\n                    <i class=\"fa-sign-out mr-2\"></i>Refresh\r\n                    <span class=\"float-right text-muted text-sm\"></span>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "li");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-link nav-item");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Shared\MainLayout.razor"
                                                                DestroySession

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "\r\n                    <i class=\"fas fa-th-large\"></i> Log out\r\n                    <span class=\"float-right text-muted text-sm\"></span>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    \r\n    \r\n    ");
            __builder.OpenElement(28, "aside");
            __builder.AddAttribute(29, "class", "main-sidebar sidebar-dark-danger elevation-4");
            __builder.AddMarkupContent(30, "\r\n        \r\n        ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", "refresh_app/" + (
#nullable restore
#line 33 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Shared\MainLayout.razor"
                              key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "class", "brand-link");
            __builder.AddMarkupContent(34, "\r\n            <img src=\"images/AdminLTELogo.png\" alt=\"NBS Logo\" class=\"brand-image img-circle elevation-3\" style=\"opacity: .8\">\r\n            ");
            __builder.AddMarkupContent(35, "<span class=\"brand-text font-weight-light\">Bancassurance</span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n        \r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "sidebar");
            __builder.AddMarkupContent(39, "\r\n            \r\n            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "user-panel mt-3 pb-3 mb-3 d-flex");
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.AddMarkupContent(43, "<div class=\"image\">\r\n                    <img src=\"images/user_ico.png\" class=\"img-circle elevation-2\" alt=\"User Image\">\r\n                </div>\r\n                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "info");
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "a");
            __builder.AddAttribute(48, "href", "refresh_app/" + (
#nullable restore
#line 47 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Shared\MainLayout.razor"
                                          key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "class", "d-block");
            __builder.AddContent(50, 
#nullable restore
#line 47 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Shared\MainLayout.razor"
                                                                fullname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n            \r\n            ");
            __builder.AddMarkupContent(54, "<nav class=\"mt-2\">\r\n                <ul class=\"nav nav-pills nav-sidebar flex-column\" data-widget=\"treeview\" role=\"menu\" data-accordion=\"false\">\r\n                    \r\n                    <li class=\"nav-item\">\r\n                        <a href=\"router/home\" class=\"nav-link\">\r\n                            <i class=\"far fa-circle nav-icon\"></i>\r\n                            <p>Home</p>\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a href=\"router/unsubscriptions\" class=\"nav-link\">\r\n                            <i class=\"far fa-circle nav-icon\"></i>\r\n                            <p>Requests</p>\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a href=\"router/policies\" class=\"nav-link\">\r\n                            <i class=\"far fa-circle nav-icon\"></i>\r\n                            <p>Policies</p>\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a href=\"router/white_listed_accounts\" class=\"nav-link\">\r\n                            <i class=\"far fa-circle nav-icon\"></i>\r\n                            <p>Special Accounts</p>\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a href=\"router/members\" class=\"nav-link\">\r\n                            <i class=\"far fa-circle nav-icon\"></i>\r\n                            <p>Members</p>\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a href=\"router/accounts\" class=\"nav-link\">\r\n                            <i class=\"far fa-circle nav-icon\"></i>\r\n                            <p>Accounts</p>\r\n                        </a>\r\n                    </li>\r\n                </ul>\r\n            </nav>\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "content-wrapper");
            __builder.AddMarkupContent(59, "\r\n        \r\n        ");
            __builder.AddMarkupContent(60, @"<div class=""content-header"">
            <div class=""container-fluid"">
                <div class=""row mb-2"">
                    <div class=""col-sm-6"">
                        <h1 class=""m-0 text-dark""></h1>
                    </div>
                    <div class=""col-sm-6"">
                        <ol class=""breadcrumb float-sm-right"">
                            <li class=""breadcrumb-item""><a href=""#""></a></li>
                            <li class=""breadcrumb-item active""></li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
        
        
        ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "content");
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "container-fluid");
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "row");
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col-lg-12");
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.AddContent(73, 
#nullable restore
#line 123 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Shared\MainLayout.razor"
                         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n        \r\n        \r\n        ");
            __builder.AddMarkupContent(79, "<div class=\"content-header\">\r\n            <div class=\"container-fluid\">\r\n                <div class=\"row mb-2\">\r\n                </div>\r\n            </div>\r\n        </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n    \r\n\r\n    ");
            __builder.OpenComponent<BancaPortal.Shared.ControlSidebar>(81);
            __builder.CloseComponent();
            __builder.AddMarkupContent(82, "\r\n\r\n    ");
            __builder.OpenComponent<BancaPortal.Shared.Footer>(83);
            __builder.CloseComponent();
            __builder.AddMarkupContent(84, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 145 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Shared\MainLayout.razor"
       

    string key;
    string fullname;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        try
        {
            var keyAsObject = await JSRuntime.InvokeAsync<object>("GetUrlKey");

            if (keyAsObject is null) return;

            key = Convert.ToString(keyAsObject);

            var sessionBridge = SessionBridgeVmManager.GetFromBasket(key);
            if (sessionBridge is null) return;

            fullname = sessionBridge.FullName;
        }
        catch (Exception)
        {
            key = null;
        }
    }

    private void RefreshApp()
    {
        if (string.IsNullOrEmpty(key)) return;

        NavigationManager.NavigateTo($"refresh_app/{key}");
    }

    private void DestroySession()
    {
        if (!string.IsNullOrEmpty(key))
        {
            SessionBasket.Remove(key);
        }

        NavigationManager.NavigateTo(ConfigReader.Read("VasPortalUrl"));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionBridgeVmManager SessionBridgeVmManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionBasket SessionBasket { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfigReader ConfigReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591