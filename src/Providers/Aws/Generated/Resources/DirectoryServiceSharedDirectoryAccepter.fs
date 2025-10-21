namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DirectoryServiceSharedDirectoryAccepterState<'SharedDirectoryId> = { assignments: ResizeArray<aws.DirectoryServiceSharedDirectoryAccepter.DirectoryServiceSharedDirectoryAccepterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_shared_directory_accepter">aws_directory_service_shared_directory_accepter</a>.
    /// </summary>
    type DirectoryServiceSharedDirectoryAccepterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DirectoryServiceSharedDirectoryAccepterState<Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceSharedDirectoryAccepterState<Missing>)

        member _.Zero(()) : DirectoryServiceSharedDirectoryAccepterState<Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceSharedDirectoryAccepterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_shared_directory_accepter#shared_directory_id-1">DirectoryServiceSharedDirectoryAccepter#shared_directory_id</a>.
        /// </summary>
        [<CustomOperation "shared_directory_id">]
        member _.SharedDirectoryId(state: DirectoryServiceSharedDirectoryAccepterState<Missing>, value: string) : DirectoryServiceSharedDirectoryAccepterState<Present> =
            state.assignments.Add(fun config -> config.SharedDirectoryId <- value)
            ({ assignments = state.assignments } : DirectoryServiceSharedDirectoryAccepterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_shared_directory_accepter#id-1">DirectoryServiceSharedDirectoryAccepter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DirectoryServiceSharedDirectoryAccepterState<'SharedDirectoryId>, value: string) : DirectoryServiceSharedDirectoryAccepterState<'SharedDirectoryId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DirectoryServiceSharedDirectoryAccepterState<'SharedDirectoryId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_shared_directory_accepter#timeouts-1">DirectoryServiceSharedDirectoryAccepter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DirectoryServiceSharedDirectoryAccepterState<'SharedDirectoryId>, value: aws.DirectoryServiceSharedDirectoryAccepter.DirectoryServiceSharedDirectoryAccepterTimeouts) : DirectoryServiceSharedDirectoryAccepterState<'SharedDirectoryId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DirectoryServiceSharedDirectoryAccepterState<'SharedDirectoryId>

        member _.Run(state: DirectoryServiceSharedDirectoryAccepterState<Present>) : aws.DirectoryServiceSharedDirectoryAccepter.DirectoryServiceSharedDirectoryAccepter =
            let config = aws.DirectoryServiceSharedDirectoryAccepter.DirectoryServiceSharedDirectoryAccepterConfig()
            for setter in state.assignments do
                setter config
            aws.DirectoryServiceSharedDirectoryAccepter.DirectoryServiceSharedDirectoryAccepter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.directoryServiceSharedDirectoryAccepter: missing required arguments. Must call: shared_directory_id.", 9999, IsError = true)>]
        member _.Run(_: DirectoryServiceSharedDirectoryAccepterState<_>) : aws.DirectoryServiceSharedDirectoryAccepter.DirectoryServiceSharedDirectoryAccepter =
            Unchecked.defaultof<aws.DirectoryServiceSharedDirectoryAccepter.DirectoryServiceSharedDirectoryAccepter>
