namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticsearchVpcEndpointState<'DomainArn, 'VpcOptions> = { assignments: ResizeArray<aws.ElasticsearchVpcEndpoint.ElasticsearchVpcEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_vpc_endpoint">aws_elasticsearch_vpc_endpoint</a>.
    /// </summary>
    type ElasticsearchVpcEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticsearchVpcEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticsearchVpcEndpointState<Missing, Missing>)

        member _.Zero(()) : ElasticsearchVpcEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticsearchVpcEndpointState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_vpc_endpoint#domain_arn-1">ElasticsearchVpcEndpoint#domain_arn</a>.
        /// </summary>
        [<CustomOperation "domain_arn">]
        member _.DomainArn(state: ElasticsearchVpcEndpointState<Missing, 'VpcOptions>, value: string) : ElasticsearchVpcEndpointState<Present, 'VpcOptions> =
            state.assignments.Add(fun config -> config.DomainArn <- value)
            ({ assignments = state.assignments } : ElasticsearchVpcEndpointState<Present, 'VpcOptions>)

        /// <summary>
        /// vpc_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_vpc_endpoint#vpc_options-1">ElasticsearchVpcEndpoint#vpc_options</a>
        /// </summary>
        [<CustomOperation "vpc_options">]
        member _.VpcOptions(state: ElasticsearchVpcEndpointState<'DomainArn, Missing>, value: aws.ElasticsearchVpcEndpoint.ElasticsearchVpcEndpointVpcOptions) : ElasticsearchVpcEndpointState<'DomainArn, Present> =
            state.assignments.Add(fun config -> config.VpcOptions <- value)
            ({ assignments = state.assignments } : ElasticsearchVpcEndpointState<'DomainArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_vpc_endpoint#id-1">ElasticsearchVpcEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticsearchVpcEndpointState<'DomainArn, 'VpcOptions>, value: string) : ElasticsearchVpcEndpointState<'DomainArn, 'VpcOptions> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticsearchVpcEndpointState<'DomainArn, 'VpcOptions>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_vpc_endpoint#timeouts-1">ElasticsearchVpcEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElasticsearchVpcEndpointState<'DomainArn, 'VpcOptions>, value: aws.ElasticsearchVpcEndpoint.ElasticsearchVpcEndpointTimeouts) : ElasticsearchVpcEndpointState<'DomainArn, 'VpcOptions> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElasticsearchVpcEndpointState<'DomainArn, 'VpcOptions>

        member _.Run(state: ElasticsearchVpcEndpointState<Present, Present>) : aws.ElasticsearchVpcEndpoint.ElasticsearchVpcEndpoint =
            let config = aws.ElasticsearchVpcEndpoint.ElasticsearchVpcEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticsearchVpcEndpoint.ElasticsearchVpcEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticsearchVpcEndpoint: missing required arguments. Must call: domain_arn, vpc_options.", 9999, IsError = true)>]
        member _.Run(_: ElasticsearchVpcEndpointState<_, _>) : aws.ElasticsearchVpcEndpoint.ElasticsearchVpcEndpoint =
            Unchecked.defaultof<aws.ElasticsearchVpcEndpoint.ElasticsearchVpcEndpoint>
