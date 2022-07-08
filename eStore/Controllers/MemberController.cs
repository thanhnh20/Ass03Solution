using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MyLibrary.Models;
using Microsoft.AspNetCore.Http;
using MyLibrary.Repository;
using System;

namespace eStore.Controllers
{
    public class MemberController : Controller
    {
        public IMemberRepository memberRepository = new MemberRepository();
        public IActionResult Index()
        {
            //var member = JsonConvert.DeserializeObject<Member>(HttpContext.Session.GetString("username"));
            var listMember = memberRepository.GetListMember();
            return View(listMember);
        }

        public IActionResult Details(int? memberID)
        {
            if (memberID == null)
            {
                return NotFound();
            }
            var member = memberRepository.GetMemberByID(memberID.Value);
            return View(member);
        }
        public IActionResult Create()
        {
            var memberID = memberRepository.IncreaseID();
            ViewBag.MemberID = memberID;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Member member)
        {
            try
            {
                bool check = memberRepository.checkEmailDuplicated(member.Email);
                if (check)
                {
                    //System.Diagnostics.Debug.WriteLine(memberFound.Email +" | " + member.Email);
                    throw new Exception("Email is dupplicated");
                }   
                memberRepository.CreateMember(member);
                return RedirectToAction(nameof(Index));                                     
            }catch (Exception ex)
            {
                ViewBag.MemberID = member.MemberId;
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }
        public IActionResult Edit(int memberID)
        {
            if (memberID == null)
            {
                return NotFound();
            }
            var member = memberRepository.GetMemberByID(memberID);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        [HttpPost]
        public IActionResult Edit(Member member)
        {

            try
            {
                memberRepository.UpdateMember(member);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }


        public IActionResult Delete(int? memberID)
        {
            if(memberID == null)
            {
                return NotFound();
            }
            var member = memberRepository.GetMemberByID(memberID.Value);
            return View(member);
        }

        [HttpPost]
        public IActionResult Delete(int memberID)
        {
            try
            {
                memberRepository.DeleteMember(memberID);
                return RedirectToAction(nameof(Index));
            }catch(Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }
    }
}
