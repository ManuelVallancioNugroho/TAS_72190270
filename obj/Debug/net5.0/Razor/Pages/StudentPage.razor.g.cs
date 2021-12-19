#pragma checksum "C:\Blazor\BlazorFrontEnd\Pages\StudentPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb195396b22c46e51ae7b793347703960f2f6d03"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Blazor\BlazorFrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Blazor\BlazorFrontEnd\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blazor\BlazorFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blazor\BlazorFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Blazor\BlazorFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Blazor\BlazorFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Blazor\BlazorFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Blazor\BlazorFrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Blazor\BlazorFrontEnd\_Imports.razor"
using BlazorFrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Blazor\BlazorFrontEnd\_Imports.razor"
using BlazorFrontEnd.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/studentpage")]
    public partial class StudentPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Daftar Student - Manuel Vallancio - 72190270</h3>\r\n");
            __builder.AddMarkupContent(1, "<a href=\"/addstudent\" class=\"btn btn-primary\">Create New</a>\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-striped");
            __builder.AddMarkupContent(4, "<thead><tr><th>Nim</th>\r\n            <th>Nama Belakang</th>\r\n            <th>Nama Depan</th>\r\n            <th>Tanggal Masuk</th>\r\n            <th></th></tr></thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 16 "C:\Blazor\BlazorFrontEnd\Pages\StudentPage.razor"
         foreach (var stu in Student)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 19 "C:\Blazor\BlazorFrontEnd\Pages\StudentPage.razor"
                     stu.StudentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 20 "C:\Blazor\BlazorFrontEnd\Pages\StudentPage.razor"
                     stu.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 21 "C:\Blazor\BlazorFrontEnd\Pages\StudentPage.razor"
                     stu.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 22 "C:\Blazor\BlazorFrontEnd\Pages\StudentPage.razor"
                     stu.EnrollmentDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n              ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", 
#nullable restore
#line 24 "C:\Blazor\BlazorFrontEnd\Pages\StudentPage.razor"
                             $"studentdetail/{stu.StudentId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "class", "btn btn-info");
            __builder.AddContent(23, "details");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                 ");
            __builder.AddMarkupContent(25, "<td><a href=\"/detailenrollment\" class=\"btn btn-primary\">enroll</a></td>\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", 
#nullable restore
#line 26 "C:\Blazor\BlazorFrontEnd\Pages\StudentPage.razor"
                                   $"EditStudent/{stu.StudentId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "class", "btn btn-secondary m-1");
            __builder.AddContent(30, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                       ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "href", 
#nullable restore
#line 27 "C:\Blazor\BlazorFrontEnd\Pages\StudentPage.razor"
                                      $"deletestudent/{stu.StudentId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "class", "btn btn-danger m-1");
            __builder.AddContent(36, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Blazor\BlazorFrontEnd\Pages\StudentPage.razor"
            
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
