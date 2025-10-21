namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, 'Qualifier> = { assignments: ResizeArray<aws.LambdaProvisionedConcurrencyConfig.LambdaProvisionedConcurrencyConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_provisioned_concurrency_config">aws_lambda_provisioned_concurrency_config</a>.
    /// </summary>
    type LambdaProvisionedConcurrencyConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : LambdaProvisionedConcurrencyConfigState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaProvisionedConcurrencyConfigState<Missing, Missing, Missing>)

        member _.Zero(()) : LambdaProvisionedConcurrencyConfigState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaProvisionedConcurrencyConfigState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_provisioned_concurrency_config#function_name-1">LambdaProvisionedConcurrencyConfig#function_name</a>.
        /// </summary>
        [<CustomOperation "function_name">]
        member _.FunctionName(state: LambdaProvisionedConcurrencyConfigState<Missing, 'ProvisionedConcurrentExecutions, 'Qualifier>, value: string) : LambdaProvisionedConcurrencyConfigState<Present, 'ProvisionedConcurrentExecutions, 'Qualifier> =
            state.assignments.Add(fun config -> config.FunctionName <- value)
            ({ assignments = state.assignments } : LambdaProvisionedConcurrencyConfigState<Present, 'ProvisionedConcurrentExecutions, 'Qualifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_provisioned_concurrency_config#provisioned_concurrent_executions-1">LambdaProvisionedConcurrencyConfig#provisioned_concurrent_executions</a>.
        /// </summary>
        [<CustomOperation "provisioned_concurrent_executions">]
        member _.ProvisionedConcurrentExecutions(state: LambdaProvisionedConcurrencyConfigState<'FunctionName, Missing, 'Qualifier>, value: double) : LambdaProvisionedConcurrencyConfigState<'FunctionName, Present, 'Qualifier> =
            state.assignments.Add(fun config -> config.ProvisionedConcurrentExecutions <- value)
            ({ assignments = state.assignments } : LambdaProvisionedConcurrencyConfigState<'FunctionName, Present, 'Qualifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_provisioned_concurrency_config#qualifier-1">LambdaProvisionedConcurrencyConfig#qualifier</a>.
        /// </summary>
        [<CustomOperation "qualifier">]
        member _.Qualifier(state: LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, Missing>, value: string) : LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, Present> =
            state.assignments.Add(fun config -> config.Qualifier <- value)
            ({ assignments = state.assignments } : LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_provisioned_concurrency_config#id-1">LambdaProvisionedConcurrencyConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, 'Qualifier>, value: string) : LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, 'Qualifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, 'Qualifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_provisioned_concurrency_config#skip_destroy-1">LambdaProvisionedConcurrencyConfig#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, 'Qualifier>, value: bool) : LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, 'Qualifier> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, 'Qualifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_provisioned_concurrency_config#skip_destroy-1">LambdaProvisionedConcurrencyConfig#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, 'Qualifier>, value: HashiCorp.Cdktf.IResolvable) : LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, 'Qualifier> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, 'Qualifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_provisioned_concurrency_config#timeouts-1">LambdaProvisionedConcurrencyConfig#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, 'Qualifier>, value: aws.LambdaProvisionedConcurrencyConfig.LambdaProvisionedConcurrencyConfigTimeouts) : LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, 'Qualifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LambdaProvisionedConcurrencyConfigState<'FunctionName, 'ProvisionedConcurrentExecutions, 'Qualifier>

        member _.Run(state: LambdaProvisionedConcurrencyConfigState<Present, Present, Present>) : aws.LambdaProvisionedConcurrencyConfig.LambdaProvisionedConcurrencyConfig =
            let config = aws.LambdaProvisionedConcurrencyConfig.LambdaProvisionedConcurrencyConfigConfig()
            for setter in state.assignments do
                setter config
            aws.LambdaProvisionedConcurrencyConfig.LambdaProvisionedConcurrencyConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lambdaProvisionedConcurrencyConfig: missing required arguments. Must call: function_name, provisioned_concurrent_executions, qualifier.", 9999, IsError = true)>]
        member _.Run(_: LambdaProvisionedConcurrencyConfigState<_, _, _>) : aws.LambdaProvisionedConcurrencyConfig.LambdaProvisionedConcurrencyConfig =
            Unchecked.defaultof<aws.LambdaProvisionedConcurrencyConfig.LambdaProvisionedConcurrencyConfig>
