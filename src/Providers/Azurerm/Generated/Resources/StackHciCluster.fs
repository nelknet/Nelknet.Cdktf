namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StackHciClusterState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.StackHciCluster.StackHciClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_cluster">azurerm_stack_hci_cluster</a>.
    /// </summary>
    type StackHciClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : StackHciClusterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StackHciClusterState<Missing, Missing, Missing>)

        member _.Zero(()) : StackHciClusterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StackHciClusterState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_cluster#location-1">StackHciCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: StackHciClusterState<Missing, 'Name, 'ResourceGroupName>, value: string) : StackHciClusterState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : StackHciClusterState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_cluster#name-1">StackHciCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StackHciClusterState<'Location, Missing, 'ResourceGroupName>, value: string) : StackHciClusterState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StackHciClusterState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_cluster#resource_group_name-1">StackHciCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StackHciClusterState<'Location, 'Name, Missing>, value: string) : StackHciClusterState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StackHciClusterState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_cluster#automanage_configuration_id-1">StackHciCluster#automanage_configuration_id</a>.
        /// </summary>
        [<CustomOperation "automanage_configuration_id">]
        member _.AutomanageConfigurationId(state: StackHciClusterState<'Location, 'Name, 'ResourceGroupName>, value: string) : StackHciClusterState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomanageConfigurationId <- value)
            state : StackHciClusterState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_cluster#client_id-1">StackHciCluster#client_id</a>.
        /// </summary>
        [<CustomOperation "client_id">]
        member _.ClientId(state: StackHciClusterState<'Location, 'Name, 'ResourceGroupName>, value: string) : StackHciClusterState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientId <- value)
            state : StackHciClusterState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_cluster#id-1">StackHciCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StackHciClusterState<'Location, 'Name, 'ResourceGroupName>, value: string) : StackHciClusterState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StackHciClusterState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_cluster#identity-1">StackHciCluster#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: StackHciClusterState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.StackHciCluster.StackHciClusterIdentity) : StackHciClusterState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : StackHciClusterState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_cluster#tags-1">StackHciCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StackHciClusterState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : StackHciClusterState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StackHciClusterState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_cluster#tenant_id-1">StackHciCluster#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: StackHciClusterState<'Location, 'Name, 'ResourceGroupName>, value: string) : StackHciClusterState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : StackHciClusterState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_cluster#timeouts-1">StackHciCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StackHciClusterState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.StackHciCluster.StackHciClusterTimeouts) : StackHciClusterState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StackHciClusterState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: StackHciClusterState<Present, Present, Present>) : azurerm.StackHciCluster.StackHciCluster =
            let config = azurerm.StackHciCluster.StackHciClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.StackHciCluster.StackHciCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.stackHciCluster: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: StackHciClusterState<_, _, _>) : azurerm.StackHciCluster.StackHciCluster =
            Unchecked.defaultof<azurerm.StackHciCluster.StackHciCluster>
