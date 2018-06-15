using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using QA.Authorization.Users;
using QA.Users.Dto;

namespace QA.MultiTenancy.Dto
{
    public class TenantMapProfile : Profile
    {
        public TenantMapProfile()
        {
            CreateMap<CreateTenantDto, Tenant>(MemberList.Source)
                .ForSourceMember(x => x.AdminEmailAddress, opt => opt.Ignore());

        }
    }
}
