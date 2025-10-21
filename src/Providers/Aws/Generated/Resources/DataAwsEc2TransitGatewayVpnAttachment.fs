namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayVpnAttachmentState = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayVpnAttachment.DataAwsEc2TransitGatewayVpnAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpn_attachment">aws_ec2_transit_gateway_vpn_attachment</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayVpnAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayVpnAttachmentState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2TransitGatewayVpnAttachmentState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpn_attachment#filter-1">DataAwsEc2TransitGatewayVpnAttachment#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayVpnAttachment.DataAwsEc2TransitGatewayVpnAttachmentFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayVpnAttachmentState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayVpnAttachmentState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayVpnAttachmentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpn_attachment#id-1">DataAwsEc2TransitGatewayVpnAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayVpnAttachmentState, value: string) : DataAwsEc2TransitGatewayVpnAttachmentState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayVpnAttachmentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpn_attachment#tags-1">DataAwsEc2TransitGatewayVpnAttachment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2TransitGatewayVpnAttachmentState, value: seq<string * string>) : DataAwsEc2TransitGatewayVpnAttachmentState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2TransitGatewayVpnAttachmentState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpn_attachment#timeouts-1">DataAwsEc2TransitGatewayVpnAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2TransitGatewayVpnAttachmentState, value: aws.DataAwsEc2TransitGatewayVpnAttachment.DataAwsEc2TransitGatewayVpnAttachmentTimeouts) : DataAwsEc2TransitGatewayVpnAttachmentState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2TransitGatewayVpnAttachmentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpn_attachment#transit_gateway_id-1">DataAwsEc2TransitGatewayVpnAttachment#transit_gateway_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_id">]
        member _.TransitGatewayId(state: DataAwsEc2TransitGatewayVpnAttachmentState, value: string) : DataAwsEc2TransitGatewayVpnAttachmentState =
            state.assignments.Add(fun config -> config.TransitGatewayId <- value)
            state : DataAwsEc2TransitGatewayVpnAttachmentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpn_attachment#vpn_connection_id-1">DataAwsEc2TransitGatewayVpnAttachment#vpn_connection_id</a>.
        /// </summary>
        [<CustomOperation "vpn_connection_id">]
        member _.VpnConnectionId(state: DataAwsEc2TransitGatewayVpnAttachmentState, value: string) : DataAwsEc2TransitGatewayVpnAttachmentState =
            state.assignments.Add(fun config -> config.VpnConnectionId <- value)
            state : DataAwsEc2TransitGatewayVpnAttachmentState

        member _.Run(state: DataAwsEc2TransitGatewayVpnAttachmentState) : aws.DataAwsEc2TransitGatewayVpnAttachment.DataAwsEc2TransitGatewayVpnAttachment =
            let config = aws.DataAwsEc2TransitGatewayVpnAttachment.DataAwsEc2TransitGatewayVpnAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayVpnAttachment.DataAwsEc2TransitGatewayVpnAttachment(StackContext.get (), logicalId, config)
