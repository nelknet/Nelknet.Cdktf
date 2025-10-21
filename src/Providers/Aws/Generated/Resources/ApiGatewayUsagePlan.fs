namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayUsagePlanState<'Name> = { assignments: ResizeArray<aws.ApiGatewayUsagePlan.ApiGatewayUsagePlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan">aws_api_gateway_usage_plan</a>.
    /// </summary>
    type ApiGatewayUsagePlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayUsagePlanState<Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayUsagePlanState<Missing>)

        member _.Zero(()) : ApiGatewayUsagePlanState<Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayUsagePlanState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#name-1">ApiGatewayUsagePlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiGatewayUsagePlanState<Missing>, value: string) : ApiGatewayUsagePlanState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiGatewayUsagePlanState<Present>)

        /// <summary>
        /// api_stages block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#api_stages-1">ApiGatewayUsagePlan#api_stages</a> Accepts: aws.IResolvable | aws.ApiGatewayUsagePlan.ApiGatewayUsagePlanApiStages[]
        /// </summary>
        [<CustomOperation "api_stages">]
        member _.ApiStages(state: ApiGatewayUsagePlanState<'Name>, value: HashiCorp.Cdktf.IResolvable) : ApiGatewayUsagePlanState<'Name> =
            state.assignments.Add(fun config -> config.ApiStages <- value)
            state : ApiGatewayUsagePlanState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#description-1">ApiGatewayUsagePlan#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiGatewayUsagePlanState<'Name>, value: string) : ApiGatewayUsagePlanState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiGatewayUsagePlanState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#id-1">ApiGatewayUsagePlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayUsagePlanState<'Name>, value: string) : ApiGatewayUsagePlanState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayUsagePlanState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#product_code-1">ApiGatewayUsagePlan#product_code</a>.
        /// </summary>
        [<CustomOperation "product_code">]
        member _.ProductCode(state: ApiGatewayUsagePlanState<'Name>, value: string) : ApiGatewayUsagePlanState<'Name> =
            state.assignments.Add(fun config -> config.ProductCode <- value)
            state : ApiGatewayUsagePlanState<'Name>

        /// <summary>
        /// quota_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#quota_settings-1">ApiGatewayUsagePlan#quota_settings</a>
        /// </summary>
        [<CustomOperation "quota_settings">]
        member _.QuotaSettings(state: ApiGatewayUsagePlanState<'Name>, value: aws.ApiGatewayUsagePlan.ApiGatewayUsagePlanQuotaSettings) : ApiGatewayUsagePlanState<'Name> =
            state.assignments.Add(fun config -> config.QuotaSettings <- value)
            state : ApiGatewayUsagePlanState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#tags-1">ApiGatewayUsagePlan#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApiGatewayUsagePlanState<'Name>, value: seq<string * string>) : ApiGatewayUsagePlanState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApiGatewayUsagePlanState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#tags_all-1">ApiGatewayUsagePlan#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ApiGatewayUsagePlanState<'Name>, value: seq<string * string>) : ApiGatewayUsagePlanState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ApiGatewayUsagePlanState<'Name>

        /// <summary>
        /// throttle_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#throttle_settings-1">ApiGatewayUsagePlan#throttle_settings</a>
        /// </summary>
        [<CustomOperation "throttle_settings">]
        member _.ThrottleSettings(state: ApiGatewayUsagePlanState<'Name>, value: aws.ApiGatewayUsagePlan.ApiGatewayUsagePlanThrottleSettings) : ApiGatewayUsagePlanState<'Name> =
            state.assignments.Add(fun config -> config.ThrottleSettings <- value)
            state : ApiGatewayUsagePlanState<'Name>

        member _.Run(state: ApiGatewayUsagePlanState<Present>) : aws.ApiGatewayUsagePlan.ApiGatewayUsagePlan =
            let config = aws.ApiGatewayUsagePlan.ApiGatewayUsagePlanConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayUsagePlan.ApiGatewayUsagePlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayUsagePlan: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayUsagePlanState<_>) : aws.ApiGatewayUsagePlan.ApiGatewayUsagePlan =
            Unchecked.defaultof<aws.ApiGatewayUsagePlan.ApiGatewayUsagePlan>
