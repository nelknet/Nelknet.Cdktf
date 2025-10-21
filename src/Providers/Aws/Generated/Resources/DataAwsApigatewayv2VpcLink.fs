namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsApigatewayv2VpcLinkState<'VpcLinkId> = { assignments: ResizeArray<aws.DataAwsApigatewayv2VpcLink.DataAwsApigatewayv2VpcLinkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_vpc_link">aws_apigatewayv2_vpc_link</a>.
    /// </summary>
    type DataAwsApigatewayv2VpcLinkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsApigatewayv2VpcLinkState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsApigatewayv2VpcLinkState<Missing>)

        member _.Zero(()) : DataAwsApigatewayv2VpcLinkState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsApigatewayv2VpcLinkState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_vpc_link#vpc_link_id-1">DataAwsApigatewayv2VpcLink#vpc_link_id</a>.
        /// </summary>
        [<CustomOperation "vpc_link_id">]
        member _.VpcLinkId(state: DataAwsApigatewayv2VpcLinkState<Missing>, value: string) : DataAwsApigatewayv2VpcLinkState<Present> =
            state.assignments.Add(fun config -> config.VpcLinkId <- value)
            ({ assignments = state.assignments } : DataAwsApigatewayv2VpcLinkState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_vpc_link#id-1">DataAwsApigatewayv2VpcLink#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsApigatewayv2VpcLinkState<'VpcLinkId>, value: string) : DataAwsApigatewayv2VpcLinkState<'VpcLinkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsApigatewayv2VpcLinkState<'VpcLinkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_vpc_link#tags-1">DataAwsApigatewayv2VpcLink#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsApigatewayv2VpcLinkState<'VpcLinkId>, value: seq<string * string>) : DataAwsApigatewayv2VpcLinkState<'VpcLinkId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsApigatewayv2VpcLinkState<'VpcLinkId>

        member _.Run(state: DataAwsApigatewayv2VpcLinkState<Present>) : aws.DataAwsApigatewayv2VpcLink.DataAwsApigatewayv2VpcLink =
            let config = aws.DataAwsApigatewayv2VpcLink.DataAwsApigatewayv2VpcLinkConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsApigatewayv2VpcLink.DataAwsApigatewayv2VpcLink(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsApigatewayv2VpcLink: missing required arguments. Must call: vpc_link_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsApigatewayv2VpcLinkState<_>) : aws.DataAwsApigatewayv2VpcLink.DataAwsApigatewayv2VpcLink =
            Unchecked.defaultof<aws.DataAwsApigatewayv2VpcLink.DataAwsApigatewayv2VpcLink>
