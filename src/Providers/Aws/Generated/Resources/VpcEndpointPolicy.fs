namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcEndpointPolicyState<'VpcEndpointId> = { assignments: ResizeArray<aws.VpcEndpointPolicy.VpcEndpointPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_policy">aws_vpc_endpoint_policy</a>.
    /// </summary>
    type VpcEndpointPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcEndpointPolicyState<Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointPolicyState<Missing>)

        member _.Zero(()) : VpcEndpointPolicyState<Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_policy#vpc_endpoint_id-1">VpcEndpointPolicy#vpc_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_id">]
        member _.VpcEndpointId(state: VpcEndpointPolicyState<Missing>, value: string) : VpcEndpointPolicyState<Present> =
            state.assignments.Add(fun config -> config.VpcEndpointId <- value)
            ({ assignments = state.assignments } : VpcEndpointPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_policy#id-1">VpcEndpointPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcEndpointPolicyState<'VpcEndpointId>, value: string) : VpcEndpointPolicyState<'VpcEndpointId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcEndpointPolicyState<'VpcEndpointId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_policy#policy-1">VpcEndpointPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: VpcEndpointPolicyState<'VpcEndpointId>, value: string) : VpcEndpointPolicyState<'VpcEndpointId> =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : VpcEndpointPolicyState<'VpcEndpointId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_policy#timeouts-1">VpcEndpointPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcEndpointPolicyState<'VpcEndpointId>, value: aws.VpcEndpointPolicy.VpcEndpointPolicyTimeouts) : VpcEndpointPolicyState<'VpcEndpointId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcEndpointPolicyState<'VpcEndpointId>

        member _.Run(state: VpcEndpointPolicyState<Present>) : aws.VpcEndpointPolicy.VpcEndpointPolicy =
            let config = aws.VpcEndpointPolicy.VpcEndpointPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.VpcEndpointPolicy.VpcEndpointPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcEndpointPolicy: missing required arguments. Must call: vpc_endpoint_id.", 9999, IsError = true)>]
        member _.Run(_: VpcEndpointPolicyState<_>) : aws.VpcEndpointPolicy.VpcEndpointPolicy =
            Unchecked.defaultof<aws.VpcEndpointPolicy.VpcEndpointPolicy>
