namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAlbTargetGroupState = { assignments: ResizeArray<aws.DataAwsAlbTargetGroup.DataAwsAlbTargetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_target_group">aws_alb_target_group</a>.
    /// </summary>
    type DataAwsAlbTargetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAlbTargetGroupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsAlbTargetGroupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_target_group#arn-1">DataAwsAlbTargetGroup#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsAlbTargetGroupState, value: string) : DataAwsAlbTargetGroupState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsAlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_target_group#id-1">DataAwsAlbTargetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAlbTargetGroupState, value: string) : DataAwsAlbTargetGroupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_target_group#load_balancing_anomaly_mitigation-1">DataAwsAlbTargetGroup#load_balancing_anomaly_mitigation</a>.
        /// </summary>
        [<CustomOperation "load_balancing_anomaly_mitigation">]
        member _.LoadBalancingAnomalyMitigation(state: DataAwsAlbTargetGroupState, value: string) : DataAwsAlbTargetGroupState =
            state.assignments.Add(fun config -> config.LoadBalancingAnomalyMitigation <- value)
            state : DataAwsAlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_target_group#name-1">DataAwsAlbTargetGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsAlbTargetGroupState, value: string) : DataAwsAlbTargetGroupState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsAlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_target_group#tags-1">DataAwsAlbTargetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsAlbTargetGroupState, value: seq<string * string>) : DataAwsAlbTargetGroupState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsAlbTargetGroupState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_target_group#timeouts-1">DataAwsAlbTargetGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsAlbTargetGroupState, value: aws.DataAwsAlbTargetGroup.DataAwsAlbTargetGroupTimeouts) : DataAwsAlbTargetGroupState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsAlbTargetGroupState

        member _.Run(state: DataAwsAlbTargetGroupState) : aws.DataAwsAlbTargetGroup.DataAwsAlbTargetGroup =
            let config = aws.DataAwsAlbTargetGroup.DataAwsAlbTargetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAlbTargetGroup.DataAwsAlbTargetGroup(StackContext.get (), logicalId, config)
