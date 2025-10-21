namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2ClientVpnRouteState<'ClientVpnEndpointId, 'DestinationCidrBlock, 'TargetVpcSubnetId> = { assignments: ResizeArray<aws.Ec2ClientVpnRoute.Ec2ClientVpnRouteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_route">aws_ec2_client_vpn_route</a>.
    /// </summary>
    type Ec2ClientVpnRouteBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2ClientVpnRouteState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2ClientVpnRouteState<Missing, Missing, Missing>)

        member _.Zero(()) : Ec2ClientVpnRouteState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2ClientVpnRouteState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_route#client_vpn_endpoint_id-1">Ec2ClientVpnRoute#client_vpn_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "client_vpn_endpoint_id">]
        member _.ClientVpnEndpointId(state: Ec2ClientVpnRouteState<Missing, 'DestinationCidrBlock, 'TargetVpcSubnetId>, value: string) : Ec2ClientVpnRouteState<Present, 'DestinationCidrBlock, 'TargetVpcSubnetId> =
            state.assignments.Add(fun config -> config.ClientVpnEndpointId <- value)
            ({ assignments = state.assignments } : Ec2ClientVpnRouteState<Present, 'DestinationCidrBlock, 'TargetVpcSubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_route#destination_cidr_block-1">Ec2ClientVpnRoute#destination_cidr_block</a>.
        /// </summary>
        [<CustomOperation "destination_cidr_block">]
        member _.DestinationCidrBlock(state: Ec2ClientVpnRouteState<'ClientVpnEndpointId, Missing, 'TargetVpcSubnetId>, value: string) : Ec2ClientVpnRouteState<'ClientVpnEndpointId, Present, 'TargetVpcSubnetId> =
            state.assignments.Add(fun config -> config.DestinationCidrBlock <- value)
            ({ assignments = state.assignments } : Ec2ClientVpnRouteState<'ClientVpnEndpointId, Present, 'TargetVpcSubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_route#target_vpc_subnet_id-1">Ec2ClientVpnRoute#target_vpc_subnet_id</a>.
        /// </summary>
        [<CustomOperation "target_vpc_subnet_id">]
        member _.TargetVpcSubnetId(state: Ec2ClientVpnRouteState<'ClientVpnEndpointId, 'DestinationCidrBlock, Missing>, value: string) : Ec2ClientVpnRouteState<'ClientVpnEndpointId, 'DestinationCidrBlock, Present> =
            state.assignments.Add(fun config -> config.TargetVpcSubnetId <- value)
            ({ assignments = state.assignments } : Ec2ClientVpnRouteState<'ClientVpnEndpointId, 'DestinationCidrBlock, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_route#description-1">Ec2ClientVpnRoute#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Ec2ClientVpnRouteState<'ClientVpnEndpointId, 'DestinationCidrBlock, 'TargetVpcSubnetId>, value: string) : Ec2ClientVpnRouteState<'ClientVpnEndpointId, 'DestinationCidrBlock, 'TargetVpcSubnetId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Ec2ClientVpnRouteState<'ClientVpnEndpointId, 'DestinationCidrBlock, 'TargetVpcSubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_route#id-1">Ec2ClientVpnRoute#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2ClientVpnRouteState<'ClientVpnEndpointId, 'DestinationCidrBlock, 'TargetVpcSubnetId>, value: string) : Ec2ClientVpnRouteState<'ClientVpnEndpointId, 'DestinationCidrBlock, 'TargetVpcSubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2ClientVpnRouteState<'ClientVpnEndpointId, 'DestinationCidrBlock, 'TargetVpcSubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_route#timeouts-1">Ec2ClientVpnRoute#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2ClientVpnRouteState<'ClientVpnEndpointId, 'DestinationCidrBlock, 'TargetVpcSubnetId>, value: aws.Ec2ClientVpnRoute.Ec2ClientVpnRouteTimeouts) : Ec2ClientVpnRouteState<'ClientVpnEndpointId, 'DestinationCidrBlock, 'TargetVpcSubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2ClientVpnRouteState<'ClientVpnEndpointId, 'DestinationCidrBlock, 'TargetVpcSubnetId>

        member _.Run(state: Ec2ClientVpnRouteState<Present, Present, Present>) : aws.Ec2ClientVpnRoute.Ec2ClientVpnRoute =
            let config = aws.Ec2ClientVpnRoute.Ec2ClientVpnRouteConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2ClientVpnRoute.Ec2ClientVpnRoute(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2ClientVpnRoute: missing required arguments. Must call: client_vpn_endpoint_id, destination_cidr_block, target_vpc_subnet_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2ClientVpnRouteState<_, _, _>) : aws.Ec2ClientVpnRoute.Ec2ClientVpnRoute =
            Unchecked.defaultof<aws.Ec2ClientVpnRoute.Ec2ClientVpnRoute>
