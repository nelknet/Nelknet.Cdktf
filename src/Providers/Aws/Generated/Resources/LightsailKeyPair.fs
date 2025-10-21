namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailKeyPairState = { assignments: ResizeArray<aws.LightsailKeyPair.LightsailKeyPairConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_key_pair">aws_lightsail_key_pair</a>.
    /// </summary>
    type LightsailKeyPairBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailKeyPairState =
            { assignments = ResizeArray() }

        member _.Zero(()) : LightsailKeyPairState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_key_pair#id-1">LightsailKeyPair#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailKeyPairState, value: string) : LightsailKeyPairState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailKeyPairState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_key_pair#name-1">LightsailKeyPair#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LightsailKeyPairState, value: string) : LightsailKeyPairState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : LightsailKeyPairState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_key_pair#name_prefix-1">LightsailKeyPair#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: LightsailKeyPairState, value: string) : LightsailKeyPairState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : LightsailKeyPairState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_key_pair#pgp_key-1">LightsailKeyPair#pgp_key</a>.
        /// </summary>
        [<CustomOperation "pgp_key">]
        member _.PgpKey(state: LightsailKeyPairState, value: string) : LightsailKeyPairState =
            state.assignments.Add(fun config -> config.PgpKey <- value)
            state : LightsailKeyPairState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_key_pair#public_key-1">LightsailKeyPair#public_key</a>.
        /// </summary>
        [<CustomOperation "public_key">]
        member _.PublicKey(state: LightsailKeyPairState, value: string) : LightsailKeyPairState =
            state.assignments.Add(fun config -> config.PublicKey <- value)
            state : LightsailKeyPairState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_key_pair#tags-1">LightsailKeyPair#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LightsailKeyPairState, value: seq<string * string>) : LightsailKeyPairState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LightsailKeyPairState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_key_pair#tags_all-1">LightsailKeyPair#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LightsailKeyPairState, value: seq<string * string>) : LightsailKeyPairState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LightsailKeyPairState

        member _.Run(state: LightsailKeyPairState) : aws.LightsailKeyPair.LightsailKeyPair =
            let config = aws.LightsailKeyPair.LightsailKeyPairConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailKeyPair.LightsailKeyPair(StackContext.get (), logicalId, config)
