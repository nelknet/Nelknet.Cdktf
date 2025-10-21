namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayMulticastDomainAssociationState<'SubnetId, 'TransitGatewayAttachmentId, 'TransitGatewayMulticastDomainId> = { assignments: ResizeArray<aws.Ec2TransitGatewayMulticastDomainAssociation.Ec2TransitGatewayMulticastDomainAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain_association">aws_ec2_transit_gateway_multicast_domain_association</a>.
    /// </summary>
    type Ec2TransitGatewayMulticastDomainAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayMulticastDomainAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayMulticastDomainAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : Ec2TransitGatewayMulticastDomainAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayMulticastDomainAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain_association#subnet_id-1">Ec2TransitGatewayMulticastDomainAssociation#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: Ec2TransitGatewayMulticastDomainAssociationState<Missing, 'TransitGatewayAttachmentId, 'TransitGatewayMulticastDomainId>, value: string) : Ec2TransitGatewayMulticastDomainAssociationState<Present, 'TransitGatewayAttachmentId, 'TransitGatewayMulticastDomainId> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayMulticastDomainAssociationState<Present, 'TransitGatewayAttachmentId, 'TransitGatewayMulticastDomainId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain_association#transit_gateway_attachment_id-1">Ec2TransitGatewayMulticastDomainAssociation#transit_gateway_attachment_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_attachment_id">]
        member _.TransitGatewayAttachmentId(state: Ec2TransitGatewayMulticastDomainAssociationState<'SubnetId, Missing, 'TransitGatewayMulticastDomainId>, value: string) : Ec2TransitGatewayMulticastDomainAssociationState<'SubnetId, Present, 'TransitGatewayMulticastDomainId> =
            state.assignments.Add(fun config -> config.TransitGatewayAttachmentId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayMulticastDomainAssociationState<'SubnetId, Present, 'TransitGatewayMulticastDomainId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain_association#transit_gateway_multicast_domain_id-1">Ec2TransitGatewayMulticastDomainAssociation#transit_gateway_multicast_domain_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_multicast_domain_id">]
        member _.TransitGatewayMulticastDomainId(state: Ec2TransitGatewayMulticastDomainAssociationState<'SubnetId, 'TransitGatewayAttachmentId, Missing>, value: string) : Ec2TransitGatewayMulticastDomainAssociationState<'SubnetId, 'TransitGatewayAttachmentId, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayMulticastDomainId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayMulticastDomainAssociationState<'SubnetId, 'TransitGatewayAttachmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain_association#id-1">Ec2TransitGatewayMulticastDomainAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayMulticastDomainAssociationState<'SubnetId, 'TransitGatewayAttachmentId, 'TransitGatewayMulticastDomainId>, value: string) : Ec2TransitGatewayMulticastDomainAssociationState<'SubnetId, 'TransitGatewayAttachmentId, 'TransitGatewayMulticastDomainId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayMulticastDomainAssociationState<'SubnetId, 'TransitGatewayAttachmentId, 'TransitGatewayMulticastDomainId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain_association#timeouts-1">Ec2TransitGatewayMulticastDomainAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2TransitGatewayMulticastDomainAssociationState<'SubnetId, 'TransitGatewayAttachmentId, 'TransitGatewayMulticastDomainId>, value: aws.Ec2TransitGatewayMulticastDomainAssociation.Ec2TransitGatewayMulticastDomainAssociationTimeouts) : Ec2TransitGatewayMulticastDomainAssociationState<'SubnetId, 'TransitGatewayAttachmentId, 'TransitGatewayMulticastDomainId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2TransitGatewayMulticastDomainAssociationState<'SubnetId, 'TransitGatewayAttachmentId, 'TransitGatewayMulticastDomainId>

        member _.Run(state: Ec2TransitGatewayMulticastDomainAssociationState<Present, Present, Present>) : aws.Ec2TransitGatewayMulticastDomainAssociation.Ec2TransitGatewayMulticastDomainAssociation =
            let config = aws.Ec2TransitGatewayMulticastDomainAssociation.Ec2TransitGatewayMulticastDomainAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayMulticastDomainAssociation.Ec2TransitGatewayMulticastDomainAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayMulticastDomainAssociation: missing required arguments. Must call: subnet_id, transit_gateway_attachment_id, transit_gateway_multicast_domain_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayMulticastDomainAssociationState<_, _, _>) : aws.Ec2TransitGatewayMulticastDomainAssociation.Ec2TransitGatewayMulticastDomainAssociation =
            Unchecked.defaultof<aws.Ec2TransitGatewayMulticastDomainAssociation.Ec2TransitGatewayMulticastDomainAssociation>
