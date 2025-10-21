namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseWorkspaceKeyState<'Active, 'CustomerManagedKeyName, 'SynapseWorkspaceId> = { assignments: ResizeArray<azurerm.SynapseWorkspaceKey.SynapseWorkspaceKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_key">azurerm_synapse_workspace_key</a>.
    /// </summary>
    type SynapseWorkspaceKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseWorkspaceKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseWorkspaceKeyState<Missing, Missing, Missing>)

        member _.Zero(()) : SynapseWorkspaceKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseWorkspaceKeyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_key#active-1">SynapseWorkspaceKey#active</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: SynapseWorkspaceKeyState<Missing, 'CustomerManagedKeyName, 'SynapseWorkspaceId>, value: bool) : SynapseWorkspaceKeyState<Present, 'CustomerManagedKeyName, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Active <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceKeyState<Present, 'CustomerManagedKeyName, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_key#active-1">SynapseWorkspaceKey#active</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: SynapseWorkspaceKeyState<Missing, 'CustomerManagedKeyName, 'SynapseWorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : SynapseWorkspaceKeyState<Present, 'CustomerManagedKeyName, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Active <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceKeyState<Present, 'CustomerManagedKeyName, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_key#customer_managed_key_name-1">SynapseWorkspaceKey#customer_managed_key_name</a>.
        /// </summary>
        [<CustomOperation "customer_managed_key_name">]
        member _.CustomerManagedKeyName(state: SynapseWorkspaceKeyState<'Active, Missing, 'SynapseWorkspaceId>, value: string) : SynapseWorkspaceKeyState<'Active, Present, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.CustomerManagedKeyName <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceKeyState<'Active, Present, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_key#synapse_workspace_id-1">SynapseWorkspaceKey#synapse_workspace_id</a>.
        /// </summary>
        [<CustomOperation "synapse_workspace_id">]
        member _.SynapseWorkspaceId(state: SynapseWorkspaceKeyState<'Active, 'CustomerManagedKeyName, Missing>, value: string) : SynapseWorkspaceKeyState<'Active, 'CustomerManagedKeyName, Present> =
            state.assignments.Add(fun config -> config.SynapseWorkspaceId <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceKeyState<'Active, 'CustomerManagedKeyName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_key#customer_managed_key_versionless_id-1">SynapseWorkspaceKey#customer_managed_key_versionless_id</a>.
        /// </summary>
        [<CustomOperation "customer_managed_key_versionless_id">]
        member _.CustomerManagedKeyVersionlessId(state: SynapseWorkspaceKeyState<'Active, 'CustomerManagedKeyName, 'SynapseWorkspaceId>, value: string) : SynapseWorkspaceKeyState<'Active, 'CustomerManagedKeyName, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.CustomerManagedKeyVersionlessId <- value)
            state : SynapseWorkspaceKeyState<'Active, 'CustomerManagedKeyName, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_key#id-1">SynapseWorkspaceKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseWorkspaceKeyState<'Active, 'CustomerManagedKeyName, 'SynapseWorkspaceId>, value: string) : SynapseWorkspaceKeyState<'Active, 'CustomerManagedKeyName, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseWorkspaceKeyState<'Active, 'CustomerManagedKeyName, 'SynapseWorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_key#timeouts-1">SynapseWorkspaceKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseWorkspaceKeyState<'Active, 'CustomerManagedKeyName, 'SynapseWorkspaceId>, value: azurerm.SynapseWorkspaceKey.SynapseWorkspaceKeyTimeouts) : SynapseWorkspaceKeyState<'Active, 'CustomerManagedKeyName, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseWorkspaceKeyState<'Active, 'CustomerManagedKeyName, 'SynapseWorkspaceId>

        member _.Run(state: SynapseWorkspaceKeyState<Present, Present, Present>) : azurerm.SynapseWorkspaceKey.SynapseWorkspaceKey =
            let config = azurerm.SynapseWorkspaceKey.SynapseWorkspaceKeyConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseWorkspaceKey.SynapseWorkspaceKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseWorkspaceKey: missing required arguments. Must call: active, customer_managed_key_name, synapse_workspace_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseWorkspaceKeyState<_, _, _>) : azurerm.SynapseWorkspaceKey.SynapseWorkspaceKey =
            Unchecked.defaultof<azurerm.SynapseWorkspaceKey.SynapseWorkspaceKey>
