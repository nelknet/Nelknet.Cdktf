namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSfnAliasState<'Name, 'StatemachineArn> = { assignments: ResizeArray<aws.DataAwsSfnAlias.DataAwsSfnAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sfn_alias">aws_sfn_alias</a>.
    /// </summary>
    type DataAwsSfnAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSfnAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsSfnAliasState<Missing, Missing>)

        member _.Zero(()) : DataAwsSfnAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsSfnAliasState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sfn_alias#name-1">DataAwsSfnAlias#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsSfnAliasState<Missing, 'StatemachineArn>, value: string) : DataAwsSfnAliasState<Present, 'StatemachineArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsSfnAliasState<Present, 'StatemachineArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sfn_alias#statemachine_arn-1">DataAwsSfnAlias#statemachine_arn</a>.
        /// </summary>
        [<CustomOperation "statemachine_arn">]
        member _.StatemachineArn(state: DataAwsSfnAliasState<'Name, Missing>, value: string) : DataAwsSfnAliasState<'Name, Present> =
            state.assignments.Add(fun config -> config.StatemachineArn <- value)
            ({ assignments = state.assignments } : DataAwsSfnAliasState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sfn_alias#description-1">DataAwsSfnAlias#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataAwsSfnAliasState<'Name, 'StatemachineArn>, value: string) : DataAwsSfnAliasState<'Name, 'StatemachineArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataAwsSfnAliasState<'Name, 'StatemachineArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sfn_alias#id-1">DataAwsSfnAlias#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSfnAliasState<'Name, 'StatemachineArn>, value: string) : DataAwsSfnAliasState<'Name, 'StatemachineArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSfnAliasState<'Name, 'StatemachineArn>

        member _.Run(state: DataAwsSfnAliasState<Present, Present>) : aws.DataAwsSfnAlias.DataAwsSfnAlias =
            let config = aws.DataAwsSfnAlias.DataAwsSfnAliasConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSfnAlias.DataAwsSfnAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSfnAlias: missing required arguments. Must call: name, statemachine_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSfnAliasState<_, _>) : aws.DataAwsSfnAlias.DataAwsSfnAlias =
            Unchecked.defaultof<aws.DataAwsSfnAlias.DataAwsSfnAlias>
