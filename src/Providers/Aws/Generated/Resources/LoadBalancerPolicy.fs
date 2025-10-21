namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LoadBalancerPolicyState<'LoadBalancerName, 'PolicyName, 'PolicyTypeName> = { assignments: ResizeArray<aws.LoadBalancerPolicy.LoadBalancerPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_policy">aws_load_balancer_policy</a>.
    /// </summary>
    type LoadBalancerPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : LoadBalancerPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LoadBalancerPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : LoadBalancerPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LoadBalancerPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_policy#load_balancer_name-1">LoadBalancerPolicy#load_balancer_name</a>.
        /// </summary>
        [<CustomOperation "load_balancer_name">]
        member _.LoadBalancerName(state: LoadBalancerPolicyState<Missing, 'PolicyName, 'PolicyTypeName>, value: string) : LoadBalancerPolicyState<Present, 'PolicyName, 'PolicyTypeName> =
            state.assignments.Add(fun config -> config.LoadBalancerName <- value)
            ({ assignments = state.assignments } : LoadBalancerPolicyState<Present, 'PolicyName, 'PolicyTypeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_policy#policy_name-1">LoadBalancerPolicy#policy_name</a>.
        /// </summary>
        [<CustomOperation "policy_name">]
        member _.PolicyName(state: LoadBalancerPolicyState<'LoadBalancerName, Missing, 'PolicyTypeName>, value: string) : LoadBalancerPolicyState<'LoadBalancerName, Present, 'PolicyTypeName> =
            state.assignments.Add(fun config -> config.PolicyName <- value)
            ({ assignments = state.assignments } : LoadBalancerPolicyState<'LoadBalancerName, Present, 'PolicyTypeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_policy#policy_type_name-1">LoadBalancerPolicy#policy_type_name</a>.
        /// </summary>
        [<CustomOperation "policy_type_name">]
        member _.PolicyTypeName(state: LoadBalancerPolicyState<'LoadBalancerName, 'PolicyName, Missing>, value: string) : LoadBalancerPolicyState<'LoadBalancerName, 'PolicyName, Present> =
            state.assignments.Add(fun config -> config.PolicyTypeName <- value)
            ({ assignments = state.assignments } : LoadBalancerPolicyState<'LoadBalancerName, 'PolicyName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_policy#id-1">LoadBalancerPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LoadBalancerPolicyState<'LoadBalancerName, 'PolicyName, 'PolicyTypeName>, value: string) : LoadBalancerPolicyState<'LoadBalancerName, 'PolicyName, 'PolicyTypeName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LoadBalancerPolicyState<'LoadBalancerName, 'PolicyName, 'PolicyTypeName>

        /// <summary>
        /// policy_attribute block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_policy#policy_attribute-1">LoadBalancerPolicy#policy_attribute</a> Accepts: aws.IResolvable | aws.LoadBalancerPolicy.LoadBalancerPolicyPolicyAttribute[]
        /// </summary>
        [<CustomOperation "policy_attribute">]
        member _.PolicyAttribute(state: LoadBalancerPolicyState<'LoadBalancerName, 'PolicyName, 'PolicyTypeName>, value: HashiCorp.Cdktf.IResolvable) : LoadBalancerPolicyState<'LoadBalancerName, 'PolicyName, 'PolicyTypeName> =
            state.assignments.Add(fun config -> config.PolicyAttribute <- value)
            state : LoadBalancerPolicyState<'LoadBalancerName, 'PolicyName, 'PolicyTypeName>

        member _.Run(state: LoadBalancerPolicyState<Present, Present, Present>) : aws.LoadBalancerPolicy.LoadBalancerPolicy =
            let config = aws.LoadBalancerPolicy.LoadBalancerPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.LoadBalancerPolicy.LoadBalancerPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.loadBalancerPolicy: missing required arguments. Must call: load_balancer_name, policy_name, policy_type_name.", 9999, IsError = true)>]
        member _.Run(_: LoadBalancerPolicyState<_, _, _>) : aws.LoadBalancerPolicy.LoadBalancerPolicy =
            Unchecked.defaultof<aws.LoadBalancerPolicy.LoadBalancerPolicy>
