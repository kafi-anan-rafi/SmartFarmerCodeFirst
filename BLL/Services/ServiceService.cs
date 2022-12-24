using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ServiceService
    {
        public static List<ServiceDto> Get()
        {
            var data = DataAccessFactory.ServiceAccess().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Service, ServiceDto>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<List<ServiceDto>>(data);
            return rt;
        }
        public static ServiceDto Get(int id)
        {
            var data = DataAccessFactory.ServiceAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Service, ServiceDto>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<ServiceDto>(data);
            return rt;
        }
        public static ServiceDto AddService(ServiceDto service)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ServiceDto, Service>();
                c.CreateMap<Service, ServiceDto>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Service>(service);
            var rt = DataAccessFactory.ServiceAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<ServiceDto>(rt);
            }
            return null;
        }
    }
}
