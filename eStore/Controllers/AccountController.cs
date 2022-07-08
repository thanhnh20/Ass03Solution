using eStore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using eStore.Models;
using MyLibrary.Repository;
namespace eStore.Controllers
{
    //[Route("account")]
    public class AccountController : Controller
    {
        //[Route("")]
        //[Route("index")]
        //[Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("login")]
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            IMemberRepository memberRepository = new MemberRepository();
            var account = ReadJson.GetAccount();
            var memberAccount = memberRepository.GetMemberByAccount(username, password);
            if (username != null && password != null)
            {
                //System.Diagnostics.Debug.WriteLine(account.Email + "|" + account.Password);
                if (username.Equals(account.Email) && password.Equals(account.Password))
                {
                    var member = new Member
                    {
                        Email = account.Email,
                        Password = account.Password,
                    };
                    HttpContext.Session.SetString("ACCOUNT", JsonConvert.SerializeObject(member));                       
                    return RedirectToAction("Index", "Member");
                }else if(memberAccount != null)
                {
                    HttpContext.Session.SetString("ACCOUNT", JsonConvert.SerializeObject(memberAccount));
                    return RedirectToAction("Index", "RoleMember");
                }
                ViewBag.error = "Invalid Account";
                return View("Index");
            }
            else
            {
                
                ViewBag.error = "Please Enter your username and password";
                return View("Index");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("ACCOUNT");
            return RedirectToAction("Index");
        }
    }
}
