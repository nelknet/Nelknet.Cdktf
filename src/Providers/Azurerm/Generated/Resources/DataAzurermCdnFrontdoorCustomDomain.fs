namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermCdnFrontdoorCustomDomainState<'Name, 'ProfileName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermCdnFrontdoorCustomDomain.DataAzurermCdnFrontdoorCustomDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_custom_domain">azurerm_cdn_frontdoor_custom_domain</a>.
    /// </summary>
    type DataAzurermCdnFrontdoorCustomDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermCdnFrontdoorCustomDomainState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnFrontdoorCustomDomainState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermCdnFrontdoorCustomDomainState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnFrontdoorCustomDomainState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_custom_domain#name-1">DataAzurermCdnFrontdoorCustomDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermCdnFrontdoorCustomDomainState<Missing, 'ProfileName, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorCustomDomainState<Present, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorCustomDomainState<Present, 'ProfileName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_custom_domain#profile_name-1">DataAzurermCdnFrontdoorCustomDomain#profile_name</a>.
        /// </summary>
        [<CustomOperation "profile_name">]
        member _.ProfileName(state: DataAzurermCdnFrontdoorCustomDomainState<'Name, Missing, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorCustomDomainState<'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProfileName <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorCustomDomainState<'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_custom_domain#resource_group_name-1">DataAzurermCdnFrontdoorCustomDomain#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermCdnFrontdoorCustomDomainState<'Name, 'ProfileName, Missing>, value: string) : DataAzurermCdnFrontdoorCustomDomainState<'Name, 'ProfileName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorCustomDomainState<'Name, 'ProfileName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_custom_domain#id-1">DataAzurermCdnFrontdoorCustomDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermCdnFrontdoorCustomDomainState<'Name, 'ProfileName, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorCustomDomainState<'Name, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermCdnFrontdoorCustomDomainState<'Name, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_custom_domain#timeouts-1">DataAzurermCdnFrontdoorCustomDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermCdnFrontdoorCustomDomainState<'Name, 'ProfileName, 'ResourceGroupName>, value: azurerm.DataAzurermCdnFrontdoorCustomDomain.DataAzurermCdnFrontdoorCustomDomainTimeouts) : DataAzurermCdnFrontdoorCustomDomainState<'Name, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermCdnFrontdoorCustomDomainState<'Name, 'ProfileName, 'ResourceGroupName>

        member _.Run(state: DataAzurermCdnFrontdoorCustomDomainState<Present, Present, Present>) : azurerm.DataAzurermCdnFrontdoorCustomDomain.DataAzurermCdnFrontdoorCustomDomain =
            let config = azurerm.DataAzurermCdnFrontdoorCustomDomain.DataAzurermCdnFrontdoorCustomDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermCdnFrontdoorCustomDomain.DataAzurermCdnFrontdoorCustomDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermCdnFrontdoorCustomDomain: missing required arguments. Must call: name, profile_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermCdnFrontdoorCustomDomainState<_, _, _>) : azurerm.DataAzurermCdnFrontdoorCustomDomain.DataAzurermCdnFrontdoorCustomDomain =
            Unchecked.defaultof<azurerm.DataAzurermCdnFrontdoorCustomDomain.DataAzurermCdnFrontdoorCustomDomain>
