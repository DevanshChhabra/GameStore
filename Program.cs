using GameStoreNew.IService;
using GameStoreNew.Service;
using GameStoreNew.Components;

var builder = WebApplication.CreateBuilder(args);

try
{
    builder.Services.AddRazorComponents()
        .AddInteractiveServerComponents();
    builder.Services.AddSingleton<IGameService, GameService>();
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred while setting up services: {ex.Message}");
    throw;
}

WebApplication app;

try
{
    app = builder.Build();
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred while building the app: {ex.Message}");
    throw;
}

try
{
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error", createScopeForErrors: true);
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseAntiforgery();

    app.MapRazorComponents<App>()
        .AddInteractiveServerRenderMode();
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred while configuring the HTTP request pipeline: {ex.Message}");
    throw;
}

try
{
    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred while running the app: {ex.Message}");
    throw;
}
