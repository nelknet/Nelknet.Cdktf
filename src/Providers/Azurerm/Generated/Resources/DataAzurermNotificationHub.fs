namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNotificationHubState<'Name, 'NamespaceName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermNotificationHub.DataAzurermNotificationHubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub">azurerm_notification_hub</a>.
    /// </summary>
    type DataAzurermNotificationHubBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNotificationHubState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNotificationHubState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermNotificationHubState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNotificationHubState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub#name-1">DataAzurermNotificationHub#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNotificationHubState<Missing, 'NamespaceName, 'ResourceGroupName>, value: string) : DataAzurermNotificationHubState<Present, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNotificationHubState<Present, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub#namespace_name-1">DataAzurermNotificationHub#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: DataAzurermNotificationHubState<'Name, Missing, 'ResourceGroupName>, value: string) : DataAzurermNotificationHubState<'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : DataAzurermNotificationHubState<'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub#resource_group_name-1">DataAzurermNotificationHub#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermNotificationHubState<'Name, 'NamespaceName, Missing>, value: string) : DataAzurermNotificationHubState<'Name, 'NamespaceName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermNotificationHubState<'Name, 'NamespaceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub#id-1">DataAzurermNotificationHub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNotificationHubState<'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : DataAzurermNotificationHubState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNotificationHubState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub#timeouts-1">DataAzurermNotificationHub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNotificationHubState<'Name, 'NamespaceName, 'ResourceGroupName>, value: azurerm.DataAzurermNotificationHub.DataAzurermNotificationHubTimeouts) : DataAzurermNotificationHubState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNotificationHubState<'Name, 'NamespaceName, 'ResourceGroupName>

        member _.Run(state: DataAzurermNotificationHubState<Present, Present, Present>) : azurerm.DataAzurermNotificationHub.DataAzurermNotificationHub =
            let config = azurerm.DataAzurermNotificationHub.DataAzurermNotificationHubConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNotificationHub.DataAzurermNotificationHub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNotificationHub: missing required arguments. Must call: name, namespace_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNotificationHubState<_, _, _>) : azurerm.DataAzurermNotificationHub.DataAzurermNotificationHub =
            Unchecked.defaultof<azurerm.DataAzurermNotificationHub.DataAzurermNotificationHub>
