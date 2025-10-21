namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDmsCertificateState<'CertificateId> = { assignments: ResizeArray<aws.DataAwsDmsCertificate.DataAwsDmsCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_certificate">aws_dms_certificate</a>.
    /// </summary>
    type DataAwsDmsCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDmsCertificateState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDmsCertificateState<Missing>)

        member _.Zero(()) : DataAwsDmsCertificateState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDmsCertificateState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_certificate#certificate_id-1">DataAwsDmsCertificate#certificate_id</a>.
        /// </summary>
        [<CustomOperation "certificate_id">]
        member _.CertificateId(state: DataAwsDmsCertificateState<Missing>, value: string) : DataAwsDmsCertificateState<Present> =
            state.assignments.Add(fun config -> config.CertificateId <- value)
            ({ assignments = state.assignments } : DataAwsDmsCertificateState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_certificate#id-1">DataAwsDmsCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDmsCertificateState<'CertificateId>, value: string) : DataAwsDmsCertificateState<'CertificateId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDmsCertificateState<'CertificateId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_certificate#tags-1">DataAwsDmsCertificate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsDmsCertificateState<'CertificateId>, value: seq<string * string>) : DataAwsDmsCertificateState<'CertificateId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsDmsCertificateState<'CertificateId>

        member _.Run(state: DataAwsDmsCertificateState<Present>) : aws.DataAwsDmsCertificate.DataAwsDmsCertificate =
            let config = aws.DataAwsDmsCertificate.DataAwsDmsCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDmsCertificate.DataAwsDmsCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDmsCertificate: missing required arguments. Must call: certificate_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDmsCertificateState<_>) : aws.DataAwsDmsCertificate.DataAwsDmsCertificate =
            Unchecked.defaultof<aws.DataAwsDmsCertificate.DataAwsDmsCertificate>
