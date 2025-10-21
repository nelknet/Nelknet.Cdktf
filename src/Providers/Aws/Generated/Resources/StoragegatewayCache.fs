namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StoragegatewayCacheState<'DiskId, 'GatewayArn> = { assignments: ResizeArray<aws.StoragegatewayCache.StoragegatewayCacheConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cache">aws_storagegateway_cache</a>.
    /// </summary>
    type StoragegatewayCacheBuilder(logicalId: string) =
        member _.Yield(_: unit) : StoragegatewayCacheState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayCacheState<Missing, Missing>)

        member _.Zero(()) : StoragegatewayCacheState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayCacheState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cache#disk_id-1">StoragegatewayCache#disk_id</a>.
        /// </summary>
        [<CustomOperation "disk_id">]
        member _.DiskId(state: StoragegatewayCacheState<Missing, 'GatewayArn>, value: string) : StoragegatewayCacheState<Present, 'GatewayArn> =
            state.assignments.Add(fun config -> config.DiskId <- value)
            ({ assignments = state.assignments } : StoragegatewayCacheState<Present, 'GatewayArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cache#gateway_arn-1">StoragegatewayCache#gateway_arn</a>.
        /// </summary>
        [<CustomOperation "gateway_arn">]
        member _.GatewayArn(state: StoragegatewayCacheState<'DiskId, Missing>, value: string) : StoragegatewayCacheState<'DiskId, Present> =
            state.assignments.Add(fun config -> config.GatewayArn <- value)
            ({ assignments = state.assignments } : StoragegatewayCacheState<'DiskId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cache#id-1">StoragegatewayCache#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StoragegatewayCacheState<'DiskId, 'GatewayArn>, value: string) : StoragegatewayCacheState<'DiskId, 'GatewayArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StoragegatewayCacheState<'DiskId, 'GatewayArn>

        member _.Run(state: StoragegatewayCacheState<Present, Present>) : aws.StoragegatewayCache.StoragegatewayCache =
            let config = aws.StoragegatewayCache.StoragegatewayCacheConfig()
            for setter in state.assignments do
                setter config
            aws.StoragegatewayCache.StoragegatewayCache(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.storagegatewayCache: missing required arguments. Must call: disk_id, gateway_arn.", 9999, IsError = true)>]
        member _.Run(_: StoragegatewayCacheState<_, _>) : aws.StoragegatewayCache.StoragegatewayCache =
            Unchecked.defaultof<aws.StoragegatewayCache.StoragegatewayCache>
