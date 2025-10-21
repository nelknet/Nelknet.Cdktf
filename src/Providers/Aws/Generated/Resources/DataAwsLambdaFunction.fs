namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLambdaFunctionState<'FunctionName> = { assignments: ResizeArray<aws.DataAwsLambdaFunction.DataAwsLambdaFunctionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_function">aws_lambda_function</a>.
    /// </summary>
    type DataAwsLambdaFunctionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLambdaFunctionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLambdaFunctionState<Missing>)

        member _.Zero(()) : DataAwsLambdaFunctionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLambdaFunctionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_function#function_name-1">DataAwsLambdaFunction#function_name</a>.
        /// </summary>
        [<CustomOperation "function_name">]
        member _.FunctionName(state: DataAwsLambdaFunctionState<Missing>, value: string) : DataAwsLambdaFunctionState<Present> =
            state.assignments.Add(fun config -> config.FunctionName <- value)
            ({ assignments = state.assignments } : DataAwsLambdaFunctionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_function#id-1">DataAwsLambdaFunction#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLambdaFunctionState<'FunctionName>, value: string) : DataAwsLambdaFunctionState<'FunctionName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLambdaFunctionState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_function#qualifier-1">DataAwsLambdaFunction#qualifier</a>.
        /// </summary>
        [<CustomOperation "qualifier">]
        member _.Qualifier(state: DataAwsLambdaFunctionState<'FunctionName>, value: string) : DataAwsLambdaFunctionState<'FunctionName> =
            state.assignments.Add(fun config -> config.Qualifier <- value)
            state : DataAwsLambdaFunctionState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_function#tags-1">DataAwsLambdaFunction#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsLambdaFunctionState<'FunctionName>, value: seq<string * string>) : DataAwsLambdaFunctionState<'FunctionName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsLambdaFunctionState<'FunctionName>

        member _.Run(state: DataAwsLambdaFunctionState<Present>) : aws.DataAwsLambdaFunction.DataAwsLambdaFunction =
            let config = aws.DataAwsLambdaFunction.DataAwsLambdaFunctionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLambdaFunction.DataAwsLambdaFunction(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLambdaFunction: missing required arguments. Must call: function_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLambdaFunctionState<_>) : aws.DataAwsLambdaFunction.DataAwsLambdaFunction =
            Unchecked.defaultof<aws.DataAwsLambdaFunction.DataAwsLambdaFunction>
