namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermManagedDiskState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermManagedDisk.DataAzurermManagedDiskConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_disk">azurerm_managed_disk</a>.
    /// </summary>
    type DataAzurermManagedDiskBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermManagedDiskState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermManagedDiskState<Missing, Missing>)

        member _.Zero(()) : DataAzurermManagedDiskState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermManagedDiskState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_disk#name-1">DataAzurermManagedDisk#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermManagedDiskState<Missing, 'ResourceGroupName>, value: string) : DataAzurermManagedDiskState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermManagedDiskState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_disk#resource_group_name-1">DataAzurermManagedDisk#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermManagedDiskState<'Name, Missing>, value: string) : DataAzurermManagedDiskState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermManagedDiskState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_disk#id-1">DataAzurermManagedDisk#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermManagedDiskState<'Name, 'ResourceGroupName>, value: string) : DataAzurermManagedDiskState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermManagedDiskState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_disk#timeouts-1">DataAzurermManagedDisk#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermManagedDiskState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermManagedDisk.DataAzurermManagedDiskTimeouts) : DataAzurermManagedDiskState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermManagedDiskState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermManagedDiskState<Present, Present>) : azurerm.DataAzurermManagedDisk.DataAzurermManagedDisk =
            let config = azurerm.DataAzurermManagedDisk.DataAzurermManagedDiskConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermManagedDisk.DataAzurermManagedDisk(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermManagedDisk: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermManagedDiskState<_, _>) : azurerm.DataAzurermManagedDisk.DataAzurermManagedDisk =
            Unchecked.defaultof<azurerm.DataAzurermManagedDisk.DataAzurermManagedDisk>
