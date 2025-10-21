namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.IothubDps.IothubDpsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps">azurerm_iothub_dps</a>.
    /// </summary>
    type IothubDpsBuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubDpsState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubDpsState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : IothubDpsState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubDpsState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#location-1">IothubDps#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: IothubDpsState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : IothubDpsState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : IothubDpsState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#name-1">IothubDps#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IothubDpsState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : IothubDpsState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IothubDpsState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#resource_group_name-1">IothubDps#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubDpsState<'Location, 'Name, Missing, 'Sku>, value: string) : IothubDpsState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubDpsState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// sku block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#sku-1">IothubDps#sku</a>
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: IothubDpsState<'Location, 'Name, 'ResourceGroupName, Missing>, value: azurerm.IothubDps.IothubDpsSku) : IothubDpsState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : IothubDpsState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#allocation_policy-1">IothubDps#allocation_policy</a>.
        /// </summary>
        [<CustomOperation "allocation_policy">]
        member _.AllocationPolicy(state: IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AllocationPolicy <- value)
            state : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#data_residency_enabled-1">IothubDps#data_residency_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "data_residency_enabled">]
        member _.DataResidencyEnabled(state: IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DataResidencyEnabled <- value)
            state : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#data_residency_enabled-1">IothubDps#data_residency_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "data_residency_enabled">]
        member _.DataResidencyEnabled(state: IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DataResidencyEnabled <- value)
            state : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#id-1">IothubDps#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// ip_filter_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#ip_filter_rule-1">IothubDps#ip_filter_rule</a> Accepts: azurerm.IResolvable | azurerm.IothubDps.IothubDpsIpFilterRule[]
        /// </summary>
        [<CustomOperation "ip_filter_rule">]
        member _.IpFilterRule(state: IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.IpFilterRule <- value)
            state : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// linked_hub block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#linked_hub-1">IothubDps#linked_hub</a> Accepts: azurerm.IResolvable | azurerm.IothubDps.IothubDpsLinkedHub[]
        /// </summary>
        [<CustomOperation "linked_hub">]
        member _.LinkedHub(state: IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LinkedHub <- value)
            state : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#public_network_access_enabled-1">IothubDps#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#public_network_access_enabled-1">IothubDps#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#tags-1">IothubDps#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#timeouts-1">IothubDps#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.IothubDps.IothubDpsTimeouts) : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubDpsState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: IothubDpsState<Present, Present, Present, Present>) : azurerm.IothubDps.IothubDps =
            let config = azurerm.IothubDps.IothubDpsConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubDps.IothubDps(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubDps: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: IothubDpsState<_, _, _, _>) : azurerm.IothubDps.IothubDps =
            Unchecked.defaultof<azurerm.IothubDps.IothubDps>
