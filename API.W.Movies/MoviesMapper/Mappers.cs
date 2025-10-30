﻿using API.W.Movies.DAL.Models;
using API.W.Movies.DAL.Models.Dtos;
using AutoMapper;

namespace API.W.Movies.MoviesMapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();
        }
    }
}
