namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcIpamPoolCidrAllocationState<'IpamPoolId> = { assignments: ResizeArray<aws.VpcIpamPoolCidrAllocation.VpcIpamPoolCidrAllocationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr_allocation">aws_vpc_ipam_pool_cidr_allocation</a>.
    /// </summary>
    type VpcIpamPoolCidrAllocationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcIpamPoolCidrAllocationState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpamPoolCidrAllocationState<Missing>)

        member _.Zero(()) : VpcIpamPoolCidrAllocationState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpamPoolCidrAllocationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr_allocation#ipam_pool_id-1">VpcIpamPoolCidrAllocation#ipam_pool_id</a>.
        /// </summary>
        [<CustomOperation "ipam_pool_id">]
        member _.IpamPoolId(state: VpcIpamPoolCidrAllocationState<Missing>, value: string) : VpcIpamPoolCidrAllocationState<Present> =
            state.assignments.Add(fun config -> config.IpamPoolId <- value)
            ({ assignments = state.assignments } : VpcIpamPoolCidrAllocationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr_allocation#cidr-1">VpcIpamPoolCidrAllocation#cidr</a>.
        /// </summary>
        [<CustomOperation "cidr">]
        member _.Cidr(state: VpcIpamPoolCidrAllocationState<'IpamPoolId>, value: string) : VpcIpamPoolCidrAllocationState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.Cidr <- value)
            state : VpcIpamPoolCidrAllocationState<'IpamPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr_allocation#description-1">VpcIpamPoolCidrAllocation#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VpcIpamPoolCidrAllocationState<'IpamPoolId>, value: string) : VpcIpamPoolCidrAllocationState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VpcIpamPoolCidrAllocationState<'IpamPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr_allocation#disallowed_cidrs-1">VpcIpamPoolCidrAllocation#disallowed_cidrs</a>.
        /// </summary>
        [<CustomOperation "disallowed_cidrs">]
        member _.DisallowedCidrs(state: VpcIpamPoolCidrAllocationState<'IpamPoolId>, value: seq<string>) : VpcIpamPoolCidrAllocationState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.DisallowedCidrs <- (value |> Seq.toArray))
            state : VpcIpamPoolCidrAllocationState<'IpamPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr_allocation#id-1">VpcIpamPoolCidrAllocation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcIpamPoolCidrAllocationState<'IpamPoolId>, value: string) : VpcIpamPoolCidrAllocationState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcIpamPoolCidrAllocationState<'IpamPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr_allocation#netmask_length-1">VpcIpamPoolCidrAllocation#netmask_length</a>.
        /// </summary>
        [<CustomOperation "netmask_length">]
        member _.NetmaskLength(state: VpcIpamPoolCidrAllocationState<'IpamPoolId>, value: double) : VpcIpamPoolCidrAllocationState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.NetmaskLength <- value)
            state : VpcIpamPoolCidrAllocationState<'IpamPoolId>

        member _.Run(state: VpcIpamPoolCidrAllocationState<Present>) : aws.VpcIpamPoolCidrAllocation.VpcIpamPoolCidrAllocation =
            let config = aws.VpcIpamPoolCidrAllocation.VpcIpamPoolCidrAllocationConfig()
            for setter in state.assignments do
                setter config
            aws.VpcIpamPoolCidrAllocation.VpcIpamPoolCidrAllocation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcIpamPoolCidrAllocation: missing required arguments. Must call: ipam_pool_id.", 9999, IsError = true)>]
        member _.Run(_: VpcIpamPoolCidrAllocationState<_>) : aws.VpcIpamPoolCidrAllocation.VpcIpamPoolCidrAllocation =
            Unchecked.defaultof<aws.VpcIpamPoolCidrAllocation.VpcIpamPoolCidrAllocation>
