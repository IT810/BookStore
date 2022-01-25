using AutoMapper;
using BookStore.Model;
using BookStore.Model.Models;
using BookStore.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace BookStore.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected void Configure()
        {
            var config = new MapperConfiguration(cfg => {
                CreateMap<Category, CategoryViewModel>();
                CreateMap<Book, BookViewModel>();
            });
            IMapper mapper = config.CreateMapper();
        }
    }
}