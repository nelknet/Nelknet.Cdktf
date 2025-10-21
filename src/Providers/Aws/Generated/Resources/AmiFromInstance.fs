namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AmiFromInstanceState<'Name, 'SourceInstanceId> = { assignments: ResizeArray<aws.AmiFromInstance.AmiFromInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_from_instance">aws_ami_from_instance</a>.
    /// </summary>
    type AmiFromInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : AmiFromInstanceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AmiFromInstanceState<Missing, Missing>)

        member _.Zero(()) : AmiFromInstanceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AmiFromInstanceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_from_instance#name-1">AmiFromInstance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AmiFromInstanceState<Missing, 'SourceInstanceId>, value: string) : AmiFromInstanceState<Present, 'SourceInstanceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AmiFromInstanceState<Present, 'SourceInstanceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_from_instance#source_instance_id-1">AmiFromInstance#source_instance_id</a>.
        /// </summary>
        [<CustomOperation "source_instance_id">]
        member _.SourceInstanceId(state: AmiFromInstanceState<'Name, Missing>, value: string) : AmiFromInstanceState<'Name, Present> =
            state.assignments.Add(fun config -> config.SourceInstanceId <- value)
            ({ assignments = state.assignments } : AmiFromInstanceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_from_instance#deprecation_time-1">AmiFromInstance#deprecation_time</a>.
        /// </summary>
        [<CustomOperation "deprecation_time">]
        member _.DeprecationTime(state: AmiFromInstanceState<'Name, 'SourceInstanceId>, value: string) : AmiFromInstanceState<'Name, 'SourceInstanceId> =
            state.assignments.Add(fun config -> config.DeprecationTime <- value)
            state : AmiFromInstanceState<'Name, 'SourceInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_from_instance#description-1">AmiFromInstance#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AmiFromInstanceState<'Name, 'SourceInstanceId>, value: string) : AmiFromInstanceState<'Name, 'SourceInstanceId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AmiFromInstanceState<'Name, 'SourceInstanceId>

        /// <summary>
        /// ebs_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_from_instance#ebs_block_device-1">AmiFromInstance#ebs_block_device</a> Accepts: aws.IResolvable | aws.AmiFromInstance.AmiFromInstanceEbsBlockDevice[]
        /// </summary>
        [<CustomOperation "ebs_block_device">]
        member _.EbsBlockDevice(state: AmiFromInstanceState<'Name, 'SourceInstanceId>, value: HashiCorp.Cdktf.IResolvable) : AmiFromInstanceState<'Name, 'SourceInstanceId> =
            state.assignments.Add(fun config -> config.EbsBlockDevice <- value)
            state : AmiFromInstanceState<'Name, 'SourceInstanceId>

        /// <summary>
        /// ephemeral_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_from_instance#ephemeral_block_device-1">AmiFromInstance#ephemeral_block_device</a> Accepts: aws.IResolvable | aws.AmiFromInstance.AmiFromInstanceEphemeralBlockDevice[]
        /// </summary>
        [<CustomOperation "ephemeral_block_device">]
        member _.EphemeralBlockDevice(state: AmiFromInstanceState<'Name, 'SourceInstanceId>, value: HashiCorp.Cdktf.IResolvable) : AmiFromInstanceState<'Name, 'SourceInstanceId> =
            state.assignments.Add(fun config -> config.EphemeralBlockDevice <- value)
            state : AmiFromInstanceState<'Name, 'SourceInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_from_instance#id-1">AmiFromInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AmiFromInstanceState<'Name, 'SourceInstanceId>, value: string) : AmiFromInstanceState<'Name, 'SourceInstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AmiFromInstanceState<'Name, 'SourceInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_from_instance#snapshot_without_reboot-1">AmiFromInstance#snapshot_without_reboot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "snapshot_without_reboot">]
        member _.SnapshotWithoutReboot(state: AmiFromInstanceState<'Name, 'SourceInstanceId>, value: bool) : AmiFromInstanceState<'Name, 'SourceInstanceId> =
            state.assignments.Add(fun config -> config.SnapshotWithoutReboot <- value)
            state : AmiFromInstanceState<'Name, 'SourceInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_from_instance#snapshot_without_reboot-1">AmiFromInstance#snapshot_without_reboot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "snapshot_without_reboot">]
        member _.SnapshotWithoutReboot(state: AmiFromInstanceState<'Name, 'SourceInstanceId>, value: HashiCorp.Cdktf.IResolvable) : AmiFromInstanceState<'Name, 'SourceInstanceId> =
            state.assignments.Add(fun config -> config.SnapshotWithoutReboot <- value)
            state : AmiFromInstanceState<'Name, 'SourceInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_from_instance#tags-1">AmiFromInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AmiFromInstanceState<'Name, 'SourceInstanceId>, value: seq<string * string>) : AmiFromInstanceState<'Name, 'SourceInstanceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AmiFromInstanceState<'Name, 'SourceInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_from_instance#tags_all-1">AmiFromInstance#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AmiFromInstanceState<'Name, 'SourceInstanceId>, value: seq<string * string>) : AmiFromInstanceState<'Name, 'SourceInstanceId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AmiFromInstanceState<'Name, 'SourceInstanceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_from_instance#timeouts-1">AmiFromInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AmiFromInstanceState<'Name, 'SourceInstanceId>, value: aws.AmiFromInstance.AmiFromInstanceTimeouts) : AmiFromInstanceState<'Name, 'SourceInstanceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AmiFromInstanceState<'Name, 'SourceInstanceId>

        member _.Run(state: AmiFromInstanceState<Present, Present>) : aws.AmiFromInstance.AmiFromInstance =
            let config = aws.AmiFromInstance.AmiFromInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.AmiFromInstance.AmiFromInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.amiFromInstance: missing required arguments. Must call: name, source_instance_id.", 9999, IsError = true)>]
        member _.Run(_: AmiFromInstanceState<_, _>) : aws.AmiFromInstance.AmiFromInstance =
            Unchecked.defaultof<aws.AmiFromInstance.AmiFromInstance>
