namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcIpv4CidrBlockAssociationState<'VpcId> = { assignments: ResizeArray<aws.VpcIpv4CidrBlockAssociation.VpcIpv4CidrBlockAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv4_cidr_block_association">aws_vpc_ipv4_cidr_block_association</a>.
    /// </summary>
    type VpcIpv4CidrBlockAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcIpv4CidrBlockAssociationState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpv4CidrBlockAssociationState<Missing>)

        member _.Zero(()) : VpcIpv4CidrBlockAssociationState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpv4CidrBlockAssociationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv4_cidr_block_association#vpc_id-1">VpcIpv4CidrBlockAssociation#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: VpcIpv4CidrBlockAssociationState<Missing>, value: string) : VpcIpv4CidrBlockAssociationState<Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : VpcIpv4CidrBlockAssociationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv4_cidr_block_association#cidr_block-1">VpcIpv4CidrBlockAssociation#cidr_block</a>.
        /// </summary>
        [<CustomOperation "cidr_block">]
        member _.CidrBlock(state: VpcIpv4CidrBlockAssociationState<'VpcId>, value: string) : VpcIpv4CidrBlockAssociationState<'VpcId> =
            state.assignments.Add(fun config -> config.CidrBlock <- value)
            state : VpcIpv4CidrBlockAssociationState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv4_cidr_block_association#id-1">VpcIpv4CidrBlockAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcIpv4CidrBlockAssociationState<'VpcId>, value: string) : VpcIpv4CidrBlockAssociationState<'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcIpv4CidrBlockAssociationState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv4_cidr_block_association#ipv4_ipam_pool_id-1">VpcIpv4CidrBlockAssociation#ipv4_ipam_pool_id</a>.
        /// </summary>
        [<CustomOperation "ipv4_ipam_pool_id">]
        member _.Ipv4IpamPoolId(state: VpcIpv4CidrBlockAssociationState<'VpcId>, value: string) : VpcIpv4CidrBlockAssociationState<'VpcId> =
            state.assignments.Add(fun config -> config.Ipv4IpamPoolId <- value)
            state : VpcIpv4CidrBlockAssociationState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv4_cidr_block_association#ipv4_netmask_length-1">VpcIpv4CidrBlockAssociation#ipv4_netmask_length</a>.
        /// </summary>
        [<CustomOperation "ipv4_netmask_length">]
        member _.Ipv4NetmaskLength(state: VpcIpv4CidrBlockAssociationState<'VpcId>, value: double) : VpcIpv4CidrBlockAssociationState<'VpcId> =
            state.assignments.Add(fun config -> config.Ipv4NetmaskLength <- value)
            state : VpcIpv4CidrBlockAssociationState<'VpcId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipv4_cidr_block_association#timeouts-1">VpcIpv4CidrBlockAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcIpv4CidrBlockAssociationState<'VpcId>, value: aws.VpcIpv4CidrBlockAssociation.VpcIpv4CidrBlockAssociationTimeouts) : VpcIpv4CidrBlockAssociationState<'VpcId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcIpv4CidrBlockAssociationState<'VpcId>

        member _.Run(state: VpcIpv4CidrBlockAssociationState<Present>) : aws.VpcIpv4CidrBlockAssociation.VpcIpv4CidrBlockAssociation =
            let config = aws.VpcIpv4CidrBlockAssociation.VpcIpv4CidrBlockAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.VpcIpv4CidrBlockAssociation.VpcIpv4CidrBlockAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcIpv4CidrBlockAssociation: missing required arguments. Must call: vpc_id.", 9999, IsError = true)>]
        member _.Run(_: VpcIpv4CidrBlockAssociationState<_>) : aws.VpcIpv4CidrBlockAssociation.VpcIpv4CidrBlockAssociation =
            Unchecked.defaultof<aws.VpcIpv4CidrBlockAssociation.VpcIpv4CidrBlockAssociation>
