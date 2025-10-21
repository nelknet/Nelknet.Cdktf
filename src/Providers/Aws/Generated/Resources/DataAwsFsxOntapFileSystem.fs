namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsFsxOntapFileSystemState<'Id> = { assignments: ResizeArray<aws.DataAwsFsxOntapFileSystem.DataAwsFsxOntapFileSystemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_ontap_file_system">aws_fsx_ontap_file_system</a>.
    /// </summary>
    type DataAwsFsxOntapFileSystemBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsFsxOntapFileSystemState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsFsxOntapFileSystemState<Missing>)

        member _.Zero(()) : DataAwsFsxOntapFileSystemState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsFsxOntapFileSystemState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_ontap_file_system#id-1">DataAwsFsxOntapFileSystem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsFsxOntapFileSystemState<Missing>, value: string) : DataAwsFsxOntapFileSystemState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsFsxOntapFileSystemState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_ontap_file_system#tags-1">DataAwsFsxOntapFileSystem#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsFsxOntapFileSystemState<'Id>, value: seq<string * string>) : DataAwsFsxOntapFileSystemState<'Id> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsFsxOntapFileSystemState<'Id>

        member _.Run(state: DataAwsFsxOntapFileSystemState<Present>) : aws.DataAwsFsxOntapFileSystem.DataAwsFsxOntapFileSystem =
            let config = aws.DataAwsFsxOntapFileSystem.DataAwsFsxOntapFileSystemConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsFsxOntapFileSystem.DataAwsFsxOntapFileSystem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsFsxOntapFileSystem: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsFsxOntapFileSystemState<_>) : aws.DataAwsFsxOntapFileSystem.DataAwsFsxOntapFileSystem =
            Unchecked.defaultof<aws.DataAwsFsxOntapFileSystem.DataAwsFsxOntapFileSystem>
