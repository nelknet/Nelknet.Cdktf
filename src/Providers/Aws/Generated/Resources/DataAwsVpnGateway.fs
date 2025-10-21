namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpnGatewayState = { assignments: ResizeArray<aws.DataAwsVpnGateway.DataAwsVpnGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpn_gateway">aws_vpn_gateway</a>.
    /// </summary>
    type DataAwsVpnGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpnGatewayState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsVpnGatewayState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpn_gateway#amazon_side_asn-1">DataAwsVpnGateway#amazon_side_asn</a>.
        /// </summary>
        [<CustomOperation "amazon_side_asn">]
        member _.AmazonSideAsn(state: DataAwsVpnGatewayState, value: string) : DataAwsVpnGatewayState =
            state.assignments.Add(fun config -> config.AmazonSideAsn <- value)
            state : DataAwsVpnGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpn_gateway#attached_vpc_id-1">DataAwsVpnGateway#attached_vpc_id</a>.
        /// </summary>
        [<CustomOperation "attached_vpc_id">]
        member _.AttachedVpcId(state: DataAwsVpnGatewayState, value: string) : DataAwsVpnGatewayState =
            state.assignments.Add(fun config -> config.AttachedVpcId <- value)
            state : DataAwsVpnGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpn_gateway#availability_zone-1">DataAwsVpnGateway#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: DataAwsVpnGatewayState, value: string) : DataAwsVpnGatewayState =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : DataAwsVpnGatewayState

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpn_gateway#filter-1">DataAwsVpnGateway#filter</a> Accepts: aws.IResolvable | aws.DataAwsVpnGateway.DataAwsVpnGatewayFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsVpnGatewayState, value: HashiCorp.Cdktf.IResolvable) : DataAwsVpnGatewayState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsVpnGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpn_gateway#id-1">DataAwsVpnGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpnGatewayState, value: string) : DataAwsVpnGatewayState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpnGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpn_gateway#state-1">DataAwsVpnGateway#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: DataAwsVpnGatewayState, value: string) : DataAwsVpnGatewayState =
            state.assignments.Add(fun config -> config.State <- value)
            state : DataAwsVpnGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpn_gateway#tags-1">DataAwsVpnGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsVpnGatewayState, value: seq<string * string>) : DataAwsVpnGatewayState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsVpnGatewayState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpn_gateway#timeouts-1">DataAwsVpnGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsVpnGatewayState, value: aws.DataAwsVpnGateway.DataAwsVpnGatewayTimeouts) : DataAwsVpnGatewayState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsVpnGatewayState

        member _.Run(state: DataAwsVpnGatewayState) : aws.DataAwsVpnGateway.DataAwsVpnGateway =
            let config = aws.DataAwsVpnGateway.DataAwsVpnGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpnGateway.DataAwsVpnGateway(StackContext.get (), logicalId, config)
