#pragma checksum "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e293fbe4e9003e0e878dc116396943cf905d152"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\_Imports.razor"
using PragimTech.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<EmployeeManagement.Web.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "content px-4 container");
            __builder.AddMarkupContent(11, "\n        ");
#nullable restore
#line 9 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Shared\MainLayout.razor"
__builder.AddContent(12, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
