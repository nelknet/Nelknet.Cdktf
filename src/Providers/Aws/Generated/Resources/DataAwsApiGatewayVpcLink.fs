namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsApiGatewayVpcLinkState<'Name> = { assignments: ResizeArray<aws.DataAwsApiGatewayVpcLink.DataAwsApiGatewayVpcLinkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_vpc_link">aws_api_gateway_vpc_link</a>.
    /// </summary>
    type DataAwsApiGatewayVpcLinkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsApiGatewayVpcLinkState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayVpcLinkState<Missing>)

        member _.Zero(()) : DataAwsApiGatewayVpcLinkState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayVpcLinkState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_vpc_link#name-1">DataAwsApiGatewayVpcLink#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsApiGatewayVpcLinkState<Missing>, value: string) : DataAwsApiGatewayVpcLinkState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsApiGatewayVpcLinkState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_vpc_link#tags-1">DataAwsApiGatewayVpcLink#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsApiGatewayVpcLinkState<'Name>, value: seq<string * string>) : DataAwsApiGatewayVpcLinkState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsApiGatewayVpcLinkState<'Name>

        member _.Run(state: DataAwsApiGatewayVpcLinkState<Present>) : aws.DataAwsApiGatewayVpcLink.DataAwsApiGatewayVpcLink =
            let config = aws.DataAwsApiGatewayVpcLink.DataAwsApiGatewayVpcLinkConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsApiGatewayVpcLink.DataAwsApiGatewayVpcLink(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsApiGatewayVpcLink: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsApiGatewayVpcLinkState<_>) : aws.DataAwsApiGatewayVpcLink.DataAwsApiGatewayVpcLink =
            Unchecked.defaultof<aws.DataAwsApiGatewayVpcLink.DataAwsApiGatewayVpcLink>
