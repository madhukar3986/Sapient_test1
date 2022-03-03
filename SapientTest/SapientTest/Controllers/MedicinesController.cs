using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sapient_Core.Models;
using Sapient_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SapientTest_Web.Controllers
{
    [Route("api/Medicines")]
    [ApiController]
    public class MedicinesController : ControllerBase
    {
        private readonly IMedicineService _medicineService;
        public MedicinesController()
        { }
        public MedicinesController(IMedicineService medicineService) 
        {
            _medicineService = medicineService;
        }
        [HttpGet("GetMedicines")]
        [AllowAnonymous]
        public IActionResult GetMedicines()
        {
            Medicines med = null;
            try
            {
              med = _medicineService.GetmedicineByName();
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Exception found");
            }
            return Ok(med);
        }
        [HttpGet("GetAllMedicines")]
        [AllowAnonymous]
        public IActionResult GetAllMedicines()
        {
            List<Medicines> med = new List<Medicines>();
            try
            {
                med = _medicineService.GetAllMedicines().ToList();
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Exception found");
            }
            return Ok(med);
        }
        [HttpPut("EditMedicines")]
        [AllowAnonymous]
        public IActionResult EditMedicine()
        {
            _medicineService.EditMedicineInfo();
            return new JsonResult(null);
        }
        [HttpDelete("DeleteMedicines")]
        [AllowAnonymous]
        public IActionResult DeleteMedicine()
        {
            _medicineService.DeleteMedicineInfo();
            return new JsonResult(null);
        }
        [HttpPost("SaveMedicines")]
        [AllowAnonymous]
        public IActionResult SaveMedicine()
        {
            _medicineService.SaveMedicineInfo();
            return new JsonResult(null);
        }

    }
}
