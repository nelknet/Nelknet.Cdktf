namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAcmpcaCertificateAuthorityState<'Arn> = { assignments: ResizeArray<aws.DataAwsAcmpcaCertificateAuthority.DataAwsAcmpcaCertificateAuthorityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acmpca_certificate_authority">aws_acmpca_certificate_authority</a>.
    /// </summary>
    type DataAwsAcmpcaCertificateAuthorityBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAcmpcaCertificateAuthorityState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsAcmpcaCertificateAuthorityState<Missing>)

        member _.Zero(()) : DataAwsAcmpcaCertificateAuthorityState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsAcmpcaCertificateAuthorityState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acmpca_certificate_authority#arn-1">DataAwsAcmpcaCertificateAuthority#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsAcmpcaCertificateAuthorityState<Missing>, value: string) : DataAwsAcmpcaCertificateAuthorityState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsAcmpcaCertificateAuthorityState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acmpca_certificate_authority#id-1">DataAwsAcmpcaCertificateAuthority#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAcmpcaCertificateAuthorityState<'Arn>, value: string) : DataAwsAcmpcaCertificateAuthorityState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAcmpcaCertificateAuthorityState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acmpca_certificate_authority#tags-1">DataAwsAcmpcaCertificateAuthority#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsAcmpcaCertificateAuthorityState<'Arn>, value: seq<string * string>) : DataAwsAcmpcaCertificateAuthorityState<'Arn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsAcmpcaCertificateAuthorityState<'Arn>

        member _.Run(state: DataAwsAcmpcaCertificateAuthorityState<Present>) : aws.DataAwsAcmpcaCertificateAuthority.DataAwsAcmpcaCertificateAuthority =
            let config = aws.DataAwsAcmpcaCertificateAuthority.DataAwsAcmpcaCertificateAuthorityConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAcmpcaCertificateAuthority.DataAwsAcmpcaCertificateAuthority(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAcmpcaCertificateAuthority: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAcmpcaCertificateAuthorityState<_>) : aws.DataAwsAcmpcaCertificateAuthority.DataAwsAcmpcaCertificateAuthority =
            Unchecked.defaultof<aws.DataAwsAcmpcaCertificateAuthority.DataAwsAcmpcaCertificateAuthority>
