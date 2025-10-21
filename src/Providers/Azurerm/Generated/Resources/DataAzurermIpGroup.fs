namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermIpGroupState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermIpGroup.DataAzurermIpGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ip_group">azurerm_ip_group</a>.
    /// </summary>
    type DataAzurermIpGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermIpGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermIpGroupState<Missing, Missing>)

        member _.Zero(()) : DataAzurermIpGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermIpGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ip_group#name-1">DataAzurermIpGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermIpGroupState<Missing, 'ResourceGroupName>, value: string) : DataAzurermIpGroupState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermIpGroupState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ip_group#resource_group_name-1">DataAzurermIpGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermIpGroupState<'Name, Missing>, value: string) : DataAzurermIpGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermIpGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ip_group#id-1">DataAzurermIpGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermIpGroupState<'Name, 'ResourceGroupName>, value: string) : DataAzurermIpGroupState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermIpGroupState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ip_group#timeouts-1">DataAzurermIpGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermIpGroupState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermIpGroup.DataAzurermIpGroupTimeouts) : DataAzurermIpGroupState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermIpGroupState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermIpGroupState<Present, Present>) : azurerm.DataAzurermIpGroup.DataAzurermIpGroup =
            let config = azurerm.DataAzurermIpGroup.DataAzurermIpGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermIpGroup.DataAzurermIpGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermIpGroup: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermIpGroupState<_, _>) : azurerm.DataAzurermIpGroup.DataAzurermIpGroup =
            Unchecked.defaultof<azurerm.DataAzurermIpGroup.DataAzurermIpGroup>
