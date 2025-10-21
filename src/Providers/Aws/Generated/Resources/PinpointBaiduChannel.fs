namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PinpointBaiduChannelState<'ApiKey, 'ApplicationId, 'SecretKey> = { assignments: ResizeArray<aws.PinpointBaiduChannel.PinpointBaiduChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_baidu_channel">aws_pinpoint_baidu_channel</a>.
    /// </summary>
    type PinpointBaiduChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : PinpointBaiduChannelState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PinpointBaiduChannelState<Missing, Missing, Missing>)

        member _.Zero(()) : PinpointBaiduChannelState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PinpointBaiduChannelState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_baidu_channel#api_key-1">PinpointBaiduChannel#api_key</a>.
        /// </summary>
        [<CustomOperation "api_key">]
        member _.ApiKey(state: PinpointBaiduChannelState<Missing, 'ApplicationId, 'SecretKey>, value: string) : PinpointBaiduChannelState<Present, 'ApplicationId, 'SecretKey> =
            state.assignments.Add(fun config -> config.ApiKey <- value)
            ({ assignments = state.assignments } : PinpointBaiduChannelState<Present, 'ApplicationId, 'SecretKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_baidu_channel#application_id-1">PinpointBaiduChannel#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: PinpointBaiduChannelState<'ApiKey, Missing, 'SecretKey>, value: string) : PinpointBaiduChannelState<'ApiKey, Present, 'SecretKey> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : PinpointBaiduChannelState<'ApiKey, Present, 'SecretKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_baidu_channel#secret_key-1">PinpointBaiduChannel#secret_key</a>.
        /// </summary>
        [<CustomOperation "secret_key">]
        member _.SecretKey(state: PinpointBaiduChannelState<'ApiKey, 'ApplicationId, Missing>, value: string) : PinpointBaiduChannelState<'ApiKey, 'ApplicationId, Present> =
            state.assignments.Add(fun config -> config.SecretKey <- value)
            ({ assignments = state.assignments } : PinpointBaiduChannelState<'ApiKey, 'ApplicationId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_baidu_channel#enabled-1">PinpointBaiduChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointBaiduChannelState<'ApiKey, 'ApplicationId, 'SecretKey>, value: bool) : PinpointBaiduChannelState<'ApiKey, 'ApplicationId, 'SecretKey> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointBaiduChannelState<'ApiKey, 'ApplicationId, 'SecretKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_baidu_channel#enabled-1">PinpointBaiduChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointBaiduChannelState<'ApiKey, 'ApplicationId, 'SecretKey>, value: HashiCorp.Cdktf.IResolvable) : PinpointBaiduChannelState<'ApiKey, 'ApplicationId, 'SecretKey> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointBaiduChannelState<'ApiKey, 'ApplicationId, 'SecretKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_baidu_channel#id-1">PinpointBaiduChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PinpointBaiduChannelState<'ApiKey, 'ApplicationId, 'SecretKey>, value: string) : PinpointBaiduChannelState<'ApiKey, 'ApplicationId, 'SecretKey> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PinpointBaiduChannelState<'ApiKey, 'ApplicationId, 'SecretKey>

        member _.Run(state: PinpointBaiduChannelState<Present, Present, Present>) : aws.PinpointBaiduChannel.PinpointBaiduChannel =
            let config = aws.PinpointBaiduChannel.PinpointBaiduChannelConfig()
            for setter in state.assignments do
                setter config
            aws.PinpointBaiduChannel.PinpointBaiduChannel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.pinpointBaiduChannel: missing required arguments. Must call: api_key, application_id, secret_key.", 9999, IsError = true)>]
        member _.Run(_: PinpointBaiduChannelState<_, _, _>) : aws.PinpointBaiduChannel.PinpointBaiduChannel =
            Unchecked.defaultof<aws.PinpointBaiduChannel.PinpointBaiduChannel>
