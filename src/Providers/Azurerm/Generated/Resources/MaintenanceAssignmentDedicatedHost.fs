namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MaintenanceAssignmentDedicatedHostState<'DedicatedHostId, 'Location, 'MaintenanceConfigurationId> = { assignments: ResizeArray<azurerm.MaintenanceAssignmentDedicatedHost.MaintenanceAssignmentDedicatedHostConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dedicated_host">azurerm_maintenance_assignment_dedicated_host</a>.
    /// </summary>
    type MaintenanceAssignmentDedicatedHostBuilder(logicalId: string) =
        member _.Yield(_: unit) : MaintenanceAssignmentDedicatedHostState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MaintenanceAssignmentDedicatedHostState<Missing, Missing, Missing>)

        member _.Zero(()) : MaintenanceAssignmentDedicatedHostState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MaintenanceAssignmentDedicatedHostState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dedicated_host#dedicated_host_id-1">MaintenanceAssignmentDedicatedHost#dedicated_host_id</a>.
        /// </summary>
        [<CustomOperation "dedicated_host_id">]
        member _.DedicatedHostId(state: MaintenanceAssignmentDedicatedHostState<Missing, 'Location, 'MaintenanceConfigurationId>, value: string) : MaintenanceAssignmentDedicatedHostState<Present, 'Location, 'MaintenanceConfigurationId> =
            state.assignments.Add(fun config -> config.DedicatedHostId <- value)
            ({ assignments = state.assignments } : MaintenanceAssignmentDedicatedHostState<Present, 'Location, 'MaintenanceConfigurationId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dedicated_host#location-1">MaintenanceAssignmentDedicatedHost#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MaintenanceAssignmentDedicatedHostState<'DedicatedHostId, Missing, 'MaintenanceConfigurationId>, value: string) : MaintenanceAssignmentDedicatedHostState<'DedicatedHostId, Present, 'MaintenanceConfigurationId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MaintenanceAssignmentDedicatedHostState<'DedicatedHostId, Present, 'MaintenanceConfigurationId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dedicated_host#maintenance_configuration_id-1">MaintenanceAssignmentDedicatedHost#maintenance_configuration_id</a>.
        /// </summary>
        [<CustomOperation "maintenance_configuration_id">]
        member _.MaintenanceConfigurationId(state: MaintenanceAssignmentDedicatedHostState<'DedicatedHostId, 'Location, Missing>, value: string) : MaintenanceAssignmentDedicatedHostState<'DedicatedHostId, 'Location, Present> =
            state.assignments.Add(fun config -> config.MaintenanceConfigurationId <- value)
            ({ assignments = state.assignments } : MaintenanceAssignmentDedicatedHostState<'DedicatedHostId, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dedicated_host#id-1">MaintenanceAssignmentDedicatedHost#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MaintenanceAssignmentDedicatedHostState<'DedicatedHostId, 'Location, 'MaintenanceConfigurationId>, value: string) : MaintenanceAssignmentDedicatedHostState<'DedicatedHostId, 'Location, 'MaintenanceConfigurationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MaintenanceAssignmentDedicatedHostState<'DedicatedHostId, 'Location, 'MaintenanceConfigurationId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dedicated_host#timeouts-1">MaintenanceAssignmentDedicatedHost#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MaintenanceAssignmentDedicatedHostState<'DedicatedHostId, 'Location, 'MaintenanceConfigurationId>, value: azurerm.MaintenanceAssignmentDedicatedHost.MaintenanceAssignmentDedicatedHostTimeouts) : MaintenanceAssignmentDedicatedHostState<'DedicatedHostId, 'Location, 'MaintenanceConfigurationId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MaintenanceAssignmentDedicatedHostState<'DedicatedHostId, 'Location, 'MaintenanceConfigurationId>

        member _.Run(state: MaintenanceAssignmentDedicatedHostState<Present, Present, Present>) : azurerm.MaintenanceAssignmentDedicatedHost.MaintenanceAssignmentDedicatedHost =
            let config = azurerm.MaintenanceAssignmentDedicatedHost.MaintenanceAssignmentDedicatedHostConfig()
            for setter in state.assignments do
                setter config
            azurerm.MaintenanceAssignmentDedicatedHost.MaintenanceAssignmentDedicatedHost(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.maintenanceAssignmentDedicatedHost: missing required arguments. Must call: dedicated_host_id, location, maintenance_configuration_id.", 9999, IsError = true)>]
        member _.Run(_: MaintenanceAssignmentDedicatedHostState<_, _, _>) : azurerm.MaintenanceAssignmentDedicatedHost.MaintenanceAssignmentDedicatedHost =
            Unchecked.defaultof<azurerm.MaintenanceAssignmentDedicatedHost.MaintenanceAssignmentDedicatedHost>
