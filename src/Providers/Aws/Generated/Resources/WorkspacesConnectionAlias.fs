namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WorkspacesConnectionAliasState<'ConnectionString> = { assignments: ResizeArray<aws.WorkspacesConnectionAlias.WorkspacesConnectionAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_connection_alias">aws_workspaces_connection_alias</a>.
    /// </summary>
    type WorkspacesConnectionAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : WorkspacesConnectionAliasState<Missing> =
            ({ assignments = ResizeArray() } : WorkspacesConnectionAliasState<Missing>)

        member _.Zero(()) : WorkspacesConnectionAliasState<Missing> =
            ({ assignments = ResizeArray() } : WorkspacesConnectionAliasState<Missing>)

        /// <summary>
        /// The connection string specified for the connection alias. The connection string must be in the form of a fully qualified domain name (FQDN), such as www.example.com. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_connection_alias#connection_string-1">WorkspacesConnectionAlias#connection_string</a>
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: WorkspacesConnectionAliasState<Missing>, value: string) : WorkspacesConnectionAliasState<Present> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            ({ assignments = state.assignments } : WorkspacesConnectionAliasState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_connection_alias#tags-1">WorkspacesConnectionAlias#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WorkspacesConnectionAliasState<'ConnectionString>, value: seq<string * string>) : WorkspacesConnectionAliasState<'ConnectionString> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WorkspacesConnectionAliasState<'ConnectionString>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_connection_alias#timeouts-1">WorkspacesConnectionAlias#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WorkspacesConnectionAliasState<'ConnectionString>, value: aws.WorkspacesConnectionAlias.WorkspacesConnectionAliasTimeouts) : WorkspacesConnectionAliasState<'ConnectionString> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WorkspacesConnectionAliasState<'ConnectionString>

        member _.Run(state: WorkspacesConnectionAliasState<Present>) : aws.WorkspacesConnectionAlias.WorkspacesConnectionAlias =
            let config = aws.WorkspacesConnectionAlias.WorkspacesConnectionAliasConfig()
            for setter in state.assignments do
                setter config
            aws.WorkspacesConnectionAlias.WorkspacesConnectionAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.workspacesConnectionAlias: missing required arguments. Must call: connection_string.", 9999, IsError = true)>]
        member _.Run(_: WorkspacesConnectionAliasState<_>) : aws.WorkspacesConnectionAlias.WorkspacesConnectionAlias =
            Unchecked.defaultof<aws.WorkspacesConnectionAlias.WorkspacesConnectionAlias>
