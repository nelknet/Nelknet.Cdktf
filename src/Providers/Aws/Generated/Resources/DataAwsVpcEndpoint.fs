namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcEndpointState = { assignments: ResizeArray<aws.DataAwsVpcEndpoint.DataAwsVpcEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint">aws_vpc_endpoint</a>.
    /// </summary>
    type DataAwsVpcEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcEndpointState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsVpcEndpointState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint#filter-1">DataAwsVpcEndpoint#filter</a> Accepts: aws.IResolvable | aws.DataAwsVpcEndpoint.DataAwsVpcEndpointFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsVpcEndpointState, value: HashiCorp.Cdktf.IResolvable) : DataAwsVpcEndpointState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsVpcEndpointState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint#id-1">DataAwsVpcEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpcEndpointState, value: string) : DataAwsVpcEndpointState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpcEndpointState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint#service_name-1">DataAwsVpcEndpoint#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: DataAwsVpcEndpointState, value: string) : DataAwsVpcEndpointState =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            state : DataAwsVpcEndpointState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint#state-1">DataAwsVpcEndpoint#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: DataAwsVpcEndpointState, value: string) : DataAwsVpcEndpointState =
            state.assignments.Add(fun config -> config.State <- value)
            state : DataAwsVpcEndpointState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint#tags-1">DataAwsVpcEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsVpcEndpointState, value: seq<string * string>) : DataAwsVpcEndpointState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsVpcEndpointState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint#timeouts-1">DataAwsVpcEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsVpcEndpointState, value: aws.DataAwsVpcEndpoint.DataAwsVpcEndpointTimeouts) : DataAwsVpcEndpointState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsVpcEndpointState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint#vpc_id-1">DataAwsVpcEndpoint#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: DataAwsVpcEndpointState, value: string) : DataAwsVpcEndpointState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : DataAwsVpcEndpointState

        member _.Run(state: DataAwsVpcEndpointState) : aws.DataAwsVpcEndpoint.DataAwsVpcEndpoint =
            let config = aws.DataAwsVpcEndpoint.DataAwsVpcEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpcEndpoint.DataAwsVpcEndpoint(StackContext.get (), logicalId, config)
