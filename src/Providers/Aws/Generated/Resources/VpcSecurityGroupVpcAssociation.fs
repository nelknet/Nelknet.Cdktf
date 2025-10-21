namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcSecurityGroupVpcAssociationState<'SecurityGroupId, 'VpcId> = { assignments: ResizeArray<aws.VpcSecurityGroupVpcAssociation.VpcSecurityGroupVpcAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_vpc_association">aws_vpc_security_group_vpc_association</a>.
    /// </summary>
    type VpcSecurityGroupVpcAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcSecurityGroupVpcAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcSecurityGroupVpcAssociationState<Missing, Missing>)

        member _.Zero(()) : VpcSecurityGroupVpcAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcSecurityGroupVpcAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_vpc_association#security_group_id-1">VpcSecurityGroupVpcAssociation#security_group_id</a>.
        /// </summary>
        [<CustomOperation "security_group_id">]
        member _.SecurityGroupId(state: VpcSecurityGroupVpcAssociationState<Missing, 'VpcId>, value: string) : VpcSecurityGroupVpcAssociationState<Present, 'VpcId> =
            state.assignments.Add(fun config -> config.SecurityGroupId <- value)
            ({ assignments = state.assignments } : VpcSecurityGroupVpcAssociationState<Present, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_vpc_association#vpc_id-1">VpcSecurityGroupVpcAssociation#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: VpcSecurityGroupVpcAssociationState<'SecurityGroupId, Missing>, value: string) : VpcSecurityGroupVpcAssociationState<'SecurityGroupId, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : VpcSecurityGroupVpcAssociationState<'SecurityGroupId, Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_vpc_association#timeouts-1">VpcSecurityGroupVpcAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcSecurityGroupVpcAssociationState<'SecurityGroupId, 'VpcId>, value: aws.VpcSecurityGroupVpcAssociation.VpcSecurityGroupVpcAssociationTimeouts) : VpcSecurityGroupVpcAssociationState<'SecurityGroupId, 'VpcId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcSecurityGroupVpcAssociationState<'SecurityGroupId, 'VpcId>

        member _.Run(state: VpcSecurityGroupVpcAssociationState<Present, Present>) : aws.VpcSecurityGroupVpcAssociation.VpcSecurityGroupVpcAssociation =
            let config = aws.VpcSecurityGroupVpcAssociation.VpcSecurityGroupVpcAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.VpcSecurityGroupVpcAssociation.VpcSecurityGroupVpcAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcSecurityGroupVpcAssociation: missing required arguments. Must call: security_group_id, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: VpcSecurityGroupVpcAssociationState<_, _>) : aws.VpcSecurityGroupVpcAssociation.VpcSecurityGroupVpcAssociation =
            Unchecked.defaultof<aws.VpcSecurityGroupVpcAssociation.VpcSecurityGroupVpcAssociation>
