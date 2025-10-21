namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53RecoverycontrolconfigClusterState<'Name> = { assignments: ResizeArray<aws.Route53RecoverycontrolconfigCluster.Route53RecoverycontrolconfigClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_cluster">aws_route53recoverycontrolconfig_cluster</a>.
    /// </summary>
    type Route53RecoverycontrolconfigClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53RecoverycontrolconfigClusterState<Missing> =
            ({ assignments = ResizeArray() } : Route53RecoverycontrolconfigClusterState<Missing>)

        member _.Zero(()) : Route53RecoverycontrolconfigClusterState<Missing> =
            ({ assignments = ResizeArray() } : Route53RecoverycontrolconfigClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_cluster#name-1">Route53RecoverycontrolconfigCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53RecoverycontrolconfigClusterState<Missing>, value: string) : Route53RecoverycontrolconfigClusterState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53RecoverycontrolconfigClusterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_cluster#id-1">Route53RecoverycontrolconfigCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53RecoverycontrolconfigClusterState<'Name>, value: string) : Route53RecoverycontrolconfigClusterState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53RecoverycontrolconfigClusterState<'Name>

        member _.Run(state: Route53RecoverycontrolconfigClusterState<Present>) : aws.Route53RecoverycontrolconfigCluster.Route53RecoverycontrolconfigCluster =
            let config = aws.Route53RecoverycontrolconfigCluster.Route53RecoverycontrolconfigClusterConfig()
            for setter in state.assignments do
                setter config
            aws.Route53RecoverycontrolconfigCluster.Route53RecoverycontrolconfigCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53RecoverycontrolconfigCluster: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: Route53RecoverycontrolconfigClusterState<_>) : aws.Route53RecoverycontrolconfigCluster.Route53RecoverycontrolconfigCluster =
            Unchecked.defaultof<aws.Route53RecoverycontrolconfigCluster.Route53RecoverycontrolconfigCluster>
