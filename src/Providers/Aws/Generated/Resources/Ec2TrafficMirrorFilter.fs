namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TrafficMirrorFilterState = { assignments: ResizeArray<aws.Ec2TrafficMirrorFilter.Ec2TrafficMirrorFilterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter">aws_ec2_traffic_mirror_filter</a>.
    /// </summary>
    type Ec2TrafficMirrorFilterBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TrafficMirrorFilterState =
            { assignments = ResizeArray() }

        member _.Zero(()) : Ec2TrafficMirrorFilterState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter#description-1">Ec2TrafficMirrorFilter#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Ec2TrafficMirrorFilterState, value: string) : Ec2TrafficMirrorFilterState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Ec2TrafficMirrorFilterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter#id-1">Ec2TrafficMirrorFilter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TrafficMirrorFilterState, value: string) : Ec2TrafficMirrorFilterState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TrafficMirrorFilterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter#network_services-1">Ec2TrafficMirrorFilter#network_services</a>.
        /// </summary>
        [<CustomOperation "network_services">]
        member _.NetworkServices(state: Ec2TrafficMirrorFilterState, value: seq<string>) : Ec2TrafficMirrorFilterState =
            state.assignments.Add(fun config -> config.NetworkServices <- (value |> Seq.toArray))
            state : Ec2TrafficMirrorFilterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter#tags-1">Ec2TrafficMirrorFilter#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2TrafficMirrorFilterState, value: seq<string * string>) : Ec2TrafficMirrorFilterState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2TrafficMirrorFilterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter#tags_all-1">Ec2TrafficMirrorFilter#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2TrafficMirrorFilterState, value: seq<string * string>) : Ec2TrafficMirrorFilterState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2TrafficMirrorFilterState

        member _.Run(state: Ec2TrafficMirrorFilterState) : aws.Ec2TrafficMirrorFilter.Ec2TrafficMirrorFilter =
            let config = aws.Ec2TrafficMirrorFilter.Ec2TrafficMirrorFilterConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TrafficMirrorFilter.Ec2TrafficMirrorFilter(StackContext.get (), logicalId, config)
