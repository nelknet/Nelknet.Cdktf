namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkmanagerDeviceState<'DeviceId, 'GlobalNetworkId> = { assignments: ResizeArray<aws.DataAwsNetworkmanagerDevice.DataAwsNetworkmanagerDeviceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_device">aws_networkmanager_device</a>.
    /// </summary>
    type DataAwsNetworkmanagerDeviceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkmanagerDeviceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerDeviceState<Missing, Missing>)

        member _.Zero(()) : DataAwsNetworkmanagerDeviceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerDeviceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_device#device_id-1">DataAwsNetworkmanagerDevice#device_id</a>.
        /// </summary>
        [<CustomOperation "device_id">]
        member _.DeviceId(state: DataAwsNetworkmanagerDeviceState<Missing, 'GlobalNetworkId>, value: string) : DataAwsNetworkmanagerDeviceState<Present, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.DeviceId <- value)
            ({ assignments = state.assignments } : DataAwsNetworkmanagerDeviceState<Present, 'GlobalNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_device#global_network_id-1">DataAwsNetworkmanagerDevice#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: DataAwsNetworkmanagerDeviceState<'DeviceId, Missing>, value: string) : DataAwsNetworkmanagerDeviceState<'DeviceId, Present> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : DataAwsNetworkmanagerDeviceState<'DeviceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_device#id-1">DataAwsNetworkmanagerDevice#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkmanagerDeviceState<'DeviceId, 'GlobalNetworkId>, value: string) : DataAwsNetworkmanagerDeviceState<'DeviceId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkmanagerDeviceState<'DeviceId, 'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_device#tags-1">DataAwsNetworkmanagerDevice#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNetworkmanagerDeviceState<'DeviceId, 'GlobalNetworkId>, value: seq<string * string>) : DataAwsNetworkmanagerDeviceState<'DeviceId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNetworkmanagerDeviceState<'DeviceId, 'GlobalNetworkId>

        member _.Run(state: DataAwsNetworkmanagerDeviceState<Present, Present>) : aws.DataAwsNetworkmanagerDevice.DataAwsNetworkmanagerDevice =
            let config = aws.DataAwsNetworkmanagerDevice.DataAwsNetworkmanagerDeviceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkmanagerDevice.DataAwsNetworkmanagerDevice(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsNetworkmanagerDevice: missing required arguments. Must call: device_id, global_network_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsNetworkmanagerDeviceState<_, _>) : aws.DataAwsNetworkmanagerDevice.DataAwsNetworkmanagerDevice =
            Unchecked.defaultof<aws.DataAwsNetworkmanagerDevice.DataAwsNetworkmanagerDevice>
