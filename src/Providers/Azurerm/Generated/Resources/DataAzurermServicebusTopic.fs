namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermServicebusTopicState<'Name> = { assignments: ResizeArray<azurerm.DataAzurermServicebusTopic.DataAzurermServicebusTopicConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic">azurerm_servicebus_topic</a>.
    /// </summary>
    type DataAzurermServicebusTopicBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermServicebusTopicState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusTopicState<Missing>)

        member _.Zero(()) : DataAzurermServicebusTopicState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusTopicState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic#name-1">DataAzurermServicebusTopic#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermServicebusTopicState<Missing>, value: string) : DataAzurermServicebusTopicState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermServicebusTopicState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic#id-1">DataAzurermServicebusTopic#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermServicebusTopicState<'Name>, value: string) : DataAzurermServicebusTopicState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermServicebusTopicState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic#namespace_id-1">DataAzurermServicebusTopic#namespace_id</a>.
        /// </summary>
        [<CustomOperation "namespace_id">]
        member _.NamespaceId(state: DataAzurermServicebusTopicState<'Name>, value: string) : DataAzurermServicebusTopicState<'Name> =
            state.assignments.Add(fun config -> config.NamespaceId <- value)
            state : DataAzurermServicebusTopicState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic#namespace_name-1">DataAzurermServicebusTopic#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: DataAzurermServicebusTopicState<'Name>, value: string) : DataAzurermServicebusTopicState<'Name> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            state : DataAzurermServicebusTopicState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic#resource_group_name-1">DataAzurermServicebusTopic#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermServicebusTopicState<'Name>, value: string) : DataAzurermServicebusTopicState<'Name> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            state : DataAzurermServicebusTopicState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic#timeouts-1">DataAzurermServicebusTopic#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermServicebusTopicState<'Name>, value: azurerm.DataAzurermServicebusTopic.DataAzurermServicebusTopicTimeouts) : DataAzurermServicebusTopicState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermServicebusTopicState<'Name>

        member _.Run(state: DataAzurermServicebusTopicState<Present>) : azurerm.DataAzurermServicebusTopic.DataAzurermServicebusTopic =
            let config = azurerm.DataAzurermServicebusTopic.DataAzurermServicebusTopicConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermServicebusTopic.DataAzurermServicebusTopic(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermServicebusTopic: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermServicebusTopicState<_>) : azurerm.DataAzurermServicebusTopic.DataAzurermServicebusTopic =
            Unchecked.defaultof<azurerm.DataAzurermServicebusTopic.DataAzurermServicebusTopic>
