﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;

namespace PartsUnlimited.Areas.Admin.Controllers
{
    [Area(AdminConstants.Area)]
    [Authorize(AdminConstants.Role)]
    public abstract class AdminController : Controller
    {
    }
}