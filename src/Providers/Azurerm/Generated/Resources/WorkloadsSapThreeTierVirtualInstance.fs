namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration> = { assignments: ResizeArray<azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance">azurerm_workloads_sap_three_tier_virtual_instance</a>.
    /// </summary>
    type WorkloadsSapThreeTierVirtualInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : WorkloadsSapThreeTierVirtualInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WorkloadsSapThreeTierVirtualInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : WorkloadsSapThreeTierVirtualInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WorkloadsSapThreeTierVirtualInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#app_location-1">WorkloadsSapThreeTierVirtualInstance#app_location</a>.
        /// </summary>
        [<CustomOperation "app_location">]
        member _.AppLocation(state: WorkloadsSapThreeTierVirtualInstanceState<Missing, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>, value: string) : WorkloadsSapThreeTierVirtualInstanceState<Present, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration> =
            state.assignments.Add(fun config -> config.AppLocation <- value)
            ({ assignments = state.assignments } : WorkloadsSapThreeTierVirtualInstanceState<Present, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#environment-1">WorkloadsSapThreeTierVirtualInstance#environment</a>.
        /// </summary>
        [<CustomOperation "environment">]
        member _.Environment(state: WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, Missing, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>, value: string) : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, Present, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration> =
            state.assignments.Add(fun config -> config.Environment <- value)
            ({ assignments = state.assignments } : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, Present, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#location-1">WorkloadsSapThreeTierVirtualInstance#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, Missing, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>, value: string) : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, Present, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, Present, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#name-1">WorkloadsSapThreeTierVirtualInstance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, Missing, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>, value: string) : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, Present, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, Present, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#resource_group_name-1">WorkloadsSapThreeTierVirtualInstance#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, Missing, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>, value: string) : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, Present, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, Present, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#sap_fqdn-1">WorkloadsSapThreeTierVirtualInstance#sap_fqdn</a>.
        /// </summary>
        [<CustomOperation "sap_fqdn">]
        member _.SapFqdn(state: WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, Missing, 'SapProduct, 'ThreeTierConfiguration>, value: string) : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, Present, 'SapProduct, 'ThreeTierConfiguration> =
            state.assignments.Add(fun config -> config.SapFqdn <- value)
            ({ assignments = state.assignments } : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, Present, 'SapProduct, 'ThreeTierConfiguration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#sap_product-1">WorkloadsSapThreeTierVirtualInstance#sap_product</a>.
        /// </summary>
        [<CustomOperation "sap_product">]
        member _.SapProduct(state: WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, Missing, 'ThreeTierConfiguration>, value: string) : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, Present, 'ThreeTierConfiguration> =
            state.assignments.Add(fun config -> config.SapProduct <- value)
            ({ assignments = state.assignments } : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, Present, 'ThreeTierConfiguration>)

        /// <summary>
        /// three_tier_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#three_tier_configuration-1">WorkloadsSapThreeTierVirtualInstance#three_tier_configuration</a>
        /// </summary>
        [<CustomOperation "three_tier_configuration">]
        member _.ThreeTierConfiguration(state: WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, Missing>, value: azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfiguration) : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, Present> =
            state.assignments.Add(fun config -> config.ThreeTierConfiguration <- value)
            ({ assignments = state.assignments } : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#id-1">WorkloadsSapThreeTierVirtualInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>, value: string) : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#identity-1">WorkloadsSapThreeTierVirtualInstance#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>, value: azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceIdentity) : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#managed_resource_group_name-1">WorkloadsSapThreeTierVirtualInstance#managed_resource_group_name</a>.
        /// </summary>
        [<CustomOperation "managed_resource_group_name">]
        member _.ManagedResourceGroupName(state: WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>, value: string) : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration> =
            state.assignments.Add(fun config -> config.ManagedResourceGroupName <- value)
            state : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#tags-1">WorkloadsSapThreeTierVirtualInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>, value: seq<string * string>) : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#timeouts-1">WorkloadsSapThreeTierVirtualInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>, value: azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceTimeouts) : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WorkloadsSapThreeTierVirtualInstanceState<'AppLocation, 'Environment, 'Location, 'Name, 'ResourceGroupName, 'SapFqdn, 'SapProduct, 'ThreeTierConfiguration>

        member _.Run(state: WorkloadsSapThreeTierVirtualInstanceState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstance =
            let config = azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceConfig()
            for setter in state.assignments do
                setter config
            azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.workloadsSapThreeTierVirtualInstance: missing required arguments. Must call: app_location, environment, location, name, resource_group_name, sap_fqdn, sap_product, three_tier_configuration.", 9999, IsError = true)>]
        member _.Run(_: WorkloadsSapThreeTierVirtualInstanceState<_, _, _, _, _, _, _, _>) : azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstance =
            Unchecked.defaultof<azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstance>
