namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.OrbitalContactProfile.OrbitalContactProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile">azurerm_orbital_contact_profile</a>.
    /// </summary>
    type OrbitalContactProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : OrbitalContactProfileState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OrbitalContactProfileState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : OrbitalContactProfileState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OrbitalContactProfileState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#auto_tracking-1">OrbitalContactProfile#auto_tracking</a>.
        /// </summary>
        [<CustomOperation "auto_tracking">]
        member _.AutoTracking(state: OrbitalContactProfileState<Missing, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>, value: string) : OrbitalContactProfileState<Present, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoTracking <- value)
            ({ assignments = state.assignments } : OrbitalContactProfileState<Present, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>)

        /// <summary>
        /// links block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#links-1">OrbitalContactProfile#links</a> Accepts: azurerm.IResolvable | azurerm.OrbitalContactProfile.OrbitalContactProfileLinks[]
        /// </summary>
        [<CustomOperation "links">]
        member _.Links(state: OrbitalContactProfileState<'AutoTracking, Missing, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : OrbitalContactProfileState<'AutoTracking, Present, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Links <- value)
            ({ assignments = state.assignments } : OrbitalContactProfileState<'AutoTracking, Present, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#location-1">OrbitalContactProfile#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: OrbitalContactProfileState<'AutoTracking, 'Links, Missing, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>, value: string) : OrbitalContactProfileState<'AutoTracking, 'Links, Present, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : OrbitalContactProfileState<'AutoTracking, 'Links, Present, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#minimum_variable_contact_duration-1">OrbitalContactProfile#minimum_variable_contact_duration</a>.
        /// </summary>
        [<CustomOperation "minimum_variable_contact_duration">]
        member _.MinimumVariableContactDuration(state: OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, Missing, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>, value: string) : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, Present, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MinimumVariableContactDuration <- value)
            ({ assignments = state.assignments } : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, Present, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#name-1">OrbitalContactProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, Missing, 'NetworkConfigurationSubnetId, 'ResourceGroupName>, value: string) : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, Present, 'NetworkConfigurationSubnetId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, Present, 'NetworkConfigurationSubnetId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#network_configuration_subnet_id-1">OrbitalContactProfile#network_configuration_subnet_id</a>.
        /// </summary>
        [<CustomOperation "network_configuration_subnet_id">]
        member _.NetworkConfigurationSubnetId(state: OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, Missing, 'ResourceGroupName>, value: string) : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NetworkConfigurationSubnetId <- value)
            ({ assignments = state.assignments } : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#resource_group_name-1">OrbitalContactProfile#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, Missing>, value: string) : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#event_hub_uri-1">OrbitalContactProfile#event_hub_uri</a>.
        /// </summary>
        [<CustomOperation "event_hub_uri">]
        member _.EventHubUri(state: OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>, value: string) : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EventHubUri <- value)
            state : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#id-1">OrbitalContactProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>, value: string) : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#minimum_elevation_degrees-1">OrbitalContactProfile#minimum_elevation_degrees</a>.
        /// </summary>
        [<CustomOperation "minimum_elevation_degrees">]
        member _.MinimumElevationDegrees(state: OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>, value: double) : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MinimumElevationDegrees <- value)
            state : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#tags-1">OrbitalContactProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>, value: seq<string * string>) : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#timeouts-1">OrbitalContactProfile#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>, value: azurerm.OrbitalContactProfile.OrbitalContactProfileTimeouts) : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OrbitalContactProfileState<'AutoTracking, 'Links, 'Location, 'MinimumVariableContactDuration, 'Name, 'NetworkConfigurationSubnetId, 'ResourceGroupName>

        member _.Run(state: OrbitalContactProfileState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.OrbitalContactProfile.OrbitalContactProfile =
            let config = azurerm.OrbitalContactProfile.OrbitalContactProfileConfig()
            for setter in state.assignments do
                setter config
            azurerm.OrbitalContactProfile.OrbitalContactProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.orbitalContactProfile: missing required arguments. Must call: auto_tracking, links, location, minimum_variable_contact_duration, name, network_configuration_subnet_id, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: OrbitalContactProfileState<_, _, _, _, _, _, _>) : azurerm.OrbitalContactProfile.OrbitalContactProfile =
            Unchecked.defaultof<azurerm.OrbitalContactProfile.OrbitalContactProfile>
