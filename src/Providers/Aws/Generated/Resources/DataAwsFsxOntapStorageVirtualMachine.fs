namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsFsxOntapStorageVirtualMachineState = { assignments: ResizeArray<aws.DataAwsFsxOntapStorageVirtualMachine.DataAwsFsxOntapStorageVirtualMachineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_ontap_storage_virtual_machine">aws_fsx_ontap_storage_virtual_machine</a>.
    /// </summary>
    type DataAwsFsxOntapStorageVirtualMachineBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsFsxOntapStorageVirtualMachineState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsFsxOntapStorageVirtualMachineState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_ontap_storage_virtual_machine#filter-1">DataAwsFsxOntapStorageVirtualMachine#filter</a> Accepts: aws.IResolvable | aws.DataAwsFsxOntapStorageVirtualMachine.DataAwsFsxOntapStorageVirtualMachineFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsFsxOntapStorageVirtualMachineState, value: HashiCorp.Cdktf.IResolvable) : DataAwsFsxOntapStorageVirtualMachineState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsFsxOntapStorageVirtualMachineState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_ontap_storage_virtual_machine#id-1">DataAwsFsxOntapStorageVirtualMachine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsFsxOntapStorageVirtualMachineState, value: string) : DataAwsFsxOntapStorageVirtualMachineState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsFsxOntapStorageVirtualMachineState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_ontap_storage_virtual_machine#tags-1">DataAwsFsxOntapStorageVirtualMachine#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsFsxOntapStorageVirtualMachineState, value: seq<string * string>) : DataAwsFsxOntapStorageVirtualMachineState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsFsxOntapStorageVirtualMachineState

        member _.Run(state: DataAwsFsxOntapStorageVirtualMachineState) : aws.DataAwsFsxOntapStorageVirtualMachine.DataAwsFsxOntapStorageVirtualMachine =
            let config = aws.DataAwsFsxOntapStorageVirtualMachine.DataAwsFsxOntapStorageVirtualMachineConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsFsxOntapStorageVirtualMachine.DataAwsFsxOntapStorageVirtualMachine(StackContext.get (), logicalId, config)
