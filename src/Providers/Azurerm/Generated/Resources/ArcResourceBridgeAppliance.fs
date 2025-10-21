namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ArcResourceBridgeAppliance.ArcResourceBridgeApplianceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_resource_bridge_appliance">azurerm_arc_resource_bridge_appliance</a>.
    /// </summary>
    type ArcResourceBridgeApplianceBuilder(logicalId: string) =
        member _.Yield(_: unit) : ArcResourceBridgeApplianceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ArcResourceBridgeApplianceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ArcResourceBridgeApplianceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ArcResourceBridgeApplianceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_resource_bridge_appliance#distro-1">ArcResourceBridgeAppliance#distro</a>.
        /// </summary>
        [<CustomOperation "distro">]
        member _.Distro(state: ArcResourceBridgeApplianceState<Missing, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName>, value: string) : ArcResourceBridgeApplianceState<Present, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Distro <- value)
            ({ assignments = state.assignments } : ArcResourceBridgeApplianceState<Present, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_resource_bridge_appliance#identity-1">ArcResourceBridgeAppliance#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ArcResourceBridgeApplianceState<'Distro, Missing, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.ArcResourceBridgeAppliance.ArcResourceBridgeApplianceIdentity) : ArcResourceBridgeApplianceState<'Distro, Present, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            ({ assignments = state.assignments } : ArcResourceBridgeApplianceState<'Distro, Present, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_resource_bridge_appliance#infrastructure_provider-1">ArcResourceBridgeAppliance#infrastructure_provider</a>.
        /// </summary>
        [<CustomOperation "infrastructure_provider">]
        member _.InfrastructureProvider(state: ArcResourceBridgeApplianceState<'Distro, 'Identity, Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : ArcResourceBridgeApplianceState<'Distro, 'Identity, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InfrastructureProvider <- value)
            ({ assignments = state.assignments } : ArcResourceBridgeApplianceState<'Distro, 'Identity, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_resource_bridge_appliance#location-1">ArcResourceBridgeAppliance#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, Missing, 'Name, 'ResourceGroupName>, value: string) : ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_resource_bridge_appliance#name-1">ArcResourceBridgeAppliance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, Missing, 'ResourceGroupName>, value: string) : ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_resource_bridge_appliance#resource_group_name-1">ArcResourceBridgeAppliance#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, Missing>, value: string) : ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_resource_bridge_appliance#id-1">ArcResourceBridgeAppliance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName>, value: string) : ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_resource_bridge_appliance#public_key_base64-1">ArcResourceBridgeAppliance#public_key_base64</a>.
        /// </summary>
        [<CustomOperation "public_key_base64">]
        member _.PublicKeyBase64(state: ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName>, value: string) : ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicKeyBase64 <- value)
            state : ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_resource_bridge_appliance#tags-1">ArcResourceBridgeAppliance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_resource_bridge_appliance#timeouts-1">ArcResourceBridgeAppliance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.ArcResourceBridgeAppliance.ArcResourceBridgeApplianceTimeouts) : ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ArcResourceBridgeApplianceState<'Distro, 'Identity, 'InfrastructureProvider, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: ArcResourceBridgeApplianceState<Present, Present, Present, Present, Present, Present>) : azurerm.ArcResourceBridgeAppliance.ArcResourceBridgeAppliance =
            let config = azurerm.ArcResourceBridgeAppliance.ArcResourceBridgeApplianceConfig()
            for setter in state.assignments do
                setter config
            azurerm.ArcResourceBridgeAppliance.ArcResourceBridgeAppliance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.arcResourceBridgeAppliance: missing required arguments. Must call: distro, identity, infrastructure_provider, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ArcResourceBridgeApplianceState<_, _, _, _, _, _>) : azurerm.ArcResourceBridgeAppliance.ArcResourceBridgeAppliance =
            Unchecked.defaultof<azurerm.ArcResourceBridgeAppliance.ArcResourceBridgeAppliance>
