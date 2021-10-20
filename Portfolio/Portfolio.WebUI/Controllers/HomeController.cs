using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Portfolio.Application.Modules.ContactModules.ContactUser;
using Portfolio.WebUI.Appcode.Application.IndexMolus;
using Portfolio.WebUI.Appcode.Extension;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using Portfolio.WebUI.Model.Entity.Membership;
using Portfolio.WebUI.Model.FormModels;
using Riode.WebUI.Appcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    [AllowAnonymous]

    public class HomeController : Controller
    {

        readonly IMediator db;
        readonly UserManager<PortUser> userManager;
        readonly SignInManager<PortUser> signInManager;
        readonly IConfiguration configuration;
        readonly PortfolioDbContext vv;



        public HomeController(IMediator db, UserManager<PortUser> userManager, SignInManager<PortUser> signInManager, IConfiguration configuration, PortfolioDbContext vv)
        {
            this.db = db;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.configuration = configuration;
            this.vv = vv;


        }
        //+
        public async Task<IActionResult> Index(IndexList query)
        {
            var respons = await db.Send(query);
            return View(respons);
        }



        //+
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //+
        public async Task<IActionResult> Contact(ContactCreateCommand query)
        {

            var respons = await db.Send(query);
            return Json(respons);
        }


        public IActionResult Signin()
        {
            //Eger giris edibse routda myaccount/sing yazanda o seyfe acilmasin homa tulaasin
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "Home");

            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signin(LoginFormModel user)
        {


            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "Home");

            }

            if (ModelState.IsValid)
            {

                PortUser founderUser = null;

                if (user.UserName.IsEmail())
                {
                    founderUser = await userManager.FindByEmailAsync(user.UserName); //Eger Isdifadeci email gore giris edibse onu yoxlayir 
                }
                else
                {
                    founderUser = await userManager.FindByNameAsync(user.UserName); //YOX EGER USERNAME GORE GIRIBSE ONU AXTARIS EDIR.

                }

                if (founderUser == null) //Eger login ola bilmirse gonderir view gonderir yeni isdifadeci tapilmiyanda
                {
                    ViewBag.Ms = "Isdifadeci sifresi ve parol sefdir gagas";
                    return View(user);

                }

                if (founderUser.EmailConfirmed == false)
                {
                    ViewBag.Ms = "Zehmet olmasa Emailinizi testiq edin....";
                    return View(user);
                }

                //Eger database isdifadeci user deyilse onda gire bilmez.

                if (!await userManager.IsInRoleAsync(founderUser, "User"))
                {
                    ViewBag.Ms = "Isdifadeci sifresi ve parol sefdir gagas";
                    return View(user);
                }




                if (founderUser.Activates == false)
                {
                    ViewBag.ms = "Siz admin terefinden banlanmisiz";
                    return View(user);
                }

                if (founderUser.Activates == true)
                {
                    var sRuselt = await signInManager.PasswordSignInAsync(founderUser, user.Password, true, true); //Burda giwi edirik.

                    if (sRuselt.Succeeded != true) // Eger giriw zamani ugurlu deyilse yeni gire bilmirse 
                    {
                        ViewBag.Ms = "Isdifadeci sifresi ve parol sefdir gagas";
                        return View(user);

                    }
                    var redirectUrl = Request.Query["ReturnUrl"];

                    if (!string.IsNullOrWhiteSpace(redirectUrl))
                    {
                        return Redirect(redirectUrl);
                    }

                    return RedirectToAction("Index", "Home");

                }
            }

            ViewBag.Ms = "Melumatlari doldur gagas";
            return View(user);











            //PortUser foundedUser = null;



            ////Isdifadecinin user ve ya email ile giriw etdiyni yoxlyuruq;
            //if (user.UserName.IsEmail())
            //{
            //    foundedUser = await userManager.FindByEmailAsync(user.UserName);
            //}
            //else
            //{
            //    foundedUser = await userManager.FindByNameAsync(user.UserName);

            //}

            //if (foundedUser==null)
            //{
            //    ViewBag.ms = "Isdifadeci sifresi ve Parolu sefdi";
            //    goto end;
            //}

            //var signinResult = await signInManager.PasswordSignInAsync(foundedUser, user.Password, true, true);




            //if (!signinResult.Succeeded)
            //{
            //    ViewBag.ms = "Isdifadeci sifresi ve Parolu sefdi";
            //    goto end;
            //}

            //var callbackurl = Request.Query["ReturnUrl"];

            //if (!string.IsNullOrWhiteSpace(callbackurl))
            //{
            //    return Redirect(callbackurl);
            //}

            //return RedirectToAction("Blog", "Details");

            //end:
            //return View();
        }


        public IActionResult Register()
        {
            //Eger giris edibse routda myaccount/sing yazanda o seyfe acilmasin homa tulaasin
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "Home");

            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormModel register)
        {

            //Eger giris edibse routda myaccount/sing yazanda o seyfe acilmasin homa tulaasin
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "Home");

            }
            if (!ModelState.IsValid)
            {
                return View();
            }

            //Yeni user yaradiriq.
            PortUser user = new PortUser
            {

                UserName = register.UserName,
                Email = register.Email,
                Activates = true
            };



            string token = $"subscribetoken-{register.UserName}-{DateTime.Now:yyyyMMddHHmmss}"; // token yeni id goturuk

            token = token.Encrypt("");

            string path = $"{Request.Scheme}://{Request.Host}/subscribe-confirmm?token={token}"; // path duzeldirik



            var mailSended = configuration.SendEmail(user.Email, "Riode seyfesi gagas", $"Zehmet olmasa <a href={path}>Link</a> vasitesile abuneliyi tamamlayin");


            var person = await userManager.FindByNameAsync(user.UserName);


            if (person == null)
            {
                //Burda biz userManager vasitesile user ve RegistirVM passwword yoxluyuruq.(yaradiriq)
                var identityRuselt = await userManager.CreateAsync(user, register.Password);


                //Startupda yazdigimiz qanunlara uymursa Configure<IdentityOptions> onda error qaytariq summary ile.;
                if (!identityRuselt.Succeeded)
                {
                    foreach (var error in identityRuselt.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }

                //Yratdigimiz user ilk yarananda user rolu verik.

                await userManager.AddToRoleAsync(user, "User");

                return RedirectToAction("index", "Home");

            }


            if (person.UserName != null)
            {
                ViewBag.ms = "Bu username evvelceden qeydiyyatdan kecib";

                return View(register);
            }
            return null;

        }

        [HttpGet]
        [Route("subscribe-confirmm")]
        public IActionResult SubscibeConfirm(string token)
        {


            token = token.Decrypte("");

            Match match = Regex.Match(token, @"subscribetoken-(?<id>[a-zA-Z0-9]*)(.*)-(?<timeStampt>\d{14})");

            if (match.Success)
            {
                string id = match.Groups["id"].Value;
                string executeTimeStamp = match.Groups["executeTimeStamp"].Value;

                var subsc = vv.Users.FirstOrDefault(s => s.UserName == id);

                if (subsc == null)
                {
                    ViewBag.ms = Tuple.Create(true, "Token xetasi");
                    goto end;
                }
                if (subsc.EmailConfirmed == true)
                {
                    ViewBag.ms = Tuple.Create(true, "Artiq tesdiq edildi");
                    goto end;
                }
                subsc.EmailConfirmed = true;
                vv.SaveChanges();

                ViewBag.ms = Tuple.Create(false, "Abuneliyiniz tesdiq edildi");

            }
            end:
            return View();
        }
    }
    
}

