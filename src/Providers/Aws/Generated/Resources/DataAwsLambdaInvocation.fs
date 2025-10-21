namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLambdaInvocationState<'FunctionName, 'Input> = { assignments: ResizeArray<aws.DataAwsLambdaInvocation.DataAwsLambdaInvocationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_invocation">aws_lambda_invocation</a>.
    /// </summary>
    type DataAwsLambdaInvocationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLambdaInvocationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsLambdaInvocationState<Missing, Missing>)

        member _.Zero(()) : DataAwsLambdaInvocationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsLambdaInvocationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_invocation#function_name-1">DataAwsLambdaInvocation#function_name</a>.
        /// </summary>
        [<CustomOperation "function_name">]
        member _.FunctionName(state: DataAwsLambdaInvocationState<Missing, 'Input>, value: string) : DataAwsLambdaInvocationState<Present, 'Input> =
            state.assignments.Add(fun config -> config.FunctionName <- value)
            ({ assignments = state.assignments } : DataAwsLambdaInvocationState<Present, 'Input>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_invocation#input-1">DataAwsLambdaInvocation#input</a>.
        /// </summary>
        [<CustomOperation "input">]
        member _.Input(state: DataAwsLambdaInvocationState<'FunctionName, Missing>, value: string) : DataAwsLambdaInvocationState<'FunctionName, Present> =
            state.assignments.Add(fun config -> config.Input <- value)
            ({ assignments = state.assignments } : DataAwsLambdaInvocationState<'FunctionName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_invocation#id-1">DataAwsLambdaInvocation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLambdaInvocationState<'FunctionName, 'Input>, value: string) : DataAwsLambdaInvocationState<'FunctionName, 'Input> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLambdaInvocationState<'FunctionName, 'Input>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_invocation#qualifier-1">DataAwsLambdaInvocation#qualifier</a>.
        /// </summary>
        [<CustomOperation "qualifier">]
        member _.Qualifier(state: DataAwsLambdaInvocationState<'FunctionName, 'Input>, value: string) : DataAwsLambdaInvocationState<'FunctionName, 'Input> =
            state.assignments.Add(fun config -> config.Qualifier <- value)
            state : DataAwsLambdaInvocationState<'FunctionName, 'Input>

        member _.Run(state: DataAwsLambdaInvocationState<Present, Present>) : aws.DataAwsLambdaInvocation.DataAwsLambdaInvocation =
            let config = aws.DataAwsLambdaInvocation.DataAwsLambdaInvocationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLambdaInvocation.DataAwsLambdaInvocation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLambdaInvocation: missing required arguments. Must call: function_name, input.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLambdaInvocationState<_, _>) : aws.DataAwsLambdaInvocation.DataAwsLambdaInvocation =
            Unchecked.defaultof<aws.DataAwsLambdaInvocation.DataAwsLambdaInvocation>
