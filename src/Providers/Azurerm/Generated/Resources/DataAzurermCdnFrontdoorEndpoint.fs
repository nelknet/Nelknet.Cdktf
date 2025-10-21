namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermCdnFrontdoorEndpointState<'Name, 'ProfileName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermCdnFrontdoorEndpoint.DataAzurermCdnFrontdoorEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_endpoint">azurerm_cdn_frontdoor_endpoint</a>.
    /// </summary>
    type DataAzurermCdnFrontdoorEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermCdnFrontdoorEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnFrontdoorEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermCdnFrontdoorEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnFrontdoorEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_endpoint#name-1">DataAzurermCdnFrontdoorEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermCdnFrontdoorEndpointState<Missing, 'ProfileName, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorEndpointState<Present, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorEndpointState<Present, 'ProfileName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_endpoint#profile_name-1">DataAzurermCdnFrontdoorEndpoint#profile_name</a>.
        /// </summary>
        [<CustomOperation "profile_name">]
        member _.ProfileName(state: DataAzurermCdnFrontdoorEndpointState<'Name, Missing, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorEndpointState<'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProfileName <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorEndpointState<'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_endpoint#resource_group_name-1">DataAzurermCdnFrontdoorEndpoint#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermCdnFrontdoorEndpointState<'Name, 'ProfileName, Missing>, value: string) : DataAzurermCdnFrontdoorEndpointState<'Name, 'ProfileName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorEndpointState<'Name, 'ProfileName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_endpoint#id-1">DataAzurermCdnFrontdoorEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermCdnFrontdoorEndpointState<'Name, 'ProfileName, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorEndpointState<'Name, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermCdnFrontdoorEndpointState<'Name, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_endpoint#timeouts-1">DataAzurermCdnFrontdoorEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermCdnFrontdoorEndpointState<'Name, 'ProfileName, 'ResourceGroupName>, value: azurerm.DataAzurermCdnFrontdoorEndpoint.DataAzurermCdnFrontdoorEndpointTimeouts) : DataAzurermCdnFrontdoorEndpointState<'Name, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermCdnFrontdoorEndpointState<'Name, 'ProfileName, 'ResourceGroupName>

        member _.Run(state: DataAzurermCdnFrontdoorEndpointState<Present, Present, Present>) : azurerm.DataAzurermCdnFrontdoorEndpoint.DataAzurermCdnFrontdoorEndpoint =
            let config = azurerm.DataAzurermCdnFrontdoorEndpoint.DataAzurermCdnFrontdoorEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermCdnFrontdoorEndpoint.DataAzurermCdnFrontdoorEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermCdnFrontdoorEndpoint: missing required arguments. Must call: name, profile_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermCdnFrontdoorEndpointState<_, _, _>) : azurerm.DataAzurermCdnFrontdoorEndpoint.DataAzurermCdnFrontdoorEndpoint =
            Unchecked.defaultof<azurerm.DataAzurermCdnFrontdoorEndpoint.DataAzurermCdnFrontdoorEndpoint>
