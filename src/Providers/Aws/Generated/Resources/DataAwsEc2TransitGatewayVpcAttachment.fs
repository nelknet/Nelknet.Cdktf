namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayVpcAttachmentState = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayVpcAttachment.DataAwsEc2TransitGatewayVpcAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpc_attachment">aws_ec2_transit_gateway_vpc_attachment</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayVpcAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayVpcAttachmentState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2TransitGatewayVpcAttachmentState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpc_attachment#filter-1">DataAwsEc2TransitGatewayVpcAttachment#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayVpcAttachment.DataAwsEc2TransitGatewayVpcAttachmentFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayVpcAttachmentState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayVpcAttachmentState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayVpcAttachmentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpc_attachment#id-1">DataAwsEc2TransitGatewayVpcAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayVpcAttachmentState, value: string) : DataAwsEc2TransitGatewayVpcAttachmentState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayVpcAttachmentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpc_attachment#tags-1">DataAwsEc2TransitGatewayVpcAttachment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2TransitGatewayVpcAttachmentState, value: seq<string * string>) : DataAwsEc2TransitGatewayVpcAttachmentState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2TransitGatewayVpcAttachmentState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpc_attachment#timeouts-1">DataAwsEc2TransitGatewayVpcAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2TransitGatewayVpcAttachmentState, value: aws.DataAwsEc2TransitGatewayVpcAttachment.DataAwsEc2TransitGatewayVpcAttachmentTimeouts) : DataAwsEc2TransitGatewayVpcAttachmentState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2TransitGatewayVpcAttachmentState

        member _.Run(state: DataAwsEc2TransitGatewayVpcAttachmentState) : aws.DataAwsEc2TransitGatewayVpcAttachment.DataAwsEc2TransitGatewayVpcAttachment =
            let config = aws.DataAwsEc2TransitGatewayVpcAttachment.DataAwsEc2TransitGatewayVpcAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayVpcAttachment.DataAwsEc2TransitGatewayVpcAttachment(StackContext.get (), logicalId, config)
