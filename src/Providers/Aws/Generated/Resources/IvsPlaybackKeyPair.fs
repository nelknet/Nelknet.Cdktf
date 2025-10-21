namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IvsPlaybackKeyPairState<'PublicKey> = { assignments: ResizeArray<aws.IvsPlaybackKeyPair.IvsPlaybackKeyPairConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_playback_key_pair">aws_ivs_playback_key_pair</a>.
    /// </summary>
    type IvsPlaybackKeyPairBuilder(logicalId: string) =
        member _.Yield(_: unit) : IvsPlaybackKeyPairState<Missing> =
            ({ assignments = ResizeArray() } : IvsPlaybackKeyPairState<Missing>)

        member _.Zero(()) : IvsPlaybackKeyPairState<Missing> =
            ({ assignments = ResizeArray() } : IvsPlaybackKeyPairState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_playback_key_pair#public_key-1">IvsPlaybackKeyPair#public_key</a>.
        /// </summary>
        [<CustomOperation "public_key">]
        member _.PublicKey(state: IvsPlaybackKeyPairState<Missing>, value: string) : IvsPlaybackKeyPairState<Present> =
            state.assignments.Add(fun config -> config.PublicKey <- value)
            ({ assignments = state.assignments } : IvsPlaybackKeyPairState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_playback_key_pair#id-1">IvsPlaybackKeyPair#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IvsPlaybackKeyPairState<'PublicKey>, value: string) : IvsPlaybackKeyPairState<'PublicKey> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IvsPlaybackKeyPairState<'PublicKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_playback_key_pair#name-1">IvsPlaybackKeyPair#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IvsPlaybackKeyPairState<'PublicKey>, value: string) : IvsPlaybackKeyPairState<'PublicKey> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : IvsPlaybackKeyPairState<'PublicKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_playback_key_pair#tags-1">IvsPlaybackKeyPair#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IvsPlaybackKeyPairState<'PublicKey>, value: seq<string * string>) : IvsPlaybackKeyPairState<'PublicKey> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IvsPlaybackKeyPairState<'PublicKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_playback_key_pair#tags_all-1">IvsPlaybackKeyPair#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IvsPlaybackKeyPairState<'PublicKey>, value: seq<string * string>) : IvsPlaybackKeyPairState<'PublicKey> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IvsPlaybackKeyPairState<'PublicKey>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_playback_key_pair#timeouts-1">IvsPlaybackKeyPair#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IvsPlaybackKeyPairState<'PublicKey>, value: aws.IvsPlaybackKeyPair.IvsPlaybackKeyPairTimeouts) : IvsPlaybackKeyPairState<'PublicKey> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IvsPlaybackKeyPairState<'PublicKey>

        member _.Run(state: IvsPlaybackKeyPairState<Present>) : aws.IvsPlaybackKeyPair.IvsPlaybackKeyPair =
            let config = aws.IvsPlaybackKeyPair.IvsPlaybackKeyPairConfig()
            for setter in state.assignments do
                setter config
            aws.IvsPlaybackKeyPair.IvsPlaybackKeyPair(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ivsPlaybackKeyPair: missing required arguments. Must call: public_key.", 9999, IsError = true)>]
        member _.Run(_: IvsPlaybackKeyPairState<_>) : aws.IvsPlaybackKeyPair.IvsPlaybackKeyPair =
            Unchecked.defaultof<aws.IvsPlaybackKeyPair.IvsPlaybackKeyPair>
