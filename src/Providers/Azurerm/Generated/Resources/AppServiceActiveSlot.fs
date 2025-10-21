namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceActiveSlotState<'AppServiceName, 'AppServiceSlotName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AppServiceActiveSlot.AppServiceActiveSlotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_active_slot">azurerm_app_service_active_slot</a>.
    /// </summary>
    type AppServiceActiveSlotBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceActiveSlotState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceActiveSlotState<Missing, Missing, Missing>)

        member _.Zero(()) : AppServiceActiveSlotState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceActiveSlotState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_active_slot#app_service_name-1">AppServiceActiveSlot#app_service_name</a>.
        /// </summary>
        [<CustomOperation "app_service_name">]
        member _.AppServiceName(state: AppServiceActiveSlotState<Missing, 'AppServiceSlotName, 'ResourceGroupName>, value: string) : AppServiceActiveSlotState<Present, 'AppServiceSlotName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AppServiceName <- value)
            ({ assignments = state.assignments } : AppServiceActiveSlotState<Present, 'AppServiceSlotName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_active_slot#app_service_slot_name-1">AppServiceActiveSlot#app_service_slot_name</a>.
        /// </summary>
        [<CustomOperation "app_service_slot_name">]
        member _.AppServiceSlotName(state: AppServiceActiveSlotState<'AppServiceName, Missing, 'ResourceGroupName>, value: string) : AppServiceActiveSlotState<'AppServiceName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AppServiceSlotName <- value)
            ({ assignments = state.assignments } : AppServiceActiveSlotState<'AppServiceName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_active_slot#resource_group_name-1">AppServiceActiveSlot#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AppServiceActiveSlotState<'AppServiceName, 'AppServiceSlotName, Missing>, value: string) : AppServiceActiveSlotState<'AppServiceName, 'AppServiceSlotName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AppServiceActiveSlotState<'AppServiceName, 'AppServiceSlotName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_active_slot#id-1">AppServiceActiveSlot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceActiveSlotState<'AppServiceName, 'AppServiceSlotName, 'ResourceGroupName>, value: string) : AppServiceActiveSlotState<'AppServiceName, 'AppServiceSlotName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceActiveSlotState<'AppServiceName, 'AppServiceSlotName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_active_slot#timeouts-1">AppServiceActiveSlot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceActiveSlotState<'AppServiceName, 'AppServiceSlotName, 'ResourceGroupName>, value: azurerm.AppServiceActiveSlot.AppServiceActiveSlotTimeouts) : AppServiceActiveSlotState<'AppServiceName, 'AppServiceSlotName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceActiveSlotState<'AppServiceName, 'AppServiceSlotName, 'ResourceGroupName>

        member _.Run(state: AppServiceActiveSlotState<Present, Present, Present>) : azurerm.AppServiceActiveSlot.AppServiceActiveSlot =
            let config = azurerm.AppServiceActiveSlot.AppServiceActiveSlotConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceActiveSlot.AppServiceActiveSlot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceActiveSlot: missing required arguments. Must call: app_service_name, app_service_slot_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AppServiceActiveSlotState<_, _, _>) : azurerm.AppServiceActiveSlot.AppServiceActiveSlot =
            Unchecked.defaultof<azurerm.AppServiceActiveSlot.AppServiceActiveSlot>
