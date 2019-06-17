using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Config_Library;
using MongoDB.Bson;
using MongoDB.Driver;

namespace API
{
    public class Startup
    {
        public static ConfigReader configReader;
        public List<BsonDocument> configList = new List<BsonDocument>();
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;


            //initialize config reader object 
            configReader = new ConfigReader("mongodb://test:test@localhost/admin", "ServiceA", 30);
            try
            {
                configReader.connect("admin");
                asyncWrapper();
            }
            catch (Exception ex)
            {
                string x = ex.ToString();
            }


        }

        public async void asyncWrapper()
        {
            await configReader.loadConfigurationsAsync();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
