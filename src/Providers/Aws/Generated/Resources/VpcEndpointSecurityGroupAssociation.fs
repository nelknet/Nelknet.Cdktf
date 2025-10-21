namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcEndpointSecurityGroupAssociationState<'SecurityGroupId, 'VpcEndpointId> = { assignments: ResizeArray<aws.VpcEndpointSecurityGroupAssociation.VpcEndpointSecurityGroupAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_security_group_association">aws_vpc_endpoint_security_group_association</a>.
    /// </summary>
    type VpcEndpointSecurityGroupAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcEndpointSecurityGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointSecurityGroupAssociationState<Missing, Missing>)

        member _.Zero(()) : VpcEndpointSecurityGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointSecurityGroupAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_security_group_association#security_group_id-1">VpcEndpointSecurityGroupAssociation#security_group_id</a>.
        /// </summary>
        [<CustomOperation "security_group_id">]
        member _.SecurityGroupId(state: VpcEndpointSecurityGroupAssociationState<Missing, 'VpcEndpointId>, value: string) : VpcEndpointSecurityGroupAssociationState<Present, 'VpcEndpointId> =
            state.assignments.Add(fun config -> config.SecurityGroupId <- value)
            ({ assignments = state.assignments } : VpcEndpointSecurityGroupAssociationState<Present, 'VpcEndpointId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_security_group_association#vpc_endpoint_id-1">VpcEndpointSecurityGroupAssociation#vpc_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_id">]
        member _.VpcEndpointId(state: VpcEndpointSecurityGroupAssociationState<'SecurityGroupId, Missing>, value: string) : VpcEndpointSecurityGroupAssociationState<'SecurityGroupId, Present> =
            state.assignments.Add(fun config -> config.VpcEndpointId <- value)
            ({ assignments = state.assignments } : VpcEndpointSecurityGroupAssociationState<'SecurityGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_security_group_association#id-1">VpcEndpointSecurityGroupAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcEndpointSecurityGroupAssociationState<'SecurityGroupId, 'VpcEndpointId>, value: string) : VpcEndpointSecurityGroupAssociationState<'SecurityGroupId, 'VpcEndpointId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcEndpointSecurityGroupAssociationState<'SecurityGroupId, 'VpcEndpointId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_security_group_association#replace_default_association-1">VpcEndpointSecurityGroupAssociation#replace_default_association</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "replace_default_association">]
        member _.ReplaceDefaultAssociation(state: VpcEndpointSecurityGroupAssociationState<'SecurityGroupId, 'VpcEndpointId>, value: bool) : VpcEndpointSecurityGroupAssociationState<'SecurityGroupId, 'VpcEndpointId> =
            state.assignments.Add(fun config -> config.ReplaceDefaultAssociation <- value)
            state : VpcEndpointSecurityGroupAssociationState<'SecurityGroupId, 'VpcEndpointId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_security_group_association#replace_default_association-1">VpcEndpointSecurityGroupAssociation#replace_default_association</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "replace_default_association">]
        member _.ReplaceDefaultAssociation(state: VpcEndpointSecurityGroupAssociationState<'SecurityGroupId, 'VpcEndpointId>, value: HashiCorp.Cdktf.IResolvable) : VpcEndpointSecurityGroupAssociationState<'SecurityGroupId, 'VpcEndpointId> =
            state.assignments.Add(fun config -> config.ReplaceDefaultAssociation <- value)
            state : VpcEndpointSecurityGroupAssociationState<'SecurityGroupId, 'VpcEndpointId>

        member _.Run(state: VpcEndpointSecurityGroupAssociationState<Present, Present>) : aws.VpcEndpointSecurityGroupAssociation.VpcEndpointSecurityGroupAssociation =
            let config = aws.VpcEndpointSecurityGroupAssociation.VpcEndpointSecurityGroupAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.VpcEndpointSecurityGroupAssociation.VpcEndpointSecurityGroupAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcEndpointSecurityGroupAssociation: missing required arguments. Must call: security_group_id, vpc_endpoint_id.", 9999, IsError = true)>]
        member _.Run(_: VpcEndpointSecurityGroupAssociationState<_, _>) : aws.VpcEndpointSecurityGroupAssociation.VpcEndpointSecurityGroupAssociation =
            Unchecked.defaultof<aws.VpcEndpointSecurityGroupAssociation.VpcEndpointSecurityGroupAssociation>
