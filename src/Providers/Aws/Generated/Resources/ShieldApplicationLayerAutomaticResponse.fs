namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ShieldApplicationLayerAutomaticResponseState<'Action, 'ResourceArn> = { assignments: ResizeArray<aws.ShieldApplicationLayerAutomaticResponse.ShieldApplicationLayerAutomaticResponseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_application_layer_automatic_response">aws_shield_application_layer_automatic_response</a>.
    /// </summary>
    type ShieldApplicationLayerAutomaticResponseBuilder(logicalId: string) =
        member _.Yield(_: unit) : ShieldApplicationLayerAutomaticResponseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ShieldApplicationLayerAutomaticResponseState<Missing, Missing>)

        member _.Zero(()) : ShieldApplicationLayerAutomaticResponseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ShieldApplicationLayerAutomaticResponseState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_application_layer_automatic_response#action-1">ShieldApplicationLayerAutomaticResponse#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: ShieldApplicationLayerAutomaticResponseState<Missing, 'ResourceArn>, value: string) : ShieldApplicationLayerAutomaticResponseState<Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : ShieldApplicationLayerAutomaticResponseState<Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_application_layer_automatic_response#resource_arn-1">ShieldApplicationLayerAutomaticResponse#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: ShieldApplicationLayerAutomaticResponseState<'Action, Missing>, value: string) : ShieldApplicationLayerAutomaticResponseState<'Action, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : ShieldApplicationLayerAutomaticResponseState<'Action, Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_application_layer_automatic_response#timeouts-1">ShieldApplicationLayerAutomaticResponse#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ShieldApplicationLayerAutomaticResponseState<'Action, 'ResourceArn>, value: aws.ShieldApplicationLayerAutomaticResponse.ShieldApplicationLayerAutomaticResponseTimeouts) : ShieldApplicationLayerAutomaticResponseState<'Action, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ShieldApplicationLayerAutomaticResponseState<'Action, 'ResourceArn>

        member _.Run(state: ShieldApplicationLayerAutomaticResponseState<Present, Present>) : aws.ShieldApplicationLayerAutomaticResponse.ShieldApplicationLayerAutomaticResponse =
            let config = aws.ShieldApplicationLayerAutomaticResponse.ShieldApplicationLayerAutomaticResponseConfig()
            for setter in state.assignments do
                setter config
            aws.ShieldApplicationLayerAutomaticResponse.ShieldApplicationLayerAutomaticResponse(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.shieldApplicationLayerAutomaticResponse: missing required arguments. Must call: action, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: ShieldApplicationLayerAutomaticResponseState<_, _>) : aws.ShieldApplicationLayerAutomaticResponse.ShieldApplicationLayerAutomaticResponse =
            Unchecked.defaultof<aws.ShieldApplicationLayerAutomaticResponse.ShieldApplicationLayerAutomaticResponse>
