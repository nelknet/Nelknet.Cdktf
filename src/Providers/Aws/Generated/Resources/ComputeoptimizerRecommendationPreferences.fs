namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ComputeoptimizerRecommendationPreferencesState<'ResourceType> = { assignments: ResizeArray<aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences">aws_computeoptimizer_recommendation_preferences</a>.
    /// </summary>
    type ComputeoptimizerRecommendationPreferencesBuilder(logicalId: string) =
        member _.Yield(_: unit) : ComputeoptimizerRecommendationPreferencesState<Missing> =
            ({ assignments = ResizeArray() } : ComputeoptimizerRecommendationPreferencesState<Missing>)

        member _.Zero(()) : ComputeoptimizerRecommendationPreferencesState<Missing> =
            ({ assignments = ResizeArray() } : ComputeoptimizerRecommendationPreferencesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#resource_type-1">ComputeoptimizerRecommendationPreferences#resource_type</a>.
        /// </summary>
        [<CustomOperation "resource_type">]
        member _.ResourceType(state: ComputeoptimizerRecommendationPreferencesState<Missing>, value: string) : ComputeoptimizerRecommendationPreferencesState<Present> =
            state.assignments.Add(fun config -> config.ResourceType <- value)
            ({ assignments = state.assignments } : ComputeoptimizerRecommendationPreferencesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#enhanced_infrastructure_metrics-1">ComputeoptimizerRecommendationPreferences#enhanced_infrastructure_metrics</a>.
        /// </summary>
        [<CustomOperation "enhanced_infrastructure_metrics">]
        member _.EnhancedInfrastructureMetrics(state: ComputeoptimizerRecommendationPreferencesState<'ResourceType>, value: string) : ComputeoptimizerRecommendationPreferencesState<'ResourceType> =
            state.assignments.Add(fun config -> config.EnhancedInfrastructureMetrics <- value)
            state : ComputeoptimizerRecommendationPreferencesState<'ResourceType>

        /// <summary>
        /// external_metrics_preference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#external_metrics_preference-1">ComputeoptimizerRecommendationPreferences#external_metrics_preference</a> Accepts: aws.IResolvable | aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesExternalMetricsPreference[]
        /// </summary>
        [<CustomOperation "external_metrics_preference">]
        member _.ExternalMetricsPreference(state: ComputeoptimizerRecommendationPreferencesState<'ResourceType>, value: HashiCorp.Cdktf.IResolvable) : ComputeoptimizerRecommendationPreferencesState<'ResourceType> =
            state.assignments.Add(fun config -> config.ExternalMetricsPreference <- value)
            state : ComputeoptimizerRecommendationPreferencesState<'ResourceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#inferred_workload_types-1">ComputeoptimizerRecommendationPreferences#inferred_workload_types</a>.
        /// </summary>
        [<CustomOperation "inferred_workload_types">]
        member _.InferredWorkloadTypes(state: ComputeoptimizerRecommendationPreferencesState<'ResourceType>, value: string) : ComputeoptimizerRecommendationPreferencesState<'ResourceType> =
            state.assignments.Add(fun config -> config.InferredWorkloadTypes <- value)
            state : ComputeoptimizerRecommendationPreferencesState<'ResourceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#look_back_period-1">ComputeoptimizerRecommendationPreferences#look_back_period</a>.
        /// </summary>
        [<CustomOperation "look_back_period">]
        member _.LookBackPeriod(state: ComputeoptimizerRecommendationPreferencesState<'ResourceType>, value: string) : ComputeoptimizerRecommendationPreferencesState<'ResourceType> =
            state.assignments.Add(fun config -> config.LookBackPeriod <- value)
            state : ComputeoptimizerRecommendationPreferencesState<'ResourceType>

        /// <summary>
        /// preferred_resource block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#preferred_resource-1">ComputeoptimizerRecommendationPreferences#preferred_resource</a> Accepts: aws.IResolvable | aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesPreferredResource[]
        /// </summary>
        [<CustomOperation "preferred_resource">]
        member _.PreferredResource(state: ComputeoptimizerRecommendationPreferencesState<'ResourceType>, value: HashiCorp.Cdktf.IResolvable) : ComputeoptimizerRecommendationPreferencesState<'ResourceType> =
            state.assignments.Add(fun config -> config.PreferredResource <- value)
            state : ComputeoptimizerRecommendationPreferencesState<'ResourceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#savings_estimation_mode-1">ComputeoptimizerRecommendationPreferences#savings_estimation_mode</a>.
        /// </summary>
        [<CustomOperation "savings_estimation_mode">]
        member _.SavingsEstimationMode(state: ComputeoptimizerRecommendationPreferencesState<'ResourceType>, value: string) : ComputeoptimizerRecommendationPreferencesState<'ResourceType> =
            state.assignments.Add(fun config -> config.SavingsEstimationMode <- value)
            state : ComputeoptimizerRecommendationPreferencesState<'ResourceType>

        /// <summary>
        /// scope block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#scope-1">ComputeoptimizerRecommendationPreferences#scope</a> Accepts: aws.IResolvable | aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesScope[]
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: ComputeoptimizerRecommendationPreferencesState<'ResourceType>, value: HashiCorp.Cdktf.IResolvable) : ComputeoptimizerRecommendationPreferencesState<'ResourceType> =
            state.assignments.Add(fun config -> config.Scope <- value)
            state : ComputeoptimizerRecommendationPreferencesState<'ResourceType>

        /// <summary>
        /// utilization_preference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#utilization_preference-1">ComputeoptimizerRecommendationPreferences#utilization_preference</a> Accepts: aws.IResolvable | aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesUtilizationPreference[]
        /// </summary>
        [<CustomOperation "utilization_preference">]
        member _.UtilizationPreference(state: ComputeoptimizerRecommendationPreferencesState<'ResourceType>, value: HashiCorp.Cdktf.IResolvable) : ComputeoptimizerRecommendationPreferencesState<'ResourceType> =
            state.assignments.Add(fun config -> config.UtilizationPreference <- value)
            state : ComputeoptimizerRecommendationPreferencesState<'ResourceType>

        member _.Run(state: ComputeoptimizerRecommendationPreferencesState<Present>) : aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferences =
            let config = aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesConfig()
            for setter in state.assignments do
                setter config
            aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferences(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.computeoptimizerRecommendationPreferences: missing required arguments. Must call: resource_type.", 9999, IsError = true)>]
        member _.Run(_: ComputeoptimizerRecommendationPreferencesState<_>) : aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferences =
            Unchecked.defaultof<aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferences>
