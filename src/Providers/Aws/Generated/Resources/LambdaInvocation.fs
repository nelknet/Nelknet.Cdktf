namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LambdaInvocationState<'FunctionName, 'Input> = { assignments: ResizeArray<aws.LambdaInvocation.LambdaInvocationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_invocation">aws_lambda_invocation</a>.
    /// </summary>
    type LambdaInvocationBuilder(logicalId: string) =
        member _.Yield(_: unit) : LambdaInvocationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaInvocationState<Missing, Missing>)

        member _.Zero(()) : LambdaInvocationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaInvocationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_invocation#function_name-1">LambdaInvocation#function_name</a>.
        /// </summary>
        [<CustomOperation "function_name">]
        member _.FunctionName(state: LambdaInvocationState<Missing, 'Input>, value: string) : LambdaInvocationState<Present, 'Input> =
            state.assignments.Add(fun config -> config.FunctionName <- value)
            ({ assignments = state.assignments } : LambdaInvocationState<Present, 'Input>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_invocation#input-1">LambdaInvocation#input</a>.
        /// </summary>
        [<CustomOperation "input">]
        member _.Input(state: LambdaInvocationState<'FunctionName, Missing>, value: string) : LambdaInvocationState<'FunctionName, Present> =
            state.assignments.Add(fun config -> config.Input <- value)
            ({ assignments = state.assignments } : LambdaInvocationState<'FunctionName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_invocation#id-1">LambdaInvocation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LambdaInvocationState<'FunctionName, 'Input>, value: string) : LambdaInvocationState<'FunctionName, 'Input> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LambdaInvocationState<'FunctionName, 'Input>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_invocation#lifecycle_scope-1">LambdaInvocation#lifecycle_scope</a>.
        /// </summary>
        [<CustomOperation "lifecycle_scope">]
        member _.LifecycleScope(state: LambdaInvocationState<'FunctionName, 'Input>, value: string) : LambdaInvocationState<'FunctionName, 'Input> =
            state.assignments.Add(fun config -> config.LifecycleScope <- value)
            state : LambdaInvocationState<'FunctionName, 'Input>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_invocation#qualifier-1">LambdaInvocation#qualifier</a>.
        /// </summary>
        [<CustomOperation "qualifier">]
        member _.Qualifier(state: LambdaInvocationState<'FunctionName, 'Input>, value: string) : LambdaInvocationState<'FunctionName, 'Input> =
            state.assignments.Add(fun config -> config.Qualifier <- value)
            state : LambdaInvocationState<'FunctionName, 'Input>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_invocation#terraform_key-1">LambdaInvocation#terraform_key</a>.
        /// </summary>
        [<CustomOperation "terraform_key">]
        member _.TerraformKey(state: LambdaInvocationState<'FunctionName, 'Input>, value: string) : LambdaInvocationState<'FunctionName, 'Input> =
            state.assignments.Add(fun config -> config.TerraformKey <- value)
            state : LambdaInvocationState<'FunctionName, 'Input>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_invocation#triggers-1">LambdaInvocation#triggers</a>.
        /// </summary>
        [<CustomOperation "triggers">]
        member _.Triggers(state: LambdaInvocationState<'FunctionName, 'Input>, value: seq<string * string>) : LambdaInvocationState<'FunctionName, 'Input> =
            state.assignments.Add(fun config -> config.Triggers <- dict value)
            state : LambdaInvocationState<'FunctionName, 'Input>

        member _.Run(state: LambdaInvocationState<Present, Present>) : aws.LambdaInvocation.LambdaInvocation =
            let config = aws.LambdaInvocation.LambdaInvocationConfig()
            for setter in state.assignments do
                setter config
            aws.LambdaInvocation.LambdaInvocation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lambdaInvocation: missing required arguments. Must call: function_name, input.", 9999, IsError = true)>]
        member _.Run(_: LambdaInvocationState<_, _>) : aws.LambdaInvocation.LambdaInvocation =
            Unchecked.defaultof<aws.LambdaInvocation.LambdaInvocation>
