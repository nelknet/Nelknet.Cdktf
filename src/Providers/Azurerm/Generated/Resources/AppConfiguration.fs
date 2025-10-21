namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppConfigurationState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AppConfiguration.AppConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration">azurerm_app_configuration</a>.
    /// </summary>
    type AppConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppConfigurationState<Missing, Missing, Missing>)

        member _.Zero(()) : AppConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppConfigurationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#location-1">AppConfiguration#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: AppConfigurationState<Missing, 'Name, 'ResourceGroupName>, value: string) : AppConfigurationState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : AppConfigurationState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#name-1">AppConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppConfigurationState<'Location, Missing, 'ResourceGroupName>, value: string) : AppConfigurationState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppConfigurationState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#resource_group_name-1">AppConfiguration#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AppConfigurationState<'Location, 'Name, Missing>, value: string) : AppConfigurationState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AppConfigurationState<'Location, 'Name, Present>)

        /// <summary>
        /// encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#encryption-1">AppConfiguration#encryption</a>
        /// </summary>
        [<CustomOperation "encryption">]
        member _.Encryption(state: AppConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppConfiguration.AppConfigurationEncryption) : AppConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encryption <- value)
            state : AppConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#id-1">AppConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: string) : AppConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#identity-1">AppConfiguration#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: AppConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppConfiguration.AppConfigurationIdentity) : AppConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : AppConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#local_auth_enabled-1">AppConfiguration#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: AppConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: bool) : AppConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : AppConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#local_auth_enabled-1">AppConfiguration#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: AppConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AppConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : AppConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#public_network_access-1">AppConfiguration#public_network_access</a>.
        /// </summary>
        [<CustomOperation "public_network_access">]
        member _.PublicNetworkAccess(state: AppConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: string) : AppConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccess <- value)
            state : AppConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#purge_protection_enabled-1">AppConfiguration#purge_protection_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "purge_protection_enabled">]
        member _.PurgeProtectionEnabled(state: AppConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: bool) : AppConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PurgeProtectionEnabled <- value)
            state : AppConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#purge_protection_enabled-1">AppConfiguration#purge_protection_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "purge_protection_enabled">]
        member _.PurgeProtectionEnabled(state: AppConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AppConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PurgeProtectionEnabled <- value)
            state : AppConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// replica block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#replica-1">AppConfiguration#replica</a> Accepts: azurerm.IResolvable | azurerm.AppConfiguration.AppConfigurationReplica[]
        /// </summary>
        [<CustomOperation "replica">]
        member _.Replica(state: AppConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AppConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Replica <- value)
            state : AppConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#sku-1">AppConfiguration#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: AppConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: string) : AppConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Sku <- value)
            state : AppConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#soft_delete_retention_days-1">AppConfiguration#soft_delete_retention_days</a>.
        /// </summary>
        [<CustomOperation "soft_delete_retention_days">]
        member _.SoftDeleteRetentionDays(state: AppConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: double) : AppConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SoftDeleteRetentionDays <- value)
            state : AppConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#tags-1">AppConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : AppConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#timeouts-1">AppConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppConfiguration.AppConfigurationTimeouts) : AppConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppConfigurationState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: AppConfigurationState<Present, Present, Present>) : azurerm.AppConfiguration.AppConfiguration =
            let config = azurerm.AppConfiguration.AppConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppConfiguration.AppConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appConfiguration: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AppConfigurationState<_, _, _>) : azurerm.AppConfiguration.AppConfiguration =
            Unchecked.defaultof<azurerm.AppConfiguration.AppConfiguration>
