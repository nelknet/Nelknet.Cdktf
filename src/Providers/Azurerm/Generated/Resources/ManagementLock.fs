namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ManagementLockState<'LockLevel, 'Name, 'Scope> = { assignments: ResizeArray<azurerm.ManagementLock.ManagementLockConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_lock">azurerm_management_lock</a>.
    /// </summary>
    type ManagementLockBuilder(logicalId: string) =
        member _.Yield(_: unit) : ManagementLockState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagementLockState<Missing, Missing, Missing>)

        member _.Zero(()) : ManagementLockState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagementLockState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_lock#lock_level-1">ManagementLock#lock_level</a>.
        /// </summary>
        [<CustomOperation "lock_level">]
        member _.LockLevel(state: ManagementLockState<Missing, 'Name, 'Scope>, value: string) : ManagementLockState<Present, 'Name, 'Scope> =
            state.assignments.Add(fun config -> config.LockLevel <- value)
            ({ assignments = state.assignments } : ManagementLockState<Present, 'Name, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_lock#name-1">ManagementLock#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ManagementLockState<'LockLevel, Missing, 'Scope>, value: string) : ManagementLockState<'LockLevel, Present, 'Scope> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ManagementLockState<'LockLevel, Present, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_lock#scope-1">ManagementLock#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: ManagementLockState<'LockLevel, 'Name, Missing>, value: string) : ManagementLockState<'LockLevel, 'Name, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : ManagementLockState<'LockLevel, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_lock#id-1">ManagementLock#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ManagementLockState<'LockLevel, 'Name, 'Scope>, value: string) : ManagementLockState<'LockLevel, 'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ManagementLockState<'LockLevel, 'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_lock#notes-1">ManagementLock#notes</a>.
        /// </summary>
        [<CustomOperation "notes">]
        member _.Notes(state: ManagementLockState<'LockLevel, 'Name, 'Scope>, value: string) : ManagementLockState<'LockLevel, 'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Notes <- value)
            state : ManagementLockState<'LockLevel, 'Name, 'Scope>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_lock#timeouts-1">ManagementLock#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ManagementLockState<'LockLevel, 'Name, 'Scope>, value: azurerm.ManagementLock.ManagementLockTimeouts) : ManagementLockState<'LockLevel, 'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ManagementLockState<'LockLevel, 'Name, 'Scope>

        member _.Run(state: ManagementLockState<Present, Present, Present>) : azurerm.ManagementLock.ManagementLock =
            let config = azurerm.ManagementLock.ManagementLockConfig()
            for setter in state.assignments do
                setter config
            azurerm.ManagementLock.ManagementLock(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.managementLock: missing required arguments. Must call: lock_level, name, scope.", 9999, IsError = true)>]
        member _.Run(_: ManagementLockState<_, _, _>) : azurerm.ManagementLock.ManagementLock =
            Unchecked.defaultof<azurerm.ManagementLock.ManagementLock>
