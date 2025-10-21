using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HpcCache
{
    [JsiiInterface(nativeType: typeof(IHpcCacheDirectoryLdap), fullyQualifiedName: "azurerm.hpcCache.HpcCacheDirectoryLdap")]
    public interface IHpcCacheDirectoryLdap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#base_dn HpcCache#base_dn}.</summary>
        [JsiiProperty(name: "baseDn", typeJson: "{\"primitive\":\"string\"}")]
        string BaseDn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#server HpcCache#server}.</summary>
        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}")]
        string Server
        {
            get;
        }

        /// <summary>bind block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#bind HpcCache#bind}
        /// </remarks>
        [JsiiProperty(name: "bind", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryLdapBind\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HpcCache.IHpcCacheDirectoryLdapBind? Bind
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#certificate_validation_uri HpcCache#certificate_validation_uri}.</summary>
        [JsiiProperty(name: "certificateValidationUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateValidationUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#download_certificate_automatically HpcCache#download_certificate_automatically}.</summary>
        [JsiiProperty(name: "downloadCertificateAutomatically", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DownloadCertificateAutomatically
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#encrypted HpcCache#encrypted}.</summary>
        [JsiiProperty(name: "encrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Encrypted
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHpcCacheDirectoryLdap), fullyQualifiedName: "azurerm.hpcCache.HpcCacheDirectoryLdap")]
        internal sealed class _Proxy : DeputyBase, azurerm.HpcCache.IHpcCacheDirectoryLdap
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#base_dn HpcCache#base_dn}.</summary>
            [JsiiProperty(name: "baseDn", typeJson: "{\"primitive\":\"string\"}")]
            public string BaseDn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#server HpcCache#server}.</summary>
            [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}")]
            public string Server
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>bind block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#bind HpcCache#bind}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bind", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryLdapBind\"}", isOptional: true)]
            public azurerm.HpcCache.IHpcCacheDirectoryLdapBind? Bind
            {
                get => GetInstanceProperty<azurerm.HpcCache.IHpcCacheDirectoryLdapBind?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#certificate_validation_uri HpcCache#certificate_validation_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateValidationUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateValidationUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#download_certificate_automatically HpcCache#download_certificate_automatically}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "downloadCertificateAutomatically", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DownloadCertificateAutomatically
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#encrypted HpcCache#encrypted}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Encrypted
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
