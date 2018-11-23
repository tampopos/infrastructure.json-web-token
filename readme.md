# tmpps.infrastructure.json-web-token

## register nuget

```bash
npm run publish
# replace version,api-key
dotnet nuget push ./Tmpps.Infrastructure.JsonWebToken/bin/Release/Tmpps.Infrastructure.JsonWebToken.${version}.nupkg -k ${api-key} -s https://api.nuget.org/v3/index.json
```
