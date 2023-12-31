﻿using Dolunay_Villas.Areas.RealEstateManagement.Models.RoomFeatures;
using Dolunay_Villas.Models;
using Entity.Dtos.RealEstateManagement.Rooms;
using Entity.Enums;
using Entity.RequestParameters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contract.RealEstateManagement;

namespace Dolunay_Villas.Areas.RealEstateManagement.Controllers
{
    [Area("RealEstateManagement")]
    [Authorize(Policy = nameof(Powers.CanManageRealEstateRooms))]
    public class RoomsController : Controller
    {
        private readonly IRealEstateRoomsService _service;

        public RoomsController(IRealEstateRoomsService service)
        {
            _service = service;
        }

        public IActionResult Index([FromQuery] PageRequestParameters? r)
        {

            if (r == null)
            {
                r = new()
                {
                    PageNumber = 1,
                    PageSize = 10
                };
            }
            var entity = _service.GetWithDetail(r)?.ToList() ?? new();
            var pagination = new Pagination
            {
                CurrentPage = r.PageNumber,
                ItemsPerPage = r.PageSize,
                TotalItems = _service.GetList()?.Count() ?? 0
            };
            var model = new RealEstateRoomsListViewModel
            {
                Entities = entity,
                Pagination = pagination
            };
            return View("Index", model);
        }
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] RoomsDtoForInsertions dtoForInsertion)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dtoForInsertion.CreatedByUser = User.Identity?.Name ?? "";
                    dtoForInsertion.UpdatedByUser = User.Identity?.Name ?? "";
                    _service.CreateWithDto(dtoForInsertion);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.InnerException?.Message ?? e.Message);
                }
            }
            return View("Create", dtoForInsertion);
        }
        public IActionResult Update([FromRoute(Name = "id")] int id)
        {
            var entity = _service.GetEntity<RoomsDtoForUpdate>(id);
            return View("Update", entity);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([FromForm] RoomsDtoForUpdate dtoForUpdate)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dtoForUpdate.UpdatedByUser = User.Identity?.Name ?? "";
                    _service.Update(dtoForUpdate);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.InnerException?.Message ?? e.Message);
                }
            }
            return View("Update", dtoForUpdate);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromForm(Name = "Entity")] int id)
        {
            try
            {
                _service.Delete(id);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
