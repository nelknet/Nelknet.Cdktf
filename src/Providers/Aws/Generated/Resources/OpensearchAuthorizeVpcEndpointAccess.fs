namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpensearchAuthorizeVpcEndpointAccessState<'Account, 'DomainName> = { assignments: ResizeArray<aws.OpensearchAuthorizeVpcEndpointAccess.OpensearchAuthorizeVpcEndpointAccessConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_authorize_vpc_endpoint_access">aws_opensearch_authorize_vpc_endpoint_access</a>.
    /// </summary>
    type OpensearchAuthorizeVpcEndpointAccessBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpensearchAuthorizeVpcEndpointAccessState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchAuthorizeVpcEndpointAccessState<Missing, Missing>)

        member _.Zero(()) : OpensearchAuthorizeVpcEndpointAccessState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchAuthorizeVpcEndpointAccessState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_authorize_vpc_endpoint_access#account-1">OpensearchAuthorizeVpcEndpointAccess#account</a>.
        /// </summary>
        [<CustomOperation "account">]
        member _.Account(state: OpensearchAuthorizeVpcEndpointAccessState<Missing, 'DomainName>, value: string) : OpensearchAuthorizeVpcEndpointAccessState<Present, 'DomainName> =
            state.assignments.Add(fun config -> config.Account <- value)
            ({ assignments = state.assignments } : OpensearchAuthorizeVpcEndpointAccessState<Present, 'DomainName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_authorize_vpc_endpoint_access#domain_name-1">OpensearchAuthorizeVpcEndpointAccess#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: OpensearchAuthorizeVpcEndpointAccessState<'Account, Missing>, value: string) : OpensearchAuthorizeVpcEndpointAccessState<'Account, Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : OpensearchAuthorizeVpcEndpointAccessState<'Account, Present>)

        member _.Run(state: OpensearchAuthorizeVpcEndpointAccessState<Present, Present>) : aws.OpensearchAuthorizeVpcEndpointAccess.OpensearchAuthorizeVpcEndpointAccess =
            let config = aws.OpensearchAuthorizeVpcEndpointAccess.OpensearchAuthorizeVpcEndpointAccessConfig()
            for setter in state.assignments do
                setter config
            aws.OpensearchAuthorizeVpcEndpointAccess.OpensearchAuthorizeVpcEndpointAccess(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opensearchAuthorizeVpcEndpointAccess: missing required arguments. Must call: account, domain_name.", 9999, IsError = true)>]
        member _.Run(_: OpensearchAuthorizeVpcEndpointAccessState<_, _>) : aws.OpensearchAuthorizeVpcEndpointAccess.OpensearchAuthorizeVpcEndpointAccess =
            Unchecked.defaultof<aws.OpensearchAuthorizeVpcEndpointAccess.OpensearchAuthorizeVpcEndpointAccess>
