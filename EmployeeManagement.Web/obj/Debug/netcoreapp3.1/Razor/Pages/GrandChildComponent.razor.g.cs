#pragma checksum "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\GrandChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cac08744901d4fcd194b8632da9701888109d810"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
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
    public partial class GrandChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "style", (
#nullable restore
#line 1 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\GrandChildComponent.razor"
            ElementStyle

#line default
#line hidden
#nullable disable
            ) + ";" + " " + (
#nullable restore
#line 1 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\GrandChildComponent.razor"
                           H1Border

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, "--Grand Child Component Text - ");
#nullable restore
#line 1 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\GrandChildComponent.razor"
__builder.AddContent(3, Counter);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\GrandChildComponent.razor"
       
    [CascadingParameter(Name = "ColorStyle")]
    public string ElementStyle { get; set; }

    [CascadingParameter(Name = "BorderStyle")]
    public string H1Border { get; set; }

    [CascadingParameter(Name = "Counter")]
    public int Counter { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
