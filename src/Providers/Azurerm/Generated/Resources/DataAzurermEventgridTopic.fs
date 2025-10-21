namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermEventgridTopicState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermEventgridTopic.DataAzurermEventgridTopicConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_topic">azurerm_eventgrid_topic</a>.
    /// </summary>
    type DataAzurermEventgridTopicBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermEventgridTopicState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventgridTopicState<Missing, Missing>)

        member _.Zero(()) : DataAzurermEventgridTopicState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventgridTopicState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_topic#name-1">DataAzurermEventgridTopic#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermEventgridTopicState<Missing, 'ResourceGroupName>, value: string) : DataAzurermEventgridTopicState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermEventgridTopicState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_topic#resource_group_name-1">DataAzurermEventgridTopic#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermEventgridTopicState<'Name, Missing>, value: string) : DataAzurermEventgridTopicState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermEventgridTopicState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_topic#id-1">DataAzurermEventgridTopic#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermEventgridTopicState<'Name, 'ResourceGroupName>, value: string) : DataAzurermEventgridTopicState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermEventgridTopicState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_topic#timeouts-1">DataAzurermEventgridTopic#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermEventgridTopicState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermEventgridTopic.DataAzurermEventgridTopicTimeouts) : DataAzurermEventgridTopicState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermEventgridTopicState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermEventgridTopicState<Present, Present>) : azurerm.DataAzurermEventgridTopic.DataAzurermEventgridTopic =
            let config = azurerm.DataAzurermEventgridTopic.DataAzurermEventgridTopicConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermEventgridTopic.DataAzurermEventgridTopic(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermEventgridTopic: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermEventgridTopicState<_, _>) : azurerm.DataAzurermEventgridTopic.DataAzurermEventgridTopic =
            Unchecked.defaultof<azurerm.DataAzurermEventgridTopic.DataAzurermEventgridTopic>
