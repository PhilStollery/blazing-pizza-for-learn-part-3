#pragma checksum "/Users/phil/agylia/BlazingPizza/Pages/OrderDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81e57fb709469a1af3aba882e02ef0d46718a8cd"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/phil/agylia/BlazingPizza/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/phil/agylia/BlazingPizza/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/phil/agylia/BlazingPizza/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/phil/agylia/BlazingPizza/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/phil/agylia/BlazingPizza/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/phil/agylia/BlazingPizza/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/phil/agylia/BlazingPizza/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/phil/agylia/BlazingPizza/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/phil/agylia/BlazingPizza/_Imports.razor"
using BlazingPizza;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/phil/agylia/BlazingPizza/_Imports.razor"
using BlazingPizza.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/phil/agylia/BlazingPizza/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/myorders/{orderId:int}")]
    public partial class OrderDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-bar");
            __builder.AddMarkupContent(2, "<a class=\"logo\" href><img src=\"img/logo.svg\"></a>\n\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(3);
            __builder.AddAttribute(4, "href", "");
            __builder.AddAttribute(5, "class", "nav-tab");
            __builder.AddAttribute(6, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 10 "/Users/phil/agylia/BlazingPizza/Pages/OrderDetail.razor"
                                            NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "<img src=\"img/pizza-slice.svg\">\n        ");
                __builder2.AddMarkupContent(9, "<div>Get Pizza</div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\n\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(11);
            __builder.AddAttribute(12, "href", "myorders");
            __builder.AddAttribute(13, "class", "nav-tab");
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "<img src=\"img/bike.svg\">\n        ");
                __builder2.AddMarkupContent(16, "<div>My Orders</div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "main");
#nullable restore
#line 23 "/Users/phil/agylia/BlazingPizza/Pages/OrderDetail.razor"
     if (invalidOrder)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "<h2>Order not found</h2>\n        ");
            __builder.AddMarkupContent(21, "<p>We\'re sorry but this order no longer exists.</p>");
#nullable restore
#line 27 "/Users/phil/agylia/BlazingPizza/Pages/OrderDetail.razor"
    }
    else if (orderWithStatus == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<div class=\"track-order\"><div class=\"track-order-title\"><h2><text>Loading...</text></h2>\n                <p class=\"ml-auto mb-0\">\n                    ...\n                </p></div></div>");
#nullable restore
#line 40 "/Users/phil/agylia/BlazingPizza/Pages/OrderDetail.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "track-order");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "track-order-title");
            __builder.OpenElement(27, "h2");
            __builder.AddMarkupContent(28, "\n                    Order placed ");
            __builder.AddContent(29, 
#nullable restore
#line 46 "/Users/phil/agylia/BlazingPizza/Pages/OrderDetail.razor"
                                  orderWithStatus.Order.CreatedTime.ToLongDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                ");
            __builder.OpenElement(31, "p");
            __builder.AddAttribute(32, "class", "ml-auto mb-0");
            __builder.AddMarkupContent(33, "\n                    Status: ");
            __builder.OpenElement(34, "strong");
            __builder.AddContent(35, 
#nullable restore
#line 49 "/Users/phil/agylia/BlazingPizza/Pages/OrderDetail.razor"
                                     orderWithStatus.StatusText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "track-order-body");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "track-order-details");
#nullable restore
#line 54 "/Users/phil/agylia/BlazingPizza/Pages/OrderDetail.razor"
                   foreach (var pizza in orderWithStatus.Order.Pizzas)
                  {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "p");
            __builder.OpenElement(42, "strong");
            __builder.AddContent(43, 
#nullable restore
#line 58 "/Users/phil/agylia/BlazingPizza/Pages/OrderDetail.razor"
                                pizza.Size

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, "\"\n                              ");
            __builder.AddContent(45, 
#nullable restore
#line 59 "/Users/phil/agylia/BlazingPizza/Pages/OrderDetail.razor"
                               pizza.Special.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(46, "\n                              (£");
            __builder.AddContent(47, 
#nullable restore
#line 60 "/Users/phil/agylia/BlazingPizza/Pages/OrderDetail.razor"
                                 pizza.GetFormattedTotalPrice()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(48, ")\n                          ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "/Users/phil/agylia/BlazingPizza/Pages/OrderDetail.razor"
                  }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "/Users/phil/agylia/BlazingPizza/Pages/OrderDetail.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "/Users/phil/agylia/BlazingPizza/Pages/OrderDetail.razor"
       
    [Parameter] public int OrderId { get; set; }

    OrderWithStatus orderWithStatus;
    bool invalidOrder = false;

    protected override async Task OnParametersSetAsync()
    {
      try
      {
          orderWithStatus = await HttpClient.GetFromJsonAsync<OrderWithStatus>(NavigationManager.BaseUri + $"orders/{OrderId}");
      }
      catch (Exception ex)
      {
          invalidOrder = true;
          Console.Error.WriteLine(ex);
      }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
