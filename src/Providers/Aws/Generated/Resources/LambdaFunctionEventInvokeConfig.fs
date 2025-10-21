namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LambdaFunctionEventInvokeConfigState<'FunctionName> = { assignments: ResizeArray<aws.LambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_event_invoke_config">aws_lambda_function_event_invoke_config</a>.
    /// </summary>
    type LambdaFunctionEventInvokeConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : LambdaFunctionEventInvokeConfigState<Missing> =
            ({ assignments = ResizeArray() } : LambdaFunctionEventInvokeConfigState<Missing>)

        member _.Zero(()) : LambdaFunctionEventInvokeConfigState<Missing> =
            ({ assignments = ResizeArray() } : LambdaFunctionEventInvokeConfigState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_event_invoke_config#function_name-1">LambdaFunctionEventInvokeConfig#function_name</a>.
        /// </summary>
        [<CustomOperation "function_name">]
        member _.FunctionName(state: LambdaFunctionEventInvokeConfigState<Missing>, value: string) : LambdaFunctionEventInvokeConfigState<Present> =
            state.assignments.Add(fun config -> config.FunctionName <- value)
            ({ assignments = state.assignments } : LambdaFunctionEventInvokeConfigState<Present>)

        /// <summary>
        /// destination_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_event_invoke_config#destination_config-1">LambdaFunctionEventInvokeConfig#destination_config</a>
        /// </summary>
        [<CustomOperation "destination_config">]
        member _.DestinationConfig(state: LambdaFunctionEventInvokeConfigState<'FunctionName>, value: aws.LambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfig) : LambdaFunctionEventInvokeConfigState<'FunctionName> =
            state.assignments.Add(fun config -> config.DestinationConfig <- value)
            state : LambdaFunctionEventInvokeConfigState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_event_invoke_config#id-1">LambdaFunctionEventInvokeConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LambdaFunctionEventInvokeConfigState<'FunctionName>, value: string) : LambdaFunctionEventInvokeConfigState<'FunctionName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LambdaFunctionEventInvokeConfigState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_event_invoke_config#maximum_event_age_in_seconds-1">LambdaFunctionEventInvokeConfig#maximum_event_age_in_seconds</a>.
        /// </summary>
        [<CustomOperation "maximum_event_age_in_seconds">]
        member _.MaximumEventAgeInSeconds(state: LambdaFunctionEventInvokeConfigState<'FunctionName>, value: double) : LambdaFunctionEventInvokeConfigState<'FunctionName> =
            state.assignments.Add(fun config -> config.MaximumEventAgeInSeconds <- value)
            state : LambdaFunctionEventInvokeConfigState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_event_invoke_config#maximum_retry_attempts-1">LambdaFunctionEventInvokeConfig#maximum_retry_attempts</a>.
        /// </summary>
        [<CustomOperation "maximum_retry_attempts">]
        member _.MaximumRetryAttempts(state: LambdaFunctionEventInvokeConfigState<'FunctionName>, value: double) : LambdaFunctionEventInvokeConfigState<'FunctionName> =
            state.assignments.Add(fun config -> config.MaximumRetryAttempts <- value)
            state : LambdaFunctionEventInvokeConfigState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_event_invoke_config#qualifier-1">LambdaFunctionEventInvokeConfig#qualifier</a>.
        /// </summary>
        [<CustomOperation "qualifier">]
        member _.Qualifier(state: LambdaFunctionEventInvokeConfigState<'FunctionName>, value: string) : LambdaFunctionEventInvokeConfigState<'FunctionName> =
            state.assignments.Add(fun config -> config.Qualifier <- value)
            state : LambdaFunctionEventInvokeConfigState<'FunctionName>

        member _.Run(state: LambdaFunctionEventInvokeConfigState<Present>) : aws.LambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfig =
            let config = aws.LambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigConfig()
            for setter in state.assignments do
                setter config
            aws.LambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lambdaFunctionEventInvokeConfig: missing required arguments. Must call: function_name.", 9999, IsError = true)>]
        member _.Run(_: LambdaFunctionEventInvokeConfigState<_>) : aws.LambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfig =
            Unchecked.defaultof<aws.LambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfig>
