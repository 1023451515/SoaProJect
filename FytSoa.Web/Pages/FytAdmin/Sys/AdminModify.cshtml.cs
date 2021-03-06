﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FytSoa.Core.Model.Sys;
using FytSoa.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FytSoa.Web.Pages.FytAdmin.Sys
{
    public class AdminModifyModel : PageModel
    {
        private readonly ISysAdminService _adminService;
        public AdminModifyModel(ISysAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public SysAdmin adminModel { get; set; }
        public void OnGet(string guid)
        {
            adminModel = _adminService.GetByGuidAsync(guid).Result.data;
        }
    }
}