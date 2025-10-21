namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, 'VocabularyName> = { assignments: ResizeArray<aws.TranscribeMedicalVocabulary.TranscribeMedicalVocabularyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_medical_vocabulary">aws_transcribe_medical_vocabulary</a>.
    /// </summary>
    type TranscribeMedicalVocabularyBuilder(logicalId: string) =
        member _.Yield(_: unit) : TranscribeMedicalVocabularyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TranscribeMedicalVocabularyState<Missing, Missing, Missing>)

        member _.Zero(()) : TranscribeMedicalVocabularyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TranscribeMedicalVocabularyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_medical_vocabulary#language_code-1">TranscribeMedicalVocabulary#language_code</a>.
        /// </summary>
        [<CustomOperation "language_code">]
        member _.LanguageCode(state: TranscribeMedicalVocabularyState<Missing, 'VocabularyFileUri, 'VocabularyName>, value: string) : TranscribeMedicalVocabularyState<Present, 'VocabularyFileUri, 'VocabularyName> =
            state.assignments.Add(fun config -> config.LanguageCode <- value)
            ({ assignments = state.assignments } : TranscribeMedicalVocabularyState<Present, 'VocabularyFileUri, 'VocabularyName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_medical_vocabulary#vocabulary_file_uri-1">TranscribeMedicalVocabulary#vocabulary_file_uri</a>.
        /// </summary>
        [<CustomOperation "vocabulary_file_uri">]
        member _.VocabularyFileUri(state: TranscribeMedicalVocabularyState<'LanguageCode, Missing, 'VocabularyName>, value: string) : TranscribeMedicalVocabularyState<'LanguageCode, Present, 'VocabularyName> =
            state.assignments.Add(fun config -> config.VocabularyFileUri <- value)
            ({ assignments = state.assignments } : TranscribeMedicalVocabularyState<'LanguageCode, Present, 'VocabularyName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_medical_vocabulary#vocabulary_name-1">TranscribeMedicalVocabulary#vocabulary_name</a>.
        /// </summary>
        [<CustomOperation "vocabulary_name">]
        member _.VocabularyName(state: TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, Missing>, value: string) : TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, Present> =
            state.assignments.Add(fun config -> config.VocabularyName <- value)
            ({ assignments = state.assignments } : TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_medical_vocabulary#id-1">TranscribeMedicalVocabulary#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, 'VocabularyName>, value: string) : TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, 'VocabularyName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, 'VocabularyName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_medical_vocabulary#tags-1">TranscribeMedicalVocabulary#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, 'VocabularyName>, value: seq<string * string>) : TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, 'VocabularyName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, 'VocabularyName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_medical_vocabulary#tags_all-1">TranscribeMedicalVocabulary#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, 'VocabularyName>, value: seq<string * string>) : TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, 'VocabularyName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, 'VocabularyName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_medical_vocabulary#timeouts-1">TranscribeMedicalVocabulary#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, 'VocabularyName>, value: aws.TranscribeMedicalVocabulary.TranscribeMedicalVocabularyTimeouts) : TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, 'VocabularyName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : TranscribeMedicalVocabularyState<'LanguageCode, 'VocabularyFileUri, 'VocabularyName>

        member _.Run(state: TranscribeMedicalVocabularyState<Present, Present, Present>) : aws.TranscribeMedicalVocabulary.TranscribeMedicalVocabulary =
            let config = aws.TranscribeMedicalVocabulary.TranscribeMedicalVocabularyConfig()
            for setter in state.assignments do
                setter config
            aws.TranscribeMedicalVocabulary.TranscribeMedicalVocabulary(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.transcribeMedicalVocabulary: missing required arguments. Must call: language_code, vocabulary_file_uri, vocabulary_name.", 9999, IsError = true)>]
        member _.Run(_: TranscribeMedicalVocabularyState<_, _, _>) : aws.TranscribeMedicalVocabulary.TranscribeMedicalVocabulary =
            Unchecked.defaultof<aws.TranscribeMedicalVocabulary.TranscribeMedicalVocabulary>
