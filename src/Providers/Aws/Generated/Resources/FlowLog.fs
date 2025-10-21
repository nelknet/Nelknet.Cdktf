namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FlowLogState = { assignments: ResizeArray<aws.FlowLog.FlowLogConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log">aws_flow_log</a>.
    /// </summary>
    type FlowLogBuilder(logicalId: string) =
        member _.Yield(_: unit) : FlowLogState =
            { assignments = ResizeArray() }

        member _.Zero(()) : FlowLogState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#deliver_cross_account_role-1">FlowLog#deliver_cross_account_role</a>.
        /// </summary>
        [<CustomOperation "deliver_cross_account_role">]
        member _.DeliverCrossAccountRole(state: FlowLogState, value: string) : FlowLogState =
            state.assignments.Add(fun config -> config.DeliverCrossAccountRole <- value)
            state : FlowLogState

        /// <summary>
        /// destination_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#destination_options-1">FlowLog#destination_options</a>
        /// </summary>
        [<CustomOperation "destination_options">]
        member _.DestinationOptions(state: FlowLogState, value: aws.FlowLog.FlowLogDestinationOptions) : FlowLogState =
            state.assignments.Add(fun config -> config.DestinationOptions <- value)
            state : FlowLogState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#eni_id-1">FlowLog#eni_id</a>.
        /// </summary>
        [<CustomOperation "eni_id">]
        member _.EniId(state: FlowLogState, value: string) : FlowLogState =
            state.assignments.Add(fun config -> config.EniId <- value)
            state : FlowLogState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#iam_role_arn-1">FlowLog#iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "iam_role_arn">]
        member _.IamRoleArn(state: FlowLogState, value: string) : FlowLogState =
            state.assignments.Add(fun config -> config.IamRoleArn <- value)
            state : FlowLogState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#id-1">FlowLog#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FlowLogState, value: string) : FlowLogState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FlowLogState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#log_destination-1">FlowLog#log_destination</a>.
        /// </summary>
        [<CustomOperation "log_destination">]
        member _.LogDestination(state: FlowLogState, value: string) : FlowLogState =
            state.assignments.Add(fun config -> config.LogDestination <- value)
            state : FlowLogState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#log_destination_type-1">FlowLog#log_destination_type</a>.
        /// </summary>
        [<CustomOperation "log_destination_type">]
        member _.LogDestinationType(state: FlowLogState, value: string) : FlowLogState =
            state.assignments.Add(fun config -> config.LogDestinationType <- value)
            state : FlowLogState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#log_format-1">FlowLog#log_format</a>.
        /// </summary>
        [<CustomOperation "log_format">]
        member _.LogFormat(state: FlowLogState, value: string) : FlowLogState =
            state.assignments.Add(fun config -> config.LogFormat <- value)
            state : FlowLogState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#log_group_name-1">FlowLog#log_group_name</a>.
        /// </summary>
        [<CustomOperation "log_group_name">]
        member _.LogGroupName(state: FlowLogState, value: string) : FlowLogState =
            state.assignments.Add(fun config -> config.LogGroupName <- value)
            state : FlowLogState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#max_aggregation_interval-1">FlowLog#max_aggregation_interval</a>.
        /// </summary>
        [<CustomOperation "max_aggregation_interval">]
        member _.MaxAggregationInterval(state: FlowLogState, value: double) : FlowLogState =
            state.assignments.Add(fun config -> config.MaxAggregationInterval <- value)
            state : FlowLogState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#subnet_id-1">FlowLog#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: FlowLogState, value: string) : FlowLogState =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : FlowLogState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#tags-1">FlowLog#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FlowLogState, value: seq<string * string>) : FlowLogState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FlowLogState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#tags_all-1">FlowLog#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FlowLogState, value: seq<string * string>) : FlowLogState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FlowLogState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#traffic_type-1">FlowLog#traffic_type</a>.
        /// </summary>
        [<CustomOperation "traffic_type">]
        member _.TrafficType(state: FlowLogState, value: string) : FlowLogState =
            state.assignments.Add(fun config -> config.TrafficType <- value)
            state : FlowLogState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#transit_gateway_attachment_id-1">FlowLog#transit_gateway_attachment_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_attachment_id">]
        member _.TransitGatewayAttachmentId(state: FlowLogState, value: string) : FlowLogState =
            state.assignments.Add(fun config -> config.TransitGatewayAttachmentId <- value)
            state : FlowLogState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#transit_gateway_id-1">FlowLog#transit_gateway_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_id">]
        member _.TransitGatewayId(state: FlowLogState, value: string) : FlowLogState =
            state.assignments.Add(fun config -> config.TransitGatewayId <- value)
            state : FlowLogState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#vpc_id-1">FlowLog#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: FlowLogState, value: string) : FlowLogState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : FlowLogState

        member _.Run(state: FlowLogState) : aws.FlowLog.FlowLog =
            let config = aws.FlowLog.FlowLogConfig()
            for setter in state.assignments do
                setter config
            aws.FlowLog.FlowLog(StackContext.get (), logicalId, config)
