using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using SmoONE.DTOs;
using SmoONE.Domain;

namespace SmoONE.UI
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  Automapper配置类,用于实现InputDto到Entity和Entity到OutputDto之间的转换
    // ******************************************************************
    /// <summary>
    /// Automapper配置类
    /// </summary>
    public static class AutomapperConfig
    {
        public static void Init()
        {
            //映射InputDto到Entity
            Mapper.CreateMap<CCInputDto, SmoONE.Domain.CostCenter>();
            Mapper.CreateMap<CCTTInputDto, CC_Type_Template>();
            Mapper.CreateMap<DepInputDto, SmoONE.Domain.Department>();
            Mapper.CreateMap<LeaveInputDto, SmoONE.Domain.Leave>();
            Mapper.CreateMap<RB_RowsInputDto, RB_Rows>();
            Mapper.CreateMap<RBInputDto, Reimbursement>();
            Mapper.CreateMap<RBRTTInputDto, RB_RType_Template>();
            Mapper.CreateMap<UserInputDto, User>();

            //映射Entity到查询用的Dto
            Mapper.CreateMap<CC_Type_Template, CC_Type_TemplateDto>();
            Mapper.CreateMap<SmoONE.Domain.CostCenter, CCDetailDto>();
            Mapper.CreateMap<SmoONE.Domain.CostCenter, CCDto>();
            Mapper.CreateMap<SmoONE.Domain.Department, DepartmentDto>();
            Mapper.CreateMap<SmoONE.Domain.Department, DepDetailDto>();
            Mapper.CreateMap<SmoONE.Domain.Leave, LeaveDetailDto>();
            //名称相同的,会自动匹配映射,但是名称不同的,需要手动配置(比如L_CreateUser→U_ID)
            Mapper.CreateMap<SmoONE.Domain.Leave, LeaveDto>().ForMember(dto => dto.U_ID, (map) => map.MapFrom(m => m.L_CreateUser));
            Mapper.CreateMap<RB_Rows, RB_RowsDto>();
            Mapper.CreateMap<RB_RType_Template, RB_RType_TemplateDto>();
            Mapper.CreateMap<Reimbursement, RBDetailDto>();
            Mapper.CreateMap<Reimbursement, ReimbursementDto>().ForMember(dto => dto.U_ID, (map) => map.MapFrom(m => m.RB_CreateUser));
            Mapper.CreateMap<User, UserDepDto>().ForMember(dto => dto.Dep_ID, (map) => map.MapFrom(m => m.U_DepID));
            Mapper.CreateMap<User, UserDetailDto>();
            Mapper.CreateMap<User, UserDto>();

        }
    }
}
