global using project.Shared;
global using System.Net.Http.Json;
global using project.Client.Services.ProductService;
global using project.Client.Services.CategoryService;
global using project.Client.Services.AuthService;
global using Microsoft.AspNetCore.Components.Authorization;
global using project.Client.Services.CartService;
global using project.Client.Services.OrderService;
global using project.Client.Services.AddressService;
global using project.Client.Services.ProductTypeService;
using project.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using project.Client.Services.ProductTypeService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("project.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
    // .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("project.ServerAPI"));

builder.Services.AddApiAuthorization();
// builder.Services.AddPwa();

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

await builder.Build().RunAsync();
