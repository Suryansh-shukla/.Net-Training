using AutoMapper;
using ProductManagementDemo.API.DTOs;
using ProductManagementDemo.API.Entities;
using System.Text.Json;

namespace ProductManagementDemo.API.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            // ── Create DTO → Entity ────────────────────────────────────────
            CreateMap<CreateProductDto, Product>()
                .ForMember(dest => dest.SKU,
                    opt => opt.MapFrom(src => src.Sku))
                .ForMember(dest => dest.CreatedAt,
                    opt => opt.MapFrom(_ => DateTime.UtcNow))
                .ForMember(dest => dest.IsActive,
                    opt => opt.MapFrom(_ => true))
                // Serialize complex types to JSON strings for storage
                .ForMember(dest => dest.Tags,
                    opt => opt.MapFrom(src => JsonSerializer.Serialize(src.Tags)))
                .ForMember(dest => dest.Specifications,
                    opt => opt.MapFrom(src => JsonSerializer.Serialize(
                        src.Specifications ?? new())));

            // ── Update DTO → Entity ────────────────────────────────────────
            // Skip null values so unset fields are not overwritten
            CreateMap<UpdateProductDto, Product>()
                .ForMember(dest => dest.UpdatedAt,
                    opt => opt.MapFrom(_ => DateTime.UtcNow))
                .ForMember(dest => dest.Tags,
                    opt => opt.Condition(src => src.Tags != null))
                .ForMember(dest => dest.Tags,
                    opt => opt.MapFrom(src => JsonSerializer.Serialize(src.Tags)))
                .ForAllMembers(opts =>
                    opts.Condition((src, dest, srcMember) => srcMember != null));
        }

    }
}
