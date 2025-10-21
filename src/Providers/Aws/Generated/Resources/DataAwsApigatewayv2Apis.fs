namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsApigatewayv2ApisState = { assignments: ResizeArray<aws.DataAwsApigatewayv2Apis.DataAwsApigatewayv2ApisConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_apis">aws_apigatewayv2_apis</a>.
    /// </summary>
    type DataAwsApigatewayv2ApisBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsApigatewayv2ApisState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsApigatewayv2ApisState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_apis#id-1">DataAwsApigatewayv2Apis#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsApigatewayv2ApisState, value: string) : DataAwsApigatewayv2ApisState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsApigatewayv2ApisState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_apis#name-1">DataAwsApigatewayv2Apis#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsApigatewayv2ApisState, value: string) : DataAwsApigatewayv2ApisState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsApigatewayv2ApisState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_apis#protocol_type-1">DataAwsApigatewayv2Apis#protocol_type</a>.
        /// </summary>
        [<CustomOperation "protocol_type">]
        member _.ProtocolType(state: DataAwsApigatewayv2ApisState, value: string) : DataAwsApigatewayv2ApisState =
            state.assignments.Add(fun config -> config.ProtocolType <- value)
            state : DataAwsApigatewayv2ApisState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_apis#tags-1">DataAwsApigatewayv2Apis#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsApigatewayv2ApisState, value: seq<string * string>) : DataAwsApigatewayv2ApisState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsApigatewayv2ApisState

        member _.Run(state: DataAwsApigatewayv2ApisState) : aws.DataAwsApigatewayv2Apis.DataAwsApigatewayv2Apis =
            let config = aws.DataAwsApigatewayv2Apis.DataAwsApigatewayv2ApisConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsApigatewayv2Apis.DataAwsApigatewayv2Apis(StackContext.get (), logicalId, config)
