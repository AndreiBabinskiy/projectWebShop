#pragma checksum "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Components\WhelchairDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "956c94632d1fa52e90fe9cee7c7a0719a167d25c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Components\WhelchairDetails.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    public partial class WhelchairDetails : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Components\WhelchairDetails.razor"
 if (Wheelchair != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "img");
            __builder.AddAttribute(2, "src", 
#nullable restore
#line 5 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Components\WhelchairDetails.razor"
               imageSrc

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "class", "img-thumbnail");
            __builder.AddAttribute(4, "width", "150");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "p");
#nullable restore
#line 7 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Components\WhelchairDetails.razor"
__builder.AddContent(9, Wheelchair.WheelchairName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, " - ");
#nullable restore
#line 7 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Components\WhelchairDetails.razor"
__builder.AddContent(11, Wheelchair.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "badge badge-info ");
#nullable restore
#line 8 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Components\WhelchairDetails.razor"
__builder.AddContent(15, Wheelchair.Price);

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, " y.e");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 10 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Components\WhelchairDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\[-БГУИР-]\Диплом\Бабинский 2.0\Бабинский\проект2022\BlazorApp1\Components\WhelchairDetails.razor"
       

    [Parameter]
    public DetailsViewModel Wheelchair { get; set; }
    [Parameter]
    public EventCallback<DetailsViewModel> WheelchairChanged { get; set; }
    string imageSrc
    {
        get
        {
            return $"https://localhost:44322/images/{Wheelchair.Image}";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
