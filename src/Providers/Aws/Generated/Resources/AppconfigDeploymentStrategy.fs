namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo> = { assignments: ResizeArray<aws.AppconfigDeploymentStrategy.AppconfigDeploymentStrategyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment_strategy">aws_appconfig_deployment_strategy</a>.
    /// </summary>
    type AppconfigDeploymentStrategyBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppconfigDeploymentStrategyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppconfigDeploymentStrategyState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppconfigDeploymentStrategyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppconfigDeploymentStrategyState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment_strategy#deployment_duration_in_minutes-1">AppconfigDeploymentStrategy#deployment_duration_in_minutes</a>.
        /// </summary>
        [<CustomOperation "deployment_duration_in_minutes">]
        member _.DeploymentDurationInMinutes(state: AppconfigDeploymentStrategyState<Missing, 'GrowthFactor, 'Name, 'ReplicateTo>, value: double) : AppconfigDeploymentStrategyState<Present, 'GrowthFactor, 'Name, 'ReplicateTo> =
            state.assignments.Add(fun config -> config.DeploymentDurationInMinutes <- value)
            ({ assignments = state.assignments } : AppconfigDeploymentStrategyState<Present, 'GrowthFactor, 'Name, 'ReplicateTo>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment_strategy#growth_factor-1">AppconfigDeploymentStrategy#growth_factor</a>.
        /// </summary>
        [<CustomOperation "growth_factor">]
        member _.GrowthFactor(state: AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, Missing, 'Name, 'ReplicateTo>, value: double) : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, Present, 'Name, 'ReplicateTo> =
            state.assignments.Add(fun config -> config.GrowthFactor <- value)
            ({ assignments = state.assignments } : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, Present, 'Name, 'ReplicateTo>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment_strategy#name-1">AppconfigDeploymentStrategy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, Missing, 'ReplicateTo>, value: string) : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, Present, 'ReplicateTo> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, Present, 'ReplicateTo>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment_strategy#replicate_to-1">AppconfigDeploymentStrategy#replicate_to</a>.
        /// </summary>
        [<CustomOperation "replicate_to">]
        member _.ReplicateTo(state: AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, Missing>, value: string) : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, Present> =
            state.assignments.Add(fun config -> config.ReplicateTo <- value)
            ({ assignments = state.assignments } : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment_strategy#description-1">AppconfigDeploymentStrategy#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo>, value: string) : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment_strategy#final_bake_time_in_minutes-1">AppconfigDeploymentStrategy#final_bake_time_in_minutes</a>.
        /// </summary>
        [<CustomOperation "final_bake_time_in_minutes">]
        member _.FinalBakeTimeInMinutes(state: AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo>, value: double) : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo> =
            state.assignments.Add(fun config -> config.FinalBakeTimeInMinutes <- value)
            state : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment_strategy#growth_type-1">AppconfigDeploymentStrategy#growth_type</a>.
        /// </summary>
        [<CustomOperation "growth_type">]
        member _.GrowthType(state: AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo>, value: string) : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo> =
            state.assignments.Add(fun config -> config.GrowthType <- value)
            state : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment_strategy#id-1">AppconfigDeploymentStrategy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo>, value: string) : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment_strategy#tags-1">AppconfigDeploymentStrategy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo>, value: seq<string * string>) : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment_strategy#tags_all-1">AppconfigDeploymentStrategy#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo>, value: seq<string * string>) : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppconfigDeploymentStrategyState<'DeploymentDurationInMinutes, 'GrowthFactor, 'Name, 'ReplicateTo>

        member _.Run(state: AppconfigDeploymentStrategyState<Present, Present, Present, Present>) : aws.AppconfigDeploymentStrategy.AppconfigDeploymentStrategy =
            let config = aws.AppconfigDeploymentStrategy.AppconfigDeploymentStrategyConfig()
            for setter in state.assignments do
                setter config
            aws.AppconfigDeploymentStrategy.AppconfigDeploymentStrategy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appconfigDeploymentStrategy: missing required arguments. Must call: deployment_duration_in_minutes, growth_factor, name, replicate_to.", 9999, IsError = true)>]
        member _.Run(_: AppconfigDeploymentStrategyState<_, _, _, _>) : aws.AppconfigDeploymentStrategy.AppconfigDeploymentStrategy =
            Unchecked.defaultof<aws.AppconfigDeploymentStrategy.AppconfigDeploymentStrategy>
