namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLambdaCodeSigningConfigState<'Arn> = { assignments: ResizeArray<aws.DataAwsLambdaCodeSigningConfig.DataAwsLambdaCodeSigningConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_code_signing_config">aws_lambda_code_signing_config</a>.
    /// </summary>
    type DataAwsLambdaCodeSigningConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLambdaCodeSigningConfigState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLambdaCodeSigningConfigState<Missing>)

        member _.Zero(()) : DataAwsLambdaCodeSigningConfigState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLambdaCodeSigningConfigState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_code_signing_config#arn-1">DataAwsLambdaCodeSigningConfig#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsLambdaCodeSigningConfigState<Missing>, value: string) : DataAwsLambdaCodeSigningConfigState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsLambdaCodeSigningConfigState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_code_signing_config#id-1">DataAwsLambdaCodeSigningConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLambdaCodeSigningConfigState<'Arn>, value: string) : DataAwsLambdaCodeSigningConfigState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLambdaCodeSigningConfigState<'Arn>

        member _.Run(state: DataAwsLambdaCodeSigningConfigState<Present>) : aws.DataAwsLambdaCodeSigningConfig.DataAwsLambdaCodeSigningConfig =
            let config = aws.DataAwsLambdaCodeSigningConfig.DataAwsLambdaCodeSigningConfigConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLambdaCodeSigningConfig.DataAwsLambdaCodeSigningConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLambdaCodeSigningConfig: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLambdaCodeSigningConfigState<_>) : aws.DataAwsLambdaCodeSigningConfig.DataAwsLambdaCodeSigningConfig =
            Unchecked.defaultof<aws.DataAwsLambdaCodeSigningConfig.DataAwsLambdaCodeSigningConfig>
