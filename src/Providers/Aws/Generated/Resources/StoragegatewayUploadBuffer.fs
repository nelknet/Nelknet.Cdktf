namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StoragegatewayUploadBufferState<'GatewayArn> = { assignments: ResizeArray<aws.StoragegatewayUploadBuffer.StoragegatewayUploadBufferConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_upload_buffer">aws_storagegateway_upload_buffer</a>.
    /// </summary>
    type StoragegatewayUploadBufferBuilder(logicalId: string) =
        member _.Yield(_: unit) : StoragegatewayUploadBufferState<Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayUploadBufferState<Missing>)

        member _.Zero(()) : StoragegatewayUploadBufferState<Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayUploadBufferState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_upload_buffer#gateway_arn-1">StoragegatewayUploadBuffer#gateway_arn</a>.
        /// </summary>
        [<CustomOperation "gateway_arn">]
        member _.GatewayArn(state: StoragegatewayUploadBufferState<Missing>, value: string) : StoragegatewayUploadBufferState<Present> =
            state.assignments.Add(fun config -> config.GatewayArn <- value)
            ({ assignments = state.assignments } : StoragegatewayUploadBufferState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_upload_buffer#disk_id-1">StoragegatewayUploadBuffer#disk_id</a>.
        /// </summary>
        [<CustomOperation "disk_id">]
        member _.DiskId(state: StoragegatewayUploadBufferState<'GatewayArn>, value: string) : StoragegatewayUploadBufferState<'GatewayArn> =
            state.assignments.Add(fun config -> config.DiskId <- value)
            state : StoragegatewayUploadBufferState<'GatewayArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_upload_buffer#disk_path-1">StoragegatewayUploadBuffer#disk_path</a>.
        /// </summary>
        [<CustomOperation "disk_path">]
        member _.DiskPath(state: StoragegatewayUploadBufferState<'GatewayArn>, value: string) : StoragegatewayUploadBufferState<'GatewayArn> =
            state.assignments.Add(fun config -> config.DiskPath <- value)
            state : StoragegatewayUploadBufferState<'GatewayArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_upload_buffer#id-1">StoragegatewayUploadBuffer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StoragegatewayUploadBufferState<'GatewayArn>, value: string) : StoragegatewayUploadBufferState<'GatewayArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StoragegatewayUploadBufferState<'GatewayArn>

        member _.Run(state: StoragegatewayUploadBufferState<Present>) : aws.StoragegatewayUploadBuffer.StoragegatewayUploadBuffer =
            let config = aws.StoragegatewayUploadBuffer.StoragegatewayUploadBufferConfig()
            for setter in state.assignments do
                setter config
            aws.StoragegatewayUploadBuffer.StoragegatewayUploadBuffer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.storagegatewayUploadBuffer: missing required arguments. Must call: gateway_arn.", 9999, IsError = true)>]
        member _.Run(_: StoragegatewayUploadBufferState<_>) : aws.StoragegatewayUploadBuffer.StoragegatewayUploadBuffer =
            Unchecked.defaultof<aws.StoragegatewayUploadBuffer.StoragegatewayUploadBuffer>
