namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLambdaFunctionsState = { assignments: ResizeArray<aws.DataAwsLambdaFunctions.DataAwsLambdaFunctionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_functions">aws_lambda_functions</a>.
    /// </summary>
    type DataAwsLambdaFunctionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLambdaFunctionsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsLambdaFunctionsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_functions#id-1">DataAwsLambdaFunctions#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLambdaFunctionsState, value: string) : DataAwsLambdaFunctionsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLambdaFunctionsState

        member _.Run(state: DataAwsLambdaFunctionsState) : aws.DataAwsLambdaFunctions.DataAwsLambdaFunctions =
            let config = aws.DataAwsLambdaFunctions.DataAwsLambdaFunctionsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLambdaFunctions.DataAwsLambdaFunctions(StackContext.get (), logicalId, config)
