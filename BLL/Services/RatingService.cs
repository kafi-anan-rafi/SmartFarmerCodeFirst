using AutoMapper;
using BLL.DTOs;
using DAL.EF.Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RatingService
    {
        public static RatingDto AddRating(RatingDto rating)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<RatingDto, Rating>();
                c.CreateMap<Rating, RatingDto>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Rating>(rating);
            var rt = DataAccessFactory.RatingAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<RatingDto>(rt);
            }
            return null;
        }
        public static List<RatingDto> Get()
        {
            var data = DataAccessFactory.RatingAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Rating, RatingDto>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<RatingDto>>(data);
        }
        public static RatingDto Get(int id)
        {
            var data = DataAccessFactory.RatingAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Rating, RatingDto>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<RatingDto>(data);
        }
        public static RatingDto Delete(int id)
        {
            var rt = DataAccessFactory.RatingAccess().Delete(id);
            if (rt != null)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Rating, RatingDto>();
                });
                var mapper = new Mapper(config);
                var dbrating = mapper.Map<RatingDto>(rt);
                return dbrating;
            }
            return null;
        }
        public static RatingDto Update(RatingDto rating)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RatingDto, Rating>();
                cfg.CreateMap<Rating, RatingDto>();
            });
            var mapper = new Mapper(config);
            var dbrating = mapper.Map<Rating>(rating);
            var rt = DataAccessFactory.RatingAccess().Update(dbrating);
            if (rt != null)
            {
                return mapper.Map<RatingDto>(rt);
            }
            return null;
        }

    }
}
