using AutoMapper;
using Net5.Examen.Infrastructure.CrossCutting.Dtos;
using Net5.Examen.Infrastructure.CrossCutting.Helpers;
using Net5.Examen.Infrastructure.Data.Entities;

namespace Net5.Examen.API.Infrastructure.Mapper
{
    public class LibraryProfile:Profile
    {
        public LibraryProfile()
        {
            CreateMap<Student, StudentDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.FirstName} {src.MiddleName} {src.LastNames}"))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));

            CreateMap<StudentForCreationDto, Student>();
            CreateMap<StudentForUpdateDto, Student>();
        }
    }
}
