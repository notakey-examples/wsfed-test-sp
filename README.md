# WS-Fed test service provider

This is a simple ASP.NET project for testing federated autehntication with Microsoft.AspNetCore.Authentication.WsFederation.

## Running

* Build image with `docker build ./ -t mybuiltimage`

* Run image

```shell
docker service create \
    --name my-wsfed-test \
    --net xyz \
    -e ADFS_URL_PREFIX=https://adfs.example.com \
    -e RP_ENTITY_ID=https://mywsfed.example.com/ \
    mybuiltimage:latest

```

ADFS_URL_PREFIX - prefix of your AD FS service, e.g. https://adfs.example.com

RP_ENTITY_ID - Relay Party identifier as entered in AD FS RP configuration