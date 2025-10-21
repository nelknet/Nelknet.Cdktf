namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermIpGroupsState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermIpGroups.DataAzurermIpGroupsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ip_groups">azurerm_ip_groups</a>.
    /// </summary>
    type DataAzurermIpGroupsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermIpGroupsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermIpGroupsState<Missing, Missing>)

        member _.Zero(()) : DataAzurermIpGroupsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermIpGroupsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ip_groups#name-1">DataAzurermIpGroups#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermIpGroupsState<Missing, 'ResourceGroupName>, value: string) : DataAzurermIpGroupsState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermIpGroupsState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ip_groups#resource_group_name-1">DataAzurermIpGroups#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermIpGroupsState<'Name, Missing>, value: string) : DataAzurermIpGroupsState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermIpGroupsState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ip_groups#id-1">DataAzurermIpGroups#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermIpGroupsState<'Name, 'ResourceGroupName>, value: string) : DataAzurermIpGroupsState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermIpGroupsState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ip_groups#timeouts-1">DataAzurermIpGroups#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermIpGroupsState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermIpGroups.DataAzurermIpGroupsTimeouts) : DataAzurermIpGroupsState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermIpGroupsState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermIpGroupsState<Present, Present>) : azurerm.DataAzurermIpGroups.DataAzurermIpGroups =
            let config = azurerm.DataAzurermIpGroups.DataAzurermIpGroupsConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermIpGroups.DataAzurermIpGroups(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermIpGroups: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermIpGroupsState<_, _>) : azurerm.DataAzurermIpGroups.DataAzurermIpGroups =
            Unchecked.defaultof<azurerm.DataAzurermIpGroups.DataAzurermIpGroups>
