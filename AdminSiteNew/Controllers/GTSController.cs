﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminSiteNew.Database;
using AdminSiteNew.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AdminSiteNew.Controllers
{
    [Authorize(Policy = "Moderator")]
    public class GTSController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var model = new GTSListModel
            {
                GTS = await DbGTS.GetOpenGTSTrades(),
                StartIndex = 0
            };
            return View(model);
        }

        public async Task<IActionResult> Closed()
        {
            var model = new GTSListModel()
            {
                GTS =  await DbGTS.GetClosedGTSTrades(),
                StartIndex = 0
            };
            return View(model);
        }

        public  async Task<IActionResult> Detail(string id)
        {
            int i;
            if (!int.TryParse(id, out i))
                i = 0;
            var model = await DbGTS.GetSingleGTSTrade(i);
            return View(model);
        }

        public async Task<IActionResult> Remove(string id)
        {
            int i;
            if (!int.TryParse(id, out i))
                return BadRequest();
            await DbGTS.DeleteGTS(i);
            return RedirectToAction("Index");
        }
    }
}
