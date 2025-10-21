namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcsCapacityProviderState<'AutoScalingGroupProvider, 'Name> = { assignments: ResizeArray<aws.EcsCapacityProvider.EcsCapacityProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider">aws_ecs_capacity_provider</a>.
    /// </summary>
    type EcsCapacityProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcsCapacityProviderState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcsCapacityProviderState<Missing, Missing>)

        member _.Zero(()) : EcsCapacityProviderState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcsCapacityProviderState<Missing, Missing>)

        /// <summary>
        /// auto_scaling_group_provider block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#auto_scaling_group_provider-1">EcsCapacityProvider#auto_scaling_group_provider</a>
        /// </summary>
        [<CustomOperation "auto_scaling_group_provider">]
        member _.AutoScalingGroupProvider(state: EcsCapacityProviderState<Missing, 'Name>, value: aws.EcsCapacityProvider.EcsCapacityProviderAutoScalingGroupProvider) : EcsCapacityProviderState<Present, 'Name> =
            state.assignments.Add(fun config -> config.AutoScalingGroupProvider <- value)
            ({ assignments = state.assignments } : EcsCapacityProviderState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#name-1">EcsCapacityProvider#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EcsCapacityProviderState<'AutoScalingGroupProvider, Missing>, value: string) : EcsCapacityProviderState<'AutoScalingGroupProvider, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EcsCapacityProviderState<'AutoScalingGroupProvider, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#id-1">EcsCapacityProvider#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcsCapacityProviderState<'AutoScalingGroupProvider, 'Name>, value: string) : EcsCapacityProviderState<'AutoScalingGroupProvider, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcsCapacityProviderState<'AutoScalingGroupProvider, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#tags-1">EcsCapacityProvider#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EcsCapacityProviderState<'AutoScalingGroupProvider, 'Name>, value: seq<string * string>) : EcsCapacityProviderState<'AutoScalingGroupProvider, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EcsCapacityProviderState<'AutoScalingGroupProvider, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#tags_all-1">EcsCapacityProvider#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EcsCapacityProviderState<'AutoScalingGroupProvider, 'Name>, value: seq<string * string>) : EcsCapacityProviderState<'AutoScalingGroupProvider, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EcsCapacityProviderState<'AutoScalingGroupProvider, 'Name>

        member _.Run(state: EcsCapacityProviderState<Present, Present>) : aws.EcsCapacityProvider.EcsCapacityProvider =
            let config = aws.EcsCapacityProvider.EcsCapacityProviderConfig()
            for setter in state.assignments do
                setter config
            aws.EcsCapacityProvider.EcsCapacityProvider(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecsCapacityProvider: missing required arguments. Must call: auto_scaling_group_provider, name.", 9999, IsError = true)>]
        member _.Run(_: EcsCapacityProviderState<_, _>) : aws.EcsCapacityProvider.EcsCapacityProvider =
            Unchecked.defaultof<aws.EcsCapacityProvider.EcsCapacityProvider>
