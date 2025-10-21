namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SignerSigningProfileState<'PlatformId> = { assignments: ResizeArray<aws.SignerSigningProfile.SignerSigningProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile">aws_signer_signing_profile</a>.
    /// </summary>
    type SignerSigningProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : SignerSigningProfileState<Missing> =
            ({ assignments = ResizeArray() } : SignerSigningProfileState<Missing>)

        member _.Zero(()) : SignerSigningProfileState<Missing> =
            ({ assignments = ResizeArray() } : SignerSigningProfileState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#platform_id-1">SignerSigningProfile#platform_id</a>.
        /// </summary>
        [<CustomOperation "platform_id">]
        member _.PlatformId(state: SignerSigningProfileState<Missing>, value: string) : SignerSigningProfileState<Present> =
            state.assignments.Add(fun config -> config.PlatformId <- value)
            ({ assignments = state.assignments } : SignerSigningProfileState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#id-1">SignerSigningProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SignerSigningProfileState<'PlatformId>, value: string) : SignerSigningProfileState<'PlatformId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SignerSigningProfileState<'PlatformId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#name-1">SignerSigningProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SignerSigningProfileState<'PlatformId>, value: string) : SignerSigningProfileState<'PlatformId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SignerSigningProfileState<'PlatformId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#name_prefix-1">SignerSigningProfile#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: SignerSigningProfileState<'PlatformId>, value: string) : SignerSigningProfileState<'PlatformId> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : SignerSigningProfileState<'PlatformId>

        /// <summary>
        /// signature_validity_period block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#signature_validity_period-1">SignerSigningProfile#signature_validity_period</a>
        /// </summary>
        [<CustomOperation "signature_validity_period">]
        member _.SignatureValidityPeriod(state: SignerSigningProfileState<'PlatformId>, value: aws.SignerSigningProfile.SignerSigningProfileSignatureValidityPeriod) : SignerSigningProfileState<'PlatformId> =
            state.assignments.Add(fun config -> config.SignatureValidityPeriod <- value)
            state : SignerSigningProfileState<'PlatformId>

        /// <summary>
        /// signing_material block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#signing_material-1">SignerSigningProfile#signing_material</a>
        /// </summary>
        [<CustomOperation "signing_material">]
        member _.SigningMaterial(state: SignerSigningProfileState<'PlatformId>, value: aws.SignerSigningProfile.SignerSigningProfileSigningMaterial) : SignerSigningProfileState<'PlatformId> =
            state.assignments.Add(fun config -> config.SigningMaterial <- value)
            state : SignerSigningProfileState<'PlatformId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#tags-1">SignerSigningProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SignerSigningProfileState<'PlatformId>, value: seq<string * string>) : SignerSigningProfileState<'PlatformId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SignerSigningProfileState<'PlatformId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile#tags_all-1">SignerSigningProfile#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SignerSigningProfileState<'PlatformId>, value: seq<string * string>) : SignerSigningProfileState<'PlatformId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SignerSigningProfileState<'PlatformId>

        member _.Run(state: SignerSigningProfileState<Present>) : aws.SignerSigningProfile.SignerSigningProfile =
            let config = aws.SignerSigningProfile.SignerSigningProfileConfig()
            for setter in state.assignments do
                setter config
            aws.SignerSigningProfile.SignerSigningProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.signerSigningProfile: missing required arguments. Must call: platform_id.", 9999, IsError = true)>]
        member _.Run(_: SignerSigningProfileState<_>) : aws.SignerSigningProfile.SignerSigningProfile =
            Unchecked.defaultof<aws.SignerSigningProfile.SignerSigningProfile>
