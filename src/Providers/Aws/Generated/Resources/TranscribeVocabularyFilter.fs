namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName> = { assignments: ResizeArray<aws.TranscribeVocabularyFilter.TranscribeVocabularyFilterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary_filter">aws_transcribe_vocabulary_filter</a>.
    /// </summary>
    type TranscribeVocabularyFilterBuilder(logicalId: string) =
        member _.Yield(_: unit) : TranscribeVocabularyFilterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TranscribeVocabularyFilterState<Missing, Missing>)

        member _.Zero(()) : TranscribeVocabularyFilterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TranscribeVocabularyFilterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary_filter#language_code-1">TranscribeVocabularyFilter#language_code</a>.
        /// </summary>
        [<CustomOperation "language_code">]
        member _.LanguageCode(state: TranscribeVocabularyFilterState<Missing, 'VocabularyFilterName>, value: string) : TranscribeVocabularyFilterState<Present, 'VocabularyFilterName> =
            state.assignments.Add(fun config -> config.LanguageCode <- value)
            ({ assignments = state.assignments } : TranscribeVocabularyFilterState<Present, 'VocabularyFilterName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary_filter#vocabulary_filter_name-1">TranscribeVocabularyFilter#vocabulary_filter_name</a>.
        /// </summary>
        [<CustomOperation "vocabulary_filter_name">]
        member _.VocabularyFilterName(state: TranscribeVocabularyFilterState<'LanguageCode, Missing>, value: string) : TranscribeVocabularyFilterState<'LanguageCode, Present> =
            state.assignments.Add(fun config -> config.VocabularyFilterName <- value)
            ({ assignments = state.assignments } : TranscribeVocabularyFilterState<'LanguageCode, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary_filter#id-1">TranscribeVocabularyFilter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName>, value: string) : TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary_filter#tags-1">TranscribeVocabularyFilter#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName>, value: seq<string * string>) : TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary_filter#tags_all-1">TranscribeVocabularyFilter#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName>, value: seq<string * string>) : TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary_filter#vocabulary_filter_file_uri-1">TranscribeVocabularyFilter#vocabulary_filter_file_uri</a>.
        /// </summary>
        [<CustomOperation "vocabulary_filter_file_uri">]
        member _.VocabularyFilterFileUri(state: TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName>, value: string) : TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName> =
            state.assignments.Add(fun config -> config.VocabularyFilterFileUri <- value)
            state : TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary_filter#words-1">TranscribeVocabularyFilter#words</a>.
        /// </summary>
        [<CustomOperation "words">]
        member _.Words(state: TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName>, value: seq<string>) : TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName> =
            state.assignments.Add(fun config -> config.Words <- (value |> Seq.toArray))
            state : TranscribeVocabularyFilterState<'LanguageCode, 'VocabularyFilterName>

        member _.Run(state: TranscribeVocabularyFilterState<Present, Present>) : aws.TranscribeVocabularyFilter.TranscribeVocabularyFilter =
            let config = aws.TranscribeVocabularyFilter.TranscribeVocabularyFilterConfig()
            for setter in state.assignments do
                setter config
            aws.TranscribeVocabularyFilter.TranscribeVocabularyFilter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.transcribeVocabularyFilter: missing required arguments. Must call: language_code, vocabulary_filter_name.", 9999, IsError = true)>]
        member _.Run(_: TranscribeVocabularyFilterState<_, _>) : aws.TranscribeVocabularyFilter.TranscribeVocabularyFilter =
            Unchecked.defaultof<aws.TranscribeVocabularyFilter.TranscribeVocabularyFilter>
