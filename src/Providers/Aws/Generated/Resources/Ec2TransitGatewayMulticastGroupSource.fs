namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayMulticastGroupSourceState<'GroupIpAddress, 'NetworkInterfaceId, 'TransitGatewayMulticastDomainId> = { assignments: ResizeArray<aws.Ec2TransitGatewayMulticastGroupSource.Ec2TransitGatewayMulticastGroupSourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_group_source">aws_ec2_transit_gateway_multicast_group_source</a>.
    /// </summary>
    type Ec2TransitGatewayMulticastGroupSourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayMulticastGroupSourceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayMulticastGroupSourceState<Missing, Missing, Missing>)

        member _.Zero(()) : Ec2TransitGatewayMulticastGroupSourceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayMulticastGroupSourceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_group_source#group_ip_address-1">Ec2TransitGatewayMulticastGroupSource#group_ip_address</a>.
        /// </summary>
        [<CustomOperation "group_ip_address">]
        member _.GroupIpAddress(state: Ec2TransitGatewayMulticastGroupSourceState<Missing, 'NetworkInterfaceId, 'TransitGatewayMulticastDomainId>, value: string) : Ec2TransitGatewayMulticastGroupSourceState<Present, 'NetworkInterfaceId, 'TransitGatewayMulticastDomainId> =
            state.assignments.Add(fun config -> config.GroupIpAddress <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayMulticastGroupSourceState<Present, 'NetworkInterfaceId, 'TransitGatewayMulticastDomainId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_group_source#network_interface_id-1">Ec2TransitGatewayMulticastGroupSource#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: Ec2TransitGatewayMulticastGroupSourceState<'GroupIpAddress, Missing, 'TransitGatewayMulticastDomainId>, value: string) : Ec2TransitGatewayMulticastGroupSourceState<'GroupIpAddress, Present, 'TransitGatewayMulticastDomainId> =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayMulticastGroupSourceState<'GroupIpAddress, Present, 'TransitGatewayMulticastDomainId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_group_source#transit_gateway_multicast_domain_id-1">Ec2TransitGatewayMulticastGroupSource#transit_gateway_multicast_domain_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_multicast_domain_id">]
        member _.TransitGatewayMulticastDomainId(state: Ec2TransitGatewayMulticastGroupSourceState<'GroupIpAddress, 'NetworkInterfaceId, Missing>, value: string) : Ec2TransitGatewayMulticastGroupSourceState<'GroupIpAddress, 'NetworkInterfaceId, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayMulticastDomainId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayMulticastGroupSourceState<'GroupIpAddress, 'NetworkInterfaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_group_source#id-1">Ec2TransitGatewayMulticastGroupSource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayMulticastGroupSourceState<'GroupIpAddress, 'NetworkInterfaceId, 'TransitGatewayMulticastDomainId>, value: string) : Ec2TransitGatewayMulticastGroupSourceState<'GroupIpAddress, 'NetworkInterfaceId, 'TransitGatewayMulticastDomainId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayMulticastGroupSourceState<'GroupIpAddress, 'NetworkInterfaceId, 'TransitGatewayMulticastDomainId>

        member _.Run(state: Ec2TransitGatewayMulticastGroupSourceState<Present, Present, Present>) : aws.Ec2TransitGatewayMulticastGroupSource.Ec2TransitGatewayMulticastGroupSource =
            let config = aws.Ec2TransitGatewayMulticastGroupSource.Ec2TransitGatewayMulticastGroupSourceConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayMulticastGroupSource.Ec2TransitGatewayMulticastGroupSource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayMulticastGroupSource: missing required arguments. Must call: group_ip_address, network_interface_id, transit_gateway_multicast_domain_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayMulticastGroupSourceState<_, _, _>) : aws.Ec2TransitGatewayMulticastGroupSource.Ec2TransitGatewayMulticastGroupSource =
            Unchecked.defaultof<aws.Ec2TransitGatewayMulticastGroupSource.Ec2TransitGatewayMulticastGroupSource>
