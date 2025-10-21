namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontFieldLevelEncryptionConfigState<'ContentTypeProfileConfig, 'QueryArgProfileConfig> = { assignments: ResizeArray<aws.CloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_config">aws_cloudfront_field_level_encryption_config</a>.
    /// </summary>
    type CloudfrontFieldLevelEncryptionConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontFieldLevelEncryptionConfigState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontFieldLevelEncryptionConfigState<Missing, Missing>)

        member _.Zero(()) : CloudfrontFieldLevelEncryptionConfigState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontFieldLevelEncryptionConfigState<Missing, Missing>)

        /// <summary>
        /// content_type_profile_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_config#content_type_profile_config-1">CloudfrontFieldLevelEncryptionConfig#content_type_profile_config</a>
        /// </summary>
        [<CustomOperation "content_type_profile_config">]
        member _.ContentTypeProfileConfig(state: CloudfrontFieldLevelEncryptionConfigState<Missing, 'QueryArgProfileConfig>, value: aws.CloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig) : CloudfrontFieldLevelEncryptionConfigState<Present, 'QueryArgProfileConfig> =
            state.assignments.Add(fun config -> config.ContentTypeProfileConfig <- value)
            ({ assignments = state.assignments } : CloudfrontFieldLevelEncryptionConfigState<Present, 'QueryArgProfileConfig>)

        /// <summary>
        /// query_arg_profile_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_config#query_arg_profile_config-1">CloudfrontFieldLevelEncryptionConfig#query_arg_profile_config</a>
        /// </summary>
        [<CustomOperation "query_arg_profile_config">]
        member _.QueryArgProfileConfig(state: CloudfrontFieldLevelEncryptionConfigState<'ContentTypeProfileConfig, Missing>, value: aws.CloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig) : CloudfrontFieldLevelEncryptionConfigState<'ContentTypeProfileConfig, Present> =
            state.assignments.Add(fun config -> config.QueryArgProfileConfig <- value)
            ({ assignments = state.assignments } : CloudfrontFieldLevelEncryptionConfigState<'ContentTypeProfileConfig, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_config#comment-1">CloudfrontFieldLevelEncryptionConfig#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: CloudfrontFieldLevelEncryptionConfigState<'ContentTypeProfileConfig, 'QueryArgProfileConfig>, value: string) : CloudfrontFieldLevelEncryptionConfigState<'ContentTypeProfileConfig, 'QueryArgProfileConfig> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : CloudfrontFieldLevelEncryptionConfigState<'ContentTypeProfileConfig, 'QueryArgProfileConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_config#id-1">CloudfrontFieldLevelEncryptionConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudfrontFieldLevelEncryptionConfigState<'ContentTypeProfileConfig, 'QueryArgProfileConfig>, value: string) : CloudfrontFieldLevelEncryptionConfigState<'ContentTypeProfileConfig, 'QueryArgProfileConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudfrontFieldLevelEncryptionConfigState<'ContentTypeProfileConfig, 'QueryArgProfileConfig>

        member _.Run(state: CloudfrontFieldLevelEncryptionConfigState<Present, Present>) : aws.CloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfig =
            let config = aws.CloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontFieldLevelEncryptionConfig: missing required arguments. Must call: content_type_profile_config, query_arg_profile_config.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontFieldLevelEncryptionConfigState<_, _>) : aws.CloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfig =
            Unchecked.defaultof<aws.CloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfig>
