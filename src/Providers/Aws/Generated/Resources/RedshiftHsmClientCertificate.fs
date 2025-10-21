namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftHsmClientCertificateState<'HsmClientCertificateIdentifier> = { assignments: ResizeArray<aws.RedshiftHsmClientCertificate.RedshiftHsmClientCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_hsm_client_certificate">aws_redshift_hsm_client_certificate</a>.
    /// </summary>
    type RedshiftHsmClientCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftHsmClientCertificateState<Missing> =
            ({ assignments = ResizeArray() } : RedshiftHsmClientCertificateState<Missing>)

        member _.Zero(()) : RedshiftHsmClientCertificateState<Missing> =
            ({ assignments = ResizeArray() } : RedshiftHsmClientCertificateState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_hsm_client_certificate#hsm_client_certificate_identifier-1">RedshiftHsmClientCertificate#hsm_client_certificate_identifier</a>.
        /// </summary>
        [<CustomOperation "hsm_client_certificate_identifier">]
        member _.HsmClientCertificateIdentifier(state: RedshiftHsmClientCertificateState<Missing>, value: string) : RedshiftHsmClientCertificateState<Present> =
            state.assignments.Add(fun config -> config.HsmClientCertificateIdentifier <- value)
            ({ assignments = state.assignments } : RedshiftHsmClientCertificateState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_hsm_client_certificate#id-1">RedshiftHsmClientCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftHsmClientCertificateState<'HsmClientCertificateIdentifier>, value: string) : RedshiftHsmClientCertificateState<'HsmClientCertificateIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftHsmClientCertificateState<'HsmClientCertificateIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_hsm_client_certificate#tags-1">RedshiftHsmClientCertificate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedshiftHsmClientCertificateState<'HsmClientCertificateIdentifier>, value: seq<string * string>) : RedshiftHsmClientCertificateState<'HsmClientCertificateIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedshiftHsmClientCertificateState<'HsmClientCertificateIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_hsm_client_certificate#tags_all-1">RedshiftHsmClientCertificate#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RedshiftHsmClientCertificateState<'HsmClientCertificateIdentifier>, value: seq<string * string>) : RedshiftHsmClientCertificateState<'HsmClientCertificateIdentifier> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RedshiftHsmClientCertificateState<'HsmClientCertificateIdentifier>

        member _.Run(state: RedshiftHsmClientCertificateState<Present>) : aws.RedshiftHsmClientCertificate.RedshiftHsmClientCertificate =
            let config = aws.RedshiftHsmClientCertificate.RedshiftHsmClientCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftHsmClientCertificate.RedshiftHsmClientCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftHsmClientCertificate: missing required arguments. Must call: hsm_client_certificate_identifier.", 9999, IsError = true)>]
        member _.Run(_: RedshiftHsmClientCertificateState<_>) : aws.RedshiftHsmClientCertificate.RedshiftHsmClientCertificate =
            Unchecked.defaultof<aws.RedshiftHsmClientCertificate.RedshiftHsmClientCertificate>
