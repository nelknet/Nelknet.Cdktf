namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayPolicyTableAssociationState<'TransitGatewayAttachmentId, 'TransitGatewayPolicyTableId> = { assignments: ResizeArray<aws.Ec2TransitGatewayPolicyTableAssociation.Ec2TransitGatewayPolicyTableAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_policy_table_association">aws_ec2_transit_gateway_policy_table_association</a>.
    /// </summary>
    type Ec2TransitGatewayPolicyTableAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayPolicyTableAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayPolicyTableAssociationState<Missing, Missing>)

        member _.Zero(()) : Ec2TransitGatewayPolicyTableAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayPolicyTableAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_policy_table_association#transit_gateway_attachment_id-1">Ec2TransitGatewayPolicyTableAssociation#transit_gateway_attachment_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_attachment_id">]
        member _.TransitGatewayAttachmentId(state: Ec2TransitGatewayPolicyTableAssociationState<Missing, 'TransitGatewayPolicyTableId>, value: string) : Ec2TransitGatewayPolicyTableAssociationState<Present, 'TransitGatewayPolicyTableId> =
            state.assignments.Add(fun config -> config.TransitGatewayAttachmentId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayPolicyTableAssociationState<Present, 'TransitGatewayPolicyTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_policy_table_association#transit_gateway_policy_table_id-1">Ec2TransitGatewayPolicyTableAssociation#transit_gateway_policy_table_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_policy_table_id">]
        member _.TransitGatewayPolicyTableId(state: Ec2TransitGatewayPolicyTableAssociationState<'TransitGatewayAttachmentId, Missing>, value: string) : Ec2TransitGatewayPolicyTableAssociationState<'TransitGatewayAttachmentId, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayPolicyTableId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayPolicyTableAssociationState<'TransitGatewayAttachmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_policy_table_association#id-1">Ec2TransitGatewayPolicyTableAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayPolicyTableAssociationState<'TransitGatewayAttachmentId, 'TransitGatewayPolicyTableId>, value: string) : Ec2TransitGatewayPolicyTableAssociationState<'TransitGatewayAttachmentId, 'TransitGatewayPolicyTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayPolicyTableAssociationState<'TransitGatewayAttachmentId, 'TransitGatewayPolicyTableId>

        member _.Run(state: Ec2TransitGatewayPolicyTableAssociationState<Present, Present>) : aws.Ec2TransitGatewayPolicyTableAssociation.Ec2TransitGatewayPolicyTableAssociation =
            let config = aws.Ec2TransitGatewayPolicyTableAssociation.Ec2TransitGatewayPolicyTableAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayPolicyTableAssociation.Ec2TransitGatewayPolicyTableAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayPolicyTableAssociation: missing required arguments. Must call: transit_gateway_attachment_id, transit_gateway_policy_table_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayPolicyTableAssociationState<_, _>) : aws.Ec2TransitGatewayPolicyTableAssociation.Ec2TransitGatewayPolicyTableAssociation =
            Unchecked.defaultof<aws.Ec2TransitGatewayPolicyTableAssociation.Ec2TransitGatewayPolicyTableAssociation>
