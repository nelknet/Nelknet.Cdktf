namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsFsxWindowsFileSystemState<'Id> = { assignments: ResizeArray<aws.DataAwsFsxWindowsFileSystem.DataAwsFsxWindowsFileSystemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_windows_file_system">aws_fsx_windows_file_system</a>.
    /// </summary>
    type DataAwsFsxWindowsFileSystemBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsFsxWindowsFileSystemState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsFsxWindowsFileSystemState<Missing>)

        member _.Zero(()) : DataAwsFsxWindowsFileSystemState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsFsxWindowsFileSystemState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_windows_file_system#id-1">DataAwsFsxWindowsFileSystem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsFsxWindowsFileSystemState<Missing>, value: string) : DataAwsFsxWindowsFileSystemState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsFsxWindowsFileSystemState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_windows_file_system#tags-1">DataAwsFsxWindowsFileSystem#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsFsxWindowsFileSystemState<'Id>, value: seq<string * string>) : DataAwsFsxWindowsFileSystemState<'Id> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsFsxWindowsFileSystemState<'Id>

        member _.Run(state: DataAwsFsxWindowsFileSystemState<Present>) : aws.DataAwsFsxWindowsFileSystem.DataAwsFsxWindowsFileSystem =
            let config = aws.DataAwsFsxWindowsFileSystem.DataAwsFsxWindowsFileSystemConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsFsxWindowsFileSystem.DataAwsFsxWindowsFileSystem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsFsxWindowsFileSystem: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsFsxWindowsFileSystemState<_>) : aws.DataAwsFsxWindowsFileSystem.DataAwsFsxWindowsFileSystem =
            Unchecked.defaultof<aws.DataAwsFsxWindowsFileSystem.DataAwsFsxWindowsFileSystem>
