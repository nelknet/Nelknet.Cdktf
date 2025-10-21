namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Macie2CustomDataIdentifierState = { assignments: ResizeArray<aws.Macie2CustomDataIdentifier.Macie2CustomDataIdentifierConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_custom_data_identifier">aws_macie2_custom_data_identifier</a>.
    /// </summary>
    type Macie2CustomDataIdentifierBuilder(logicalId: string) =
        member _.Yield(_: unit) : Macie2CustomDataIdentifierState =
            { assignments = ResizeArray() }

        member _.Zero(()) : Macie2CustomDataIdentifierState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_custom_data_identifier#description-1">Macie2CustomDataIdentifier#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Macie2CustomDataIdentifierState, value: string) : Macie2CustomDataIdentifierState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Macie2CustomDataIdentifierState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_custom_data_identifier#id-1">Macie2CustomDataIdentifier#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Macie2CustomDataIdentifierState, value: string) : Macie2CustomDataIdentifierState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Macie2CustomDataIdentifierState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_custom_data_identifier#ignore_words-1">Macie2CustomDataIdentifier#ignore_words</a>.
        /// </summary>
        [<CustomOperation "ignore_words">]
        member _.IgnoreWords(state: Macie2CustomDataIdentifierState, value: seq<string>) : Macie2CustomDataIdentifierState =
            state.assignments.Add(fun config -> config.IgnoreWords <- (value |> Seq.toArray))
            state : Macie2CustomDataIdentifierState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_custom_data_identifier#keywords-1">Macie2CustomDataIdentifier#keywords</a>.
        /// </summary>
        [<CustomOperation "keywords">]
        member _.Keywords(state: Macie2CustomDataIdentifierState, value: seq<string>) : Macie2CustomDataIdentifierState =
            state.assignments.Add(fun config -> config.Keywords <- (value |> Seq.toArray))
            state : Macie2CustomDataIdentifierState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_custom_data_identifier#maximum_match_distance-1">Macie2CustomDataIdentifier#maximum_match_distance</a>.
        /// </summary>
        [<CustomOperation "maximum_match_distance">]
        member _.MaximumMatchDistance(state: Macie2CustomDataIdentifierState, value: double) : Macie2CustomDataIdentifierState =
            state.assignments.Add(fun config -> config.MaximumMatchDistance <- value)
            state : Macie2CustomDataIdentifierState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_custom_data_identifier#name-1">Macie2CustomDataIdentifier#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Macie2CustomDataIdentifierState, value: string) : Macie2CustomDataIdentifierState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : Macie2CustomDataIdentifierState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_custom_data_identifier#name_prefix-1">Macie2CustomDataIdentifier#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: Macie2CustomDataIdentifierState, value: string) : Macie2CustomDataIdentifierState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : Macie2CustomDataIdentifierState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_custom_data_identifier#regex-1">Macie2CustomDataIdentifier#regex</a>.
        /// </summary>
        [<CustomOperation "regex">]
        member _.Regex(state: Macie2CustomDataIdentifierState, value: string) : Macie2CustomDataIdentifierState =
            state.assignments.Add(fun config -> config.Regex <- value)
            state : Macie2CustomDataIdentifierState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_custom_data_identifier#tags-1">Macie2CustomDataIdentifier#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Macie2CustomDataIdentifierState, value: seq<string * string>) : Macie2CustomDataIdentifierState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Macie2CustomDataIdentifierState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_custom_data_identifier#tags_all-1">Macie2CustomDataIdentifier#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Macie2CustomDataIdentifierState, value: seq<string * string>) : Macie2CustomDataIdentifierState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Macie2CustomDataIdentifierState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_custom_data_identifier#timeouts-1">Macie2CustomDataIdentifier#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Macie2CustomDataIdentifierState, value: aws.Macie2CustomDataIdentifier.Macie2CustomDataIdentifierTimeouts) : Macie2CustomDataIdentifierState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Macie2CustomDataIdentifierState

        member _.Run(state: Macie2CustomDataIdentifierState) : aws.Macie2CustomDataIdentifier.Macie2CustomDataIdentifier =
            let config = aws.Macie2CustomDataIdentifier.Macie2CustomDataIdentifierConfig()
            for setter in state.assignments do
                setter config
            aws.Macie2CustomDataIdentifier.Macie2CustomDataIdentifier(StackContext.get (), logicalId, config)
