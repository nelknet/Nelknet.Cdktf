namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyspacesKeyspaceState<'Name> = { assignments: ResizeArray<aws.KeyspacesKeyspace.KeyspacesKeyspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_keyspace">aws_keyspaces_keyspace</a>.
    /// </summary>
    type KeyspacesKeyspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyspacesKeyspaceState<Missing> =
            ({ assignments = ResizeArray() } : KeyspacesKeyspaceState<Missing>)

        member _.Zero(()) : KeyspacesKeyspaceState<Missing> =
            ({ assignments = ResizeArray() } : KeyspacesKeyspaceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_keyspace#name-1">KeyspacesKeyspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KeyspacesKeyspaceState<Missing>, value: string) : KeyspacesKeyspaceState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KeyspacesKeyspaceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_keyspace#id-1">KeyspacesKeyspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyspacesKeyspaceState<'Name>, value: string) : KeyspacesKeyspaceState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyspacesKeyspaceState<'Name>

        /// <summary>
        /// replication_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_keyspace#replication_specification-1">KeyspacesKeyspace#replication_specification</a>
        /// </summary>
        [<CustomOperation "replication_specification">]
        member _.ReplicationSpecification(state: KeyspacesKeyspaceState<'Name>, value: aws.KeyspacesKeyspace.KeyspacesKeyspaceReplicationSpecification) : KeyspacesKeyspaceState<'Name> =
            state.assignments.Add(fun config -> config.ReplicationSpecification <- value)
            state : KeyspacesKeyspaceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_keyspace#tags-1">KeyspacesKeyspace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KeyspacesKeyspaceState<'Name>, value: seq<string * string>) : KeyspacesKeyspaceState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KeyspacesKeyspaceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_keyspace#tags_all-1">KeyspacesKeyspace#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KeyspacesKeyspaceState<'Name>, value: seq<string * string>) : KeyspacesKeyspaceState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KeyspacesKeyspaceState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_keyspace#timeouts-1">KeyspacesKeyspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KeyspacesKeyspaceState<'Name>, value: aws.KeyspacesKeyspace.KeyspacesKeyspaceTimeouts) : KeyspacesKeyspaceState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KeyspacesKeyspaceState<'Name>

        member _.Run(state: KeyspacesKeyspaceState<Present>) : aws.KeyspacesKeyspace.KeyspacesKeyspace =
            let config = aws.KeyspacesKeyspace.KeyspacesKeyspaceConfig()
            for setter in state.assignments do
                setter config
            aws.KeyspacesKeyspace.KeyspacesKeyspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.keyspacesKeyspace: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: KeyspacesKeyspaceState<_>) : aws.KeyspacesKeyspace.KeyspacesKeyspace =
            Unchecked.defaultof<aws.KeyspacesKeyspace.KeyspacesKeyspace>
