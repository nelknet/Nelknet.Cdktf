namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LambdaCodeSigningConfigState<'AllowedPublishers> = { assignments: ResizeArray<aws.LambdaCodeSigningConfig.LambdaCodeSigningConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config">aws_lambda_code_signing_config</a>.
    /// </summary>
    type LambdaCodeSigningConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : LambdaCodeSigningConfigState<Missing> =
            ({ assignments = ResizeArray() } : LambdaCodeSigningConfigState<Missing>)

        member _.Zero(()) : LambdaCodeSigningConfigState<Missing> =
            ({ assignments = ResizeArray() } : LambdaCodeSigningConfigState<Missing>)

        /// <summary>
        /// allowed_publishers block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config#allowed_publishers-1">LambdaCodeSigningConfig#allowed_publishers</a>
        /// </summary>
        [<CustomOperation "allowed_publishers">]
        member _.AllowedPublishers(state: LambdaCodeSigningConfigState<Missing>, value: aws.LambdaCodeSigningConfig.LambdaCodeSigningConfigAllowedPublishers) : LambdaCodeSigningConfigState<Present> =
            state.assignments.Add(fun config -> config.AllowedPublishers <- value)
            ({ assignments = state.assignments } : LambdaCodeSigningConfigState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config#description-1">LambdaCodeSigningConfig#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LambdaCodeSigningConfigState<'AllowedPublishers>, value: string) : LambdaCodeSigningConfigState<'AllowedPublishers> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LambdaCodeSigningConfigState<'AllowedPublishers>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config#id-1">LambdaCodeSigningConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LambdaCodeSigningConfigState<'AllowedPublishers>, value: string) : LambdaCodeSigningConfigState<'AllowedPublishers> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LambdaCodeSigningConfigState<'AllowedPublishers>

        /// <summary>
        /// policies block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config#policies-1">LambdaCodeSigningConfig#policies</a>
        /// </summary>
        [<CustomOperation "policies">]
        member _.Policies(state: LambdaCodeSigningConfigState<'AllowedPublishers>, value: aws.LambdaCodeSigningConfig.LambdaCodeSigningConfigPolicies) : LambdaCodeSigningConfigState<'AllowedPublishers> =
            state.assignments.Add(fun config -> config.Policies <- value)
            state : LambdaCodeSigningConfigState<'AllowedPublishers>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config#tags-1">LambdaCodeSigningConfig#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LambdaCodeSigningConfigState<'AllowedPublishers>, value: seq<string * string>) : LambdaCodeSigningConfigState<'AllowedPublishers> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LambdaCodeSigningConfigState<'AllowedPublishers>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config#tags_all-1">LambdaCodeSigningConfig#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LambdaCodeSigningConfigState<'AllowedPublishers>, value: seq<string * string>) : LambdaCodeSigningConfigState<'AllowedPublishers> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LambdaCodeSigningConfigState<'AllowedPublishers>

        member _.Run(state: LambdaCodeSigningConfigState<Present>) : aws.LambdaCodeSigningConfig.LambdaCodeSigningConfig =
            let config = aws.LambdaCodeSigningConfig.LambdaCodeSigningConfigConfig()
            for setter in state.assignments do
                setter config
            aws.LambdaCodeSigningConfig.LambdaCodeSigningConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lambdaCodeSigningConfig: missing required arguments. Must call: allowed_publishers.", 9999, IsError = true)>]
        member _.Run(_: LambdaCodeSigningConfigState<_>) : aws.LambdaCodeSigningConfig.LambdaCodeSigningConfig =
            Unchecked.defaultof<aws.LambdaCodeSigningConfig.LambdaCodeSigningConfig>
