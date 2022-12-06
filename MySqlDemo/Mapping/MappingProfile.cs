using AutoMapper;
using MySqlDemo.AppServices.Dto;
using MySqlDemo.Models;

namespace MySqlDemo.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Brand, BrandOutput>();
            CreateMap<BrandInput, Brand>();

            CreateMap<Car, CarOutput>();
            CreateMap<CarInput, Car>();

            CreateMap<Color, ColorOutput>();
            CreateMap<ColorInput, Color>();
        }
    }
}
