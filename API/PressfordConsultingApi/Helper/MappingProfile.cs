using AutoMapper;
using PressfordConsultingApi.Dtos;
using PressfordConsultingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressfordConsultingApi.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Article, ArticleDto>().ReverseMap();
        }
    }
}
