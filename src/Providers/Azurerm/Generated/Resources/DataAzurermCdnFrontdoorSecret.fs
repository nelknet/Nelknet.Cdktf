namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermCdnFrontdoorSecretState<'Name, 'ProfileName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermCdnFrontdoorSecret.DataAzurermCdnFrontdoorSecretConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_secret">azurerm_cdn_frontdoor_secret</a>.
    /// </summary>
    type DataAzurermCdnFrontdoorSecretBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermCdnFrontdoorSecretState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnFrontdoorSecretState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermCdnFrontdoorSecretState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnFrontdoorSecretState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_secret#name-1">DataAzurermCdnFrontdoorSecret#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermCdnFrontdoorSecretState<Missing, 'ProfileName, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorSecretState<Present, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorSecretState<Present, 'ProfileName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_secret#profile_name-1">DataAzurermCdnFrontdoorSecret#profile_name</a>.
        /// </summary>
        [<CustomOperation "profile_name">]
        member _.ProfileName(state: DataAzurermCdnFrontdoorSecretState<'Name, Missing, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorSecretState<'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProfileName <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorSecretState<'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_secret#resource_group_name-1">DataAzurermCdnFrontdoorSecret#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermCdnFrontdoorSecretState<'Name, 'ProfileName, Missing>, value: string) : DataAzurermCdnFrontdoorSecretState<'Name, 'ProfileName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorSecretState<'Name, 'ProfileName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_secret#id-1">DataAzurermCdnFrontdoorSecret#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermCdnFrontdoorSecretState<'Name, 'ProfileName, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorSecretState<'Name, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermCdnFrontdoorSecretState<'Name, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_secret#timeouts-1">DataAzurermCdnFrontdoorSecret#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermCdnFrontdoorSecretState<'Name, 'ProfileName, 'ResourceGroupName>, value: azurerm.DataAzurermCdnFrontdoorSecret.DataAzurermCdnFrontdoorSecretTimeouts) : DataAzurermCdnFrontdoorSecretState<'Name, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermCdnFrontdoorSecretState<'Name, 'ProfileName, 'ResourceGroupName>

        member _.Run(state: DataAzurermCdnFrontdoorSecretState<Present, Present, Present>) : azurerm.DataAzurermCdnFrontdoorSecret.DataAzurermCdnFrontdoorSecret =
            let config = azurerm.DataAzurermCdnFrontdoorSecret.DataAzurermCdnFrontdoorSecretConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermCdnFrontdoorSecret.DataAzurermCdnFrontdoorSecret(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermCdnFrontdoorSecret: missing required arguments. Must call: name, profile_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermCdnFrontdoorSecretState<_, _, _>) : azurerm.DataAzurermCdnFrontdoorSecret.DataAzurermCdnFrontdoorSecret =
            Unchecked.defaultof<azurerm.DataAzurermCdnFrontdoorSecret.DataAzurermCdnFrontdoorSecret>
