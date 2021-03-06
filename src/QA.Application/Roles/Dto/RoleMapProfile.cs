﻿using AutoMapper;
using Abp.Authorization;
using Abp.Authorization.Roles;
using QA.Authorization.Roles;

namespace QA.Roles.Dto
{
    public class RoleMapProfile : Profile
    {
        public RoleMapProfile()
        {
            // Role and permission
            CreateMap<Permission, string>().ConvertUsing(r => r.Name);
            CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

            CreateMap<CreateRoleDto, Role>(MemberList.Source).ForMember(x => x.Permissions, opt => opt.Ignore());
            CreateMap<RoleDto, Role>(MemberList.Source).ForMember(x => x.Permissions, opt => opt.Ignore());
        }
    }
}
