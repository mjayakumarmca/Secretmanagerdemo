using Secretmanagerdemo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Host.ConfigureAppConfiguration(((_, configurationBuilder) =>
{
    configurationBuilder.AddAmazonSecretsManager("us-east-1", "arn:aws:secretsmanager:us-east-1:842497576495:secret:SecretManager-emids-jk-nlIrCM");
}));

builder.Services.Configure<MyApiCredentials>(builder.Configuration);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
