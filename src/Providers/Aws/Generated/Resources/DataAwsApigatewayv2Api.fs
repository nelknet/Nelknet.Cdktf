namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsApigatewayv2ApiState<'ApiId> = { assignments: ResizeArray<aws.DataAwsApigatewayv2Api.DataAwsApigatewayv2ApiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_api">aws_apigatewayv2_api</a>.
    /// </summary>
    type DataAwsApigatewayv2ApiBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsApigatewayv2ApiState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsApigatewayv2ApiState<Missing>)

        member _.Zero(()) : DataAwsApigatewayv2ApiState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsApigatewayv2ApiState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_api#api_id-1">DataAwsApigatewayv2Api#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: DataAwsApigatewayv2ApiState<Missing>, value: string) : DataAwsApigatewayv2ApiState<Present> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : DataAwsApigatewayv2ApiState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_api#id-1">DataAwsApigatewayv2Api#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsApigatewayv2ApiState<'ApiId>, value: string) : DataAwsApigatewayv2ApiState<'ApiId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsApigatewayv2ApiState<'ApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_api#tags-1">DataAwsApigatewayv2Api#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsApigatewayv2ApiState<'ApiId>, value: seq<string * string>) : DataAwsApigatewayv2ApiState<'ApiId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsApigatewayv2ApiState<'ApiId>

        member _.Run(state: DataAwsApigatewayv2ApiState<Present>) : aws.DataAwsApigatewayv2Api.DataAwsApigatewayv2Api =
            let config = aws.DataAwsApigatewayv2Api.DataAwsApigatewayv2ApiConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsApigatewayv2Api.DataAwsApigatewayv2Api(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsApigatewayv2Api: missing required arguments. Must call: api_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsApigatewayv2ApiState<_>) : aws.DataAwsApigatewayv2Api.DataAwsApigatewayv2Api =
            Unchecked.defaultof<aws.DataAwsApigatewayv2Api.DataAwsApigatewayv2Api>
