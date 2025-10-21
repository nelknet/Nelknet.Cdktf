namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKeyPairState = { assignments: ResizeArray<aws.DataAwsKeyPair.DataAwsKeyPairConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/key_pair">aws_key_pair</a>.
    /// </summary>
    type DataAwsKeyPairBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKeyPairState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsKeyPairState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/key_pair#filter-1">DataAwsKeyPair#filter</a> Accepts: aws.IResolvable | aws.DataAwsKeyPair.DataAwsKeyPairFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsKeyPairState, value: HashiCorp.Cdktf.IResolvable) : DataAwsKeyPairState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsKeyPairState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/key_pair#id-1">DataAwsKeyPair#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKeyPairState, value: string) : DataAwsKeyPairState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsKeyPairState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/key_pair#include_public_key-1">DataAwsKeyPair#include_public_key</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_public_key">]
        member _.IncludePublicKey(state: DataAwsKeyPairState, value: bool) : DataAwsKeyPairState =
            state.assignments.Add(fun config -> config.IncludePublicKey <- value)
            state : DataAwsKeyPairState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/key_pair#include_public_key-1">DataAwsKeyPair#include_public_key</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_public_key">]
        member _.IncludePublicKey(state: DataAwsKeyPairState, value: HashiCorp.Cdktf.IResolvable) : DataAwsKeyPairState =
            state.assignments.Add(fun config -> config.IncludePublicKey <- value)
            state : DataAwsKeyPairState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/key_pair#key_name-1">DataAwsKeyPair#key_name</a>.
        /// </summary>
        [<CustomOperation "key_name">]
        member _.KeyName(state: DataAwsKeyPairState, value: string) : DataAwsKeyPairState =
            state.assignments.Add(fun config -> config.KeyName <- value)
            state : DataAwsKeyPairState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/key_pair#key_pair_id-1">DataAwsKeyPair#key_pair_id</a>.
        /// </summary>
        [<CustomOperation "key_pair_id">]
        member _.KeyPairId(state: DataAwsKeyPairState, value: string) : DataAwsKeyPairState =
            state.assignments.Add(fun config -> config.KeyPairId <- value)
            state : DataAwsKeyPairState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/key_pair#tags-1">DataAwsKeyPair#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsKeyPairState, value: seq<string * string>) : DataAwsKeyPairState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsKeyPairState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/key_pair#timeouts-1">DataAwsKeyPair#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsKeyPairState, value: aws.DataAwsKeyPair.DataAwsKeyPairTimeouts) : DataAwsKeyPairState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsKeyPairState

        member _.Run(state: DataAwsKeyPairState) : aws.DataAwsKeyPair.DataAwsKeyPair =
            let config = aws.DataAwsKeyPair.DataAwsKeyPairConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKeyPair.DataAwsKeyPair(StackContext.get (), logicalId, config)
