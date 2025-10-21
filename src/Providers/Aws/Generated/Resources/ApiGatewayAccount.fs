namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayAccountState = { assignments: ResizeArray<aws.ApiGatewayAccount.ApiGatewayAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_account">aws_api_gateway_account</a>.
    /// </summary>
    type ApiGatewayAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayAccountState =
            { assignments = ResizeArray() }

        member _.Zero(()) : ApiGatewayAccountState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_account#cloudwatch_role_arn-1">ApiGatewayAccount#cloudwatch_role_arn</a>.
        /// </summary>
        [<CustomOperation "cloudwatch_role_arn">]
        member _.CloudwatchRoleArn(state: ApiGatewayAccountState, value: string) : ApiGatewayAccountState =
            state.assignments.Add(fun config -> config.CloudwatchRoleArn <- value)
            state : ApiGatewayAccountState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_account#reset_on_delete-1">ApiGatewayAccount#reset_on_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "reset_on_delete">]
        member _.ResetOnDelete(state: ApiGatewayAccountState, value: bool) : ApiGatewayAccountState =
            state.assignments.Add(fun config -> config.ResetOnDelete <- value)
            state : ApiGatewayAccountState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_account#reset_on_delete-1">ApiGatewayAccount#reset_on_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "reset_on_delete">]
        member _.ResetOnDelete(state: ApiGatewayAccountState, value: HashiCorp.Cdktf.IResolvable) : ApiGatewayAccountState =
            state.assignments.Add(fun config -> config.ResetOnDelete <- value)
            state : ApiGatewayAccountState

        member _.Run(state: ApiGatewayAccountState) : aws.ApiGatewayAccount.ApiGatewayAccount =
            let config = aws.ApiGatewayAccount.ApiGatewayAccountConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayAccount.ApiGatewayAccount(StackContext.get (), logicalId, config)
