namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StoragegatewayWorkingStorageState<'DiskId, 'GatewayArn> = { assignments: ResizeArray<aws.StoragegatewayWorkingStorage.StoragegatewayWorkingStorageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_working_storage">aws_storagegateway_working_storage</a>.
    /// </summary>
    type StoragegatewayWorkingStorageBuilder(logicalId: string) =
        member _.Yield(_: unit) : StoragegatewayWorkingStorageState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayWorkingStorageState<Missing, Missing>)

        member _.Zero(()) : StoragegatewayWorkingStorageState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayWorkingStorageState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_working_storage#disk_id-1">StoragegatewayWorkingStorage#disk_id</a>.
        /// </summary>
        [<CustomOperation "disk_id">]
        member _.DiskId(state: StoragegatewayWorkingStorageState<Missing, 'GatewayArn>, value: string) : StoragegatewayWorkingStorageState<Present, 'GatewayArn> =
            state.assignments.Add(fun config -> config.DiskId <- value)
            ({ assignments = state.assignments } : StoragegatewayWorkingStorageState<Present, 'GatewayArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_working_storage#gateway_arn-1">StoragegatewayWorkingStorage#gateway_arn</a>.
        /// </summary>
        [<CustomOperation "gateway_arn">]
        member _.GatewayArn(state: StoragegatewayWorkingStorageState<'DiskId, Missing>, value: string) : StoragegatewayWorkingStorageState<'DiskId, Present> =
            state.assignments.Add(fun config -> config.GatewayArn <- value)
            ({ assignments = state.assignments } : StoragegatewayWorkingStorageState<'DiskId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_working_storage#id-1">StoragegatewayWorkingStorage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StoragegatewayWorkingStorageState<'DiskId, 'GatewayArn>, value: string) : StoragegatewayWorkingStorageState<'DiskId, 'GatewayArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StoragegatewayWorkingStorageState<'DiskId, 'GatewayArn>

        member _.Run(state: StoragegatewayWorkingStorageState<Present, Present>) : aws.StoragegatewayWorkingStorage.StoragegatewayWorkingStorage =
            let config = aws.StoragegatewayWorkingStorage.StoragegatewayWorkingStorageConfig()
            for setter in state.assignments do
                setter config
            aws.StoragegatewayWorkingStorage.StoragegatewayWorkingStorage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.storagegatewayWorkingStorage: missing required arguments. Must call: disk_id, gateway_arn.", 9999, IsError = true)>]
        member _.Run(_: StoragegatewayWorkingStorageState<_, _>) : aws.StoragegatewayWorkingStorage.StoragegatewayWorkingStorage =
            Unchecked.defaultof<aws.StoragegatewayWorkingStorage.StoragegatewayWorkingStorage>
