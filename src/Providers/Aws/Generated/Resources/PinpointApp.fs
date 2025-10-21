namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PinpointAppState = { assignments: ResizeArray<aws.PinpointApp.PinpointAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_app">aws_pinpoint_app</a>.
    /// </summary>
    type PinpointAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : PinpointAppState =
            { assignments = ResizeArray() }

        member _.Zero(()) : PinpointAppState =
            { assignments = ResizeArray() }

        /// <summary>
        /// campaign_hook block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_app#campaign_hook-1">PinpointApp#campaign_hook</a>
        /// </summary>
        [<CustomOperation "campaign_hook">]
        member _.CampaignHook(state: PinpointAppState, value: aws.PinpointApp.PinpointAppCampaignHook) : PinpointAppState =
            state.assignments.Add(fun config -> config.CampaignHook <- value)
            state : PinpointAppState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_app#id-1">PinpointApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PinpointAppState, value: string) : PinpointAppState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PinpointAppState

        /// <summary>
        /// limits block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_app#limits-1">PinpointApp#limits</a>
        /// </summary>
        [<CustomOperation "limits">]
        member _.Limits(state: PinpointAppState, value: aws.PinpointApp.PinpointAppLimits) : PinpointAppState =
            state.assignments.Add(fun config -> config.Limits <- value)
            state : PinpointAppState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_app#name-1">PinpointApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PinpointAppState, value: string) : PinpointAppState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : PinpointAppState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_app#name_prefix-1">PinpointApp#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: PinpointAppState, value: string) : PinpointAppState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : PinpointAppState

        /// <summary>
        /// quiet_time block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_app#quiet_time-1">PinpointApp#quiet_time</a>
        /// </summary>
        [<CustomOperation "quiet_time">]
        member _.QuietTime(state: PinpointAppState, value: aws.PinpointApp.PinpointAppQuietTime) : PinpointAppState =
            state.assignments.Add(fun config -> config.QuietTime <- value)
            state : PinpointAppState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_app#tags-1">PinpointApp#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PinpointAppState, value: seq<string * string>) : PinpointAppState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PinpointAppState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_app#tags_all-1">PinpointApp#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: PinpointAppState, value: seq<string * string>) : PinpointAppState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : PinpointAppState

        member _.Run(state: PinpointAppState) : aws.PinpointApp.PinpointApp =
            let config = aws.PinpointApp.PinpointAppConfig()
            for setter in state.assignments do
                setter config
            aws.PinpointApp.PinpointApp(StackContext.get (), logicalId, config)
