using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VGC;
using VGC.Models;

namespace VGC.Controllers
{
    public class TopicsController : Controller
    {
        private readonly ApplicationDbContext db;

        public TopicsController(ApplicationDbContext db)
        {
            this.db = db;
        }
        //[Authorize]
        public IActionResult Topics()
        {
            return View();
        }
        public IActionResult List() //listing topics
        {
            var topics = db.Topics.ToList();
            return View(topics);
        }

        public IActionResult TopicContent(int? TopicId)
        {
            var topic = db.Topics.Find(TopicId);
            
            return View(topic.TopicInfo);
        }


        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }
        //POST -CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Topics obj)
        {
            obj = new Topics() { TopicId = "121561", TopicDescription = "description", TopicName = "Tops" };
            if (ModelState.IsValid)
            {
                db.Topics.Add(obj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //GET - Edit
        public IActionResult Edit(int? TopicId)
        {
            if (TopicId == null || TopicId == 0)
            {
                return NotFound();
            }
            var obj = db.Topics.Find(TopicId);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Topics obj)
        {
            if (ModelState.IsValid)
            {
                db.Topics.Update(obj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        // GET - Delete
        public IActionResult Delete(int? TopicId)
        {
            if (TopicId == null || TopicId == 0)
            {
                return NotFound();
            }
            var obj = db.Topics.Find(TopicId);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST - Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Topics obj)
        {
            if (ModelState.IsValid)
            {
                db.Topics.Update(obj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
