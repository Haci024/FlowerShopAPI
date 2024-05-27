using AutoMapper;
using DTO.DTOS.ContactUsDTO;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AutoMapper
{
    public class ContactUsMapper:Profile
    {
        public ContactUsMapper()
        {
            CreateMap<ContactUs, ReadContactUsDTO>().ReverseMap();
            CreateMap<ContactUs, ContactUsListDTO>().ReverseMap();
            CreateMap<ContactUs,SendContactUsDTO>().ReverseMap();
        }
    }
}
