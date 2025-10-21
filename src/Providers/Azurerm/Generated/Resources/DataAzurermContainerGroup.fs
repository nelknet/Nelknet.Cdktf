namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermContainerGroupState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermContainerGroup.DataAzurermContainerGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_group">azurerm_container_group</a>.
    /// </summary>
    type DataAzurermContainerGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermContainerGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerGroupState<Missing, Missing>)

        member _.Zero(()) : DataAzurermContainerGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_group#name-1">DataAzurermContainerGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermContainerGroupState<Missing, 'ResourceGroupName>, value: string) : DataAzurermContainerGroupState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermContainerGroupState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_group#resource_group_name-1">DataAzurermContainerGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermContainerGroupState<'Name, Missing>, value: string) : DataAzurermContainerGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermContainerGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_group#id-1">DataAzurermContainerGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermContainerGroupState<'Name, 'ResourceGroupName>, value: string) : DataAzurermContainerGroupState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermContainerGroupState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_group#timeouts-1">DataAzurermContainerGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermContainerGroupState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermContainerGroup.DataAzurermContainerGroupTimeouts) : DataAzurermContainerGroupState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermContainerGroupState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_group#zones-1">DataAzurermContainerGroup#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: DataAzurermContainerGroupState<'Name, 'ResourceGroupName>, value: seq<string>) : DataAzurermContainerGroupState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : DataAzurermContainerGroupState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermContainerGroupState<Present, Present>) : azurerm.DataAzurermContainerGroup.DataAzurermContainerGroup =
            let config = azurerm.DataAzurermContainerGroup.DataAzurermContainerGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermContainerGroup.DataAzurermContainerGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermContainerGroup: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermContainerGroupState<_, _>) : azurerm.DataAzurermContainerGroup.DataAzurermContainerGroup =
            Unchecked.defaultof<azurerm.DataAzurermContainerGroup.DataAzurermContainerGroup>
