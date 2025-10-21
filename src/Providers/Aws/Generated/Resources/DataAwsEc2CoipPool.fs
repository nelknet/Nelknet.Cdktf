namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2CoipPoolState = { assignments: ResizeArray<aws.DataAwsEc2CoipPool.DataAwsEc2CoipPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pool">aws_ec2_coip_pool</a>.
    /// </summary>
    type DataAwsEc2CoipPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2CoipPoolState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2CoipPoolState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pool#filter-1">DataAwsEc2CoipPool#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2CoipPool.DataAwsEc2CoipPoolFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2CoipPoolState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2CoipPoolState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2CoipPoolState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pool#id-1">DataAwsEc2CoipPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2CoipPoolState, value: string) : DataAwsEc2CoipPoolState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2CoipPoolState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pool#local_gateway_route_table_id-1">DataAwsEc2CoipPool#local_gateway_route_table_id</a>.
        /// </summary>
        [<CustomOperation "local_gateway_route_table_id">]
        member _.LocalGatewayRouteTableId(state: DataAwsEc2CoipPoolState, value: string) : DataAwsEc2CoipPoolState =
            state.assignments.Add(fun config -> config.LocalGatewayRouteTableId <- value)
            state : DataAwsEc2CoipPoolState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pool#pool_id-1">DataAwsEc2CoipPool#pool_id</a>.
        /// </summary>
        [<CustomOperation "pool_id">]
        member _.PoolId(state: DataAwsEc2CoipPoolState, value: string) : DataAwsEc2CoipPoolState =
            state.assignments.Add(fun config -> config.PoolId <- value)
            state : DataAwsEc2CoipPoolState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pool#tags-1">DataAwsEc2CoipPool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2CoipPoolState, value: seq<string * string>) : DataAwsEc2CoipPoolState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2CoipPoolState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pool#timeouts-1">DataAwsEc2CoipPool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2CoipPoolState, value: aws.DataAwsEc2CoipPool.DataAwsEc2CoipPoolTimeouts) : DataAwsEc2CoipPoolState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2CoipPoolState

        member _.Run(state: DataAwsEc2CoipPoolState) : aws.DataAwsEc2CoipPool.DataAwsEc2CoipPool =
            let config = aws.DataAwsEc2CoipPool.DataAwsEc2CoipPoolConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2CoipPool.DataAwsEc2CoipPool(StackContext.get (), logicalId, config)
