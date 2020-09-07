#pragma checksum "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f227f6172a60abd9c7ea1e4d03473e005522308b"
// <auto-generated/>
#pragma warning disable 1591
namespace StBarnabasHospiceTable.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using StBarnabasHospiceTable.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\_Imports.razor"
using StBarnabasHospiceTable.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
using StBarnabasHospiceTable.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
using StBarnabasHospiceTable.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listitem")]
    public partial class ListItems : ListItemsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "items");
            __builder.AddAttribute(2, "class", "widget");
            __builder.AddMarkupContent(3, "\r\n    \r\n    ");
            __builder.OpenElement(4, "h3");
            __builder.AddContent(5, "Items");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "type", "submit");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                             AddItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "btn btn-primary edit-btn float-right");
            __builder.AddContent(10, "Add Item");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    \r\n    ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table table-bordered");
            __builder.AddAttribute(14, "style", "width:90%;");
            __builder.AddMarkupContent(15, "\r\n        \r\n        ");
            __builder.AddMarkupContent(16, "<thead>\r\n            <tr>\r\n                <th scope=\"col\">Item Name</th>\r\n                <th scope=\"col\">Description</th>\r\n                \r\n                <th scope=\"col\">Image</th>\r\n            </tr>\r\n        </thead>\r\n        \r\n        ");
            __builder.OpenElement(17, "tbody");
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 27 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
             foreach (var item in Items)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "                ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 30 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                         item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 31 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                         item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "img");
            __builder.AddAttribute(30, "src", 
#nullable restore
#line 32 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                   item.Image

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 34 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 38 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
 if (ShowPopup == true)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "    \r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "modal");
            __builder.AddAttribute(40, "tabindex", "-1");
            __builder.AddAttribute(41, "style", "display:block");
            __builder.AddAttribute(42, "role", "dialog");
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "modal-dialog");
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "modal-content");
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "modal-header");
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.AddMarkupContent(53, "<h3 class=\"modal-title\">Add item</h3>\r\n                    \r\n                    ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "type", "button");
            __builder.AddAttribute(56, "class", "close");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                                                  ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.AddMarkupContent(59, "<span aria-hidden=\"true\">X</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                \r\n                ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "modal-body");
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(65);
            __builder.AddAttribute(66, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 53 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                      HRItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 53 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                                              HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(69, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(70);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(72);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n                        ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group row");
                __builder2.AddMarkupContent(76, "\r\n                            ");
                __builder2.AddMarkupContent(77, "<label for=\"name\" class=\"col-sm-3\">Name: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(78);
                __builder2.AddAttribute(79, "id", "name");
                __builder2.AddAttribute(80, "class", "form-control col-sm-8");
                __builder2.AddAttribute(81, "placeholder", "Enter Item Name");
                __builder2.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                                                                             HRItem.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HRItem.Name = __value, HRItem.Name))));
                __builder2.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HRItem.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n                        ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group row");
                __builder2.AddMarkupContent(89, "\r\n                            ");
                __builder2.AddMarkupContent(90, "<label for=\"name\" class=\"col-sm-3\">Description: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(91);
                __builder2.AddAttribute(92, "id", "description");
                __builder2.AddAttribute(93, "class", "form-control col-sm-8");
                __builder2.AddAttribute(94, "placeholder", "Enter Item Description");
                __builder2.AddAttribute(95, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                                                                                        HRItem.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HRItem.Description = __value, HRItem.Description))));
                __builder2.AddAttribute(97, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HRItem.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(98, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                        ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "form-group row");
                __builder2.AddMarkupContent(102, "\r\n                            ");
                __builder2.AddMarkupContent(103, "<label for=\"name\" class=\"col-sm-3\">Image Link: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(104);
                __builder2.AddAttribute(105, "id", "image");
                __builder2.AddAttribute(106, "class", "form-control col-sm-8");
                __builder2.AddAttribute(107, "placeholder", "Enter Item Image Link");
                __builder2.AddAttribute(108, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                                                                              HRItem.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HRItem.Image = __value, HRItem.Image))));
                __builder2.AddAttribute(110, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HRItem.Image));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(111, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                        ");
                __builder2.AddMarkupContent(113, "<button type=\"submit\" class=\"btn btn-primary edit-btn\">Add Item</button>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(114, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
#nullable restore
#line 74 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(119, "    ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "alert alert-info");
            __builder.AddContent(122, 
#nullable restore
#line 77 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
                                   Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n");
#nullable restore
#line 78 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\ListItems.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IItemDataService itemService { get; set; }
    }
}
#pragma warning restore 1591
