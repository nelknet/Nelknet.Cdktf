namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevicefarmNetworkProfileState<'Name, 'ProjectArn> = { assignments: ResizeArray<aws.DevicefarmNetworkProfile.DevicefarmNetworkProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile">aws_devicefarm_network_profile</a>.
    /// </summary>
    type DevicefarmNetworkProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevicefarmNetworkProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DevicefarmNetworkProfileState<Missing, Missing>)

        member _.Zero(()) : DevicefarmNetworkProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DevicefarmNetworkProfileState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile#name-1">DevicefarmNetworkProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevicefarmNetworkProfileState<Missing, 'ProjectArn>, value: string) : DevicefarmNetworkProfileState<Present, 'ProjectArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevicefarmNetworkProfileState<Present, 'ProjectArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile#project_arn-1">DevicefarmNetworkProfile#project_arn</a>.
        /// </summary>
        [<CustomOperation "project_arn">]
        member _.ProjectArn(state: DevicefarmNetworkProfileState<'Name, Missing>, value: string) : DevicefarmNetworkProfileState<'Name, Present> =
            state.assignments.Add(fun config -> config.ProjectArn <- value)
            ({ assignments = state.assignments } : DevicefarmNetworkProfileState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile#description-1">DevicefarmNetworkProfile#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DevicefarmNetworkProfileState<'Name, 'ProjectArn>, value: string) : DevicefarmNetworkProfileState<'Name, 'ProjectArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DevicefarmNetworkProfileState<'Name, 'ProjectArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile#downlink_bandwidth_bits-1">DevicefarmNetworkProfile#downlink_bandwidth_bits</a>.
        /// </summary>
        [<CustomOperation "downlink_bandwidth_bits">]
        member _.DownlinkBandwidthBits(state: DevicefarmNetworkProfileState<'Name, 'ProjectArn>, value: double) : DevicefarmNetworkProfileState<'Name, 'ProjectArn> =
            state.assignments.Add(fun config -> config.DownlinkBandwidthBits <- value)
            state : DevicefarmNetworkProfileState<'Name, 'ProjectArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile#downlink_delay_ms-1">DevicefarmNetworkProfile#downlink_delay_ms</a>.
        /// </summary>
        [<CustomOperation "downlink_delay_ms">]
        member _.DownlinkDelayMs(state: DevicefarmNetworkProfileState<'Name, 'ProjectArn>, value: double) : DevicefarmNetworkProfileState<'Name, 'ProjectArn> =
            state.assignments.Add(fun config -> config.DownlinkDelayMs <- value)
            state : DevicefarmNetworkProfileState<'Name, 'ProjectArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile#downlink_jitter_ms-1">DevicefarmNetworkProfile#downlink_jitter_ms</a>.
        /// </summary>
        [<CustomOperation "downlink_jitter_ms">]
        member _.DownlinkJitterMs(state: DevicefarmNetworkProfileState<'Name, 'ProjectArn>, value: double) : DevicefarmNetworkProfileState<'Name, 'ProjectArn> =
            state.assignments.Add(fun config -> config.DownlinkJitterMs <- value)
            state : DevicefarmNetworkProfileState<'Name, 'ProjectArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile#downlink_loss_percent-1">DevicefarmNetworkProfile#downlink_loss_percent</a>.
        /// </summary>
        [<CustomOperation "downlink_loss_percent">]
        member _.DownlinkLossPercent(state: DevicefarmNetworkProfileState<'Name, 'ProjectArn>, value: double) : DevicefarmNetworkProfileState<'Name, 'ProjectArn> =
            state.assignments.Add(fun config -> config.DownlinkLossPercent <- value)
            state : DevicefarmNetworkProfileState<'Name, 'ProjectArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile#id-1">DevicefarmNetworkProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevicefarmNetworkProfileState<'Name, 'ProjectArn>, value: string) : DevicefarmNetworkProfileState<'Name, 'ProjectArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevicefarmNetworkProfileState<'Name, 'ProjectArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile#tags-1">DevicefarmNetworkProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevicefarmNetworkProfileState<'Name, 'ProjectArn>, value: seq<string * string>) : DevicefarmNetworkProfileState<'Name, 'ProjectArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevicefarmNetworkProfileState<'Name, 'ProjectArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile#tags_all-1">DevicefarmNetworkProfile#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DevicefarmNetworkProfileState<'Name, 'ProjectArn>, value: seq<string * string>) : DevicefarmNetworkProfileState<'Name, 'ProjectArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DevicefarmNetworkProfileState<'Name, 'ProjectArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile#type-1">DevicefarmNetworkProfile#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DevicefarmNetworkProfileState<'Name, 'ProjectArn>, value: string) : DevicefarmNetworkProfileState<'Name, 'ProjectArn> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : DevicefarmNetworkProfileState<'Name, 'ProjectArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile#uplink_bandwidth_bits-1">DevicefarmNetworkProfile#uplink_bandwidth_bits</a>.
        /// </summary>
        [<CustomOperation "uplink_bandwidth_bits">]
        member _.UplinkBandwidthBits(state: DevicefarmNetworkProfileState<'Name, 'ProjectArn>, value: double) : DevicefarmNetworkProfileState<'Name, 'ProjectArn> =
            state.assignments.Add(fun config -> config.UplinkBandwidthBits <- value)
            state : DevicefarmNetworkProfileState<'Name, 'ProjectArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile#uplink_delay_ms-1">DevicefarmNetworkProfile#uplink_delay_ms</a>.
        /// </summary>
        [<CustomOperation "uplink_delay_ms">]
        member _.UplinkDelayMs(state: DevicefarmNetworkProfileState<'Name, 'ProjectArn>, value: double) : DevicefarmNetworkProfileState<'Name, 'ProjectArn> =
            state.assignments.Add(fun config -> config.UplinkDelayMs <- value)
            state : DevicefarmNetworkProfileState<'Name, 'ProjectArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile#uplink_jitter_ms-1">DevicefarmNetworkProfile#uplink_jitter_ms</a>.
        /// </summary>
        [<CustomOperation "uplink_jitter_ms">]
        member _.UplinkJitterMs(state: DevicefarmNetworkProfileState<'Name, 'ProjectArn>, value: double) : DevicefarmNetworkProfileState<'Name, 'ProjectArn> =
            state.assignments.Add(fun config -> config.UplinkJitterMs <- value)
            state : DevicefarmNetworkProfileState<'Name, 'ProjectArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_network_profile#uplink_loss_percent-1">DevicefarmNetworkProfile#uplink_loss_percent</a>.
        /// </summary>
        [<CustomOperation "uplink_loss_percent">]
        member _.UplinkLossPercent(state: DevicefarmNetworkProfileState<'Name, 'ProjectArn>, value: double) : DevicefarmNetworkProfileState<'Name, 'ProjectArn> =
            state.assignments.Add(fun config -> config.UplinkLossPercent <- value)
            state : DevicefarmNetworkProfileState<'Name, 'ProjectArn>

        member _.Run(state: DevicefarmNetworkProfileState<Present, Present>) : aws.DevicefarmNetworkProfile.DevicefarmNetworkProfile =
            let config = aws.DevicefarmNetworkProfile.DevicefarmNetworkProfileConfig()
            for setter in state.assignments do
                setter config
            aws.DevicefarmNetworkProfile.DevicefarmNetworkProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.devicefarmNetworkProfile: missing required arguments. Must call: name, project_arn.", 9999, IsError = true)>]
        member _.Run(_: DevicefarmNetworkProfileState<_, _>) : aws.DevicefarmNetworkProfile.DevicefarmNetworkProfile =
            Unchecked.defaultof<aws.DevicefarmNetworkProfile.DevicefarmNetworkProfile>
