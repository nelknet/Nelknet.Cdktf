namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2ClientVpnNetworkAssociationState<'ClientVpnEndpointId, 'SubnetId> = { assignments: ResizeArray<aws.Ec2ClientVpnNetworkAssociation.Ec2ClientVpnNetworkAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_network_association">aws_ec2_client_vpn_network_association</a>.
    /// </summary>
    type Ec2ClientVpnNetworkAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2ClientVpnNetworkAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2ClientVpnNetworkAssociationState<Missing, Missing>)

        member _.Zero(()) : Ec2ClientVpnNetworkAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2ClientVpnNetworkAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_network_association#client_vpn_endpoint_id-1">Ec2ClientVpnNetworkAssociation#client_vpn_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "client_vpn_endpoint_id">]
        member _.ClientVpnEndpointId(state: Ec2ClientVpnNetworkAssociationState<Missing, 'SubnetId>, value: string) : Ec2ClientVpnNetworkAssociationState<Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.ClientVpnEndpointId <- value)
            ({ assignments = state.assignments } : Ec2ClientVpnNetworkAssociationState<Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_network_association#subnet_id-1">Ec2ClientVpnNetworkAssociation#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: Ec2ClientVpnNetworkAssociationState<'ClientVpnEndpointId, Missing>, value: string) : Ec2ClientVpnNetworkAssociationState<'ClientVpnEndpointId, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : Ec2ClientVpnNetworkAssociationState<'ClientVpnEndpointId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_network_association#id-1">Ec2ClientVpnNetworkAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2ClientVpnNetworkAssociationState<'ClientVpnEndpointId, 'SubnetId>, value: string) : Ec2ClientVpnNetworkAssociationState<'ClientVpnEndpointId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2ClientVpnNetworkAssociationState<'ClientVpnEndpointId, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_network_association#timeouts-1">Ec2ClientVpnNetworkAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2ClientVpnNetworkAssociationState<'ClientVpnEndpointId, 'SubnetId>, value: aws.Ec2ClientVpnNetworkAssociation.Ec2ClientVpnNetworkAssociationTimeouts) : Ec2ClientVpnNetworkAssociationState<'ClientVpnEndpointId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2ClientVpnNetworkAssociationState<'ClientVpnEndpointId, 'SubnetId>

        member _.Run(state: Ec2ClientVpnNetworkAssociationState<Present, Present>) : aws.Ec2ClientVpnNetworkAssociation.Ec2ClientVpnNetworkAssociation =
            let config = aws.Ec2ClientVpnNetworkAssociation.Ec2ClientVpnNetworkAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2ClientVpnNetworkAssociation.Ec2ClientVpnNetworkAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2ClientVpnNetworkAssociation: missing required arguments. Must call: client_vpn_endpoint_id, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2ClientVpnNetworkAssociationState<_, _>) : aws.Ec2ClientVpnNetworkAssociation.Ec2ClientVpnNetworkAssociation =
            Unchecked.defaultof<aws.Ec2ClientVpnNetworkAssociation.Ec2ClientVpnNetworkAssociation>
