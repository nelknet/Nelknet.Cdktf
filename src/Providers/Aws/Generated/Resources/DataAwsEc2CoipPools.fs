namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2CoipPoolsState = { assignments: ResizeArray<aws.DataAwsEc2CoipPools.DataAwsEc2CoipPoolsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pools">aws_ec2_coip_pools</a>.
    /// </summary>
    type DataAwsEc2CoipPoolsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2CoipPoolsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2CoipPoolsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pools#filter-1">DataAwsEc2CoipPools#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2CoipPools.DataAwsEc2CoipPoolsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2CoipPoolsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2CoipPoolsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2CoipPoolsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pools#id-1">DataAwsEc2CoipPools#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2CoipPoolsState, value: string) : DataAwsEc2CoipPoolsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2CoipPoolsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pools#tags-1">DataAwsEc2CoipPools#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2CoipPoolsState, value: seq<string * string>) : DataAwsEc2CoipPoolsState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2CoipPoolsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pools#timeouts-1">DataAwsEc2CoipPools#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2CoipPoolsState, value: aws.DataAwsEc2CoipPools.DataAwsEc2CoipPoolsTimeouts) : DataAwsEc2CoipPoolsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2CoipPoolsState

        member _.Run(state: DataAwsEc2CoipPoolsState) : aws.DataAwsEc2CoipPools.DataAwsEc2CoipPools =
            let config = aws.DataAwsEc2CoipPools.DataAwsEc2CoipPoolsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2CoipPools.DataAwsEc2CoipPools(StackContext.get (), logicalId, config)
