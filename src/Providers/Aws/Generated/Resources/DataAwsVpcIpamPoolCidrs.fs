namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcIpamPoolCidrsState<'IpamPoolId> = { assignments: ResizeArray<aws.DataAwsVpcIpamPoolCidrs.DataAwsVpcIpamPoolCidrsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pool_cidrs">aws_vpc_ipam_pool_cidrs</a>.
    /// </summary>
    type DataAwsVpcIpamPoolCidrsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcIpamPoolCidrsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpcIpamPoolCidrsState<Missing>)

        member _.Zero(()) : DataAwsVpcIpamPoolCidrsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpcIpamPoolCidrsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pool_cidrs#ipam_pool_id-1">DataAwsVpcIpamPoolCidrs#ipam_pool_id</a>.
        /// </summary>
        [<CustomOperation "ipam_pool_id">]
        member _.IpamPoolId(state: DataAwsVpcIpamPoolCidrsState<Missing>, value: string) : DataAwsVpcIpamPoolCidrsState<Present> =
            state.assignments.Add(fun config -> config.IpamPoolId <- value)
            ({ assignments = state.assignments } : DataAwsVpcIpamPoolCidrsState<Present>)

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pool_cidrs#filter-1">DataAwsVpcIpamPoolCidrs#filter</a> Accepts: aws.IResolvable | aws.DataAwsVpcIpamPoolCidrs.DataAwsVpcIpamPoolCidrsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsVpcIpamPoolCidrsState<'IpamPoolId>, value: HashiCorp.Cdktf.IResolvable) : DataAwsVpcIpamPoolCidrsState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsVpcIpamPoolCidrsState<'IpamPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pool_cidrs#id-1">DataAwsVpcIpamPoolCidrs#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpcIpamPoolCidrsState<'IpamPoolId>, value: string) : DataAwsVpcIpamPoolCidrsState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpcIpamPoolCidrsState<'IpamPoolId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pool_cidrs#timeouts-1">DataAwsVpcIpamPoolCidrs#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsVpcIpamPoolCidrsState<'IpamPoolId>, value: aws.DataAwsVpcIpamPoolCidrs.DataAwsVpcIpamPoolCidrsTimeouts) : DataAwsVpcIpamPoolCidrsState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsVpcIpamPoolCidrsState<'IpamPoolId>

        member _.Run(state: DataAwsVpcIpamPoolCidrsState<Present>) : aws.DataAwsVpcIpamPoolCidrs.DataAwsVpcIpamPoolCidrs =
            let config = aws.DataAwsVpcIpamPoolCidrs.DataAwsVpcIpamPoolCidrsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpcIpamPoolCidrs.DataAwsVpcIpamPoolCidrs(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsVpcIpamPoolCidrs: missing required arguments. Must call: ipam_pool_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsVpcIpamPoolCidrsState<_>) : aws.DataAwsVpcIpamPoolCidrs.DataAwsVpcIpamPoolCidrs =
            Unchecked.defaultof<aws.DataAwsVpcIpamPoolCidrs.DataAwsVpcIpamPoolCidrs>
