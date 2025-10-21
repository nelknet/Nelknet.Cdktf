namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LambdaFunctionUrlState<'AuthorizationType, 'FunctionName> = { assignments: ResizeArray<aws.LambdaFunctionUrl.LambdaFunctionUrlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_url">aws_lambda_function_url</a>.
    /// </summary>
    type LambdaFunctionUrlBuilder(logicalId: string) =
        member _.Yield(_: unit) : LambdaFunctionUrlState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaFunctionUrlState<Missing, Missing>)

        member _.Zero(()) : LambdaFunctionUrlState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaFunctionUrlState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_url#authorization_type-1">LambdaFunctionUrl#authorization_type</a>.
        /// </summary>
        [<CustomOperation "authorization_type">]
        member _.AuthorizationType(state: LambdaFunctionUrlState<Missing, 'FunctionName>, value: string) : LambdaFunctionUrlState<Present, 'FunctionName> =
            state.assignments.Add(fun config -> config.AuthorizationType <- value)
            ({ assignments = state.assignments } : LambdaFunctionUrlState<Present, 'FunctionName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_url#function_name-1">LambdaFunctionUrl#function_name</a>.
        /// </summary>
        [<CustomOperation "function_name">]
        member _.FunctionName(state: LambdaFunctionUrlState<'AuthorizationType, Missing>, value: string) : LambdaFunctionUrlState<'AuthorizationType, Present> =
            state.assignments.Add(fun config -> config.FunctionName <- value)
            ({ assignments = state.assignments } : LambdaFunctionUrlState<'AuthorizationType, Present>)

        /// <summary>
        /// cors block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_url#cors-1">LambdaFunctionUrl#cors</a>
        /// </summary>
        [<CustomOperation "cors">]
        member _.Cors(state: LambdaFunctionUrlState<'AuthorizationType, 'FunctionName>, value: aws.LambdaFunctionUrl.LambdaFunctionUrlCors) : LambdaFunctionUrlState<'AuthorizationType, 'FunctionName> =
            state.assignments.Add(fun config -> config.Cors <- value)
            state : LambdaFunctionUrlState<'AuthorizationType, 'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_url#id-1">LambdaFunctionUrl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LambdaFunctionUrlState<'AuthorizationType, 'FunctionName>, value: string) : LambdaFunctionUrlState<'AuthorizationType, 'FunctionName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LambdaFunctionUrlState<'AuthorizationType, 'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_url#invoke_mode-1">LambdaFunctionUrl#invoke_mode</a>.
        /// </summary>
        [<CustomOperation "invoke_mode">]
        member _.InvokeMode(state: LambdaFunctionUrlState<'AuthorizationType, 'FunctionName>, value: string) : LambdaFunctionUrlState<'AuthorizationType, 'FunctionName> =
            state.assignments.Add(fun config -> config.InvokeMode <- value)
            state : LambdaFunctionUrlState<'AuthorizationType, 'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_url#qualifier-1">LambdaFunctionUrl#qualifier</a>.
        /// </summary>
        [<CustomOperation "qualifier">]
        member _.Qualifier(state: LambdaFunctionUrlState<'AuthorizationType, 'FunctionName>, value: string) : LambdaFunctionUrlState<'AuthorizationType, 'FunctionName> =
            state.assignments.Add(fun config -> config.Qualifier <- value)
            state : LambdaFunctionUrlState<'AuthorizationType, 'FunctionName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_url#timeouts-1">LambdaFunctionUrl#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LambdaFunctionUrlState<'AuthorizationType, 'FunctionName>, value: aws.LambdaFunctionUrl.LambdaFunctionUrlTimeouts) : LambdaFunctionUrlState<'AuthorizationType, 'FunctionName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LambdaFunctionUrlState<'AuthorizationType, 'FunctionName>

        member _.Run(state: LambdaFunctionUrlState<Present, Present>) : aws.LambdaFunctionUrl.LambdaFunctionUrl =
            let config = aws.LambdaFunctionUrl.LambdaFunctionUrlConfig()
            for setter in state.assignments do
                setter config
            aws.LambdaFunctionUrl.LambdaFunctionUrl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lambdaFunctionUrl: missing required arguments. Must call: authorization_type, function_name.", 9999, IsError = true)>]
        member _.Run(_: LambdaFunctionUrlState<_, _>) : aws.LambdaFunctionUrl.LambdaFunctionUrl =
            Unchecked.defaultof<aws.LambdaFunctionUrl.LambdaFunctionUrl>
