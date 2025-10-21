namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermEventgridSystemTopicState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermEventgridSystemTopic.DataAzurermEventgridSystemTopicConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_system_topic">azurerm_eventgrid_system_topic</a>.
    /// </summary>
    type DataAzurermEventgridSystemTopicBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermEventgridSystemTopicState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventgridSystemTopicState<Missing, Missing>)

        member _.Zero(()) : DataAzurermEventgridSystemTopicState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventgridSystemTopicState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_system_topic#name-1">DataAzurermEventgridSystemTopic#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermEventgridSystemTopicState<Missing, 'ResourceGroupName>, value: string) : DataAzurermEventgridSystemTopicState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermEventgridSystemTopicState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_system_topic#resource_group_name-1">DataAzurermEventgridSystemTopic#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermEventgridSystemTopicState<'Name, Missing>, value: string) : DataAzurermEventgridSystemTopicState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermEventgridSystemTopicState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_system_topic#id-1">DataAzurermEventgridSystemTopic#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermEventgridSystemTopicState<'Name, 'ResourceGroupName>, value: string) : DataAzurermEventgridSystemTopicState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermEventgridSystemTopicState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_system_topic#timeouts-1">DataAzurermEventgridSystemTopic#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermEventgridSystemTopicState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermEventgridSystemTopic.DataAzurermEventgridSystemTopicTimeouts) : DataAzurermEventgridSystemTopicState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermEventgridSystemTopicState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermEventgridSystemTopicState<Present, Present>) : azurerm.DataAzurermEventgridSystemTopic.DataAzurermEventgridSystemTopic =
            let config = azurerm.DataAzurermEventgridSystemTopic.DataAzurermEventgridSystemTopicConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermEventgridSystemTopic.DataAzurermEventgridSystemTopic(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermEventgridSystemTopic: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermEventgridSystemTopicState<_, _>) : azurerm.DataAzurermEventgridSystemTopic.DataAzurermEventgridSystemTopic =
            Unchecked.defaultof<azurerm.DataAzurermEventgridSystemTopic.DataAzurermEventgridSystemTopic>
