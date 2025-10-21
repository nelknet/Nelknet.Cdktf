namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AcmpcaPermissionState<'Actions, 'CertificateAuthorityArn, 'Principal> = { assignments: ResizeArray<aws.AcmpcaPermission.AcmpcaPermissionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_permission">aws_acmpca_permission</a>.
    /// </summary>
    type AcmpcaPermissionBuilder(logicalId: string) =
        member _.Yield(_: unit) : AcmpcaPermissionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AcmpcaPermissionState<Missing, Missing, Missing>)

        member _.Zero(()) : AcmpcaPermissionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AcmpcaPermissionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_permission#actions-1">AcmpcaPermission#actions</a>.
        /// </summary>
        [<CustomOperation "actions">]
        member _.Actions(state: AcmpcaPermissionState<Missing, 'CertificateAuthorityArn, 'Principal>, value: seq<string>) : AcmpcaPermissionState<Present, 'CertificateAuthorityArn, 'Principal> =
            state.assignments.Add(fun config -> config.Actions <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : AcmpcaPermissionState<Present, 'CertificateAuthorityArn, 'Principal>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_permission#certificate_authority_arn-1">AcmpcaPermission#certificate_authority_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_authority_arn">]
        member _.CertificateAuthorityArn(state: AcmpcaPermissionState<'Actions, Missing, 'Principal>, value: string) : AcmpcaPermissionState<'Actions, Present, 'Principal> =
            state.assignments.Add(fun config -> config.CertificateAuthorityArn <- value)
            ({ assignments = state.assignments } : AcmpcaPermissionState<'Actions, Present, 'Principal>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_permission#principal-1">AcmpcaPermission#principal</a>.
        /// </summary>
        [<CustomOperation "principal">]
        member _.Principal(state: AcmpcaPermissionState<'Actions, 'CertificateAuthorityArn, Missing>, value: string) : AcmpcaPermissionState<'Actions, 'CertificateAuthorityArn, Present> =
            state.assignments.Add(fun config -> config.Principal <- value)
            ({ assignments = state.assignments } : AcmpcaPermissionState<'Actions, 'CertificateAuthorityArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_permission#id-1">AcmpcaPermission#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AcmpcaPermissionState<'Actions, 'CertificateAuthorityArn, 'Principal>, value: string) : AcmpcaPermissionState<'Actions, 'CertificateAuthorityArn, 'Principal> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AcmpcaPermissionState<'Actions, 'CertificateAuthorityArn, 'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_permission#source_account-1">AcmpcaPermission#source_account</a>.
        /// </summary>
        [<CustomOperation "source_account">]
        member _.SourceAccount(state: AcmpcaPermissionState<'Actions, 'CertificateAuthorityArn, 'Principal>, value: string) : AcmpcaPermissionState<'Actions, 'CertificateAuthorityArn, 'Principal> =
            state.assignments.Add(fun config -> config.SourceAccount <- value)
            state : AcmpcaPermissionState<'Actions, 'CertificateAuthorityArn, 'Principal>

        member _.Run(state: AcmpcaPermissionState<Present, Present, Present>) : aws.AcmpcaPermission.AcmpcaPermission =
            let config = aws.AcmpcaPermission.AcmpcaPermissionConfig()
            for setter in state.assignments do
                setter config
            aws.AcmpcaPermission.AcmpcaPermission(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.acmpcaPermission: missing required arguments. Must call: actions, certificate_authority_arn, principal.", 9999, IsError = true)>]
        member _.Run(_: AcmpcaPermissionState<_, _, _>) : aws.AcmpcaPermission.AcmpcaPermission =
            Unchecked.defaultof<aws.AcmpcaPermission.AcmpcaPermission>
