namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType> = { assignments: ResizeArray<aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider">aws_verifiedaccess_trust_provider</a>.
    /// </summary>
    type VerifiedaccessTrustProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : VerifiedaccessTrustProviderState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VerifiedaccessTrustProviderState<Missing, Missing>)

        member _.Zero(()) : VerifiedaccessTrustProviderState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VerifiedaccessTrustProviderState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#policy_reference_name-1">VerifiedaccessTrustProvider#policy_reference_name</a>.
        /// </summary>
        [<CustomOperation "policy_reference_name">]
        member _.PolicyReferenceName(state: VerifiedaccessTrustProviderState<Missing, 'TrustProviderType>, value: string) : VerifiedaccessTrustProviderState<Present, 'TrustProviderType> =
            state.assignments.Add(fun config -> config.PolicyReferenceName <- value)
            ({ assignments = state.assignments } : VerifiedaccessTrustProviderState<Present, 'TrustProviderType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#trust_provider_type-1">VerifiedaccessTrustProvider#trust_provider_type</a>.
        /// </summary>
        [<CustomOperation "trust_provider_type">]
        member _.TrustProviderType(state: VerifiedaccessTrustProviderState<'PolicyReferenceName, Missing>, value: string) : VerifiedaccessTrustProviderState<'PolicyReferenceName, Present> =
            state.assignments.Add(fun config -> config.TrustProviderType <- value)
            ({ assignments = state.assignments } : VerifiedaccessTrustProviderState<'PolicyReferenceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#description-1">VerifiedaccessTrustProvider#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>, value: string) : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>

        /// <summary>
        /// device_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#device_options-1">VerifiedaccessTrustProvider#device_options</a>
        /// </summary>
        [<CustomOperation "device_options">]
        member _.DeviceOptions(state: VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>, value: aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderDeviceOptions) : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType> =
            state.assignments.Add(fun config -> config.DeviceOptions <- value)
            state : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#device_trust_provider_type-1">VerifiedaccessTrustProvider#device_trust_provider_type</a>.
        /// </summary>
        [<CustomOperation "device_trust_provider_type">]
        member _.DeviceTrustProviderType(state: VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>, value: string) : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType> =
            state.assignments.Add(fun config -> config.DeviceTrustProviderType <- value)
            state : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#id-1">VerifiedaccessTrustProvider#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>, value: string) : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>

        /// <summary>
        /// native_application_oidc_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#native_application_oidc_options-1">VerifiedaccessTrustProvider#native_application_oidc_options</a>
        /// </summary>
        [<CustomOperation "native_application_oidc_options">]
        member _.NativeApplicationOidcOptions(state: VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>, value: aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderNativeApplicationOidcOptions) : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType> =
            state.assignments.Add(fun config -> config.NativeApplicationOidcOptions <- value)
            state : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>

        /// <summary>
        /// oidc_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#oidc_options-1">VerifiedaccessTrustProvider#oidc_options</a>
        /// </summary>
        [<CustomOperation "oidc_options">]
        member _.OidcOptions(state: VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>, value: aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderOidcOptions) : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType> =
            state.assignments.Add(fun config -> config.OidcOptions <- value)
            state : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>

        /// <summary>
        /// sse_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#sse_specification-1">VerifiedaccessTrustProvider#sse_specification</a>
        /// </summary>
        [<CustomOperation "sse_specification">]
        member _.SseSpecification(state: VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>, value: aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderSseSpecification) : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType> =
            state.assignments.Add(fun config -> config.SseSpecification <- value)
            state : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#tags-1">VerifiedaccessTrustProvider#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>, value: seq<string * string>) : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#tags_all-1">VerifiedaccessTrustProvider#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>, value: seq<string * string>) : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#timeouts-1">VerifiedaccessTrustProvider#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>, value: aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderTimeouts) : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#user_trust_provider_type-1">VerifiedaccessTrustProvider#user_trust_provider_type</a>.
        /// </summary>
        [<CustomOperation "user_trust_provider_type">]
        member _.UserTrustProviderType(state: VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>, value: string) : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType> =
            state.assignments.Add(fun config -> config.UserTrustProviderType <- value)
            state : VerifiedaccessTrustProviderState<'PolicyReferenceName, 'TrustProviderType>

        member _.Run(state: VerifiedaccessTrustProviderState<Present, Present>) : aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProvider =
            let config = aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderConfig()
            for setter in state.assignments do
                setter config
            aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProvider(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.verifiedaccessTrustProvider: missing required arguments. Must call: policy_reference_name, trust_provider_type.", 9999, IsError = true)>]
        member _.Run(_: VerifiedaccessTrustProviderState<_, _>) : aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProvider =
            Unchecked.defaultof<aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProvider>
