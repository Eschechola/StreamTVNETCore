#pragma checksum "C:\Users\Lucas\Desktop\StreamTV\StreamTV\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "671523a191d3910f8f769459b3534d6c6fe7da99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
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
#line 1 "C:\Users\Lucas\Desktop\StreamTV\StreamTV\Views\_ViewImports.cshtml"
using StreamTV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucas\Desktop\StreamTV\StreamTV\Views\_ViewImports.cshtml"
using StreamTV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"671523a191d3910f8f769459b3534d6c6fe7da99", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1b64baeb60e32038d1e05494b4c3dcf6e888a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lucas\Desktop\StreamTV\StreamTV\Views\Home\Profile.cshtml"
  
    ViewBag.Title = "Profile - StreamTV";
    ViewBag.Css = "dashboard.css";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""content"">
        <nav class=""left-nav"">
            <div class=""menu-itens"">
                <div class=""item-menu selected-menu"" onclick=""window.location.href ='/Home/Profile'"">
                    <img src=""/imgsSite/userIcon.png"" />
                    <center>
                        <p id=""TextUser"">SENAI</p>
                    </center>
                </div>
                <div class=""item-menu opacity-off"">

                </div>
                <div class=""item-menu opacity-off"">

                </div>
                <div class=""item-menu opacity-off"">

                </div>
                <div class=""item-menu"" onclick=""window.location.href ='/Home/Index'"">
                    <img src=""/imgsSite/userTelevision.png"" />
                    <center>
                        <p id=""TextUser"">Início</p>
                    </center>
                </div>
                <div class=""item-menu"" onclick=""window.location.href ='/Home/Docs'"">
               ");
            WriteLiteral(@"     <img src=""/imgsSite/userDocs.png"" />
                    <center>
                        <p id=""TextUser"">Docs</p>
                    </center>
                </div>
                <div class=""item-menu opacity-off"">

                </div>
                <div class=""item-menu opacity-off"">

                </div>
                <div class=""item-menu opacity-off"">

                </div>

                <div class=""item-menu"" onclick=""window.location.href ='/Home/Logout'"">
                    <img src=""/imgsSite/userLogout.png"" />
                    <center>
                        <p id=""TextUser"">Sair</p>
                    </center>
                </div>
            </div>
        </nav>
        
        <main class=""content-page"">
            <div class=""profile-page"">
                <div class=""profile-box-picture"">
                    <img src=""/imgsSite/userIcon.png"" />
                </div>

                <h2 id=""NameUser"">SENAI ""Ary Torres"" 1.12</h2>
");
            WriteLiteral(@"                <br />

                <table>
                    <tr>
                        <th>Dispositivos: </th>
                        <td>4</td>
                    </tr>
                    <tr>
                        <th>Responsável: </th>
                        <td>Fulano</td>
                    </tr>
                    <tr>
                        <th>Email: </th>
                        <td>senai@112.com.br</td>
                    </tr>
                    <tr>
                        <th>Telefone: </th>
                        <td>(11) 99999-9999</td>
                    </tr>
                    <tr>
                        <th>Cadastro em:</th>
                        <td>00/00/0000</td>
                    </tr>
                </table>

                <button id=""button-update"" onclick=""window.location.href='/Home/UpdateAccount'"">
                    Alterar dados
                </button>
            </div>

            <div class=""profile-page-televis");
            WriteLiteral(@"ion"">
                <div class=""profile-television-item"" onclick=""window.location.href='/Home/EditTelevision/0'"">
                    <div class=""profile-television-icon"">
                        <div class=""background-black-television"">
                            <center>
                                <p id=""TextEditTelevision"">Editar<br>▾</p>
                            </center>
                        </div>
                    </div>

                    <h2>Televisão 1</h2>
                </div>

                <div class=""profile-television-item"">
                    <div class=""profile-television-icon"" onclick=""window.location.href='/Home/EditTelevision/1'"">
                        <div class=""background-black-television"">
                            <center>
                                <p id=""TextEditTelevision"">Editar<br>▾</p>
                            </center>
                        </div>
                    </div>

                    <h2>Televisão 2</h2>
   ");
            WriteLiteral(@"             </div>

                <div class=""profile-television-item"">
                    <div class=""profile-television-icon"" onclick=""window.location.href='/Home/EditTelevision/2'"">
                        <div class=""background-black-television"">
                            <center>
                                <p id=""TextEditTelevision"">Editar<br>▾</p>
                            </center>
                        </div>
                    </div>

                    <h2>Televisão 3</h2>
                </div>

                <div class=""profile-television-item"">
                    <div class=""profile-television-icon"" onclick=""window.location.href='/Home/EditTelevision/3'"">
                        <div class=""background-black-television"">
                            <center>
                                <p id=""TextEditTelevision"">Editar<br>▾</p>
                            </center>
                        </div>
                    </div>

                    <h2>Telev");
            WriteLiteral(@"isão 4</h2>
                </div>

                <div class=""profile-television-item"">
                    <div class=""profile-television-icon"" onclick=""window.location.href='/Home/EditTelevision/4'"">
                        <div class=""background-black-television"">
                            <center>
                                <p id=""TextEditTelevision"">Editar<br>▾</p>
                            </center>
                        </div>
                    </div>

                    <h2>Televisão 5</h2>
                </div>

                <div class=""profile-television-item"">
                    <div class=""profile-television-icon"" onclick=""window.location.href='/Home/EditTelevision/5'"">
                        <div class=""background-black-television"">
                            <center>
                                <p id=""TextEditTelevision"">Editar<br>▾</p>
                            </center>
                        </div>
                    </div>

             ");
            WriteLiteral("       <h2>Televisão 6</h2>\r\n                </div>\r\n            </div>\r\n        </main>\r\n</div>");
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
