namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerDeviceState<'Device, 'DeviceFleetName> = { assignments: ResizeArray<aws.SagemakerDevice.SagemakerDeviceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device">aws_sagemaker_device</a>.
    /// </summary>
    type SagemakerDeviceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerDeviceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerDeviceState<Missing, Missing>)

        member _.Zero(()) : SagemakerDeviceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerDeviceState<Missing, Missing>)

        /// <summary>
        /// device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device#device-1">SagemakerDevice#device</a>
        /// </summary>
        [<CustomOperation "device">]
        member _.Device(state: SagemakerDeviceState<Missing, 'DeviceFleetName>, value: aws.SagemakerDevice.SagemakerDeviceDevice) : SagemakerDeviceState<Present, 'DeviceFleetName> =
            state.assignments.Add(fun config -> config.Device <- value)
            ({ assignments = state.assignments } : SagemakerDeviceState<Present, 'DeviceFleetName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device#device_fleet_name-1">SagemakerDevice#device_fleet_name</a>.
        /// </summary>
        [<CustomOperation "device_fleet_name">]
        member _.DeviceFleetName(state: SagemakerDeviceState<'Device, Missing>, value: string) : SagemakerDeviceState<'Device, Present> =
            state.assignments.Add(fun config -> config.DeviceFleetName <- value)
            ({ assignments = state.assignments } : SagemakerDeviceState<'Device, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device#id-1">SagemakerDevice#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerDeviceState<'Device, 'DeviceFleetName>, value: string) : SagemakerDeviceState<'Device, 'DeviceFleetName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerDeviceState<'Device, 'DeviceFleetName>

        member _.Run(state: SagemakerDeviceState<Present, Present>) : aws.SagemakerDevice.SagemakerDevice =
            let config = aws.SagemakerDevice.SagemakerDeviceConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerDevice.SagemakerDevice(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerDevice: missing required arguments. Must call: device, device_fleet_name.", 9999, IsError = true)>]
        member _.Run(_: SagemakerDeviceState<_, _>) : aws.SagemakerDevice.SagemakerDevice =
            Unchecked.defaultof<aws.SagemakerDevice.SagemakerDevice>
