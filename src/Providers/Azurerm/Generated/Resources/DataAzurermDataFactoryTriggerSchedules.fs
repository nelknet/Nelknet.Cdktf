namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDataFactoryTriggerSchedulesState<'DataFactoryId> = { assignments: ResizeArray<azurerm.DataAzurermDataFactoryTriggerSchedules.DataAzurermDataFactoryTriggerSchedulesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory_trigger_schedules">azurerm_data_factory_trigger_schedules</a>.
    /// </summary>
    type DataAzurermDataFactoryTriggerSchedulesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDataFactoryTriggerSchedulesState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataFactoryTriggerSchedulesState<Missing>)

        member _.Zero(()) : DataAzurermDataFactoryTriggerSchedulesState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataFactoryTriggerSchedulesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory_trigger_schedules#data_factory_id-1">DataAzurermDataFactoryTriggerSchedules#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataAzurermDataFactoryTriggerSchedulesState<Missing>, value: string) : DataAzurermDataFactoryTriggerSchedulesState<Present> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataAzurermDataFactoryTriggerSchedulesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory_trigger_schedules#id-1">DataAzurermDataFactoryTriggerSchedules#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDataFactoryTriggerSchedulesState<'DataFactoryId>, value: string) : DataAzurermDataFactoryTriggerSchedulesState<'DataFactoryId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDataFactoryTriggerSchedulesState<'DataFactoryId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory_trigger_schedules#timeouts-1">DataAzurermDataFactoryTriggerSchedules#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDataFactoryTriggerSchedulesState<'DataFactoryId>, value: azurerm.DataAzurermDataFactoryTriggerSchedules.DataAzurermDataFactoryTriggerSchedulesTimeouts) : DataAzurermDataFactoryTriggerSchedulesState<'DataFactoryId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDataFactoryTriggerSchedulesState<'DataFactoryId>

        member _.Run(state: DataAzurermDataFactoryTriggerSchedulesState<Present>) : azurerm.DataAzurermDataFactoryTriggerSchedules.DataAzurermDataFactoryTriggerSchedules =
            let config = azurerm.DataAzurermDataFactoryTriggerSchedules.DataAzurermDataFactoryTriggerSchedulesConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDataFactoryTriggerSchedules.DataAzurermDataFactoryTriggerSchedules(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDataFactoryTriggerSchedules: missing required arguments. Must call: data_factory_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDataFactoryTriggerSchedulesState<_>) : azurerm.DataAzurermDataFactoryTriggerSchedules.DataAzurermDataFactoryTriggerSchedules =
            Unchecked.defaultof<azurerm.DataAzurermDataFactoryTriggerSchedules.DataAzurermDataFactoryTriggerSchedules>
