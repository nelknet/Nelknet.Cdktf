namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcIpamPreviewNextCidrState<'IpamPoolId> = { assignments: ResizeArray<aws.DataAwsVpcIpamPreviewNextCidr.DataAwsVpcIpamPreviewNextCidrConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_preview_next_cidr">aws_vpc_ipam_preview_next_cidr</a>.
    /// </summary>
    type DataAwsVpcIpamPreviewNextCidrBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcIpamPreviewNextCidrState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpcIpamPreviewNextCidrState<Missing>)

        member _.Zero(()) : DataAwsVpcIpamPreviewNextCidrState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpcIpamPreviewNextCidrState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_preview_next_cidr#ipam_pool_id-1">DataAwsVpcIpamPreviewNextCidr#ipam_pool_id</a>.
        /// </summary>
        [<CustomOperation "ipam_pool_id">]
        member _.IpamPoolId(state: DataAwsVpcIpamPreviewNextCidrState<Missing>, value: string) : DataAwsVpcIpamPreviewNextCidrState<Present> =
            state.assignments.Add(fun config -> config.IpamPoolId <- value)
            ({ assignments = state.assignments } : DataAwsVpcIpamPreviewNextCidrState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_preview_next_cidr#disallowed_cidrs-1">DataAwsVpcIpamPreviewNextCidr#disallowed_cidrs</a>.
        /// </summary>
        [<CustomOperation "disallowed_cidrs">]
        member _.DisallowedCidrs(state: DataAwsVpcIpamPreviewNextCidrState<'IpamPoolId>, value: seq<string>) : DataAwsVpcIpamPreviewNextCidrState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.DisallowedCidrs <- (value |> Seq.toArray))
            state : DataAwsVpcIpamPreviewNextCidrState<'IpamPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_preview_next_cidr#id-1">DataAwsVpcIpamPreviewNextCidr#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpcIpamPreviewNextCidrState<'IpamPoolId>, value: string) : DataAwsVpcIpamPreviewNextCidrState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpcIpamPreviewNextCidrState<'IpamPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_preview_next_cidr#netmask_length-1">DataAwsVpcIpamPreviewNextCidr#netmask_length</a>.
        /// </summary>
        [<CustomOperation "netmask_length">]
        member _.NetmaskLength(state: DataAwsVpcIpamPreviewNextCidrState<'IpamPoolId>, value: double) : DataAwsVpcIpamPreviewNextCidrState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.NetmaskLength <- value)
            state : DataAwsVpcIpamPreviewNextCidrState<'IpamPoolId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_preview_next_cidr#timeouts-1">DataAwsVpcIpamPreviewNextCidr#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsVpcIpamPreviewNextCidrState<'IpamPoolId>, value: aws.DataAwsVpcIpamPreviewNextCidr.DataAwsVpcIpamPreviewNextCidrTimeouts) : DataAwsVpcIpamPreviewNextCidrState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsVpcIpamPreviewNextCidrState<'IpamPoolId>

        member _.Run(state: DataAwsVpcIpamPreviewNextCidrState<Present>) : aws.DataAwsVpcIpamPreviewNextCidr.DataAwsVpcIpamPreviewNextCidr =
            let config = aws.DataAwsVpcIpamPreviewNextCidr.DataAwsVpcIpamPreviewNextCidrConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpcIpamPreviewNextCidr.DataAwsVpcIpamPreviewNextCidr(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsVpcIpamPreviewNextCidr: missing required arguments. Must call: ipam_pool_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsVpcIpamPreviewNextCidrState<_>) : aws.DataAwsVpcIpamPreviewNextCidr.DataAwsVpcIpamPreviewNextCidr =
            Unchecked.defaultof<aws.DataAwsVpcIpamPreviewNextCidr.DataAwsVpcIpamPreviewNextCidr>
