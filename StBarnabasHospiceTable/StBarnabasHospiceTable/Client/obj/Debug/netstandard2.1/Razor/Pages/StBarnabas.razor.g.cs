#pragma checksum "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca077d51242c7c6f52dcd0aed14f21dff1b4cfc5"
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
#line 2 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
using Blazorme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
using StBarnabasHospiceTable.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
using StBarnabasHospiceTable.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
using StBarnabasHospiceTable.Client.Pages.SessionState;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/barnabas")]
    public partial class StBarnabas : StBarnabasBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<p></p>\r\n");
            __builder.AddMarkupContent(1, @"<style>
    a.button1 {
        border: 0.1em solid #000000;
        border-radius: 0.12em;
        box-sizing: border-box;
        color: #000000;
    }

        a.button1:hover {
            color: #FFFFFF;
            background-color: #000000;
        }

    .container-pane {
        padding: 70px 0;
        vertical-align: middle
    }
</style>

");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid border border-primary");
            __builder.AddAttribute(4, "style", "text-align:center; width: 100%; height:600px");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenComponent<Blazorme.Split>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<Blazorme.SplitPane>(9);
                __builder2.AddAttribute(10, "SizeInPercentage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                     33

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "MinSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 33 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                  0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n            ");
                    __builder3.OpenComponent<Blazorme.Split>(14);
                    __builder3.AddAttribute(15, "Direction", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorme.SplitDirection>(
#nullable restore
#line 34 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                               SplitDirection.Vertical

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "GutterSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                    5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(18, "\r\n                ");
                        __builder4.OpenComponent<StBarnabasHospiceTable.Client.Pages.ButtonTemplate>(19);
                        __builder4.AddComponentReferenceCapture(20, (__value) => {
#nullable restore
#line 35 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                      buttonOne = (StBarnabasHospiceTable.Client.Pages.ButtonTemplate)__value;

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(21, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenComponent<Blazorme.SplitPane>(24);
                __builder2.AddAttribute(25, "SizeInPercentage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                     33

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "MinSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 38 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                  0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(28, "\r\n            ");
                    __builder3.OpenComponent<Blazorme.Split>(29);
                    __builder3.AddAttribute(30, "Direction", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorme.SplitDirection>(
#nullable restore
#line 39 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                               SplitDirection.Vertical

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "GutterSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                    5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(33, "\r\n                ");
                        __builder4.OpenComponent<Blazorme.SplitPane>(34);
                        __builder4.AddAttribute(35, "MinSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 40 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                    0

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(37, "\r\n");
#nullable restore
#line 41 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                     if (displayButton == true)
                    {
                        buttonCount = 3;

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(38, "                        ");
                            __builder5.OpenElement(39, "div");
                            __builder5.AddAttribute(40, "class", "container-pane");
                            __builder5.AddMarkupContent(41, "\r\n                            ");
                            __builder5.OpenElement(42, "a");
                            __builder5.AddAttribute(43, "id", "threePane");
                            __builder5.AddAttribute(44, "class", "oi oi-plus btn button1");
                            __builder5.AddAttribute(45, "aria-hidden", "true");
                            __builder5.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                                                          ShowPopup

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(47, "style", "border-radius:35%; padding:50px");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(48, "\r\n                        ");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(49, "\r\n");
#nullable restore
#line 47 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                    }

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(50, "                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(51, "\r\n                ");
                        __builder4.OpenComponent<Blazorme.SplitPane>(52);
                        __builder4.AddAttribute(53, "MinSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 49 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                    0

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(55, "\r\n");
#nullable restore
#line 50 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                     if (displayButton == true)
                    {
                        buttonCount = 4;

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(56, "                        ");
                            __builder5.OpenElement(57, "div");
                            __builder5.AddAttribute(58, "class", "container-pane");
                            __builder5.AddMarkupContent(59, "\r\n                            ");
                            __builder5.OpenElement(60, "a");
                            __builder5.AddAttribute(61, "id", "fourPane");
                            __builder5.AddAttribute(62, "class", "oi oi-plus btn button1");
                            __builder5.AddAttribute(63, "aria-hidden", "true");
                            __builder5.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                                                         ShowPopup

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(65, "style", "border-radius:35%; padding:50px");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(66, "\r\n                        ");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(67, "\r\n");
#nullable restore
#line 56 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                    }

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(68, "                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(69, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.OpenComponent<Blazorme.SplitPane>(72);
                __builder2.AddAttribute(73, "SizeInPercentage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 60 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                     33

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "MinSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 60 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                  0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(76, "\r\n            ");
                    __builder3.OpenComponent<Blazorme.Split>(77);
                    __builder3.AddAttribute(78, "Direction", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorme.SplitDirection>(
#nullable restore
#line 61 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                               SplitDirection.Vertical

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(79, "GutterSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 61 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                    5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(81, "\r\n                ");
                        __builder4.OpenComponent<Blazorme.SplitPane>(82);
                        __builder4.AddAttribute(83, "MinSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 62 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                    0

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(85, "\r\n");
#nullable restore
#line 63 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                     if (displayButton == true)
                    {
                        buttonCount = 5;

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(86, "                        ");
                            __builder5.OpenElement(87, "div");
                            __builder5.AddAttribute(88, "class", "container-pane");
                            __builder5.AddMarkupContent(89, "\r\n                            ");
                            __builder5.OpenElement(90, "a");
                            __builder5.AddAttribute(91, "id", "fivePane");
                            __builder5.AddAttribute(92, "class", "oi oi-plus btn button1");
                            __builder5.AddAttribute(93, "aria-hidden", "true");
                            __builder5.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                                                         ShowPopup

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(95, "style", "border-radius:35%; padding:50px");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(96, "\r\n                        ");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(97, "\r\n");
#nullable restore
#line 69 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                    }

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(98, "                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(99, "\r\n                ");
                        __builder4.OpenComponent<Blazorme.SplitPane>(100);
                        __builder4.AddAttribute(101, "MinSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 71 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                    0

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(103, "\r\n                    ");
                            __builder5.OpenElement(104, "div");
                            __builder5.AddAttribute(105, "class", "container-pane");
                            __builder5.AddMarkupContent(106, "\r\n                        ");
                            __builder5.OpenElement(107, "a");
                            __builder5.AddAttribute(108, "id", "sixPane");
                            __builder5.AddAttribute(109, "class", "oi oi-plus btn button1");
                            __builder5.AddAttribute(110, "aria-hidden", "true");
                            __builder5.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                                                    ShowPopup

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(112, "style", "border-radius:35%; padding:50px");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(113, "\r\n                    ");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(114, "\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(115, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(116, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(117, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(118, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n\r\n");
#nullable restore
#line 81 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
 if (imagePopup == true)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(120, "    ");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "modal");
            __builder.AddAttribute(123, "tabindex", "-1");
            __builder.AddAttribute(124, "style", "display:block");
            __builder.AddAttribute(125, "role", "dialog");
            __builder.AddMarkupContent(126, "\r\n        ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "modal-dialog");
            __builder.AddMarkupContent(129, "\r\n            ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "modal-content");
            __builder.AddMarkupContent(132, "\r\n                ");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "modal-header");
            __builder.AddMarkupContent(135, "\r\n                    ");
            __builder.AddMarkupContent(136, "<h3 class=\"modal-title\">Select image </h3>\r\n                    \r\n                    ");
            __builder.OpenElement(137, "a");
            __builder.AddAttribute(138, "type", "button");
            __builder.AddAttribute(139, "class", "close oi oi-circle-x");
            __builder.AddAttribute(140, "aria-hidden", "true");
            __builder.AddAttribute(141, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                                               ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                ");
            __builder.OpenElement(144, "div");
            __builder.AddAttribute(145, "class", "modal-body");
            __builder.AddMarkupContent(146, "\r\n                    \r\n                    ");
            __builder.OpenElement(147, "select");
            __builder.AddAttribute(148, "class", "form-control selectpicker");
            __builder.AddMarkupContent(149, "\r\n                        ");
            __builder.OpenElement(150, "option");
            __builder.AddContent(151, "--Select--");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n");
#nullable restore
#line 95 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                         foreach (var item in Items)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(153, "                            ");
            __builder.OpenElement(154, "option");
            __builder.AddAttribute(155, "value", 
#nullable restore
#line 97 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                            item.ItemId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 97 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
__builder.AddContent(156, item.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n");
#nullable restore
#line 98 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(158, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n                ");
            __builder.OpenElement(161, "div");
            __builder.AddAttribute(162, "class", "modal-footer");
            __builder.AddAttribute(163, "style", "text-align:center");
            __builder.AddMarkupContent(164, "\r\n                    ");
            __builder.OpenElement(165, "a");
            __builder.AddAttribute(166, "type", "button");
            __builder.AddAttribute(167, "class", "oi oi-circle-check");
            __builder.AddAttribute(168, "aria-hidden", "true");
            __builder.AddAttribute(169, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
                                                                                             EventHandleSelect

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(170, " Select ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n");
#nullable restore
#line 107 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "C:\Users\alist\OneDrive\Documents\GitHub\StBarnabasHospiceTable\StBarnabasHospiceTable\StBarnabasHospiceTable\Client\Pages\StBarnabas.razor"
       
    /// <summary>
    /// Global variables
    /// </summary>
    [Inject]
    public IItemDataService itemService { get; set; }
    public List<Item> Items { get; set; } = new List<Item>();

    /// <summary>
    /// Popup code
    /// </summary>
    bool imagePopup = false;
    bool displayButton = true;

    void CloseButton()
    {
        displayButton = false;
    }
    void ShowButton()
    {
        displayButton = true;
    }

    void ClosePopup()
    {
        imagePopup = false;
    }
    void ShowPopup()
    {
        imagePopup = true;
    }

    void EventHandleSelect()
    {
        ClosePopup();
        CloseButton();
    }

    /// <summary>
    /// Button / Session State  code
    /// </summary>
    //Have display button1, button2, button3, button4...
    //OR
    //Figure out a reference id type for each button
    int buttonCount = 0;
    public int Count { get; set; }
    //PWD:: Research
    private ButtonTemplate buttonOne;
    private void buttonCounting()
    {
        //Session State management calls the GetCurrentCount method for the current count
        //int buttonCount = CounterState.GetCurrentCount();
        //Set the current count to the button value
        buttonOne.ButtonOneValue();
        //...
        //Set Current count on the Session State object
        //CounterState.UpdateCurrentCount(buttonCount);
    }

    /// <summary>
    /// Rendering code
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {
        ClosePopup();
        ShowButton();
        Items = (await itemService.GetAllItems()).ToList();

        if (Count != 0)
        {
            Items = Items.Take(Count).ToList();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
