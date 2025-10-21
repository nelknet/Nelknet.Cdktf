namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TrafficMirrorTargetState = { assignments: ResizeArray<aws.Ec2TrafficMirrorTarget.Ec2TrafficMirrorTargetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_target">aws_ec2_traffic_mirror_target</a>.
    /// </summary>
    type Ec2TrafficMirrorTargetBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TrafficMirrorTargetState =
            { assignments = ResizeArray() }

        member _.Zero(()) : Ec2TrafficMirrorTargetState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_target#description-1">Ec2TrafficMirrorTarget#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Ec2TrafficMirrorTargetState, value: string) : Ec2TrafficMirrorTargetState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Ec2TrafficMirrorTargetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_target#gateway_load_balancer_endpoint_id-1">Ec2TrafficMirrorTarget#gateway_load_balancer_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "gateway_load_balancer_endpoint_id">]
        member _.GatewayLoadBalancerEndpointId(state: Ec2TrafficMirrorTargetState, value: string) : Ec2TrafficMirrorTargetState =
            state.assignments.Add(fun config -> config.GatewayLoadBalancerEndpointId <- value)
            state : Ec2TrafficMirrorTargetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_target#id-1">Ec2TrafficMirrorTarget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TrafficMirrorTargetState, value: string) : Ec2TrafficMirrorTargetState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TrafficMirrorTargetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_target#network_interface_id-1">Ec2TrafficMirrorTarget#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: Ec2TrafficMirrorTargetState, value: string) : Ec2TrafficMirrorTargetState =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            state : Ec2TrafficMirrorTargetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_target#network_load_balancer_arn-1">Ec2TrafficMirrorTarget#network_load_balancer_arn</a>.
        /// </summary>
        [<CustomOperation "network_load_balancer_arn">]
        member _.NetworkLoadBalancerArn(state: Ec2TrafficMirrorTargetState, value: string) : Ec2TrafficMirrorTargetState =
            state.assignments.Add(fun config -> config.NetworkLoadBalancerArn <- value)
            state : Ec2TrafficMirrorTargetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_target#tags-1">Ec2TrafficMirrorTarget#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2TrafficMirrorTargetState, value: seq<string * string>) : Ec2TrafficMirrorTargetState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2TrafficMirrorTargetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_target#tags_all-1">Ec2TrafficMirrorTarget#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2TrafficMirrorTargetState, value: seq<string * string>) : Ec2TrafficMirrorTargetState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2TrafficMirrorTargetState

        member _.Run(state: Ec2TrafficMirrorTargetState) : aws.Ec2TrafficMirrorTarget.Ec2TrafficMirrorTarget =
            let config = aws.Ec2TrafficMirrorTarget.Ec2TrafficMirrorTargetConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TrafficMirrorTarget.Ec2TrafficMirrorTarget(StackContext.get (), logicalId, config)
