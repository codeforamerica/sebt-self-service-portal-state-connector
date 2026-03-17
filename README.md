# sebt-self-service-portal-state-connector
A repository containing the contracts for the state backend connectors for the [Self-Service Summer EBT Portal application](https://github.com/codeforamerica/sebt-self-service-portal)

This service should be installed as a peer to the main `sebt-self-service-portal` application repo and relevant state connector (eg, [sebt-self-service-portal-co-connector](https://github.com/codeforamerica/sebt-self-service-portal-co-connector)).

1. Clone and follow instructions for setting up the main application, `sebt-self-service-portal`
2. Clone this repository in the same parent folder
3. Clone the relevant state connector repository in the same parent folder
4. From the root of this repo, run `dotnet tool restore` to install the .NET dependencies
5. Run `dotnet build` to build the project
