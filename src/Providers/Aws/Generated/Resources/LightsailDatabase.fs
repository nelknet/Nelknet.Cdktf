namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> = { assignments: ResizeArray<aws.LightsailDatabase.LightsailDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database">aws_lightsail_database</a>.
    /// </summary>
    type LightsailDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailDatabaseState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailDatabaseState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LightsailDatabaseState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailDatabaseState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#blueprint_id-1">LightsailDatabase#blueprint_id</a>.
        /// </summary>
        [<CustomOperation "blueprint_id">]
        member _.BlueprintId(state: LightsailDatabaseState<Missing, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: string) : LightsailDatabaseState<Present, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.BlueprintId <- value)
            ({ assignments = state.assignments } : LightsailDatabaseState<Present, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#bundle_id-1">LightsailDatabase#bundle_id</a>.
        /// </summary>
        [<CustomOperation "bundle_id">]
        member _.BundleId(state: LightsailDatabaseState<'BlueprintId, Missing, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: string) : LightsailDatabaseState<'BlueprintId, Present, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.BundleId <- value)
            ({ assignments = state.assignments } : LightsailDatabaseState<'BlueprintId, Present, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#master_database_name-1">LightsailDatabase#master_database_name</a>.
        /// </summary>
        [<CustomOperation "master_database_name">]
        member _.MasterDatabaseName(state: LightsailDatabaseState<'BlueprintId, 'BundleId, Missing, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: string) : LightsailDatabaseState<'BlueprintId, 'BundleId, Present, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.MasterDatabaseName <- value)
            ({ assignments = state.assignments } : LightsailDatabaseState<'BlueprintId, 'BundleId, Present, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#master_password-1">LightsailDatabase#master_password</a>.
        /// </summary>
        [<CustomOperation "master_password">]
        member _.MasterPassword(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, Missing, 'MasterUsername, 'RelationalDatabaseName>, value: string) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, Present, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.MasterPassword <- value)
            ({ assignments = state.assignments } : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, Present, 'MasterUsername, 'RelationalDatabaseName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#master_username-1">LightsailDatabase#master_username</a>.
        /// </summary>
        [<CustomOperation "master_username">]
        member _.MasterUsername(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, Missing, 'RelationalDatabaseName>, value: string) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, Present, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.MasterUsername <- value)
            ({ assignments = state.assignments } : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, Present, 'RelationalDatabaseName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#relational_database_name-1">LightsailDatabase#relational_database_name</a>.
        /// </summary>
        [<CustomOperation "relational_database_name">]
        member _.RelationalDatabaseName(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, Missing>, value: string) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, Present> =
            state.assignments.Add(fun config -> config.RelationalDatabaseName <- value)
            ({ assignments = state.assignments } : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#apply_immediately-1">LightsailDatabase#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: bool) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#apply_immediately-1">LightsailDatabase#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: HashiCorp.Cdktf.IResolvable) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#availability_zone-1">LightsailDatabase#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: string) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#backup_retention_enabled-1">LightsailDatabase#backup_retention_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "backup_retention_enabled">]
        member _.BackupRetentionEnabled(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: bool) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.BackupRetentionEnabled <- value)
            state : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#backup_retention_enabled-1">LightsailDatabase#backup_retention_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "backup_retention_enabled">]
        member _.BackupRetentionEnabled(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: HashiCorp.Cdktf.IResolvable) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.BackupRetentionEnabled <- value)
            state : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#final_snapshot_name-1">LightsailDatabase#final_snapshot_name</a>.
        /// </summary>
        [<CustomOperation "final_snapshot_name">]
        member _.FinalSnapshotName(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: string) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.FinalSnapshotName <- value)
            state : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#id-1">LightsailDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: string) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#preferred_backup_window-1">LightsailDatabase#preferred_backup_window</a>.
        /// </summary>
        [<CustomOperation "preferred_backup_window">]
        member _.PreferredBackupWindow(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: string) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.PreferredBackupWindow <- value)
            state : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#preferred_maintenance_window-1">LightsailDatabase#preferred_maintenance_window</a>.
        /// </summary>
        [<CustomOperation "preferred_maintenance_window">]
        member _.PreferredMaintenanceWindow(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: string) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.PreferredMaintenanceWindow <- value)
            state : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#publicly_accessible-1">LightsailDatabase#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: bool) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#publicly_accessible-1">LightsailDatabase#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: HashiCorp.Cdktf.IResolvable) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#skip_final_snapshot-1">LightsailDatabase#skip_final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_snapshot">]
        member _.SkipFinalSnapshot(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: bool) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.SkipFinalSnapshot <- value)
            state : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#skip_final_snapshot-1">LightsailDatabase#skip_final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_snapshot">]
        member _.SkipFinalSnapshot(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: HashiCorp.Cdktf.IResolvable) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.SkipFinalSnapshot <- value)
            state : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#tags-1">LightsailDatabase#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: seq<string * string>) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_database#tags_all-1">LightsailDatabase#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>, value: seq<string * string>) : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LightsailDatabaseState<'BlueprintId, 'BundleId, 'MasterDatabaseName, 'MasterPassword, 'MasterUsername, 'RelationalDatabaseName>

        member _.Run(state: LightsailDatabaseState<Present, Present, Present, Present, Present, Present>) : aws.LightsailDatabase.LightsailDatabase =
            let config = aws.LightsailDatabase.LightsailDatabaseConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailDatabase.LightsailDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailDatabase: missing required arguments. Must call: blueprint_id, bundle_id, master_database_name, master_password, master_username, relational_database_name.", 9999, IsError = true)>]
        member _.Run(_: LightsailDatabaseState<_, _, _, _, _, _>) : aws.LightsailDatabase.LightsailDatabase =
            Unchecked.defaultof<aws.LightsailDatabase.LightsailDatabase>
