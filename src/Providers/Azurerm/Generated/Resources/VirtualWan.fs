namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualWanState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.VirtualWan.VirtualWanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_wan">azurerm_virtual_wan</a>.
    /// </summary>
    type VirtualWanBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualWanState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualWanState<Missing, Missing, Missing>)

        member _.Zero(()) : VirtualWanState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualWanState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_wan#location-1">VirtualWan#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VirtualWanState<Missing, 'Name, 'ResourceGroupName>, value: string) : VirtualWanState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VirtualWanState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_wan#name-1">VirtualWan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualWanState<'Location, Missing, 'ResourceGroupName>, value: string) : VirtualWanState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualWanState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_wan#resource_group_name-1">VirtualWan#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VirtualWanState<'Location, 'Name, Missing>, value: string) : VirtualWanState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VirtualWanState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_wan#allow_branch_to_branch_traffic-1">VirtualWan#allow_branch_to_branch_traffic</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_branch_to_branch_traffic">]
        member _.AllowBranchToBranchTraffic(state: VirtualWanState<'Location, 'Name, 'ResourceGroupName>, value: bool) : VirtualWanState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllowBranchToBranchTraffic <- value)
            state : VirtualWanState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_wan#allow_branch_to_branch_traffic-1">VirtualWan#allow_branch_to_branch_traffic</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_branch_to_branch_traffic">]
        member _.AllowBranchToBranchTraffic(state: VirtualWanState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : VirtualWanState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllowBranchToBranchTraffic <- value)
            state : VirtualWanState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_wan#disable_vpn_encryption-1">VirtualWan#disable_vpn_encryption</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disable_vpn_encryption">]
        member _.DisableVpnEncryption(state: VirtualWanState<'Location, 'Name, 'ResourceGroupName>, value: bool) : VirtualWanState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisableVpnEncryption <- value)
            state : VirtualWanState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_wan#disable_vpn_encryption-1">VirtualWan#disable_vpn_encryption</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disable_vpn_encryption">]
        member _.DisableVpnEncryption(state: VirtualWanState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : VirtualWanState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisableVpnEncryption <- value)
            state : VirtualWanState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_wan#id-1">VirtualWan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualWanState<'Location, 'Name, 'ResourceGroupName>, value: string) : VirtualWanState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualWanState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_wan#office365_local_breakout_category-1">VirtualWan#office365_local_breakout_category</a>.
        /// </summary>
        [<CustomOperation "office365_local_breakout_category">]
        member _.Office365LocalBreakoutCategory(state: VirtualWanState<'Location, 'Name, 'ResourceGroupName>, value: string) : VirtualWanState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Office365LocalBreakoutCategory <- value)
            state : VirtualWanState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_wan#tags-1">VirtualWan#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VirtualWanState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : VirtualWanState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VirtualWanState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_wan#timeouts-1">VirtualWan#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualWanState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.VirtualWan.VirtualWanTimeouts) : VirtualWanState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualWanState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_wan#type-1">VirtualWan#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: VirtualWanState<'Location, 'Name, 'ResourceGroupName>, value: string) : VirtualWanState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : VirtualWanState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: VirtualWanState<Present, Present, Present>) : azurerm.VirtualWan.VirtualWan =
            let config = azurerm.VirtualWan.VirtualWanConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualWan.VirtualWan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualWan: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: VirtualWanState<_, _, _>) : azurerm.VirtualWan.VirtualWan =
            Unchecked.defaultof<azurerm.VirtualWan.VirtualWan>
