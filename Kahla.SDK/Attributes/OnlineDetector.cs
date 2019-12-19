﻿using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Kahla.SDK.Attributes
{
    public class OnlineDetector : ActionFilterAttribute
    {
        public static Dictionary<string, DateTime> OnlineCache = new Dictionary<string, DateTime>();
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                var userId = context.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (!string.IsNullOrWhiteSpace(userId))
                {
                    OnlineCache[userId] = DateTime.UtcNow;
                }
            }
        }
    }
}