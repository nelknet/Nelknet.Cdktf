namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLambdaAliasState<'FunctionName, 'Name> = { assignments: ResizeArray<aws.DataAwsLambdaAlias.DataAwsLambdaAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_alias">aws_lambda_alias</a>.
    /// </summary>
    type DataAwsLambdaAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLambdaAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsLambdaAliasState<Missing, Missing>)

        member _.Zero(()) : DataAwsLambdaAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsLambdaAliasState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_alias#function_name-1">DataAwsLambdaAlias#function_name</a>.
        /// </summary>
        [<CustomOperation "function_name">]
        member _.FunctionName(state: DataAwsLambdaAliasState<Missing, 'Name>, value: string) : DataAwsLambdaAliasState<Present, 'Name> =
            state.assignments.Add(fun config -> config.FunctionName <- value)
            ({ assignments = state.assignments } : DataAwsLambdaAliasState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_alias#name-1">DataAwsLambdaAlias#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsLambdaAliasState<'FunctionName, Missing>, value: string) : DataAwsLambdaAliasState<'FunctionName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsLambdaAliasState<'FunctionName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_alias#id-1">DataAwsLambdaAlias#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLambdaAliasState<'FunctionName, 'Name>, value: string) : DataAwsLambdaAliasState<'FunctionName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLambdaAliasState<'FunctionName, 'Name>

        member _.Run(state: DataAwsLambdaAliasState<Present, Present>) : aws.DataAwsLambdaAlias.DataAwsLambdaAlias =
            let config = aws.DataAwsLambdaAlias.DataAwsLambdaAliasConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLambdaAlias.DataAwsLambdaAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLambdaAlias: missing required arguments. Must call: function_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLambdaAliasState<_, _>) : aws.DataAwsLambdaAlias.DataAwsLambdaAlias =
            Unchecked.defaultof<aws.DataAwsLambdaAlias.DataAwsLambdaAlias>
