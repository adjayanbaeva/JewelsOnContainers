#pragma checksum "C:\Users\Ainur Dzhaianbaeva\Documents\Kal Academy\JewelsOnContainers\TokenServiceApi\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09ea419e8a983f9ebcd2dc9d8952b27e300cd8be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Users\Ainur Dzhaianbaeva\Documents\Kal Academy\JewelsOnContainers\TokenServiceApi\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Ainur Dzhaianbaeva\Documents\Kal Academy\JewelsOnContainers\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi;

#line default
#line hidden
#line 3 "C:\Users\Ainur Dzhaianbaeva\Documents\Kal Academy\JewelsOnContainers\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi.Models;

#line default
#line hidden
#line 4 "C:\Users\Ainur Dzhaianbaeva\Documents\Kal Academy\JewelsOnContainers\TokenServiceApi\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
#line 5 "C:\Users\Ainur Dzhaianbaeva\Documents\Kal Academy\JewelsOnContainers\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi.Models.AccountViewModels;

#line default
#line hidden
#line 6 "C:\Users\Ainur Dzhaianbaeva\Documents\Kal Academy\JewelsOnContainers\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09ea419e8a983f9ebcd2dc9d8952b27e300cd8be", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ebd87ea481c1599b146960a74ab2e52576419d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityServer4.Quickstart.UI.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ainur Dzhaianbaeva\Documents\Kal Academy\JewelsOnContainers\TokenServiceApi\Views\Shared\Error.cshtml"
  
    var error = Model?.Error?.Error;
    var request_id = Model?.Error?.RequestId;

#line default
#line hidden
            BeginContext(145, 243, true);
            WriteLiteral("\r\n<div class=\"error-page\">\r\n    <div class=\"page-header\">\r\n        <h1>Error</h1>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <div class=\"alert alert-danger\">\r\n                Sorry, there was an error\r\n\r\n");
            EndContext();
#line 17 "C:\Users\Ainur Dzhaianbaeva\Documents\Kal Academy\JewelsOnContainers\TokenServiceApi\Views\Shared\Error.cshtml"
                 if (error != null)
                {

#line default
#line hidden
            BeginContext(444, 90, true);
            WriteLiteral("                    <strong>\r\n                        <em>\r\n                            : ");
            EndContext();
            BeginContext(535, 5, false);
#line 21 "C:\Users\Ainur Dzhaianbaeva\Documents\Kal Academy\JewelsOnContainers\TokenServiceApi\Views\Shared\Error.cshtml"
                         Write(error);

#line default
#line hidden
            EndContext();
            BeginContext(540, 64, true);
            WriteLiteral("\r\n                        </em>\r\n                    </strong>\r\n");
            EndContext();
#line 24 "C:\Users\Ainur Dzhaianbaeva\Documents\Kal Academy\JewelsOnContainers\TokenServiceApi\Views\Shared\Error.cshtml"
                }

#line default
#line hidden
            BeginContext(623, 22, true);
            WriteLiteral("            </div>\r\n\r\n");
            EndContext();
#line 27 "C:\Users\Ainur Dzhaianbaeva\Documents\Kal Academy\JewelsOnContainers\TokenServiceApi\Views\Shared\Error.cshtml"
             if (request_id != null)
            {

#line default
#line hidden
            BeginContext(698, 52, true);
            WriteLiteral("                <div class=\"request-id\">Request Id: ");
            EndContext();
            BeginContext(751, 10, false);
#line 29 "C:\Users\Ainur Dzhaianbaeva\Documents\Kal Academy\JewelsOnContainers\TokenServiceApi\Views\Shared\Error.cshtml"
                                               Write(request_id);

#line default
#line hidden
            EndContext();
            BeginContext(761, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 30 "C:\Users\Ainur Dzhaianbaeva\Documents\Kal Academy\JewelsOnContainers\TokenServiceApi\Views\Shared\Error.cshtml"
            }

#line default
#line hidden
            BeginContext(784, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityServer4.Quickstart.UI.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591