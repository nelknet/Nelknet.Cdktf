namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn> = { assignments: ResizeArray<aws.DbInstanceAutomatedBackupsReplication.DbInstanceAutomatedBackupsReplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_automated_backups_replication">aws_db_instance_automated_backups_replication</a>.
    /// </summary>
    type DbInstanceAutomatedBackupsReplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DbInstanceAutomatedBackupsReplicationState<Missing> =
            ({ assignments = ResizeArray() } : DbInstanceAutomatedBackupsReplicationState<Missing>)

        member _.Zero(()) : DbInstanceAutomatedBackupsReplicationState<Missing> =
            ({ assignments = ResizeArray() } : DbInstanceAutomatedBackupsReplicationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_automated_backups_replication#source_db_instance_arn-1">DbInstanceAutomatedBackupsReplication#source_db_instance_arn</a>.
        /// </summary>
        [<CustomOperation "source_db_instance_arn">]
        member _.SourceDbInstanceArn(state: DbInstanceAutomatedBackupsReplicationState<Missing>, value: string) : DbInstanceAutomatedBackupsReplicationState<Present> =
            state.assignments.Add(fun config -> config.SourceDbInstanceArn <- value)
            ({ assignments = state.assignments } : DbInstanceAutomatedBackupsReplicationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_automated_backups_replication#id-1">DbInstanceAutomatedBackupsReplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn>, value: string) : DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_automated_backups_replication#kms_key_id-1">DbInstanceAutomatedBackupsReplication#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn>, value: string) : DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_automated_backups_replication#pre_signed_url-1">DbInstanceAutomatedBackupsReplication#pre_signed_url</a>.
        /// </summary>
        [<CustomOperation "pre_signed_url">]
        member _.PreSignedUrl(state: DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn>, value: string) : DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn> =
            state.assignments.Add(fun config -> config.PreSignedUrl <- value)
            state : DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_automated_backups_replication#retention_period-1">DbInstanceAutomatedBackupsReplication#retention_period</a>.
        /// </summary>
        [<CustomOperation "retention_period">]
        member _.RetentionPeriod(state: DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn>, value: double) : DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn> =
            state.assignments.Add(fun config -> config.RetentionPeriod <- value)
            state : DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_automated_backups_replication#timeouts-1">DbInstanceAutomatedBackupsReplication#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn>, value: aws.DbInstanceAutomatedBackupsReplication.DbInstanceAutomatedBackupsReplicationTimeouts) : DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DbInstanceAutomatedBackupsReplicationState<'SourceDbInstanceArn>

        member _.Run(state: DbInstanceAutomatedBackupsReplicationState<Present>) : aws.DbInstanceAutomatedBackupsReplication.DbInstanceAutomatedBackupsReplication =
            let config = aws.DbInstanceAutomatedBackupsReplication.DbInstanceAutomatedBackupsReplicationConfig()
            for setter in state.assignments do
                setter config
            aws.DbInstanceAutomatedBackupsReplication.DbInstanceAutomatedBackupsReplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dbInstanceAutomatedBackupsReplication: missing required arguments. Must call: source_db_instance_arn.", 9999, IsError = true)>]
        member _.Run(_: DbInstanceAutomatedBackupsReplicationState<_>) : aws.DbInstanceAutomatedBackupsReplication.DbInstanceAutomatedBackupsReplication =
            Unchecked.defaultof<aws.DbInstanceAutomatedBackupsReplication.DbInstanceAutomatedBackupsReplication>
