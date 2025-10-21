namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LambdaFunctionRecursionConfigState<'FunctionName, 'RecursiveLoop> = { assignments: ResizeArray<aws.LambdaFunctionRecursionConfig.LambdaFunctionRecursionConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_recursion_config">aws_lambda_function_recursion_config</a>.
    /// </summary>
    type LambdaFunctionRecursionConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : LambdaFunctionRecursionConfigState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaFunctionRecursionConfigState<Missing, Missing>)

        member _.Zero(()) : LambdaFunctionRecursionConfigState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaFunctionRecursionConfigState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_recursion_config#function_name-1">LambdaFunctionRecursionConfig#function_name</a>.
        /// </summary>
        [<CustomOperation "function_name">]
        member _.FunctionName(state: LambdaFunctionRecursionConfigState<Missing, 'RecursiveLoop>, value: string) : LambdaFunctionRecursionConfigState<Present, 'RecursiveLoop> =
            state.assignments.Add(fun config -> config.FunctionName <- value)
            ({ assignments = state.assignments } : LambdaFunctionRecursionConfigState<Present, 'RecursiveLoop>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_recursion_config#recursive_loop-1">LambdaFunctionRecursionConfig#recursive_loop</a>.
        /// </summary>
        [<CustomOperation "recursive_loop">]
        member _.RecursiveLoop(state: LambdaFunctionRecursionConfigState<'FunctionName, Missing>, value: string) : LambdaFunctionRecursionConfigState<'FunctionName, Present> =
            state.assignments.Add(fun config -> config.RecursiveLoop <- value)
            ({ assignments = state.assignments } : LambdaFunctionRecursionConfigState<'FunctionName, Present>)

        member _.Run(state: LambdaFunctionRecursionConfigState<Present, Present>) : aws.LambdaFunctionRecursionConfig.LambdaFunctionRecursionConfig =
            let config = aws.LambdaFunctionRecursionConfig.LambdaFunctionRecursionConfigConfig()
            for setter in state.assignments do
                setter config
            aws.LambdaFunctionRecursionConfig.LambdaFunctionRecursionConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lambdaFunctionRecursionConfig: missing required arguments. Must call: function_name, recursive_loop.", 9999, IsError = true)>]
        member _.Run(_: LambdaFunctionRecursionConfigState<_, _>) : aws.LambdaFunctionRecursionConfig.LambdaFunctionRecursionConfig =
            Unchecked.defaultof<aws.LambdaFunctionRecursionConfig.LambdaFunctionRecursionConfig>
