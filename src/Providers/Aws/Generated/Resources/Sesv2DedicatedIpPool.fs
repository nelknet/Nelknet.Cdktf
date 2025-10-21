namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Sesv2DedicatedIpPoolState<'PoolName> = { assignments: ResizeArray<aws.Sesv2DedicatedIpPool.Sesv2DedicatedIpPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_pool">aws_sesv2_dedicated_ip_pool</a>.
    /// </summary>
    type Sesv2DedicatedIpPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : Sesv2DedicatedIpPoolState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2DedicatedIpPoolState<Missing>)

        member _.Zero(()) : Sesv2DedicatedIpPoolState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2DedicatedIpPoolState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_pool#pool_name-1">Sesv2DedicatedIpPool#pool_name</a>.
        /// </summary>
        [<CustomOperation "pool_name">]
        member _.PoolName(state: Sesv2DedicatedIpPoolState<Missing>, value: string) : Sesv2DedicatedIpPoolState<Present> =
            state.assignments.Add(fun config -> config.PoolName <- value)
            ({ assignments = state.assignments } : Sesv2DedicatedIpPoolState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_pool#id-1">Sesv2DedicatedIpPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Sesv2DedicatedIpPoolState<'PoolName>, value: string) : Sesv2DedicatedIpPoolState<'PoolName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Sesv2DedicatedIpPoolState<'PoolName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_pool#scaling_mode-1">Sesv2DedicatedIpPool#scaling_mode</a>.
        /// </summary>
        [<CustomOperation "scaling_mode">]
        member _.ScalingMode(state: Sesv2DedicatedIpPoolState<'PoolName>, value: string) : Sesv2DedicatedIpPoolState<'PoolName> =
            state.assignments.Add(fun config -> config.ScalingMode <- value)
            state : Sesv2DedicatedIpPoolState<'PoolName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_pool#tags-1">Sesv2DedicatedIpPool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Sesv2DedicatedIpPoolState<'PoolName>, value: seq<string * string>) : Sesv2DedicatedIpPoolState<'PoolName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Sesv2DedicatedIpPoolState<'PoolName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_pool#tags_all-1">Sesv2DedicatedIpPool#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Sesv2DedicatedIpPoolState<'PoolName>, value: seq<string * string>) : Sesv2DedicatedIpPoolState<'PoolName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Sesv2DedicatedIpPoolState<'PoolName>

        member _.Run(state: Sesv2DedicatedIpPoolState<Present>) : aws.Sesv2DedicatedIpPool.Sesv2DedicatedIpPool =
            let config = aws.Sesv2DedicatedIpPool.Sesv2DedicatedIpPoolConfig()
            for setter in state.assignments do
                setter config
            aws.Sesv2DedicatedIpPool.Sesv2DedicatedIpPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesv2DedicatedIpPool: missing required arguments. Must call: pool_name.", 9999, IsError = true)>]
        member _.Run(_: Sesv2DedicatedIpPoolState<_>) : aws.Sesv2DedicatedIpPool.Sesv2DedicatedIpPool =
            Unchecked.defaultof<aws.Sesv2DedicatedIpPool.Sesv2DedicatedIpPool>
