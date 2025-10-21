namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNotificationHubNamespaceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermNotificationHubNamespace.DataAzurermNotificationHubNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub_namespace">azurerm_notification_hub_namespace</a>.
    /// </summary>
    type DataAzurermNotificationHubNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNotificationHubNamespaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNotificationHubNamespaceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermNotificationHubNamespaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNotificationHubNamespaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub_namespace#name-1">DataAzurermNotificationHubNamespace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNotificationHubNamespaceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermNotificationHubNamespaceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNotificationHubNamespaceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub_namespace#resource_group_name-1">DataAzurermNotificationHubNamespace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermNotificationHubNamespaceState<'Name, Missing>, value: string) : DataAzurermNotificationHubNamespaceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermNotificationHubNamespaceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub_namespace#id-1">DataAzurermNotificationHubNamespace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNotificationHubNamespaceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermNotificationHubNamespaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNotificationHubNamespaceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/notification_hub_namespace#timeouts-1">DataAzurermNotificationHubNamespace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNotificationHubNamespaceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermNotificationHubNamespace.DataAzurermNotificationHubNamespaceTimeouts) : DataAzurermNotificationHubNamespaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNotificationHubNamespaceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermNotificationHubNamespaceState<Present, Present>) : azurerm.DataAzurermNotificationHubNamespace.DataAzurermNotificationHubNamespace =
            let config = azurerm.DataAzurermNotificationHubNamespace.DataAzurermNotificationHubNamespaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNotificationHubNamespace.DataAzurermNotificationHubNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNotificationHubNamespace: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNotificationHubNamespaceState<_, _>) : azurerm.DataAzurermNotificationHubNamespace.DataAzurermNotificationHubNamespace =
            Unchecked.defaultof<azurerm.DataAzurermNotificationHubNamespace.DataAzurermNotificationHubNamespace>
