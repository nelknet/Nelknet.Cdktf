namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayPeeringAttachmentsState = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayPeeringAttachments.DataAwsEc2TransitGatewayPeeringAttachmentsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_peering_attachments">aws_ec2_transit_gateway_peering_attachments</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayPeeringAttachmentsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayPeeringAttachmentsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2TransitGatewayPeeringAttachmentsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_peering_attachments#filter-1">DataAwsEc2TransitGatewayPeeringAttachments#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayPeeringAttachments.DataAwsEc2TransitGatewayPeeringAttachmentsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayPeeringAttachmentsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayPeeringAttachmentsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayPeeringAttachmentsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_peering_attachments#id-1">DataAwsEc2TransitGatewayPeeringAttachments#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayPeeringAttachmentsState, value: string) : DataAwsEc2TransitGatewayPeeringAttachmentsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayPeeringAttachmentsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_peering_attachments#timeouts-1">DataAwsEc2TransitGatewayPeeringAttachments#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2TransitGatewayPeeringAttachmentsState, value: aws.DataAwsEc2TransitGatewayPeeringAttachments.DataAwsEc2TransitGatewayPeeringAttachmentsTimeouts) : DataAwsEc2TransitGatewayPeeringAttachmentsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2TransitGatewayPeeringAttachmentsState

        member _.Run(state: DataAwsEc2TransitGatewayPeeringAttachmentsState) : aws.DataAwsEc2TransitGatewayPeeringAttachments.DataAwsEc2TransitGatewayPeeringAttachments =
            let config = aws.DataAwsEc2TransitGatewayPeeringAttachments.DataAwsEc2TransitGatewayPeeringAttachmentsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayPeeringAttachments.DataAwsEc2TransitGatewayPeeringAttachments(StackContext.get (), logicalId, config)
