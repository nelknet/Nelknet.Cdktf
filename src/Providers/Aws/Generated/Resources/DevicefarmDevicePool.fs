namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule> = { assignments: ResizeArray<aws.DevicefarmDevicePool.DevicefarmDevicePoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_device_pool">aws_devicefarm_device_pool</a>.
    /// </summary>
    type DevicefarmDevicePoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevicefarmDevicePoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevicefarmDevicePoolState<Missing, Missing, Missing>)

        member _.Zero(()) : DevicefarmDevicePoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevicefarmDevicePoolState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_device_pool#name-1">DevicefarmDevicePool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevicefarmDevicePoolState<Missing, 'ProjectArn, 'Rule>, value: string) : DevicefarmDevicePoolState<Present, 'ProjectArn, 'Rule> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevicefarmDevicePoolState<Present, 'ProjectArn, 'Rule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_device_pool#project_arn-1">DevicefarmDevicePool#project_arn</a>.
        /// </summary>
        [<CustomOperation "project_arn">]
        member _.ProjectArn(state: DevicefarmDevicePoolState<'Name, Missing, 'Rule>, value: string) : DevicefarmDevicePoolState<'Name, Present, 'Rule> =
            state.assignments.Add(fun config -> config.ProjectArn <- value)
            ({ assignments = state.assignments } : DevicefarmDevicePoolState<'Name, Present, 'Rule>)

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_device_pool#rule-1">DevicefarmDevicePool#rule</a> Accepts: aws.IResolvable | aws.DevicefarmDevicePool.DevicefarmDevicePoolRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: DevicefarmDevicePoolState<'Name, 'ProjectArn, Missing>, value: HashiCorp.Cdktf.IResolvable) : DevicefarmDevicePoolState<'Name, 'ProjectArn, Present> =
            state.assignments.Add(fun config -> config.Rule <- value)
            ({ assignments = state.assignments } : DevicefarmDevicePoolState<'Name, 'ProjectArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_device_pool#description-1">DevicefarmDevicePool#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule>, value: string) : DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_device_pool#id-1">DevicefarmDevicePool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule>, value: string) : DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_device_pool#max_devices-1">DevicefarmDevicePool#max_devices</a>.
        /// </summary>
        [<CustomOperation "max_devices">]
        member _.MaxDevices(state: DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule>, value: double) : DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule> =
            state.assignments.Add(fun config -> config.MaxDevices <- value)
            state : DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_device_pool#tags-1">DevicefarmDevicePool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule>, value: seq<string * string>) : DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_device_pool#tags_all-1">DevicefarmDevicePool#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule>, value: seq<string * string>) : DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DevicefarmDevicePoolState<'Name, 'ProjectArn, 'Rule>

        member _.Run(state: DevicefarmDevicePoolState<Present, Present, Present>) : aws.DevicefarmDevicePool.DevicefarmDevicePool =
            let config = aws.DevicefarmDevicePool.DevicefarmDevicePoolConfig()
            for setter in state.assignments do
                setter config
            aws.DevicefarmDevicePool.DevicefarmDevicePool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.devicefarmDevicePool: missing required arguments. Must call: name, project_arn, rule.", 9999, IsError = true)>]
        member _.Run(_: DevicefarmDevicePoolState<_, _, _>) : aws.DevicefarmDevicePool.DevicefarmDevicePool =
            Unchecked.defaultof<aws.DevicefarmDevicePool.DevicefarmDevicePool>
