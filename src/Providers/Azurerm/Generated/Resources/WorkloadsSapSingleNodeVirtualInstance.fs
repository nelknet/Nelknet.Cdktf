namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration> = { assignments: ResizeArray<azurerm.WorkloadsSapSingleNodeVirtualInstance.WorkloadsSapSingleNodeVirtualInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance">azurerm_workloads_sap_single_node_virtual_instance</a>.
    /// </summary>
    type WorkloadsSapSingleNodeVirtualInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : WorkloadsSapSingleNodeVirtualInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WorkloadsSapSingleNodeVirtualInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : WorkloadsSapSingleNodeVirtualInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WorkloadsSapSingleNodeVirtualInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#app_location-1">WorkloadsSapSingleNodeVirtualInstance#app_location</a>.
        /// </summary>
        [<CustomOperation "app_location">]
        member _.AppLocation(state: WorkloadsSapSingleNodeVirtualInstanceState<Missing, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>, value: string) : WorkloadsSapSingleNodeVirtualInstanceState<Present, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration> =
            state.assignments.Add(fun config -> config.AppLocation <- value)
            ({ assignments = state.assignments } : WorkloadsSapSingleNodeVirtualInstanceState<Present, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#environment-1">WorkloadsSapSingleNodeVirtualInstance#environment</a>.
        /// </summary>
        [<CustomOperation "environment">]
        member _.Environment(state: WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, Missing, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>, value: string) : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, Present, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration> =
            state.assignments.Add(fun config -> config.Environment <- value)
            ({ assignments = state.assignments } : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, Present, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#location-1">WorkloadsSapSingleNodeVirtualInstance#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, Missing, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>, value: string) : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, Present, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, Present, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#name-1">WorkloadsSapSingleNodeVirtualInstance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, Missing, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>, value: string) : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, Present, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, Present, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#resource_group_name-1">WorkloadsSapSingleNodeVirtualInstance#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, Missing, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>, value: string) : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, Present, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, Present, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#sap_fqdn-1">WorkloadsSapSingleNodeVirtualInstance#sap_fqdn</a>.
        /// </summary>
        [<CustomOperation "sap_fqdn">]
        member _.SapFqdn(state: WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, Missing, 'SapProduct, 'SingleServerConfiguration>, value: string) : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, Present, 'SapProduct, 'SingleServerConfiguration> =
            state.assignments.Add(fun config -> config.SapFqdn <- value)
            ({ assignments = state.assignments } : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, Present, 'SapProduct, 'SingleServerConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#sap_product-1">WorkloadsSapSingleNodeVirtualInstance#sap_product</a>.
        /// </summary>
        [<CustomOperation "sap_product">]
        member _.SapProduct(state: WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, Missing, 'SingleServerConfiguration>, value: string) : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, Present, 'SingleServerConfiguration> =
            state.assignments.Add(fun config -> config.SapProduct <- value)
            ({ assignments = state.assignments } : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, Present, 'SingleServerConfiguration>)

        /// <summary>
        /// single_server_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#single_server_configuration-1">WorkloadsSapSingleNodeVirtualInstance#single_server_configuration</a>
        /// </summary>
        [<CustomOperation "single_server_configuration">]
        member _.SingleServerConfiguration(state: WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, Missing>, value: azurerm.WorkloadsSapSingleNodeVirtualInstance.WorkloadsSapSingleNodeVirtualInstanceSingleServerConfiguration) : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, Present> =
            state.assignments.Add(fun config -> config.SingleServerConfiguration <- value)
            ({ assignments = state.assignments } : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#id-1">WorkloadsSapSingleNodeVirtualInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>, value: string) : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#identity-1">WorkloadsSapSingleNodeVirtualInstance#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>, value: azurerm.WorkloadsSapSingleNodeVirtualInstance.WorkloadsSapSingleNodeVirtualInstanceIdentity) : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#managed_resource_group_name-1">WorkloadsSapSingleNodeVirtualInstance#managed_resource_group_name</a>.
        /// </summary>
        [<CustomOperation "managed_resource_group_name">]
        member _.ManagedResourceGroupName(state: WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>, value: string) : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration> =
            state.assignments.Add(fun config -> config.ManagedResourceGroupName <- value)
            state : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#tags-1">WorkloadsSapSingleNodeVirtualInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>, value: seq<string * string>) : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#timeouts-1">WorkloadsSapSingleNodeVirtualInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>, value: azurerm.WorkloadsSapSingleNodeVirtualInstance.WorkloadsSapSingleNodeVirtualInstanceTimeouts) : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WorkloadsSapSingleNodeVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'SingleServerConfiguration>

        member _.Run(state: WorkloadsSapSingleNodeVirtualInstanceState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.WorkloadsSapSingleNodeVirtualInstance.WorkloadsSapSingleNodeVirtualInstance =
            let config = azurerm.WorkloadsSapSingleNodeVirtualInstance.WorkloadsSapSingleNodeVirtualInstanceConfig()
            for setter in state.assignments do
                setter config
            azurerm.WorkloadsSapSingleNodeVirtualInstance.WorkloadsSapSingleNodeVirtualInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.workloadsSapSingleNodeVirtualInstance: missing required arguments. Must call: app_location, environment, location, name, resource_group_name, sap_fqdn, sap_product, single_server_configuration.", 9999, IsError = true)>]
        member _.Run(_: WorkloadsSapSingleNodeVirtualInstanceState<_, _, _, _, _, _, _, _>) : azurerm.WorkloadsSapSingleNodeVirtualInstance.WorkloadsSapSingleNodeVirtualInstance =
            Unchecked.defaultof<azurerm.WorkloadsSapSingleNodeVirtualInstance.WorkloadsSapSingleNodeVirtualInstance>
