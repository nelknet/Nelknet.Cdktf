namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerDeviceState<'GlobalNetworkId> = { assignments: ResizeArray<aws.NetworkmanagerDevice.NetworkmanagerDeviceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device">aws_networkmanager_device</a>.
    /// </summary>
    type NetworkmanagerDeviceBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerDeviceState<Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerDeviceState<Missing>)

        member _.Zero(()) : NetworkmanagerDeviceState<Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerDeviceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#global_network_id-1">NetworkmanagerDevice#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: NetworkmanagerDeviceState<Missing>, value: string) : NetworkmanagerDeviceState<Present> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerDeviceState<Present>)

        /// <summary>
        /// aws_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#aws_location-1">NetworkmanagerDevice#aws_location</a>
        /// </summary>
        [<CustomOperation "aws_location">]
        member _.AwsLocation(state: NetworkmanagerDeviceState<'GlobalNetworkId>, value: aws.NetworkmanagerDevice.NetworkmanagerDeviceAwsLocation) : NetworkmanagerDeviceState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.AwsLocation <- value)
            state : NetworkmanagerDeviceState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#description-1">NetworkmanagerDevice#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkmanagerDeviceState<'GlobalNetworkId>, value: string) : NetworkmanagerDeviceState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkmanagerDeviceState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#id-1">NetworkmanagerDevice#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerDeviceState<'GlobalNetworkId>, value: string) : NetworkmanagerDeviceState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerDeviceState<'GlobalNetworkId>

        /// <summary>
        /// location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#location-1">NetworkmanagerDevice#location</a>
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetworkmanagerDeviceState<'GlobalNetworkId>, value: aws.NetworkmanagerDevice.NetworkmanagerDeviceLocation) : NetworkmanagerDeviceState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Location <- value)
            state : NetworkmanagerDeviceState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#model-1">NetworkmanagerDevice#model</a>.
        /// </summary>
        [<CustomOperation "model">]
        member _.Model(state: NetworkmanagerDeviceState<'GlobalNetworkId>, value: string) : NetworkmanagerDeviceState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Model <- value)
            state : NetworkmanagerDeviceState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#serial_number-1">NetworkmanagerDevice#serial_number</a>.
        /// </summary>
        [<CustomOperation "serial_number">]
        member _.SerialNumber(state: NetworkmanagerDeviceState<'GlobalNetworkId>, value: string) : NetworkmanagerDeviceState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.SerialNumber <- value)
            state : NetworkmanagerDeviceState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#site_id-1">NetworkmanagerDevice#site_id</a>.
        /// </summary>
        [<CustomOperation "site_id">]
        member _.SiteId(state: NetworkmanagerDeviceState<'GlobalNetworkId>, value: string) : NetworkmanagerDeviceState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.SiteId <- value)
            state : NetworkmanagerDeviceState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#tags-1">NetworkmanagerDevice#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkmanagerDeviceState<'GlobalNetworkId>, value: seq<string * string>) : NetworkmanagerDeviceState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkmanagerDeviceState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#tags_all-1">NetworkmanagerDevice#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkmanagerDeviceState<'GlobalNetworkId>, value: seq<string * string>) : NetworkmanagerDeviceState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkmanagerDeviceState<'GlobalNetworkId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#timeouts-1">NetworkmanagerDevice#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerDeviceState<'GlobalNetworkId>, value: aws.NetworkmanagerDevice.NetworkmanagerDeviceTimeouts) : NetworkmanagerDeviceState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerDeviceState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#type-1">NetworkmanagerDevice#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: NetworkmanagerDeviceState<'GlobalNetworkId>, value: string) : NetworkmanagerDeviceState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : NetworkmanagerDeviceState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#vendor-1">NetworkmanagerDevice#vendor</a>.
        /// </summary>
        [<CustomOperation "vendor">]
        member _.Vendor(state: NetworkmanagerDeviceState<'GlobalNetworkId>, value: string) : NetworkmanagerDeviceState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Vendor <- value)
            state : NetworkmanagerDeviceState<'GlobalNetworkId>

        member _.Run(state: NetworkmanagerDeviceState<Present>) : aws.NetworkmanagerDevice.NetworkmanagerDevice =
            let config = aws.NetworkmanagerDevice.NetworkmanagerDeviceConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerDevice.NetworkmanagerDevice(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerDevice: missing required arguments. Must call: global_network_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerDeviceState<_>) : aws.NetworkmanagerDevice.NetworkmanagerDevice =
            Unchecked.defaultof<aws.NetworkmanagerDevice.NetworkmanagerDevice>
