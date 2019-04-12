using smotrish.Models;
using smotrish.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace smotrish.Controllers
{
    public class ChannelsController : Controller
    {
        //ChannelContext context = new ChannelContext();
        ChannelsRepository repository = new ChannelsRepository();
        // GET: Channels
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost()]
        public ActionResult Create(Channel channel)
        {
            if (!ModelState.IsValid) return View(channel);

            repository.Add(channel);
            repository.SaveChanges();
            return RedirectToAction("Index"); 
        }
    }
}