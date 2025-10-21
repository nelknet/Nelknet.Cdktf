namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn> = { assignments: ResizeArray<aws.SagemakerDeviceFleet.SagemakerDeviceFleetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet">aws_sagemaker_device_fleet</a>.
    /// </summary>
    type SagemakerDeviceFleetBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerDeviceFleetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerDeviceFleetState<Missing, Missing, Missing>)

        member _.Zero(()) : SagemakerDeviceFleetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerDeviceFleetState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet#device_fleet_name-1">SagemakerDeviceFleet#device_fleet_name</a>.
        /// </summary>
        [<CustomOperation "device_fleet_name">]
        member _.DeviceFleetName(state: SagemakerDeviceFleetState<Missing, 'OutputConfig, 'RoleArn>, value: string) : SagemakerDeviceFleetState<Present, 'OutputConfig, 'RoleArn> =
            state.assignments.Add(fun config -> config.DeviceFleetName <- value)
            ({ assignments = state.assignments } : SagemakerDeviceFleetState<Present, 'OutputConfig, 'RoleArn>)

        /// <summary>
        /// output_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet#output_config-1">SagemakerDeviceFleet#output_config</a>
        /// </summary>
        [<CustomOperation "output_config">]
        member _.OutputConfig(state: SagemakerDeviceFleetState<'DeviceFleetName, Missing, 'RoleArn>, value: aws.SagemakerDeviceFleet.SagemakerDeviceFleetOutputConfig) : SagemakerDeviceFleetState<'DeviceFleetName, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.OutputConfig <- value)
            ({ assignments = state.assignments } : SagemakerDeviceFleetState<'DeviceFleetName, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet#role_arn-1">SagemakerDeviceFleet#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, Missing>, value: string) : SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet#description-1">SagemakerDeviceFleet#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn>, value: string) : SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet#enable_iot_role_alias-1">SagemakerDeviceFleet#enable_iot_role_alias</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_iot_role_alias">]
        member _.EnableIotRoleAlias(state: SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn>, value: bool) : SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn> =
            state.assignments.Add(fun config -> config.EnableIotRoleAlias <- value)
            state : SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet#enable_iot_role_alias-1">SagemakerDeviceFleet#enable_iot_role_alias</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_iot_role_alias">]
        member _.EnableIotRoleAlias(state: SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn> =
            state.assignments.Add(fun config -> config.EnableIotRoleAlias <- value)
            state : SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet#id-1">SagemakerDeviceFleet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn>, value: string) : SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet#tags-1">SagemakerDeviceFleet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn>, value: seq<string * string>) : SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_device_fleet#tags_all-1">SagemakerDeviceFleet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn>, value: seq<string * string>) : SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerDeviceFleetState<'DeviceFleetName, 'OutputConfig, 'RoleArn>

        member _.Run(state: SagemakerDeviceFleetState<Present, Present, Present>) : aws.SagemakerDeviceFleet.SagemakerDeviceFleet =
            let config = aws.SagemakerDeviceFleet.SagemakerDeviceFleetConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerDeviceFleet.SagemakerDeviceFleet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerDeviceFleet: missing required arguments. Must call: device_fleet_name, output_config, role_arn.", 9999, IsError = true)>]
        member _.Run(_: SagemakerDeviceFleetState<_, _, _>) : aws.SagemakerDeviceFleet.SagemakerDeviceFleet =
            Unchecked.defaultof<aws.SagemakerDeviceFleet.SagemakerDeviceFleet>
