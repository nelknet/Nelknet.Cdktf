namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayVpcAttachmentsState = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayVpcAttachments.DataAwsEc2TransitGatewayVpcAttachmentsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpc_attachments">aws_ec2_transit_gateway_vpc_attachments</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayVpcAttachmentsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayVpcAttachmentsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2TransitGatewayVpcAttachmentsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpc_attachments#filter-1">DataAwsEc2TransitGatewayVpcAttachments#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayVpcAttachments.DataAwsEc2TransitGatewayVpcAttachmentsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayVpcAttachmentsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayVpcAttachmentsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayVpcAttachmentsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpc_attachments#id-1">DataAwsEc2TransitGatewayVpcAttachments#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayVpcAttachmentsState, value: string) : DataAwsEc2TransitGatewayVpcAttachmentsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayVpcAttachmentsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpc_attachments#timeouts-1">DataAwsEc2TransitGatewayVpcAttachments#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2TransitGatewayVpcAttachmentsState, value: aws.DataAwsEc2TransitGatewayVpcAttachments.DataAwsEc2TransitGatewayVpcAttachmentsTimeouts) : DataAwsEc2TransitGatewayVpcAttachmentsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2TransitGatewayVpcAttachmentsState

        member _.Run(state: DataAwsEc2TransitGatewayVpcAttachmentsState) : aws.DataAwsEc2TransitGatewayVpcAttachments.DataAwsEc2TransitGatewayVpcAttachments =
            let config = aws.DataAwsEc2TransitGatewayVpcAttachments.DataAwsEc2TransitGatewayVpcAttachmentsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayVpcAttachments.DataAwsEc2TransitGatewayVpcAttachments(StackContext.get (), logicalId, config)
