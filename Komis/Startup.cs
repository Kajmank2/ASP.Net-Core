using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Komis.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Komis
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) //rejstrujemy uslugi
        {
            services.AddTransient<ISamochodRepository, MokSamochodRepository>();  //oznacza ze za kazdym razem poprosi o samochod repository , gdy zadana jest instancja to za kazdym razem bedziemy otrzymywac nowa instancje , oporcz tego jest addsingielton - gdy jest tylko 1 wystapienie ,addscope = na zadanie zwroci to samo wystapienia a gdy wykracza poza zakres instancja zostanie usunieta , a przy nastepnym zadaniu zostanie nowa instancja
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) // komponenty oprogramowania posredniczego beda przechwytywac http
        {
            app.UseDeveloperExceptionPage(); //wazna jest kolejnosc dodawania
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute(); //MVC Z DOMYSLNYM ROUTINGIEM
        }
    }
}
