#pragma checksum "C:\CIDM 3312\MidTerm\MidTermTwoMakeup\Views\Math\ShowCalculationResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8d024a105e97bf5015339b1148a2fa90f80c04e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Math_ShowCalculationResults), @"mvc.1.0.view", @"/Views/Math/ShowCalculationResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Math/ShowCalculationResults.cshtml", typeof(AspNetCore.Views_Math_ShowCalculationResults))]
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
#line 1 "C:\CIDM 3312\MidTerm\MidTermTwoMakeup\Views\_ViewImports.cshtml"
using MidTermTwoMakeup;

#line default
#line hidden
#line 2 "C:\CIDM 3312\MidTerm\MidTermTwoMakeup\Views\_ViewImports.cshtml"
using MidTermTwoMakeup.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8d024a105e97bf5015339b1148a2fa90f80c04e", @"/Views/Math/ShowCalculationResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cbb743c0015b76fa49ad64fd9ba8b99bd04780c", @"/Views/_ViewImports.cshtml")]
    public class Views_Math_ShowCalculationResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MidTermTwoMakeup.Models.MathOperation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 16, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(63, 19, false);
#line 10 "C:\CIDM 3312\MidTerm\MidTermTwoMakeup\Views\Math\ShowCalculationResults.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(82, 723, true);
            WriteLiteral(@"
  
<div class=""col-sm-8 text-left""> 
    <h1>Welcome</h1>
    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
    <hr>
    <h3>Test</h3>
    <p>Lorem ipsum...</p>
    <div class=""well"">
        The result of ");
            EndContext();
            BeginContext(806, 17, false);
#line 19 "C:\CIDM 3312\MidTerm\MidTermTwoMakeup\Views\Math\ShowCalculationResults.cshtml"
                 Write(Model.LeftOperand);

#line default
#line hidden
            EndContext();
            BeginContext(823, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(825, 14, false);
#line 19 "C:\CIDM 3312\MidTerm\MidTermTwoMakeup\Views\Math\ShowCalculationResults.cshtml"
                                    Write(Model.Operator);

#line default
#line hidden
            EndContext();
            BeginContext(839, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(841, 18, false);
#line 19 "C:\CIDM 3312\MidTerm\MidTermTwoMakeup\Views\Math\ShowCalculationResults.cshtml"
                                                    Write(Model.RightOperand);

#line default
#line hidden
            EndContext();
            BeginContext(859, 8, true);
            WriteLiteral(" equals ");
            EndContext();
            BeginContext(868, 12, false);
#line 19 "C:\CIDM 3312\MidTerm\MidTermTwoMakeup\Views\Math\ShowCalculationResults.cshtml"
                                                                               Write(Model.Result);

#line default
#line hidden
            EndContext();
            BeginContext(880, 126, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<footer class=\"container-fluid text-center\">\r\n  <p>Thank you for using Math Operator!</p>\r\n</footer>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MidTermTwoMakeup.Models.MathOperation> Html { get; private set; }
    }
}
#pragma warning restore 1591