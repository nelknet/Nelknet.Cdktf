namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCodeartifactRepositoryEndpointState<'Domain, 'Format, 'Repository> = { assignments: ResizeArray<aws.DataAwsCodeartifactRepositoryEndpoint.DataAwsCodeartifactRepositoryEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codeartifact_repository_endpoint">aws_codeartifact_repository_endpoint</a>.
    /// </summary>
    type DataAwsCodeartifactRepositoryEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCodeartifactRepositoryEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsCodeartifactRepositoryEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAwsCodeartifactRepositoryEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsCodeartifactRepositoryEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codeartifact_repository_endpoint#domain-1">DataAwsCodeartifactRepositoryEndpoint#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: DataAwsCodeartifactRepositoryEndpointState<Missing, 'Format, 'Repository>, value: string) : DataAwsCodeartifactRepositoryEndpointState<Present, 'Format, 'Repository> =
            state.assignments.Add(fun config -> config.Domain <- value)
            ({ assignments = state.assignments } : DataAwsCodeartifactRepositoryEndpointState<Present, 'Format, 'Repository>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codeartifact_repository_endpoint#format-1">DataAwsCodeartifactRepositoryEndpoint#format</a>.
        /// </summary>
        [<CustomOperation "format">]
        member _.Format(state: DataAwsCodeartifactRepositoryEndpointState<'Domain, Missing, 'Repository>, value: string) : DataAwsCodeartifactRepositoryEndpointState<'Domain, Present, 'Repository> =
            state.assignments.Add(fun config -> config.Format <- value)
            ({ assignments = state.assignments } : DataAwsCodeartifactRepositoryEndpointState<'Domain, Present, 'Repository>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codeartifact_repository_endpoint#repository-1">DataAwsCodeartifactRepositoryEndpoint#repository</a>.
        /// </summary>
        [<CustomOperation "repository">]
        member _.Repository(state: DataAwsCodeartifactRepositoryEndpointState<'Domain, 'Format, Missing>, value: string) : DataAwsCodeartifactRepositoryEndpointState<'Domain, 'Format, Present> =
            state.assignments.Add(fun config -> config.Repository <- value)
            ({ assignments = state.assignments } : DataAwsCodeartifactRepositoryEndpointState<'Domain, 'Format, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codeartifact_repository_endpoint#domain_owner-1">DataAwsCodeartifactRepositoryEndpoint#domain_owner</a>.
        /// </summary>
        [<CustomOperation "domain_owner">]
        member _.DomainOwner(state: DataAwsCodeartifactRepositoryEndpointState<'Domain, 'Format, 'Repository>, value: string) : DataAwsCodeartifactRepositoryEndpointState<'Domain, 'Format, 'Repository> =
            state.assignments.Add(fun config -> config.DomainOwner <- value)
            state : DataAwsCodeartifactRepositoryEndpointState<'Domain, 'Format, 'Repository>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codeartifact_repository_endpoint#id-1">DataAwsCodeartifactRepositoryEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCodeartifactRepositoryEndpointState<'Domain, 'Format, 'Repository>, value: string) : DataAwsCodeartifactRepositoryEndpointState<'Domain, 'Format, 'Repository> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCodeartifactRepositoryEndpointState<'Domain, 'Format, 'Repository>

        member _.Run(state: DataAwsCodeartifactRepositoryEndpointState<Present, Present, Present>) : aws.DataAwsCodeartifactRepositoryEndpoint.DataAwsCodeartifactRepositoryEndpoint =
            let config = aws.DataAwsCodeartifactRepositoryEndpoint.DataAwsCodeartifactRepositoryEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCodeartifactRepositoryEndpoint.DataAwsCodeartifactRepositoryEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCodeartifactRepositoryEndpoint: missing required arguments. Must call: domain, format, repository.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCodeartifactRepositoryEndpointState<_, _, _>) : aws.DataAwsCodeartifactRepositoryEndpoint.DataAwsCodeartifactRepositoryEndpoint =
            Unchecked.defaultof<aws.DataAwsCodeartifactRepositoryEndpoint.DataAwsCodeartifactRepositoryEndpoint>
