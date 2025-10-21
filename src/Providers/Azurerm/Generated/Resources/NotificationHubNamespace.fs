namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.NotificationHubNamespace.NotificationHubNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_namespace">azurerm_notification_hub_namespace</a>.
    /// </summary>
    type NotificationHubNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : NotificationHubNamespaceState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NotificationHubNamespaceState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NotificationHubNamespaceState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NotificationHubNamespaceState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_namespace#location-1">NotificationHubNamespace#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NotificationHubNamespaceState<Missing, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName>, value: string) : NotificationHubNamespaceState<Present, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NotificationHubNamespaceState<Present, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_namespace#name-1">NotificationHubNamespace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NotificationHubNamespaceState<'Location, Missing, 'NamespaceType, 'ResourceGroupName, 'SkuName>, value: string) : NotificationHubNamespaceState<'Location, Present, 'NamespaceType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NotificationHubNamespaceState<'Location, Present, 'NamespaceType, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_namespace#namespace_type-1">NotificationHubNamespace#namespace_type</a>.
        /// </summary>
        [<CustomOperation "namespace_type">]
        member _.NamespaceType(state: NotificationHubNamespaceState<'Location, 'Name, Missing, 'ResourceGroupName, 'SkuName>, value: string) : NotificationHubNamespaceState<'Location, 'Name, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.NamespaceType <- value)
            ({ assignments = state.assignments } : NotificationHubNamespaceState<'Location, 'Name, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_namespace#resource_group_name-1">NotificationHubNamespace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, Missing, 'SkuName>, value: string) : NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_namespace#sku_name-1">NotificationHubNamespace#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, Missing>, value: string) : NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_namespace#enabled-1">NotificationHubNamespace#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName>, value: bool) : NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_namespace#enabled-1">NotificationHubNamespace#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_namespace#id-1">NotificationHubNamespace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName>, value: string) : NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_namespace#tags-1">NotificationHubNamespace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_namespace#timeouts-1">NotificationHubNamespace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName>, value: azurerm.NotificationHubNamespace.NotificationHubNamespaceTimeouts) : NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NotificationHubNamespaceState<'Location, 'Name, 'NamespaceType, 'ResourceGroupName, 'SkuName>

        member _.Run(state: NotificationHubNamespaceState<Present, Present, Present, Present, Present>) : azurerm.NotificationHubNamespace.NotificationHubNamespace =
            let config = azurerm.NotificationHubNamespace.NotificationHubNamespaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.NotificationHubNamespace.NotificationHubNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.notificationHubNamespace: missing required arguments. Must call: location, name, namespace_type, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: NotificationHubNamespaceState<_, _, _, _, _>) : azurerm.NotificationHubNamespace.NotificationHubNamespace =
            Unchecked.defaultof<azurerm.NotificationHubNamespace.NotificationHubNamespace>
