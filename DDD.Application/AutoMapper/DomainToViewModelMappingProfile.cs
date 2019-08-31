using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DDD.Application.DTO.Assemble;
using DDD.Application.DTO.Collection;
using DDD.Application.DTO.DayFinished;
using DDD.Application.DTO.Order;
using DDD.Application.DTO.Right;
using DDD.Application.DTO.Role;
using DDD.Application.DTO.Storage;
using DDD.Application.DTO.User;
using DDD.Domain;
using DDD.Domain.Models;

namespace DDD.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        /// <summary>
        /// 配置构造函数，用来创建关系映射
        /// </summary>
        public DomainToViewModelMappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<Role, RoleDto>();
            CreateMap<Right, RightDto>();
            CreateMap<User, LoginOutput>();
            CreateMap<OrderPlacing, OrderCollectionDto>();
            CreateMap<OrderPlacing, OrderAssembleDto>();

            CreateMap<OrderPlacing, OrderEditDto>();

            CreateMap<OrderPlacing, OrderStorageDto>();
            CreateMap<OrderPlacing, OrderGatherSearchDto>();
           

            CreateMap<Collection, CollectionDto>();
            CreateMap<Assemble, AssembleDto>();

            CreateMap<DayFinished, DayFinishedDto>();

            CreateMap<Storage, StorageDto>();

            //.ForMember(d => d.County, o => o.MapFrom(s => s.Address.County))
            //.ForMember(d => d.Province, o => o.MapFrom(s => s.Address.Province))
            //.ForMember(d => d.City, o => o.MapFrom(s => s.Address.City))
            //.ForMember(d => d.Street, o => o.MapFrom(s => s.Address.Street))
            //;

            //CreateMap<Order, OrderViewModel>();
            //CreateMap<OrderItem, OrderItemViewModel>();
            //CreateMap<OrderItemViewModel, OrderItem>();


        }
    }
}
