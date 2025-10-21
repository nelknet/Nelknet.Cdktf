namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type InternetGatewayState = { assignments: ResizeArray<aws.InternetGateway.InternetGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internet_gateway">aws_internet_gateway</a>.
    /// </summary>
    type InternetGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : InternetGatewayState =
            { assignments = ResizeArray() }

        member _.Zero(()) : InternetGatewayState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internet_gateway#id-1">InternetGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: InternetGatewayState, value: string) : InternetGatewayState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : InternetGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internet_gateway#tags-1">InternetGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: InternetGatewayState, value: seq<string * string>) : InternetGatewayState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : InternetGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internet_gateway#tags_all-1">InternetGateway#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: InternetGatewayState, value: seq<string * string>) : InternetGatewayState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : InternetGatewayState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internet_gateway#timeouts-1">InternetGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: InternetGatewayState, value: aws.InternetGateway.InternetGatewayTimeouts) : InternetGatewayState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : InternetGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internet_gateway#vpc_id-1">InternetGateway#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: InternetGatewayState, value: string) : InternetGatewayState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : InternetGatewayState

        member _.Run(state: InternetGatewayState) : aws.InternetGateway.InternetGateway =
            let config = aws.InternetGateway.InternetGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.InternetGateway.InternetGateway(StackContext.get (), logicalId, config)
