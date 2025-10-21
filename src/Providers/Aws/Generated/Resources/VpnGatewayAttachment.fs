namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpnGatewayAttachmentState<'VpcId, 'VpnGatewayId> = { assignments: ResizeArray<aws.VpnGatewayAttachment.VpnGatewayAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway_attachment">aws_vpn_gateway_attachment</a>.
    /// </summary>
    type VpnGatewayAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpnGatewayAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnGatewayAttachmentState<Missing, Missing>)

        member _.Zero(()) : VpnGatewayAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnGatewayAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway_attachment#vpc_id-1">VpnGatewayAttachment#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: VpnGatewayAttachmentState<Missing, 'VpnGatewayId>, value: string) : VpnGatewayAttachmentState<Present, 'VpnGatewayId> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : VpnGatewayAttachmentState<Present, 'VpnGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway_attachment#vpn_gateway_id-1">VpnGatewayAttachment#vpn_gateway_id</a>.
        /// </summary>
        [<CustomOperation "vpn_gateway_id">]
        member _.VpnGatewayId(state: VpnGatewayAttachmentState<'VpcId, Missing>, value: string) : VpnGatewayAttachmentState<'VpcId, Present> =
            state.assignments.Add(fun config -> config.VpnGatewayId <- value)
            ({ assignments = state.assignments } : VpnGatewayAttachmentState<'VpcId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway_attachment#id-1">VpnGatewayAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpnGatewayAttachmentState<'VpcId, 'VpnGatewayId>, value: string) : VpnGatewayAttachmentState<'VpcId, 'VpnGatewayId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpnGatewayAttachmentState<'VpcId, 'VpnGatewayId>

        member _.Run(state: VpnGatewayAttachmentState<Present, Present>) : aws.VpnGatewayAttachment.VpnGatewayAttachment =
            let config = aws.VpnGatewayAttachment.VpnGatewayAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.VpnGatewayAttachment.VpnGatewayAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpnGatewayAttachment: missing required arguments. Must call: vpc_id, vpn_gateway_id.", 9999, IsError = true)>]
        member _.Run(_: VpnGatewayAttachmentState<_, _>) : aws.VpnGatewayAttachment.VpnGatewayAttachment =
            Unchecked.defaultof<aws.VpnGatewayAttachment.VpnGatewayAttachment>
