namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightFolderState<'FolderId> = { assignments: ResizeArray<aws.QuicksightFolder.QuicksightFolderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder">aws_quicksight_folder</a>.
    /// </summary>
    type QuicksightFolderBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightFolderState<Missing> =
            ({ assignments = ResizeArray() } : QuicksightFolderState<Missing>)

        member _.Zero(()) : QuicksightFolderState<Missing> =
            ({ assignments = ResizeArray() } : QuicksightFolderState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder#folder_id-1">QuicksightFolder#folder_id</a>.
        /// </summary>
        [<CustomOperation "folder_id">]
        member _.FolderId(state: QuicksightFolderState<Missing>, value: string) : QuicksightFolderState<Present> =
            state.assignments.Add(fun config -> config.FolderId <- value)
            ({ assignments = state.assignments } : QuicksightFolderState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder#aws_account_id-1">QuicksightFolder#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightFolderState<'FolderId>, value: string) : QuicksightFolderState<'FolderId> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightFolderState<'FolderId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder#folder_type-1">QuicksightFolder#folder_type</a>.
        /// </summary>
        [<CustomOperation "folder_type">]
        member _.FolderType(state: QuicksightFolderState<'FolderId>, value: string) : QuicksightFolderState<'FolderId> =
            state.assignments.Add(fun config -> config.FolderType <- value)
            state : QuicksightFolderState<'FolderId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder#id-1">QuicksightFolder#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: QuicksightFolderState<'FolderId>, value: string) : QuicksightFolderState<'FolderId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : QuicksightFolderState<'FolderId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder#name-1">QuicksightFolder#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: QuicksightFolderState<'FolderId>, value: string) : QuicksightFolderState<'FolderId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : QuicksightFolderState<'FolderId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder#parent_folder_arn-1">QuicksightFolder#parent_folder_arn</a>.
        /// </summary>
        [<CustomOperation "parent_folder_arn">]
        member _.ParentFolderArn(state: QuicksightFolderState<'FolderId>, value: string) : QuicksightFolderState<'FolderId> =
            state.assignments.Add(fun config -> config.ParentFolderArn <- value)
            state : QuicksightFolderState<'FolderId>

        /// <summary>
        /// permissions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder#permissions-1">QuicksightFolder#permissions</a> Accepts: aws.IResolvable | aws.QuicksightFolder.QuicksightFolderPermissions[]
        /// </summary>
        [<CustomOperation "permissions">]
        member _.Permissions(state: QuicksightFolderState<'FolderId>, value: HashiCorp.Cdktf.IResolvable) : QuicksightFolderState<'FolderId> =
            state.assignments.Add(fun config -> config.Permissions <- value)
            state : QuicksightFolderState<'FolderId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder#tags-1">QuicksightFolder#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: QuicksightFolderState<'FolderId>, value: seq<string * string>) : QuicksightFolderState<'FolderId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : QuicksightFolderState<'FolderId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder#tags_all-1">QuicksightFolder#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: QuicksightFolderState<'FolderId>, value: seq<string * string>) : QuicksightFolderState<'FolderId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : QuicksightFolderState<'FolderId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_folder#timeouts-1">QuicksightFolder#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: QuicksightFolderState<'FolderId>, value: aws.QuicksightFolder.QuicksightFolderTimeouts) : QuicksightFolderState<'FolderId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : QuicksightFolderState<'FolderId>

        member _.Run(state: QuicksightFolderState<Present>) : aws.QuicksightFolder.QuicksightFolder =
            let config = aws.QuicksightFolder.QuicksightFolderConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightFolder.QuicksightFolder(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightFolder: missing required arguments. Must call: folder_id.", 9999, IsError = true)>]
        member _.Run(_: QuicksightFolderState<_>) : aws.QuicksightFolder.QuicksightFolder =
            Unchecked.defaultof<aws.QuicksightFolder.QuicksightFolder>
