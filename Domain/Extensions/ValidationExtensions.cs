using Domain.DTO.Auth;
using Domain.DTO.Roles;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions
{
    public static class ValidationExtensions
    {
        public static void addFluentValidations(this IServiceCollection services) 
        {
            services.AddScoped<IValidator<RegisterDTO>, RegisterDtoValidator>();
            services.AddScoped<IValidator<LoginDTO>, LoginDtoValidator>();
            services.AddScoped<IValidator<CreateRoleDTO>, CreateRoleDTOValidator>();
            services.AddScoped<IValidator<UpdateRoleDTO>, UpdateRoleDTOValidator>();
            services.AddScoped<IValidator<UpdatePermissionsOnRoleDTO>, UpdatePermissionsOnRoleDTOValidator>();
        }
    }
}
