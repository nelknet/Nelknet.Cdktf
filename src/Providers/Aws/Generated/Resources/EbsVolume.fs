namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EbsVolumeState<'AvailabilityZone> = { assignments: ResizeArray<aws.EbsVolume.EbsVolumeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume">aws_ebs_volume</a>.
    /// </summary>
    type EbsVolumeBuilder(logicalId: string) =
        member _.Yield(_: unit) : EbsVolumeState<Missing> =
            ({ assignments = ResizeArray() } : EbsVolumeState<Missing>)

        member _.Zero(()) : EbsVolumeState<Missing> =
            ({ assignments = ResizeArray() } : EbsVolumeState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#availability_zone-1">EbsVolume#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: EbsVolumeState<Missing>, value: string) : EbsVolumeState<Present> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            ({ assignments = state.assignments } : EbsVolumeState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#encrypted-1">EbsVolume#encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: EbsVolumeState<'AvailabilityZone>, value: bool) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#encrypted-1">EbsVolume#encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: EbsVolumeState<'AvailabilityZone>, value: HashiCorp.Cdktf.IResolvable) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#final_snapshot-1">EbsVolume#final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "final_snapshot">]
        member _.FinalSnapshot(state: EbsVolumeState<'AvailabilityZone>, value: bool) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.FinalSnapshot <- value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#final_snapshot-1">EbsVolume#final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "final_snapshot">]
        member _.FinalSnapshot(state: EbsVolumeState<'AvailabilityZone>, value: HashiCorp.Cdktf.IResolvable) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.FinalSnapshot <- value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#id-1">EbsVolume#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EbsVolumeState<'AvailabilityZone>, value: string) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#iops-1">EbsVolume#iops</a>.
        /// </summary>
        [<CustomOperation "iops">]
        member _.Iops(state: EbsVolumeState<'AvailabilityZone>, value: double) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Iops <- value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#kms_key_id-1">EbsVolume#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: EbsVolumeState<'AvailabilityZone>, value: string) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#multi_attach_enabled-1">EbsVolume#multi_attach_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_attach_enabled">]
        member _.MultiAttachEnabled(state: EbsVolumeState<'AvailabilityZone>, value: bool) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.MultiAttachEnabled <- value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#multi_attach_enabled-1">EbsVolume#multi_attach_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_attach_enabled">]
        member _.MultiAttachEnabled(state: EbsVolumeState<'AvailabilityZone>, value: HashiCorp.Cdktf.IResolvable) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.MultiAttachEnabled <- value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#outpost_arn-1">EbsVolume#outpost_arn</a>.
        /// </summary>
        [<CustomOperation "outpost_arn">]
        member _.OutpostArn(state: EbsVolumeState<'AvailabilityZone>, value: string) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.OutpostArn <- value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#size-1">EbsVolume#size</a>.
        /// </summary>
        [<CustomOperation "size">]
        member _.Size(state: EbsVolumeState<'AvailabilityZone>, value: double) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Size <- value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#snapshot_id-1">EbsVolume#snapshot_id</a>.
        /// </summary>
        [<CustomOperation "snapshot_id">]
        member _.SnapshotId(state: EbsVolumeState<'AvailabilityZone>, value: string) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.SnapshotId <- value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#tags-1">EbsVolume#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EbsVolumeState<'AvailabilityZone>, value: seq<string * string>) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#tags_all-1">EbsVolume#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EbsVolumeState<'AvailabilityZone>, value: seq<string * string>) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#throughput-1">EbsVolume#throughput</a>.
        /// </summary>
        [<CustomOperation "throughput">]
        member _.Throughput(state: EbsVolumeState<'AvailabilityZone>, value: double) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Throughput <- value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#timeouts-1">EbsVolume#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EbsVolumeState<'AvailabilityZone>, value: aws.EbsVolume.EbsVolumeTimeouts) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EbsVolumeState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_volume#type-1">EbsVolume#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: EbsVolumeState<'AvailabilityZone>, value: string) : EbsVolumeState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : EbsVolumeState<'AvailabilityZone>

        member _.Run(state: EbsVolumeState<Present>) : aws.EbsVolume.EbsVolume =
            let config = aws.EbsVolume.EbsVolumeConfig()
            for setter in state.assignments do
                setter config
            aws.EbsVolume.EbsVolume(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ebsVolume: missing required arguments. Must call: availability_zone.", 9999, IsError = true)>]
        member _.Run(_: EbsVolumeState<_>) : aws.EbsVolume.EbsVolume =
            Unchecked.defaultof<aws.EbsVolume.EbsVolume>
