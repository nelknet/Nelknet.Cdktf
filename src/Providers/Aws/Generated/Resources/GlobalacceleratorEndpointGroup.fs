namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlobalacceleratorEndpointGroupState<'ListenerArn> = { assignments: ResizeArray<aws.GlobalacceleratorEndpointGroup.GlobalacceleratorEndpointGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_endpoint_group">aws_globalaccelerator_endpoint_group</a>.
    /// </summary>
    type GlobalacceleratorEndpointGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlobalacceleratorEndpointGroupState<Missing> =
            ({ assignments = ResizeArray() } : GlobalacceleratorEndpointGroupState<Missing>)

        member _.Zero(()) : GlobalacceleratorEndpointGroupState<Missing> =
            ({ assignments = ResizeArray() } : GlobalacceleratorEndpointGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_endpoint_group#listener_arn-1">GlobalacceleratorEndpointGroup#listener_arn</a>.
        /// </summary>
        [<CustomOperation "listener_arn">]
        member _.ListenerArn(state: GlobalacceleratorEndpointGroupState<Missing>, value: string) : GlobalacceleratorEndpointGroupState<Present> =
            state.assignments.Add(fun config -> config.ListenerArn <- value)
            ({ assignments = state.assignments } : GlobalacceleratorEndpointGroupState<Present>)

        /// <summary>
        /// endpoint_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_endpoint_group#endpoint_configuration-1">GlobalacceleratorEndpointGroup#endpoint_configuration</a> Accepts: aws.IResolvable | aws.GlobalacceleratorEndpointGroup.GlobalacceleratorEndpointGroupEndpointConfiguration[]
        /// </summary>
        [<CustomOperation "endpoint_configuration">]
        member _.EndpointConfiguration(state: GlobalacceleratorEndpointGroupState<'ListenerArn>, value: HashiCorp.Cdktf.IResolvable) : GlobalacceleratorEndpointGroupState<'ListenerArn> =
            state.assignments.Add(fun config -> config.EndpointConfiguration <- value)
            state : GlobalacceleratorEndpointGroupState<'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_endpoint_group#endpoint_group_region-1">GlobalacceleratorEndpointGroup#endpoint_group_region</a>.
        /// </summary>
        [<CustomOperation "endpoint_group_region">]
        member _.EndpointGroupRegion(state: GlobalacceleratorEndpointGroupState<'ListenerArn>, value: string) : GlobalacceleratorEndpointGroupState<'ListenerArn> =
            state.assignments.Add(fun config -> config.EndpointGroupRegion <- value)
            state : GlobalacceleratorEndpointGroupState<'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_endpoint_group#health_check_interval_seconds-1">GlobalacceleratorEndpointGroup#health_check_interval_seconds</a>.
        /// </summary>
        [<CustomOperation "health_check_interval_seconds">]
        member _.HealthCheckIntervalSeconds(state: GlobalacceleratorEndpointGroupState<'ListenerArn>, value: double) : GlobalacceleratorEndpointGroupState<'ListenerArn> =
            state.assignments.Add(fun config -> config.HealthCheckIntervalSeconds <- value)
            state : GlobalacceleratorEndpointGroupState<'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_endpoint_group#health_check_path-1">GlobalacceleratorEndpointGroup#health_check_path</a>.
        /// </summary>
        [<CustomOperation "health_check_path">]
        member _.HealthCheckPath(state: GlobalacceleratorEndpointGroupState<'ListenerArn>, value: string) : GlobalacceleratorEndpointGroupState<'ListenerArn> =
            state.assignments.Add(fun config -> config.HealthCheckPath <- value)
            state : GlobalacceleratorEndpointGroupState<'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_endpoint_group#health_check_port-1">GlobalacceleratorEndpointGroup#health_check_port</a>.
        /// </summary>
        [<CustomOperation "health_check_port">]
        member _.HealthCheckPort(state: GlobalacceleratorEndpointGroupState<'ListenerArn>, value: double) : GlobalacceleratorEndpointGroupState<'ListenerArn> =
            state.assignments.Add(fun config -> config.HealthCheckPort <- value)
            state : GlobalacceleratorEndpointGroupState<'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_endpoint_group#health_check_protocol-1">GlobalacceleratorEndpointGroup#health_check_protocol</a>.
        /// </summary>
        [<CustomOperation "health_check_protocol">]
        member _.HealthCheckProtocol(state: GlobalacceleratorEndpointGroupState<'ListenerArn>, value: string) : GlobalacceleratorEndpointGroupState<'ListenerArn> =
            state.assignments.Add(fun config -> config.HealthCheckProtocol <- value)
            state : GlobalacceleratorEndpointGroupState<'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_endpoint_group#id-1">GlobalacceleratorEndpointGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlobalacceleratorEndpointGroupState<'ListenerArn>, value: string) : GlobalacceleratorEndpointGroupState<'ListenerArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlobalacceleratorEndpointGroupState<'ListenerArn>

        /// <summary>
        /// port_override block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_endpoint_group#port_override-1">GlobalacceleratorEndpointGroup#port_override</a> Accepts: aws.IResolvable | aws.GlobalacceleratorEndpointGroup.GlobalacceleratorEndpointGroupPortOverride[]
        /// </summary>
        [<CustomOperation "port_override">]
        member _.PortOverride(state: GlobalacceleratorEndpointGroupState<'ListenerArn>, value: HashiCorp.Cdktf.IResolvable) : GlobalacceleratorEndpointGroupState<'ListenerArn> =
            state.assignments.Add(fun config -> config.PortOverride <- value)
            state : GlobalacceleratorEndpointGroupState<'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_endpoint_group#threshold_count-1">GlobalacceleratorEndpointGroup#threshold_count</a>.
        /// </summary>
        [<CustomOperation "threshold_count">]
        member _.ThresholdCount(state: GlobalacceleratorEndpointGroupState<'ListenerArn>, value: double) : GlobalacceleratorEndpointGroupState<'ListenerArn> =
            state.assignments.Add(fun config -> config.ThresholdCount <- value)
            state : GlobalacceleratorEndpointGroupState<'ListenerArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_endpoint_group#timeouts-1">GlobalacceleratorEndpointGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GlobalacceleratorEndpointGroupState<'ListenerArn>, value: aws.GlobalacceleratorEndpointGroup.GlobalacceleratorEndpointGroupTimeouts) : GlobalacceleratorEndpointGroupState<'ListenerArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GlobalacceleratorEndpointGroupState<'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_endpoint_group#traffic_dial_percentage-1">GlobalacceleratorEndpointGroup#traffic_dial_percentage</a>.
        /// </summary>
        [<CustomOperation "traffic_dial_percentage">]
        member _.TrafficDialPercentage(state: GlobalacceleratorEndpointGroupState<'ListenerArn>, value: double) : GlobalacceleratorEndpointGroupState<'ListenerArn> =
            state.assignments.Add(fun config -> config.TrafficDialPercentage <- value)
            state : GlobalacceleratorEndpointGroupState<'ListenerArn>

        member _.Run(state: GlobalacceleratorEndpointGroupState<Present>) : aws.GlobalacceleratorEndpointGroup.GlobalacceleratorEndpointGroup =
            let config = aws.GlobalacceleratorEndpointGroup.GlobalacceleratorEndpointGroupConfig()
            for setter in state.assignments do
                setter config
            aws.GlobalacceleratorEndpointGroup.GlobalacceleratorEndpointGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.globalacceleratorEndpointGroup: missing required arguments. Must call: listener_arn.", 9999, IsError = true)>]
        member _.Run(_: GlobalacceleratorEndpointGroupState<_>) : aws.GlobalacceleratorEndpointGroup.GlobalacceleratorEndpointGroup =
            Unchecked.defaultof<aws.GlobalacceleratorEndpointGroup.GlobalacceleratorEndpointGroup>
