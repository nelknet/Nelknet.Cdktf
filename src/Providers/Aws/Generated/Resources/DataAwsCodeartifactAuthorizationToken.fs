namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCodeartifactAuthorizationTokenState<'Domain> = { assignments: ResizeArray<aws.DataAwsCodeartifactAuthorizationToken.DataAwsCodeartifactAuthorizationTokenConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codeartifact_authorization_token">aws_codeartifact_authorization_token</a>.
    /// </summary>
    type DataAwsCodeartifactAuthorizationTokenBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCodeartifactAuthorizationTokenState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCodeartifactAuthorizationTokenState<Missing>)

        member _.Zero(()) : DataAwsCodeartifactAuthorizationTokenState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCodeartifactAuthorizationTokenState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codeartifact_authorization_token#domain-1">DataAwsCodeartifactAuthorizationToken#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: DataAwsCodeartifactAuthorizationTokenState<Missing>, value: string) : DataAwsCodeartifactAuthorizationTokenState<Present> =
            state.assignments.Add(fun config -> config.Domain <- value)
            ({ assignments = state.assignments } : DataAwsCodeartifactAuthorizationTokenState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codeartifact_authorization_token#domain_owner-1">DataAwsCodeartifactAuthorizationToken#domain_owner</a>.
        /// </summary>
        [<CustomOperation "domain_owner">]
        member _.DomainOwner(state: DataAwsCodeartifactAuthorizationTokenState<'Domain>, value: string) : DataAwsCodeartifactAuthorizationTokenState<'Domain> =
            state.assignments.Add(fun config -> config.DomainOwner <- value)
            state : DataAwsCodeartifactAuthorizationTokenState<'Domain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codeartifact_authorization_token#duration_seconds-1">DataAwsCodeartifactAuthorizationToken#duration_seconds</a>.
        /// </summary>
        [<CustomOperation "duration_seconds">]
        member _.DurationSeconds(state: DataAwsCodeartifactAuthorizationTokenState<'Domain>, value: double) : DataAwsCodeartifactAuthorizationTokenState<'Domain> =
            state.assignments.Add(fun config -> config.DurationSeconds <- value)
            state : DataAwsCodeartifactAuthorizationTokenState<'Domain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codeartifact_authorization_token#id-1">DataAwsCodeartifactAuthorizationToken#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCodeartifactAuthorizationTokenState<'Domain>, value: string) : DataAwsCodeartifactAuthorizationTokenState<'Domain> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCodeartifactAuthorizationTokenState<'Domain>

        member _.Run(state: DataAwsCodeartifactAuthorizationTokenState<Present>) : aws.DataAwsCodeartifactAuthorizationToken.DataAwsCodeartifactAuthorizationToken =
            let config = aws.DataAwsCodeartifactAuthorizationToken.DataAwsCodeartifactAuthorizationTokenConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCodeartifactAuthorizationToken.DataAwsCodeartifactAuthorizationToken(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCodeartifactAuthorizationToken: missing required arguments. Must call: domain.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCodeartifactAuthorizationTokenState<_>) : aws.DataAwsCodeartifactAuthorizationToken.DataAwsCodeartifactAuthorizationToken =
            Unchecked.defaultof<aws.DataAwsCodeartifactAuthorizationToken.DataAwsCodeartifactAuthorizationToken>
