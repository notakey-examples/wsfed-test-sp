# WS-Fed test service provider

This is a simple ASP.NET project for testing federated authentication with Microsoft.AspNetCore.Authentication.WsFederation.

## Running

* Build image with `docker build ./ -t mybuiltimage`

* Run image

```shell
docker service create \
    ... your publishing details here ...
    --name my-wsfed-test \
    --net xyz \
    -e ADFS_URL_PREFIX=https://adfs.example.com \
    -e RP_ENTITY_ID=https://mywsfed.example.com/ \
    mybuiltimage:latest

```

ADFS_URL_PREFIX - prefix of your AD FS service, e.g. https://adfs.example.com

RP_ENTITY_ID - Relay Party identifier as entered in AD FS RP configuration

* Create RP in AD FS

```powershell
Add-AdfsRelyingPartyTrust -Name "WS-Fed test SP" -Notes "This is a test" -Identifier https://mywsfed.example.com/ -WSFedEndpoint https://mywsfed.example.com/signin-wsfed -IssuanceAuthorizationRules '@RuleTemplate = "AllowAllAuthzRule" => issue(Type = "http://schemas.microsoft.com/authorization/claims/permit", Value = "true");' -IssueOAuthRefreshTokensTo NoDevice
Set-AdfsRelyingPartyTrust -TargetName "WS-Fed test SP" -ClaimsProviderName @("Active Directory")
Set-AdfsRelyingPartyTrust -TargetName "WS-Fed test SP" -ClaimsProviderName @("Other claims provider")
```