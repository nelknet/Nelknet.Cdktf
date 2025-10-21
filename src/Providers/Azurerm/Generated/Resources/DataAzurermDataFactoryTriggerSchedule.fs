namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDataFactoryTriggerScheduleState<'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermDataFactoryTriggerSchedule.DataAzurermDataFactoryTriggerScheduleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory_trigger_schedule">azurerm_data_factory_trigger_schedule</a>.
    /// </summary>
    type DataAzurermDataFactoryTriggerScheduleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDataFactoryTriggerScheduleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataFactoryTriggerScheduleState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDataFactoryTriggerScheduleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataFactoryTriggerScheduleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory_trigger_schedule#data_factory_id-1">DataAzurermDataFactoryTriggerSchedule#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataAzurermDataFactoryTriggerScheduleState<Missing, 'Name>, value: string) : DataAzurermDataFactoryTriggerScheduleState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataAzurermDataFactoryTriggerScheduleState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory_trigger_schedule#name-1">DataAzurermDataFactoryTriggerSchedule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDataFactoryTriggerScheduleState<'DataFactoryId, Missing>, value: string) : DataAzurermDataFactoryTriggerScheduleState<'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDataFactoryTriggerScheduleState<'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory_trigger_schedule#id-1">DataAzurermDataFactoryTriggerSchedule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: string) : DataAzurermDataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory_trigger_schedule#timeouts-1">DataAzurermDataFactoryTriggerSchedule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDataFactoryTriggerScheduleState<'DataFactoryId, 'Name>, value: azurerm.DataAzurermDataFactoryTriggerSchedule.DataAzurermDataFactoryTriggerScheduleTimeouts) : DataAzurermDataFactoryTriggerScheduleState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDataFactoryTriggerScheduleState<'DataFactoryId, 'Name>

        member _.Run(state: DataAzurermDataFactoryTriggerScheduleState<Present, Present>) : azurerm.DataAzurermDataFactoryTriggerSchedule.DataAzurermDataFactoryTriggerSchedule =
            let config = azurerm.DataAzurermDataFactoryTriggerSchedule.DataAzurermDataFactoryTriggerScheduleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDataFactoryTriggerSchedule.DataAzurermDataFactoryTriggerSchedule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDataFactoryTriggerSchedule: missing required arguments. Must call: data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDataFactoryTriggerScheduleState<_, _>) : azurerm.DataAzurermDataFactoryTriggerSchedule.DataAzurermDataFactoryTriggerSchedule =
            Unchecked.defaultof<azurerm.DataAzurermDataFactoryTriggerSchedule.DataAzurermDataFactoryTriggerSchedule>
