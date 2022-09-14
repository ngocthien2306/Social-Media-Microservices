using Conversations.API.Data;
using Conversations.API.Entities;
using Conversations.API.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.Configure<ConversationDBSettings>(builder.Configuration.GetSection("ConversationsDB"));
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IConversationRepository, ConversationRepository>();
builder.Services.AddScoped<IConversationContext, ConversationContext>();
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
