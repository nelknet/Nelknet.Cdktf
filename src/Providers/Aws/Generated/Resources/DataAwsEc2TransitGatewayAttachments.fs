namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayAttachmentsState = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayAttachments.DataAwsEc2TransitGatewayAttachmentsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachments">aws_ec2_transit_gateway_attachments</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayAttachmentsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayAttachmentsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2TransitGatewayAttachmentsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachments#filter-1">DataAwsEc2TransitGatewayAttachments#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayAttachments.DataAwsEc2TransitGatewayAttachmentsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayAttachmentsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayAttachmentsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayAttachmentsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachments#id-1">DataAwsEc2TransitGatewayAttachments#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayAttachmentsState, value: string) : DataAwsEc2TransitGatewayAttachmentsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayAttachmentsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachments#tags-1">DataAwsEc2TransitGatewayAttachments#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2TransitGatewayAttachmentsState, value: seq<string * string>) : DataAwsEc2TransitGatewayAttachmentsState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2TransitGatewayAttachmentsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachments#timeouts-1">DataAwsEc2TransitGatewayAttachments#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2TransitGatewayAttachmentsState, value: aws.DataAwsEc2TransitGatewayAttachments.DataAwsEc2TransitGatewayAttachmentsTimeouts) : DataAwsEc2TransitGatewayAttachmentsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2TransitGatewayAttachmentsState

        member _.Run(state: DataAwsEc2TransitGatewayAttachmentsState) : aws.DataAwsEc2TransitGatewayAttachments.DataAwsEc2TransitGatewayAttachments =
            let config = aws.DataAwsEc2TransitGatewayAttachments.DataAwsEc2TransitGatewayAttachmentsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayAttachments.DataAwsEc2TransitGatewayAttachments(StackContext.get (), logicalId, config)
