namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpensearchVpcEndpointState<'DomainArn, 'VpcOptions> = { assignments: ResizeArray<aws.OpensearchVpcEndpoint.OpensearchVpcEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_vpc_endpoint">aws_opensearch_vpc_endpoint</a>.
    /// </summary>
    type OpensearchVpcEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpensearchVpcEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchVpcEndpointState<Missing, Missing>)

        member _.Zero(()) : OpensearchVpcEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchVpcEndpointState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_vpc_endpoint#domain_arn-1">OpensearchVpcEndpoint#domain_arn</a>.
        /// </summary>
        [<CustomOperation "domain_arn">]
        member _.DomainArn(state: OpensearchVpcEndpointState<Missing, 'VpcOptions>, value: string) : OpensearchVpcEndpointState<Present, 'VpcOptions> =
            state.assignments.Add(fun config -> config.DomainArn <- value)
            ({ assignments = state.assignments } : OpensearchVpcEndpointState<Present, 'VpcOptions>)

        /// <summary>
        /// vpc_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_vpc_endpoint#vpc_options-1">OpensearchVpcEndpoint#vpc_options</a>
        /// </summary>
        [<CustomOperation "vpc_options">]
        member _.VpcOptions(state: OpensearchVpcEndpointState<'DomainArn, Missing>, value: aws.OpensearchVpcEndpoint.OpensearchVpcEndpointVpcOptions) : OpensearchVpcEndpointState<'DomainArn, Present> =
            state.assignments.Add(fun config -> config.VpcOptions <- value)
            ({ assignments = state.assignments } : OpensearchVpcEndpointState<'DomainArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_vpc_endpoint#id-1">OpensearchVpcEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpensearchVpcEndpointState<'DomainArn, 'VpcOptions>, value: string) : OpensearchVpcEndpointState<'DomainArn, 'VpcOptions> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpensearchVpcEndpointState<'DomainArn, 'VpcOptions>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_vpc_endpoint#timeouts-1">OpensearchVpcEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OpensearchVpcEndpointState<'DomainArn, 'VpcOptions>, value: aws.OpensearchVpcEndpoint.OpensearchVpcEndpointTimeouts) : OpensearchVpcEndpointState<'DomainArn, 'VpcOptions> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OpensearchVpcEndpointState<'DomainArn, 'VpcOptions>

        member _.Run(state: OpensearchVpcEndpointState<Present, Present>) : aws.OpensearchVpcEndpoint.OpensearchVpcEndpoint =
            let config = aws.OpensearchVpcEndpoint.OpensearchVpcEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.OpensearchVpcEndpoint.OpensearchVpcEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opensearchVpcEndpoint: missing required arguments. Must call: domain_arn, vpc_options.", 9999, IsError = true)>]
        member _.Run(_: OpensearchVpcEndpointState<_, _>) : aws.OpensearchVpcEndpoint.OpensearchVpcEndpoint =
            Unchecked.defaultof<aws.OpensearchVpcEndpoint.OpensearchVpcEndpoint>
