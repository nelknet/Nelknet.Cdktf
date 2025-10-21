namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StoragegatewayTapePoolState<'PoolName, 'StorageClass> = { assignments: ResizeArray<aws.StoragegatewayTapePool.StoragegatewayTapePoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_tape_pool">aws_storagegateway_tape_pool</a>.
    /// </summary>
    type StoragegatewayTapePoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : StoragegatewayTapePoolState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayTapePoolState<Missing, Missing>)

        member _.Zero(()) : StoragegatewayTapePoolState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayTapePoolState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_tape_pool#pool_name-1">StoragegatewayTapePool#pool_name</a>.
        /// </summary>
        [<CustomOperation "pool_name">]
        member _.PoolName(state: StoragegatewayTapePoolState<Missing, 'StorageClass>, value: string) : StoragegatewayTapePoolState<Present, 'StorageClass> =
            state.assignments.Add(fun config -> config.PoolName <- value)
            ({ assignments = state.assignments } : StoragegatewayTapePoolState<Present, 'StorageClass>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_tape_pool#storage_class-1">StoragegatewayTapePool#storage_class</a>.
        /// </summary>
        [<CustomOperation "storage_class">]
        member _.StorageClass(state: StoragegatewayTapePoolState<'PoolName, Missing>, value: string) : StoragegatewayTapePoolState<'PoolName, Present> =
            state.assignments.Add(fun config -> config.StorageClass <- value)
            ({ assignments = state.assignments } : StoragegatewayTapePoolState<'PoolName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_tape_pool#id-1">StoragegatewayTapePool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StoragegatewayTapePoolState<'PoolName, 'StorageClass>, value: string) : StoragegatewayTapePoolState<'PoolName, 'StorageClass> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StoragegatewayTapePoolState<'PoolName, 'StorageClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_tape_pool#retention_lock_time_in_days-1">StoragegatewayTapePool#retention_lock_time_in_days</a>.
        /// </summary>
        [<CustomOperation "retention_lock_time_in_days">]
        member _.RetentionLockTimeInDays(state: StoragegatewayTapePoolState<'PoolName, 'StorageClass>, value: double) : StoragegatewayTapePoolState<'PoolName, 'StorageClass> =
            state.assignments.Add(fun config -> config.RetentionLockTimeInDays <- value)
            state : StoragegatewayTapePoolState<'PoolName, 'StorageClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_tape_pool#retention_lock_type-1">StoragegatewayTapePool#retention_lock_type</a>.
        /// </summary>
        [<CustomOperation "retention_lock_type">]
        member _.RetentionLockType(state: StoragegatewayTapePoolState<'PoolName, 'StorageClass>, value: string) : StoragegatewayTapePoolState<'PoolName, 'StorageClass> =
            state.assignments.Add(fun config -> config.RetentionLockType <- value)
            state : StoragegatewayTapePoolState<'PoolName, 'StorageClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_tape_pool#tags-1">StoragegatewayTapePool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StoragegatewayTapePoolState<'PoolName, 'StorageClass>, value: seq<string * string>) : StoragegatewayTapePoolState<'PoolName, 'StorageClass> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StoragegatewayTapePoolState<'PoolName, 'StorageClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_tape_pool#tags_all-1">StoragegatewayTapePool#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: StoragegatewayTapePoolState<'PoolName, 'StorageClass>, value: seq<string * string>) : StoragegatewayTapePoolState<'PoolName, 'StorageClass> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : StoragegatewayTapePoolState<'PoolName, 'StorageClass>

        member _.Run(state: StoragegatewayTapePoolState<Present, Present>) : aws.StoragegatewayTapePool.StoragegatewayTapePool =
            let config = aws.StoragegatewayTapePool.StoragegatewayTapePoolConfig()
            for setter in state.assignments do
                setter config
            aws.StoragegatewayTapePool.StoragegatewayTapePool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.storagegatewayTapePool: missing required arguments. Must call: pool_name, storage_class.", 9999, IsError = true)>]
        member _.Run(_: StoragegatewayTapePoolState<_, _>) : aws.StoragegatewayTapePool.StoragegatewayTapePool =
            Unchecked.defaultof<aws.StoragegatewayTapePool.StoragegatewayTapePool>
