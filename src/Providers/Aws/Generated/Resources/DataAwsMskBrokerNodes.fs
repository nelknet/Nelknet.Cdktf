namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMskBrokerNodesState<'ClusterArn> = { assignments: ResizeArray<aws.DataAwsMskBrokerNodes.DataAwsMskBrokerNodesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_broker_nodes">aws_msk_broker_nodes</a>.
    /// </summary>
    type DataAwsMskBrokerNodesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMskBrokerNodesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskBrokerNodesState<Missing>)

        member _.Zero(()) : DataAwsMskBrokerNodesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskBrokerNodesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_broker_nodes#cluster_arn-1">DataAwsMskBrokerNodes#cluster_arn</a>.
        /// </summary>
        [<CustomOperation "cluster_arn">]
        member _.ClusterArn(state: DataAwsMskBrokerNodesState<Missing>, value: string) : DataAwsMskBrokerNodesState<Present> =
            state.assignments.Add(fun config -> config.ClusterArn <- value)
            ({ assignments = state.assignments } : DataAwsMskBrokerNodesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_broker_nodes#id-1">DataAwsMskBrokerNodes#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMskBrokerNodesState<'ClusterArn>, value: string) : DataAwsMskBrokerNodesState<'ClusterArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMskBrokerNodesState<'ClusterArn>

        member _.Run(state: DataAwsMskBrokerNodesState<Present>) : aws.DataAwsMskBrokerNodes.DataAwsMskBrokerNodes =
            let config = aws.DataAwsMskBrokerNodes.DataAwsMskBrokerNodesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMskBrokerNodes.DataAwsMskBrokerNodes(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMskBrokerNodes: missing required arguments. Must call: cluster_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMskBrokerNodesState<_>) : aws.DataAwsMskBrokerNodes.DataAwsMskBrokerNodes =
            Unchecked.defaultof<aws.DataAwsMskBrokerNodes.DataAwsMskBrokerNodes>
