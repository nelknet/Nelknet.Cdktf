namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId> = { assignments: ResizeArray<azurerm.VirtualHubIp.VirtualHubIpConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_ip">azurerm_virtual_hub_ip</a>.
    /// </summary>
    type VirtualHubIpBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualHubIpState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubIpState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualHubIpState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubIpState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_ip#name-1">VirtualHubIp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualHubIpState<Missing, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId>, value: string) : VirtualHubIpState<Present, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualHubIpState<Present, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_ip#public_ip_address_id-1">VirtualHubIp#public_ip_address_id</a>.
        /// </summary>
        [<CustomOperation "public_ip_address_id">]
        member _.PublicIpAddressId(state: VirtualHubIpState<'Name, Missing, 'SubnetId, 'VirtualHubId>, value: string) : VirtualHubIpState<'Name, Present, 'SubnetId, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.PublicIpAddressId <- value)
            ({ assignments = state.assignments } : VirtualHubIpState<'Name, Present, 'SubnetId, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_ip#subnet_id-1">VirtualHubIp#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: VirtualHubIpState<'Name, 'PublicIpAddressId, Missing, 'VirtualHubId>, value: string) : VirtualHubIpState<'Name, 'PublicIpAddressId, Present, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : VirtualHubIpState<'Name, 'PublicIpAddressId, Present, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_ip#virtual_hub_id-1">VirtualHubIp#virtual_hub_id</a>.
        /// </summary>
        [<CustomOperation "virtual_hub_id">]
        member _.VirtualHubId(state: VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, Missing>, value: string) : VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, Present> =
            state.assignments.Add(fun config -> config.VirtualHubId <- value)
            ({ assignments = state.assignments } : VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_ip#id-1">VirtualHubIp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId>, value: string) : VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_ip#private_ip_address-1">VirtualHubIp#private_ip_address</a>.
        /// </summary>
        [<CustomOperation "private_ip_address">]
        member _.PrivateIpAddress(state: VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId>, value: string) : VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.PrivateIpAddress <- value)
            state : VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_ip#private_ip_allocation_method-1">VirtualHubIp#private_ip_allocation_method</a>.
        /// </summary>
        [<CustomOperation "private_ip_allocation_method">]
        member _.PrivateIpAllocationMethod(state: VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId>, value: string) : VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.PrivateIpAllocationMethod <- value)
            state : VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_ip#timeouts-1">VirtualHubIp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId>, value: azurerm.VirtualHubIp.VirtualHubIpTimeouts) : VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualHubIpState<'Name, 'PublicIpAddressId, 'SubnetId, 'VirtualHubId>

        member _.Run(state: VirtualHubIpState<Present, Present, Present, Present>) : azurerm.VirtualHubIp.VirtualHubIp =
            let config = azurerm.VirtualHubIp.VirtualHubIpConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualHubIp.VirtualHubIp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualHubIp: missing required arguments. Must call: name, public_ip_address_id, subnet_id, virtual_hub_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualHubIpState<_, _, _, _>) : azurerm.VirtualHubIp.VirtualHubIp =
            Unchecked.defaultof<azurerm.VirtualHubIp.VirtualHubIp>
