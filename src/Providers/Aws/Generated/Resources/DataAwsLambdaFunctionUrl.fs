namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLambdaFunctionUrlState<'FunctionName> = { assignments: ResizeArray<aws.DataAwsLambdaFunctionUrl.DataAwsLambdaFunctionUrlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_function_url">aws_lambda_function_url</a>.
    /// </summary>
    type DataAwsLambdaFunctionUrlBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLambdaFunctionUrlState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLambdaFunctionUrlState<Missing>)

        member _.Zero(()) : DataAwsLambdaFunctionUrlState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLambdaFunctionUrlState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_function_url#function_name-1">DataAwsLambdaFunctionUrl#function_name</a>.
        /// </summary>
        [<CustomOperation "function_name">]
        member _.FunctionName(state: DataAwsLambdaFunctionUrlState<Missing>, value: string) : DataAwsLambdaFunctionUrlState<Present> =
            state.assignments.Add(fun config -> config.FunctionName <- value)
            ({ assignments = state.assignments } : DataAwsLambdaFunctionUrlState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_function_url#id-1">DataAwsLambdaFunctionUrl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLambdaFunctionUrlState<'FunctionName>, value: string) : DataAwsLambdaFunctionUrlState<'FunctionName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLambdaFunctionUrlState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_function_url#qualifier-1">DataAwsLambdaFunctionUrl#qualifier</a>.
        /// </summary>
        [<CustomOperation "qualifier">]
        member _.Qualifier(state: DataAwsLambdaFunctionUrlState<'FunctionName>, value: string) : DataAwsLambdaFunctionUrlState<'FunctionName> =
            state.assignments.Add(fun config -> config.Qualifier <- value)
            state : DataAwsLambdaFunctionUrlState<'FunctionName>

        member _.Run(state: DataAwsLambdaFunctionUrlState<Present>) : aws.DataAwsLambdaFunctionUrl.DataAwsLambdaFunctionUrl =
            let config = aws.DataAwsLambdaFunctionUrl.DataAwsLambdaFunctionUrlConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLambdaFunctionUrl.DataAwsLambdaFunctionUrl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLambdaFunctionUrl: missing required arguments. Must call: function_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLambdaFunctionUrlState<_>) : aws.DataAwsLambdaFunctionUrl.DataAwsLambdaFunctionUrl =
            Unchecked.defaultof<aws.DataAwsLambdaFunctionUrl.DataAwsLambdaFunctionUrl>
