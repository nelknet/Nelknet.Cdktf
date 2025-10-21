namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion> = { assignments: ResizeArray<aws.AmiCopy.AmiCopyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy">aws_ami_copy</a>.
    /// </summary>
    type AmiCopyBuilder(logicalId: string) =
        member _.Yield(_: unit) : AmiCopyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AmiCopyState<Missing, Missing, Missing>)

        member _.Zero(()) : AmiCopyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AmiCopyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy#name-1">AmiCopy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AmiCopyState<Missing, 'SourceAmiId, 'SourceAmiRegion>, value: string) : AmiCopyState<Present, 'SourceAmiId, 'SourceAmiRegion> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AmiCopyState<Present, 'SourceAmiId, 'SourceAmiRegion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy#source_ami_id-1">AmiCopy#source_ami_id</a>.
        /// </summary>
        [<CustomOperation "source_ami_id">]
        member _.SourceAmiId(state: AmiCopyState<'Name, Missing, 'SourceAmiRegion>, value: string) : AmiCopyState<'Name, Present, 'SourceAmiRegion> =
            state.assignments.Add(fun config -> config.SourceAmiId <- value)
            ({ assignments = state.assignments } : AmiCopyState<'Name, Present, 'SourceAmiRegion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy#source_ami_region-1">AmiCopy#source_ami_region</a>.
        /// </summary>
        [<CustomOperation "source_ami_region">]
        member _.SourceAmiRegion(state: AmiCopyState<'Name, 'SourceAmiId, Missing>, value: string) : AmiCopyState<'Name, 'SourceAmiId, Present> =
            state.assignments.Add(fun config -> config.SourceAmiRegion <- value)
            ({ assignments = state.assignments } : AmiCopyState<'Name, 'SourceAmiId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy#deprecation_time-1">AmiCopy#deprecation_time</a>.
        /// </summary>
        [<CustomOperation "deprecation_time">]
        member _.DeprecationTime(state: AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>, value: string) : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion> =
            state.assignments.Add(fun config -> config.DeprecationTime <- value)
            state : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy#description-1">AmiCopy#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>, value: string) : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy#destination_outpost_arn-1">AmiCopy#destination_outpost_arn</a>.
        /// </summary>
        [<CustomOperation "destination_outpost_arn">]
        member _.DestinationOutpostArn(state: AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>, value: string) : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion> =
            state.assignments.Add(fun config -> config.DestinationOutpostArn <- value)
            state : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>

        /// <summary>
        /// ebs_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy#ebs_block_device-1">AmiCopy#ebs_block_device</a> Accepts: aws.IResolvable | aws.AmiCopy.AmiCopyEbsBlockDevice[]
        /// </summary>
        [<CustomOperation "ebs_block_device">]
        member _.EbsBlockDevice(state: AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>, value: HashiCorp.Cdktf.IResolvable) : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion> =
            state.assignments.Add(fun config -> config.EbsBlockDevice <- value)
            state : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy#encrypted-1">AmiCopy#encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>, value: bool) : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy#encrypted-1">AmiCopy#encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>, value: HashiCorp.Cdktf.IResolvable) : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>

        /// <summary>
        /// ephemeral_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy#ephemeral_block_device-1">AmiCopy#ephemeral_block_device</a> Accepts: aws.IResolvable | aws.AmiCopy.AmiCopyEphemeralBlockDevice[]
        /// </summary>
        [<CustomOperation "ephemeral_block_device">]
        member _.EphemeralBlockDevice(state: AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>, value: HashiCorp.Cdktf.IResolvable) : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion> =
            state.assignments.Add(fun config -> config.EphemeralBlockDevice <- value)
            state : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy#id-1">AmiCopy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>, value: string) : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy#kms_key_id-1">AmiCopy#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>, value: string) : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy#tags-1">AmiCopy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>, value: seq<string * string>) : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy#tags_all-1">AmiCopy#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>, value: seq<string * string>) : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ami_copy#timeouts-1">AmiCopy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>, value: aws.AmiCopy.AmiCopyTimeouts) : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AmiCopyState<'Name, 'SourceAmiId, 'SourceAmiRegion>

        member _.Run(state: AmiCopyState<Present, Present, Present>) : aws.AmiCopy.AmiCopy =
            let config = aws.AmiCopy.AmiCopyConfig()
            for setter in state.assignments do
                setter config
            aws.AmiCopy.AmiCopy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.amiCopy: missing required arguments. Must call: name, source_ami_id, source_ami_region.", 9999, IsError = true)>]
        member _.Run(_: AmiCopyState<_, _, _>) : aws.AmiCopy.AmiCopy =
            Unchecked.defaultof<aws.AmiCopy.AmiCopy>
