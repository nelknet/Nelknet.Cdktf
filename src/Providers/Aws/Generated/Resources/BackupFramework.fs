namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupFrameworkState<'Control, 'Name> = { assignments: ResizeArray<aws.BackupFramework.BackupFrameworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_framework">aws_backup_framework</a>.
    /// </summary>
    type BackupFrameworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupFrameworkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupFrameworkState<Missing, Missing>)

        member _.Zero(()) : BackupFrameworkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupFrameworkState<Missing, Missing>)

        /// <summary>
        /// control block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_framework#control-1">BackupFramework#control</a> Accepts: aws.IResolvable | aws.BackupFramework.BackupFrameworkControl[]
        /// </summary>
        [<CustomOperation "control">]
        member _.Control(state: BackupFrameworkState<Missing, 'Name>, value: HashiCorp.Cdktf.IResolvable) : BackupFrameworkState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Control <- value)
            ({ assignments = state.assignments } : BackupFrameworkState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_framework#name-1">BackupFramework#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BackupFrameworkState<'Control, Missing>, value: string) : BackupFrameworkState<'Control, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BackupFrameworkState<'Control, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_framework#description-1">BackupFramework#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: BackupFrameworkState<'Control, 'Name>, value: string) : BackupFrameworkState<'Control, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : BackupFrameworkState<'Control, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_framework#id-1">BackupFramework#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupFrameworkState<'Control, 'Name>, value: string) : BackupFrameworkState<'Control, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupFrameworkState<'Control, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_framework#tags-1">BackupFramework#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BackupFrameworkState<'Control, 'Name>, value: seq<string * string>) : BackupFrameworkState<'Control, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BackupFrameworkState<'Control, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_framework#tags_all-1">BackupFramework#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: BackupFrameworkState<'Control, 'Name>, value: seq<string * string>) : BackupFrameworkState<'Control, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : BackupFrameworkState<'Control, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_framework#timeouts-1">BackupFramework#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BackupFrameworkState<'Control, 'Name>, value: aws.BackupFramework.BackupFrameworkTimeouts) : BackupFrameworkState<'Control, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BackupFrameworkState<'Control, 'Name>

        member _.Run(state: BackupFrameworkState<Present, Present>) : aws.BackupFramework.BackupFramework =
            let config = aws.BackupFramework.BackupFrameworkConfig()
            for setter in state.assignments do
                setter config
            aws.BackupFramework.BackupFramework(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.backupFramework: missing required arguments. Must call: control, name.", 9999, IsError = true)>]
        member _.Run(_: BackupFrameworkState<_, _>) : aws.BackupFramework.BackupFramework =
            Unchecked.defaultof<aws.BackupFramework.BackupFramework>
