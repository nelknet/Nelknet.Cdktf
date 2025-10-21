namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2PublicIpv4PoolsState = { assignments: ResizeArray<aws.DataAwsEc2PublicIpv4Pools.DataAwsEc2PublicIpv4PoolsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_public_ipv4_pools">aws_ec2_public_ipv4_pools</a>.
    /// </summary>
    type DataAwsEc2PublicIpv4PoolsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2PublicIpv4PoolsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2PublicIpv4PoolsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_public_ipv4_pools#filter-1">DataAwsEc2PublicIpv4Pools#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2PublicIpv4Pools.DataAwsEc2PublicIpv4PoolsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2PublicIpv4PoolsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2PublicIpv4PoolsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2PublicIpv4PoolsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_public_ipv4_pools#id-1">DataAwsEc2PublicIpv4Pools#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2PublicIpv4PoolsState, value: string) : DataAwsEc2PublicIpv4PoolsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2PublicIpv4PoolsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_public_ipv4_pools#tags-1">DataAwsEc2PublicIpv4Pools#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2PublicIpv4PoolsState, value: seq<string * string>) : DataAwsEc2PublicIpv4PoolsState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2PublicIpv4PoolsState

        member _.Run(state: DataAwsEc2PublicIpv4PoolsState) : aws.DataAwsEc2PublicIpv4Pools.DataAwsEc2PublicIpv4Pools =
            let config = aws.DataAwsEc2PublicIpv4Pools.DataAwsEc2PublicIpv4PoolsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2PublicIpv4Pools.DataAwsEc2PublicIpv4Pools(StackContext.get (), logicalId, config)
