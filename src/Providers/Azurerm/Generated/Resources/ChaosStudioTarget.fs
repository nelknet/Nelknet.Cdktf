namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChaosStudioTargetState<'Location, 'TargetResourceId, 'TargetType> = { assignments: ResizeArray<azurerm.ChaosStudioTarget.ChaosStudioTargetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_target">azurerm_chaos_studio_target</a>.
    /// </summary>
    type ChaosStudioTargetBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChaosStudioTargetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChaosStudioTargetState<Missing, Missing, Missing>)

        member _.Zero(()) : ChaosStudioTargetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChaosStudioTargetState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_target#location-1">ChaosStudioTarget#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ChaosStudioTargetState<Missing, 'TargetResourceId, 'TargetType>, value: string) : ChaosStudioTargetState<Present, 'TargetResourceId, 'TargetType> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ChaosStudioTargetState<Present, 'TargetResourceId, 'TargetType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_target#target_resource_id-1">ChaosStudioTarget#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: ChaosStudioTargetState<'Location, Missing, 'TargetType>, value: string) : ChaosStudioTargetState<'Location, Present, 'TargetType> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : ChaosStudioTargetState<'Location, Present, 'TargetType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_target#target_type-1">ChaosStudioTarget#target_type</a>.
        /// </summary>
        [<CustomOperation "target_type">]
        member _.TargetType(state: ChaosStudioTargetState<'Location, 'TargetResourceId, Missing>, value: string) : ChaosStudioTargetState<'Location, 'TargetResourceId, Present> =
            state.assignments.Add(fun config -> config.TargetType <- value)
            ({ assignments = state.assignments } : ChaosStudioTargetState<'Location, 'TargetResourceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_target#id-1">ChaosStudioTarget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ChaosStudioTargetState<'Location, 'TargetResourceId, 'TargetType>, value: string) : ChaosStudioTargetState<'Location, 'TargetResourceId, 'TargetType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ChaosStudioTargetState<'Location, 'TargetResourceId, 'TargetType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_target#timeouts-1">ChaosStudioTarget#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ChaosStudioTargetState<'Location, 'TargetResourceId, 'TargetType>, value: azurerm.ChaosStudioTarget.ChaosStudioTargetTimeouts) : ChaosStudioTargetState<'Location, 'TargetResourceId, 'TargetType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ChaosStudioTargetState<'Location, 'TargetResourceId, 'TargetType>

        member _.Run(state: ChaosStudioTargetState<Present, Present, Present>) : azurerm.ChaosStudioTarget.ChaosStudioTarget =
            let config = azurerm.ChaosStudioTarget.ChaosStudioTargetConfig()
            for setter in state.assignments do
                setter config
            azurerm.ChaosStudioTarget.ChaosStudioTarget(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.chaosStudioTarget: missing required arguments. Must call: location, target_resource_id, target_type.", 9999, IsError = true)>]
        member _.Run(_: ChaosStudioTargetState<_, _, _>) : azurerm.ChaosStudioTarget.ChaosStudioTarget =
            Unchecked.defaultof<azurerm.ChaosStudioTarget.ChaosStudioTarget>
