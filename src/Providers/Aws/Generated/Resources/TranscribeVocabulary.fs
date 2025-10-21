namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TranscribeVocabularyState<'LanguageCode, 'VocabularyName> = { assignments: ResizeArray<aws.TranscribeVocabulary.TranscribeVocabularyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary">aws_transcribe_vocabulary</a>.
    /// </summary>
    type TranscribeVocabularyBuilder(logicalId: string) =
        member _.Yield(_: unit) : TranscribeVocabularyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TranscribeVocabularyState<Missing, Missing>)

        member _.Zero(()) : TranscribeVocabularyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TranscribeVocabularyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary#language_code-1">TranscribeVocabulary#language_code</a>.
        /// </summary>
        [<CustomOperation "language_code">]
        member _.LanguageCode(state: TranscribeVocabularyState<Missing, 'VocabularyName>, value: string) : TranscribeVocabularyState<Present, 'VocabularyName> =
            state.assignments.Add(fun config -> config.LanguageCode <- value)
            ({ assignments = state.assignments } : TranscribeVocabularyState<Present, 'VocabularyName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary#vocabulary_name-1">TranscribeVocabulary#vocabulary_name</a>.
        /// </summary>
        [<CustomOperation "vocabulary_name">]
        member _.VocabularyName(state: TranscribeVocabularyState<'LanguageCode, Missing>, value: string) : TranscribeVocabularyState<'LanguageCode, Present> =
            state.assignments.Add(fun config -> config.VocabularyName <- value)
            ({ assignments = state.assignments } : TranscribeVocabularyState<'LanguageCode, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary#id-1">TranscribeVocabulary#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TranscribeVocabularyState<'LanguageCode, 'VocabularyName>, value: string) : TranscribeVocabularyState<'LanguageCode, 'VocabularyName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TranscribeVocabularyState<'LanguageCode, 'VocabularyName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary#phrases-1">TranscribeVocabulary#phrases</a>.
        /// </summary>
        [<CustomOperation "phrases">]
        member _.Phrases(state: TranscribeVocabularyState<'LanguageCode, 'VocabularyName>, value: seq<string>) : TranscribeVocabularyState<'LanguageCode, 'VocabularyName> =
            state.assignments.Add(fun config -> config.Phrases <- (value |> Seq.toArray))
            state : TranscribeVocabularyState<'LanguageCode, 'VocabularyName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary#tags-1">TranscribeVocabulary#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TranscribeVocabularyState<'LanguageCode, 'VocabularyName>, value: seq<string * string>) : TranscribeVocabularyState<'LanguageCode, 'VocabularyName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TranscribeVocabularyState<'LanguageCode, 'VocabularyName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary#tags_all-1">TranscribeVocabulary#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: TranscribeVocabularyState<'LanguageCode, 'VocabularyName>, value: seq<string * string>) : TranscribeVocabularyState<'LanguageCode, 'VocabularyName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : TranscribeVocabularyState<'LanguageCode, 'VocabularyName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary#timeouts-1">TranscribeVocabulary#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: TranscribeVocabularyState<'LanguageCode, 'VocabularyName>, value: aws.TranscribeVocabulary.TranscribeVocabularyTimeouts) : TranscribeVocabularyState<'LanguageCode, 'VocabularyName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : TranscribeVocabularyState<'LanguageCode, 'VocabularyName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_vocabulary#vocabulary_file_uri-1">TranscribeVocabulary#vocabulary_file_uri</a>.
        /// </summary>
        [<CustomOperation "vocabulary_file_uri">]
        member _.VocabularyFileUri(state: TranscribeVocabularyState<'LanguageCode, 'VocabularyName>, value: string) : TranscribeVocabularyState<'LanguageCode, 'VocabularyName> =
            state.assignments.Add(fun config -> config.VocabularyFileUri <- value)
            state : TranscribeVocabularyState<'LanguageCode, 'VocabularyName>

        member _.Run(state: TranscribeVocabularyState<Present, Present>) : aws.TranscribeVocabulary.TranscribeVocabulary =
            let config = aws.TranscribeVocabulary.TranscribeVocabularyConfig()
            for setter in state.assignments do
                setter config
            aws.TranscribeVocabulary.TranscribeVocabulary(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.transcribeVocabulary: missing required arguments. Must call: language_code, vocabulary_name.", 9999, IsError = true)>]
        member _.Run(_: TranscribeVocabularyState<_, _>) : aws.TranscribeVocabulary.TranscribeVocabulary =
            Unchecked.defaultof<aws.TranscribeVocabulary.TranscribeVocabulary>
