namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DevTestVirtualNetwork.DevTestVirtualNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network">azurerm_dev_test_virtual_network</a>.
    /// </summary>
    type DevTestVirtualNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevTestVirtualNetworkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevTestVirtualNetworkState<Missing, Missing, Missing>)

        member _.Zero(()) : DevTestVirtualNetworkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevTestVirtualNetworkState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#lab_name-1">DevTestVirtualNetwork#lab_name</a>.
        /// </summary>
        [<CustomOperation "lab_name">]
        member _.LabName(state: DevTestVirtualNetworkState<Missing, 'Name, 'ResourceGroupName>, value: string) : DevTestVirtualNetworkState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LabName <- value)
            ({ assignments = state.assignments } : DevTestVirtualNetworkState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#name-1">DevTestVirtualNetwork#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevTestVirtualNetworkState<'LabName, Missing, 'ResourceGroupName>, value: string) : DevTestVirtualNetworkState<'LabName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevTestVirtualNetworkState<'LabName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#resource_group_name-1">DevTestVirtualNetwork#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DevTestVirtualNetworkState<'LabName, 'Name, Missing>, value: string) : DevTestVirtualNetworkState<'LabName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DevTestVirtualNetworkState<'LabName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#description-1">DevTestVirtualNetwork#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName>, value: string) : DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#id-1">DevTestVirtualNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName>, value: string) : DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// subnet block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#subnet-1">DevTestVirtualNetwork#subnet</a>
        /// </summary>
        [<CustomOperation "subnet">]
        member _.Subnet(state: DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName>, value: azurerm.DevTestVirtualNetwork.DevTestVirtualNetworkSubnet) : DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Subnet <- value)
            state : DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#tags-1">DevTestVirtualNetwork#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName>, value: seq<string * string>) : DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#timeouts-1">DevTestVirtualNetwork#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName>, value: azurerm.DevTestVirtualNetwork.DevTestVirtualNetworkTimeouts) : DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName>

        member _.Run(state: DevTestVirtualNetworkState<Present, Present, Present>) : azurerm.DevTestVirtualNetwork.DevTestVirtualNetwork =
            let config = azurerm.DevTestVirtualNetwork.DevTestVirtualNetworkConfig()
            for setter in state.assignments do
                setter config
            azurerm.DevTestVirtualNetwork.DevTestVirtualNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.devTestVirtualNetwork: missing required arguments. Must call: lab_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DevTestVirtualNetworkState<_, _, _>) : azurerm.DevTestVirtualNetwork.DevTestVirtualNetwork =
            Unchecked.defaultof<azurerm.DevTestVirtualNetwork.DevTestVirtualNetwork>
