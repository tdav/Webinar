using System.Text;
using Arch.EntityFrameworkCore.UnitOfWork;
using ExtCore.WebApplication.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Webinar.Models;
using Webinar.Models.Utils;
using Webinar.Repository;
using Webinar.Utils;
using Swashbuckle.AspNetCore.SwaggerUI;
using Webinar.Hubs;

namespace Webinar
{
    public class Startup
    {
        private string extensionsPath;

        public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            Configuration = configuration;
            this.extensionsPath = webHostEnvironment.ContentRootPath + configuration["Extensions:Path"];
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)//, ILoggerFactory loggerFactory)
        {
            services.AddExtCore(this.extensionsPath);

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders",
                        builder =>
                        {
                            builder.AllowAnyOrigin()
                                .AllowAnyHeader()
                                .AllowAnyMethod();
                        });
            });

            services
                .AddScoped<IAuditService, AuditService>()
                .AddDbContext<RssDbContext>(opt => opt.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"),
                                            ass => ass.MigrationsAssembly(typeof(RssDbContext).Assembly.FullName)))
                .AddCustomRepository<tbUser, UserRepository>();


            services.AddControllers()
                .AddNewtonsoftJson()
                .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

            services.AddSignalR();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Rss Sata.uz",
                });
                c.EnableAnnotations();
            });
            services.AddSwaggerGenNewtonsoftSupport();



            // configure jwt authentication
            var appSettings = Configuration.GetSection("AppSettings:Secret");
            var key = Encoding.ASCII.GetBytes(appSettings.Value);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, RssDbContext dataContext)
        {
            app.UseCors("AllowAllHeaders");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<WebrtcSignalingHub>("/signaling");
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Rss Sata.uz");
                c.DefaultModelExpandDepth(2);
                c.DefaultModelRendering(ModelRendering.Model);
                c.DefaultModelsExpandDepth(-1);
                c.DisplayOperationId();
                c.DisplayRequestDuration();
                c.DocExpansion(DocExpansion.None);
                c.EnableDeepLinking();
                c.EnableFilter();
                c.MaxDisplayedTags(5);
                c.ShowExtensions();
                c.EnableValidator();
                c.SupportedSubmitMethods(SubmitMethod.Get, SubmitMethod.Post, SubmitMethod.Delete, SubmitMethod.Put, SubmitMethod.Head);
            });

            app.UseExtCore();
        }
    }
}
