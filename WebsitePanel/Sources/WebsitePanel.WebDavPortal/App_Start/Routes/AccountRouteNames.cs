﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsitePanel.WebDavPortal.UI.Routes
{
    public class AccountRouteNames
    {
        public const string Logout = "AccountLogout";
        public const string Login = "AccountLogin";
        public const string UserProfile = "UserProfileRoute";

        public const string PasswordChange = "PasswordChangeRoute";
        public const string PasswordResetEmail = "PasswordResetEmailRoute";
        public const string PasswordResetSms = "PasswordResetSmsRoute";
        public const string PasswordResetSendSms = "PasswordResetSendSmsRoute";
        public const string PasswordResetFinalStep = "PasswordResetFinalStepRoute";
    }
}