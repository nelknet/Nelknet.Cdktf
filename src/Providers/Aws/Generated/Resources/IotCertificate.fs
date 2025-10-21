namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotCertificateState<'Active> = { assignments: ResizeArray<aws.IotCertificate.IotCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_certificate">aws_iot_certificate</a>.
    /// </summary>
    type IotCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotCertificateState<Missing> =
            ({ assignments = ResizeArray() } : IotCertificateState<Missing>)

        member _.Zero(()) : IotCertificateState<Missing> =
            ({ assignments = ResizeArray() } : IotCertificateState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_certificate#active-1">IotCertificate#active</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: IotCertificateState<Missing>, value: bool) : IotCertificateState<Present> =
            state.assignments.Add(fun config -> config.Active <- value)
            ({ assignments = state.assignments } : IotCertificateState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_certificate#active-1">IotCertificate#active</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: IotCertificateState<Missing>, value: HashiCorp.Cdktf.IResolvable) : IotCertificateState<Present> =
            state.assignments.Add(fun config -> config.Active <- value)
            ({ assignments = state.assignments } : IotCertificateState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_certificate#ca_pem-1">IotCertificate#ca_pem</a>.
        /// </summary>
        [<CustomOperation "ca_pem">]
        member _.CaPem(state: IotCertificateState<'Active>, value: string) : IotCertificateState<'Active> =
            state.assignments.Add(fun config -> config.CaPem <- value)
            state : IotCertificateState<'Active>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_certificate#certificate_pem-1">IotCertificate#certificate_pem</a>.
        /// </summary>
        [<CustomOperation "certificate_pem">]
        member _.CertificatePem(state: IotCertificateState<'Active>, value: string) : IotCertificateState<'Active> =
            state.assignments.Add(fun config -> config.CertificatePem <- value)
            state : IotCertificateState<'Active>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_certificate#csr-1">IotCertificate#csr</a>.
        /// </summary>
        [<CustomOperation "csr">]
        member _.Csr(state: IotCertificateState<'Active>, value: string) : IotCertificateState<'Active> =
            state.assignments.Add(fun config -> config.Csr <- value)
            state : IotCertificateState<'Active>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_certificate#id-1">IotCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotCertificateState<'Active>, value: string) : IotCertificateState<'Active> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotCertificateState<'Active>

        member _.Run(state: IotCertificateState<Present>) : aws.IotCertificate.IotCertificate =
            let config = aws.IotCertificate.IotCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.IotCertificate.IotCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotCertificate: missing required arguments. Must call: active.", 9999, IsError = true)>]
        member _.Run(_: IotCertificateState<_>) : aws.IotCertificate.IotCertificate =
            Unchecked.defaultof<aws.IotCertificate.IotCertificate>
