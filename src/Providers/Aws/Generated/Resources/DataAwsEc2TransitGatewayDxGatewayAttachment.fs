namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayDxGatewayAttachmentState = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayDxGatewayAttachment.DataAwsEc2TransitGatewayDxGatewayAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_dx_gateway_attachment">aws_ec2_transit_gateway_dx_gateway_attachment</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayDxGatewayAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayDxGatewayAttachmentState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2TransitGatewayDxGatewayAttachmentState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_dx_gateway_attachment#dx_gateway_id-1">DataAwsEc2TransitGatewayDxGatewayAttachment#dx_gateway_id</a>.
        /// </summary>
        [<CustomOperation "dx_gateway_id">]
        member _.DxGatewayId(state: DataAwsEc2TransitGatewayDxGatewayAttachmentState, value: string) : DataAwsEc2TransitGatewayDxGatewayAttachmentState =
            state.assignments.Add(fun config -> config.DxGatewayId <- value)
            state : DataAwsEc2TransitGatewayDxGatewayAttachmentState

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_dx_gateway_attachment#filter-1">DataAwsEc2TransitGatewayDxGatewayAttachment#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayDxGatewayAttachment.DataAwsEc2TransitGatewayDxGatewayAttachmentFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayDxGatewayAttachmentState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayDxGatewayAttachmentState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayDxGatewayAttachmentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_dx_gateway_attachment#id-1">DataAwsEc2TransitGatewayDxGatewayAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayDxGatewayAttachmentState, value: string) : DataAwsEc2TransitGatewayDxGatewayAttachmentState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayDxGatewayAttachmentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_dx_gateway_attachment#tags-1">DataAwsEc2TransitGatewayDxGatewayAttachment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2TransitGatewayDxGatewayAttachmentState, value: seq<string * string>) : DataAwsEc2TransitGatewayDxGatewayAttachmentState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2TransitGatewayDxGatewayAttachmentState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_dx_gateway_attachment#timeouts-1">DataAwsEc2TransitGatewayDxGatewayAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2TransitGatewayDxGatewayAttachmentState, value: aws.DataAwsEc2TransitGatewayDxGatewayAttachment.DataAwsEc2TransitGatewayDxGatewayAttachmentTimeouts) : DataAwsEc2TransitGatewayDxGatewayAttachmentState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2TransitGatewayDxGatewayAttachmentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_dx_gateway_attachment#transit_gateway_id-1">DataAwsEc2TransitGatewayDxGatewayAttachment#transit_gateway_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_id">]
        member _.TransitGatewayId(state: DataAwsEc2TransitGatewayDxGatewayAttachmentState, value: string) : DataAwsEc2TransitGatewayDxGatewayAttachmentState =
            state.assignments.Add(fun config -> config.TransitGatewayId <- value)
            state : DataAwsEc2TransitGatewayDxGatewayAttachmentState

        member _.Run(state: DataAwsEc2TransitGatewayDxGatewayAttachmentState) : aws.DataAwsEc2TransitGatewayDxGatewayAttachment.DataAwsEc2TransitGatewayDxGatewayAttachment =
            let config = aws.DataAwsEc2TransitGatewayDxGatewayAttachment.DataAwsEc2TransitGatewayDxGatewayAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayDxGatewayAttachment.DataAwsEc2TransitGatewayDxGatewayAttachment(StackContext.get (), logicalId, config)
