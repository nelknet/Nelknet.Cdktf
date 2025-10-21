namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSesv2DedicatedIpPoolState<'PoolName> = { assignments: ResizeArray<aws.DataAwsSesv2DedicatedIpPool.DataAwsSesv2DedicatedIpPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_dedicated_ip_pool">aws_sesv2_dedicated_ip_pool</a>.
    /// </summary>
    type DataAwsSesv2DedicatedIpPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSesv2DedicatedIpPoolState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSesv2DedicatedIpPoolState<Missing>)

        member _.Zero(()) : DataAwsSesv2DedicatedIpPoolState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSesv2DedicatedIpPoolState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_dedicated_ip_pool#pool_name-1">DataAwsSesv2DedicatedIpPool#pool_name</a>.
        /// </summary>
        [<CustomOperation "pool_name">]
        member _.PoolName(state: DataAwsSesv2DedicatedIpPoolState<Missing>, value: string) : DataAwsSesv2DedicatedIpPoolState<Present> =
            state.assignments.Add(fun config -> config.PoolName <- value)
            ({ assignments = state.assignments } : DataAwsSesv2DedicatedIpPoolState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_dedicated_ip_pool#id-1">DataAwsSesv2DedicatedIpPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSesv2DedicatedIpPoolState<'PoolName>, value: string) : DataAwsSesv2DedicatedIpPoolState<'PoolName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSesv2DedicatedIpPoolState<'PoolName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_dedicated_ip_pool#tags-1">DataAwsSesv2DedicatedIpPool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsSesv2DedicatedIpPoolState<'PoolName>, value: seq<string * string>) : DataAwsSesv2DedicatedIpPoolState<'PoolName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsSesv2DedicatedIpPoolState<'PoolName>

        member _.Run(state: DataAwsSesv2DedicatedIpPoolState<Present>) : aws.DataAwsSesv2DedicatedIpPool.DataAwsSesv2DedicatedIpPool =
            let config = aws.DataAwsSesv2DedicatedIpPool.DataAwsSesv2DedicatedIpPoolConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSesv2DedicatedIpPool.DataAwsSesv2DedicatedIpPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSesv2DedicatedIpPool: missing required arguments. Must call: pool_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSesv2DedicatedIpPoolState<_>) : aws.DataAwsSesv2DedicatedIpPool.DataAwsSesv2DedicatedIpPool =
            Unchecked.defaultof<aws.DataAwsSesv2DedicatedIpPool.DataAwsSesv2DedicatedIpPool>
