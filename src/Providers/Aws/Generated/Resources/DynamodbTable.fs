namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DynamodbTableState<'Name> = { assignments: ResizeArray<aws.DynamodbTable.DynamodbTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table">aws_dynamodb_table</a>.
    /// </summary>
    type DynamodbTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : DynamodbTableState<Missing> =
            ({ assignments = ResizeArray() } : DynamodbTableState<Missing>)

        member _.Zero(()) : DynamodbTableState<Missing> =
            ({ assignments = ResizeArray() } : DynamodbTableState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#name-1">DynamodbTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DynamodbTableState<Missing>, value: string) : DynamodbTableState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DynamodbTableState<Present>)

        /// <summary>
        /// attribute block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#attribute-1">DynamodbTable#attribute</a> Accepts: aws.IResolvable | aws.DynamodbTable.DynamodbTableAttribute[]
        /// </summary>
        [<CustomOperation "attribute">]
        member _.Attribute(state: DynamodbTableState<'Name>, value: HashiCorp.Cdktf.IResolvable) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.Attribute <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#billing_mode-1">DynamodbTable#billing_mode</a>.
        /// </summary>
        [<CustomOperation "billing_mode">]
        member _.BillingMode(state: DynamodbTableState<'Name>, value: string) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.BillingMode <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#deletion_protection_enabled-1">DynamodbTable#deletion_protection_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection_enabled">]
        member _.DeletionProtectionEnabled(state: DynamodbTableState<'Name>, value: bool) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.DeletionProtectionEnabled <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#deletion_protection_enabled-1">DynamodbTable#deletion_protection_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection_enabled">]
        member _.DeletionProtectionEnabled(state: DynamodbTableState<'Name>, value: HashiCorp.Cdktf.IResolvable) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.DeletionProtectionEnabled <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// global_secondary_index block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#global_secondary_index-1">DynamodbTable#global_secondary_index</a> Accepts: aws.IResolvable | aws.DynamodbTable.DynamodbTableGlobalSecondaryIndex[]
        /// </summary>
        [<CustomOperation "global_secondary_index">]
        member _.GlobalSecondaryIndex(state: DynamodbTableState<'Name>, value: HashiCorp.Cdktf.IResolvable) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.GlobalSecondaryIndex <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#hash_key-1">DynamodbTable#hash_key</a>.
        /// </summary>
        [<CustomOperation "hash_key">]
        member _.HashKey(state: DynamodbTableState<'Name>, value: string) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.HashKey <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#id-1">DynamodbTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DynamodbTableState<'Name>, value: string) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// import_table block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#import_table-1">DynamodbTable#import_table</a>
        /// </summary>
        [<CustomOperation "import_table">]
        member _.ImportTable(state: DynamodbTableState<'Name>, value: aws.DynamodbTable.DynamodbTableImportTable) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.ImportTable <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// local_secondary_index block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#local_secondary_index-1">DynamodbTable#local_secondary_index</a> Accepts: aws.IResolvable | aws.DynamodbTable.DynamodbTableLocalSecondaryIndex[]
        /// </summary>
        [<CustomOperation "local_secondary_index">]
        member _.LocalSecondaryIndex(state: DynamodbTableState<'Name>, value: HashiCorp.Cdktf.IResolvable) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.LocalSecondaryIndex <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// on_demand_throughput block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#on_demand_throughput-1">DynamodbTable#on_demand_throughput</a>
        /// </summary>
        [<CustomOperation "on_demand_throughput">]
        member _.OnDemandThroughput(state: DynamodbTableState<'Name>, value: aws.DynamodbTable.DynamodbTableOnDemandThroughput) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.OnDemandThroughput <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// point_in_time_recovery block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#point_in_time_recovery-1">DynamodbTable#point_in_time_recovery</a>
        /// </summary>
        [<CustomOperation "point_in_time_recovery">]
        member _.PointInTimeRecovery(state: DynamodbTableState<'Name>, value: aws.DynamodbTable.DynamodbTablePointInTimeRecovery) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.PointInTimeRecovery <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#range_key-1">DynamodbTable#range_key</a>.
        /// </summary>
        [<CustomOperation "range_key">]
        member _.RangeKey(state: DynamodbTableState<'Name>, value: string) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.RangeKey <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#read_capacity-1">DynamodbTable#read_capacity</a>.
        /// </summary>
        [<CustomOperation "read_capacity">]
        member _.ReadCapacity(state: DynamodbTableState<'Name>, value: double) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.ReadCapacity <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// replica block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#replica-1">DynamodbTable#replica</a> Accepts: aws.IResolvable | aws.DynamodbTable.DynamodbTableReplica[]
        /// </summary>
        [<CustomOperation "replica">]
        member _.Replica(state: DynamodbTableState<'Name>, value: HashiCorp.Cdktf.IResolvable) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.Replica <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#restore_date_time-1">DynamodbTable#restore_date_time</a>.
        /// </summary>
        [<CustomOperation "restore_date_time">]
        member _.RestoreDateTime(state: DynamodbTableState<'Name>, value: string) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.RestoreDateTime <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#restore_source_name-1">DynamodbTable#restore_source_name</a>.
        /// </summary>
        [<CustomOperation "restore_source_name">]
        member _.RestoreSourceName(state: DynamodbTableState<'Name>, value: string) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.RestoreSourceName <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#restore_source_table_arn-1">DynamodbTable#restore_source_table_arn</a>.
        /// </summary>
        [<CustomOperation "restore_source_table_arn">]
        member _.RestoreSourceTableArn(state: DynamodbTableState<'Name>, value: string) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.RestoreSourceTableArn <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#restore_to_latest_time-1">DynamodbTable#restore_to_latest_time</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "restore_to_latest_time">]
        member _.RestoreToLatestTime(state: DynamodbTableState<'Name>, value: bool) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.RestoreToLatestTime <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#restore_to_latest_time-1">DynamodbTable#restore_to_latest_time</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "restore_to_latest_time">]
        member _.RestoreToLatestTime(state: DynamodbTableState<'Name>, value: HashiCorp.Cdktf.IResolvable) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.RestoreToLatestTime <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// server_side_encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#server_side_encryption-1">DynamodbTable#server_side_encryption</a>
        /// </summary>
        [<CustomOperation "server_side_encryption">]
        member _.ServerSideEncryption(state: DynamodbTableState<'Name>, value: aws.DynamodbTable.DynamodbTableServerSideEncryption) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.ServerSideEncryption <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#stream_enabled-1">DynamodbTable#stream_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "stream_enabled">]
        member _.StreamEnabled(state: DynamodbTableState<'Name>, value: bool) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.StreamEnabled <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#stream_enabled-1">DynamodbTable#stream_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "stream_enabled">]
        member _.StreamEnabled(state: DynamodbTableState<'Name>, value: HashiCorp.Cdktf.IResolvable) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.StreamEnabled <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#stream_view_type-1">DynamodbTable#stream_view_type</a>.
        /// </summary>
        [<CustomOperation "stream_view_type">]
        member _.StreamViewType(state: DynamodbTableState<'Name>, value: string) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.StreamViewType <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#table_class-1">DynamodbTable#table_class</a>.
        /// </summary>
        [<CustomOperation "table_class">]
        member _.TableClass(state: DynamodbTableState<'Name>, value: string) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.TableClass <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#tags-1">DynamodbTable#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DynamodbTableState<'Name>, value: seq<string * string>) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#tags_all-1">DynamodbTable#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DynamodbTableState<'Name>, value: seq<string * string>) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#timeouts-1">DynamodbTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DynamodbTableState<'Name>, value: aws.DynamodbTable.DynamodbTableTimeouts) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// ttl block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#ttl-1">DynamodbTable#ttl</a>
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: DynamodbTableState<'Name>, value: aws.DynamodbTable.DynamodbTableTtl) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            state : DynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#write_capacity-1">DynamodbTable#write_capacity</a>.
        /// </summary>
        [<CustomOperation "write_capacity">]
        member _.WriteCapacity(state: DynamodbTableState<'Name>, value: double) : DynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.WriteCapacity <- value)
            state : DynamodbTableState<'Name>

        member _.Run(state: DynamodbTableState<Present>) : aws.DynamodbTable.DynamodbTable =
            let config = aws.DynamodbTable.DynamodbTableConfig()
            for setter in state.assignments do
                setter config
            aws.DynamodbTable.DynamodbTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dynamodbTable: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DynamodbTableState<_>) : aws.DynamodbTable.DynamodbTable =
            Unchecked.defaultof<aws.DynamodbTable.DynamodbTable>
