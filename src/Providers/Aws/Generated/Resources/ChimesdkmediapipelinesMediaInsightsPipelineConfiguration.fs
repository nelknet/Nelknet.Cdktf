namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, 'ResourceAccessRoleArn> = { assignments: ResizeArray<aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration">aws_chimesdkmediapipelines_media_insights_pipeline_configuration</a>.
    /// </summary>
    type ChimesdkmediapipelinesMediaInsightsPipelineConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<Missing, Missing, Missing>)

        member _.Zero(()) : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<Missing, Missing, Missing>)

        /// <summary>
        /// elements block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#elements-1">ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#elements</a> Accepts: aws.IResolvable | aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationElements[]
        /// </summary>
        [<CustomOperation "elements">]
        member _.Elements(state: ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<Missing, 'Name, 'ResourceAccessRoleArn>, value: HashiCorp.Cdktf.IResolvable) : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<Present, 'Name, 'ResourceAccessRoleArn> =
            state.assignments.Add(fun config -> config.Elements <- value)
            ({ assignments = state.assignments } : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<Present, 'Name, 'ResourceAccessRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#name-1">ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, Missing, 'ResourceAccessRoleArn>, value: string) : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, Present, 'ResourceAccessRoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, Present, 'ResourceAccessRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#resource_access_role_arn-1">ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#resource_access_role_arn</a>.
        /// </summary>
        [<CustomOperation "resource_access_role_arn">]
        member _.ResourceAccessRoleArn(state: ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, Missing>, value: string) : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceAccessRoleArn <- value)
            ({ assignments = state.assignments } : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, Present>)

        /// <summary>
        /// real_time_alert_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#real_time_alert_configuration-1">ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#real_time_alert_configuration</a>
        /// </summary>
        [<CustomOperation "real_time_alert_configuration">]
        member _.RealTimeAlertConfiguration(state: ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, 'ResourceAccessRoleArn>, value: aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfiguration) : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, 'ResourceAccessRoleArn> =
            state.assignments.Add(fun config -> config.RealTimeAlertConfiguration <- value)
            state : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, 'ResourceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#tags-1">ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, 'ResourceAccessRoleArn>, value: seq<string * string>) : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, 'ResourceAccessRoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, 'ResourceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#tags_all-1">ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, 'ResourceAccessRoleArn>, value: seq<string * string>) : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, 'ResourceAccessRoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, 'ResourceAccessRoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#timeouts-1">ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, 'ResourceAccessRoleArn>, value: aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationTimeouts) : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, 'ResourceAccessRoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<'Elements, 'Name, 'ResourceAccessRoleArn>

        member _.Run(state: ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<Present, Present, Present>) : aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration =
            let config = aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration: missing required arguments. Must call: elements, name, resource_access_role_arn.", 9999, IsError = true)>]
        member _.Run(_: ChimesdkmediapipelinesMediaInsightsPipelineConfigurationState<_, _, _>) : aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration =
            Unchecked.defaultof<aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration>
