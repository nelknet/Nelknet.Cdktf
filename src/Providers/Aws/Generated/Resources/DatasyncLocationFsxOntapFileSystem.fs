namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, 'StorageVirtualMachineArn> = { assignments: ResizeArray<aws.DatasyncLocationFsxOntapFileSystem.DatasyncLocationFsxOntapFileSystemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_ontap_file_system">aws_datasync_location_fsx_ontap_file_system</a>.
    /// </summary>
    type DatasyncLocationFsxOntapFileSystemBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatasyncLocationFsxOntapFileSystemState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationFsxOntapFileSystemState<Missing, Missing, Missing>)

        member _.Zero(()) : DatasyncLocationFsxOntapFileSystemState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationFsxOntapFileSystemState<Missing, Missing, Missing>)

        /// <summary>
        /// protocol block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_ontap_file_system#protocol-1">DatasyncLocationFsxOntapFileSystem#protocol</a>
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: DatasyncLocationFsxOntapFileSystemState<Missing, 'SecurityGroupArns, 'StorageVirtualMachineArn>, value: aws.DatasyncLocationFsxOntapFileSystem.DatasyncLocationFsxOntapFileSystemProtocol) : DatasyncLocationFsxOntapFileSystemState<Present, 'SecurityGroupArns, 'StorageVirtualMachineArn> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : DatasyncLocationFsxOntapFileSystemState<Present, 'SecurityGroupArns, 'StorageVirtualMachineArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_ontap_file_system#security_group_arns-1">DatasyncLocationFsxOntapFileSystem#security_group_arns</a>.
        /// </summary>
        [<CustomOperation "security_group_arns">]
        member _.SecurityGroupArns(state: DatasyncLocationFsxOntapFileSystemState<'Protocol, Missing, 'StorageVirtualMachineArn>, value: seq<string>) : DatasyncLocationFsxOntapFileSystemState<'Protocol, Present, 'StorageVirtualMachineArn> =
            state.assignments.Add(fun config -> config.SecurityGroupArns <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DatasyncLocationFsxOntapFileSystemState<'Protocol, Present, 'StorageVirtualMachineArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_ontap_file_system#storage_virtual_machine_arn-1">DatasyncLocationFsxOntapFileSystem#storage_virtual_machine_arn</a>.
        /// </summary>
        [<CustomOperation "storage_virtual_machine_arn">]
        member _.StorageVirtualMachineArn(state: DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, Missing>, value: string) : DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, Present> =
            state.assignments.Add(fun config -> config.StorageVirtualMachineArn <- value)
            ({ assignments = state.assignments } : DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_ontap_file_system#id-1">DatasyncLocationFsxOntapFileSystem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, 'StorageVirtualMachineArn>, value: string) : DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, 'StorageVirtualMachineArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, 'StorageVirtualMachineArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_ontap_file_system#subdirectory-1">DatasyncLocationFsxOntapFileSystem#subdirectory</a>.
        /// </summary>
        [<CustomOperation "subdirectory">]
        member _.Subdirectory(state: DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, 'StorageVirtualMachineArn>, value: string) : DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, 'StorageVirtualMachineArn> =
            state.assignments.Add(fun config -> config.Subdirectory <- value)
            state : DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, 'StorageVirtualMachineArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_ontap_file_system#tags-1">DatasyncLocationFsxOntapFileSystem#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, 'StorageVirtualMachineArn>, value: seq<string * string>) : DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, 'StorageVirtualMachineArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, 'StorageVirtualMachineArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_ontap_file_system#tags_all-1">DatasyncLocationFsxOntapFileSystem#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, 'StorageVirtualMachineArn>, value: seq<string * string>) : DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, 'StorageVirtualMachineArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DatasyncLocationFsxOntapFileSystemState<'Protocol, 'SecurityGroupArns, 'StorageVirtualMachineArn>

        member _.Run(state: DatasyncLocationFsxOntapFileSystemState<Present, Present, Present>) : aws.DatasyncLocationFsxOntapFileSystem.DatasyncLocationFsxOntapFileSystem =
            let config = aws.DatasyncLocationFsxOntapFileSystem.DatasyncLocationFsxOntapFileSystemConfig()
            for setter in state.assignments do
                setter config
            aws.DatasyncLocationFsxOntapFileSystem.DatasyncLocationFsxOntapFileSystem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datasyncLocationFsxOntapFileSystem: missing required arguments. Must call: protocol, security_group_arns, storage_virtual_machine_arn.", 9999, IsError = true)>]
        member _.Run(_: DatasyncLocationFsxOntapFileSystemState<_, _, _>) : aws.DatasyncLocationFsxOntapFileSystem.DatasyncLocationFsxOntapFileSystem =
            Unchecked.defaultof<aws.DatasyncLocationFsxOntapFileSystem.DatasyncLocationFsxOntapFileSystem>
