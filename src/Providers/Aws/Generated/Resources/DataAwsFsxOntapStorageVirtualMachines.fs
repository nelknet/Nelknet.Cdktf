namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsFsxOntapStorageVirtualMachinesState = { assignments: ResizeArray<aws.DataAwsFsxOntapStorageVirtualMachines.DataAwsFsxOntapStorageVirtualMachinesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_ontap_storage_virtual_machines">aws_fsx_ontap_storage_virtual_machines</a>.
    /// </summary>
    type DataAwsFsxOntapStorageVirtualMachinesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsFsxOntapStorageVirtualMachinesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsFsxOntapStorageVirtualMachinesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_ontap_storage_virtual_machines#filter-1">DataAwsFsxOntapStorageVirtualMachines#filter</a> Accepts: aws.IResolvable | aws.DataAwsFsxOntapStorageVirtualMachines.DataAwsFsxOntapStorageVirtualMachinesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsFsxOntapStorageVirtualMachinesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsFsxOntapStorageVirtualMachinesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsFsxOntapStorageVirtualMachinesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_ontap_storage_virtual_machines#id-1">DataAwsFsxOntapStorageVirtualMachines#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsFsxOntapStorageVirtualMachinesState, value: string) : DataAwsFsxOntapStorageVirtualMachinesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsFsxOntapStorageVirtualMachinesState

        member _.Run(state: DataAwsFsxOntapStorageVirtualMachinesState) : aws.DataAwsFsxOntapStorageVirtualMachines.DataAwsFsxOntapStorageVirtualMachines =
            let config = aws.DataAwsFsxOntapStorageVirtualMachines.DataAwsFsxOntapStorageVirtualMachinesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsFsxOntapStorageVirtualMachines.DataAwsFsxOntapStorageVirtualMachines(StackContext.get (), logicalId, config)
