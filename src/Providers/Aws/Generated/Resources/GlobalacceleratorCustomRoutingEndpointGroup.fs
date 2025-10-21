namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, 'ListenerArn> = { assignments: ResizeArray<aws.GlobalacceleratorCustomRoutingEndpointGroup.GlobalacceleratorCustomRoutingEndpointGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_endpoint_group">aws_globalaccelerator_custom_routing_endpoint_group</a>.
    /// </summary>
    type GlobalacceleratorCustomRoutingEndpointGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlobalacceleratorCustomRoutingEndpointGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GlobalacceleratorCustomRoutingEndpointGroupState<Missing, Missing>)

        member _.Zero(()) : GlobalacceleratorCustomRoutingEndpointGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GlobalacceleratorCustomRoutingEndpointGroupState<Missing, Missing>)

        /// <summary>
        /// destination_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_endpoint_group#destination_configuration-1">GlobalacceleratorCustomRoutingEndpointGroup#destination_configuration</a> Accepts: aws.IResolvable | aws.GlobalacceleratorCustomRoutingEndpointGroup.GlobalacceleratorCustomRoutingEndpointGroupDestinationConfiguration[]
        /// </summary>
        [<CustomOperation "destination_configuration">]
        member _.DestinationConfiguration(state: GlobalacceleratorCustomRoutingEndpointGroupState<Missing, 'ListenerArn>, value: HashiCorp.Cdktf.IResolvable) : GlobalacceleratorCustomRoutingEndpointGroupState<Present, 'ListenerArn> =
            state.assignments.Add(fun config -> config.DestinationConfiguration <- value)
            ({ assignments = state.assignments } : GlobalacceleratorCustomRoutingEndpointGroupState<Present, 'ListenerArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_endpoint_group#listener_arn-1">GlobalacceleratorCustomRoutingEndpointGroup#listener_arn</a>.
        /// </summary>
        [<CustomOperation "listener_arn">]
        member _.ListenerArn(state: GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, Missing>, value: string) : GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, Present> =
            state.assignments.Add(fun config -> config.ListenerArn <- value)
            ({ assignments = state.assignments } : GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, Present>)

        /// <summary>
        /// endpoint_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_endpoint_group#endpoint_configuration-1">GlobalacceleratorCustomRoutingEndpointGroup#endpoint_configuration</a> Accepts: aws.IResolvable | aws.GlobalacceleratorCustomRoutingEndpointGroup.GlobalacceleratorCustomRoutingEndpointGroupEndpointConfiguration[]
        /// </summary>
        [<CustomOperation "endpoint_configuration">]
        member _.EndpointConfiguration(state: GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, 'ListenerArn>, value: HashiCorp.Cdktf.IResolvable) : GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, 'ListenerArn> =
            state.assignments.Add(fun config -> config.EndpointConfiguration <- value)
            state : GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, 'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_endpoint_group#endpoint_group_region-1">GlobalacceleratorCustomRoutingEndpointGroup#endpoint_group_region</a>.
        /// </summary>
        [<CustomOperation "endpoint_group_region">]
        member _.EndpointGroupRegion(state: GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, 'ListenerArn>, value: string) : GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, 'ListenerArn> =
            state.assignments.Add(fun config -> config.EndpointGroupRegion <- value)
            state : GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, 'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_endpoint_group#id-1">GlobalacceleratorCustomRoutingEndpointGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, 'ListenerArn>, value: string) : GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, 'ListenerArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, 'ListenerArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_endpoint_group#timeouts-1">GlobalacceleratorCustomRoutingEndpointGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, 'ListenerArn>, value: aws.GlobalacceleratorCustomRoutingEndpointGroup.GlobalacceleratorCustomRoutingEndpointGroupTimeouts) : GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, 'ListenerArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GlobalacceleratorCustomRoutingEndpointGroupState<'DestinationConfiguration, 'ListenerArn>

        member _.Run(state: GlobalacceleratorCustomRoutingEndpointGroupState<Present, Present>) : aws.GlobalacceleratorCustomRoutingEndpointGroup.GlobalacceleratorCustomRoutingEndpointGroup =
            let config = aws.GlobalacceleratorCustomRoutingEndpointGroup.GlobalacceleratorCustomRoutingEndpointGroupConfig()
            for setter in state.assignments do
                setter config
            aws.GlobalacceleratorCustomRoutingEndpointGroup.GlobalacceleratorCustomRoutingEndpointGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.globalacceleratorCustomRoutingEndpointGroup: missing required arguments. Must call: destination_configuration, listener_arn.", 9999, IsError = true)>]
        member _.Run(_: GlobalacceleratorCustomRoutingEndpointGroupState<_, _>) : aws.GlobalacceleratorCustomRoutingEndpointGroup.GlobalacceleratorCustomRoutingEndpointGroup =
            Unchecked.defaultof<aws.GlobalacceleratorCustomRoutingEndpointGroup.GlobalacceleratorCustomRoutingEndpointGroup>
