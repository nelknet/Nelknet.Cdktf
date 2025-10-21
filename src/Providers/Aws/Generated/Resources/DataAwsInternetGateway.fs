namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsInternetGatewayState = { assignments: ResizeArray<aws.DataAwsInternetGateway.DataAwsInternetGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/internet_gateway">aws_internet_gateway</a>.
    /// </summary>
    type DataAwsInternetGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsInternetGatewayState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsInternetGatewayState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/internet_gateway#filter-1">DataAwsInternetGateway#filter</a> Accepts: aws.IResolvable | aws.DataAwsInternetGateway.DataAwsInternetGatewayFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsInternetGatewayState, value: HashiCorp.Cdktf.IResolvable) : DataAwsInternetGatewayState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsInternetGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/internet_gateway#id-1">DataAwsInternetGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsInternetGatewayState, value: string) : DataAwsInternetGatewayState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsInternetGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/internet_gateway#internet_gateway_id-1">DataAwsInternetGateway#internet_gateway_id</a>.
        /// </summary>
        [<CustomOperation "internet_gateway_id">]
        member _.InternetGatewayId(state: DataAwsInternetGatewayState, value: string) : DataAwsInternetGatewayState =
            state.assignments.Add(fun config -> config.InternetGatewayId <- value)
            state : DataAwsInternetGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/internet_gateway#tags-1">DataAwsInternetGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsInternetGatewayState, value: seq<string * string>) : DataAwsInternetGatewayState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsInternetGatewayState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/internet_gateway#timeouts-1">DataAwsInternetGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsInternetGatewayState, value: aws.DataAwsInternetGateway.DataAwsInternetGatewayTimeouts) : DataAwsInternetGatewayState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsInternetGatewayState

        member _.Run(state: DataAwsInternetGatewayState) : aws.DataAwsInternetGateway.DataAwsInternetGateway =
            let config = aws.DataAwsInternetGateway.DataAwsInternetGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsInternetGateway.DataAwsInternetGateway(StackContext.get (), logicalId, config)
