namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AmiState<'Name> = { assignments: ResizeArray<aws.Ami.AmiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami">aws_ami</a>.
    /// </summary>
    type AmiBuilder(logicalId: string) =
        member _.Yield(_: unit) : AmiState<Missing> =
            ({ assignments = ResizeArray() } : AmiState<Missing>)

        member _.Zero(()) : AmiState<Missing> =
            ({ assignments = ResizeArray() } : AmiState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#name-1">Ami#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AmiState<Missing>, value: string) : AmiState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AmiState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#architecture-1">Ami#architecture</a>.
        /// </summary>
        [<CustomOperation "architecture">]
        member _.Architecture(state: AmiState<'Name>, value: string) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.Architecture <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#boot_mode-1">Ami#boot_mode</a>.
        /// </summary>
        [<CustomOperation "boot_mode">]
        member _.BootMode(state: AmiState<'Name>, value: string) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.BootMode <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#deprecation_time-1">Ami#deprecation_time</a>.
        /// </summary>
        [<CustomOperation "deprecation_time">]
        member _.DeprecationTime(state: AmiState<'Name>, value: string) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.DeprecationTime <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#description-1">Ami#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AmiState<'Name>, value: string) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AmiState<'Name>

        /// <summary>
        /// ebs_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#ebs_block_device-1">Ami#ebs_block_device</a> Accepts: aws.IResolvable | aws.Ami.AmiEbsBlockDevice[]
        /// </summary>
        [<CustomOperation "ebs_block_device">]
        member _.EbsBlockDevice(state: AmiState<'Name>, value: HashiCorp.Cdktf.IResolvable) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.EbsBlockDevice <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#ena_support-1">Ami#ena_support</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ena_support">]
        member _.EnaSupport(state: AmiState<'Name>, value: bool) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.EnaSupport <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#ena_support-1">Ami#ena_support</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ena_support">]
        member _.EnaSupport(state: AmiState<'Name>, value: HashiCorp.Cdktf.IResolvable) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.EnaSupport <- value)
            state : AmiState<'Name>

        /// <summary>
        /// ephemeral_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#ephemeral_block_device-1">Ami#ephemeral_block_device</a> Accepts: aws.IResolvable | aws.Ami.AmiEphemeralBlockDevice[]
        /// </summary>
        [<CustomOperation "ephemeral_block_device">]
        member _.EphemeralBlockDevice(state: AmiState<'Name>, value: HashiCorp.Cdktf.IResolvable) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.EphemeralBlockDevice <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#id-1">Ami#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AmiState<'Name>, value: string) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#image_location-1">Ami#image_location</a>.
        /// </summary>
        [<CustomOperation "image_location">]
        member _.ImageLocation(state: AmiState<'Name>, value: string) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.ImageLocation <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#imds_support-1">Ami#imds_support</a>.
        /// </summary>
        [<CustomOperation "imds_support">]
        member _.ImdsSupport(state: AmiState<'Name>, value: string) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.ImdsSupport <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#kernel_id-1">Ami#kernel_id</a>.
        /// </summary>
        [<CustomOperation "kernel_id">]
        member _.KernelId(state: AmiState<'Name>, value: string) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.KernelId <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#ramdisk_id-1">Ami#ramdisk_id</a>.
        /// </summary>
        [<CustomOperation "ramdisk_id">]
        member _.RamdiskId(state: AmiState<'Name>, value: string) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.RamdiskId <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#root_device_name-1">Ami#root_device_name</a>.
        /// </summary>
        [<CustomOperation "root_device_name">]
        member _.RootDeviceName(state: AmiState<'Name>, value: string) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.RootDeviceName <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#sriov_net_support-1">Ami#sriov_net_support</a>.
        /// </summary>
        [<CustomOperation "sriov_net_support">]
        member _.SriovNetSupport(state: AmiState<'Name>, value: string) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.SriovNetSupport <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#tags-1">Ami#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AmiState<'Name>, value: seq<string * string>) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#tags_all-1">Ami#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AmiState<'Name>, value: seq<string * string>) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AmiState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#timeouts-1">Ami#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AmiState<'Name>, value: aws.Ami.AmiTimeouts) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#tpm_support-1">Ami#tpm_support</a>.
        /// </summary>
        [<CustomOperation "tpm_support">]
        member _.TpmSupport(state: AmiState<'Name>, value: string) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.TpmSupport <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#uefi_data-1">Ami#uefi_data</a>.
        /// </summary>
        [<CustomOperation "uefi_data">]
        member _.UefiData(state: AmiState<'Name>, value: string) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.UefiData <- value)
            state : AmiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami#virtualization_type-1">Ami#virtualization_type</a>.
        /// </summary>
        [<CustomOperation "virtualization_type">]
        member _.VirtualizationType(state: AmiState<'Name>, value: string) : AmiState<'Name> =
            state.assignments.Add(fun config -> config.VirtualizationType <- value)
            state : AmiState<'Name>

        member _.Run(state: AmiState<Present>) : aws.Ami.Ami =
            let config = aws.Ami.AmiConfig()
            for setter in state.assignments do
                setter config
            aws.Ami.Ami(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ami: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: AmiState<_>) : aws.Ami.Ami =
            Unchecked.defaultof<aws.Ami.Ami>
