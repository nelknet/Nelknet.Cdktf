namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayVpcLinkState<'Name, 'TargetArns> = { assignments: ResizeArray<aws.ApiGatewayVpcLink.ApiGatewayVpcLinkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_vpc_link">aws_api_gateway_vpc_link</a>.
    /// </summary>
    type ApiGatewayVpcLinkBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayVpcLinkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayVpcLinkState<Missing, Missing>)

        member _.Zero(()) : ApiGatewayVpcLinkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayVpcLinkState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_vpc_link#name-1">ApiGatewayVpcLink#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiGatewayVpcLinkState<Missing, 'TargetArns>, value: string) : ApiGatewayVpcLinkState<Present, 'TargetArns> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiGatewayVpcLinkState<Present, 'TargetArns>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_vpc_link#target_arns-1">ApiGatewayVpcLink#target_arns</a>.
        /// </summary>
        [<CustomOperation "target_arns">]
        member _.TargetArns(state: ApiGatewayVpcLinkState<'Name, Missing>, value: seq<string>) : ApiGatewayVpcLinkState<'Name, Present> =
            state.assignments.Add(fun config -> config.TargetArns <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ApiGatewayVpcLinkState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_vpc_link#description-1">ApiGatewayVpcLink#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiGatewayVpcLinkState<'Name, 'TargetArns>, value: string) : ApiGatewayVpcLinkState<'Name, 'TargetArns> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiGatewayVpcLinkState<'Name, 'TargetArns>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_vpc_link#id-1">ApiGatewayVpcLink#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayVpcLinkState<'Name, 'TargetArns>, value: string) : ApiGatewayVpcLinkState<'Name, 'TargetArns> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayVpcLinkState<'Name, 'TargetArns>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_vpc_link#tags-1">ApiGatewayVpcLink#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApiGatewayVpcLinkState<'Name, 'TargetArns>, value: seq<string * string>) : ApiGatewayVpcLinkState<'Name, 'TargetArns> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApiGatewayVpcLinkState<'Name, 'TargetArns>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_vpc_link#tags_all-1">ApiGatewayVpcLink#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ApiGatewayVpcLinkState<'Name, 'TargetArns>, value: seq<string * string>) : ApiGatewayVpcLinkState<'Name, 'TargetArns> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ApiGatewayVpcLinkState<'Name, 'TargetArns>

        member _.Run(state: ApiGatewayVpcLinkState<Present, Present>) : aws.ApiGatewayVpcLink.ApiGatewayVpcLink =
            let config = aws.ApiGatewayVpcLink.ApiGatewayVpcLinkConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayVpcLink.ApiGatewayVpcLink(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayVpcLink: missing required arguments. Must call: name, target_arns.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayVpcLinkState<_, _>) : aws.ApiGatewayVpcLink.ApiGatewayVpcLink =
            Unchecked.defaultof<aws.ApiGatewayVpcLink.ApiGatewayVpcLink>
