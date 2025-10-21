namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53RecoverycontrolconfigControlPanelState<'ClusterArn, 'Name> = { assignments: ResizeArray<aws.Route53RecoverycontrolconfigControlPanel.Route53RecoverycontrolconfigControlPanelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_control_panel">aws_route53recoverycontrolconfig_control_panel</a>.
    /// </summary>
    type Route53RecoverycontrolconfigControlPanelBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53RecoverycontrolconfigControlPanelState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53RecoverycontrolconfigControlPanelState<Missing, Missing>)

        member _.Zero(()) : Route53RecoverycontrolconfigControlPanelState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53RecoverycontrolconfigControlPanelState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_control_panel#cluster_arn-1">Route53RecoverycontrolconfigControlPanel#cluster_arn</a>.
        /// </summary>
        [<CustomOperation "cluster_arn">]
        member _.ClusterArn(state: Route53RecoverycontrolconfigControlPanelState<Missing, 'Name>, value: string) : Route53RecoverycontrolconfigControlPanelState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ClusterArn <- value)
            ({ assignments = state.assignments } : Route53RecoverycontrolconfigControlPanelState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_control_panel#name-1">Route53RecoverycontrolconfigControlPanel#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53RecoverycontrolconfigControlPanelState<'ClusterArn, Missing>, value: string) : Route53RecoverycontrolconfigControlPanelState<'ClusterArn, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53RecoverycontrolconfigControlPanelState<'ClusterArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_control_panel#id-1">Route53RecoverycontrolconfigControlPanel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53RecoverycontrolconfigControlPanelState<'ClusterArn, 'Name>, value: string) : Route53RecoverycontrolconfigControlPanelState<'ClusterArn, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53RecoverycontrolconfigControlPanelState<'ClusterArn, 'Name>

        member _.Run(state: Route53RecoverycontrolconfigControlPanelState<Present, Present>) : aws.Route53RecoverycontrolconfigControlPanel.Route53RecoverycontrolconfigControlPanel =
            let config = aws.Route53RecoverycontrolconfigControlPanel.Route53RecoverycontrolconfigControlPanelConfig()
            for setter in state.assignments do
                setter config
            aws.Route53RecoverycontrolconfigControlPanel.Route53RecoverycontrolconfigControlPanel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53RecoverycontrolconfigControlPanel: missing required arguments. Must call: cluster_arn, name.", 9999, IsError = true)>]
        member _.Run(_: Route53RecoverycontrolconfigControlPanelState<_, _>) : aws.Route53RecoverycontrolconfigControlPanel.Route53RecoverycontrolconfigControlPanel =
            Unchecked.defaultof<aws.Route53RecoverycontrolconfigControlPanel.Route53RecoverycontrolconfigControlPanel>
