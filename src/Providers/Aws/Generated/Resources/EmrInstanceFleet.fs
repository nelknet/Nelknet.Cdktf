namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EmrInstanceFleetState<'ClusterId> = { assignments: ResizeArray<aws.EmrInstanceFleet.EmrInstanceFleetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet">aws_emr_instance_fleet</a>.
    /// </summary>
    type EmrInstanceFleetBuilder(logicalId: string) =
        member _.Yield(_: unit) : EmrInstanceFleetState<Missing> =
            ({ assignments = ResizeArray() } : EmrInstanceFleetState<Missing>)

        member _.Zero(()) : EmrInstanceFleetState<Missing> =
            ({ assignments = ResizeArray() } : EmrInstanceFleetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#cluster_id-1">EmrInstanceFleet#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: EmrInstanceFleetState<Missing>, value: string) : EmrInstanceFleetState<Present> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : EmrInstanceFleetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#id-1">EmrInstanceFleet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EmrInstanceFleetState<'ClusterId>, value: string) : EmrInstanceFleetState<'ClusterId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EmrInstanceFleetState<'ClusterId>

        /// <summary>
        /// instance_type_configs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#instance_type_configs-1">EmrInstanceFleet#instance_type_configs</a> Accepts: aws.IResolvable | aws.EmrInstanceFleet.EmrInstanceFleetInstanceTypeConfigs[]
        /// </summary>
        [<CustomOperation "instance_type_configs">]
        member _.InstanceTypeConfigs(state: EmrInstanceFleetState<'ClusterId>, value: HashiCorp.Cdktf.IResolvable) : EmrInstanceFleetState<'ClusterId> =
            state.assignments.Add(fun config -> config.InstanceTypeConfigs <- value)
            state : EmrInstanceFleetState<'ClusterId>

        /// <summary>
        /// launch_specifications block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#launch_specifications-1">EmrInstanceFleet#launch_specifications</a>
        /// </summary>
        [<CustomOperation "launch_specifications">]
        member _.LaunchSpecifications(state: EmrInstanceFleetState<'ClusterId>, value: aws.EmrInstanceFleet.EmrInstanceFleetLaunchSpecifications) : EmrInstanceFleetState<'ClusterId> =
            state.assignments.Add(fun config -> config.LaunchSpecifications <- value)
            state : EmrInstanceFleetState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#name-1">EmrInstanceFleet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EmrInstanceFleetState<'ClusterId>, value: string) : EmrInstanceFleetState<'ClusterId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : EmrInstanceFleetState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#target_on_demand_capacity-1">EmrInstanceFleet#target_on_demand_capacity</a>.
        /// </summary>
        [<CustomOperation "target_on_demand_capacity">]
        member _.TargetOnDemandCapacity(state: EmrInstanceFleetState<'ClusterId>, value: double) : EmrInstanceFleetState<'ClusterId> =
            state.assignments.Add(fun config -> config.TargetOnDemandCapacity <- value)
            state : EmrInstanceFleetState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#target_spot_capacity-1">EmrInstanceFleet#target_spot_capacity</a>.
        /// </summary>
        [<CustomOperation "target_spot_capacity">]
        member _.TargetSpotCapacity(state: EmrInstanceFleetState<'ClusterId>, value: double) : EmrInstanceFleetState<'ClusterId> =
            state.assignments.Add(fun config -> config.TargetSpotCapacity <- value)
            state : EmrInstanceFleetState<'ClusterId>

        member _.Run(state: EmrInstanceFleetState<Present>) : aws.EmrInstanceFleet.EmrInstanceFleet =
            let config = aws.EmrInstanceFleet.EmrInstanceFleetConfig()
            for setter in state.assignments do
                setter config
            aws.EmrInstanceFleet.EmrInstanceFleet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.emrInstanceFleet: missing required arguments. Must call: cluster_id.", 9999, IsError = true)>]
        member _.Run(_: EmrInstanceFleetState<_>) : aws.EmrInstanceFleet.EmrInstanceFleet =
            Unchecked.defaultof<aws.EmrInstanceFleet.EmrInstanceFleet>
