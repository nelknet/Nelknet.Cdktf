namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount> = { assignments: ResizeArray<aws.DocdbelasticCluster.DocdbelasticClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdbelastic_cluster">aws_docdbelastic_cluster</a>.
    /// </summary>
    type DocdbelasticClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DocdbelasticClusterState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DocdbelasticClusterState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DocdbelasticClusterState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DocdbelasticClusterState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdbelastic_cluster#admin_user_name-1">DocdbelasticCluster#admin_user_name</a>.
        /// </summary>
        [<CustomOperation "admin_user_name">]
        member _.AdminUserName(state: DocdbelasticClusterState<Missing, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>, value: string) : DocdbelasticClusterState<Present, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount> =
            state.assignments.Add(fun config -> config.AdminUserName <- value)
            ({ assignments = state.assignments } : DocdbelasticClusterState<Present, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdbelastic_cluster#admin_user_password-1">DocdbelasticCluster#admin_user_password</a>.
        /// </summary>
        [<CustomOperation "admin_user_password">]
        member _.AdminUserPassword(state: DocdbelasticClusterState<'AdminUserName, Missing, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>, value: string) : DocdbelasticClusterState<'AdminUserName, Present, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount> =
            state.assignments.Add(fun config -> config.AdminUserPassword <- value)
            ({ assignments = state.assignments } : DocdbelasticClusterState<'AdminUserName, Present, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdbelastic_cluster#auth_type-1">DocdbelasticCluster#auth_type</a>.
        /// </summary>
        [<CustomOperation "auth_type">]
        member _.AuthType(state: DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, Missing, 'Name, 'ShardCapacity, 'ShardCount>, value: string) : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, Present, 'Name, 'ShardCapacity, 'ShardCount> =
            state.assignments.Add(fun config -> config.AuthType <- value)
            ({ assignments = state.assignments } : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, Present, 'Name, 'ShardCapacity, 'ShardCount>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdbelastic_cluster#name-1">DocdbelasticCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, Missing, 'ShardCapacity, 'ShardCount>, value: string) : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, Present, 'ShardCapacity, 'ShardCount> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, Present, 'ShardCapacity, 'ShardCount>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdbelastic_cluster#shard_capacity-1">DocdbelasticCluster#shard_capacity</a>.
        /// </summary>
        [<CustomOperation "shard_capacity">]
        member _.ShardCapacity(state: DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, Missing, 'ShardCount>, value: double) : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, Present, 'ShardCount> =
            state.assignments.Add(fun config -> config.ShardCapacity <- value)
            ({ assignments = state.assignments } : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, Present, 'ShardCount>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdbelastic_cluster#shard_count-1">DocdbelasticCluster#shard_count</a>.
        /// </summary>
        [<CustomOperation "shard_count">]
        member _.ShardCount(state: DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, Missing>, value: double) : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, Present> =
            state.assignments.Add(fun config -> config.ShardCount <- value)
            ({ assignments = state.assignments } : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdbelastic_cluster#backup_retention_period-1">DocdbelasticCluster#backup_retention_period</a>.
        /// </summary>
        [<CustomOperation "backup_retention_period">]
        member _.BackupRetentionPeriod(state: DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>, value: double) : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount> =
            state.assignments.Add(fun config -> config.BackupRetentionPeriod <- value)
            state : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdbelastic_cluster#kms_key_id-1">DocdbelasticCluster#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>, value: string) : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdbelastic_cluster#preferred_backup_window-1">DocdbelasticCluster#preferred_backup_window</a>.
        /// </summary>
        [<CustomOperation "preferred_backup_window">]
        member _.PreferredBackupWindow(state: DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>, value: string) : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount> =
            state.assignments.Add(fun config -> config.PreferredBackupWindow <- value)
            state : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdbelastic_cluster#preferred_maintenance_window-1">DocdbelasticCluster#preferred_maintenance_window</a>.
        /// </summary>
        [<CustomOperation "preferred_maintenance_window">]
        member _.PreferredMaintenanceWindow(state: DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>, value: string) : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount> =
            state.assignments.Add(fun config -> config.PreferredMaintenanceWindow <- value)
            state : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdbelastic_cluster#subnet_ids-1">DocdbelasticCluster#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>, value: seq<string>) : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            state : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdbelastic_cluster#tags-1">DocdbelasticCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>, value: seq<string * string>) : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdbelastic_cluster#timeouts-1">DocdbelasticCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>, value: aws.DocdbelasticCluster.DocdbelasticClusterTimeouts) : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdbelastic_cluster#vpc_security_group_ids-1">DocdbelasticCluster#vpc_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_security_group_ids">]
        member _.VpcSecurityGroupIds(state: DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>, value: seq<string>) : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount> =
            state.assignments.Add(fun config -> config.VpcSecurityGroupIds <- (value |> Seq.toArray))
            state : DocdbelasticClusterState<'AdminUserName, 'AdminUserPassword, 'AuthType, 'Name, 'ShardCapacity, 'ShardCount>

        member _.Run(state: DocdbelasticClusterState<Present, Present, Present, Present, Present, Present>) : aws.DocdbelasticCluster.DocdbelasticCluster =
            let config = aws.DocdbelasticCluster.DocdbelasticClusterConfig()
            for setter in state.assignments do
                setter config
            aws.DocdbelasticCluster.DocdbelasticCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.docdbelasticCluster: missing required arguments. Must call: admin_user_name, admin_user_password, auth_type, name, shard_capacity, shard_count.", 9999, IsError = true)>]
        member _.Run(_: DocdbelasticClusterState<_, _, _, _, _, _>) : aws.DocdbelasticCluster.DocdbelasticCluster =
            Unchecked.defaultof<aws.DocdbelasticCluster.DocdbelasticCluster>
