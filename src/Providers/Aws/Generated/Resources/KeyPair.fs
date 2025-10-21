namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyPairState<'PublicKey> = { assignments: ResizeArray<aws.KeyPair.KeyPairConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/key_pair">aws_key_pair</a>.
    /// </summary>
    type KeyPairBuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyPairState<Missing> =
            ({ assignments = ResizeArray() } : KeyPairState<Missing>)

        member _.Zero(()) : KeyPairState<Missing> =
            ({ assignments = ResizeArray() } : KeyPairState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/key_pair#public_key-1">KeyPair#public_key</a>.
        /// </summary>
        [<CustomOperation "public_key">]
        member _.PublicKey(state: KeyPairState<Missing>, value: string) : KeyPairState<Present> =
            state.assignments.Add(fun config -> config.PublicKey <- value)
            ({ assignments = state.assignments } : KeyPairState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/key_pair#id-1">KeyPair#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyPairState<'PublicKey>, value: string) : KeyPairState<'PublicKey> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyPairState<'PublicKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/key_pair#key_name-1">KeyPair#key_name</a>.
        /// </summary>
        [<CustomOperation "key_name">]
        member _.KeyName(state: KeyPairState<'PublicKey>, value: string) : KeyPairState<'PublicKey> =
            state.assignments.Add(fun config -> config.KeyName <- value)
            state : KeyPairState<'PublicKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/key_pair#key_name_prefix-1">KeyPair#key_name_prefix</a>.
        /// </summary>
        [<CustomOperation "key_name_prefix">]
        member _.KeyNamePrefix(state: KeyPairState<'PublicKey>, value: string) : KeyPairState<'PublicKey> =
            state.assignments.Add(fun config -> config.KeyNamePrefix <- value)
            state : KeyPairState<'PublicKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/key_pair#tags-1">KeyPair#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KeyPairState<'PublicKey>, value: seq<string * string>) : KeyPairState<'PublicKey> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KeyPairState<'PublicKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/key_pair#tags_all-1">KeyPair#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KeyPairState<'PublicKey>, value: seq<string * string>) : KeyPairState<'PublicKey> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KeyPairState<'PublicKey>

        member _.Run(state: KeyPairState<Present>) : aws.KeyPair.KeyPair =
            let config = aws.KeyPair.KeyPairConfig()
            for setter in state.assignments do
                setter config
            aws.KeyPair.KeyPair(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.keyPair: missing required arguments. Must call: public_key.", 9999, IsError = true)>]
        member _.Run(_: KeyPairState<_>) : aws.KeyPair.KeyPair =
            Unchecked.defaultof<aws.KeyPair.KeyPair>
