﻿using SkyMallCore.Data;
using SkyMallCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyMallCore.Respository
{
    public interface ISysUserRespository: IRespositoryBase<SysUser>
    {
        IList<SysUser> GetSysUsers();
    }
}
