#pragma checksum "C:\Users\snyp_\Documents\GitHub\CDMSystem\CDMSystem\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "274afaedce347bf7e66010c2f0cd2b807f301b0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\snyp_\Documents\GitHub\CDMSystem\CDMSystem\Views\_ViewImports.cshtml"
using CDMSystem;

#line default
#line hidden
#line 2 "C:\Users\snyp_\Documents\GitHub\CDMSystem\CDMSystem\Views\_ViewImports.cshtml"
using CDMSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"274afaedce347bf7e66010c2f0cd2b807f301b0b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c65b9560cbf687c2ccac42fc081d1b2d3e162fb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\snyp_\Documents\GitHub\CDMSystem\CDMSystem\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 94, true);
            WriteLiteral("\r\n    <div id=\"myCarousel\" class=\"carousel slide\" data-ride=\"carousel\" data-interval=\"6000\">\r\n");
            EndContext();
            BeginContext(165, 407, true);
            WriteLiteral(@"        <label></label>
        <input type=""text"" id=""Nome"" />

        <label></label>
        <input type=""text"" id=""Level"" />

        <label></label>
        <select></select>

        <label></label>
        <select></select>

        <label></label>
        <select></select>

        <label></label>
        <select></select>

        <label></label>
        <select></select>

");
            EndContext();
            BeginContext(599, 640, true);
            WriteLiteral(@"        <label>HP</label>
        <input type=""text"" id=""Hp"" />

        <label>MP</label>
        <input type=""text"" id=""Mp"" />

        <label>DMGF</label>
        <input type=""text"" id=""Dmgf"" />

        <label>DMGM</label>
        <input type=""text"" id=""Dmgm"" />

        <label>DEF</label>
        <input type=""text"" id=""Def"" />

        <label>FUR</label>
        <input type=""text"" id=""Fur"" />

        <label>DET</label>
        <input type=""text"" id=""Det"" />

        <label>CRIT</label>
        <input type=""text"" id=""Crit"" />

        <label>ACR</label>
        <input type=""text"" id=""Acr"" />
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
