namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayAttachmentState = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayAttachment.DataAwsEc2TransitGatewayAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachment">aws_ec2_transit_gateway_attachment</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayAttachmentState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2TransitGatewayAttachmentState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachment#filter-1">DataAwsEc2TransitGatewayAttachment#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayAttachment.DataAwsEc2TransitGatewayAttachmentFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayAttachmentState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayAttachmentState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayAttachmentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachment#id-1">DataAwsEc2TransitGatewayAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayAttachmentState, value: string) : DataAwsEc2TransitGatewayAttachmentState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayAttachmentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachment#tags-1">DataAwsEc2TransitGatewayAttachment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2TransitGatewayAttachmentState, value: seq<string * string>) : DataAwsEc2TransitGatewayAttachmentState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2TransitGatewayAttachmentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachment#transit_gateway_attachment_id-1">DataAwsEc2TransitGatewayAttachment#transit_gateway_attachment_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_attachment_id">]
        member _.TransitGatewayAttachmentId(state: DataAwsEc2TransitGatewayAttachmentState, value: string) : DataAwsEc2TransitGatewayAttachmentState =
            state.assignments.Add(fun config -> config.TransitGatewayAttachmentId <- value)
            state : DataAwsEc2TransitGatewayAttachmentState

        member _.Run(state: DataAwsEc2TransitGatewayAttachmentState) : aws.DataAwsEc2TransitGatewayAttachment.DataAwsEc2TransitGatewayAttachment =
            let config = aws.DataAwsEc2TransitGatewayAttachment.DataAwsEc2TransitGatewayAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayAttachment.DataAwsEc2TransitGatewayAttachment(StackContext.get (), logicalId, config)
