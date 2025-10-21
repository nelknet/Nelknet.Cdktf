namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcIpamPoolState = { assignments: ResizeArray<aws.DataAwsVpcIpamPool.DataAwsVpcIpamPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pool">aws_vpc_ipam_pool</a>.
    /// </summary>
    type DataAwsVpcIpamPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcIpamPoolState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsVpcIpamPoolState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pool#allocation_resource_tags-1">DataAwsVpcIpamPool#allocation_resource_tags</a>.
        /// </summary>
        [<CustomOperation "allocation_resource_tags">]
        member _.AllocationResourceTags(state: DataAwsVpcIpamPoolState, value: seq<string * string>) : DataAwsVpcIpamPoolState =
            state.assignments.Add(fun config -> config.AllocationResourceTags <- dict value)
            state : DataAwsVpcIpamPoolState

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pool#filter-1">DataAwsVpcIpamPool#filter</a> Accepts: aws.IResolvable | aws.DataAwsVpcIpamPool.DataAwsVpcIpamPoolFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsVpcIpamPoolState, value: HashiCorp.Cdktf.IResolvable) : DataAwsVpcIpamPoolState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsVpcIpamPoolState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pool#id-1">DataAwsVpcIpamPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpcIpamPoolState, value: string) : DataAwsVpcIpamPoolState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpcIpamPoolState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pool#ipam_pool_id-1">DataAwsVpcIpamPool#ipam_pool_id</a>.
        /// </summary>
        [<CustomOperation "ipam_pool_id">]
        member _.IpamPoolId(state: DataAwsVpcIpamPoolState, value: string) : DataAwsVpcIpamPoolState =
            state.assignments.Add(fun config -> config.IpamPoolId <- value)
            state : DataAwsVpcIpamPoolState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pool#tags-1">DataAwsVpcIpamPool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsVpcIpamPoolState, value: seq<string * string>) : DataAwsVpcIpamPoolState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsVpcIpamPoolState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pool#timeouts-1">DataAwsVpcIpamPool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsVpcIpamPoolState, value: aws.DataAwsVpcIpamPool.DataAwsVpcIpamPoolTimeouts) : DataAwsVpcIpamPoolState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsVpcIpamPoolState

        member _.Run(state: DataAwsVpcIpamPoolState) : aws.DataAwsVpcIpamPool.DataAwsVpcIpamPool =
            let config = aws.DataAwsVpcIpamPool.DataAwsVpcIpamPoolConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpcIpamPool.DataAwsVpcIpamPool(StackContext.get (), logicalId, config)
