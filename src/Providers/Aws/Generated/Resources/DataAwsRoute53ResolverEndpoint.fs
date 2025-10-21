namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRoute53ResolverEndpointState = { assignments: ResizeArray<aws.DataAwsRoute53ResolverEndpoint.DataAwsRoute53ResolverEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_endpoint">aws_route53_resolver_endpoint</a>.
    /// </summary>
    type DataAwsRoute53ResolverEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRoute53ResolverEndpointState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRoute53ResolverEndpointState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_endpoint#filter-1">DataAwsRoute53ResolverEndpoint#filter</a> Accepts: aws.IResolvable | aws.DataAwsRoute53ResolverEndpoint.DataAwsRoute53ResolverEndpointFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsRoute53ResolverEndpointState, value: HashiCorp.Cdktf.IResolvable) : DataAwsRoute53ResolverEndpointState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsRoute53ResolverEndpointState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_endpoint#id-1">DataAwsRoute53ResolverEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRoute53ResolverEndpointState, value: string) : DataAwsRoute53ResolverEndpointState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRoute53ResolverEndpointState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_endpoint#resolver_endpoint_id-1">DataAwsRoute53ResolverEndpoint#resolver_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "resolver_endpoint_id">]
        member _.ResolverEndpointId(state: DataAwsRoute53ResolverEndpointState, value: string) : DataAwsRoute53ResolverEndpointState =
            state.assignments.Add(fun config -> config.ResolverEndpointId <- value)
            state : DataAwsRoute53ResolverEndpointState

        member _.Run(state: DataAwsRoute53ResolverEndpointState) : aws.DataAwsRoute53ResolverEndpoint.DataAwsRoute53ResolverEndpoint =
            let config = aws.DataAwsRoute53ResolverEndpoint.DataAwsRoute53ResolverEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute53ResolverEndpoint.DataAwsRoute53ResolverEndpoint(StackContext.get (), logicalId, config)
