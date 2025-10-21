namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HealthcareServiceState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.HealthcareService.HealthcareServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service">azurerm_healthcare_service</a>.
    /// </summary>
    type HealthcareServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : HealthcareServiceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HealthcareServiceState<Missing, Missing, Missing>)

        member _.Zero(()) : HealthcareServiceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HealthcareServiceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#location-1">HealthcareService#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: HealthcareServiceState<Missing, 'Name, 'ResourceGroupName>, value: string) : HealthcareServiceState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : HealthcareServiceState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#name-1">HealthcareService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HealthcareServiceState<'Location, Missing, 'ResourceGroupName>, value: string) : HealthcareServiceState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HealthcareServiceState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#resource_group_name-1">HealthcareService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: HealthcareServiceState<'Location, 'Name, Missing>, value: string) : HealthcareServiceState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : HealthcareServiceState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#access_policy_object_ids-1">HealthcareService#access_policy_object_ids</a>.
        /// </summary>
        [<CustomOperation "access_policy_object_ids">]
        member _.AccessPolicyObjectIds(state: HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccessPolicyObjectIds <- (value |> Seq.toArray))
            state : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// authentication_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#authentication_configuration-1">HealthcareService#authentication_configuration</a>
        /// </summary>
        [<CustomOperation "authentication_configuration">]
        member _.AuthenticationConfiguration(state: HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.HealthcareService.HealthcareServiceAuthenticationConfiguration) : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AuthenticationConfiguration <- value)
            state : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#configuration_export_storage_account_name-1">HealthcareService#configuration_export_storage_account_name</a>.
        /// </summary>
        [<CustomOperation "configuration_export_storage_account_name">]
        member _.ConfigurationExportStorageAccountName(state: HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>, value: string) : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConfigurationExportStorageAccountName <- value)
            state : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// cors_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#cors_configuration-1">HealthcareService#cors_configuration</a>
        /// </summary>
        [<CustomOperation "cors_configuration">]
        member _.CorsConfiguration(state: HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.HealthcareService.HealthcareServiceCorsConfiguration) : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CorsConfiguration <- value)
            state : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#cosmosdb_key_vault_key_versionless_id-1">HealthcareService#cosmosdb_key_vault_key_versionless_id</a>.
        /// </summary>
        [<CustomOperation "cosmosdb_key_vault_key_versionless_id">]
        member _.CosmosdbKeyVaultKeyVersionlessId(state: HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>, value: string) : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CosmosdbKeyVaultKeyVersionlessId <- value)
            state : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#cosmosdb_throughput-1">HealthcareService#cosmosdb_throughput</a>.
        /// </summary>
        [<CustomOperation "cosmosdb_throughput">]
        member _.CosmosdbThroughput(state: HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>, value: double) : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CosmosdbThroughput <- value)
            state : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#id-1">HealthcareService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>, value: string) : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#identity-1">HealthcareService#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.HealthcareService.HealthcareServiceIdentity) : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#kind-1">HealthcareService#kind</a>.
        /// </summary>
        [<CustomOperation "kind">]
        member _.Kind(state: HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>, value: string) : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Kind <- value)
            state : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#public_network_access_enabled-1">HealthcareService#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>, value: bool) : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#public_network_access_enabled-1">HealthcareService#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#tags-1">HealthcareService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#timeouts-1">HealthcareService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.HealthcareService.HealthcareServiceTimeouts) : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HealthcareServiceState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: HealthcareServiceState<Present, Present, Present>) : azurerm.HealthcareService.HealthcareService =
            let config = azurerm.HealthcareService.HealthcareServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.HealthcareService.HealthcareService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.healthcareService: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: HealthcareServiceState<_, _, _>) : azurerm.HealthcareService.HealthcareService =
            Unchecked.defaultof<azurerm.HealthcareService.HealthcareService>
