namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElastictranscoderPresetState<'Container> = { assignments: ResizeArray<aws.ElastictranscoderPreset.ElastictranscoderPresetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset">aws_elastictranscoder_preset</a>.
    /// </summary>
    type ElastictranscoderPresetBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElastictranscoderPresetState<Missing> =
            ({ assignments = ResizeArray() } : ElastictranscoderPresetState<Missing>)

        member _.Zero(()) : ElastictranscoderPresetState<Missing> =
            ({ assignments = ResizeArray() } : ElastictranscoderPresetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#container-1">ElastictranscoderPreset#container</a>.
        /// </summary>
        [<CustomOperation "container">]
        member _.Container(state: ElastictranscoderPresetState<Missing>, value: string) : ElastictranscoderPresetState<Present> =
            state.assignments.Add(fun config -> config.Container <- value)
            ({ assignments = state.assignments } : ElastictranscoderPresetState<Present>)

        /// <summary>
        /// audio block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#audio-1">ElastictranscoderPreset#audio</a>
        /// </summary>
        [<CustomOperation "audio">]
        member _.Audio(state: ElastictranscoderPresetState<'Container>, value: aws.ElastictranscoderPreset.ElastictranscoderPresetAudio) : ElastictranscoderPresetState<'Container> =
            state.assignments.Add(fun config -> config.Audio <- value)
            state : ElastictranscoderPresetState<'Container>

        /// <summary>
        /// audio_codec_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#audio_codec_options-1">ElastictranscoderPreset#audio_codec_options</a>
        /// </summary>
        [<CustomOperation "audio_codec_options">]
        member _.AudioCodecOptions(state: ElastictranscoderPresetState<'Container>, value: aws.ElastictranscoderPreset.ElastictranscoderPresetAudioCodecOptions) : ElastictranscoderPresetState<'Container> =
            state.assignments.Add(fun config -> config.AudioCodecOptions <- value)
            state : ElastictranscoderPresetState<'Container>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#description-1">ElastictranscoderPreset#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ElastictranscoderPresetState<'Container>, value: string) : ElastictranscoderPresetState<'Container> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ElastictranscoderPresetState<'Container>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#id-1">ElastictranscoderPreset#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElastictranscoderPresetState<'Container>, value: string) : ElastictranscoderPresetState<'Container> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElastictranscoderPresetState<'Container>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#name-1">ElastictranscoderPreset#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ElastictranscoderPresetState<'Container>, value: string) : ElastictranscoderPresetState<'Container> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : ElastictranscoderPresetState<'Container>

        /// <summary>
        /// thumbnails block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#thumbnails-1">ElastictranscoderPreset#thumbnails</a>
        /// </summary>
        [<CustomOperation "thumbnails">]
        member _.Thumbnails(state: ElastictranscoderPresetState<'Container>, value: aws.ElastictranscoderPreset.ElastictranscoderPresetThumbnails) : ElastictranscoderPresetState<'Container> =
            state.assignments.Add(fun config -> config.Thumbnails <- value)
            state : ElastictranscoderPresetState<'Container>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#type-1">ElastictranscoderPreset#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ElastictranscoderPresetState<'Container>, value: string) : ElastictranscoderPresetState<'Container> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : ElastictranscoderPresetState<'Container>

        /// <summary>
        /// video block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#video-1">ElastictranscoderPreset#video</a>
        /// </summary>
        [<CustomOperation "video">]
        member _.Video(state: ElastictranscoderPresetState<'Container>, value: aws.ElastictranscoderPreset.ElastictranscoderPresetVideo) : ElastictranscoderPresetState<'Container> =
            state.assignments.Add(fun config -> config.Video <- value)
            state : ElastictranscoderPresetState<'Container>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#video_codec_options-1">ElastictranscoderPreset#video_codec_options</a>.
        /// </summary>
        [<CustomOperation "video_codec_options">]
        member _.VideoCodecOptions(state: ElastictranscoderPresetState<'Container>, value: seq<string * string>) : ElastictranscoderPresetState<'Container> =
            state.assignments.Add(fun config -> config.VideoCodecOptions <- dict value)
            state : ElastictranscoderPresetState<'Container>

        /// <summary>
        /// video_watermarks block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#video_watermarks-1">ElastictranscoderPreset#video_watermarks</a> Accepts: aws.IResolvable | aws.ElastictranscoderPreset.ElastictranscoderPresetVideoWatermarks[]
        /// </summary>
        [<CustomOperation "video_watermarks">]
        member _.VideoWatermarks(state: ElastictranscoderPresetState<'Container>, value: HashiCorp.Cdktf.IResolvable) : ElastictranscoderPresetState<'Container> =
            state.assignments.Add(fun config -> config.VideoWatermarks <- value)
            state : ElastictranscoderPresetState<'Container>

        member _.Run(state: ElastictranscoderPresetState<Present>) : aws.ElastictranscoderPreset.ElastictranscoderPreset =
            let config = aws.ElastictranscoderPreset.ElastictranscoderPresetConfig()
            for setter in state.assignments do
                setter config
            aws.ElastictranscoderPreset.ElastictranscoderPreset(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elastictranscoderPreset: missing required arguments. Must call: container.", 9999, IsError = true)>]
        member _.Run(_: ElastictranscoderPresetState<_>) : aws.ElastictranscoderPreset.ElastictranscoderPreset =
            Unchecked.defaultof<aws.ElastictranscoderPreset.ElastictranscoderPreset>
