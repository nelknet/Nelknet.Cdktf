namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCustomerGatewayState = { assignments: ResizeArray<aws.DataAwsCustomerGateway.DataAwsCustomerGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/customer_gateway">aws_customer_gateway</a>.
    /// </summary>
    type DataAwsCustomerGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCustomerGatewayState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsCustomerGatewayState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/customer_gateway#filter-1">DataAwsCustomerGateway#filter</a> Accepts: aws.IResolvable | aws.DataAwsCustomerGateway.DataAwsCustomerGatewayFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsCustomerGatewayState, value: HashiCorp.Cdktf.IResolvable) : DataAwsCustomerGatewayState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsCustomerGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/customer_gateway#id-1">DataAwsCustomerGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCustomerGatewayState, value: string) : DataAwsCustomerGatewayState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCustomerGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/customer_gateway#tags-1">DataAwsCustomerGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsCustomerGatewayState, value: seq<string * string>) : DataAwsCustomerGatewayState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsCustomerGatewayState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/customer_gateway#timeouts-1">DataAwsCustomerGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsCustomerGatewayState, value: aws.DataAwsCustomerGateway.DataAwsCustomerGatewayTimeouts) : DataAwsCustomerGatewayState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsCustomerGatewayState

        member _.Run(state: DataAwsCustomerGatewayState) : aws.DataAwsCustomerGateway.DataAwsCustomerGateway =
            let config = aws.DataAwsCustomerGateway.DataAwsCustomerGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCustomerGateway.DataAwsCustomerGateway(StackContext.get (), logicalId, config)
