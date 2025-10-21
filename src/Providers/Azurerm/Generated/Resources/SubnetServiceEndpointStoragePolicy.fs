namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SubnetServiceEndpointStoragePolicyState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.SubnetServiceEndpointStoragePolicy.SubnetServiceEndpointStoragePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_service_endpoint_storage_policy">azurerm_subnet_service_endpoint_storage_policy</a>.
    /// </summary>
    type SubnetServiceEndpointStoragePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SubnetServiceEndpointStoragePolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SubnetServiceEndpointStoragePolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : SubnetServiceEndpointStoragePolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SubnetServiceEndpointStoragePolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_service_endpoint_storage_policy#location-1">SubnetServiceEndpointStoragePolicy#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SubnetServiceEndpointStoragePolicyState<Missing, 'Name, 'ResourceGroupName>, value: string) : SubnetServiceEndpointStoragePolicyState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SubnetServiceEndpointStoragePolicyState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_service_endpoint_storage_policy#name-1">SubnetServiceEndpointStoragePolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SubnetServiceEndpointStoragePolicyState<'Location, Missing, 'ResourceGroupName>, value: string) : SubnetServiceEndpointStoragePolicyState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SubnetServiceEndpointStoragePolicyState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_service_endpoint_storage_policy#resource_group_name-1">SubnetServiceEndpointStoragePolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SubnetServiceEndpointStoragePolicyState<'Location, 'Name, Missing>, value: string) : SubnetServiceEndpointStoragePolicyState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SubnetServiceEndpointStoragePolicyState<'Location, 'Name, Present>)

        /// <summary>
        /// definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_service_endpoint_storage_policy#definition-1">SubnetServiceEndpointStoragePolicy#definition</a> Accepts: azurerm.IResolvable | azurerm.SubnetServiceEndpointStoragePolicy.SubnetServiceEndpointStoragePolicyDefinition[]
        /// </summary>
        [<CustomOperation "definition">]
        member _.Definition(state: SubnetServiceEndpointStoragePolicyState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : SubnetServiceEndpointStoragePolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Definition <- value)
            state : SubnetServiceEndpointStoragePolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_service_endpoint_storage_policy#id-1">SubnetServiceEndpointStoragePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SubnetServiceEndpointStoragePolicyState<'Location, 'Name, 'ResourceGroupName>, value: string) : SubnetServiceEndpointStoragePolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SubnetServiceEndpointStoragePolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_service_endpoint_storage_policy#tags-1">SubnetServiceEndpointStoragePolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SubnetServiceEndpointStoragePolicyState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : SubnetServiceEndpointStoragePolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SubnetServiceEndpointStoragePolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_service_endpoint_storage_policy#timeouts-1">SubnetServiceEndpointStoragePolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SubnetServiceEndpointStoragePolicyState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.SubnetServiceEndpointStoragePolicy.SubnetServiceEndpointStoragePolicyTimeouts) : SubnetServiceEndpointStoragePolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SubnetServiceEndpointStoragePolicyState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: SubnetServiceEndpointStoragePolicyState<Present, Present, Present>) : azurerm.SubnetServiceEndpointStoragePolicy.SubnetServiceEndpointStoragePolicy =
            let config = azurerm.SubnetServiceEndpointStoragePolicy.SubnetServiceEndpointStoragePolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.SubnetServiceEndpointStoragePolicy.SubnetServiceEndpointStoragePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.subnetServiceEndpointStoragePolicy: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: SubnetServiceEndpointStoragePolicyState<_, _, _>) : azurerm.SubnetServiceEndpointStoragePolicy.SubnetServiceEndpointStoragePolicy =
            Unchecked.defaultof<azurerm.SubnetServiceEndpointStoragePolicy.SubnetServiceEndpointStoragePolicy>
