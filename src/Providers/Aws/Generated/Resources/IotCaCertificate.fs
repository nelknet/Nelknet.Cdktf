namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem> = { assignments: ResizeArray<aws.IotCaCertificate.IotCaCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate">aws_iot_ca_certificate</a>.
    /// </summary>
    type IotCaCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotCaCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IotCaCertificateState<Missing, Missing, Missing>)

        member _.Zero(()) : IotCaCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IotCaCertificateState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#active-1">IotCaCertificate#active</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: IotCaCertificateState<Missing, 'AllowAutoRegistration, 'CaCertificatePem>, value: bool) : IotCaCertificateState<Present, 'AllowAutoRegistration, 'CaCertificatePem> =
            state.assignments.Add(fun config -> config.Active <- value)
            ({ assignments = state.assignments } : IotCaCertificateState<Present, 'AllowAutoRegistration, 'CaCertificatePem>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#active-1">IotCaCertificate#active</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: IotCaCertificateState<Missing, 'AllowAutoRegistration, 'CaCertificatePem>, value: HashiCorp.Cdktf.IResolvable) : IotCaCertificateState<Present, 'AllowAutoRegistration, 'CaCertificatePem> =
            state.assignments.Add(fun config -> config.Active <- value)
            ({ assignments = state.assignments } : IotCaCertificateState<Present, 'AllowAutoRegistration, 'CaCertificatePem>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#allow_auto_registration-1">IotCaCertificate#allow_auto_registration</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_auto_registration">]
        member _.AllowAutoRegistration(state: IotCaCertificateState<'Active, Missing, 'CaCertificatePem>, value: bool) : IotCaCertificateState<'Active, Present, 'CaCertificatePem> =
            state.assignments.Add(fun config -> config.AllowAutoRegistration <- value)
            ({ assignments = state.assignments } : IotCaCertificateState<'Active, Present, 'CaCertificatePem>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#allow_auto_registration-1">IotCaCertificate#allow_auto_registration</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_auto_registration">]
        member _.AllowAutoRegistration(state: IotCaCertificateState<'Active, Missing, 'CaCertificatePem>, value: HashiCorp.Cdktf.IResolvable) : IotCaCertificateState<'Active, Present, 'CaCertificatePem> =
            state.assignments.Add(fun config -> config.AllowAutoRegistration <- value)
            ({ assignments = state.assignments } : IotCaCertificateState<'Active, Present, 'CaCertificatePem>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#ca_certificate_pem-1">IotCaCertificate#ca_certificate_pem</a>.
        /// </summary>
        [<CustomOperation "ca_certificate_pem">]
        member _.CaCertificatePem(state: IotCaCertificateState<'Active, 'AllowAutoRegistration, Missing>, value: string) : IotCaCertificateState<'Active, 'AllowAutoRegistration, Present> =
            state.assignments.Add(fun config -> config.CaCertificatePem <- value)
            ({ assignments = state.assignments } : IotCaCertificateState<'Active, 'AllowAutoRegistration, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#certificate_mode-1">IotCaCertificate#certificate_mode</a>.
        /// </summary>
        [<CustomOperation "certificate_mode">]
        member _.CertificateMode(state: IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem>, value: string) : IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem> =
            state.assignments.Add(fun config -> config.CertificateMode <- value)
            state : IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#id-1">IotCaCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem>, value: string) : IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem>

        /// <summary>
        /// registration_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#registration_config-1">IotCaCertificate#registration_config</a>
        /// </summary>
        [<CustomOperation "registration_config">]
        member _.RegistrationConfig(state: IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem>, value: aws.IotCaCertificate.IotCaCertificateRegistrationConfig) : IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem> =
            state.assignments.Add(fun config -> config.RegistrationConfig <- value)
            state : IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#tags-1">IotCaCertificate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem>, value: seq<string * string>) : IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#tags_all-1">IotCaCertificate#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem>, value: seq<string * string>) : IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#verification_certificate_pem-1">IotCaCertificate#verification_certificate_pem</a>.
        /// </summary>
        [<CustomOperation "verification_certificate_pem">]
        member _.VerificationCertificatePem(state: IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem>, value: string) : IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem> =
            state.assignments.Add(fun config -> config.VerificationCertificatePem <- value)
            state : IotCaCertificateState<'Active, 'AllowAutoRegistration, 'CaCertificatePem>

        member _.Run(state: IotCaCertificateState<Present, Present, Present>) : aws.IotCaCertificate.IotCaCertificate =
            let config = aws.IotCaCertificate.IotCaCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.IotCaCertificate.IotCaCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotCaCertificate: missing required arguments. Must call: active, allow_auto_registration, ca_certificate_pem.", 9999, IsError = true)>]
        member _.Run(_: IotCaCertificateState<_, _, _>) : aws.IotCaCertificate.IotCaCertificate =
            Unchecked.defaultof<aws.IotCaCertificate.IotCaCertificate>
