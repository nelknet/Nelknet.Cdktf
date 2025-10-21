namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcIpamPreviewNextCidrState<'IpamPoolId> = { assignments: ResizeArray<aws.VpcIpamPreviewNextCidr.VpcIpamPreviewNextCidrConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_preview_next_cidr">aws_vpc_ipam_preview_next_cidr</a>.
    /// </summary>
    type VpcIpamPreviewNextCidrBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcIpamPreviewNextCidrState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpamPreviewNextCidrState<Missing>)

        member _.Zero(()) : VpcIpamPreviewNextCidrState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpamPreviewNextCidrState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_preview_next_cidr#ipam_pool_id-1">VpcIpamPreviewNextCidr#ipam_pool_id</a>.
        /// </summary>
        [<CustomOperation "ipam_pool_id">]
        member _.IpamPoolId(state: VpcIpamPreviewNextCidrState<Missing>, value: string) : VpcIpamPreviewNextCidrState<Present> =
            state.assignments.Add(fun config -> config.IpamPoolId <- value)
            ({ assignments = state.assignments } : VpcIpamPreviewNextCidrState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_preview_next_cidr#disallowed_cidrs-1">VpcIpamPreviewNextCidr#disallowed_cidrs</a>.
        /// </summary>
        [<CustomOperation "disallowed_cidrs">]
        member _.DisallowedCidrs(state: VpcIpamPreviewNextCidrState<'IpamPoolId>, value: seq<string>) : VpcIpamPreviewNextCidrState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.DisallowedCidrs <- (value |> Seq.toArray))
            state : VpcIpamPreviewNextCidrState<'IpamPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_preview_next_cidr#id-1">VpcIpamPreviewNextCidr#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcIpamPreviewNextCidrState<'IpamPoolId>, value: string) : VpcIpamPreviewNextCidrState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcIpamPreviewNextCidrState<'IpamPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_preview_next_cidr#netmask_length-1">VpcIpamPreviewNextCidr#netmask_length</a>.
        /// </summary>
        [<CustomOperation "netmask_length">]
        member _.NetmaskLength(state: VpcIpamPreviewNextCidrState<'IpamPoolId>, value: double) : VpcIpamPreviewNextCidrState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.NetmaskLength <- value)
            state : VpcIpamPreviewNextCidrState<'IpamPoolId>

        member _.Run(state: VpcIpamPreviewNextCidrState<Present>) : aws.VpcIpamPreviewNextCidr.VpcIpamPreviewNextCidr =
            let config = aws.VpcIpamPreviewNextCidr.VpcIpamPreviewNextCidrConfig()
            for setter in state.assignments do
                setter config
            aws.VpcIpamPreviewNextCidr.VpcIpamPreviewNextCidr(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcIpamPreviewNextCidr: missing required arguments. Must call: ipam_pool_id.", 9999, IsError = true)>]
        member _.Run(_: VpcIpamPreviewNextCidrState<_>) : aws.VpcIpamPreviewNextCidr.VpcIpamPreviewNextCidr =
            Unchecked.defaultof<aws.VpcIpamPreviewNextCidr.VpcIpamPreviewNextCidr>
