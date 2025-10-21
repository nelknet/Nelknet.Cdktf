namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName> = { assignments: ResizeArray<aws.KeyspacesTable.KeyspacesTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table">aws_keyspaces_table</a>.
    /// </summary>
    type KeyspacesTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyspacesTableState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyspacesTableState<Missing, Missing, Missing>)

        member _.Zero(()) : KeyspacesTableState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyspacesTableState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#keyspace_name-1">KeyspacesTable#keyspace_name</a>.
        /// </summary>
        [<CustomOperation "keyspace_name">]
        member _.KeyspaceName(state: KeyspacesTableState<Missing, 'SchemaDefinition, 'TableName>, value: string) : KeyspacesTableState<Present, 'SchemaDefinition, 'TableName> =
            state.assignments.Add(fun config -> config.KeyspaceName <- value)
            ({ assignments = state.assignments } : KeyspacesTableState<Present, 'SchemaDefinition, 'TableName>)

        /// <summary>
        /// schema_definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#schema_definition-1">KeyspacesTable#schema_definition</a>
        /// </summary>
        [<CustomOperation "schema_definition">]
        member _.SchemaDefinition(state: KeyspacesTableState<'KeyspaceName, Missing, 'TableName>, value: aws.KeyspacesTable.KeyspacesTableSchemaDefinition) : KeyspacesTableState<'KeyspaceName, Present, 'TableName> =
            state.assignments.Add(fun config -> config.SchemaDefinition <- value)
            ({ assignments = state.assignments } : KeyspacesTableState<'KeyspaceName, Present, 'TableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#table_name-1">KeyspacesTable#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, Missing>, value: string) : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, Present> =
            state.assignments.Add(fun config -> config.TableName <- value)
            ({ assignments = state.assignments } : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, Present>)

        /// <summary>
        /// capacity_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#capacity_specification-1">KeyspacesTable#capacity_specification</a>
        /// </summary>
        [<CustomOperation "capacity_specification">]
        member _.CapacitySpecification(state: KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>, value: aws.KeyspacesTable.KeyspacesTableCapacitySpecification) : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName> =
            state.assignments.Add(fun config -> config.CapacitySpecification <- value)
            state : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>

        /// <summary>
        /// client_side_timestamps block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#client_side_timestamps-1">KeyspacesTable#client_side_timestamps</a>
        /// </summary>
        [<CustomOperation "client_side_timestamps">]
        member _.ClientSideTimestamps(state: KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>, value: aws.KeyspacesTable.KeyspacesTableClientSideTimestamps) : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName> =
            state.assignments.Add(fun config -> config.ClientSideTimestamps <- value)
            state : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>

        /// <summary>
        /// comment block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#comment-1">KeyspacesTable#comment</a>
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>, value: aws.KeyspacesTable.KeyspacesTableComment) : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#default_time_to_live-1">KeyspacesTable#default_time_to_live</a>.
        /// </summary>
        [<CustomOperation "default_time_to_live">]
        member _.DefaultTimeToLive(state: KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>, value: double) : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName> =
            state.assignments.Add(fun config -> config.DefaultTimeToLive <- value)
            state : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>

        /// <summary>
        /// encryption_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#encryption_specification-1">KeyspacesTable#encryption_specification</a>
        /// </summary>
        [<CustomOperation "encryption_specification">]
        member _.EncryptionSpecification(state: KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>, value: aws.KeyspacesTable.KeyspacesTableEncryptionSpecification) : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName> =
            state.assignments.Add(fun config -> config.EncryptionSpecification <- value)
            state : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#id-1">KeyspacesTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>, value: string) : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>

        /// <summary>
        /// point_in_time_recovery block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#point_in_time_recovery-1">KeyspacesTable#point_in_time_recovery</a>
        /// </summary>
        [<CustomOperation "point_in_time_recovery">]
        member _.PointInTimeRecovery(state: KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>, value: aws.KeyspacesTable.KeyspacesTablePointInTimeRecovery) : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName> =
            state.assignments.Add(fun config -> config.PointInTimeRecovery <- value)
            state : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#tags-1">KeyspacesTable#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>, value: seq<string * string>) : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#tags_all-1">KeyspacesTable#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>, value: seq<string * string>) : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#timeouts-1">KeyspacesTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>, value: aws.KeyspacesTable.KeyspacesTableTimeouts) : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>

        /// <summary>
        /// ttl block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#ttl-1">KeyspacesTable#ttl</a>
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>, value: aws.KeyspacesTable.KeyspacesTableTtl) : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            state : KeyspacesTableState<'KeyspaceName, 'SchemaDefinition, 'TableName>

        member _.Run(state: KeyspacesTableState<Present, Present, Present>) : aws.KeyspacesTable.KeyspacesTable =
            let config = aws.KeyspacesTable.KeyspacesTableConfig()
            for setter in state.assignments do
                setter config
            aws.KeyspacesTable.KeyspacesTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.keyspacesTable: missing required arguments. Must call: keyspace_name, schema_definition, table_name.", 9999, IsError = true)>]
        member _.Run(_: KeyspacesTableState<_, _, _>) : aws.KeyspacesTable.KeyspacesTable =
            Unchecked.defaultof<aws.KeyspacesTable.KeyspacesTable>
