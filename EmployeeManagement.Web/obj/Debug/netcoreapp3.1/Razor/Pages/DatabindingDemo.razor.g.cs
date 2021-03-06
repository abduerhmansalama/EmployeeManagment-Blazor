#pragma checksum "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\DatabindingDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c9721372edf9b6af1ce0df870e67580d4f58dc5"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/databindingdemo")]
    public partial class DatabindingDemo : DatabindingDemoBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Data Binding Demo</h1>\n<hr>\n");
            __builder.AddMarkupContent(1, "<h3>One Way Data Binding</h3>\n\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.AddMarkupContent(4, "<b>Name :</b> ");
#nullable restore
#line 9 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
__builder.AddContent(5, Name);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n");
            __builder.OpenElement(8, "div");
            __builder.AddMarkupContent(9, "\n    ");
            __builder.AddMarkupContent(10, "<b>Name with salutation:</b> ");
#nullable restore
#line 12 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
__builder.AddContent(11, Gender == "Male" ? $"Mr. {Name}" : $"Miss. {Name}");

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n");
            __builder.OpenElement(14, "div");
            __builder.AddMarkupContent(15, "\n    ");
            __builder.AddMarkupContent(16, "<b>Name :</b> ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "value", 
#nullable restore
#line 15 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                 Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n\n<hr>\n");
            __builder.AddMarkupContent(21, "<h3>Two Way Data Binding</h3>\n\n");
            __builder.OpenElement(22, "div");
            __builder.AddMarkupContent(23, "\n    ");
            __builder.AddMarkupContent(24, "<b>Name :</b> ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "value", 
#nullable restore
#line 22 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                 Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 22 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                                    e => { Name = e.Value.ToString(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
            __builder.OpenElement(30, "div");
            __builder.AddMarkupContent(31, "\n    ");
            __builder.AddMarkupContent(32, "<b>Name :</b> ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n");
            __builder.OpenElement(38, "div");
            __builder.AddMarkupContent(39, "\n    ");
            __builder.AddMarkupContent(40, "<b>Name :</b> ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n\n");
            __builder.OpenElement(46, "div");
            __builder.AddMarkupContent(47, "\n    ");
            __builder.AddMarkupContent(48, "<b>Colour :</b> ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                  Colour

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Colour = __value, Colour));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n\n");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "style", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                  Colour

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Colour = __value, Colour));
            __builder.SetUpdatesAttributeName("style");
            __builder.AddMarkupContent(57, "\n    ");
            __builder.AddMarkupContent(58, "<h3>The background colour of this text changes</h3>\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n\n");
            __builder.AddMarkupContent(60, "<b>Description</b>\n\n");
            __builder.OpenElement(61, "div");
            __builder.AddMarkupContent(62, "\n    ");
            __builder.OpenElement(63, "textarea");
            __builder.AddAttribute(64, "style", "width:500px");
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                     Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Description = __value, Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n");
            __builder.OpenElement(69, "div");
            __builder.AddMarkupContent(70, "\n    Count : ");
#nullable restore
#line 45 "G:\Training Projects\EmployeeManagment-master\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
__builder.AddContent(71, Description.Length);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(72, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
