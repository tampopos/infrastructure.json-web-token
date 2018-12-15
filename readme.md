# tmpps.infrastructure.json-web-token

## command

#### build

`dotnet build Tmpps.Infrastructure.JsonWebToken.Tests/`

#### test

`dotnet test Tmpps.Infrastructure.JsonWebToken.Tests/`

#### register nuget

```bash
dotnet build -c Release Tmpps.Infrastructure.JsonWebToken
# replace version,api-key
dotnet pack -c Release --include-source -p:PackageVersion=${version} Tmpps.Infrastructure.JsonWebToken
dotnet nuget push ./Tmpps.Infrastructure.JsonWebToken/bin/Release/Tmpps.Infrastructure.JsonWebToken.${version}.nupkg -k ${api-key} -s https://api.nuget.org/v3/index.json
```

## use circleCI CLI

#### validation config

`circleci config validate`

#### test

`circleci local execute --job test`

#### release

```bash
git tag X.Y.Z
git push origin --tags
```
