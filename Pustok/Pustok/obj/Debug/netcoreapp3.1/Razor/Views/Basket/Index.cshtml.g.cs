#pragma checksum "C:\Users\nijatma\Desktop\P224_ASP_30-03-2022_Basket-main\Pustok\Pustok\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e20fcc153ec1283b6543268564fca8d752239fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e20fcc153ec1283b6543268564fca8d752239fd", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045a71b95c13b3515155ee034a9ee153bbd19140", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main class=""cart-page-main-block inner-page-sec-padding-bottom"">
			<div class=""cart_area cart-area-padding  "">
				<div class=""container"">
					<div class=""page-section-title"">
						<h1>Shopping Cart</h1>
					</div>
					<div class=""row"">
						<div class=""col-12"">
							");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e20fcc153ec1283b6543268564fca8d752239fd4666", async() => {
                WriteLiteral(@"
								<!-- Cart Table -->
								<div class=""cart-table table-responsive mb--40"">
									<table class=""table"">
										<!-- Head Row -->
										<thead>
											<tr>
												<th class=""pro-remove""></th>
												<th class=""pro-thumbnail"">Image</th>
												<th class=""pro-title"">Product</th>
												<th class=""pro-price"">Price</th>
												<th class=""pro-quantity"">Quantity</th>
												<th class=""pro-subtotal"">Total</th>
											</tr>
										</thead>
										<tbody class=""productTable"">
											");
#nullable restore
#line 26 "C:\Users\nijatma\Desktop\P224_ASP_30-03-2022_Basket-main\Pustok\Pustok\Views\Basket\Index.cshtml"
                                       Write(await Html.PartialAsync("_BasketProductTablePartial",Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\t\t\t\t\t\t\t\t\t\t\t<!-- Discount Row  -->\n\t\t\t\t\t\t\t\t\t\t\t\n\t\t\t\t\t\t\t\t\t\t</tbody>\n\t\t\t\t\t\t\t\t\t</table>\n\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
				</div>
			</div>
			<div class=""cart-section-2"">
				<div class=""container"">
					<div class=""row"">
						<div class=""col-lg-6 col-12 mb--30 mb-lg--0"">
							<!-- slide Block 5 / Normal Slider -->
							<div class=""cart-block-title"">
								<h2>YOU MAY BE INTERESTED IN…</h2>
							</div>
							<div class=""product-slider sb-slick-slider"" data-slick-setting='{
							          ""autoplay"": true,
							          ""autoplaySpeed"": 8000,
							          ""slidesToShow"": 2
									  }' data-slick-responsive='[
                {""breakpoint"":992, ""settings"": {""slidesToShow"": 2} },
                {""breakpoint"":768, ""settings"": {""slidesToShow"": 3} },
                {""breakpoint"":575, ""settings"": {""slidesToShow"": 2} },
                {""breakpoint"":480, ""settings"": {""slidesToShow"": 1} },
                {""breakpoint"":320, ""settings"": {""slidesToShow"": 1} }
            ]'>
								<div class=""single-slide"">
									<div class=""product-card"">
										<div class=""product-header"">
				");
            WriteLiteral(@"							<span class=""author"">
												Lpple
											</span>
											<h3><a href=""product-details.html"">Revolutionize Your BOOK With These
													Easy-peasy Tips</a></h3>
										</div>
										<div class=""product-card--body"">
											<div class=""card-image"">
												<img src=""image/products/product-10.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2401, "\"", 2407, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"hover-contents\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"product-details.html\" class=\"hover-image\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<img src=\"image/products/product-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2569, "\"", 2575, 0);
            EndWriteAttribute();
            WriteLiteral(@">
													</a>
													<div class=""hover-btns"">
														<a href=""cart.html"" class=""single-btn"">
															<i class=""fas fa-shopping-basket""></i>
														</a>
														<a href=""wishlist.html"" class=""single-btn"">
															<i class=""fas fa-heart""></i>
														</a>
														<a href=""compare.html"" class=""single-btn"">
															<i class=""fas fa-random""></i>
														</a>
														<a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
															class=""single-btn"">
															<i class=""fas fa-eye""></i>
														</a>
													</div>
												</div>
											</div>
											<div class=""price-block"">
												<span class=""price"">£51.20</span>
												<del class=""price-old"">£51.20</del>
												<span class=""price-discount"">20%</span>
											</div>
										</div>
									</div>
								</div>
								<div class=""single-slide"">
									<div class=""product-card"">
										<div class=""product-header"">
											<s");
            WriteLiteral(@"pan class=""author"">
												Jpple
											</span>
											<h3><a href=""product-details.html"">Turn Your BOOK Into High Machine</a></h3>
										</div>
										<div class=""product-card--body"">
											<div class=""card-image"">
												<img src=""image/products/product-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3892, "\"", 3898, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"hover-contents\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"product-details.html\" class=\"hover-image\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<img src=\"image/products/product-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4060, "\"", 4066, 0);
            EndWriteAttribute();
            WriteLiteral(@">
													</a>
													<div class=""hover-btns"">
														<a href=""cart.html"" class=""single-btn"">
															<i class=""fas fa-shopping-basket""></i>
														</a>
														<a href=""wishlist.html"" class=""single-btn"">
															<i class=""fas fa-heart""></i>
														</a>
														<a href=""compare.html"" class=""single-btn"">
															<i class=""fas fa-random""></i>
														</a>
														<a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
															class=""single-btn"">
															<i class=""fas fa-eye""></i>
														</a>
													</div>
												</div>
											</div>
											<div class=""price-block"">
												<span class=""price"">£51.20</span>
												<del class=""price-old"">£51.20</del>
												<span class=""price-discount"">20%</span>
											</div>
										</div>
									</div>
								</div>
								<div class=""single-slide"">
									<div class=""product-card"">
										<div class=""product-header"">
											<s");
            WriteLiteral(@"pan class=""author"">
												Wpple
											</span>
											<h3><a href=""product-details.html"">3 Ways Create Better BOOK With</a></h3>
										</div>
										<div class=""product-card--body"">
											<div class=""card-image"">
												<img src=""image/products/product-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5381, "\"", 5387, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"hover-contents\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"product-details.html\" class=\"hover-image\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<img src=\"image/products/product-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 5549, "\"", 5555, 0);
            EndWriteAttribute();
            WriteLiteral(@">
													</a>
													<div class=""hover-btns"">
														<a href=""cart.html"" class=""single-btn"">
															<i class=""fas fa-shopping-basket""></i>
														</a>
														<a href=""wishlist.html"" class=""single-btn"">
															<i class=""fas fa-heart""></i>
														</a>
														<a href=""compare.html"" class=""single-btn"">
															<i class=""fas fa-random""></i>
														</a>
														<a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
															class=""single-btn"">
															<i class=""fas fa-eye""></i>
														</a>
													</div>
												</div>
											</div>
											<div class=""price-block"">
												<span class=""price"">£51.20</span>
												<del class=""price-old"">£51.20</del>
												<span class=""price-discount"">20%</span>
											</div>
										</div>
									</div>
								</div>
								<div class=""single-slide"">
									<div class=""product-card"">
										<div class=""product-header"">
											<s");
            WriteLiteral(@"pan class=""author"">
												Epple
											</span>
											<h3><a href=""product-details.html"">What You Can Learn From Bill Gates</a>
											</h3>
										</div>
										<div class=""product-card--body"">
											<div class=""card-image"">
												<img src=""image/products/product-5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6886, "\"", 6892, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"hover-contents\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"product-details.html\" class=\"hover-image\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<img src=\"image/products/product-4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 7054, "\"", 7060, 0);
            EndWriteAttribute();
            WriteLiteral(@">
													</a>
													<div class=""hover-btns"">
														<a href=""cart.html"" class=""single-btn"">
															<i class=""fas fa-shopping-basket""></i>
														</a>
														<a href=""wishlist.html"" class=""single-btn"">
															<i class=""fas fa-heart""></i>
														</a>
														<a href=""compare.html"" class=""single-btn"">
															<i class=""fas fa-random""></i>
														</a>
														<a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
															class=""single-btn"">
															<i class=""fas fa-eye""></i>
														</a>
													</div>
												</div>
											</div>
											<div class=""price-block"">
												<span class=""price"">£51.20</span>
												<del class=""price-old"">£51.20</del>
												<span class=""price-discount"">20%</span>
											</div>
										</div>
									</div>
								</div>
								<div class=""single-slide"">
									<div class=""product-card"">
										<div class=""product-header"">
											<s");
            WriteLiteral(@"pan class=""author"">
												Hpple
											</span>
											<h3><a href=""product-details.html"">Simple Things You To Save BOOK</a></h3>
										</div>
										<div class=""product-card--body"">
											<div class=""card-image"">
												<img src=""image/products/product-6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8375, "\"", 8381, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"hover-contents\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"product-details.html\" class=\"hover-image\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<img src=\"image/products/product-4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 8543, "\"", 8549, 0);
            EndWriteAttribute();
            WriteLiteral(@">
													</a>
													<div class=""hover-btns"">
														<a href=""cart.html"" class=""single-btn"">
															<i class=""fas fa-shopping-basket""></i>
														</a>
														<a href=""wishlist.html"" class=""single-btn"">
															<i class=""fas fa-heart""></i>
														</a>
														<a href=""compare.html"" class=""single-btn"">
															<i class=""fas fa-random""></i>
														</a>
														<a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
															class=""single-btn"">
															<i class=""fas fa-eye""></i>
														</a>
													</div>
												</div>
											</div>
											<div class=""price-block"">
												<span class=""price"">£51.20</span>
												<del class=""price-old"">£51.20</del>
												<span class=""price-discount"">20%</span>
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
						<!-- Cart Summary -->
						<div class=""col-lg-6 col-12 d-flex"">
							<div class=""cart-s");
            WriteLiteral("ummary\">\n                                <div class=\"cart-summary-wrap\">\n                                    <h4><span>Cart Summary</span></h4>\n");
#nullable restore
#line 265 "C:\Users\nijatma\Desktop\P224_ASP_30-03-2022_Basket-main\Pustok\Pustok\Views\Basket\Index.cshtml"
                                       double total = 0;

                                        foreach (BasketVM basketVM in Model)
                                        {
                                            total += (basketVM.Count * basketVM.Price);
                                        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Sub Total <span class=\"text-primary\">$");
#nullable restore
#line 271 "C:\Users\nijatma\Desktop\P224_ASP_30-03-2022_Basket-main\Pustok\Pustok\Views\Basket\Index.cshtml"
                                                                        Write(total.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\n                                    <p>Shipping Cost <span class=\"text-primary\">$00.00</span></p>\n                                    <h2>Grand Total <span class=\"text-primary\">$");
#nullable restore
#line 273 "C:\Users\nijatma\Desktop\P224_ASP_30-03-2022_Basket-main\Pustok\Pustok\Views\Basket\Index.cshtml"
                                                                           Write(total.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h2>
                                </div>
								<div class=""cart-summary-button"">
									<a href=""checkout.html"" class=""checkout-btn c-btn btn--primary"">Checkout</a>
									<button class=""update-btn c-btn btn-outlined"">Update Cart</button>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
