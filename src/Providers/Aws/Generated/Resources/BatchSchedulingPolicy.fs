namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BatchSchedulingPolicyState<'Name> = { assignments: ResizeArray<aws.BatchSchedulingPolicy.BatchSchedulingPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy">aws_batch_scheduling_policy</a>.
    /// </summary>
    type BatchSchedulingPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : BatchSchedulingPolicyState<Missing> =
            ({ assignments = ResizeArray() } : BatchSchedulingPolicyState<Missing>)

        member _.Zero(()) : BatchSchedulingPolicyState<Missing> =
            ({ assignments = ResizeArray() } : BatchSchedulingPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#name-1">BatchSchedulingPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BatchSchedulingPolicyState<Missing>, value: string) : BatchSchedulingPolicyState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BatchSchedulingPolicyState<Present>)

        /// <summary>
        /// fair_share_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#fair_share_policy-1">BatchSchedulingPolicy#fair_share_policy</a>
        /// </summary>
        [<CustomOperation "fair_share_policy">]
        member _.FairSharePolicy(state: BatchSchedulingPolicyState<'Name>, value: aws.BatchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicy) : BatchSchedulingPolicyState<'Name> =
            state.assignments.Add(fun config -> config.FairSharePolicy <- value)
            state : BatchSchedulingPolicyState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#id-1">BatchSchedulingPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BatchSchedulingPolicyState<'Name>, value: string) : BatchSchedulingPolicyState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BatchSchedulingPolicyState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#tags-1">BatchSchedulingPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BatchSchedulingPolicyState<'Name>, value: seq<string * string>) : BatchSchedulingPolicyState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BatchSchedulingPolicyState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#tags_all-1">BatchSchedulingPolicy#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: BatchSchedulingPolicyState<'Name>, value: seq<string * string>) : BatchSchedulingPolicyState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : BatchSchedulingPolicyState<'Name>

        member _.Run(state: BatchSchedulingPolicyState<Present>) : aws.BatchSchedulingPolicy.BatchSchedulingPolicy =
            let config = aws.BatchSchedulingPolicy.BatchSchedulingPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.BatchSchedulingPolicy.BatchSchedulingPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.batchSchedulingPolicy: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: BatchSchedulingPolicyState<_>) : aws.BatchSchedulingPolicy.BatchSchedulingPolicy =
            Unchecked.defaultof<aws.BatchSchedulingPolicy.BatchSchedulingPolicy>
