namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.DedicatedHardwareSecurityModule.DedicatedHardwareSecurityModuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module">azurerm_dedicated_hardware_security_module</a>.
    /// </summary>
    type DedicatedHardwareSecurityModuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DedicatedHardwareSecurityModuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DedicatedHardwareSecurityModuleState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DedicatedHardwareSecurityModuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DedicatedHardwareSecurityModuleState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#location-1">DedicatedHardwareSecurityModule#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DedicatedHardwareSecurityModuleState<Missing, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName>, value: string) : DedicatedHardwareSecurityModuleState<Present, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DedicatedHardwareSecurityModuleState<Present, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#name-1">DedicatedHardwareSecurityModule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DedicatedHardwareSecurityModuleState<'Location, Missing, 'NetworkProfile, 'ResourceGroupName, 'SkuName>, value: string) : DedicatedHardwareSecurityModuleState<'Location, Present, 'NetworkProfile, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DedicatedHardwareSecurityModuleState<'Location, Present, 'NetworkProfile, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// network_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#network_profile-1">DedicatedHardwareSecurityModule#network_profile</a>
        /// </summary>
        [<CustomOperation "network_profile">]
        member _.NetworkProfile(state: DedicatedHardwareSecurityModuleState<'Location, 'Name, Missing, 'ResourceGroupName, 'SkuName>, value: azurerm.DedicatedHardwareSecurityModule.DedicatedHardwareSecurityModuleNetworkProfile) : DedicatedHardwareSecurityModuleState<'Location, 'Name, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.NetworkProfile <- value)
            ({ assignments = state.assignments } : DedicatedHardwareSecurityModuleState<'Location, 'Name, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#resource_group_name-1">DedicatedHardwareSecurityModule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, Missing, 'SkuName>, value: string) : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#sku_name-1">DedicatedHardwareSecurityModule#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, Missing>, value: string) : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#id-1">DedicatedHardwareSecurityModule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName>, value: string) : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// management_network_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#management_network_profile-1">DedicatedHardwareSecurityModule#management_network_profile</a>
        /// </summary>
        [<CustomOperation "management_network_profile">]
        member _.ManagementNetworkProfile(state: DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName>, value: azurerm.DedicatedHardwareSecurityModule.DedicatedHardwareSecurityModuleManagementNetworkProfile) : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.ManagementNetworkProfile <- value)
            state : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#stamp_id-1">DedicatedHardwareSecurityModule#stamp_id</a>.
        /// </summary>
        [<CustomOperation "stamp_id">]
        member _.StampId(state: DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName>, value: string) : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.StampId <- value)
            state : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#tags-1">DedicatedHardwareSecurityModule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#timeouts-1">DedicatedHardwareSecurityModule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName>, value: azurerm.DedicatedHardwareSecurityModule.DedicatedHardwareSecurityModuleTimeouts) : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#zones-1">DedicatedHardwareSecurityModule#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName>, value: seq<string>) : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : DedicatedHardwareSecurityModuleState<'Location, 'Name, 'NetworkProfile, 'ResourceGroupName, 'SkuName>

        member _.Run(state: DedicatedHardwareSecurityModuleState<Present, Present, Present, Present, Present>) : azurerm.DedicatedHardwareSecurityModule.DedicatedHardwareSecurityModule =
            let config = azurerm.DedicatedHardwareSecurityModule.DedicatedHardwareSecurityModuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DedicatedHardwareSecurityModule.DedicatedHardwareSecurityModule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dedicatedHardwareSecurityModule: missing required arguments. Must call: location, name, network_profile, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: DedicatedHardwareSecurityModuleState<_, _, _, _, _>) : azurerm.DedicatedHardwareSecurityModule.DedicatedHardwareSecurityModule =
            Unchecked.defaultof<azurerm.DedicatedHardwareSecurityModule.DedicatedHardwareSecurityModule>
