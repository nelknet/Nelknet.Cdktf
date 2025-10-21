namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayPeeringAttachmentState = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayPeeringAttachment.DataAwsEc2TransitGatewayPeeringAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_peering_attachment">aws_ec2_transit_gateway_peering_attachment</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayPeeringAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayPeeringAttachmentState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2TransitGatewayPeeringAttachmentState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_peering_attachment#filter-1">DataAwsEc2TransitGatewayPeeringAttachment#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayPeeringAttachment.DataAwsEc2TransitGatewayPeeringAttachmentFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayPeeringAttachmentState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayPeeringAttachmentState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayPeeringAttachmentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_peering_attachment#id-1">DataAwsEc2TransitGatewayPeeringAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayPeeringAttachmentState, value: string) : DataAwsEc2TransitGatewayPeeringAttachmentState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayPeeringAttachmentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_peering_attachment#tags-1">DataAwsEc2TransitGatewayPeeringAttachment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2TransitGatewayPeeringAttachmentState, value: seq<string * string>) : DataAwsEc2TransitGatewayPeeringAttachmentState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2TransitGatewayPeeringAttachmentState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_peering_attachment#timeouts-1">DataAwsEc2TransitGatewayPeeringAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2TransitGatewayPeeringAttachmentState, value: aws.DataAwsEc2TransitGatewayPeeringAttachment.DataAwsEc2TransitGatewayPeeringAttachmentTimeouts) : DataAwsEc2TransitGatewayPeeringAttachmentState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2TransitGatewayPeeringAttachmentState

        member _.Run(state: DataAwsEc2TransitGatewayPeeringAttachmentState) : aws.DataAwsEc2TransitGatewayPeeringAttachment.DataAwsEc2TransitGatewayPeeringAttachment =
            let config = aws.DataAwsEc2TransitGatewayPeeringAttachment.DataAwsEc2TransitGatewayPeeringAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayPeeringAttachment.DataAwsEc2TransitGatewayPeeringAttachment(StackContext.get (), logicalId, config)
