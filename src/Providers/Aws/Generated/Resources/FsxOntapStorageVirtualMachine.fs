namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name> = { assignments: ResizeArray<aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine">aws_fsx_ontap_storage_virtual_machine</a>.
    /// </summary>
    type FsxOntapStorageVirtualMachineBuilder(logicalId: string) =
        member _.Yield(_: unit) : FsxOntapStorageVirtualMachineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxOntapStorageVirtualMachineState<Missing, Missing>)

        member _.Zero(()) : FsxOntapStorageVirtualMachineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxOntapStorageVirtualMachineState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine#file_system_id-1">FsxOntapStorageVirtualMachine#file_system_id</a>.
        /// </summary>
        [<CustomOperation "file_system_id">]
        member _.FileSystemId(state: FsxOntapStorageVirtualMachineState<Missing, 'Name>, value: string) : FsxOntapStorageVirtualMachineState<Present, 'Name> =
            state.assignments.Add(fun config -> config.FileSystemId <- value)
            ({ assignments = state.assignments } : FsxOntapStorageVirtualMachineState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine#name-1">FsxOntapStorageVirtualMachine#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FsxOntapStorageVirtualMachineState<'FileSystemId, Missing>, value: string) : FsxOntapStorageVirtualMachineState<'FileSystemId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FsxOntapStorageVirtualMachineState<'FileSystemId, Present>)

        /// <summary>
        /// active_directory_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine#active_directory_configuration-1">FsxOntapStorageVirtualMachine#active_directory_configuration</a>
        /// </summary>
        [<CustomOperation "active_directory_configuration">]
        member _.ActiveDirectoryConfiguration(state: FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name>, value: aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineActiveDirectoryConfiguration) : FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name> =
            state.assignments.Add(fun config -> config.ActiveDirectoryConfiguration <- value)
            state : FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine#id-1">FsxOntapStorageVirtualMachine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name>, value: string) : FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine#root_volume_security_style-1">FsxOntapStorageVirtualMachine#root_volume_security_style</a>.
        /// </summary>
        [<CustomOperation "root_volume_security_style">]
        member _.RootVolumeSecurityStyle(state: FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name>, value: string) : FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name> =
            state.assignments.Add(fun config -> config.RootVolumeSecurityStyle <- value)
            state : FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine#svm_admin_password-1">FsxOntapStorageVirtualMachine#svm_admin_password</a>.
        /// </summary>
        [<CustomOperation "svm_admin_password">]
        member _.SvmAdminPassword(state: FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name>, value: string) : FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name> =
            state.assignments.Add(fun config -> config.SvmAdminPassword <- value)
            state : FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine#tags-1">FsxOntapStorageVirtualMachine#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name>, value: seq<string * string>) : FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine#tags_all-1">FsxOntapStorageVirtualMachine#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name>, value: seq<string * string>) : FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_storage_virtual_machine#timeouts-1">FsxOntapStorageVirtualMachine#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name>, value: aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineTimeouts) : FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FsxOntapStorageVirtualMachineState<'FileSystemId, 'Name>

        member _.Run(state: FsxOntapStorageVirtualMachineState<Present, Present>) : aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachine =
            let config = aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineConfig()
            for setter in state.assignments do
                setter config
            aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachine(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.fsxOntapStorageVirtualMachine: missing required arguments. Must call: file_system_id, name.", 9999, IsError = true)>]
        member _.Run(_: FsxOntapStorageVirtualMachineState<_, _>) : aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachine =
            Unchecked.defaultof<aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachine>
