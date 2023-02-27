﻿using Abp.AutoMapper;
using ASP.NETMyProject.Authentication.External;

namespace ASP.NETMyProject.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
