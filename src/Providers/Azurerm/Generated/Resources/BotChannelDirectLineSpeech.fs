namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.BotChannelDirectLineSpeech.BotChannelDirectLineSpeechConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_direct_line_speech">azurerm_bot_channel_direct_line_speech</a>.
    /// </summary>
    type BotChannelDirectLineSpeechBuilder(logicalId: string) =
        member _.Yield(_: unit) : BotChannelDirectLineSpeechState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelDirectLineSpeechState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BotChannelDirectLineSpeechState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelDirectLineSpeechState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_direct_line_speech#bot_name-1">BotChannelDirectLineSpeech#bot_name</a>.
        /// </summary>
        [<CustomOperation "bot_name">]
        member _.BotName(state: BotChannelDirectLineSpeechState<Missing, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName>, value: string) : BotChannelDirectLineSpeechState<Present, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BotName <- value)
            ({ assignments = state.assignments } : BotChannelDirectLineSpeechState<Present, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_direct_line_speech#cognitive_service_access_key-1">BotChannelDirectLineSpeech#cognitive_service_access_key</a>.
        /// </summary>
        [<CustomOperation "cognitive_service_access_key">]
        member _.CognitiveServiceAccessKey(state: BotChannelDirectLineSpeechState<'BotName, Missing, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName>, value: string) : BotChannelDirectLineSpeechState<'BotName, Present, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CognitiveServiceAccessKey <- value)
            ({ assignments = state.assignments } : BotChannelDirectLineSpeechState<'BotName, Present, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_direct_line_speech#cognitive_service_location-1">BotChannelDirectLineSpeech#cognitive_service_location</a>.
        /// </summary>
        [<CustomOperation "cognitive_service_location">]
        member _.CognitiveServiceLocation(state: BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, Missing, 'Location, 'ResourceGroupName>, value: string) : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, Present, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CognitiveServiceLocation <- value)
            ({ assignments = state.assignments } : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, Present, 'Location, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_direct_line_speech#location-1">BotChannelDirectLineSpeech#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, Missing, 'ResourceGroupName>, value: string) : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_direct_line_speech#resource_group_name-1">BotChannelDirectLineSpeech#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, Missing>, value: string) : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_direct_line_speech#cognitive_account_id-1">BotChannelDirectLineSpeech#cognitive_account_id</a>.
        /// </summary>
        [<CustomOperation "cognitive_account_id">]
        member _.CognitiveAccountId(state: BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName>, value: string) : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CognitiveAccountId <- value)
            state : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_direct_line_speech#custom_speech_model_id-1">BotChannelDirectLineSpeech#custom_speech_model_id</a>.
        /// </summary>
        [<CustomOperation "custom_speech_model_id">]
        member _.CustomSpeechModelId(state: BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName>, value: string) : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CustomSpeechModelId <- value)
            state : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_direct_line_speech#custom_voice_deployment_id-1">BotChannelDirectLineSpeech#custom_voice_deployment_id</a>.
        /// </summary>
        [<CustomOperation "custom_voice_deployment_id">]
        member _.CustomVoiceDeploymentId(state: BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName>, value: string) : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CustomVoiceDeploymentId <- value)
            state : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_direct_line_speech#id-1">BotChannelDirectLineSpeech#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName>, value: string) : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_direct_line_speech#timeouts-1">BotChannelDirectLineSpeech#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName>, value: azurerm.BotChannelDirectLineSpeech.BotChannelDirectLineSpeechTimeouts) : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BotChannelDirectLineSpeechState<'BotName, 'CognitiveServiceAccessKey, 'CognitiveServiceLocation, 'Location, 'ResourceGroupName>

        member _.Run(state: BotChannelDirectLineSpeechState<Present, Present, Present, Present, Present>) : azurerm.BotChannelDirectLineSpeech.BotChannelDirectLineSpeech =
            let config = azurerm.BotChannelDirectLineSpeech.BotChannelDirectLineSpeechConfig()
            for setter in state.assignments do
                setter config
            azurerm.BotChannelDirectLineSpeech.BotChannelDirectLineSpeech(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.botChannelDirectLineSpeech: missing required arguments. Must call: bot_name, cognitive_service_access_key, cognitive_service_location, location, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: BotChannelDirectLineSpeechState<_, _, _, _, _>) : azurerm.BotChannelDirectLineSpeech.BotChannelDirectLineSpeech =
            Unchecked.defaultof<azurerm.BotChannelDirectLineSpeech.BotChannelDirectLineSpeech>
