namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CostoptimizationhubPreferencesState = { assignments: ResizeArray<aws.CostoptimizationhubPreferences.CostoptimizationhubPreferencesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/costoptimizationhub_preferences">aws_costoptimizationhub_preferences</a>.
    /// </summary>
    type CostoptimizationhubPreferencesBuilder(logicalId: string) =
        member _.Yield(_: unit) : CostoptimizationhubPreferencesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : CostoptimizationhubPreferencesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/costoptimizationhub_preferences#member_account_discount_visibility-1">CostoptimizationhubPreferences#member_account_discount_visibility</a>.
        /// </summary>
        [<CustomOperation "member_account_discount_visibility">]
        member _.MemberAccountDiscountVisibility(state: CostoptimizationhubPreferencesState, value: string) : CostoptimizationhubPreferencesState =
            state.assignments.Add(fun config -> config.MemberAccountDiscountVisibility <- value)
            state : CostoptimizationhubPreferencesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/costoptimizationhub_preferences#savings_estimation_mode-1">CostoptimizationhubPreferences#savings_estimation_mode</a>.
        /// </summary>
        [<CustomOperation "savings_estimation_mode">]
        member _.SavingsEstimationMode(state: CostoptimizationhubPreferencesState, value: string) : CostoptimizationhubPreferencesState =
            state.assignments.Add(fun config -> config.SavingsEstimationMode <- value)
            state : CostoptimizationhubPreferencesState

        member _.Run(state: CostoptimizationhubPreferencesState) : aws.CostoptimizationhubPreferences.CostoptimizationhubPreferences =
            let config = aws.CostoptimizationhubPreferences.CostoptimizationhubPreferencesConfig()
            for setter in state.assignments do
                setter config
            aws.CostoptimizationhubPreferences.CostoptimizationhubPreferences(StackContext.get (), logicalId, config)
