namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DynamodbTableReplicaAState<'GlobalTableArn> = { assignments: ResizeArray<aws.DynamodbTableReplica.DynamodbTableReplicaAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_replica">aws_dynamodb_table_replica</a>.
    /// </summary>
    type DynamodbTableReplicaABuilder(logicalId: string) =
        member _.Yield(_: unit) : DynamodbTableReplicaAState<Missing> =
            ({ assignments = ResizeArray() } : DynamodbTableReplicaAState<Missing>)

        member _.Zero(()) : DynamodbTableReplicaAState<Missing> =
            ({ assignments = ResizeArray() } : DynamodbTableReplicaAState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_replica#global_table_arn-1">DynamodbTableReplicaA#global_table_arn</a>.
        /// </summary>
        [<CustomOperation "global_table_arn">]
        member _.GlobalTableArn(state: DynamodbTableReplicaAState<Missing>, value: string) : DynamodbTableReplicaAState<Present> =
            state.assignments.Add(fun config -> config.GlobalTableArn <- value)
            ({ assignments = state.assignments } : DynamodbTableReplicaAState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_replica#deletion_protection_enabled-1">DynamodbTableReplicaA#deletion_protection_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection_enabled">]
        member _.DeletionProtectionEnabled(state: DynamodbTableReplicaAState<'GlobalTableArn>, value: bool) : DynamodbTableReplicaAState<'GlobalTableArn> =
            state.assignments.Add(fun config -> config.DeletionProtectionEnabled <- value)
            state : DynamodbTableReplicaAState<'GlobalTableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_replica#deletion_protection_enabled-1">DynamodbTableReplicaA#deletion_protection_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection_enabled">]
        member _.DeletionProtectionEnabled(state: DynamodbTableReplicaAState<'GlobalTableArn>, value: HashiCorp.Cdktf.IResolvable) : DynamodbTableReplicaAState<'GlobalTableArn> =
            state.assignments.Add(fun config -> config.DeletionProtectionEnabled <- value)
            state : DynamodbTableReplicaAState<'GlobalTableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_replica#id-1">DynamodbTableReplicaA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DynamodbTableReplicaAState<'GlobalTableArn>, value: string) : DynamodbTableReplicaAState<'GlobalTableArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DynamodbTableReplicaAState<'GlobalTableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_replica#kms_key_arn-1">DynamodbTableReplicaA#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: DynamodbTableReplicaAState<'GlobalTableArn>, value: string) : DynamodbTableReplicaAState<'GlobalTableArn> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : DynamodbTableReplicaAState<'GlobalTableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_replica#point_in_time_recovery-1">DynamodbTableReplicaA#point_in_time_recovery</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "point_in_time_recovery">]
        member _.PointInTimeRecovery(state: DynamodbTableReplicaAState<'GlobalTableArn>, value: bool) : DynamodbTableReplicaAState<'GlobalTableArn> =
            state.assignments.Add(fun config -> config.PointInTimeRecovery <- value)
            state : DynamodbTableReplicaAState<'GlobalTableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_replica#point_in_time_recovery-1">DynamodbTableReplicaA#point_in_time_recovery</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "point_in_time_recovery">]
        member _.PointInTimeRecovery(state: DynamodbTableReplicaAState<'GlobalTableArn>, value: HashiCorp.Cdktf.IResolvable) : DynamodbTableReplicaAState<'GlobalTableArn> =
            state.assignments.Add(fun config -> config.PointInTimeRecovery <- value)
            state : DynamodbTableReplicaAState<'GlobalTableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_replica#table_class_override-1">DynamodbTableReplicaA#table_class_override</a>.
        /// </summary>
        [<CustomOperation "table_class_override">]
        member _.TableClassOverride(state: DynamodbTableReplicaAState<'GlobalTableArn>, value: string) : DynamodbTableReplicaAState<'GlobalTableArn> =
            state.assignments.Add(fun config -> config.TableClassOverride <- value)
            state : DynamodbTableReplicaAState<'GlobalTableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_replica#tags-1">DynamodbTableReplicaA#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DynamodbTableReplicaAState<'GlobalTableArn>, value: seq<string * string>) : DynamodbTableReplicaAState<'GlobalTableArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DynamodbTableReplicaAState<'GlobalTableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_replica#tags_all-1">DynamodbTableReplicaA#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DynamodbTableReplicaAState<'GlobalTableArn>, value: seq<string * string>) : DynamodbTableReplicaAState<'GlobalTableArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DynamodbTableReplicaAState<'GlobalTableArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_replica#timeouts-1">DynamodbTableReplicaA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DynamodbTableReplicaAState<'GlobalTableArn>, value: aws.DynamodbTableReplica.DynamodbTableReplicaTimeouts) : DynamodbTableReplicaAState<'GlobalTableArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DynamodbTableReplicaAState<'GlobalTableArn>

        member _.Run(state: DynamodbTableReplicaAState<Present>) : aws.DynamodbTableReplica.DynamodbTableReplicaA =
            let config = aws.DynamodbTableReplica.DynamodbTableReplicaAConfig()
            for setter in state.assignments do
                setter config
            aws.DynamodbTableReplica.DynamodbTableReplicaA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dynamodbTableReplicaA: missing required arguments. Must call: global_table_arn.", 9999, IsError = true)>]
        member _.Run(_: DynamodbTableReplicaAState<_>) : aws.DynamodbTableReplica.DynamodbTableReplicaA =
            Unchecked.defaultof<aws.DynamodbTableReplica.DynamodbTableReplicaA>
