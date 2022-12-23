﻿using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdvisorService
    {
        public static List<AdvisorDTO> Get()
        {
            var data = DataAccessFactory.AdvisorDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Advisor, AdvisorDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<List<AdvisorDTO>>(data);
            return rt;
        }
        public static AdvisorDTO Get(int id)
        {
            var data = DataAccessFactory.AdvisorDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Advisor, AdvisorDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<AdvisorDTO>(data);
            return rt;
        }
        public static AdvisorDTO Add(AdvisorDTO advisor)
        {

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AdvisorDTO, Advisor>();
                cfg.CreateMap<Advisor, AdvisorDTO>();
            });
            var mapper = new Mapper(config);
            var dbadvisor = mapper.Map<Advisor>(advisor);
            var rt = DataAccessFactory.AdvisorDataAccess().Add(dbadvisor);
            if (rt != null)
            {
                return mapper.Map<AdvisorDTO>(rt);
            }
            return null;
        }
        public static AdvisorDTO Delete(int id)
        {
            var rt = DataAccessFactory.AdvisorDataAccess().Delete(id);
            if (rt != null)
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Advisor, AdvisorDTO>();
                });
                var mapper = new Mapper(config);
                var dbadvisor = mapper.Map<AdvisorDTO>(rt);
                return dbadvisor;
            }
            return null;
        }
        public static AdvisorDTO Update(AdvisorDTO advisor)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AdvisorDTO, Advisor>();
                cfg.CreateMap<Advisor, AdvisorDTO>();
            });
            var mapper = new Mapper(config);
            var dbadvisor = mapper.Map<Advisor>(advisor);
            var rt = DataAccessFactory.AdvisorDataAccess().Update(dbadvisor);
            if (rt != null)
            {
                return mapper.Map<AdvisorDTO>(rt);
            }
            return null;
        }
    }
}
