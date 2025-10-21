namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ArcPrivateLinkScope.ArcPrivateLinkScopeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_private_link_scope">azurerm_arc_private_link_scope</a>.
    /// </summary>
    type ArcPrivateLinkScopeBuilder(logicalId: string) =
        member _.Yield(_: unit) : ArcPrivateLinkScopeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ArcPrivateLinkScopeState<Missing, Missing, Missing>)

        member _.Zero(()) : ArcPrivateLinkScopeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ArcPrivateLinkScopeState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_private_link_scope#location-1">ArcPrivateLinkScope#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ArcPrivateLinkScopeState<Missing, 'Name, 'ResourceGroupName>, value: string) : ArcPrivateLinkScopeState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ArcPrivateLinkScopeState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_private_link_scope#name-1">ArcPrivateLinkScope#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ArcPrivateLinkScopeState<'Location, Missing, 'ResourceGroupName>, value: string) : ArcPrivateLinkScopeState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ArcPrivateLinkScopeState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_private_link_scope#resource_group_name-1">ArcPrivateLinkScope#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ArcPrivateLinkScopeState<'Location, 'Name, Missing>, value: string) : ArcPrivateLinkScopeState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ArcPrivateLinkScopeState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_private_link_scope#id-1">ArcPrivateLinkScope#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName>, value: string) : ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_private_link_scope#public_network_access_enabled-1">ArcPrivateLinkScope#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName>, value: bool) : ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_private_link_scope#public_network_access_enabled-1">ArcPrivateLinkScope#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_private_link_scope#tags-1">ArcPrivateLinkScope#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_private_link_scope#timeouts-1">ArcPrivateLinkScope#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.ArcPrivateLinkScope.ArcPrivateLinkScopeTimeouts) : ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ArcPrivateLinkScopeState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: ArcPrivateLinkScopeState<Present, Present, Present>) : azurerm.ArcPrivateLinkScope.ArcPrivateLinkScope =
            let config = azurerm.ArcPrivateLinkScope.ArcPrivateLinkScopeConfig()
            for setter in state.assignments do
                setter config
            azurerm.ArcPrivateLinkScope.ArcPrivateLinkScope(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.arcPrivateLinkScope: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ArcPrivateLinkScopeState<_, _, _>) : azurerm.ArcPrivateLinkScope.ArcPrivateLinkScope =
            Unchecked.defaultof<azurerm.ArcPrivateLinkScope.ArcPrivateLinkScope>
