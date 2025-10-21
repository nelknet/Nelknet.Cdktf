namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration> = { assignments: ResizeArray<aws.AcmpcaCertificateAuthority.AcmpcaCertificateAuthorityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority">aws_acmpca_certificate_authority</a>.
    /// </summary>
    type AcmpcaCertificateAuthorityBuilder(logicalId: string) =
        member _.Yield(_: unit) : AcmpcaCertificateAuthorityState<Missing> =
            ({ assignments = ResizeArray() } : AcmpcaCertificateAuthorityState<Missing>)

        member _.Zero(()) : AcmpcaCertificateAuthorityState<Missing> =
            ({ assignments = ResizeArray() } : AcmpcaCertificateAuthorityState<Missing>)

        /// <summary>
        /// certificate_authority_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#certificate_authority_configuration-1">AcmpcaCertificateAuthority#certificate_authority_configuration</a>
        /// </summary>
        [<CustomOperation "certificate_authority_configuration">]
        member _.CertificateAuthorityConfiguration(state: AcmpcaCertificateAuthorityState<Missing>, value: aws.AcmpcaCertificateAuthority.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration) : AcmpcaCertificateAuthorityState<Present> =
            state.assignments.Add(fun config -> config.CertificateAuthorityConfiguration <- value)
            ({ assignments = state.assignments } : AcmpcaCertificateAuthorityState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#enabled-1">AcmpcaCertificateAuthority#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>, value: bool) : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#enabled-1">AcmpcaCertificateAuthority#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>, value: HashiCorp.Cdktf.IResolvable) : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#id-1">AcmpcaCertificateAuthority#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>, value: string) : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#key_storage_security_standard-1">AcmpcaCertificateAuthority#key_storage_security_standard</a>.
        /// </summary>
        [<CustomOperation "key_storage_security_standard">]
        member _.KeyStorageSecurityStandard(state: AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>, value: string) : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration> =
            state.assignments.Add(fun config -> config.KeyStorageSecurityStandard <- value)
            state : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#permanent_deletion_time_in_days-1">AcmpcaCertificateAuthority#permanent_deletion_time_in_days</a>.
        /// </summary>
        [<CustomOperation "permanent_deletion_time_in_days">]
        member _.PermanentDeletionTimeInDays(state: AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>, value: double) : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration> =
            state.assignments.Add(fun config -> config.PermanentDeletionTimeInDays <- value)
            state : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>

        /// <summary>
        /// revocation_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#revocation_configuration-1">AcmpcaCertificateAuthority#revocation_configuration</a>
        /// </summary>
        [<CustomOperation "revocation_configuration">]
        member _.RevocationConfiguration(state: AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>, value: aws.AcmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfiguration) : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration> =
            state.assignments.Add(fun config -> config.RevocationConfiguration <- value)
            state : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#tags-1">AcmpcaCertificateAuthority#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>, value: seq<string * string>) : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#tags_all-1">AcmpcaCertificateAuthority#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>, value: seq<string * string>) : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#timeouts-1">AcmpcaCertificateAuthority#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>, value: aws.AcmpcaCertificateAuthority.AcmpcaCertificateAuthorityTimeouts) : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#type-1">AcmpcaCertificateAuthority#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>, value: string) : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#usage_mode-1">AcmpcaCertificateAuthority#usage_mode</a>.
        /// </summary>
        [<CustomOperation "usage_mode">]
        member _.UsageMode(state: AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>, value: string) : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration> =
            state.assignments.Add(fun config -> config.UsageMode <- value)
            state : AcmpcaCertificateAuthorityState<'CertificateAuthorityConfiguration>

        member _.Run(state: AcmpcaCertificateAuthorityState<Present>) : aws.AcmpcaCertificateAuthority.AcmpcaCertificateAuthority =
            let config = aws.AcmpcaCertificateAuthority.AcmpcaCertificateAuthorityConfig()
            for setter in state.assignments do
                setter config
            aws.AcmpcaCertificateAuthority.AcmpcaCertificateAuthority(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.acmpcaCertificateAuthority: missing required arguments. Must call: certificate_authority_configuration.", 9999, IsError = true)>]
        member _.Run(_: AcmpcaCertificateAuthorityState<_>) : aws.AcmpcaCertificateAuthority.AcmpcaCertificateAuthority =
            Unchecked.defaultof<aws.AcmpcaCertificateAuthority.AcmpcaCertificateAuthority>
