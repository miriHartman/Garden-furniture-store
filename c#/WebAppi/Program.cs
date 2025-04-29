var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<IDal_Repository<Dto_Common_Enteties.CourseDto>, Dal_Repository.CoursesRepositoryl>();
builder.Services.AddScoped<IDallRepository.IDal_buy<DTO_Common.classes.Buy>,Dal_Repository.func_buy>();
builder.Services.AddScoped<IDallRepository.IDal_bydetails<DTO_Common.classes.Buy_Detailes>, Dal_Repository.func_buydetails>();
builder.Services.AddScoped<IDallRepository.Idal_category<DTO_Common.classes.Category>, Dal_Repository.func_category>();
builder.Services.AddScoped<IDallRepository.IDal_company<DTO_Common.classes.Company>, Dal_Repository.func_company>();
builder.Services.AddScoped<IDallRepository.IDal_product<DTO_Common.classes.Product>, Dal_Repository.func_product>();
builder.Services.AddScoped<IDallRepository.IDal_user<DTO_Common.classes.User>, Dal_Repository.func_user>();


builder.Services.AddScoped<IBll_Services.IBll_buy<DTO_Common.classes.Buy>, Bll_Services.Bll_s_buy>();
builder.Services.AddScoped < IBll_Services.IBll_buydetails<DTO_Common.classes.Buy_Detailes>, Bll_Services.Bll_s_buydetails> ();
builder.Services.AddScoped<IBll_Services.IBll_category<DTO_Common.classes.Category>, Bll_Services.Bll_s_category>();
builder.Services.AddScoped<IBll_Services.IBll_company<DTO_Common.classes.Company>, Bll_Services.Bll_s_company>();
builder.Services.AddScoped<IBll_Services.IBll_product<DTO_Common.classes.Product>, Bll_Services.Bll_s_product>();
builder.Services.AddScoped<IBll_Services.IBll_user<DTO_Common.classes.User>, Bll_Services.Bll_s_user>();






builder.Services.AddCors(opotion => opotion.AddPolicy("AllowAll",
    p => p.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()));
builder.Services.AddControllers()
           .AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);


var app = builder.Build();
app.UseCors("AllowAll");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
