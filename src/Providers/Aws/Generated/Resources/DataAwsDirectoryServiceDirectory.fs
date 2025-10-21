namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDirectoryServiceDirectoryState<'DirectoryId> = { assignments: ResizeArray<aws.DataAwsDirectoryServiceDirectory.DataAwsDirectoryServiceDirectoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/directory_service_directory">aws_directory_service_directory</a>.
    /// </summary>
    type DataAwsDirectoryServiceDirectoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDirectoryServiceDirectoryState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDirectoryServiceDirectoryState<Missing>)

        member _.Zero(()) : DataAwsDirectoryServiceDirectoryState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDirectoryServiceDirectoryState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/directory_service_directory#directory_id-1">DataAwsDirectoryServiceDirectory#directory_id</a>.
        /// </summary>
        [<CustomOperation "directory_id">]
        member _.DirectoryId(state: DataAwsDirectoryServiceDirectoryState<Missing>, value: string) : DataAwsDirectoryServiceDirectoryState<Present> =
            state.assignments.Add(fun config -> config.DirectoryId <- value)
            ({ assignments = state.assignments } : DataAwsDirectoryServiceDirectoryState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/directory_service_directory#id-1">DataAwsDirectoryServiceDirectory#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDirectoryServiceDirectoryState<'DirectoryId>, value: string) : DataAwsDirectoryServiceDirectoryState<'DirectoryId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDirectoryServiceDirectoryState<'DirectoryId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/directory_service_directory#tags-1">DataAwsDirectoryServiceDirectory#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsDirectoryServiceDirectoryState<'DirectoryId>, value: seq<string * string>) : DataAwsDirectoryServiceDirectoryState<'DirectoryId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsDirectoryServiceDirectoryState<'DirectoryId>

        member _.Run(state: DataAwsDirectoryServiceDirectoryState<Present>) : aws.DataAwsDirectoryServiceDirectory.DataAwsDirectoryServiceDirectory =
            let config = aws.DataAwsDirectoryServiceDirectory.DataAwsDirectoryServiceDirectoryConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDirectoryServiceDirectory.DataAwsDirectoryServiceDirectory(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDirectoryServiceDirectory: missing required arguments. Must call: directory_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDirectoryServiceDirectoryState<_>) : aws.DataAwsDirectoryServiceDirectory.DataAwsDirectoryServiceDirectory =
            Unchecked.defaultof<aws.DataAwsDirectoryServiceDirectory.DataAwsDirectoryServiceDirectory>
