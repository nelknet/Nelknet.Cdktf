namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.BotChannelMsTeams.BotChannelMsTeamsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_ms_teams">azurerm_bot_channel_ms_teams</a>.
    /// </summary>
    type BotChannelMsTeamsBuilder(logicalId: string) =
        member _.Yield(_: unit) : BotChannelMsTeamsState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelMsTeamsState<Missing, Missing, Missing>)

        member _.Zero(()) : BotChannelMsTeamsState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelMsTeamsState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_ms_teams#bot_name-1">BotChannelMsTeams#bot_name</a>.
        /// </summary>
        [<CustomOperation "bot_name">]
        member _.BotName(state: BotChannelMsTeamsState<Missing, 'Location, 'ResourceGroupName>, value: string) : BotChannelMsTeamsState<Present, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BotName <- value)
            ({ assignments = state.assignments } : BotChannelMsTeamsState<Present, 'Location, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_ms_teams#location-1">BotChannelMsTeams#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BotChannelMsTeamsState<'BotName, Missing, 'ResourceGroupName>, value: string) : BotChannelMsTeamsState<'BotName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BotChannelMsTeamsState<'BotName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_ms_teams#resource_group_name-1">BotChannelMsTeams#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BotChannelMsTeamsState<'BotName, 'Location, Missing>, value: string) : BotChannelMsTeamsState<'BotName, 'Location, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BotChannelMsTeamsState<'BotName, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_ms_teams#calling_web_hook-1">BotChannelMsTeams#calling_web_hook</a>.
        /// </summary>
        [<CustomOperation "calling_web_hook">]
        member _.CallingWebHook(state: BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName>, value: string) : BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CallingWebHook <- value)
            state : BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_ms_teams#deployment_environment-1">BotChannelMsTeams#deployment_environment</a>.
        /// </summary>
        [<CustomOperation "deployment_environment">]
        member _.DeploymentEnvironment(state: BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName>, value: string) : BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DeploymentEnvironment <- value)
            state : BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_ms_teams#enable_calling-1">BotChannelMsTeams#enable_calling</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_calling">]
        member _.EnableCalling(state: BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName>, value: bool) : BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EnableCalling <- value)
            state : BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_ms_teams#enable_calling-1">BotChannelMsTeams#enable_calling</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_calling">]
        member _.EnableCalling(state: BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EnableCalling <- value)
            state : BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_ms_teams#id-1">BotChannelMsTeams#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName>, value: string) : BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_ms_teams#timeouts-1">BotChannelMsTeams#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName>, value: azurerm.BotChannelMsTeams.BotChannelMsTeamsTimeouts) : BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BotChannelMsTeamsState<'BotName, 'Location, 'ResourceGroupName>

        member _.Run(state: BotChannelMsTeamsState<Present, Present, Present>) : azurerm.BotChannelMsTeams.BotChannelMsTeams =
            let config = azurerm.BotChannelMsTeams.BotChannelMsTeamsConfig()
            for setter in state.assignments do
                setter config
            azurerm.BotChannelMsTeams.BotChannelMsTeams(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.botChannelMsTeams: missing required arguments. Must call: bot_name, location, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: BotChannelMsTeamsState<_, _, _>) : azurerm.BotChannelMsTeams.BotChannelMsTeams =
            Unchecked.defaultof<azurerm.BotChannelMsTeams.BotChannelMsTeams>
