namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct> = { assignments: ResizeArray<azurerm.WorkloadsSapDiscoveryVirtualInstance.WorkloadsSapDiscoveryVirtualInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_discovery_virtual_instance">azurerm_workloads_sap_discovery_virtual_instance</a>.
    /// </summary>
    type WorkloadsSapDiscoveryVirtualInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : WorkloadsSapDiscoveryVirtualInstanceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WorkloadsSapDiscoveryVirtualInstanceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : WorkloadsSapDiscoveryVirtualInstanceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WorkloadsSapDiscoveryVirtualInstanceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_discovery_virtual_instance#central_server_virtual_machine_id-1">WorkloadsSapDiscoveryVirtualInstance#central_server_virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "central_server_virtual_machine_id">]
        member _.CentralServerVirtualMachineId(state: WorkloadsSapDiscoveryVirtualInstanceState<Missing, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>, value: string) : WorkloadsSapDiscoveryVirtualInstanceState<Present, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct> =
            state.assignments.Add(fun config -> config.CentralServerVirtualMachineId <- value)
            ({ assignments = state.assignments } : WorkloadsSapDiscoveryVirtualInstanceState<Present, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_discovery_virtual_instance#environment-1">WorkloadsSapDiscoveryVirtualInstance#environment</a>.
        /// </summary>
        [<CustomOperation "environment">]
        member _.Environment(state: WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, Missing, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>, value: string) : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, Present, 'Location, 'Name, 'ResourceGroupName, 'SapProduct> =
            state.assignments.Add(fun config -> config.Environment <- value)
            ({ assignments = state.assignments } : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, Present, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_discovery_virtual_instance#location-1">WorkloadsSapDiscoveryVirtualInstance#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, Missing, 'Name, 'ResourceGroupName, 'SapProduct>, value: string) : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, Present, 'Name, 'ResourceGroupName, 'SapProduct> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, Present, 'Name, 'ResourceGroupName, 'SapProduct>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_discovery_virtual_instance#name-1">WorkloadsSapDiscoveryVirtualInstance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, Missing, 'ResourceGroupName, 'SapProduct>, value: string) : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, Present, 'ResourceGroupName, 'SapProduct> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, Present, 'ResourceGroupName, 'SapProduct>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_discovery_virtual_instance#resource_group_name-1">WorkloadsSapDiscoveryVirtualInstance#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, Missing, 'SapProduct>, value: string) : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, Present, 'SapProduct> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, Present, 'SapProduct>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_discovery_virtual_instance#sap_product-1">WorkloadsSapDiscoveryVirtualInstance#sap_product</a>.
        /// </summary>
        [<CustomOperation "sap_product">]
        member _.SapProduct(state: WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SapProduct <- value)
            ({ assignments = state.assignments } : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_discovery_virtual_instance#id-1">WorkloadsSapDiscoveryVirtualInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>, value: string) : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_discovery_virtual_instance#identity-1">WorkloadsSapDiscoveryVirtualInstance#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>, value: azurerm.WorkloadsSapDiscoveryVirtualInstance.WorkloadsSapDiscoveryVirtualInstanceIdentity) : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_discovery_virtual_instance#managed_resource_group_name-1">WorkloadsSapDiscoveryVirtualInstance#managed_resource_group_name</a>.
        /// </summary>
        [<CustomOperation "managed_resource_group_name">]
        member _.ManagedResourceGroupName(state: WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>, value: string) : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct> =
            state.assignments.Add(fun config -> config.ManagedResourceGroupName <- value)
            state : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_discovery_virtual_instance#managed_storage_account_name-1">WorkloadsSapDiscoveryVirtualInstance#managed_storage_account_name</a>.
        /// </summary>
        [<CustomOperation "managed_storage_account_name">]
        member _.ManagedStorageAccountName(state: WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>, value: string) : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct> =
            state.assignments.Add(fun config -> config.ManagedStorageAccountName <- value)
            state : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_discovery_virtual_instance#tags-1">WorkloadsSapDiscoveryVirtualInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>, value: seq<string * string>) : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_discovery_virtual_instance#timeouts-1">WorkloadsSapDiscoveryVirtualInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>, value: azurerm.WorkloadsSapDiscoveryVirtualInstance.WorkloadsSapDiscoveryVirtualInstanceTimeouts) : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WorkloadsSapDiscoveryVirtualInstanceState<'CentralServerVirtualMachineId, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapProduct>

        member _.Run(state: WorkloadsSapDiscoveryVirtualInstanceState<Present, Present, Present, Present, Present, Present>) : azurerm.WorkloadsSapDiscoveryVirtualInstance.WorkloadsSapDiscoveryVirtualInstance =
            let config = azurerm.WorkloadsSapDiscoveryVirtualInstance.WorkloadsSapDiscoveryVirtualInstanceConfig()
            for setter in state.assignments do
                setter config
            azurerm.WorkloadsSapDiscoveryVirtualInstance.WorkloadsSapDiscoveryVirtualInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.workloadsSapDiscoveryVirtualInstance: missing required arguments. Must call: central_server_virtual_machine_id, environment, location, name, resource_group_name, sap_product.", 9999, IsError = true)>]
        member _.Run(_: WorkloadsSapDiscoveryVirtualInstanceState<_, _, _, _, _, _>) : azurerm.WorkloadsSapDiscoveryVirtualInstance.WorkloadsSapDiscoveryVirtualInstance =
            Unchecked.defaultof<azurerm.WorkloadsSapDiscoveryVirtualInstance.WorkloadsSapDiscoveryVirtualInstance>
