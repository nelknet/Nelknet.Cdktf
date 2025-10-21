namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, 'LogGroupName, 'Name> = { assignments: ResizeArray<aws.CloudwatchLogSubscriptionFilter.CloudwatchLogSubscriptionFilterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_subscription_filter">aws_cloudwatch_log_subscription_filter</a>.
    /// </summary>
    type CloudwatchLogSubscriptionFilterBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchLogSubscriptionFilterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogSubscriptionFilterState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CloudwatchLogSubscriptionFilterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogSubscriptionFilterState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_subscription_filter#destination_arn-1">CloudwatchLogSubscriptionFilter#destination_arn</a>.
        /// </summary>
        [<CustomOperation "destination_arn">]
        member _.DestinationArn(state: CloudwatchLogSubscriptionFilterState<Missing, 'FilterPattern, 'LogGroupName, 'Name>, value: string) : CloudwatchLogSubscriptionFilterState<Present, 'FilterPattern, 'LogGroupName, 'Name> =
            state.assignments.Add(fun config -> config.DestinationArn <- value)
            ({ assignments = state.assignments } : CloudwatchLogSubscriptionFilterState<Present, 'FilterPattern, 'LogGroupName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_subscription_filter#filter_pattern-1">CloudwatchLogSubscriptionFilter#filter_pattern</a>.
        /// </summary>
        [<CustomOperation "filter_pattern">]
        member _.FilterPattern(state: CloudwatchLogSubscriptionFilterState<'DestinationArn, Missing, 'LogGroupName, 'Name>, value: string) : CloudwatchLogSubscriptionFilterState<'DestinationArn, Present, 'LogGroupName, 'Name> =
            state.assignments.Add(fun config -> config.FilterPattern <- value)
            ({ assignments = state.assignments } : CloudwatchLogSubscriptionFilterState<'DestinationArn, Present, 'LogGroupName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_subscription_filter#log_group_name-1">CloudwatchLogSubscriptionFilter#log_group_name</a>.
        /// </summary>
        [<CustomOperation "log_group_name">]
        member _.LogGroupName(state: CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, Missing, 'Name>, value: string) : CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, Present, 'Name> =
            state.assignments.Add(fun config -> config.LogGroupName <- value)
            ({ assignments = state.assignments } : CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_subscription_filter#name-1">CloudwatchLogSubscriptionFilter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, 'LogGroupName, Missing>, value: string) : CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, 'LogGroupName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, 'LogGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_subscription_filter#distribution-1">CloudwatchLogSubscriptionFilter#distribution</a>.
        /// </summary>
        [<CustomOperation "distribution">]
        member _.Distribution(state: CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, 'LogGroupName, 'Name>, value: string) : CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, 'LogGroupName, 'Name> =
            state.assignments.Add(fun config -> config.Distribution <- value)
            state : CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, 'LogGroupName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_subscription_filter#id-1">CloudwatchLogSubscriptionFilter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, 'LogGroupName, 'Name>, value: string) : CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, 'LogGroupName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, 'LogGroupName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_subscription_filter#role_arn-1">CloudwatchLogSubscriptionFilter#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, 'LogGroupName, 'Name>, value: string) : CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, 'LogGroupName, 'Name> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : CloudwatchLogSubscriptionFilterState<'DestinationArn, 'FilterPattern, 'LogGroupName, 'Name>

        member _.Run(state: CloudwatchLogSubscriptionFilterState<Present, Present, Present, Present>) : aws.CloudwatchLogSubscriptionFilter.CloudwatchLogSubscriptionFilter =
            let config = aws.CloudwatchLogSubscriptionFilter.CloudwatchLogSubscriptionFilterConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchLogSubscriptionFilter.CloudwatchLogSubscriptionFilter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchLogSubscriptionFilter: missing required arguments. Must call: destination_arn, filter_pattern, log_group_name, name.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchLogSubscriptionFilterState<_, _, _, _>) : aws.CloudwatchLogSubscriptionFilter.CloudwatchLogSubscriptionFilter =
            Unchecked.defaultof<aws.CloudwatchLogSubscriptionFilter.CloudwatchLogSubscriptionFilter>
