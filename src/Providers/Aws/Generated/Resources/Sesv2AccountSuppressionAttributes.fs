namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Sesv2AccountSuppressionAttributesState<'SuppressedReasons> = { assignments: ResizeArray<aws.Sesv2AccountSuppressionAttributes.Sesv2AccountSuppressionAttributesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_account_suppression_attributes">aws_sesv2_account_suppression_attributes</a>.
    /// </summary>
    type Sesv2AccountSuppressionAttributesBuilder(logicalId: string) =
        member _.Yield(_: unit) : Sesv2AccountSuppressionAttributesState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2AccountSuppressionAttributesState<Missing>)

        member _.Zero(()) : Sesv2AccountSuppressionAttributesState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2AccountSuppressionAttributesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_account_suppression_attributes#suppressed_reasons-1">Sesv2AccountSuppressionAttributes#suppressed_reasons</a>.
        /// </summary>
        [<CustomOperation "suppressed_reasons">]
        member _.SuppressedReasons(state: Sesv2AccountSuppressionAttributesState<Missing>, value: seq<string>) : Sesv2AccountSuppressionAttributesState<Present> =
            state.assignments.Add(fun config -> config.SuppressedReasons <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : Sesv2AccountSuppressionAttributesState<Present>)

        member _.Run(state: Sesv2AccountSuppressionAttributesState<Present>) : aws.Sesv2AccountSuppressionAttributes.Sesv2AccountSuppressionAttributes =
            let config = aws.Sesv2AccountSuppressionAttributes.Sesv2AccountSuppressionAttributesConfig()
            for setter in state.assignments do
                setter config
            aws.Sesv2AccountSuppressionAttributes.Sesv2AccountSuppressionAttributes(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesv2AccountSuppressionAttributes: missing required arguments. Must call: suppressed_reasons.", 9999, IsError = true)>]
        member _.Run(_: Sesv2AccountSuppressionAttributesState<_>) : aws.Sesv2AccountSuppressionAttributes.Sesv2AccountSuppressionAttributes =
            Unchecked.defaultof<aws.Sesv2AccountSuppressionAttributes.Sesv2AccountSuppressionAttributes>
