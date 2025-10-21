using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    [JsiiInterface(nativeType: typeof(IApiManagementCertificate), fullyQualifiedName: "azurerm.apiManagement.ApiManagementCertificate")]
    public interface IApiManagementCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#encoded_certificate ApiManagement#encoded_certificate}.</summary>
        [JsiiProperty(name: "encodedCertificate", typeJson: "{\"primitive\":\"string\"}")]
        string EncodedCertificate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#store_name ApiManagement#store_name}.</summary>
        [JsiiProperty(name: "storeName", typeJson: "{\"primitive\":\"string\"}")]
        string StoreName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#certificate_password ApiManagement#certificate_password}.</summary>
        [JsiiProperty(name: "certificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificatePassword
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementCertificate), fullyQualifiedName: "azurerm.apiManagement.ApiManagementCertificate")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagement.IApiManagementCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#encoded_certificate ApiManagement#encoded_certificate}.</summary>
            [JsiiProperty(name: "encodedCertificate", typeJson: "{\"primitive\":\"string\"}")]
            public string EncodedCertificate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#store_name ApiManagement#store_name}.</summary>
            [JsiiProperty(name: "storeName", typeJson: "{\"primitive\":\"string\"}")]
            public string StoreName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#certificate_password ApiManagement#certificate_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificatePassword
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
