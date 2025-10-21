namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName> = { assignments: ResizeArray<aws.StoragegatewayStoredIscsiVolume.StoragegatewayStoredIscsiVolumeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_stored_iscsi_volume">aws_storagegateway_stored_iscsi_volume</a>.
    /// </summary>
    type StoragegatewayStoredIscsiVolumeBuilder(logicalId: string) =
        member _.Yield(_: unit) : StoragegatewayStoredIscsiVolumeState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayStoredIscsiVolumeState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StoragegatewayStoredIscsiVolumeState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayStoredIscsiVolumeState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_stored_iscsi_volume#disk_id-1">StoragegatewayStoredIscsiVolume#disk_id</a>.
        /// </summary>
        [<CustomOperation "disk_id">]
        member _.DiskId(state: StoragegatewayStoredIscsiVolumeState<Missing, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>, value: string) : StoragegatewayStoredIscsiVolumeState<Present, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName> =
            state.assignments.Add(fun config -> config.DiskId <- value)
            ({ assignments = state.assignments } : StoragegatewayStoredIscsiVolumeState<Present, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_stored_iscsi_volume#gateway_arn-1">StoragegatewayStoredIscsiVolume#gateway_arn</a>.
        /// </summary>
        [<CustomOperation "gateway_arn">]
        member _.GatewayArn(state: StoragegatewayStoredIscsiVolumeState<'DiskId, Missing, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>, value: string) : StoragegatewayStoredIscsiVolumeState<'DiskId, Present, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName> =
            state.assignments.Add(fun config -> config.GatewayArn <- value)
            ({ assignments = state.assignments } : StoragegatewayStoredIscsiVolumeState<'DiskId, Present, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_stored_iscsi_volume#network_interface_id-1">StoragegatewayStoredIscsiVolume#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, Missing, 'PreserveExistingData, 'TargetName>, value: string) : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, Present, 'PreserveExistingData, 'TargetName> =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            ({ assignments = state.assignments } : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, Present, 'PreserveExistingData, 'TargetName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_stored_iscsi_volume#preserve_existing_data-1">StoragegatewayStoredIscsiVolume#preserve_existing_data</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "preserve_existing_data">]
        member _.PreserveExistingData(state: StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, Missing, 'TargetName>, value: bool) : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, Present, 'TargetName> =
            state.assignments.Add(fun config -> config.PreserveExistingData <- value)
            ({ assignments = state.assignments } : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, Present, 'TargetName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_stored_iscsi_volume#preserve_existing_data-1">StoragegatewayStoredIscsiVolume#preserve_existing_data</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "preserve_existing_data">]
        member _.PreserveExistingData(state: StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, Missing, 'TargetName>, value: HashiCorp.Cdktf.IResolvable) : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, Present, 'TargetName> =
            state.assignments.Add(fun config -> config.PreserveExistingData <- value)
            ({ assignments = state.assignments } : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, Present, 'TargetName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_stored_iscsi_volume#target_name-1">StoragegatewayStoredIscsiVolume#target_name</a>.
        /// </summary>
        [<CustomOperation "target_name">]
        member _.TargetName(state: StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, Missing>, value: string) : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, Present> =
            state.assignments.Add(fun config -> config.TargetName <- value)
            ({ assignments = state.assignments } : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_stored_iscsi_volume#id-1">StoragegatewayStoredIscsiVolume#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>, value: string) : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_stored_iscsi_volume#kms_encrypted-1">StoragegatewayStoredIscsiVolume#kms_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "kms_encrypted">]
        member _.KmsEncrypted(state: StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>, value: bool) : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName> =
            state.assignments.Add(fun config -> config.KmsEncrypted <- value)
            state : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_stored_iscsi_volume#kms_encrypted-1">StoragegatewayStoredIscsiVolume#kms_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "kms_encrypted">]
        member _.KmsEncrypted(state: StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>, value: HashiCorp.Cdktf.IResolvable) : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName> =
            state.assignments.Add(fun config -> config.KmsEncrypted <- value)
            state : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_stored_iscsi_volume#kms_key-1">StoragegatewayStoredIscsiVolume#kms_key</a>.
        /// </summary>
        [<CustomOperation "kms_key">]
        member _.KmsKey(state: StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>, value: string) : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName> =
            state.assignments.Add(fun config -> config.KmsKey <- value)
            state : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_stored_iscsi_volume#snapshot_id-1">StoragegatewayStoredIscsiVolume#snapshot_id</a>.
        /// </summary>
        [<CustomOperation "snapshot_id">]
        member _.SnapshotId(state: StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>, value: string) : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName> =
            state.assignments.Add(fun config -> config.SnapshotId <- value)
            state : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_stored_iscsi_volume#tags-1">StoragegatewayStoredIscsiVolume#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>, value: seq<string * string>) : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_stored_iscsi_volume#tags_all-1">StoragegatewayStoredIscsiVolume#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>, value: seq<string * string>) : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : StoragegatewayStoredIscsiVolumeState<'DiskId, 'GatewayArn, 'NetworkInterfaceId, 'PreserveExistingData, 'TargetName>

        member _.Run(state: StoragegatewayStoredIscsiVolumeState<Present, Present, Present, Present, Present>) : aws.StoragegatewayStoredIscsiVolume.StoragegatewayStoredIscsiVolume =
            let config = aws.StoragegatewayStoredIscsiVolume.StoragegatewayStoredIscsiVolumeConfig()
            for setter in state.assignments do
                setter config
            aws.StoragegatewayStoredIscsiVolume.StoragegatewayStoredIscsiVolume(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.storagegatewayStoredIscsiVolume: missing required arguments. Must call: disk_id, gateway_arn, network_interface_id, preserve_existing_data, target_name.", 9999, IsError = true)>]
        member _.Run(_: StoragegatewayStoredIscsiVolumeState<_, _, _, _, _>) : aws.StoragegatewayStoredIscsiVolume.StoragegatewayStoredIscsiVolume =
            Unchecked.defaultof<aws.StoragegatewayStoredIscsiVolume.StoragegatewayStoredIscsiVolume>
