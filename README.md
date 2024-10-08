# AspireEnvironmentIsAlwaysDevelopment
ASPNETCORE_ENVIRONMENT is always Development

Changing this environment variable in launchSettings.json doesn't seem to have any effect on the application. It seems like something is setting DOTNET_ENVIRONMENT to development no matter what.

This is a repo to reproduse this https://github.com/dotnet/aspire/issues/6185
