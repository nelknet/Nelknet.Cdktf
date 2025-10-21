namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DirectoryServiceSharedDirectoryState<'DirectoryId, 'Target> = { assignments: ResizeArray<aws.DirectoryServiceSharedDirectory.DirectoryServiceSharedDirectoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_shared_directory">aws_directory_service_shared_directory</a>.
    /// </summary>
    type DirectoryServiceSharedDirectoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DirectoryServiceSharedDirectoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceSharedDirectoryState<Missing, Missing>)

        member _.Zero(()) : DirectoryServiceSharedDirectoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceSharedDirectoryState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_shared_directory#directory_id-1">DirectoryServiceSharedDirectory#directory_id</a>.
        /// </summary>
        [<CustomOperation "directory_id">]
        member _.DirectoryId(state: DirectoryServiceSharedDirectoryState<Missing, 'Target>, value: string) : DirectoryServiceSharedDirectoryState<Present, 'Target> =
            state.assignments.Add(fun config -> config.DirectoryId <- value)
            ({ assignments = state.assignments } : DirectoryServiceSharedDirectoryState<Present, 'Target>)

        /// <summary>
        /// target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_shared_directory#target-1">DirectoryServiceSharedDirectory#target</a>
        /// </summary>
        [<CustomOperation "target">]
        member _.Target(state: DirectoryServiceSharedDirectoryState<'DirectoryId, Missing>, value: aws.DirectoryServiceSharedDirectory.DirectoryServiceSharedDirectoryTarget) : DirectoryServiceSharedDirectoryState<'DirectoryId, Present> =
            state.assignments.Add(fun config -> config.Target <- value)
            ({ assignments = state.assignments } : DirectoryServiceSharedDirectoryState<'DirectoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_shared_directory#id-1">DirectoryServiceSharedDirectory#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DirectoryServiceSharedDirectoryState<'DirectoryId, 'Target>, value: string) : DirectoryServiceSharedDirectoryState<'DirectoryId, 'Target> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DirectoryServiceSharedDirectoryState<'DirectoryId, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_shared_directory#method-1">DirectoryServiceSharedDirectory#method</a>.
        /// </summary>
        [<CustomOperation "method">]
        member _.Method(state: DirectoryServiceSharedDirectoryState<'DirectoryId, 'Target>, value: string) : DirectoryServiceSharedDirectoryState<'DirectoryId, 'Target> =
            state.assignments.Add(fun config -> config.Method <- value)
            state : DirectoryServiceSharedDirectoryState<'DirectoryId, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_shared_directory#notes-1">DirectoryServiceSharedDirectory#notes</a>.
        /// </summary>
        [<CustomOperation "notes">]
        member _.Notes(state: DirectoryServiceSharedDirectoryState<'DirectoryId, 'Target>, value: string) : DirectoryServiceSharedDirectoryState<'DirectoryId, 'Target> =
            state.assignments.Add(fun config -> config.Notes <- value)
            state : DirectoryServiceSharedDirectoryState<'DirectoryId, 'Target>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_shared_directory#timeouts-1">DirectoryServiceSharedDirectory#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DirectoryServiceSharedDirectoryState<'DirectoryId, 'Target>, value: aws.DirectoryServiceSharedDirectory.DirectoryServiceSharedDirectoryTimeouts) : DirectoryServiceSharedDirectoryState<'DirectoryId, 'Target> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DirectoryServiceSharedDirectoryState<'DirectoryId, 'Target>

        member _.Run(state: DirectoryServiceSharedDirectoryState<Present, Present>) : aws.DirectoryServiceSharedDirectory.DirectoryServiceSharedDirectory =
            let config = aws.DirectoryServiceSharedDirectory.DirectoryServiceSharedDirectoryConfig()
            for setter in state.assignments do
                setter config
            aws.DirectoryServiceSharedDirectory.DirectoryServiceSharedDirectory(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.directoryServiceSharedDirectory: missing required arguments. Must call: directory_id, target.", 9999, IsError = true)>]
        member _.Run(_: DirectoryServiceSharedDirectoryState<_, _>) : aws.DirectoryServiceSharedDirectory.DirectoryServiceSharedDirectory =
            Unchecked.defaultof<aws.DirectoryServiceSharedDirectory.DirectoryServiceSharedDirectory>
