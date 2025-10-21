namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation> = { assignments: ResizeArray<azurerm.VoiceServicesCommunicationsGateway.VoiceServicesCommunicationsGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway">azurerm_voice_services_communications_gateway</a>.
    /// </summary>
    type VoiceServicesCommunicationsGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : VoiceServicesCommunicationsGatewayState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VoiceServicesCommunicationsGatewayState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VoiceServicesCommunicationsGatewayState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VoiceServicesCommunicationsGatewayState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#codecs-1">VoiceServicesCommunicationsGateway#codecs</a>.
        /// </summary>
        [<CustomOperation "codecs">]
        member _.Codecs(state: VoiceServicesCommunicationsGatewayState<Missing, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>, value: string) : VoiceServicesCommunicationsGatewayState<Present, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.Codecs <- value)
            ({ assignments = state.assignments } : VoiceServicesCommunicationsGatewayState<Present, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#connectivity-1">VoiceServicesCommunicationsGateway#connectivity</a>.
        /// </summary>
        [<CustomOperation "connectivity">]
        member _.Connectivity(state: VoiceServicesCommunicationsGatewayState<'Codecs, Missing, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>, value: string) : VoiceServicesCommunicationsGatewayState<'Codecs, Present, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.Connectivity <- value)
            ({ assignments = state.assignments } : VoiceServicesCommunicationsGatewayState<'Codecs, Present, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#e911_type-1">VoiceServicesCommunicationsGateway#e911_type</a>.
        /// </summary>
        [<CustomOperation "e911_type">]
        member _.E911Type(state: VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, Missing, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>, value: string) : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, Present, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.E911Type <- value)
            ({ assignments = state.assignments } : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, Present, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#location-1">VoiceServicesCommunicationsGateway#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, Missing, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>, value: string) : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, Present, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, Present, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#name-1">VoiceServicesCommunicationsGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, Missing, 'Platforms, 'ResourceGroupName, 'ServiceLocation>, value: string) : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, Present, 'Platforms, 'ResourceGroupName, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, Present, 'Platforms, 'ResourceGroupName, 'ServiceLocation>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#platforms-1">VoiceServicesCommunicationsGateway#platforms</a>.
        /// </summary>
        [<CustomOperation "platforms">]
        member _.Platforms(state: VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, Missing, 'ResourceGroupName, 'ServiceLocation>, value: seq<string>) : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, Present, 'ResourceGroupName, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.Platforms <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, Present, 'ResourceGroupName, 'ServiceLocation>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#resource_group_name-1">VoiceServicesCommunicationsGateway#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, Missing, 'ServiceLocation>, value: string) : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, Present, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, Present, 'ServiceLocation>)

        /// <summary>
        /// service_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#service_location-1">VoiceServicesCommunicationsGateway#service_location</a> Accepts: azurerm.IResolvable | azurerm.VoiceServicesCommunicationsGateway.VoiceServicesCommunicationsGatewayServiceLocation[]
        /// </summary>
        [<CustomOperation "service_location">]
        member _.ServiceLocation(state: VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, Missing>, value: HashiCorp.Cdktf.IResolvable) : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ServiceLocation <- value)
            ({ assignments = state.assignments } : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#api_bridge-1">VoiceServicesCommunicationsGateway#api_bridge</a>.
        /// </summary>
        [<CustomOperation "api_bridge">]
        member _.ApiBridge(state: VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>, value: string) : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.ApiBridge <- value)
            state : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#auto_generated_domain_name_label_scope-1">VoiceServicesCommunicationsGateway#auto_generated_domain_name_label_scope</a>.
        /// </summary>
        [<CustomOperation "auto_generated_domain_name_label_scope">]
        member _.AutoGeneratedDomainNameLabelScope(state: VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>, value: string) : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.AutoGeneratedDomainNameLabelScope <- value)
            state : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#emergency_dial_strings-1">VoiceServicesCommunicationsGateway#emergency_dial_strings</a>.
        /// </summary>
        [<CustomOperation "emergency_dial_strings">]
        member _.EmergencyDialStrings(state: VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>, value: seq<string>) : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.EmergencyDialStrings <- (value |> Seq.toArray))
            state : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#id-1">VoiceServicesCommunicationsGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>, value: string) : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#microsoft_teams_voicemail_pilot_number-1">VoiceServicesCommunicationsGateway#microsoft_teams_voicemail_pilot_number</a>.
        /// </summary>
        [<CustomOperation "microsoft_teams_voicemail_pilot_number">]
        member _.MicrosoftTeamsVoicemailPilotNumber(state: VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>, value: string) : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.MicrosoftTeamsVoicemailPilotNumber <- value)
            state : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#on_prem_mcp_enabled-1">VoiceServicesCommunicationsGateway#on_prem_mcp_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "on_prem_mcp_enabled">]
        member _.OnPremMcpEnabled(state: VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>, value: bool) : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.OnPremMcpEnabled <- value)
            state : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#on_prem_mcp_enabled-1">VoiceServicesCommunicationsGateway#on_prem_mcp_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "on_prem_mcp_enabled">]
        member _.OnPremMcpEnabled(state: VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>, value: HashiCorp.Cdktf.IResolvable) : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.OnPremMcpEnabled <- value)
            state : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#tags-1">VoiceServicesCommunicationsGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>, value: seq<string * string>) : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#timeouts-1">VoiceServicesCommunicationsGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>, value: azurerm.VoiceServicesCommunicationsGateway.VoiceServicesCommunicationsGatewayTimeouts) : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VoiceServicesCommunicationsGatewayState<'Codecs, 'Connectivity, 'E911Type, 'Location, 'Name, 'Platforms, 'ResourceGroupName, 'ServiceLocation>

        member _.Run(state: VoiceServicesCommunicationsGatewayState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.VoiceServicesCommunicationsGateway.VoiceServicesCommunicationsGateway =
            let config = azurerm.VoiceServicesCommunicationsGateway.VoiceServicesCommunicationsGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.VoiceServicesCommunicationsGateway.VoiceServicesCommunicationsGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.voiceServicesCommunicationsGateway: missing required arguments. Must call: codecs, connectivity, e911_type, location, name, platforms, resource_group_name, service_location.", 9999, IsError = true)>]
        member _.Run(_: VoiceServicesCommunicationsGatewayState<_, _, _, _, _, _, _, _>) : azurerm.VoiceServicesCommunicationsGateway.VoiceServicesCommunicationsGateway =
            Unchecked.defaultof<azurerm.VoiceServicesCommunicationsGateway.VoiceServicesCommunicationsGateway>
