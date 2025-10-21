namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayMulticastGroupMemberState<'GroupIpAddress, 'NetworkInterfaceId, 'TransitGatewayMulticastDomainId> = { assignments: ResizeArray<aws.Ec2TransitGatewayMulticastGroupMember.Ec2TransitGatewayMulticastGroupMemberConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_group_member">aws_ec2_transit_gateway_multicast_group_member</a>.
    /// </summary>
    type Ec2TransitGatewayMulticastGroupMemberBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayMulticastGroupMemberState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayMulticastGroupMemberState<Missing, Missing, Missing>)

        member _.Zero(()) : Ec2TransitGatewayMulticastGroupMemberState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayMulticastGroupMemberState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_group_member#group_ip_address-1">Ec2TransitGatewayMulticastGroupMember#group_ip_address</a>.
        /// </summary>
        [<CustomOperation "group_ip_address">]
        member _.GroupIpAddress(state: Ec2TransitGatewayMulticastGroupMemberState<Missing, 'NetworkInterfaceId, 'TransitGatewayMulticastDomainId>, value: string) : Ec2TransitGatewayMulticastGroupMemberState<Present, 'NetworkInterfaceId, 'TransitGatewayMulticastDomainId> =
            state.assignments.Add(fun config -> config.GroupIpAddress <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayMulticastGroupMemberState<Present, 'NetworkInterfaceId, 'TransitGatewayMulticastDomainId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_group_member#network_interface_id-1">Ec2TransitGatewayMulticastGroupMember#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: Ec2TransitGatewayMulticastGroupMemberState<'GroupIpAddress, Missing, 'TransitGatewayMulticastDomainId>, value: string) : Ec2TransitGatewayMulticastGroupMemberState<'GroupIpAddress, Present, 'TransitGatewayMulticastDomainId> =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayMulticastGroupMemberState<'GroupIpAddress, Present, 'TransitGatewayMulticastDomainId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_group_member#transit_gateway_multicast_domain_id-1">Ec2TransitGatewayMulticastGroupMember#transit_gateway_multicast_domain_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_multicast_domain_id">]
        member _.TransitGatewayMulticastDomainId(state: Ec2TransitGatewayMulticastGroupMemberState<'GroupIpAddress, 'NetworkInterfaceId, Missing>, value: string) : Ec2TransitGatewayMulticastGroupMemberState<'GroupIpAddress, 'NetworkInterfaceId, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayMulticastDomainId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayMulticastGroupMemberState<'GroupIpAddress, 'NetworkInterfaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_group_member#id-1">Ec2TransitGatewayMulticastGroupMember#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayMulticastGroupMemberState<'GroupIpAddress, 'NetworkInterfaceId, 'TransitGatewayMulticastDomainId>, value: string) : Ec2TransitGatewayMulticastGroupMemberState<'GroupIpAddress, 'NetworkInterfaceId, 'TransitGatewayMulticastDomainId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayMulticastGroupMemberState<'GroupIpAddress, 'NetworkInterfaceId, 'TransitGatewayMulticastDomainId>

        member _.Run(state: Ec2TransitGatewayMulticastGroupMemberState<Present, Present, Present>) : aws.Ec2TransitGatewayMulticastGroupMember.Ec2TransitGatewayMulticastGroupMember =
            let config = aws.Ec2TransitGatewayMulticastGroupMember.Ec2TransitGatewayMulticastGroupMemberConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayMulticastGroupMember.Ec2TransitGatewayMulticastGroupMember(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayMulticastGroupMember: missing required arguments. Must call: group_ip_address, network_interface_id, transit_gateway_multicast_domain_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayMulticastGroupMemberState<_, _, _>) : aws.Ec2TransitGatewayMulticastGroupMember.Ec2TransitGatewayMulticastGroupMember =
            Unchecked.defaultof<aws.Ec2TransitGatewayMulticastGroupMember.Ec2TransitGatewayMulticastGroupMember>
