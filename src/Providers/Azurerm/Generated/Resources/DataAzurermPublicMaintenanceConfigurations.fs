namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPublicMaintenanceConfigurationsState = { assignments: ResizeArray<azurerm.DataAzurermPublicMaintenanceConfigurations.DataAzurermPublicMaintenanceConfigurationsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_maintenance_configurations">azurerm_public_maintenance_configurations</a>.
    /// </summary>
    type DataAzurermPublicMaintenanceConfigurationsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPublicMaintenanceConfigurationsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAzurermPublicMaintenanceConfigurationsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_maintenance_configurations#id-1">DataAzurermPublicMaintenanceConfigurations#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPublicMaintenanceConfigurationsState, value: string) : DataAzurermPublicMaintenanceConfigurationsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPublicMaintenanceConfigurationsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_maintenance_configurations#location-1">DataAzurermPublicMaintenanceConfigurations#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataAzurermPublicMaintenanceConfigurationsState, value: string) : DataAzurermPublicMaintenanceConfigurationsState =
            state.assignments.Add(fun config -> config.Location <- value)
            state : DataAzurermPublicMaintenanceConfigurationsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_maintenance_configurations#recur_every-1">DataAzurermPublicMaintenanceConfigurations#recur_every</a>.
        /// </summary>
        [<CustomOperation "recur_every">]
        member _.RecurEvery(state: DataAzurermPublicMaintenanceConfigurationsState, value: string) : DataAzurermPublicMaintenanceConfigurationsState =
            state.assignments.Add(fun config -> config.RecurEvery <- value)
            state : DataAzurermPublicMaintenanceConfigurationsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_maintenance_configurations#scope-1">DataAzurermPublicMaintenanceConfigurations#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: DataAzurermPublicMaintenanceConfigurationsState, value: string) : DataAzurermPublicMaintenanceConfigurationsState =
            state.assignments.Add(fun config -> config.Scope <- value)
            state : DataAzurermPublicMaintenanceConfigurationsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_maintenance_configurations#timeouts-1">DataAzurermPublicMaintenanceConfigurations#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPublicMaintenanceConfigurationsState, value: azurerm.DataAzurermPublicMaintenanceConfigurations.DataAzurermPublicMaintenanceConfigurationsTimeouts) : DataAzurermPublicMaintenanceConfigurationsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPublicMaintenanceConfigurationsState

        member _.Run(state: DataAzurermPublicMaintenanceConfigurationsState) : azurerm.DataAzurermPublicMaintenanceConfigurations.DataAzurermPublicMaintenanceConfigurations =
            let config = azurerm.DataAzurermPublicMaintenanceConfigurations.DataAzurermPublicMaintenanceConfigurationsConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPublicMaintenanceConfigurations.DataAzurermPublicMaintenanceConfigurations(StackContext.get (), logicalId, config)
