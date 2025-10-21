namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcIpamPoolsState = { assignments: ResizeArray<aws.DataAwsVpcIpamPools.DataAwsVpcIpamPoolsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pools">aws_vpc_ipam_pools</a>.
    /// </summary>
    type DataAwsVpcIpamPoolsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcIpamPoolsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsVpcIpamPoolsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pools#filter-1">DataAwsVpcIpamPools#filter</a> Accepts: aws.IResolvable | aws.DataAwsVpcIpamPools.DataAwsVpcIpamPoolsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsVpcIpamPoolsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsVpcIpamPoolsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsVpcIpamPoolsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pools#id-1">DataAwsVpcIpamPools#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpcIpamPoolsState, value: string) : DataAwsVpcIpamPoolsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpcIpamPoolsState

        member _.Run(state: DataAwsVpcIpamPoolsState) : aws.DataAwsVpcIpamPools.DataAwsVpcIpamPools =
            let config = aws.DataAwsVpcIpamPools.DataAwsVpcIpamPoolsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpcIpamPools.DataAwsVpcIpamPools(StackContext.get (), logicalId, config)
