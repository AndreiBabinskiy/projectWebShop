// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\[-БГУИР-]\Диплом\проект2022\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\[-БГУИР-]\Диплом\проект2022\BlazorApp1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\[-БГУИР-]\Диплом\проект2022\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\[-БГУИР-]\Диплом\проект2022\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\[-БГУИР-]\Диплом\проект2022\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\[-БГУИР-]\Диплом\проект2022\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\[-БГУИР-]\Диплом\проект2022\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\[-БГУИР-]\Диплом\проект2022\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\[-БГУИР-]\Диплом\проект2022\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\[-БГУИР-]\Диплом\проект2022\BlazorApp1\Components\WhelchairDetails.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    public partial class WhelchairDetails : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\[-БГУИР-]\Диплом\проект2022\BlazorApp1\Components\WhelchairDetails.razor"
       

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
