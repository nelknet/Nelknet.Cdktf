namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, 'ModelName> = { assignments: ResizeArray<aws.TranscribeLanguageModel.TranscribeLanguageModelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_language_model">aws_transcribe_language_model</a>.
    /// </summary>
    type TranscribeLanguageModelBuilder(logicalId: string) =
        member _.Yield(_: unit) : TranscribeLanguageModelState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TranscribeLanguageModelState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : TranscribeLanguageModelState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TranscribeLanguageModelState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_language_model#base_model_name-1">TranscribeLanguageModel#base_model_name</a>.
        /// </summary>
        [<CustomOperation "base_model_name">]
        member _.BaseModelName(state: TranscribeLanguageModelState<Missing, 'InputDataConfig, 'LanguageCode, 'ModelName>, value: string) : TranscribeLanguageModelState<Present, 'InputDataConfig, 'LanguageCode, 'ModelName> =
            state.assignments.Add(fun config -> config.BaseModelName <- value)
            ({ assignments = state.assignments } : TranscribeLanguageModelState<Present, 'InputDataConfig, 'LanguageCode, 'ModelName>)

        /// <summary>
        /// input_data_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_language_model#input_data_config-1">TranscribeLanguageModel#input_data_config</a>
        /// </summary>
        [<CustomOperation "input_data_config">]
        member _.InputDataConfig(state: TranscribeLanguageModelState<'BaseModelName, Missing, 'LanguageCode, 'ModelName>, value: aws.TranscribeLanguageModel.TranscribeLanguageModelInputDataConfig) : TranscribeLanguageModelState<'BaseModelName, Present, 'LanguageCode, 'ModelName> =
            state.assignments.Add(fun config -> config.InputDataConfig <- value)
            ({ assignments = state.assignments } : TranscribeLanguageModelState<'BaseModelName, Present, 'LanguageCode, 'ModelName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_language_model#language_code-1">TranscribeLanguageModel#language_code</a>.
        /// </summary>
        [<CustomOperation "language_code">]
        member _.LanguageCode(state: TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, Missing, 'ModelName>, value: string) : TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, Present, 'ModelName> =
            state.assignments.Add(fun config -> config.LanguageCode <- value)
            ({ assignments = state.assignments } : TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, Present, 'ModelName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_language_model#model_name-1">TranscribeLanguageModel#model_name</a>.
        /// </summary>
        [<CustomOperation "model_name">]
        member _.ModelName(state: TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, Missing>, value: string) : TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, Present> =
            state.assignments.Add(fun config -> config.ModelName <- value)
            ({ assignments = state.assignments } : TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_language_model#id-1">TranscribeLanguageModel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, 'ModelName>, value: string) : TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, 'ModelName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, 'ModelName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_language_model#tags-1">TranscribeLanguageModel#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, 'ModelName>, value: seq<string * string>) : TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, 'ModelName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, 'ModelName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_language_model#tags_all-1">TranscribeLanguageModel#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, 'ModelName>, value: seq<string * string>) : TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, 'ModelName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, 'ModelName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_language_model#timeouts-1">TranscribeLanguageModel#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, 'ModelName>, value: aws.TranscribeLanguageModel.TranscribeLanguageModelTimeouts) : TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, 'ModelName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : TranscribeLanguageModelState<'BaseModelName, 'InputDataConfig, 'LanguageCode, 'ModelName>

        member _.Run(state: TranscribeLanguageModelState<Present, Present, Present, Present>) : aws.TranscribeLanguageModel.TranscribeLanguageModel =
            let config = aws.TranscribeLanguageModel.TranscribeLanguageModelConfig()
            for setter in state.assignments do
                setter config
            aws.TranscribeLanguageModel.TranscribeLanguageModel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.transcribeLanguageModel: missing required arguments. Must call: base_model_name, input_data_config, language_code, model_name.", 9999, IsError = true)>]
        member _.Run(_: TranscribeLanguageModelState<_, _, _, _>) : aws.TranscribeLanguageModel.TranscribeLanguageModel =
            Unchecked.defaultof<aws.TranscribeLanguageModel.TranscribeLanguageModel>
