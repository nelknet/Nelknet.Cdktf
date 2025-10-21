namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsStoragegatewayLocalDiskState<'GatewayArn> = { assignments: ResizeArray<aws.DataAwsStoragegatewayLocalDisk.DataAwsStoragegatewayLocalDiskConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/storagegateway_local_disk">aws_storagegateway_local_disk</a>.
    /// </summary>
    type DataAwsStoragegatewayLocalDiskBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsStoragegatewayLocalDiskState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsStoragegatewayLocalDiskState<Missing>)

        member _.Zero(()) : DataAwsStoragegatewayLocalDiskState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsStoragegatewayLocalDiskState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/storagegateway_local_disk#gateway_arn-1">DataAwsStoragegatewayLocalDisk#gateway_arn</a>.
        /// </summary>
        [<CustomOperation "gateway_arn">]
        member _.GatewayArn(state: DataAwsStoragegatewayLocalDiskState<Missing>, value: string) : DataAwsStoragegatewayLocalDiskState<Present> =
            state.assignments.Add(fun config -> config.GatewayArn <- value)
            ({ assignments = state.assignments } : DataAwsStoragegatewayLocalDiskState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/storagegateway_local_disk#disk_node-1">DataAwsStoragegatewayLocalDisk#disk_node</a>.
        /// </summary>
        [<CustomOperation "disk_node">]
        member _.DiskNode(state: DataAwsStoragegatewayLocalDiskState<'GatewayArn>, value: string) : DataAwsStoragegatewayLocalDiskState<'GatewayArn> =
            state.assignments.Add(fun config -> config.DiskNode <- value)
            state : DataAwsStoragegatewayLocalDiskState<'GatewayArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/storagegateway_local_disk#disk_path-1">DataAwsStoragegatewayLocalDisk#disk_path</a>.
        /// </summary>
        [<CustomOperation "disk_path">]
        member _.DiskPath(state: DataAwsStoragegatewayLocalDiskState<'GatewayArn>, value: string) : DataAwsStoragegatewayLocalDiskState<'GatewayArn> =
            state.assignments.Add(fun config -> config.DiskPath <- value)
            state : DataAwsStoragegatewayLocalDiskState<'GatewayArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/storagegateway_local_disk#id-1">DataAwsStoragegatewayLocalDisk#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsStoragegatewayLocalDiskState<'GatewayArn>, value: string) : DataAwsStoragegatewayLocalDiskState<'GatewayArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsStoragegatewayLocalDiskState<'GatewayArn>

        member _.Run(state: DataAwsStoragegatewayLocalDiskState<Present>) : aws.DataAwsStoragegatewayLocalDisk.DataAwsStoragegatewayLocalDisk =
            let config = aws.DataAwsStoragegatewayLocalDisk.DataAwsStoragegatewayLocalDiskConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsStoragegatewayLocalDisk.DataAwsStoragegatewayLocalDisk(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsStoragegatewayLocalDisk: missing required arguments. Must call: gateway_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsStoragegatewayLocalDiskState<_>) : aws.DataAwsStoragegatewayLocalDisk.DataAwsStoragegatewayLocalDisk =
            Unchecked.defaultof<aws.DataAwsStoragegatewayLocalDisk.DataAwsStoragegatewayLocalDisk>
