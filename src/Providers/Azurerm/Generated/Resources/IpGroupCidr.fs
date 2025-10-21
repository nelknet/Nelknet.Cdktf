namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IpGroupCidrState<'Cidr, 'IpGroupId> = { assignments: ResizeArray<azurerm.IpGroupCidr.IpGroupCidrConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ip_group_cidr">azurerm_ip_group_cidr</a>.
    /// </summary>
    type IpGroupCidrBuilder(logicalId: string) =
        member _.Yield(_: unit) : IpGroupCidrState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IpGroupCidrState<Missing, Missing>)

        member _.Zero(()) : IpGroupCidrState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IpGroupCidrState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ip_group_cidr#cidr-1">IpGroupCidr#cidr</a>.
        /// </summary>
        [<CustomOperation "cidr">]
        member _.Cidr(state: IpGroupCidrState<Missing, 'IpGroupId>, value: string) : IpGroupCidrState<Present, 'IpGroupId> =
            state.assignments.Add(fun config -> config.Cidr <- value)
            ({ assignments = state.assignments } : IpGroupCidrState<Present, 'IpGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ip_group_cidr#ip_group_id-1">IpGroupCidr#ip_group_id</a>.
        /// </summary>
        [<CustomOperation "ip_group_id">]
        member _.IpGroupId(state: IpGroupCidrState<'Cidr, Missing>, value: string) : IpGroupCidrState<'Cidr, Present> =
            state.assignments.Add(fun config -> config.IpGroupId <- value)
            ({ assignments = state.assignments } : IpGroupCidrState<'Cidr, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ip_group_cidr#id-1">IpGroupCidr#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IpGroupCidrState<'Cidr, 'IpGroupId>, value: string) : IpGroupCidrState<'Cidr, 'IpGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IpGroupCidrState<'Cidr, 'IpGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ip_group_cidr#timeouts-1">IpGroupCidr#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IpGroupCidrState<'Cidr, 'IpGroupId>, value: azurerm.IpGroupCidr.IpGroupCidrTimeouts) : IpGroupCidrState<'Cidr, 'IpGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IpGroupCidrState<'Cidr, 'IpGroupId>

        member _.Run(state: IpGroupCidrState<Present, Present>) : azurerm.IpGroupCidr.IpGroupCidr =
            let config = azurerm.IpGroupCidr.IpGroupCidrConfig()
            for setter in state.assignments do
                setter config
            azurerm.IpGroupCidr.IpGroupCidr(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.ipGroupCidr: missing required arguments. Must call: cidr, ip_group_id.", 9999, IsError = true)>]
        member _.Run(_: IpGroupCidrState<_, _>) : azurerm.IpGroupCidr.IpGroupCidr =
            Unchecked.defaultof<azurerm.IpGroupCidr.IpGroupCidr>
