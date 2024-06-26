﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WebAdminDatLichPhongKham.Models;

namespace WebAdminDatLichPhongKham.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AppUser class
public class AppUser : IdentityUser
{

    public int idNhanVien { get; set; }
    [ForeignKey("idNhanVien")]
    public NhanVien nhanVien { get; set; }
}

