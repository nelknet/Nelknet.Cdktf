namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Apigatewayv2VpcLinkState<'Name, 'SecurityGroupIds, 'SubnetIds> = { assignments: ResizeArray<aws.Apigatewayv2VpcLink.Apigatewayv2VpcLinkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_vpc_link">aws_apigatewayv2_vpc_link</a>.
    /// </summary>
    type Apigatewayv2VpcLinkBuilder(logicalId: string) =
        member _.Yield(_: unit) : Apigatewayv2VpcLinkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2VpcLinkState<Missing, Missing, Missing>)

        member _.Zero(()) : Apigatewayv2VpcLinkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2VpcLinkState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_vpc_link#name-1">Apigatewayv2VpcLink#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Apigatewayv2VpcLinkState<Missing, 'SecurityGroupIds, 'SubnetIds>, value: string) : Apigatewayv2VpcLinkState<Present, 'SecurityGroupIds, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Apigatewayv2VpcLinkState<Present, 'SecurityGroupIds, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_vpc_link#security_group_ids-1">Apigatewayv2VpcLink#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: Apigatewayv2VpcLinkState<'Name, Missing, 'SubnetIds>, value: seq<string>) : Apigatewayv2VpcLinkState<'Name, Present, 'SubnetIds> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : Apigatewayv2VpcLinkState<'Name, Present, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_vpc_link#subnet_ids-1">Apigatewayv2VpcLink#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: Apigatewayv2VpcLinkState<'Name, 'SecurityGroupIds, Missing>, value: seq<string>) : Apigatewayv2VpcLinkState<'Name, 'SecurityGroupIds, Present> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : Apigatewayv2VpcLinkState<'Name, 'SecurityGroupIds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_vpc_link#id-1">Apigatewayv2VpcLink#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Apigatewayv2VpcLinkState<'Name, 'SecurityGroupIds, 'SubnetIds>, value: string) : Apigatewayv2VpcLinkState<'Name, 'SecurityGroupIds, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Apigatewayv2VpcLinkState<'Name, 'SecurityGroupIds, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_vpc_link#tags-1">Apigatewayv2VpcLink#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Apigatewayv2VpcLinkState<'Name, 'SecurityGroupIds, 'SubnetIds>, value: seq<string * string>) : Apigatewayv2VpcLinkState<'Name, 'SecurityGroupIds, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Apigatewayv2VpcLinkState<'Name, 'SecurityGroupIds, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_vpc_link#tags_all-1">Apigatewayv2VpcLink#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Apigatewayv2VpcLinkState<'Name, 'SecurityGroupIds, 'SubnetIds>, value: seq<string * string>) : Apigatewayv2VpcLinkState<'Name, 'SecurityGroupIds, 'SubnetIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Apigatewayv2VpcLinkState<'Name, 'SecurityGroupIds, 'SubnetIds>

        member _.Run(state: Apigatewayv2VpcLinkState<Present, Present, Present>) : aws.Apigatewayv2VpcLink.Apigatewayv2VpcLink =
            let config = aws.Apigatewayv2VpcLink.Apigatewayv2VpcLinkConfig()
            for setter in state.assignments do
                setter config
            aws.Apigatewayv2VpcLink.Apigatewayv2VpcLink(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apigatewayv2VpcLink: missing required arguments. Must call: name, security_group_ids, subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: Apigatewayv2VpcLinkState<_, _, _>) : aws.Apigatewayv2VpcLink.Apigatewayv2VpcLink =
            Unchecked.defaultof<aws.Apigatewayv2VpcLink.Apigatewayv2VpcLink>
