#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a639cf3afddb2de78f32f5ebfbaa62df91f15a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_Inventory), @"mvc.1.0.view", @"/Views/Sales/Inventory.cshtml")]
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
#line 1 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a639cf3afddb2de78f32f5ebfbaa62df91f15a4", @"/Views/Sales/Inventory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_Inventory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable< SCASA.Models.ModelClasses.ProductsDisplaySales>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SApp/assets/images/products/shape1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Shape"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SApp/assets/images/products/shape2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Products"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SApp/assets/images/shape1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SApp/assets/images/shape2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
  
    Layout = "~/Views/Shared/_SalesMaster.cshtml";
    System.Globalization.CultureInfo Indian = new System.Globalization.CultureInfo("hi-IN");
    var psiz = ViewBag.ps;
    var pnum = ViewBag.pn;
    var total = ViewBag.totProds;
    var cid = ViewBag.cid;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"products-area ptb-100\">\r\n");
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3\">\r\n                <div class=\"sorting-menu\">\r\n                    <ul class=\"justify-content-center\">\r\n                       \r\n");
#nullable restore
#line 19 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                         foreach (var c in ViewBag.cats)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                             if (ViewBag.cid == c.CategoryId)
                            {
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"filter active\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a639cf3afddb2de78f32f5ebfbaa62df91f15a47031", async() => {
                WriteLiteral("\r\n                                <div class=\"products-thumb\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a639cf3afddb2de78f32f5ebfbaa62df91f15a47388", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a639cf3afddb2de78f32f5ebfbaa62df91f15a48597", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <i");
                BeginWriteAttribute("class", " class=\"", 1311, "\"", 1335, 1);
#nullable restore
#line 29 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
WriteAttributeValue("", 1319, c.CategoryImage, 1319, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                                    <span>");
#nullable restore
#line 30 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                                     Write(c.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 962, "~/Sales/Inventory?catid=", 962, 24, true);
#nullable restore
#line 25 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
AddHtmlAttributeValue("", 986, c.CategoryId, 986, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>                               \r\n");
#nullable restore
#line 34 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                            }
                            else
                            {                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"filter\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a639cf3afddb2de78f32f5ebfbaa62df91f15a412269", async() => {
                WriteLiteral("\r\n                            <div class=\"products-thumb\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a639cf3afddb2de78f32f5ebfbaa62df91f15a412619", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a639cf3afddb2de78f32f5ebfbaa62df91f15a413825", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <i");
                BeginWriteAttribute("class", " class=\"", 2080, "\"", 2104, 1);
#nullable restore
#line 42 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
WriteAttributeValue("", 2088, c.CategoryImage, 2088, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                                <span>");
#nullable restore
#line 43 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                                 Write(c.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1747, "~/Sales/Inventory?catid=", 1747, 24, true);
#nullable restore
#line 38 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
AddHtmlAttributeValue("", 1771, c.CategoryId, 1771, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>                               \r\n");
#nullable restore
#line 47 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-9\">\r\n                <div id=\"prods\" class=\"row justify-content-center\">\r\n");
#nullable restore
#line 54 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                     if (Model != null)
                    {
                                foreach (var p in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-sm-6 col-lg-4 mix center-table\"");
            BeginWriteAttribute("id", " id=\"", 2772, "\"", 2796, 2);
            WriteAttributeValue("", 2777, "item_", 2777, 5, true);
#nullable restore
#line 58 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
WriteAttributeValue("", 2782, p.InventroyId, 2782, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"products-item\">\r\n                                            <div class=\"top\">\r\n");
#nullable restore
#line 61 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                                                  
                                                    string[] allImges = p.MainImages.Split(",");
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a639cf3afddb2de78f32f5ebfbaa62df91f15a419127", async() => {
                WriteLiteral("\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a639cf3afddb2de78f32f5ebfbaa62df91f15a419435", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3312, "~/ProductImages/", 3312, 16, true);
#nullable restore
#line 65 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
AddHtmlAttributeValue("", 3328, allImges[0], 3328, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3190, "~/Sales/ProductDetails?id=", 3190, 26, true);
#nullable restore
#line 64 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
AddHtmlAttributeValue("", 3216, p.InventroyId, 3216, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                <div class=\"inner\">\r\n                                                    <h3>\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a639cf3afddb2de78f32f5ebfbaa62df91f15a422662", async() => {
                WriteLiteral("\r\n                                                            ");
#nullable restore
#line 70 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                                                       Write(p.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3607, "~/Sales/ProductDetails?id=", 3607, 26, true);
#nullable restore
#line 69 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
AddHtmlAttributeValue("", 3633, p.InventroyId, 3633, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </h3>\r\n                                                    <span>\r\n");
#nullable restore
#line 74 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                                                          
                                                                     string mrp = String.Format(Indian, "{0:N}", p.MRP);
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        Rs. ");
#nullable restore
#line 77 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                                                       Write(p.MRP);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </span>\r\n                                                    <span>\r\n                                                        Available Qty ");
#nullable restore
#line 80 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                                                                 Write(p.AvaliableQtyW);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (W),  ");
#nullable restore
#line 80 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                                                                                        Write(p.AvailableQtyS);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (S),");
#nullable restore
#line 80 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                                                                                                             Write(p.AvaliableQtyR);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" (R)
                                                    </span>
                                                </div>
                                            </div>
                                                                                   </div>
                                    </div>
");
#nullable restore
#line 86 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                        }
                                
                    }                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"text-center\" > \r\n                    <a class=\"common-btn\" href=\"javascript:void(0)\" id=\"moreprod\" onclick=\"MoreLoad()\">\r\n                        Load More Products\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a639cf3afddb2de78f32f5ebfbaa62df91f15a427457", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a639cf3afddb2de78f32f5ebfbaa62df91f15a428595", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    var noOfProdsLoaded = ");
#nullable restore
#line 103 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                     Write(pnum);

#line default
#line hidden
#nullable disable
            WriteLiteral("*");
#nullable restore
#line 103 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                           Write(psiz);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var pnu =");
#nullable restore
#line 104 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
        Write(pnum);

#line default
#line hidden
#nullable disable
            WriteLiteral("+1;\r\n    var nps =");
#nullable restore
#line 105 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
        Write(psiz);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    //var hor\r\n    $(document).ready(function () {\r\n        if (noOfProdsLoaded >=  ");
#nullable restore
#line 108 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                           Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        {\r\n            $(\"#moreprod\").hide();\r\n        }\r\n        //$(document).scrollTop(");
#nullable restore
#line 112 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                           Write(ViewBag.top);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n    });\r\n");
            WriteLiteral("    function MoreLoad() {\r\n\r\n        $.ajax({\r\n            url: GlobalUrl + \"Sales/LoadMoreInventory\",\r\n            type: \'post\',\r\n            data: {\r\n                \'catid\': ");
#nullable restore
#line 124 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                    Write(cid);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                \'pageNumber\' : pnu,\r\n                \'pageSize\': ");
#nullable restore
#line 126 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                       Write(psiz);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            }, success: function (response) {
                if (response.re != null) {
                    var i = 0;
                    for (; i < response.re.length; i++) {

                        var abc = response.re[i].mainImages;

                        var join = `<div id=""next"" class=""col-sm-6 col-lg-4 mix center-table"" id=""item_` + response.re[i].inventroyId+`"">
<div class=""products-item"">
                                            <div class=""top"">

                                                <a href=""ProductDetails?id=`+ response.re[i].inventroyId +`"" target=""_blank"">
                                                    <img src=""../ProductImages/`+abc+`"" alt=""Products"" />
                                                </a>
                                                <div class=""inner"">
                                                    <h3>
                                                        <a href=""ProductDetails?id=`+ response.re[i].inventroyId +`"" target=""");
            WriteLiteral(@"_blank"">
                                                            `+ response.re[i].title+`
                                                        </a>
                                                    </h3>
                                                    <span>
                                                        Rs. `+ response.re[i].mrp+`
                                                    </span>
                                                    <span>
                                                        Available Qty `+ response.re[i].avaliableQtyW + '(W),' + response.re[i].availableQtyS + '(S),' + response.re[i].avaliableQtyR + '(R)' +`
                                                    </span>
                                                </div>
                                            </div>
                                        </div>
</div>`

                        $('#prods').append(join);
                       nps++;
                    }
             ");
            WriteLiteral("       noOfProdsLoaded +=");
#nullable restore
#line 161 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                                 Write(psiz);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    if (noOfProdsLoaded >=  ");
#nullable restore
#line 162 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\Inventory.cshtml"
                                       Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                    {\r\n                        $(\"#moreprod\").hide();\r\n                    }\r\n                    pnu++;\r\n                    //$(\"#nSize\").val(nps);\r\n                }\r\n            }\r\n        })\r\n    }    \r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable< SCASA.Models.ModelClasses.ProductsDisplaySales>> Html { get; private set; }
    }
}
#pragma warning restore 1591
