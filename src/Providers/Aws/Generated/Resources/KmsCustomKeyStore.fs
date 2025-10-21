namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KmsCustomKeyStoreState<'CustomKeyStoreName> = { assignments: ResizeArray<aws.KmsCustomKeyStore.KmsCustomKeyStoreConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store">aws_kms_custom_key_store</a>.
    /// </summary>
    type KmsCustomKeyStoreBuilder(logicalId: string) =
        member _.Yield(_: unit) : KmsCustomKeyStoreState<Missing> =
            ({ assignments = ResizeArray() } : KmsCustomKeyStoreState<Missing>)

        member _.Zero(()) : KmsCustomKeyStoreState<Missing> =
            ({ assignments = ResizeArray() } : KmsCustomKeyStoreState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#custom_key_store_name-1">KmsCustomKeyStore#custom_key_store_name</a>.
        /// </summary>
        [<CustomOperation "custom_key_store_name">]
        member _.CustomKeyStoreName(state: KmsCustomKeyStoreState<Missing>, value: string) : KmsCustomKeyStoreState<Present> =
            state.assignments.Add(fun config -> config.CustomKeyStoreName <- value)
            ({ assignments = state.assignments } : KmsCustomKeyStoreState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#cloud_hsm_cluster_id-1">KmsCustomKeyStore#cloud_hsm_cluster_id</a>.
        /// </summary>
        [<CustomOperation "cloud_hsm_cluster_id">]
        member _.CloudHsmClusterId(state: KmsCustomKeyStoreState<'CustomKeyStoreName>, value: string) : KmsCustomKeyStoreState<'CustomKeyStoreName> =
            state.assignments.Add(fun config -> config.CloudHsmClusterId <- value)
            state : KmsCustomKeyStoreState<'CustomKeyStoreName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#custom_key_store_type-1">KmsCustomKeyStore#custom_key_store_type</a>.
        /// </summary>
        [<CustomOperation "custom_key_store_type">]
        member _.CustomKeyStoreType(state: KmsCustomKeyStoreState<'CustomKeyStoreName>, value: string) : KmsCustomKeyStoreState<'CustomKeyStoreName> =
            state.assignments.Add(fun config -> config.CustomKeyStoreType <- value)
            state : KmsCustomKeyStoreState<'CustomKeyStoreName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#id-1">KmsCustomKeyStore#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KmsCustomKeyStoreState<'CustomKeyStoreName>, value: string) : KmsCustomKeyStoreState<'CustomKeyStoreName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KmsCustomKeyStoreState<'CustomKeyStoreName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#key_store_password-1">KmsCustomKeyStore#key_store_password</a>.
        /// </summary>
        [<CustomOperation "key_store_password">]
        member _.KeyStorePassword(state: KmsCustomKeyStoreState<'CustomKeyStoreName>, value: string) : KmsCustomKeyStoreState<'CustomKeyStoreName> =
            state.assignments.Add(fun config -> config.KeyStorePassword <- value)
            state : KmsCustomKeyStoreState<'CustomKeyStoreName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#timeouts-1">KmsCustomKeyStore#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KmsCustomKeyStoreState<'CustomKeyStoreName>, value: aws.KmsCustomKeyStore.KmsCustomKeyStoreTimeouts) : KmsCustomKeyStoreState<'CustomKeyStoreName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KmsCustomKeyStoreState<'CustomKeyStoreName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#trust_anchor_certificate-1">KmsCustomKeyStore#trust_anchor_certificate</a>.
        /// </summary>
        [<CustomOperation "trust_anchor_certificate">]
        member _.TrustAnchorCertificate(state: KmsCustomKeyStoreState<'CustomKeyStoreName>, value: string) : KmsCustomKeyStoreState<'CustomKeyStoreName> =
            state.assignments.Add(fun config -> config.TrustAnchorCertificate <- value)
            state : KmsCustomKeyStoreState<'CustomKeyStoreName>

        /// <summary>
        /// xks_proxy_authentication_credential block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#xks_proxy_authentication_credential-1">KmsCustomKeyStore#xks_proxy_authentication_credential</a>
        /// </summary>
        [<CustomOperation "xks_proxy_authentication_credential">]
        member _.XksProxyAuthenticationCredential(state: KmsCustomKeyStoreState<'CustomKeyStoreName>, value: aws.KmsCustomKeyStore.KmsCustomKeyStoreXksProxyAuthenticationCredential) : KmsCustomKeyStoreState<'CustomKeyStoreName> =
            state.assignments.Add(fun config -> config.XksProxyAuthenticationCredential <- value)
            state : KmsCustomKeyStoreState<'CustomKeyStoreName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#xks_proxy_connectivity-1">KmsCustomKeyStore#xks_proxy_connectivity</a>.
        /// </summary>
        [<CustomOperation "xks_proxy_connectivity">]
        member _.XksProxyConnectivity(state: KmsCustomKeyStoreState<'CustomKeyStoreName>, value: string) : KmsCustomKeyStoreState<'CustomKeyStoreName> =
            state.assignments.Add(fun config -> config.XksProxyConnectivity <- value)
            state : KmsCustomKeyStoreState<'CustomKeyStoreName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#xks_proxy_uri_endpoint-1">KmsCustomKeyStore#xks_proxy_uri_endpoint</a>.
        /// </summary>
        [<CustomOperation "xks_proxy_uri_endpoint">]
        member _.XksProxyUriEndpoint(state: KmsCustomKeyStoreState<'CustomKeyStoreName>, value: string) : KmsCustomKeyStoreState<'CustomKeyStoreName> =
            state.assignments.Add(fun config -> config.XksProxyUriEndpoint <- value)
            state : KmsCustomKeyStoreState<'CustomKeyStoreName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#xks_proxy_uri_path-1">KmsCustomKeyStore#xks_proxy_uri_path</a>.
        /// </summary>
        [<CustomOperation "xks_proxy_uri_path">]
        member _.XksProxyUriPath(state: KmsCustomKeyStoreState<'CustomKeyStoreName>, value: string) : KmsCustomKeyStoreState<'CustomKeyStoreName> =
            state.assignments.Add(fun config -> config.XksProxyUriPath <- value)
            state : KmsCustomKeyStoreState<'CustomKeyStoreName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#xks_proxy_vpc_endpoint_service_name-1">KmsCustomKeyStore#xks_proxy_vpc_endpoint_service_name</a>.
        /// </summary>
        [<CustomOperation "xks_proxy_vpc_endpoint_service_name">]
        member _.XksProxyVpcEndpointServiceName(state: KmsCustomKeyStoreState<'CustomKeyStoreName>, value: string) : KmsCustomKeyStoreState<'CustomKeyStoreName> =
            state.assignments.Add(fun config -> config.XksProxyVpcEndpointServiceName <- value)
            state : KmsCustomKeyStoreState<'CustomKeyStoreName>

        member _.Run(state: KmsCustomKeyStoreState<Present>) : aws.KmsCustomKeyStore.KmsCustomKeyStore =
            let config = aws.KmsCustomKeyStore.KmsCustomKeyStoreConfig()
            for setter in state.assignments do
                setter config
            aws.KmsCustomKeyStore.KmsCustomKeyStore(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kmsCustomKeyStore: missing required arguments. Must call: custom_key_store_name.", 9999, IsError = true)>]
        member _.Run(_: KmsCustomKeyStoreState<_>) : aws.KmsCustomKeyStore.KmsCustomKeyStore =
            Unchecked.defaultof<aws.KmsCustomKeyStore.KmsCustomKeyStore>
