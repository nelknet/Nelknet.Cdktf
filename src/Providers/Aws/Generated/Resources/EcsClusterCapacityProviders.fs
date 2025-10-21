namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcsClusterCapacityProvidersState<'ClusterName> = { assignments: ResizeArray<aws.EcsClusterCapacityProviders.EcsClusterCapacityProvidersConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster_capacity_providers">aws_ecs_cluster_capacity_providers</a>.
    /// </summary>
    type EcsClusterCapacityProvidersBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcsClusterCapacityProvidersState<Missing> =
            ({ assignments = ResizeArray() } : EcsClusterCapacityProvidersState<Missing>)

        member _.Zero(()) : EcsClusterCapacityProvidersState<Missing> =
            ({ assignments = ResizeArray() } : EcsClusterCapacityProvidersState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster_capacity_providers#cluster_name-1">EcsClusterCapacityProviders#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: EcsClusterCapacityProvidersState<Missing>, value: string) : EcsClusterCapacityProvidersState<Present> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : EcsClusterCapacityProvidersState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster_capacity_providers#capacity_providers-1">EcsClusterCapacityProviders#capacity_providers</a>.
        /// </summary>
        [<CustomOperation "capacity_providers">]
        member _.CapacityProviders(state: EcsClusterCapacityProvidersState<'ClusterName>, value: seq<string>) : EcsClusterCapacityProvidersState<'ClusterName> =
            state.assignments.Add(fun config -> config.CapacityProviders <- (value |> Seq.toArray))
            state : EcsClusterCapacityProvidersState<'ClusterName>

        /// <summary>
        /// default_capacity_provider_strategy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster_capacity_providers#default_capacity_provider_strategy-1">EcsClusterCapacityProviders#default_capacity_provider_strategy</a> Accepts: aws.IResolvable | aws.EcsClusterCapacityProviders.EcsClusterCapacityProvidersDefaultCapacityProviderStrategy[]
        /// </summary>
        [<CustomOperation "default_capacity_provider_strategy">]
        member _.DefaultCapacityProviderStrategy(state: EcsClusterCapacityProvidersState<'ClusterName>, value: HashiCorp.Cdktf.IResolvable) : EcsClusterCapacityProvidersState<'ClusterName> =
            state.assignments.Add(fun config -> config.DefaultCapacityProviderStrategy <- value)
            state : EcsClusterCapacityProvidersState<'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster_capacity_providers#id-1">EcsClusterCapacityProviders#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcsClusterCapacityProvidersState<'ClusterName>, value: string) : EcsClusterCapacityProvidersState<'ClusterName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcsClusterCapacityProvidersState<'ClusterName>

        member _.Run(state: EcsClusterCapacityProvidersState<Present>) : aws.EcsClusterCapacityProviders.EcsClusterCapacityProviders =
            let config = aws.EcsClusterCapacityProviders.EcsClusterCapacityProvidersConfig()
            for setter in state.assignments do
                setter config
            aws.EcsClusterCapacityProviders.EcsClusterCapacityProviders(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecsClusterCapacityProviders: missing required arguments. Must call: cluster_name.", 9999, IsError = true)>]
        member _.Run(_: EcsClusterCapacityProvidersState<_>) : aws.EcsClusterCapacityProviders.EcsClusterCapacityProviders =
            Unchecked.defaultof<aws.EcsClusterCapacityProviders.EcsClusterCapacityProviders>
