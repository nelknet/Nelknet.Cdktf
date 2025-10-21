namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EfsAccessPointState<'FileSystemId> = { assignments: ResizeArray<aws.EfsAccessPoint.EfsAccessPointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point">aws_efs_access_point</a>.
    /// </summary>
    type EfsAccessPointBuilder(logicalId: string) =
        member _.Yield(_: unit) : EfsAccessPointState<Missing> =
            ({ assignments = ResizeArray() } : EfsAccessPointState<Missing>)

        member _.Zero(()) : EfsAccessPointState<Missing> =
            ({ assignments = ResizeArray() } : EfsAccessPointState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#file_system_id-1">EfsAccessPoint#file_system_id</a>.
        /// </summary>
        [<CustomOperation "file_system_id">]
        member _.FileSystemId(state: EfsAccessPointState<Missing>, value: string) : EfsAccessPointState<Present> =
            state.assignments.Add(fun config -> config.FileSystemId <- value)
            ({ assignments = state.assignments } : EfsAccessPointState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#id-1">EfsAccessPoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EfsAccessPointState<'FileSystemId>, value: string) : EfsAccessPointState<'FileSystemId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EfsAccessPointState<'FileSystemId>

        /// <summary>
        /// posix_user block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#posix_user-1">EfsAccessPoint#posix_user</a>
        /// </summary>
        [<CustomOperation "posix_user">]
        member _.PosixUser(state: EfsAccessPointState<'FileSystemId>, value: aws.EfsAccessPoint.EfsAccessPointPosixUser) : EfsAccessPointState<'FileSystemId> =
            state.assignments.Add(fun config -> config.PosixUser <- value)
            state : EfsAccessPointState<'FileSystemId>

        /// <summary>
        /// root_directory block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#root_directory-1">EfsAccessPoint#root_directory</a>
        /// </summary>
        [<CustomOperation "root_directory">]
        member _.RootDirectory(state: EfsAccessPointState<'FileSystemId>, value: aws.EfsAccessPoint.EfsAccessPointRootDirectory) : EfsAccessPointState<'FileSystemId> =
            state.assignments.Add(fun config -> config.RootDirectory <- value)
            state : EfsAccessPointState<'FileSystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#tags-1">EfsAccessPoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EfsAccessPointState<'FileSystemId>, value: seq<string * string>) : EfsAccessPointState<'FileSystemId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EfsAccessPointState<'FileSystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#tags_all-1">EfsAccessPoint#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EfsAccessPointState<'FileSystemId>, value: seq<string * string>) : EfsAccessPointState<'FileSystemId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EfsAccessPointState<'FileSystemId>

        member _.Run(state: EfsAccessPointState<Present>) : aws.EfsAccessPoint.EfsAccessPoint =
            let config = aws.EfsAccessPoint.EfsAccessPointConfig()
            for setter in state.assignments do
                setter config
            aws.EfsAccessPoint.EfsAccessPoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.efsAccessPoint: missing required arguments. Must call: file_system_id.", 9999, IsError = true)>]
        member _.Run(_: EfsAccessPointState<_>) : aws.EfsAccessPoint.EfsAccessPoint =
            Unchecked.defaultof<aws.EfsAccessPoint.EfsAccessPoint>
