namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBackupFrameworkState<'Name> = { assignments: ResizeArray<aws.DataAwsBackupFramework.DataAwsBackupFrameworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_framework">aws_backup_framework</a>.
    /// </summary>
    type DataAwsBackupFrameworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBackupFrameworkState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBackupFrameworkState<Missing>)

        member _.Zero(()) : DataAwsBackupFrameworkState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBackupFrameworkState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_framework#name-1">DataAwsBackupFramework#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsBackupFrameworkState<Missing>, value: string) : DataAwsBackupFrameworkState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsBackupFrameworkState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_framework#id-1">DataAwsBackupFramework#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsBackupFrameworkState<'Name>, value: string) : DataAwsBackupFrameworkState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsBackupFrameworkState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_framework#tags-1">DataAwsBackupFramework#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsBackupFrameworkState<'Name>, value: seq<string * string>) : DataAwsBackupFrameworkState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsBackupFrameworkState<'Name>

        member _.Run(state: DataAwsBackupFrameworkState<Present>) : aws.DataAwsBackupFramework.DataAwsBackupFramework =
            let config = aws.DataAwsBackupFramework.DataAwsBackupFrameworkConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBackupFramework.DataAwsBackupFramework(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsBackupFramework: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsBackupFrameworkState<_>) : aws.DataAwsBackupFramework.DataAwsBackupFramework =
            Unchecked.defaultof<aws.DataAwsBackupFramework.DataAwsBackupFramework>
