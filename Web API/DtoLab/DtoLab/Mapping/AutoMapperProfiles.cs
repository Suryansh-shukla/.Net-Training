using AutoMapper;
using DtoLab.Models;
using DtoLab.Dtos;

namespace DtoLab.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            // Entity → DTO mappings
            CreateMap<User, UserDto>()
                .ForMember(
                    dest => dest.Age,
                    opt => opt.MapFrom(src => CalculateAge(src.DateOfBirth))
                );

            CreateMap<User, UserAdminDto>();

            // DTO → Entity mappings (for create/update)
            CreateMap<CreateUserDto, User>()
                .ForMember(
                    dest => dest.PasswordHash,
                    opt => opt.MapFrom(src => HashPassword(src.Password))
                )
                .ForMember(
                    dest => dest.CreatedAt,
                    opt => opt.MapFrom(src => DateTime.UtcNow)
                )
                .ForMember(
                    dest => dest.Id,
                    opt => opt.Ignore()  // Database generates Id
                )
                .ForMember(
                    dest => dest.IsAdmin,
                    opt => opt.MapFrom(src => false)  // Default value
                );

            CreateMap<UpdateUserDto, User>()
                .ForAllMembers(opts => opts.Condition(
                    (src, dest, srcMember) => srcMember != null
                ));
        }

        private int CalculateAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }

        private string HashPassword(string password)
        {
            // In real app, use proper password hashing
            return $"HASHED_{password}";
        }
    }
}
