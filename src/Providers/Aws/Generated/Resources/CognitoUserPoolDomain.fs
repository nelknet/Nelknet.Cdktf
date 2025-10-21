namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitoUserPoolDomainState<'Domain, 'UserPoolId> = { assignments: ResizeArray<aws.CognitoUserPoolDomain.CognitoUserPoolDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_domain">aws_cognito_user_pool_domain</a>.
    /// </summary>
    type CognitoUserPoolDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitoUserPoolDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoUserPoolDomainState<Missing, Missing>)

        member _.Zero(()) : CognitoUserPoolDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoUserPoolDomainState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_domain#domain-1">CognitoUserPoolDomain#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: CognitoUserPoolDomainState<Missing, 'UserPoolId>, value: string) : CognitoUserPoolDomainState<Present, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Domain <- value)
            ({ assignments = state.assignments } : CognitoUserPoolDomainState<Present, 'UserPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_domain#user_pool_id-1">CognitoUserPoolDomain#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: CognitoUserPoolDomainState<'Domain, Missing>, value: string) : CognitoUserPoolDomainState<'Domain, Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : CognitoUserPoolDomainState<'Domain, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_domain#certificate_arn-1">CognitoUserPoolDomain#certificate_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_arn">]
        member _.CertificateArn(state: CognitoUserPoolDomainState<'Domain, 'UserPoolId>, value: string) : CognitoUserPoolDomainState<'Domain, 'UserPoolId> =
            state.assignments.Add(fun config -> config.CertificateArn <- value)
            state : CognitoUserPoolDomainState<'Domain, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_domain#id-1">CognitoUserPoolDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CognitoUserPoolDomainState<'Domain, 'UserPoolId>, value: string) : CognitoUserPoolDomainState<'Domain, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CognitoUserPoolDomainState<'Domain, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_domain#managed_login_version-1">CognitoUserPoolDomain#managed_login_version</a>.
        /// </summary>
        [<CustomOperation "managed_login_version">]
        member _.ManagedLoginVersion(state: CognitoUserPoolDomainState<'Domain, 'UserPoolId>, value: double) : CognitoUserPoolDomainState<'Domain, 'UserPoolId> =
            state.assignments.Add(fun config -> config.ManagedLoginVersion <- value)
            state : CognitoUserPoolDomainState<'Domain, 'UserPoolId>

        member _.Run(state: CognitoUserPoolDomainState<Present, Present>) : aws.CognitoUserPoolDomain.CognitoUserPoolDomain =
            let config = aws.CognitoUserPoolDomain.CognitoUserPoolDomainConfig()
            for setter in state.assignments do
                setter config
            aws.CognitoUserPoolDomain.CognitoUserPoolDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cognitoUserPoolDomain: missing required arguments. Must call: domain, user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: CognitoUserPoolDomainState<_, _>) : aws.CognitoUserPoolDomain.CognitoUserPoolDomain =
            Unchecked.defaultof<aws.CognitoUserPoolDomain.CognitoUserPoolDomain>
