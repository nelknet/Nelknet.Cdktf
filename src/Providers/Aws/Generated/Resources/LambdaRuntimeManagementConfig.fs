namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LambdaRuntimeManagementConfigState<'FunctionName> = { assignments: ResizeArray<aws.LambdaRuntimeManagementConfig.LambdaRuntimeManagementConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_runtime_management_config">aws_lambda_runtime_management_config</a>.
    /// </summary>
    type LambdaRuntimeManagementConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : LambdaRuntimeManagementConfigState<Missing> =
            ({ assignments = ResizeArray() } : LambdaRuntimeManagementConfigState<Missing>)

        member _.Zero(()) : LambdaRuntimeManagementConfigState<Missing> =
            ({ assignments = ResizeArray() } : LambdaRuntimeManagementConfigState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_runtime_management_config#function_name-1">LambdaRuntimeManagementConfig#function_name</a>.
        /// </summary>
        [<CustomOperation "function_name">]
        member _.FunctionName(state: LambdaRuntimeManagementConfigState<Missing>, value: string) : LambdaRuntimeManagementConfigState<Present> =
            state.assignments.Add(fun config -> config.FunctionName <- value)
            ({ assignments = state.assignments } : LambdaRuntimeManagementConfigState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_runtime_management_config#qualifier-1">LambdaRuntimeManagementConfig#qualifier</a>.
        /// </summary>
        [<CustomOperation "qualifier">]
        member _.Qualifier(state: LambdaRuntimeManagementConfigState<'FunctionName>, value: string) : LambdaRuntimeManagementConfigState<'FunctionName> =
            state.assignments.Add(fun config -> config.Qualifier <- value)
            state : LambdaRuntimeManagementConfigState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_runtime_management_config#runtime_version_arn-1">LambdaRuntimeManagementConfig#runtime_version_arn</a>.
        /// </summary>
        [<CustomOperation "runtime_version_arn">]
        member _.RuntimeVersionArn(state: LambdaRuntimeManagementConfigState<'FunctionName>, value: string) : LambdaRuntimeManagementConfigState<'FunctionName> =
            state.assignments.Add(fun config -> config.RuntimeVersionArn <- value)
            state : LambdaRuntimeManagementConfigState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_runtime_management_config#update_runtime_on-1">LambdaRuntimeManagementConfig#update_runtime_on</a>.
        /// </summary>
        [<CustomOperation "update_runtime_on">]
        member _.UpdateRuntimeOn(state: LambdaRuntimeManagementConfigState<'FunctionName>, value: string) : LambdaRuntimeManagementConfigState<'FunctionName> =
            state.assignments.Add(fun config -> config.UpdateRuntimeOn <- value)
            state : LambdaRuntimeManagementConfigState<'FunctionName>

        member _.Run(state: LambdaRuntimeManagementConfigState<Present>) : aws.LambdaRuntimeManagementConfig.LambdaRuntimeManagementConfig =
            let config = aws.LambdaRuntimeManagementConfig.LambdaRuntimeManagementConfigConfig()
            for setter in state.assignments do
                setter config
            aws.LambdaRuntimeManagementConfig.LambdaRuntimeManagementConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lambdaRuntimeManagementConfig: missing required arguments. Must call: function_name.", 9999, IsError = true)>]
        member _.Run(_: LambdaRuntimeManagementConfigState<_>) : aws.LambdaRuntimeManagementConfig.LambdaRuntimeManagementConfig =
            Unchecked.defaultof<aws.LambdaRuntimeManagementConfig.LambdaRuntimeManagementConfig>
