namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2LocalGatewayState = { assignments: ResizeArray<aws.DataAwsEc2LocalGateway.DataAwsEc2LocalGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway">aws_ec2_local_gateway</a>.
    /// </summary>
    type DataAwsEc2LocalGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2LocalGatewayState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2LocalGatewayState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway#filter-1">DataAwsEc2LocalGateway#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2LocalGateway.DataAwsEc2LocalGatewayFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2LocalGatewayState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2LocalGatewayState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2LocalGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway#id-1">DataAwsEc2LocalGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2LocalGatewayState, value: string) : DataAwsEc2LocalGatewayState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2LocalGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway#state-1">DataAwsEc2LocalGateway#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: DataAwsEc2LocalGatewayState, value: string) : DataAwsEc2LocalGatewayState =
            state.assignments.Add(fun config -> config.State <- value)
            state : DataAwsEc2LocalGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway#tags-1">DataAwsEc2LocalGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2LocalGatewayState, value: seq<string * string>) : DataAwsEc2LocalGatewayState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2LocalGatewayState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway#timeouts-1">DataAwsEc2LocalGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2LocalGatewayState, value: aws.DataAwsEc2LocalGateway.DataAwsEc2LocalGatewayTimeouts) : DataAwsEc2LocalGatewayState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2LocalGatewayState

        member _.Run(state: DataAwsEc2LocalGatewayState) : aws.DataAwsEc2LocalGateway.DataAwsEc2LocalGateway =
            let config = aws.DataAwsEc2LocalGateway.DataAwsEc2LocalGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2LocalGateway.DataAwsEc2LocalGateway(StackContext.get (), logicalId, config)
