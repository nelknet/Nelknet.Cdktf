namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCognitoUserPoolSigningCertificateState<'UserPoolId> = { assignments: ResizeArray<aws.DataAwsCognitoUserPoolSigningCertificate.DataAwsCognitoUserPoolSigningCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pool_signing_certificate">aws_cognito_user_pool_signing_certificate</a>.
    /// </summary>
    type DataAwsCognitoUserPoolSigningCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCognitoUserPoolSigningCertificateState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoUserPoolSigningCertificateState<Missing>)

        member _.Zero(()) : DataAwsCognitoUserPoolSigningCertificateState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoUserPoolSigningCertificateState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pool_signing_certificate#user_pool_id-1">DataAwsCognitoUserPoolSigningCertificate#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: DataAwsCognitoUserPoolSigningCertificateState<Missing>, value: string) : DataAwsCognitoUserPoolSigningCertificateState<Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : DataAwsCognitoUserPoolSigningCertificateState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pool_signing_certificate#id-1">DataAwsCognitoUserPoolSigningCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCognitoUserPoolSigningCertificateState<'UserPoolId>, value: string) : DataAwsCognitoUserPoolSigningCertificateState<'UserPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCognitoUserPoolSigningCertificateState<'UserPoolId>

        member _.Run(state: DataAwsCognitoUserPoolSigningCertificateState<Present>) : aws.DataAwsCognitoUserPoolSigningCertificate.DataAwsCognitoUserPoolSigningCertificate =
            let config = aws.DataAwsCognitoUserPoolSigningCertificate.DataAwsCognitoUserPoolSigningCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCognitoUserPoolSigningCertificate.DataAwsCognitoUserPoolSigningCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCognitoUserPoolSigningCertificate: missing required arguments. Must call: user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCognitoUserPoolSigningCertificateState<_>) : aws.DataAwsCognitoUserPoolSigningCertificate.DataAwsCognitoUserPoolSigningCertificate =
            Unchecked.defaultof<aws.DataAwsCognitoUserPoolSigningCertificate.DataAwsCognitoUserPoolSigningCertificate>
