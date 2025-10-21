namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBatchSchedulingPolicyState<'Arn> = { assignments: ResizeArray<aws.DataAwsBatchSchedulingPolicy.DataAwsBatchSchedulingPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_scheduling_policy">aws_batch_scheduling_policy</a>.
    /// </summary>
    type DataAwsBatchSchedulingPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBatchSchedulingPolicyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBatchSchedulingPolicyState<Missing>)

        member _.Zero(()) : DataAwsBatchSchedulingPolicyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBatchSchedulingPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_scheduling_policy#arn-1">DataAwsBatchSchedulingPolicy#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsBatchSchedulingPolicyState<Missing>, value: string) : DataAwsBatchSchedulingPolicyState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsBatchSchedulingPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_scheduling_policy#id-1">DataAwsBatchSchedulingPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsBatchSchedulingPolicyState<'Arn>, value: string) : DataAwsBatchSchedulingPolicyState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsBatchSchedulingPolicyState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_scheduling_policy#tags-1">DataAwsBatchSchedulingPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsBatchSchedulingPolicyState<'Arn>, value: seq<string * string>) : DataAwsBatchSchedulingPolicyState<'Arn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsBatchSchedulingPolicyState<'Arn>

        member _.Run(state: DataAwsBatchSchedulingPolicyState<Present>) : aws.DataAwsBatchSchedulingPolicy.DataAwsBatchSchedulingPolicy =
            let config = aws.DataAwsBatchSchedulingPolicy.DataAwsBatchSchedulingPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBatchSchedulingPolicy.DataAwsBatchSchedulingPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsBatchSchedulingPolicy: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsBatchSchedulingPolicyState<_>) : aws.DataAwsBatchSchedulingPolicy.DataAwsBatchSchedulingPolicy =
            Unchecked.defaultof<aws.DataAwsBatchSchedulingPolicy.DataAwsBatchSchedulingPolicy>
