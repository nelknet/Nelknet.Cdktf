namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> = { assignments: ResizeArray<aws.ComprehendDocumentClassifier.ComprehendDocumentClassifierConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier">aws_comprehend_document_classifier</a>.
    /// </summary>
    type ComprehendDocumentClassifierBuilder(logicalId: string) =
        member _.Yield(_: unit) : ComprehendDocumentClassifierState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ComprehendDocumentClassifierState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ComprehendDocumentClassifierState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ComprehendDocumentClassifierState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#data_access_role_arn-1">ComprehendDocumentClassifier#data_access_role_arn</a>.
        /// </summary>
        [<CustomOperation "data_access_role_arn">]
        member _.DataAccessRoleArn(state: ComprehendDocumentClassifierState<Missing, 'InputDataConfig, 'LanguageCode, 'Name>, value: string) : ComprehendDocumentClassifierState<Present, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.DataAccessRoleArn <- value)
            ({ assignments = state.assignments } : ComprehendDocumentClassifierState<Present, 'InputDataConfig, 'LanguageCode, 'Name>)

        /// <summary>
        /// input_data_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#input_data_config-1">ComprehendDocumentClassifier#input_data_config</a>
        /// </summary>
        [<CustomOperation "input_data_config">]
        member _.InputDataConfig(state: ComprehendDocumentClassifierState<'DataAccessRoleArn, Missing, 'LanguageCode, 'Name>, value: aws.ComprehendDocumentClassifier.ComprehendDocumentClassifierInputDataConfig) : ComprehendDocumentClassifierState<'DataAccessRoleArn, Present, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.InputDataConfig <- value)
            ({ assignments = state.assignments } : ComprehendDocumentClassifierState<'DataAccessRoleArn, Present, 'LanguageCode, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#language_code-1">ComprehendDocumentClassifier#language_code</a>.
        /// </summary>
        [<CustomOperation "language_code">]
        member _.LanguageCode(state: ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, Missing, 'Name>, value: string) : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, Present, 'Name> =
            state.assignments.Add(fun config -> config.LanguageCode <- value)
            ({ assignments = state.assignments } : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#name-1">ComprehendDocumentClassifier#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, Missing>, value: string) : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#id-1">ComprehendDocumentClassifier#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: string) : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#mode-1">ComprehendDocumentClassifier#mode</a>.
        /// </summary>
        [<CustomOperation "mode">]
        member _.Mode(state: ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: string) : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.Mode <- value)
            state : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#model_kms_key_id-1">ComprehendDocumentClassifier#model_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "model_kms_key_id">]
        member _.ModelKmsKeyId(state: ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: string) : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.ModelKmsKeyId <- value)
            state : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// output_data_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#output_data_config-1">ComprehendDocumentClassifier#output_data_config</a>
        /// </summary>
        [<CustomOperation "output_data_config">]
        member _.OutputDataConfig(state: ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: aws.ComprehendDocumentClassifier.ComprehendDocumentClassifierOutputDataConfig) : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.OutputDataConfig <- value)
            state : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#tags-1">ComprehendDocumentClassifier#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: seq<string * string>) : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#tags_all-1">ComprehendDocumentClassifier#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: seq<string * string>) : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#timeouts-1">ComprehendDocumentClassifier#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: aws.ComprehendDocumentClassifier.ComprehendDocumentClassifierTimeouts) : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#version_name-1">ComprehendDocumentClassifier#version_name</a>.
        /// </summary>
        [<CustomOperation "version_name">]
        member _.VersionName(state: ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: string) : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.VersionName <- value)
            state : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#version_name_prefix-1">ComprehendDocumentClassifier#version_name_prefix</a>.
        /// </summary>
        [<CustomOperation "version_name_prefix">]
        member _.VersionNamePrefix(state: ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: string) : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.VersionNamePrefix <- value)
            state : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#volume_kms_key_id-1">ComprehendDocumentClassifier#volume_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "volume_kms_key_id">]
        member _.VolumeKmsKeyId(state: ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: string) : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.VolumeKmsKeyId <- value)
            state : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        /// <summary>
        /// vpc_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#vpc_config-1">ComprehendDocumentClassifier#vpc_config</a>
        /// </summary>
        [<CustomOperation "vpc_config">]
        member _.VpcConfig(state: ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>, value: aws.ComprehendDocumentClassifier.ComprehendDocumentClassifierVpcConfig) : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.VpcConfig <- value)
            state : ComprehendDocumentClassifierState<'DataAccessRoleArn, 'InputDataConfig, 'LanguageCode, 'Name>

        member _.Run(state: ComprehendDocumentClassifierState<Present, Present, Present, Present>) : aws.ComprehendDocumentClassifier.ComprehendDocumentClassifier =
            let config = aws.ComprehendDocumentClassifier.ComprehendDocumentClassifierConfig()
            for setter in state.assignments do
                setter config
            aws.ComprehendDocumentClassifier.ComprehendDocumentClassifier(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.comprehendDocumentClassifier: missing required arguments. Must call: data_access_role_arn, input_data_config, language_code, name.", 9999, IsError = true)>]
        member _.Run(_: ComprehendDocumentClassifierState<_, _, _, _>) : aws.ComprehendDocumentClassifier.ComprehendDocumentClassifier =
            Unchecked.defaultof<aws.ComprehendDocumentClassifier.ComprehendDocumentClassifier>
