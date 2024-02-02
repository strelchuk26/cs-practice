using AutoMapper;
using BusinessLogic.Dtos;
using BusinessLogic.Interfaces;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Exceptions;
using BusinessLogic.ApiModels;
using DataAccess.Data.Entities;
using DataAccess.Repositories;

namespace BusinessLogic.Services
{
    public class AdvertsService : IAdvertsService
    {
        private readonly IRepository<Advert> advertsRepo;
        private readonly IMapper mapper;

        public AdvertsService(IRepository<Advert> productsRepo, IMapper mapper)
        {
            this.advertsRepo = advertsRepo;
            this.mapper = mapper;
        }

        public void Create(CreateAdvertModel product)
        {
            advertsRepo.Insert(mapper.Map<Advert>(product));
            advertsRepo.Save();
        }

        public void Delete(int id)
        {
            var item = advertsRepo.GetByID(id);

            if (item == null) throw new HttpException("Advert with Id not found!", HttpStatusCode.NotFound);

            advertsRepo.Delete(item);
            advertsRepo.Save();
        }

        public void Edit(EditAdvertModel product)
        {
            advertsRepo.Update(mapper.Map<Advert>(product));
            advertsRepo.Save();
        }

        public List<AdvertDto> Get()
        {
            var items = advertsRepo.Get(includeProperties: "Category");

            if (items == null) throw new HttpException("Adverts with Id not found!", HttpStatusCode.NotFound);

            return mapper.Map<List<AdvertDto>>(items);
        }

        public AdvertDto? Get(int id)
        {
            var item = advertsRepo.GetByID(id);

            if (item == null) throw new HttpException("Adverts with Id not found!", HttpStatusCode.NotFound);

            return mapper.Map<AdvertDto>(item);
        }
    }
}
