using System;
using AutoMapper;
using DDD.Application.DTO.DayFinished;
using DDD.Application.DTO.Order;
using DDD.Application.DTO.Role;
using DDD.Application.DTO.Storage;
using DDD.Application.DTO.User;
using DDD.Domain;
using DDD.Domain.Commands.User;
using DDD.Domain.Models;

namespace DDD.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {

            CreateMap<UserDto, User>();
            CreateMap<RoleDto, Role>();
            CreateMap<DayFinishedDto, DayFinished>();
            CreateMap<OrderAddDto, OrderPlacing>();
            CreateMap<OrderEditDto, OrderPlacing>();
            CreateMap<OrderCollectionDto, OrderPlacing>();
            CreateMap<OrderStorageDto, OrderPlacing>();
            CreateMap<DayFinishedDto, DayFinished>();


            ////这个注意 完全是两个不同的实体  练手
            CreateMap<OrderStorageDto, Storage>()
                .ConstructUsing(c => new Storage() {OrderId = c.OrderId, StorageCreateTime = DateTime.Now});

            CreateMap<UserEditDto, User>();

            //用户注册视图模型 -> 添加新用户命令模型

            CreateMap<UserRegisterDto, RegisterUserCommand>().ConstructUsing(c=>new RegisterUserCommand(c.UserName,c.UserPwd,c.UserConfirmPwd));

            ////手动进行配置
            //CreateMap<StudentViewModel, Student>()
            //    .ForPath(d => d.Address.Province, o => o.MapFrom(s => s.Province))
            //    .ForPath(d => d.Address.City, o => o.MapFrom(s => s.City))
            //    .ForPath(d => d.Address.County, o => o.MapFrom(s => s.County))
            //    .ForPath(d => d.Address.Street, o => o.MapFrom(s => s.Street))
            //    ;

            ////这里以后会写领域命令，所以不能和DomainToViewModelMappingProfile写在一起。
            ////学生视图模型 -> 添加新学生命令模型
            //CreateMap<StudentViewModel, RegisterStudentCommand>()
            //    .ConstructUsing(c => new RegisterStudentCommand(c.Name, c.Email, c.BirthDate, c.Phone, c.Province, c.City,
            //        c.County, c.Street));

            ////学生视图模型 -> 更新学生信息命令模型
            //CreateMap<StudentViewModel, UpdateStudentCommand>()
            //    .ConstructUsing(c => new UpdateStudentCommand(c.Id, c.Name, c.Email, c.BirthDate, c.Phone, c.Province, c.City,
            //        c.County, c.Street));


            //CreateMap<OrderViewModel, Order>();

            //CreateMap<OrderViewModel, RegisterOrderCommand>();
        }
    }
}