namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId> = { assignments: ResizeArray<azurerm.ContainerConnectedRegistry.ContainerConnectedRegistryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry">azurerm_container_connected_registry</a>.
    /// </summary>
    type ContainerConnectedRegistryBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerConnectedRegistryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerConnectedRegistryState<Missing, Missing, Missing>)

        member _.Zero(()) : ContainerConnectedRegistryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerConnectedRegistryState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#container_registry_id-1">ContainerConnectedRegistry#container_registry_id</a>.
        /// </summary>
        [<CustomOperation "container_registry_id">]
        member _.ContainerRegistryId(state: ContainerConnectedRegistryState<Missing, 'Name, 'SyncTokenId>, value: string) : ContainerConnectedRegistryState<Present, 'Name, 'SyncTokenId> =
            state.assignments.Add(fun config -> config.ContainerRegistryId <- value)
            ({ assignments = state.assignments } : ContainerConnectedRegistryState<Present, 'Name, 'SyncTokenId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#name-1">ContainerConnectedRegistry#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerConnectedRegistryState<'ContainerRegistryId, Missing, 'SyncTokenId>, value: string) : ContainerConnectedRegistryState<'ContainerRegistryId, Present, 'SyncTokenId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerConnectedRegistryState<'ContainerRegistryId, Present, 'SyncTokenId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#sync_token_id-1">ContainerConnectedRegistry#sync_token_id</a>.
        /// </summary>
        [<CustomOperation "sync_token_id">]
        member _.SyncTokenId(state: ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, Missing>, value: string) : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, Present> =
            state.assignments.Add(fun config -> config.SyncTokenId <- value)
            ({ assignments = state.assignments } : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#audit_log_enabled-1">ContainerConnectedRegistry#audit_log_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "audit_log_enabled">]
        member _.AuditLogEnabled(state: ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>, value: bool) : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId> =
            state.assignments.Add(fun config -> config.AuditLogEnabled <- value)
            state : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#audit_log_enabled-1">ContainerConnectedRegistry#audit_log_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "audit_log_enabled">]
        member _.AuditLogEnabled(state: ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>, value: HashiCorp.Cdktf.IResolvable) : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId> =
            state.assignments.Add(fun config -> config.AuditLogEnabled <- value)
            state : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#client_token_ids-1">ContainerConnectedRegistry#client_token_ids</a>.
        /// </summary>
        [<CustomOperation "client_token_ids">]
        member _.ClientTokenIds(state: ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>, value: seq<string>) : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId> =
            state.assignments.Add(fun config -> config.ClientTokenIds <- (value |> Seq.toArray))
            state : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#id-1">ContainerConnectedRegistry#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>, value: string) : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#log_level-1">ContainerConnectedRegistry#log_level</a>.
        /// </summary>
        [<CustomOperation "log_level">]
        member _.LogLevel(state: ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>, value: string) : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId> =
            state.assignments.Add(fun config -> config.LogLevel <- value)
            state : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#mode-1">ContainerConnectedRegistry#mode</a>.
        /// </summary>
        [<CustomOperation "mode">]
        member _.Mode(state: ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>, value: string) : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId> =
            state.assignments.Add(fun config -> config.Mode <- value)
            state : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>

        /// <summary>
        /// notification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#notification-1">ContainerConnectedRegistry#notification</a> Accepts: azurerm.IResolvable | azurerm.ContainerConnectedRegistry.ContainerConnectedRegistryNotification[]
        /// </summary>
        [<CustomOperation "notification">]
        member _.Notification(state: ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>, value: HashiCorp.Cdktf.IResolvable) : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId> =
            state.assignments.Add(fun config -> config.Notification <- value)
            state : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#parent_registry_id-1">ContainerConnectedRegistry#parent_registry_id</a>.
        /// </summary>
        [<CustomOperation "parent_registry_id">]
        member _.ParentRegistryId(state: ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>, value: string) : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId> =
            state.assignments.Add(fun config -> config.ParentRegistryId <- value)
            state : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#sync_message_ttl-1">ContainerConnectedRegistry#sync_message_ttl</a>.
        /// </summary>
        [<CustomOperation "sync_message_ttl">]
        member _.SyncMessageTtl(state: ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>, value: string) : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId> =
            state.assignments.Add(fun config -> config.SyncMessageTtl <- value)
            state : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#sync_schedule-1">ContainerConnectedRegistry#sync_schedule</a>.
        /// </summary>
        [<CustomOperation "sync_schedule">]
        member _.SyncSchedule(state: ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>, value: string) : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId> =
            state.assignments.Add(fun config -> config.SyncSchedule <- value)
            state : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#sync_window-1">ContainerConnectedRegistry#sync_window</a>.
        /// </summary>
        [<CustomOperation "sync_window">]
        member _.SyncWindow(state: ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>, value: string) : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId> =
            state.assignments.Add(fun config -> config.SyncWindow <- value)
            state : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_connected_registry#timeouts-1">ContainerConnectedRegistry#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>, value: azurerm.ContainerConnectedRegistry.ContainerConnectedRegistryTimeouts) : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerConnectedRegistryState<'ContainerRegistryId, 'Name, 'SyncTokenId>

        member _.Run(state: ContainerConnectedRegistryState<Present, Present, Present>) : azurerm.ContainerConnectedRegistry.ContainerConnectedRegistry =
            let config = azurerm.ContainerConnectedRegistry.ContainerConnectedRegistryConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerConnectedRegistry.ContainerConnectedRegistry(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerConnectedRegistry: missing required arguments. Must call: container_registry_id, name, sync_token_id.", 9999, IsError = true)>]
        member _.Run(_: ContainerConnectedRegistryState<_, _, _>) : azurerm.ContainerConnectedRegistry.ContainerConnectedRegistry =
            Unchecked.defaultof<azurerm.ContainerConnectedRegistry.ContainerConnectedRegistry>
