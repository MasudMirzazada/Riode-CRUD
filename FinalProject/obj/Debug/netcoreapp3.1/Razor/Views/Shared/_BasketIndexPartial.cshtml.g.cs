#pragma checksum "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df14e66a112d173aa213129d4c24e8b510e1e23d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BasketIndexPartial), @"mvc.1.0.view", @"/Views/Shared/_BasketIndexPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df14e66a112d173aa213129d4c24e8b510e1e23d", @"/Views/Shared/_BasketIndexPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11387cfc1771cfbca0138c2155cfafcba45e86e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BasketIndexPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BasketVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-remove deletecard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Remove this product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "us", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "uk", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "fr", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "aus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
  
    double subtotal = 0;
    double total = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-8 col-md-12 pr-lg-4"">
        <table class=""shop-table cart-table"">
            <thead>
                <tr>
                    <th><span>Product</span></th>
                    <th></th>
                    <th><span>Price</span></th>
                    <th><span>quantity</span></th>
                    <th>Subtotal</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 20 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
                 foreach (BasketVM basket in Model)
                {
                    subtotal += basket.Price * basket.Count;
                    total += (basket.Price + basket.ExTax) * basket.Count;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"product-thumbnail\">\r\n                            <figure>\r\n                                <a href=\"product-simple.html\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "df14e66a112d173aa213129d4c24e8b510e1e23d9381", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 971, "~/assets/images/demos/demo23/products/", 971, 38, true);
#nullable restore
#line 28 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
AddHtmlAttributeValue("", 1009, basket.Image, 1009, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </a>
                            </figure>
                        </td>
                        <td class=""product-name"">
                            <div class=""product-name-section"">
                                <a href=""product-simple.html"">");
#nullable restore
#line 34 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
                                                         Write(basket.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </div>\r\n                        </td>\r\n                        <td class=\"product-subtotal\">\r\n                            <span class=\"amount\">$");
#nullable restore
#line 38 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
                                             Write(basket.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </td>
                        <td class=""product-quantity"">
                            <div class=""input-group"">
                                <button class=""quantity-minus dec d-icon-minus""></button>
                                <input class=""quantity form-control prod-count"" type=""number"" min=""1"" max=""1000000""data-id=""");
#nullable restore
#line 43 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
                                                                                                                       Write(basket.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-productCount=\"");
#nullable restore
#line 43 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
                                                                                                                                                             Write(basket.stockCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-color=\"");
#nullable restore
#line 43 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
                                                                                                                                                                                             Write(basket.ColorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-size=\"");
#nullable restore
#line 43 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
                                                                                                                                                                                                                         Write(basket.SizeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("value", " value=\"", 2031, "\"", 2052, 1);
#nullable restore
#line 43 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
WriteAttributeValue("", 2039, basket.Count, 2039, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <button class=""quantity-plus inc d-icon-plus""></button>
                            </div>
                        </td>
                        <td class=""product-price"">
                            <span class=""amount"">$");
#nullable restore
#line 48 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
                                              Write(basket.Price*basket.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </td>\r\n                        <td class=\"product-close\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df14e66a112d173aa213129d4c24e8b510e1e23d15540", async() => {
                WriteLiteral("\r\n                                <i class=\"fas fa-times\"></i>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
                                                         WriteLiteral(basket.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
                                                                                             WriteLiteral(basket.ColorId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["color"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-color", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["color"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
                                                                                                                              WriteLiteral(basket.SizeId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["size"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-size", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["size"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 56 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
        <div class=""cart-actions mb-6 pt-4"">
            <a href=""shop.html"" class=""btn btn-dark btn-md btn-rounded btn-icon-left mr-4 mb-4""><i class=""d-icon-arrow-left""></i>Continue Shopping</a>
            <button type=""submit"" class=""btn btn-outline btn-dark btn-md btn-rounded btn-disabled"">
                Update
                Cart
            </button>
        </div>
        <div class=""cart-coupon-box mb-8"">
            <h4 class=""title coupon-title text-uppercase ls-m"">Coupon Discount</h4>
            <input type=""text"" name=""coupon_code"" class=""input-text form-control text-grey ls-m mb-4"" id=""coupon_code""");
            BeginWriteAttribute("value", " value=\"", 3496, "\"", 3504, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter coupon code here..."">
            <button type=""submit"" class=""btn btn-md btn-dark btn-rounded btn-outline"">
                Apply
                Coupon
            </button>
        </div>
    </div>
    <aside class=""col-lg-4 sticky-sidebar-wrapper"">
        <div class=""sticky-sidebar"" data-sticky-options=""{'bottom': 20}"">
            <div class=""summary mb-4"">
                <h3 class=""summary-title text-left"">Cart Totals</h3>
                <table class=""shipping"">
                    <tbody>
                        <tr class=""summary-subtotal"">
                            <td>
                                <h4 class=""summary-subtitle"">Subtotal</h4>
                            </td>
                            <td>
                                <p class=""summary-subtotal-price"">$");
#nullable restore
#line 86 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
                                                              Write(subtotal.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </td>
                        </tr>
                        <tr class=""sumnary-shipping shipping-row-last"">
                            <td colspan=""2"">
                                <h4 class=""summary-subtitle"">Calculate Shipping</h4>
                                <ul>
                                    <li>
                                        <div class=""custom-radio"">
                                            <input type=""radio"" id=""flat_rate"" name=""shipping"" class=""custom-control-input""");
            BeginWriteAttribute("checked", " checked=\"", 4918, "\"", 4928, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            <label class=""custom-control-label"" for=""flat_rate"">
                                                Flat
                                                rate
                                            </label>
                                        </div>
                                    </li>
                                    <li>
                                        <div class=""custom-radio"">
                                            <input type=""radio"" id=""free-shipping"" name=""shipping"" class=""custom-control-input"">
                                            <label class=""custom-control-label"" for=""free-shipping"">
                                                Free
                                                shipping
                                            </label>
                                        </div>
                                    </li>

                                    <li>
                           ");
            WriteLiteral(@"             <div class=""custom-radio"">
                                            <input type=""radio"" id=""local_pickup"" name=""shipping"" class=""custom-control-input"">
                                            <label class=""custom-control-label"" for=""local_pickup"">
                                                Local
                                                pickup
                                            </label>
                                        </div>
                                    </li>
                                </ul>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <div class=""shipping-address"">
                    <label>Shipping to <strong>CA.</strong></label>
                    <div class=""select-box"">
                        <select name=""country"" class=""form-control"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df14e66a112d173aa213129d4c24e8b510e1e23d24764", async() => {
                WriteLiteral("United States (US)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df14e66a112d173aa213129d4c24e8b510e1e23d26047", async() => {
                WriteLiteral(" United Kingdom");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df14e66a112d173aa213129d4c24e8b510e1e23d27244", async() => {
                WriteLiteral("France");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df14e66a112d173aa213129d4c24e8b510e1e23d28432", async() => {
                WriteLiteral("Austria");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                    <div class=\"select-box\">\r\n                        <select name=\"country\" class=\"form-control\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df14e66a112d173aa213129d4c24e8b510e1e23d29816", async() => {
                WriteLiteral("California");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df14e66a112d173aa213129d4c24e8b510e1e23d31091", async() => {
                WriteLiteral("Alaska");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df14e66a112d173aa213129d4c24e8b510e1e23d32279", async() => {
                WriteLiteral("Delaware");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df14e66a112d173aa213129d4c24e8b510e1e23d33469", async() => {
                WriteLiteral("Hawaii");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </div>
                    <input type=""text"" class=""form-control"" name=""code"" placeholder=""Town / City"">
                    <input type=""text"" class=""form-control"" name=""code"" placeholder=""ZIP"">
                    <a href=""#"" class=""btn btn-md btn-dark btn-rounded btn-outline"">
                        Update
                        totals
                    </a>
                </div>
                <table class=""total"">
                    <tbody>
                        <tr class=""summary-subtotal"">
                            <td>
                                <h4 class=""summary-subtitle"">Total</h4>
                            </td>
                            <td>
                                <p class=""summary-total-price ls-s"">$");
#nullable restore
#line 158 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Shared\_BasketIndexPartial.cshtml"
                                                                Write(total.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <a href=""checkout.html"" class=""btn btn-dark btn-rounded btn-checkout"">
                    Proceed to
                    checkout
                </a>
            </div>
        </div>
    </aside>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BasketVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
