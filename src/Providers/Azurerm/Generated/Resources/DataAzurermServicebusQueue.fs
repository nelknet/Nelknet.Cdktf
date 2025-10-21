namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermServicebusQueueState<'Name> = { assignments: ResizeArray<azurerm.DataAzurermServicebusQueue.DataAzurermServicebusQueueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue">azurerm_servicebus_queue</a>.
    /// </summary>
    type DataAzurermServicebusQueueBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermServicebusQueueState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusQueueState<Missing>)

        member _.Zero(()) : DataAzurermServicebusQueueState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusQueueState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue#name-1">DataAzurermServicebusQueue#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermServicebusQueueState<Missing>, value: string) : DataAzurermServicebusQueueState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermServicebusQueueState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue#id-1">DataAzurermServicebusQueue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermServicebusQueueState<'Name>, value: string) : DataAzurermServicebusQueueState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermServicebusQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue#namespace_id-1">DataAzurermServicebusQueue#namespace_id</a>.
        /// </summary>
        [<CustomOperation "namespace_id">]
        member _.NamespaceId(state: DataAzurermServicebusQueueState<'Name>, value: string) : DataAzurermServicebusQueueState<'Name> =
            state.assignments.Add(fun config -> config.NamespaceId <- value)
            state : DataAzurermServicebusQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue#namespace_name-1">DataAzurermServicebusQueue#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: DataAzurermServicebusQueueState<'Name>, value: string) : DataAzurermServicebusQueueState<'Name> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            state : DataAzurermServicebusQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue#resource_group_name-1">DataAzurermServicebusQueue#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermServicebusQueueState<'Name>, value: string) : DataAzurermServicebusQueueState<'Name> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            state : DataAzurermServicebusQueueState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue#timeouts-1">DataAzurermServicebusQueue#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermServicebusQueueState<'Name>, value: azurerm.DataAzurermServicebusQueue.DataAzurermServicebusQueueTimeouts) : DataAzurermServicebusQueueState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermServicebusQueueState<'Name>

        member _.Run(state: DataAzurermServicebusQueueState<Present>) : azurerm.DataAzurermServicebusQueue.DataAzurermServicebusQueue =
            let config = azurerm.DataAzurermServicebusQueue.DataAzurermServicebusQueueConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermServicebusQueue.DataAzurermServicebusQueue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermServicebusQueue: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermServicebusQueueState<_>) : azurerm.DataAzurermServicebusQueue.DataAzurermServicebusQueue =
            Unchecked.defaultof<azurerm.DataAzurermServicebusQueue.DataAzurermServicebusQueue>
