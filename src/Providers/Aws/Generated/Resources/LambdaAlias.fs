namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LambdaAliasState<'FunctionName, 'FunctionVersion, 'Name> = { assignments: ResizeArray<aws.LambdaAlias.LambdaAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_alias">aws_lambda_alias</a>.
    /// </summary>
    type LambdaAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : LambdaAliasState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaAliasState<Missing, Missing, Missing>)

        member _.Zero(()) : LambdaAliasState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaAliasState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_alias#function_name-1">LambdaAlias#function_name</a>.
        /// </summary>
        [<CustomOperation "function_name">]
        member _.FunctionName(state: LambdaAliasState<Missing, 'FunctionVersion, 'Name>, value: string) : LambdaAliasState<Present, 'FunctionVersion, 'Name> =
            state.assignments.Add(fun config -> config.FunctionName <- value)
            ({ assignments = state.assignments } : LambdaAliasState<Present, 'FunctionVersion, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_alias#function_version-1">LambdaAlias#function_version</a>.
        /// </summary>
        [<CustomOperation "function_version">]
        member _.FunctionVersion(state: LambdaAliasState<'FunctionName, Missing, 'Name>, value: string) : LambdaAliasState<'FunctionName, Present, 'Name> =
            state.assignments.Add(fun config -> config.FunctionVersion <- value)
            ({ assignments = state.assignments } : LambdaAliasState<'FunctionName, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_alias#name-1">LambdaAlias#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LambdaAliasState<'FunctionName, 'FunctionVersion, Missing>, value: string) : LambdaAliasState<'FunctionName, 'FunctionVersion, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LambdaAliasState<'FunctionName, 'FunctionVersion, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_alias#description-1">LambdaAlias#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LambdaAliasState<'FunctionName, 'FunctionVersion, 'Name>, value: string) : LambdaAliasState<'FunctionName, 'FunctionVersion, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LambdaAliasState<'FunctionName, 'FunctionVersion, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_alias#id-1">LambdaAlias#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LambdaAliasState<'FunctionName, 'FunctionVersion, 'Name>, value: string) : LambdaAliasState<'FunctionName, 'FunctionVersion, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LambdaAliasState<'FunctionName, 'FunctionVersion, 'Name>

        /// <summary>
        /// routing_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_alias#routing_config-1">LambdaAlias#routing_config</a>
        /// </summary>
        [<CustomOperation "routing_config">]
        member _.RoutingConfig(state: LambdaAliasState<'FunctionName, 'FunctionVersion, 'Name>, value: aws.LambdaAlias.LambdaAliasRoutingConfig) : LambdaAliasState<'FunctionName, 'FunctionVersion, 'Name> =
            state.assignments.Add(fun config -> config.RoutingConfig <- value)
            state : LambdaAliasState<'FunctionName, 'FunctionVersion, 'Name>

        member _.Run(state: LambdaAliasState<Present, Present, Present>) : aws.LambdaAlias.LambdaAlias =
            let config = aws.LambdaAlias.LambdaAliasConfig()
            for setter in state.assignments do
                setter config
            aws.LambdaAlias.LambdaAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lambdaAlias: missing required arguments. Must call: function_name, function_version, name.", 9999, IsError = true)>]
        member _.Run(_: LambdaAliasState<_, _, _>) : aws.LambdaAlias.LambdaAlias =
            Unchecked.defaultof<aws.LambdaAlias.LambdaAlias>
