namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpnGatewayState = { assignments: ResizeArray<aws.VpnGateway.VpnGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway">aws_vpn_gateway</a>.
    /// </summary>
    type VpnGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpnGatewayState =
            { assignments = ResizeArray() }

        member _.Zero(()) : VpnGatewayState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway#amazon_side_asn-1">VpnGateway#amazon_side_asn</a>.
        /// </summary>
        [<CustomOperation "amazon_side_asn">]
        member _.AmazonSideAsn(state: VpnGatewayState, value: string) : VpnGatewayState =
            state.assignments.Add(fun config -> config.AmazonSideAsn <- value)
            state : VpnGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway#availability_zone-1">VpnGateway#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: VpnGatewayState, value: string) : VpnGatewayState =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : VpnGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway#id-1">VpnGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpnGatewayState, value: string) : VpnGatewayState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpnGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway#tags-1">VpnGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpnGatewayState, value: seq<string * string>) : VpnGatewayState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpnGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway#tags_all-1">VpnGateway#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpnGatewayState, value: seq<string * string>) : VpnGatewayState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpnGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway#vpc_id-1">VpnGateway#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: VpnGatewayState, value: string) : VpnGatewayState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : VpnGatewayState

        member _.Run(state: VpnGatewayState) : aws.VpnGateway.VpnGateway =
            let config = aws.VpnGateway.VpnGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.VpnGateway.VpnGateway(StackContext.get (), logicalId, config)
