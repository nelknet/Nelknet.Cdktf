namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId> = { assignments: ResizeArray<azurerm.VoiceServicesCommunicationsGatewayTestLine.VoiceServicesCommunicationsGatewayTestLineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line">azurerm_voice_services_communications_gateway_test_line</a>.
    /// </summary>
    type VoiceServicesCommunicationsGatewayTestLineBuilder(logicalId: string) =
        member _.Yield(_: unit) : VoiceServicesCommunicationsGatewayTestLineState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VoiceServicesCommunicationsGatewayTestLineState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VoiceServicesCommunicationsGatewayTestLineState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VoiceServicesCommunicationsGatewayTestLineState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#location-1">VoiceServicesCommunicationsGatewayTestLine#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VoiceServicesCommunicationsGatewayTestLineState<Missing, 'Name, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId>, value: string) : VoiceServicesCommunicationsGatewayTestLineState<Present, 'Name, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VoiceServicesCommunicationsGatewayTestLineState<Present, 'Name, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#name-1">VoiceServicesCommunicationsGatewayTestLine#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VoiceServicesCommunicationsGatewayTestLineState<'Location, Missing, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId>, value: string) : VoiceServicesCommunicationsGatewayTestLineState<'Location, Present, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VoiceServicesCommunicationsGatewayTestLineState<'Location, Present, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#phone_number-1">VoiceServicesCommunicationsGatewayTestLine#phone_number</a>.
        /// </summary>
        [<CustomOperation "phone_number">]
        member _.PhoneNumber(state: VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, Missing, 'Purpose, 'VoiceServicesCommunicationsGatewayId>, value: string) : VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, Present, 'Purpose, 'VoiceServicesCommunicationsGatewayId> =
            state.assignments.Add(fun config -> config.PhoneNumber <- value)
            ({ assignments = state.assignments } : VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, Present, 'Purpose, 'VoiceServicesCommunicationsGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#purpose-1">VoiceServicesCommunicationsGatewayTestLine#purpose</a>.
        /// </summary>
        [<CustomOperation "purpose">]
        member _.Purpose(state: VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, Missing, 'VoiceServicesCommunicationsGatewayId>, value: string) : VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, Present, 'VoiceServicesCommunicationsGatewayId> =
            state.assignments.Add(fun config -> config.Purpose <- value)
            ({ assignments = state.assignments } : VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, Present, 'VoiceServicesCommunicationsGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#voice_services_communications_gateway_id-1">VoiceServicesCommunicationsGatewayTestLine#voice_services_communications_gateway_id</a>.
        /// </summary>
        [<CustomOperation "voice_services_communications_gateway_id">]
        member _.VoiceServicesCommunicationsGatewayId(state: VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, 'Purpose, Missing>, value: string) : VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, 'Purpose, Present> =
            state.assignments.Add(fun config -> config.VoiceServicesCommunicationsGatewayId <- value)
            ({ assignments = state.assignments } : VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, 'Purpose, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#id-1">VoiceServicesCommunicationsGatewayTestLine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId>, value: string) : VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#tags-1">VoiceServicesCommunicationsGatewayTestLine#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId>, value: seq<string * string>) : VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#timeouts-1">VoiceServicesCommunicationsGatewayTestLine#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId>, value: azurerm.VoiceServicesCommunicationsGatewayTestLine.VoiceServicesCommunicationsGatewayTestLineTimeouts) : VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VoiceServicesCommunicationsGatewayTestLineState<'Location, 'Name, 'PhoneNumber, 'Purpose, 'VoiceServicesCommunicationsGatewayId>

        member _.Run(state: VoiceServicesCommunicationsGatewayTestLineState<Present, Present, Present, Present, Present>) : azurerm.VoiceServicesCommunicationsGatewayTestLine.VoiceServicesCommunicationsGatewayTestLine =
            let config = azurerm.VoiceServicesCommunicationsGatewayTestLine.VoiceServicesCommunicationsGatewayTestLineConfig()
            for setter in state.assignments do
                setter config
            azurerm.VoiceServicesCommunicationsGatewayTestLine.VoiceServicesCommunicationsGatewayTestLine(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.voiceServicesCommunicationsGatewayTestLine: missing required arguments. Must call: location, name, phone_number, purpose, voice_services_communications_gateway_id.", 9999, IsError = true)>]
        member _.Run(_: VoiceServicesCommunicationsGatewayTestLineState<_, _, _, _, _>) : azurerm.VoiceServicesCommunicationsGatewayTestLine.VoiceServicesCommunicationsGatewayTestLine =
            Unchecked.defaultof<azurerm.VoiceServicesCommunicationsGatewayTestLine.VoiceServicesCommunicationsGatewayTestLine>
