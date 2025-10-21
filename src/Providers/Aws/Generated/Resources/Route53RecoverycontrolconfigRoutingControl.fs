namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53RecoverycontrolconfigRoutingControlState<'ClusterArn, 'Name> = { assignments: ResizeArray<aws.Route53RecoverycontrolconfigRoutingControl.Route53RecoverycontrolconfigRoutingControlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_routing_control">aws_route53recoverycontrolconfig_routing_control</a>.
    /// </summary>
    type Route53RecoverycontrolconfigRoutingControlBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53RecoverycontrolconfigRoutingControlState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53RecoverycontrolconfigRoutingControlState<Missing, Missing>)

        member _.Zero(()) : Route53RecoverycontrolconfigRoutingControlState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53RecoverycontrolconfigRoutingControlState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_routing_control#cluster_arn-1">Route53RecoverycontrolconfigRoutingControl#cluster_arn</a>.
        /// </summary>
        [<CustomOperation "cluster_arn">]
        member _.ClusterArn(state: Route53RecoverycontrolconfigRoutingControlState<Missing, 'Name>, value: string) : Route53RecoverycontrolconfigRoutingControlState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ClusterArn <- value)
            ({ assignments = state.assignments } : Route53RecoverycontrolconfigRoutingControlState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_routing_control#name-1">Route53RecoverycontrolconfigRoutingControl#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53RecoverycontrolconfigRoutingControlState<'ClusterArn, Missing>, value: string) : Route53RecoverycontrolconfigRoutingControlState<'ClusterArn, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53RecoverycontrolconfigRoutingControlState<'ClusterArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_routing_control#control_panel_arn-1">Route53RecoverycontrolconfigRoutingControl#control_panel_arn</a>.
        /// </summary>
        [<CustomOperation "control_panel_arn">]
        member _.ControlPanelArn(state: Route53RecoverycontrolconfigRoutingControlState<'ClusterArn, 'Name>, value: string) : Route53RecoverycontrolconfigRoutingControlState<'ClusterArn, 'Name> =
            state.assignments.Add(fun config -> config.ControlPanelArn <- value)
            state : Route53RecoverycontrolconfigRoutingControlState<'ClusterArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_routing_control#id-1">Route53RecoverycontrolconfigRoutingControl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53RecoverycontrolconfigRoutingControlState<'ClusterArn, 'Name>, value: string) : Route53RecoverycontrolconfigRoutingControlState<'ClusterArn, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53RecoverycontrolconfigRoutingControlState<'ClusterArn, 'Name>

        member _.Run(state: Route53RecoverycontrolconfigRoutingControlState<Present, Present>) : aws.Route53RecoverycontrolconfigRoutingControl.Route53RecoverycontrolconfigRoutingControl =
            let config = aws.Route53RecoverycontrolconfigRoutingControl.Route53RecoverycontrolconfigRoutingControlConfig()
            for setter in state.assignments do
                setter config
            aws.Route53RecoverycontrolconfigRoutingControl.Route53RecoverycontrolconfigRoutingControl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53RecoverycontrolconfigRoutingControl: missing required arguments. Must call: cluster_arn, name.", 9999, IsError = true)>]
        member _.Run(_: Route53RecoverycontrolconfigRoutingControlState<_, _>) : aws.Route53RecoverycontrolconfigRoutingControl.Route53RecoverycontrolconfigRoutingControl =
            Unchecked.defaultof<aws.Route53RecoverycontrolconfigRoutingControl.Route53RecoverycontrolconfigRoutingControl>
