namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLbTargetGroupState = { assignments: ResizeArray<aws.DataAwsLbTargetGroup.DataAwsLbTargetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_target_group">aws_lb_target_group</a>.
    /// </summary>
    type DataAwsLbTargetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLbTargetGroupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsLbTargetGroupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_target_group#arn-1">DataAwsLbTargetGroup#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsLbTargetGroupState, value: string) : DataAwsLbTargetGroupState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsLbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_target_group#id-1">DataAwsLbTargetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLbTargetGroupState, value: string) : DataAwsLbTargetGroupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_target_group#load_balancing_anomaly_mitigation-1">DataAwsLbTargetGroup#load_balancing_anomaly_mitigation</a>.
        /// </summary>
        [<CustomOperation "load_balancing_anomaly_mitigation">]
        member _.LoadBalancingAnomalyMitigation(state: DataAwsLbTargetGroupState, value: string) : DataAwsLbTargetGroupState =
            state.assignments.Add(fun config -> config.LoadBalancingAnomalyMitigation <- value)
            state : DataAwsLbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_target_group#name-1">DataAwsLbTargetGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsLbTargetGroupState, value: string) : DataAwsLbTargetGroupState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsLbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_target_group#tags-1">DataAwsLbTargetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsLbTargetGroupState, value: seq<string * string>) : DataAwsLbTargetGroupState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsLbTargetGroupState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_target_group#timeouts-1">DataAwsLbTargetGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsLbTargetGroupState, value: aws.DataAwsLbTargetGroup.DataAwsLbTargetGroupTimeouts) : DataAwsLbTargetGroupState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsLbTargetGroupState

        member _.Run(state: DataAwsLbTargetGroupState) : aws.DataAwsLbTargetGroup.DataAwsLbTargetGroup =
            let config = aws.DataAwsLbTargetGroup.DataAwsLbTargetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLbTargetGroup.DataAwsLbTargetGroup(StackContext.get (), logicalId, config)
