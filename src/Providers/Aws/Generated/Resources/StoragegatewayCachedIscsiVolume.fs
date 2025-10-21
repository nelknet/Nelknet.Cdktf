namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes> = { assignments: ResizeArray<aws.StoragegatewayCachedIscsiVolume.StoragegatewayCachedIscsiVolumeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cached_iscsi_volume">aws_storagegateway_cached_iscsi_volume</a>.
    /// </summary>
    type StoragegatewayCachedIscsiVolumeBuilder(logicalId: string) =
        member _.Yield(_: unit) : StoragegatewayCachedIscsiVolumeState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayCachedIscsiVolumeState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StoragegatewayCachedIscsiVolumeState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayCachedIscsiVolumeState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cached_iscsi_volume#gateway_arn-1">StoragegatewayCachedIscsiVolume#gateway_arn</a>.
        /// </summary>
        [<CustomOperation "gateway_arn">]
        member _.GatewayArn(state: StoragegatewayCachedIscsiVolumeState<Missing, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>, value: string) : StoragegatewayCachedIscsiVolumeState<Present, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes> =
            state.assignments.Add(fun config -> config.GatewayArn <- value)
            ({ assignments = state.assignments } : StoragegatewayCachedIscsiVolumeState<Present, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cached_iscsi_volume#network_interface_id-1">StoragegatewayCachedIscsiVolume#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: StoragegatewayCachedIscsiVolumeState<'GatewayArn, Missing, 'TargetName, 'VolumeSizeInBytes>, value: string) : StoragegatewayCachedIscsiVolumeState<'GatewayArn, Present, 'TargetName, 'VolumeSizeInBytes> =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            ({ assignments = state.assignments } : StoragegatewayCachedIscsiVolumeState<'GatewayArn, Present, 'TargetName, 'VolumeSizeInBytes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cached_iscsi_volume#target_name-1">StoragegatewayCachedIscsiVolume#target_name</a>.
        /// </summary>
        [<CustomOperation "target_name">]
        member _.TargetName(state: StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, Missing, 'VolumeSizeInBytes>, value: string) : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, Present, 'VolumeSizeInBytes> =
            state.assignments.Add(fun config -> config.TargetName <- value)
            ({ assignments = state.assignments } : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, Present, 'VolumeSizeInBytes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cached_iscsi_volume#volume_size_in_bytes-1">StoragegatewayCachedIscsiVolume#volume_size_in_bytes</a>.
        /// </summary>
        [<CustomOperation "volume_size_in_bytes">]
        member _.VolumeSizeInBytes(state: StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, Missing>, value: double) : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, Present> =
            state.assignments.Add(fun config -> config.VolumeSizeInBytes <- value)
            ({ assignments = state.assignments } : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cached_iscsi_volume#id-1">StoragegatewayCachedIscsiVolume#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>, value: string) : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cached_iscsi_volume#kms_encrypted-1">StoragegatewayCachedIscsiVolume#kms_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "kms_encrypted">]
        member _.KmsEncrypted(state: StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>, value: bool) : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes> =
            state.assignments.Add(fun config -> config.KmsEncrypted <- value)
            state : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cached_iscsi_volume#kms_encrypted-1">StoragegatewayCachedIscsiVolume#kms_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "kms_encrypted">]
        member _.KmsEncrypted(state: StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>, value: HashiCorp.Cdktf.IResolvable) : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes> =
            state.assignments.Add(fun config -> config.KmsEncrypted <- value)
            state : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cached_iscsi_volume#kms_key-1">StoragegatewayCachedIscsiVolume#kms_key</a>.
        /// </summary>
        [<CustomOperation "kms_key">]
        member _.KmsKey(state: StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>, value: string) : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes> =
            state.assignments.Add(fun config -> config.KmsKey <- value)
            state : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cached_iscsi_volume#snapshot_id-1">StoragegatewayCachedIscsiVolume#snapshot_id</a>.
        /// </summary>
        [<CustomOperation "snapshot_id">]
        member _.SnapshotId(state: StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>, value: string) : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes> =
            state.assignments.Add(fun config -> config.SnapshotId <- value)
            state : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cached_iscsi_volume#source_volume_arn-1">StoragegatewayCachedIscsiVolume#source_volume_arn</a>.
        /// </summary>
        [<CustomOperation "source_volume_arn">]
        member _.SourceVolumeArn(state: StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>, value: string) : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes> =
            state.assignments.Add(fun config -> config.SourceVolumeArn <- value)
            state : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cached_iscsi_volume#tags-1">StoragegatewayCachedIscsiVolume#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>, value: seq<string * string>) : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_cached_iscsi_volume#tags_all-1">StoragegatewayCachedIscsiVolume#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>, value: seq<string * string>) : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : StoragegatewayCachedIscsiVolumeState<'GatewayArn, 'NetworkInterfaceId, 'TargetName, 'VolumeSizeInBytes>

        member _.Run(state: StoragegatewayCachedIscsiVolumeState<Present, Present, Present, Present>) : aws.StoragegatewayCachedIscsiVolume.StoragegatewayCachedIscsiVolume =
            let config = aws.StoragegatewayCachedIscsiVolume.StoragegatewayCachedIscsiVolumeConfig()
            for setter in state.assignments do
                setter config
            aws.StoragegatewayCachedIscsiVolume.StoragegatewayCachedIscsiVolume(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.storagegatewayCachedIscsiVolume: missing required arguments. Must call: gateway_arn, network_interface_id, target_name, volume_size_in_bytes.", 9999, IsError = true)>]
        member _.Run(_: StoragegatewayCachedIscsiVolumeState<_, _, _, _>) : aws.StoragegatewayCachedIscsiVolume.StoragegatewayCachedIscsiVolume =
            Unchecked.defaultof<aws.StoragegatewayCachedIscsiVolume.StoragegatewayCachedIscsiVolume>
