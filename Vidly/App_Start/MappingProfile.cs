using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Models;
using Vidly.Dtos;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>();
            Mapper.CreateMap<Genre, GenreDto>();
            Mapper.CreateMap<GenreDto, Genre>();
            Mapper.CreateMap<Rental, NewRentalDto>();
            Mapper.CreateMap<NewRentalDto,Rental>();

            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            //Mapper.CreateMap(MembershipTypeDto, MembershipType);

        }
    }
}