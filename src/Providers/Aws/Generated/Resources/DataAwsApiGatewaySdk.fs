namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsApiGatewaySdkState<'RestApiId, 'SdkType, 'StageName> = { assignments: ResizeArray<aws.DataAwsApiGatewaySdk.DataAwsApiGatewaySdkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_sdk">aws_api_gateway_sdk</a>.
    /// </summary>
    type DataAwsApiGatewaySdkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsApiGatewaySdkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewaySdkState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAwsApiGatewaySdkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewaySdkState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_sdk#rest_api_id-1">DataAwsApiGatewaySdk#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: DataAwsApiGatewaySdkState<Missing, 'SdkType, 'StageName>, value: string) : DataAwsApiGatewaySdkState<Present, 'SdkType, 'StageName> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : DataAwsApiGatewaySdkState<Present, 'SdkType, 'StageName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_sdk#sdk_type-1">DataAwsApiGatewaySdk#sdk_type</a>.
        /// </summary>
        [<CustomOperation "sdk_type">]
        member _.SdkType(state: DataAwsApiGatewaySdkState<'RestApiId, Missing, 'StageName>, value: string) : DataAwsApiGatewaySdkState<'RestApiId, Present, 'StageName> =
            state.assignments.Add(fun config -> config.SdkType <- value)
            ({ assignments = state.assignments } : DataAwsApiGatewaySdkState<'RestApiId, Present, 'StageName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_sdk#stage_name-1">DataAwsApiGatewaySdk#stage_name</a>.
        /// </summary>
        [<CustomOperation "stage_name">]
        member _.StageName(state: DataAwsApiGatewaySdkState<'RestApiId, 'SdkType, Missing>, value: string) : DataAwsApiGatewaySdkState<'RestApiId, 'SdkType, Present> =
            state.assignments.Add(fun config -> config.StageName <- value)
            ({ assignments = state.assignments } : DataAwsApiGatewaySdkState<'RestApiId, 'SdkType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_sdk#id-1">DataAwsApiGatewaySdk#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsApiGatewaySdkState<'RestApiId, 'SdkType, 'StageName>, value: string) : DataAwsApiGatewaySdkState<'RestApiId, 'SdkType, 'StageName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsApiGatewaySdkState<'RestApiId, 'SdkType, 'StageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_sdk#parameters-1">DataAwsApiGatewaySdk#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataAwsApiGatewaySdkState<'RestApiId, 'SdkType, 'StageName>, value: seq<string * string>) : DataAwsApiGatewaySdkState<'RestApiId, 'SdkType, 'StageName> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataAwsApiGatewaySdkState<'RestApiId, 'SdkType, 'StageName>

        member _.Run(state: DataAwsApiGatewaySdkState<Present, Present, Present>) : aws.DataAwsApiGatewaySdk.DataAwsApiGatewaySdk =
            let config = aws.DataAwsApiGatewaySdk.DataAwsApiGatewaySdkConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsApiGatewaySdk.DataAwsApiGatewaySdk(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsApiGatewaySdk: missing required arguments. Must call: rest_api_id, sdk_type, stage_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsApiGatewaySdkState<_, _, _>) : aws.DataAwsApiGatewaySdk.DataAwsApiGatewaySdk =
            Unchecked.defaultof<aws.DataAwsApiGatewaySdk.DataAwsApiGatewaySdk>
