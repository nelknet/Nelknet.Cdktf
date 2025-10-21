namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueResourcePolicyState<'Policy> = { assignments: ResizeArray<aws.GlueResourcePolicy.GlueResourcePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_resource_policy">aws_glue_resource_policy</a>.
    /// </summary>
    type GlueResourcePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueResourcePolicyState<Missing> =
            ({ assignments = ResizeArray() } : GlueResourcePolicyState<Missing>)

        member _.Zero(()) : GlueResourcePolicyState<Missing> =
            ({ assignments = ResizeArray() } : GlueResourcePolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_resource_policy#policy-1">GlueResourcePolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: GlueResourcePolicyState<Missing>, value: string) : GlueResourcePolicyState<Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : GlueResourcePolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_resource_policy#enable_hybrid-1">GlueResourcePolicy#enable_hybrid</a>.
        /// </summary>
        [<CustomOperation "enable_hybrid">]
        member _.EnableHybrid(state: GlueResourcePolicyState<'Policy>, value: string) : GlueResourcePolicyState<'Policy> =
            state.assignments.Add(fun config -> config.EnableHybrid <- value)
            state : GlueResourcePolicyState<'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_resource_policy#id-1">GlueResourcePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueResourcePolicyState<'Policy>, value: string) : GlueResourcePolicyState<'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueResourcePolicyState<'Policy>

        member _.Run(state: GlueResourcePolicyState<Present>) : aws.GlueResourcePolicy.GlueResourcePolicy =
            let config = aws.GlueResourcePolicy.GlueResourcePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.GlueResourcePolicy.GlueResourcePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueResourcePolicy: missing required arguments. Must call: policy.", 9999, IsError = true)>]
        member _.Run(_: GlueResourcePolicyState<_>) : aws.GlueResourcePolicy.GlueResourcePolicy =
            Unchecked.defaultof<aws.GlueResourcePolicy.GlueResourcePolicy>
