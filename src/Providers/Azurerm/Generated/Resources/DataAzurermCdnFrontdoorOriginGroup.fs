namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermCdnFrontdoorOriginGroupState<'Name, 'ProfileName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermCdnFrontdoorOriginGroup.DataAzurermCdnFrontdoorOriginGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_origin_group">azurerm_cdn_frontdoor_origin_group</a>.
    /// </summary>
    type DataAzurermCdnFrontdoorOriginGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermCdnFrontdoorOriginGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnFrontdoorOriginGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermCdnFrontdoorOriginGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnFrontdoorOriginGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_origin_group#name-1">DataAzurermCdnFrontdoorOriginGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermCdnFrontdoorOriginGroupState<Missing, 'ProfileName, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorOriginGroupState<Present, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorOriginGroupState<Present, 'ProfileName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_origin_group#profile_name-1">DataAzurermCdnFrontdoorOriginGroup#profile_name</a>.
        /// </summary>
        [<CustomOperation "profile_name">]
        member _.ProfileName(state: DataAzurermCdnFrontdoorOriginGroupState<'Name, Missing, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorOriginGroupState<'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProfileName <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorOriginGroupState<'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_origin_group#resource_group_name-1">DataAzurermCdnFrontdoorOriginGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermCdnFrontdoorOriginGroupState<'Name, 'ProfileName, Missing>, value: string) : DataAzurermCdnFrontdoorOriginGroupState<'Name, 'ProfileName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorOriginGroupState<'Name, 'ProfileName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_origin_group#id-1">DataAzurermCdnFrontdoorOriginGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermCdnFrontdoorOriginGroupState<'Name, 'ProfileName, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorOriginGroupState<'Name, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermCdnFrontdoorOriginGroupState<'Name, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_origin_group#timeouts-1">DataAzurermCdnFrontdoorOriginGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermCdnFrontdoorOriginGroupState<'Name, 'ProfileName, 'ResourceGroupName>, value: azurerm.DataAzurermCdnFrontdoorOriginGroup.DataAzurermCdnFrontdoorOriginGroupTimeouts) : DataAzurermCdnFrontdoorOriginGroupState<'Name, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermCdnFrontdoorOriginGroupState<'Name, 'ProfileName, 'ResourceGroupName>

        member _.Run(state: DataAzurermCdnFrontdoorOriginGroupState<Present, Present, Present>) : azurerm.DataAzurermCdnFrontdoorOriginGroup.DataAzurermCdnFrontdoorOriginGroup =
            let config = azurerm.DataAzurermCdnFrontdoorOriginGroup.DataAzurermCdnFrontdoorOriginGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermCdnFrontdoorOriginGroup.DataAzurermCdnFrontdoorOriginGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermCdnFrontdoorOriginGroup: missing required arguments. Must call: name, profile_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermCdnFrontdoorOriginGroupState<_, _, _>) : azurerm.DataAzurermCdnFrontdoorOriginGroup.DataAzurermCdnFrontdoorOriginGroup =
            Unchecked.defaultof<azurerm.DataAzurermCdnFrontdoorOriginGroup.DataAzurermCdnFrontdoorOriginGroup>
