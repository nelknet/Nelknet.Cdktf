namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MaintenanceAssignmentDynamicScopeState<'Filter, 'MaintenanceConfigurationId, 'Name> = { assignments: ResizeArray<azurerm.MaintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dynamic_scope">azurerm_maintenance_assignment_dynamic_scope</a>.
    /// </summary>
    type MaintenanceAssignmentDynamicScopeBuilder(logicalId: string) =
        member _.Yield(_: unit) : MaintenanceAssignmentDynamicScopeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MaintenanceAssignmentDynamicScopeState<Missing, Missing, Missing>)

        member _.Zero(()) : MaintenanceAssignmentDynamicScopeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MaintenanceAssignmentDynamicScopeState<Missing, Missing, Missing>)

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dynamic_scope#filter-1">MaintenanceAssignmentDynamicScope#filter</a>
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: MaintenanceAssignmentDynamicScopeState<Missing, 'MaintenanceConfigurationId, 'Name>, value: azurerm.MaintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeFilter) : MaintenanceAssignmentDynamicScopeState<Present, 'MaintenanceConfigurationId, 'Name> =
            state.assignments.Add(fun config -> config.Filter <- value)
            ({ assignments = state.assignments } : MaintenanceAssignmentDynamicScopeState<Present, 'MaintenanceConfigurationId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dynamic_scope#maintenance_configuration_id-1">MaintenanceAssignmentDynamicScope#maintenance_configuration_id</a>.
        /// </summary>
        [<CustomOperation "maintenance_configuration_id">]
        member _.MaintenanceConfigurationId(state: MaintenanceAssignmentDynamicScopeState<'Filter, Missing, 'Name>, value: string) : MaintenanceAssignmentDynamicScopeState<'Filter, Present, 'Name> =
            state.assignments.Add(fun config -> config.MaintenanceConfigurationId <- value)
            ({ assignments = state.assignments } : MaintenanceAssignmentDynamicScopeState<'Filter, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dynamic_scope#name-1">MaintenanceAssignmentDynamicScope#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MaintenanceAssignmentDynamicScopeState<'Filter, 'MaintenanceConfigurationId, Missing>, value: string) : MaintenanceAssignmentDynamicScopeState<'Filter, 'MaintenanceConfigurationId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MaintenanceAssignmentDynamicScopeState<'Filter, 'MaintenanceConfigurationId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dynamic_scope#id-1">MaintenanceAssignmentDynamicScope#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MaintenanceAssignmentDynamicScopeState<'Filter, 'MaintenanceConfigurationId, 'Name>, value: string) : MaintenanceAssignmentDynamicScopeState<'Filter, 'MaintenanceConfigurationId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MaintenanceAssignmentDynamicScopeState<'Filter, 'MaintenanceConfigurationId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dynamic_scope#timeouts-1">MaintenanceAssignmentDynamicScope#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MaintenanceAssignmentDynamicScopeState<'Filter, 'MaintenanceConfigurationId, 'Name>, value: azurerm.MaintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeTimeouts) : MaintenanceAssignmentDynamicScopeState<'Filter, 'MaintenanceConfigurationId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MaintenanceAssignmentDynamicScopeState<'Filter, 'MaintenanceConfigurationId, 'Name>

        member _.Run(state: MaintenanceAssignmentDynamicScopeState<Present, Present, Present>) : azurerm.MaintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScope =
            let config = azurerm.MaintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeConfig()
            for setter in state.assignments do
                setter config
            azurerm.MaintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScope(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.maintenanceAssignmentDynamicScope: missing required arguments. Must call: filter, maintenance_configuration_id, name.", 9999, IsError = true)>]
        member _.Run(_: MaintenanceAssignmentDynamicScopeState<_, _, _>) : azurerm.MaintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScope =
            Unchecked.defaultof<azurerm.MaintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScope>
