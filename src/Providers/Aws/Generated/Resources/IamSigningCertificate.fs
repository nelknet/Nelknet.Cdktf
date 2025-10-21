namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamSigningCertificateState<'CertificateBody, 'UserName> = { assignments: ResizeArray<aws.IamSigningCertificate.IamSigningCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_signing_certificate">aws_iam_signing_certificate</a>.
    /// </summary>
    type IamSigningCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamSigningCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamSigningCertificateState<Missing, Missing>)

        member _.Zero(()) : IamSigningCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamSigningCertificateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_signing_certificate#certificate_body-1">IamSigningCertificate#certificate_body</a>.
        /// </summary>
        [<CustomOperation "certificate_body">]
        member _.CertificateBody(state: IamSigningCertificateState<Missing, 'UserName>, value: string) : IamSigningCertificateState<Present, 'UserName> =
            state.assignments.Add(fun config -> config.CertificateBody <- value)
            ({ assignments = state.assignments } : IamSigningCertificateState<Present, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_signing_certificate#user_name-1">IamSigningCertificate#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: IamSigningCertificateState<'CertificateBody, Missing>, value: string) : IamSigningCertificateState<'CertificateBody, Present> =
            state.assignments.Add(fun config -> config.UserName <- value)
            ({ assignments = state.assignments } : IamSigningCertificateState<'CertificateBody, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_signing_certificate#id-1">IamSigningCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamSigningCertificateState<'CertificateBody, 'UserName>, value: string) : IamSigningCertificateState<'CertificateBody, 'UserName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamSigningCertificateState<'CertificateBody, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_signing_certificate#status-1">IamSigningCertificate#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: IamSigningCertificateState<'CertificateBody, 'UserName>, value: string) : IamSigningCertificateState<'CertificateBody, 'UserName> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : IamSigningCertificateState<'CertificateBody, 'UserName>

        member _.Run(state: IamSigningCertificateState<Present, Present>) : aws.IamSigningCertificate.IamSigningCertificate =
            let config = aws.IamSigningCertificate.IamSigningCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.IamSigningCertificate.IamSigningCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamSigningCertificate: missing required arguments. Must call: certificate_body, user_name.", 9999, IsError = true)>]
        member _.Run(_: IamSigningCertificateState<_, _>) : aws.IamSigningCertificate.IamSigningCertificate =
            Unchecked.defaultof<aws.IamSigningCertificate.IamSigningCertificate>
