namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name> = { assignments: ResizeArray<aws.MedialiveChannel.MedialiveChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel">aws_medialive_channel</a>.
    /// </summary>
    type MedialiveChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : MedialiveChannelState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MedialiveChannelState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MedialiveChannelState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MedialiveChannelState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#channel_class-1">MedialiveChannel#channel_class</a>.
        /// </summary>
        [<CustomOperation "channel_class">]
        member _.ChannelClass(state: MedialiveChannelState<Missing, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>, value: string) : MedialiveChannelState<Present, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name> =
            state.assignments.Add(fun config -> config.ChannelClass <- value)
            ({ assignments = state.assignments } : MedialiveChannelState<Present, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>)

        /// <summary>
        /// destinations block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#destinations-1">MedialiveChannel#destinations</a> Accepts: aws.IResolvable | aws.MedialiveChannel.MedialiveChannelDestinations[]
        /// </summary>
        [<CustomOperation "destinations">]
        member _.Destinations(state: MedialiveChannelState<'ChannelClass, Missing, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>, value: HashiCorp.Cdktf.IResolvable) : MedialiveChannelState<'ChannelClass, Present, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name> =
            state.assignments.Add(fun config -> config.Destinations <- value)
            ({ assignments = state.assignments } : MedialiveChannelState<'ChannelClass, Present, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>)

        /// <summary>
        /// encoder_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#encoder_settings-1">MedialiveChannel#encoder_settings</a>
        /// </summary>
        [<CustomOperation "encoder_settings">]
        member _.EncoderSettings(state: MedialiveChannelState<'ChannelClass, 'Destinations, Missing, 'InputAttachments, 'InputSpecification, 'Name>, value: aws.MedialiveChannel.MedialiveChannelEncoderSettings) : MedialiveChannelState<'ChannelClass, 'Destinations, Present, 'InputAttachments, 'InputSpecification, 'Name> =
            state.assignments.Add(fun config -> config.EncoderSettings <- value)
            ({ assignments = state.assignments } : MedialiveChannelState<'ChannelClass, 'Destinations, Present, 'InputAttachments, 'InputSpecification, 'Name>)

        /// <summary>
        /// input_attachments block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_attachments-1">MedialiveChannel#input_attachments</a> Accepts: aws.IResolvable | aws.MedialiveChannel.MedialiveChannelInputAttachments[]
        /// </summary>
        [<CustomOperation "input_attachments">]
        member _.InputAttachments(state: MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, Missing, 'InputSpecification, 'Name>, value: HashiCorp.Cdktf.IResolvable) : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, Present, 'InputSpecification, 'Name> =
            state.assignments.Add(fun config -> config.InputAttachments <- value)
            ({ assignments = state.assignments } : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, Present, 'InputSpecification, 'Name>)

        /// <summary>
        /// input_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_specification-1">MedialiveChannel#input_specification</a>
        /// </summary>
        [<CustomOperation "input_specification">]
        member _.InputSpecification(state: MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, Missing, 'Name>, value: aws.MedialiveChannel.MedialiveChannelInputSpecification) : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, Present, 'Name> =
            state.assignments.Add(fun config -> config.InputSpecification <- value)
            ({ assignments = state.assignments } : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#name-1">MedialiveChannel#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, Missing>, value: string) : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, Present>)

        /// <summary>
        /// cdi_input_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#cdi_input_specification-1">MedialiveChannel#cdi_input_specification</a>
        /// </summary>
        [<CustomOperation "cdi_input_specification">]
        member _.CdiInputSpecification(state: MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>, value: aws.MedialiveChannel.MedialiveChannelCdiInputSpecification) : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name> =
            state.assignments.Add(fun config -> config.CdiInputSpecification <- value)
            state : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#id-1">MedialiveChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>, value: string) : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#log_level-1">MedialiveChannel#log_level</a>.
        /// </summary>
        [<CustomOperation "log_level">]
        member _.LogLevel(state: MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>, value: string) : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name> =
            state.assignments.Add(fun config -> config.LogLevel <- value)
            state : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>

        /// <summary>
        /// maintenance block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#maintenance-1">MedialiveChannel#maintenance</a>
        /// </summary>
        [<CustomOperation "maintenance">]
        member _.Maintenance(state: MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>, value: aws.MedialiveChannel.MedialiveChannelMaintenance) : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name> =
            state.assignments.Add(fun config -> config.Maintenance <- value)
            state : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#role_arn-1">MedialiveChannel#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>, value: string) : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#start_channel-1">MedialiveChannel#start_channel</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_channel">]
        member _.StartChannel(state: MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>, value: bool) : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name> =
            state.assignments.Add(fun config -> config.StartChannel <- value)
            state : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#start_channel-1">MedialiveChannel#start_channel</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_channel">]
        member _.StartChannel(state: MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>, value: HashiCorp.Cdktf.IResolvable) : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name> =
            state.assignments.Add(fun config -> config.StartChannel <- value)
            state : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#tags-1">MedialiveChannel#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>, value: seq<string * string>) : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#tags_all-1">MedialiveChannel#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>, value: seq<string * string>) : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timeouts-1">MedialiveChannel#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>, value: aws.MedialiveChannel.MedialiveChannelTimeouts) : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>

        /// <summary>
        /// vpc block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#vpc-1">MedialiveChannel#vpc</a>
        /// </summary>
        [<CustomOperation "vpc">]
        member _.Vpc(state: MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>, value: aws.MedialiveChannel.MedialiveChannelVpc) : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name> =
            state.assignments.Add(fun config -> config.Vpc <- value)
            state : MedialiveChannelState<'ChannelClass, 'Destinations, 'EncoderSettings, 'InputAttachments, 'InputSpecification, 'Name>

        member _.Run(state: MedialiveChannelState<Present, Present, Present, Present, Present, Present>) : aws.MedialiveChannel.MedialiveChannel =
            let config = aws.MedialiveChannel.MedialiveChannelConfig()
            for setter in state.assignments do
                setter config
            aws.MedialiveChannel.MedialiveChannel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.medialiveChannel: missing required arguments. Must call: channel_class, destinations, encoder_settings, input_attachments, input_specification, name.", 9999, IsError = true)>]
        member _.Run(_: MedialiveChannelState<_, _, _, _, _, _>) : aws.MedialiveChannel.MedialiveChannel =
            Unchecked.defaultof<aws.MedialiveChannel.MedialiveChannel>
