namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> = { assignments: ResizeArray<aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer">aws_comprehend_entity_recognizer</a>.
    /// </summary>
    type ComprehendEntityRecognizerBuilder(logicalId: string) =
        member _.Yield(_: unit) : ComprehendEntityRecognizerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ComprehendEntityRecognizerState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ComprehendEntityRecognizerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ComprehendEntityRecognizerState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#data_access_role_arn-1">ComprehendEntityRecognizer#data_access_role_arn</a>.
        /// </summary>
        [<CustomOperation "data_access_role_arn">]
        member _.DataAccessRoleArn(state: ComprehendEntityRecognizerState<Missing, 'InputDataConfig, 'LanguageCode, 'Name>, value: string) : ComprehendEntityRecognizerState<Present, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.DataAccessRoleArn <- value)
            ({ assignments = state.assignments } : ComprehendEntityRecognizerState<Present, 'InputDataConfig, 'LanguageCode, 'Name>)

        /// <summary>
        /// input_data_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#input_data_config-1">ComprehendEntityRecognizer#input_data_config</a>
        /// </summary>
        [<CustomOperation "input_data_config">]
        member _.InputDataConfig(state: ComprehendEntityRecognizerState<'DataAccessRoleArn, Missing, 'LanguageCode, 'Name>, value: aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfig) : ComprehendEntityRecognizerState<'DataAccessRoleArn, Present, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.InputDataConfig <- value)
            ({ assignments = state.assignments } : ComprehendEntityRecognizerState<'DataAccessRoleArn, Present, 'LanguageCode, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#language_code-1">ComprehendEntityRecognizer#language_code</a>.
        /// </summary>
        [<CustomOperation "language_code">]
        member _.LanguageCode(state: ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, Missing, 'Name>, value: string) : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, Present, 'Name> =
            state.assignments.Add(fun config -> config.LanguageCode <- value)
            ({ assignments = state.assignments } : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#name-1">ComprehendEntityRecognizer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, Missing>, value: string) : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#id-1">ComprehendEntityRecognizer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: string) : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#model_kms_key_id-1">ComprehendEntityRecognizer#model_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "model_kms_key_id">]
        member _.ModelKmsKeyId(state: ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: string) : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.ModelKmsKeyId <- value)
            state : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#tags-1">ComprehendEntityRecognizer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: seq<string * string>) : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#tags_all-1">ComprehendEntityRecognizer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: seq<string * string>) : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#timeouts-1">ComprehendEntityRecognizer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerTimeouts) : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#version_name-1">ComprehendEntityRecognizer#version_name</a>.
        /// </summary>
        [<CustomOperation "version_name">]
        member _.VersionName(state: ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: string) : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.VersionName <- value)
            state : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#version_name_prefix-1">ComprehendEntityRecognizer#version_name_prefix</a>.
        /// </summary>
        [<CustomOperation "version_name_prefix">]
        member _.VersionNamePrefix(state: ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: string) : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.VersionNamePrefix <- value)
            state : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#volume_kms_key_id-1">ComprehendEntityRecognizer#volume_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "volume_kms_key_id">]
        member _.VolumeKmsKeyId(state: ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: string) : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.VolumeKmsKeyId <- value)
            state : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// vpc_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#vpc_config-1">ComprehendEntityRecognizer#vpc_config</a>
        /// </summary>
        [<CustomOperation "vpc_config">]
        member _.VpcConfig(state: ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerVpcConfig) : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.VpcConfig <- value)
            state : ComprehendEntityRecognizerState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        member _.Run(state: ComprehendEntityRecognizerState<Present, Present, Present, Present>) : aws.ComprehendEntityRecognizer.ComprehendEntityRecognizer =
            let config = aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerConfig()
            for setter in state.assignments do
                setter config
            aws.ComprehendEntityRecognizer.ComprehendEntityRecognizer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.comprehendEntityRecognizer: missing required arguments. Must call: data_access_role_arn, input_data_config, language_code, name.", 9999, IsError = true)>]
        member _.Run(_: ComprehendEntityRecognizerState<_, _, _, _>) : aws.ComprehendEntityRecognizer.ComprehendEntityRecognizer =
            Unchecked.defaultof<aws.ComprehendEntityRecognizer.ComprehendEntityRecognizer>
