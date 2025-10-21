namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2PublicIpv4PoolState<'PoolId> = { assignments: ResizeArray<aws.DataAwsEc2PublicIpv4Pool.DataAwsEc2PublicIpv4PoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_public_ipv4_pool">aws_ec2_public_ipv4_pool</a>.
    /// </summary>
    type DataAwsEc2PublicIpv4PoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2PublicIpv4PoolState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEc2PublicIpv4PoolState<Missing>)

        member _.Zero(()) : DataAwsEc2PublicIpv4PoolState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEc2PublicIpv4PoolState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_public_ipv4_pool#pool_id-1">DataAwsEc2PublicIpv4Pool#pool_id</a>.
        /// </summary>
        [<CustomOperation "pool_id">]
        member _.PoolId(state: DataAwsEc2PublicIpv4PoolState<Missing>, value: string) : DataAwsEc2PublicIpv4PoolState<Present> =
            state.assignments.Add(fun config -> config.PoolId <- value)
            ({ assignments = state.assignments } : DataAwsEc2PublicIpv4PoolState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_public_ipv4_pool#id-1">DataAwsEc2PublicIpv4Pool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2PublicIpv4PoolState<'PoolId>, value: string) : DataAwsEc2PublicIpv4PoolState<'PoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2PublicIpv4PoolState<'PoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_public_ipv4_pool#tags-1">DataAwsEc2PublicIpv4Pool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2PublicIpv4PoolState<'PoolId>, value: seq<string * string>) : DataAwsEc2PublicIpv4PoolState<'PoolId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2PublicIpv4PoolState<'PoolId>

        member _.Run(state: DataAwsEc2PublicIpv4PoolState<Present>) : aws.DataAwsEc2PublicIpv4Pool.DataAwsEc2PublicIpv4Pool =
            let config = aws.DataAwsEc2PublicIpv4Pool.DataAwsEc2PublicIpv4PoolConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2PublicIpv4Pool.DataAwsEc2PublicIpv4Pool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEc2PublicIpv4Pool: missing required arguments. Must call: pool_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEc2PublicIpv4PoolState<_>) : aws.DataAwsEc2PublicIpv4Pool.DataAwsEc2PublicIpv4Pool =
            Unchecked.defaultof<aws.DataAwsEc2PublicIpv4Pool.DataAwsEc2PublicIpv4Pool>
