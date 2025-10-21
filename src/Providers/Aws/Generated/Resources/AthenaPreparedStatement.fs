namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AthenaPreparedStatementState<'Name, 'QueryStatement, 'Workgroup> = { assignments: ResizeArray<aws.AthenaPreparedStatement.AthenaPreparedStatementConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_prepared_statement">aws_athena_prepared_statement</a>.
    /// </summary>
    type AthenaPreparedStatementBuilder(logicalId: string) =
        member _.Yield(_: unit) : AthenaPreparedStatementState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AthenaPreparedStatementState<Missing, Missing, Missing>)

        member _.Zero(()) : AthenaPreparedStatementState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AthenaPreparedStatementState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_prepared_statement#name-1">AthenaPreparedStatement#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AthenaPreparedStatementState<Missing, 'QueryStatement, 'Workgroup>, value: string) : AthenaPreparedStatementState<Present, 'QueryStatement, 'Workgroup> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AthenaPreparedStatementState<Present, 'QueryStatement, 'Workgroup>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_prepared_statement#query_statement-1">AthenaPreparedStatement#query_statement</a>.
        /// </summary>
        [<CustomOperation "query_statement">]
        member _.QueryStatement(state: AthenaPreparedStatementState<'Name, Missing, 'Workgroup>, value: string) : AthenaPreparedStatementState<'Name, Present, 'Workgroup> =
            state.assignments.Add(fun config -> config.QueryStatement <- value)
            ({ assignments = state.assignments } : AthenaPreparedStatementState<'Name, Present, 'Workgroup>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_prepared_statement#workgroup-1">AthenaPreparedStatement#workgroup</a>.
        /// </summary>
        [<CustomOperation "workgroup">]
        member _.Workgroup(state: AthenaPreparedStatementState<'Name, 'QueryStatement, Missing>, value: string) : AthenaPreparedStatementState<'Name, 'QueryStatement, Present> =
            state.assignments.Add(fun config -> config.Workgroup <- value)
            ({ assignments = state.assignments } : AthenaPreparedStatementState<'Name, 'QueryStatement, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_prepared_statement#description-1">AthenaPreparedStatement#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AthenaPreparedStatementState<'Name, 'QueryStatement, 'Workgroup>, value: string) : AthenaPreparedStatementState<'Name, 'QueryStatement, 'Workgroup> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AthenaPreparedStatementState<'Name, 'QueryStatement, 'Workgroup>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_prepared_statement#id-1">AthenaPreparedStatement#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AthenaPreparedStatementState<'Name, 'QueryStatement, 'Workgroup>, value: string) : AthenaPreparedStatementState<'Name, 'QueryStatement, 'Workgroup> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AthenaPreparedStatementState<'Name, 'QueryStatement, 'Workgroup>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_prepared_statement#timeouts-1">AthenaPreparedStatement#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AthenaPreparedStatementState<'Name, 'QueryStatement, 'Workgroup>, value: aws.AthenaPreparedStatement.AthenaPreparedStatementTimeouts) : AthenaPreparedStatementState<'Name, 'QueryStatement, 'Workgroup> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AthenaPreparedStatementState<'Name, 'QueryStatement, 'Workgroup>

        member _.Run(state: AthenaPreparedStatementState<Present, Present, Present>) : aws.AthenaPreparedStatement.AthenaPreparedStatement =
            let config = aws.AthenaPreparedStatement.AthenaPreparedStatementConfig()
            for setter in state.assignments do
                setter config
            aws.AthenaPreparedStatement.AthenaPreparedStatement(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.athenaPreparedStatement: missing required arguments. Must call: name, query_statement, workgroup.", 9999, IsError = true)>]
        member _.Run(_: AthenaPreparedStatementState<_, _, _>) : aws.AthenaPreparedStatement.AthenaPreparedStatement =
            Unchecked.defaultof<aws.AthenaPreparedStatement.AthenaPreparedStatement>
