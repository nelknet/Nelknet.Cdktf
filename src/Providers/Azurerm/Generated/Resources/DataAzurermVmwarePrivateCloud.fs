namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermVmwarePrivateCloudState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/vmware_private_cloud">azurerm_vmware_private_cloud</a>.
    /// </summary>
    type DataAzurermVmwarePrivateCloudBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermVmwarePrivateCloudState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVmwarePrivateCloudState<Missing, Missing>)

        member _.Zero(()) : DataAzurermVmwarePrivateCloudState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVmwarePrivateCloudState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/vmware_private_cloud#name-1">DataAzurermVmwarePrivateCloud#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermVmwarePrivateCloudState<Missing, 'ResourceGroupName>, value: string) : DataAzurermVmwarePrivateCloudState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermVmwarePrivateCloudState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/vmware_private_cloud#resource_group_name-1">DataAzurermVmwarePrivateCloud#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermVmwarePrivateCloudState<'Name, Missing>, value: string) : DataAzurermVmwarePrivateCloudState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermVmwarePrivateCloudState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/vmware_private_cloud#id-1">DataAzurermVmwarePrivateCloud#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermVmwarePrivateCloudState<'Name, 'ResourceGroupName>, value: string) : DataAzurermVmwarePrivateCloudState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermVmwarePrivateCloudState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/vmware_private_cloud#timeouts-1">DataAzurermVmwarePrivateCloud#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermVmwarePrivateCloudState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudTimeouts) : DataAzurermVmwarePrivateCloudState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermVmwarePrivateCloudState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermVmwarePrivateCloudState<Present, Present>) : azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloud =
            let config = azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloudConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloud(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermVmwarePrivateCloud: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermVmwarePrivateCloudState<_, _>) : azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloud =
            Unchecked.defaultof<azurerm.DataAzurermVmwarePrivateCloud.DataAzurermVmwarePrivateCloud>
