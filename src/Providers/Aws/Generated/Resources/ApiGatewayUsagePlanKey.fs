namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayUsagePlanKeyState<'KeyId, 'KeyType, 'UsagePlanId> = { assignments: ResizeArray<aws.ApiGatewayUsagePlanKey.ApiGatewayUsagePlanKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan_key">aws_api_gateway_usage_plan_key</a>.
    /// </summary>
    type ApiGatewayUsagePlanKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayUsagePlanKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayUsagePlanKeyState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiGatewayUsagePlanKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayUsagePlanKeyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan_key#key_id-1">ApiGatewayUsagePlanKey#key_id</a>.
        /// </summary>
        [<CustomOperation "key_id">]
        member _.KeyId(state: ApiGatewayUsagePlanKeyState<Missing, 'KeyType, 'UsagePlanId>, value: string) : ApiGatewayUsagePlanKeyState<Present, 'KeyType, 'UsagePlanId> =
            state.assignments.Add(fun config -> config.KeyId <- value)
            ({ assignments = state.assignments } : ApiGatewayUsagePlanKeyState<Present, 'KeyType, 'UsagePlanId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan_key#key_type-1">ApiGatewayUsagePlanKey#key_type</a>.
        /// </summary>
        [<CustomOperation "key_type">]
        member _.KeyType(state: ApiGatewayUsagePlanKeyState<'KeyId, Missing, 'UsagePlanId>, value: string) : ApiGatewayUsagePlanKeyState<'KeyId, Present, 'UsagePlanId> =
            state.assignments.Add(fun config -> config.KeyType <- value)
            ({ assignments = state.assignments } : ApiGatewayUsagePlanKeyState<'KeyId, Present, 'UsagePlanId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan_key#usage_plan_id-1">ApiGatewayUsagePlanKey#usage_plan_id</a>.
        /// </summary>
        [<CustomOperation "usage_plan_id">]
        member _.UsagePlanId(state: ApiGatewayUsagePlanKeyState<'KeyId, 'KeyType, Missing>, value: string) : ApiGatewayUsagePlanKeyState<'KeyId, 'KeyType, Present> =
            state.assignments.Add(fun config -> config.UsagePlanId <- value)
            ({ assignments = state.assignments } : ApiGatewayUsagePlanKeyState<'KeyId, 'KeyType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan_key#id-1">ApiGatewayUsagePlanKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayUsagePlanKeyState<'KeyId, 'KeyType, 'UsagePlanId>, value: string) : ApiGatewayUsagePlanKeyState<'KeyId, 'KeyType, 'UsagePlanId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayUsagePlanKeyState<'KeyId, 'KeyType, 'UsagePlanId>

        member _.Run(state: ApiGatewayUsagePlanKeyState<Present, Present, Present>) : aws.ApiGatewayUsagePlanKey.ApiGatewayUsagePlanKey =
            let config = aws.ApiGatewayUsagePlanKey.ApiGatewayUsagePlanKeyConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayUsagePlanKey.ApiGatewayUsagePlanKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayUsagePlanKey: missing required arguments. Must call: key_id, key_type, usage_plan_id.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayUsagePlanKeyState<_, _, _>) : aws.ApiGatewayUsagePlanKey.ApiGatewayUsagePlanKey =
            Unchecked.defaultof<aws.ApiGatewayUsagePlanKey.ApiGatewayUsagePlanKey>
