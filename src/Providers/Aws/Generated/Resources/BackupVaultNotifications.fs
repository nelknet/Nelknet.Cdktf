namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupVaultNotificationsState<'BackupVaultEvents, 'BackupVaultName, 'SnsTopicArn> = { assignments: ResizeArray<aws.BackupVaultNotifications.BackupVaultNotificationsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault_notifications">aws_backup_vault_notifications</a>.
    /// </summary>
    type BackupVaultNotificationsBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupVaultNotificationsState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupVaultNotificationsState<Missing, Missing, Missing>)

        member _.Zero(()) : BackupVaultNotificationsState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupVaultNotificationsState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault_notifications#backup_vault_events-1">BackupVaultNotifications#backup_vault_events</a>.
        /// </summary>
        [<CustomOperation "backup_vault_events">]
        member _.BackupVaultEvents(state: BackupVaultNotificationsState<Missing, 'BackupVaultName, 'SnsTopicArn>, value: seq<string>) : BackupVaultNotificationsState<Present, 'BackupVaultName, 'SnsTopicArn> =
            state.assignments.Add(fun config -> config.BackupVaultEvents <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : BackupVaultNotificationsState<Present, 'BackupVaultName, 'SnsTopicArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault_notifications#backup_vault_name-1">BackupVaultNotifications#backup_vault_name</a>.
        /// </summary>
        [<CustomOperation "backup_vault_name">]
        member _.BackupVaultName(state: BackupVaultNotificationsState<'BackupVaultEvents, Missing, 'SnsTopicArn>, value: string) : BackupVaultNotificationsState<'BackupVaultEvents, Present, 'SnsTopicArn> =
            state.assignments.Add(fun config -> config.BackupVaultName <- value)
            ({ assignments = state.assignments } : BackupVaultNotificationsState<'BackupVaultEvents, Present, 'SnsTopicArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault_notifications#sns_topic_arn-1">BackupVaultNotifications#sns_topic_arn</a>.
        /// </summary>
        [<CustomOperation "sns_topic_arn">]
        member _.SnsTopicArn(state: BackupVaultNotificationsState<'BackupVaultEvents, 'BackupVaultName, Missing>, value: string) : BackupVaultNotificationsState<'BackupVaultEvents, 'BackupVaultName, Present> =
            state.assignments.Add(fun config -> config.SnsTopicArn <- value)
            ({ assignments = state.assignments } : BackupVaultNotificationsState<'BackupVaultEvents, 'BackupVaultName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault_notifications#id-1">BackupVaultNotifications#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupVaultNotificationsState<'BackupVaultEvents, 'BackupVaultName, 'SnsTopicArn>, value: string) : BackupVaultNotificationsState<'BackupVaultEvents, 'BackupVaultName, 'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupVaultNotificationsState<'BackupVaultEvents, 'BackupVaultName, 'SnsTopicArn>

        member _.Run(state: BackupVaultNotificationsState<Present, Present, Present>) : aws.BackupVaultNotifications.BackupVaultNotifications =
            let config = aws.BackupVaultNotifications.BackupVaultNotificationsConfig()
            for setter in state.assignments do
                setter config
            aws.BackupVaultNotifications.BackupVaultNotifications(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.backupVaultNotifications: missing required arguments. Must call: backup_vault_events, backup_vault_name, sns_topic_arn.", 9999, IsError = true)>]
        member _.Run(_: BackupVaultNotificationsState<_, _, _>) : aws.BackupVaultNotifications.BackupVaultNotifications =
            Unchecked.defaultof<aws.BackupVaultNotifications.BackupVaultNotifications>
