namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodeconnectionsConnectionState<'Name> = { assignments: ResizeArray<aws.CodeconnectionsConnection.CodeconnectionsConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_connection">aws_codeconnections_connection</a>.
    /// </summary>
    type CodeconnectionsConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodeconnectionsConnectionState<Missing> =
            ({ assignments = ResizeArray() } : CodeconnectionsConnectionState<Missing>)

        member _.Zero(()) : CodeconnectionsConnectionState<Missing> =
            ({ assignments = ResizeArray() } : CodeconnectionsConnectionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_connection#name-1">CodeconnectionsConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CodeconnectionsConnectionState<Missing>, value: string) : CodeconnectionsConnectionState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CodeconnectionsConnectionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_connection#host_arn-1">CodeconnectionsConnection#host_arn</a>.
        /// </summary>
        [<CustomOperation "host_arn">]
        member _.HostArn(state: CodeconnectionsConnectionState<'Name>, value: string) : CodeconnectionsConnectionState<'Name> =
            state.assignments.Add(fun config -> config.HostArn <- value)
            state : CodeconnectionsConnectionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_connection#provider_type-1">CodeconnectionsConnection#provider_type</a>.
        /// </summary>
        [<CustomOperation "provider_type">]
        member _.ProviderType(state: CodeconnectionsConnectionState<'Name>, value: string) : CodeconnectionsConnectionState<'Name> =
            state.assignments.Add(fun config -> config.ProviderType <- value)
            state : CodeconnectionsConnectionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_connection#tags-1">CodeconnectionsConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodeconnectionsConnectionState<'Name>, value: seq<string * string>) : CodeconnectionsConnectionState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodeconnectionsConnectionState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_connection#timeouts-1">CodeconnectionsConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CodeconnectionsConnectionState<'Name>, value: aws.CodeconnectionsConnection.CodeconnectionsConnectionTimeouts) : CodeconnectionsConnectionState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CodeconnectionsConnectionState<'Name>

        member _.Run(state: CodeconnectionsConnectionState<Present>) : aws.CodeconnectionsConnection.CodeconnectionsConnection =
            let config = aws.CodeconnectionsConnection.CodeconnectionsConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.CodeconnectionsConnection.CodeconnectionsConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codeconnectionsConnection: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: CodeconnectionsConnectionState<_>) : aws.CodeconnectionsConnection.CodeconnectionsConnection =
            Unchecked.defaultof<aws.CodeconnectionsConnection.CodeconnectionsConnection>
