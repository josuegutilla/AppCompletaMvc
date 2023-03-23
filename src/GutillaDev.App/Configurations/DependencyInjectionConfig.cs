using DevIO.Business.Intefaces;
using DevIO.Business.Notificacoes;
using GutillaDev.App.Extensions;
using GutillaDev.Business.Intefaces;
using GutillaDev.Business.Interfaces;
using GutillaDev.Business.Services;
using GutillaDev.Data.Context;
using GutillaDev.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using System.Configuration;

namespace GutillaDev.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }
    }
}
