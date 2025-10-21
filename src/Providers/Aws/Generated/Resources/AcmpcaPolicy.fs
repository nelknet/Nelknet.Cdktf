namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AcmpcaPolicyState<'Policy, 'ResourceArn> = { assignments: ResizeArray<aws.AcmpcaPolicy.AcmpcaPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_policy">aws_acmpca_policy</a>.
    /// </summary>
    type AcmpcaPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : AcmpcaPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AcmpcaPolicyState<Missing, Missing>)

        member _.Zero(()) : AcmpcaPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AcmpcaPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_policy#policy-1">AcmpcaPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: AcmpcaPolicyState<Missing, 'ResourceArn>, value: string) : AcmpcaPolicyState<Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : AcmpcaPolicyState<Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_policy#resource_arn-1">AcmpcaPolicy#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: AcmpcaPolicyState<'Policy, Missing>, value: string) : AcmpcaPolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : AcmpcaPolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_policy#id-1">AcmpcaPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AcmpcaPolicyState<'Policy, 'ResourceArn>, value: string) : AcmpcaPolicyState<'Policy, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AcmpcaPolicyState<'Policy, 'ResourceArn>

        member _.Run(state: AcmpcaPolicyState<Present, Present>) : aws.AcmpcaPolicy.AcmpcaPolicy =
            let config = aws.AcmpcaPolicy.AcmpcaPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.AcmpcaPolicy.AcmpcaPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.acmpcaPolicy: missing required arguments. Must call: policy, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: AcmpcaPolicyState<_, _>) : aws.AcmpcaPolicy.AcmpcaPolicy =
            Unchecked.defaultof<aws.AcmpcaPolicy.AcmpcaPolicy>
