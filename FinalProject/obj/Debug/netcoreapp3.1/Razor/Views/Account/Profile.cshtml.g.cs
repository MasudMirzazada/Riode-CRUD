#pragma checksum "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4babbc33d160330028857a608dc5940ec2126931"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4babbc33d160330028857a608dc5940ec2126931", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11387cfc1771cfbca0138c2155cfafcba45e86e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MemberProfileVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    int orderCount = 0;
    int orderItemCount = 0;
    double totalOrderItem = 0;
    foreach (var item in Model.Orders)
    {
        foreach (var item1 in item.OrderItems)
        {
            totalOrderItem = item1.TotalPrice;
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <!-- breadcrumb area start -->
    <div class=""breadcrumb-area bg-img"" data-bg=""assets/img/banner/breadcrumb-banner.jpg"" style=""background-image: url(&quot;assets/img/banner/breadcrumb-banner.jpg&quot;);"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""breadcrumb-wrap text-center"">
                        <nav aria-label=""breadcrumb"">
                            <h1 class=""breadcrumb-title"">My Account</h1>
                            <ul class=""breadcrumb"">
                                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">My Account</li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- breadcrumb area end -->
    <!-- my account wrapper start -->
    <div class=""my-account-wrapper se");
            WriteLiteral(@"ction-padding"">
        <div class=""container custom-container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <!-- My Account Page Start -->
                    <div class=""myaccount-page-wrapper"">
                        <!-- My Account Tab Menu Start -->
                        <div class=""row"">
                            <div class=""col-lg-3 col-md-4"">
                                <div class=""myaccount-tab-menu nav"" role=""tablist"">
                                    <a href=""#dashboad"" class=""active"" data-toggle=""dashboad"">
                                        <i class=""fa fa-dashboard""></i>
                                        Dashboard
                                    </a>
                                    <a href=""#orders"" data-toggle=""orders""><i class=""fa fa-cart-arrow-down""></i> Orders</a>
                                    <a href=""#download"" data-toggle=""download""><i class=""fa fa-cloud-download""></i> Download</a>
                         ");
            WriteLiteral(@"           <a href=""#payment-method"" data-toggle=""payment-method"">
                                        <i class=""fa fa-credit-card""></i> Payment
                                        Method
                                    </a>
                                    <a href=""#address-edit"" data-toggle=""address-edit""><i class=""fa fa-map-marker""></i> address</a>
                                    <a href=""#account-info"" data-toggle=""account-info""><i class=""fa fa-user""></i> Account Details</a>
                                    <a href=""login-register.html"" data-toggle=""""><i class=""fa fa-sign-out""></i> Logout</a>
                                </div>
                            </div>
                            <!-- My Account Tab Menu End -->
                            <!-- My Account Tab Content Start -->
                            <div class=""col-lg-9 col-md-8"">
                                <div class=""tab-content"" id=""myaccountContent"">
                                    <!-- Single Tab Conte");
            WriteLiteral(@"nt Start -->
                                    <div class=""tab-pane fade show active"" id=""dashboad"" data-toggle=""dashboad"" role=""tabpanel"">
                                        <div class=""myaccount-content"">
                                            <h3>Dashboard</h3>
                                            <div class=""welcome"">
                                                <p>Hello, <strong>Alex Tuntuni</strong> (If Not <strong>Tuntuni !</strong><a href=""login-register.html"" class=""logout""> Logout</a>)</p>
                                            </div>
                                            <p class=""mb-0"">From your account dashboard. you can easily check &amp; view your recent orders, manage your shipping and billing addresses and edit your password and account details.</p>
                                        </div>
                                    </div>
                                    <!-- Single Tab Content End -->
                                    <!-- Single Tab Cont");
            WriteLiteral(@"ent Start -->
                                    <div class=""tab-pane fade"" id=""orders"" data-toggle=""orders"" role=""tabpanel"">
                                        <div class=""myaccount-content"">
                                            <h3>Orders</h3>
                                            <div class=""myaccount-table table-responsive text-center"">
                                                <table class=""table table-bordered"">
                                                    <thead class=""thead-light"">
                                                        <tr>
                                                            <th>Order</th>
                                                            <th>User</th>
                                                            <th>Product Count</th>
                                                            <th>Total</th>
");
            WriteLiteral(@"                                                            <th>Status</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
");
#nullable restore
#line 94 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                                         foreach (var item in Model.Orders)
                                                        {
                                                            orderCount++;
                                                            orderItemCount = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <tr data-toggle=\"collapse\" data-target=\"#demo");
#nullable restore
#line 98 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                                                                                     Write(orderCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"accordion-toggle openCloseOrderItem\">\n                                                                <td>");
#nullable restore
#line 99 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                                               Write(orderCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                <td>");
#nullable restore
#line 100 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                                               Write(item.AppUser.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                <td>");
#nullable restore
#line 101 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                                               Write(item.OrderItems.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                <td>");
#nullable restore
#line 102 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                                               Write(item.OrderItems.Sum(o => o.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                <td>");
            WriteLiteral("</td>\n                                                                <td>");
#nullable restore
#line 104 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                                               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan=""12"" class=""hiddenRow"">
                                                                    <div class=""accordian-body collapse""");
            BeginWriteAttribute("id", " id=\"", 7043, "\"", 7065, 2);
            WriteAttributeValue("", 7048, "demo", 7048, 4, true);
#nullable restore
#line 108 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
WriteAttributeValue("", 7052, orderCount, 7052, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""opacity: 1;"">
                                                                        <table class=""table table-striped"">
                                                                            <thead>
                                                                                <tr class=""info"">
                                                                                    <th>#</th>
                                                                                    <th>Product Name</th>
                                                                                    <th>Count</th>
                                                                                    <th>Total Price</th>
                                                                                    <th>Price</th>
                                                                                </tr>
                                                                            </thead>
                                     ");
            WriteLiteral("                                       <tbody>\n");
#nullable restore
#line 120 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                                                                 foreach (var orderItem in item.OrderItems)
                                                                                {
                                                                                    orderItemCount++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                                    <tr data-toggle=\"collapse\" class=\"accordion-toggle\">\n                                                                                        <td>");
#nullable restore
#line 124 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                                                                       Write(orderItemCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                        <td>");
#nullable restore
#line 125 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                                                                       Write(orderItem.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                        <td>");
#nullable restore
#line 126 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                                                                       Write(orderItem.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                        <td>");
#nullable restore
#line 127 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                                                                       Write(orderItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                        <td>");
#nullable restore
#line 128 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                                                                       Write(orderItem.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                    </tr>\n");
#nullable restore
#line 130 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                            </tbody>
                                                                        </table>
                                                                    </div>
                                                                </td>
                                                            </tr>
");
#nullable restore
#line 136 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- Single Tab Content End -->
                                    <!-- Single Tab Content Start -->
                                    <div class=""tab-pane fade"" id=""download"" data-toggle=""download"" role=""tabpanel"">
                                        <div class=""myaccount-content"">
                                            <h3>Downloads</h3>
                                            <div class=""myaccount-table table-responsive text-center"">
                                                <table class=""table table-bordered"">
                                                    <thead class=""thead-light"">
                                                        <tr>
                                              ");
            WriteLiteral(@"              <th>Product</th>
                                                            <th>Date</th>
                                                            <th>Expire</th>
                                                            <th>Download</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <td>Haven - Free Real Estate PSD Template</td>
                                                            <td>Aug 22, 2018</td>
                                                            <td>Yes</td>
                                                            <td><a href=""#"" class=""btn ""><i class=""fa fa-cloud-download""></i> Download File</a></td>
                                                        </tr>
                                                ");
            WriteLiteral(@"        <tr>
                                                            <td>HasTech - Profolio Business Template</td>
                                                            <td>Sep 12, 2018</td>
                                                            <td>Never</td>
                                                            <td><a href=""#"" class=""btn ""><i class=""fa fa-cloud-download""></i> Download File</a></td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- Single Tab Content End -->
                                    <!-- Single Tab Content Start -->
                                    <div class=""tab-pane fade"" id=""payment-method"" data-toggle=""payment-method"" role=""tabpanel"">
           ");
            WriteLiteral(@"                             <div class=""myaccount-content"">
                                            <h3>Payment Method</h3>
                                            <p class=""saved-message"">You Can't Saved Your Payment Method yet.</p>
                                        </div>
                                    </div>
                                    <!-- Single Tab Content End -->
                                    <!-- Single Tab Content Start -->
                                    <div class=""tab-pane fade"" id=""address-edit"" data-toggle=""address-edit"" role=""tabpanel"">
                                        <div class=""myaccount-content"">
                                            <h3>Billing Address</h3>
                                            <address>
                                                <p><strong>Alex Tuntuni</strong></p>
                                                <p>
                                                    1355 Market St, Suite 900 <br>
             ");
            WriteLiteral(@"                                       San Francisco, CA 94103
                                                </p>
                                                <p>Mobile: (123) 456-7890</p>
                                            </address>
                                            <a class=""check-btn sqr-btn ""><i class=""fa fa-edit""></i> Edit Address</a>
                                        </div>
                                    </div>
                                    <!-- Single Tab Content End -->
                                    <!-- Single Tab Content Start -->
                                    <div class=""tab-pane fade"" id=""account-info"" data-toggle=""account-info"" role=""tabpanel"">
                                        <div class=""myaccount-content"">
                                            <h3>Account Details</h3>
                                            <div class=""account-details-form"">

                                                ");
#nullable restore
#line 206 "C:\Users\HP\Desktop\Final riode\RiodeFinalLibraff-main\FinalProject\FinalProject\Views\Account\Profile.cshtml"
                                           Write(await Html.PartialAsync("_ProfileFormPartial", Model.Member));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div> <!-- Single Tab Content End -->
                                </div>
                            </div> <!-- My Account Tab Content End -->
                        </div>
                    </div> <!-- My Account Page End -->
                </div>
            </div>
        </div>
    </div>
    <!-- my account wrapper end -->
</main>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>

<script>
    $(document).ready(function () {
        $(document).on(""click"", "".openCloseOrderItem"", function () {
            $(this).next().find("".accordian-body"").slideToggle();
            $(this).next().find("".accordian-body"").css({
                ""opacity"": ""1"",
                ""display"":""block""
            });
        })
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MemberProfileVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
