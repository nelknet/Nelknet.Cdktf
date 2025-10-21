namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DsqlClusterPeeringState<'Clusters, 'Identifier, 'WitnessRegion> = { assignments: ResizeArray<aws.DsqlClusterPeering.DsqlClusterPeeringConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster_peering">aws_dsql_cluster_peering</a>.
    /// </summary>
    type DsqlClusterPeeringBuilder(logicalId: string) =
        member _.Yield(_: unit) : DsqlClusterPeeringState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DsqlClusterPeeringState<Missing, Missing, Missing>)

        member _.Zero(()) : DsqlClusterPeeringState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DsqlClusterPeeringState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster_peering#clusters-1">DsqlClusterPeering#clusters</a>.
        /// </summary>
        [<CustomOperation "clusters">]
        member _.Clusters(state: DsqlClusterPeeringState<Missing, 'Identifier, 'WitnessRegion>, value: seq<string>) : DsqlClusterPeeringState<Present, 'Identifier, 'WitnessRegion> =
            state.assignments.Add(fun config -> config.Clusters <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DsqlClusterPeeringState<Present, 'Identifier, 'WitnessRegion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster_peering#identifier-1">DsqlClusterPeering#identifier</a>.
        /// </summary>
        [<CustomOperation "identifier">]
        member _.Identifier(state: DsqlClusterPeeringState<'Clusters, Missing, 'WitnessRegion>, value: string) : DsqlClusterPeeringState<'Clusters, Present, 'WitnessRegion> =
            state.assignments.Add(fun config -> config.Identifier <- value)
            ({ assignments = state.assignments } : DsqlClusterPeeringState<'Clusters, Present, 'WitnessRegion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster_peering#witness_region-1">DsqlClusterPeering#witness_region</a>.
        /// </summary>
        [<CustomOperation "witness_region">]
        member _.WitnessRegion(state: DsqlClusterPeeringState<'Clusters, 'Identifier, Missing>, value: string) : DsqlClusterPeeringState<'Clusters, 'Identifier, Present> =
            state.assignments.Add(fun config -> config.WitnessRegion <- value)
            ({ assignments = state.assignments } : DsqlClusterPeeringState<'Clusters, 'Identifier, Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster_peering#timeouts-1">DsqlClusterPeering#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DsqlClusterPeeringState<'Clusters, 'Identifier, 'WitnessRegion>, value: aws.DsqlClusterPeering.DsqlClusterPeeringTimeouts) : DsqlClusterPeeringState<'Clusters, 'Identifier, 'WitnessRegion> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DsqlClusterPeeringState<'Clusters, 'Identifier, 'WitnessRegion>

        member _.Run(state: DsqlClusterPeeringState<Present, Present, Present>) : aws.DsqlClusterPeering.DsqlClusterPeering =
            let config = aws.DsqlClusterPeering.DsqlClusterPeeringConfig()
            for setter in state.assignments do
                setter config
            aws.DsqlClusterPeering.DsqlClusterPeering(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dsqlClusterPeering: missing required arguments. Must call: clusters, identifier, witness_region.", 9999, IsError = true)>]
        member _.Run(_: DsqlClusterPeeringState<_, _, _>) : aws.DsqlClusterPeering.DsqlClusterPeering =
            Unchecked.defaultof<aws.DsqlClusterPeering.DsqlClusterPeering>
