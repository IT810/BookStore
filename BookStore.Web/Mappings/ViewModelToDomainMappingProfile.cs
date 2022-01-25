using AutoMapper;
using BookStore.Model.Models;
using BookStore.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected void Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                CreateMap<BookFormViewModel, Book>()
                .ForMember(g => g.Name, map => map.MapFrom(vm => vm.Title))
                .ForMember(g => g.Description, map => map.MapFrom(vm => vm.Description))
                .ForMember(g => g.Price, map => map.MapFrom(vm => vm.Price))
                .ForMember(g => g.Image, map => map.MapFrom(vm => vm.File.FileName))
                .ForMember(g => g.CategoryID, map => map.MapFrom(vm => vm.Category));
            });
        }
    }
}