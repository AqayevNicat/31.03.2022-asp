#pragma checksum "C:\Users\nijatma\Desktop\P224_ASP_30-03-2022_Basket-main\Pustok\Pustok\Views\Shared\_ProductDetailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35b7e995b943cb0c0563115694c7396d1aa9f98d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductDetailPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductDetailPartial.cshtml")]
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
#line 2 "C:\Users\nijatma\Desktop\P224_ASP_30-03-2022_Basket-main\Pustok\Pustok\Views\_ViewImports.cshtml"
using Pustok.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nijatma\Desktop\P224_ASP_30-03-2022_Basket-main\Pustok\Pustok\Views\_ViewImports.cshtml"
using Pustok.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nijatma\Desktop\P224_ASP_30-03-2022_Basket-main\Pustok\Pustok\Views\_ViewImports.cshtml"
using Pustok.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nijatma\Desktop\P224_ASP_30-03-2022_Basket-main\Pustok\Pustok\Views\_ViewImports.cshtml"
using Pustok.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35b7e995b943cb0c0563115694c7396d1aa9f98d", @"/Views/Shared/_ProductDetailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045a71b95c13b3515155ee034a9ee153bbd19140", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outlined--primary addtobasket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

                    
                        <div class=""row"">
                            <div class=""col-lg-5"">
                                <!-- Product Details Slider Big Image-->
                                <div class=""product-details-slider sb-slick-slider arrow-type-two"" data-slick-setting='{
              ""slidesToShow"": 1,
              ""arrows"": false,
              ""fade"": true,
              ""draggable"": false,
              ""swipe"": false,
              ""asNavFor"": "".product-slider-nav""
              }'>
                                    <div class=""single-slide"">
");
#nullable restore
#line 17 "C:\Users\nijatma\Desktop\P224_ASP_30-03-2022_Basket-main\Pustok\Pustok\Views\Shared\_ProductDetailPartial.cshtml"
                             if (@Model.ProductImages.Count > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 742, "\"", 801, 2);
            WriteAttributeValue("", 748, "image/products/", 748, 15, true);
#nullable restore
#line 19 "C:\Users\nijatma\Desktop\P224_ASP_30-03-2022_Basket-main\Pustok\Pustok\Views\Shared\_ProductDetailPartial.cshtml"
WriteAttributeValue("", 763, Model.ProductImages.ElementAt(0).Name, 763, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 802, "\"", 808, 0);
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 20 "C:\Users\nijatma\Desktop\P224_ASP_30-03-2022_Basket-main\Pustok\Pustok\Views\Shared\_ProductDetailPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                                </div>
                                <!-- Product Details Slider Nav -->
                                <div class=""mt--30 product-slider-nav sb-slick-slider arrow-type-two""
                                    data-slick-setting='{
            ""infinite"":true,
              ""autoplay"": true,
              ""autoplaySpeed"": 8000,
              ""slidesToShow"": 4,
              ""arrows"": true,
              ""prevArrow"":{""buttonClass"": ""slick-prev"",""iconClass"":""fa fa-chevron-left""},
              ""nextArrow"":{""buttonClass"": ""slick-next"",""iconClass"":""fa fa-chevron-right""},
              ""asNavFor"": "".product-details-slider"",
              ""focusOnSelect"": true
              }'>
");
            WriteLiteral(@"                                </div>
                            </div>
                            <div class=""col-lg-7 mt--30 mt-lg--30"">
                                <div class=""product-details-info pl-lg--30 "">
                                    <p class=""tag-block"">Tags: <a href=""#"">Movado</a>, <a href=""#"">Omega</a></p>
                                    <h3 class=""product-title"">Beats EP Wired On-Ear Headphone-Black</h3>
                                    <ul class=""list-unstyled"">
                                        <li>Ex Tax: <span class=""list-value""> £60.24</span></li>
                                        <li>Brands: <a href=""#"" class=""list-value font-weight-bold""> Canon</a></li>
                                        <li>Product Code: <span class=""list-value""> model1</span></li>
                                        <li>Reward Points: <span class=""list-value""> 200</span></li>
                                        <li>Availability: <span class=""list-value""> In Stock</span></li>
 ");
            WriteLiteral(@"                                   </ul>
                                    <div class=""price-block"">
                                        <span class=""price-new"">£73.79</span>
                                        <del class=""price-old"">£91.86</del>
                                    </div>
                                    <div class=""rating-widget"">
                                        <div class=""rating-block"">
                                            <span class=""fas fa-star star_on""></span>
                                            <span class=""fas fa-star star_on""></span>
                                            <span class=""fas fa-star star_on""></span>
                                            <span class=""fas fa-star star_on""></span>
                                            <span class=""fas fa-star ""></span>
                                        </div>
                                        <div class=""review-widget"">
                                            <a href=""#""");
            WriteLiteral(@">(1 Reviews)</a> <span>|</span>
                                            <a href=""#"">Write a review</a>
                                        </div>
                                    </div>
                                    <article class=""product-details-article"">
                                        <h4 class=""sr-only"">Product Summery</h4>
                                        <p>Long printed dress with thin adjustable straps. V-neckline and wiring under
                                            the Dust with ruffles
                                            at the bottom
                                            of the
                                            dress.</p>
                                    </article>
                                    <div class=""add-to-cart-row"">
                                        <div class=""count-input-block"">
                                            <span class=""widget-label"">Qty</span>
                                            <input t");
            WriteLiteral("ype=\"number\" class=\"form-control text-center quantity\" value=\"1\">\n                                        </div>\n                                        <div class=\"add-cart-btn\">\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35b7e995b943cb0c0563115694c7396d1aa9f98d10718", async() => {
                WriteLiteral("<span\n                                                    class=\"plus-icon\">+</span>Add to Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\nijatma\Desktop\P224_ASP_30-03-2022_Basket-main\Pustok\Pustok\Views\Shared\_ProductDetailPartial.cshtml"
                                                                                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                    </div>
                                    <div class=""compare-wishlist-row"">
                                        <a href=""#"" class=""add-link""><i class=""fas fa-heart""></i>Add to Wish List</a>
                                        <a href=""#"" class=""add-link""><i class=""fas fa-random""></i>Add to Compare</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    
                ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
