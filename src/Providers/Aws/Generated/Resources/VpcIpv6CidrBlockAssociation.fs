namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcIpv6CidrBlockAssociationState<'VpcId> = { assignments: ResizeArray<aws.VpcIpv6CidrBlockAssociation.VpcIpv6CidrBlockAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv6_cidr_block_association">aws_vpc_ipv6_cidr_block_association</a>.
    /// </summary>
    type VpcIpv6CidrBlockAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcIpv6CidrBlockAssociationState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpv6CidrBlockAssociationState<Missing>)

        member _.Zero(()) : VpcIpv6CidrBlockAssociationState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpv6CidrBlockAssociationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv6_cidr_block_association#vpc_id-1">VpcIpv6CidrBlockAssociation#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: VpcIpv6CidrBlockAssociationState<Missing>, value: string) : VpcIpv6CidrBlockAssociationState<Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : VpcIpv6CidrBlockAssociationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv6_cidr_block_association#assign_generated_ipv6_cidr_block-1">VpcIpv6CidrBlockAssociation#assign_generated_ipv6_cidr_block</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "assign_generated_ipv6_cidr_block">]
        member _.AssignGeneratedIpv6CidrBlock(state: VpcIpv6CidrBlockAssociationState<'VpcId>, value: bool) : VpcIpv6CidrBlockAssociationState<'VpcId> =
            state.assignments.Add(fun config -> config.AssignGeneratedIpv6CidrBlock <- value)
            state : VpcIpv6CidrBlockAssociationState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv6_cidr_block_association#assign_generated_ipv6_cidr_block-1">VpcIpv6CidrBlockAssociation#assign_generated_ipv6_cidr_block</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "assign_generated_ipv6_cidr_block">]
        member _.AssignGeneratedIpv6CidrBlock(state: VpcIpv6CidrBlockAssociationState<'VpcId>, value: HashiCorp.Cdktf.IResolvable) : VpcIpv6CidrBlockAssociationState<'VpcId> =
            state.assignments.Add(fun config -> config.AssignGeneratedIpv6CidrBlock <- value)
            state : VpcIpv6CidrBlockAssociationState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv6_cidr_block_association#id-1">VpcIpv6CidrBlockAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcIpv6CidrBlockAssociationState<'VpcId>, value: string) : VpcIpv6CidrBlockAssociationState<'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcIpv6CidrBlockAssociationState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv6_cidr_block_association#ipv6_cidr_block-1">VpcIpv6CidrBlockAssociation#ipv6_cidr_block</a>.
        /// </summary>
        [<CustomOperation "ipv6_cidr_block">]
        member _.Ipv6CidrBlock(state: VpcIpv6CidrBlockAssociationState<'VpcId>, value: string) : VpcIpv6CidrBlockAssociationState<'VpcId> =
            state.assignments.Add(fun config -> config.Ipv6CidrBlock <- value)
            state : VpcIpv6CidrBlockAssociationState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv6_cidr_block_association#ipv6_ipam_pool_id-1">VpcIpv6CidrBlockAssociation#ipv6_ipam_pool_id</a>.
        /// </summary>
        [<CustomOperation "ipv6_ipam_pool_id">]
        member _.Ipv6IpamPoolId(state: VpcIpv6CidrBlockAssociationState<'VpcId>, value: string) : VpcIpv6CidrBlockAssociationState<'VpcId> =
            state.assignments.Add(fun config -> config.Ipv6IpamPoolId <- value)
            state : VpcIpv6CidrBlockAssociationState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv6_cidr_block_association#ipv6_netmask_length-1">VpcIpv6CidrBlockAssociation#ipv6_netmask_length</a>.
        /// </summary>
        [<CustomOperation "ipv6_netmask_length">]
        member _.Ipv6NetmaskLength(state: VpcIpv6CidrBlockAssociationState<'VpcId>, value: double) : VpcIpv6CidrBlockAssociationState<'VpcId> =
            state.assignments.Add(fun config -> config.Ipv6NetmaskLength <- value)
            state : VpcIpv6CidrBlockAssociationState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv6_cidr_block_association#ipv6_pool-1">VpcIpv6CidrBlockAssociation#ipv6_pool</a>.
        /// </summary>
        [<CustomOperation "ipv6_pool">]
        member _.Ipv6Pool(state: VpcIpv6CidrBlockAssociationState<'VpcId>, value: string) : VpcIpv6CidrBlockAssociationState<'VpcId> =
            state.assignments.Add(fun config -> config.Ipv6Pool <- value)
            state : VpcIpv6CidrBlockAssociationState<'VpcId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv6_cidr_block_association#timeouts-1">VpcIpv6CidrBlockAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcIpv6CidrBlockAssociationState<'VpcId>, value: aws.VpcIpv6CidrBlockAssociation.VpcIpv6CidrBlockAssociationTimeouts) : VpcIpv6CidrBlockAssociationState<'VpcId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcIpv6CidrBlockAssociationState<'VpcId>

        member _.Run(state: VpcIpv6CidrBlockAssociationState<Present>) : aws.VpcIpv6CidrBlockAssociation.VpcIpv6CidrBlockAssociation =
            let config = aws.VpcIpv6CidrBlockAssociation.VpcIpv6CidrBlockAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.VpcIpv6CidrBlockAssociation.VpcIpv6CidrBlockAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcIpv6CidrBlockAssociation: missing required arguments. Must call: vpc_id.", 9999, IsError = true)>]
        member _.Run(_: VpcIpv6CidrBlockAssociationState<_>) : aws.VpcIpv6CidrBlockAssociation.VpcIpv6CidrBlockAssociation =
            Unchecked.defaultof<aws.VpcIpv6CidrBlockAssociation.VpcIpv6CidrBlockAssociation>
