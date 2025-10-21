namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.NotificationHub.NotificationHubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub">azurerm_notification_hub</a>.
    /// </summary>
    type NotificationHubBuilder(logicalId: string) =
        member _.Yield(_: unit) : NotificationHubState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NotificationHubState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NotificationHubState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NotificationHubState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#location-1">NotificationHub#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NotificationHubState<Missing, 'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : NotificationHubState<Present, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NotificationHubState<Present, 'Name, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#name-1">NotificationHub#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NotificationHubState<'Location, Missing, 'NamespaceName, 'ResourceGroupName>, value: string) : NotificationHubState<'Location, Present, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NotificationHubState<'Location, Present, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#namespace_name-1">NotificationHub#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: NotificationHubState<'Location, 'Name, Missing, 'ResourceGroupName>, value: string) : NotificationHubState<'Location, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : NotificationHubState<'Location, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#resource_group_name-1">NotificationHub#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NotificationHubState<'Location, 'Name, 'NamespaceName, Missing>, value: string) : NotificationHubState<'Location, 'Name, 'NamespaceName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NotificationHubState<'Location, 'Name, 'NamespaceName, Present>)

        /// <summary>
        /// apns_credential block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#apns_credential-1">NotificationHub#apns_credential</a>
        /// </summary>
        [<CustomOperation "apns_credential">]
        member _.ApnsCredential(state: NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName>, value: azurerm.NotificationHub.NotificationHubApnsCredential) : NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApnsCredential <- value)
            state : NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// browser_credential block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#browser_credential-1">NotificationHub#browser_credential</a>
        /// </summary>
        [<CustomOperation "browser_credential">]
        member _.BrowserCredential(state: NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName>, value: azurerm.NotificationHub.NotificationHubBrowserCredential) : NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BrowserCredential <- value)
            state : NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// gcm_credential block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#gcm_credential-1">NotificationHub#gcm_credential</a>
        /// </summary>
        [<CustomOperation "gcm_credential">]
        member _.GcmCredential(state: NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName>, value: azurerm.NotificationHub.NotificationHubGcmCredential) : NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GcmCredential <- value)
            state : NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#id-1">NotificationHub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#tags-1">NotificationHub#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName>, value: seq<string * string>) : NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#timeouts-1">NotificationHub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName>, value: azurerm.NotificationHub.NotificationHubTimeouts) : NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NotificationHubState<'Location, 'Name, 'NamespaceName, 'ResourceGroupName>

        member _.Run(state: NotificationHubState<Present, Present, Present, Present>) : azurerm.NotificationHub.NotificationHub =
            let config = azurerm.NotificationHub.NotificationHubConfig()
            for setter in state.assignments do
                setter config
            azurerm.NotificationHub.NotificationHub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.notificationHub: missing required arguments. Must call: location, name, namespace_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: NotificationHubState<_, _, _, _>) : azurerm.NotificationHub.NotificationHub =
            Unchecked.defaultof<azurerm.NotificationHub.NotificationHub>
