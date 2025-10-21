using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Frontdoor
{
    [JsiiInterface(nativeType: typeof(IFrontdoorBackendPoolSettings), fullyQualifiedName: "azurerm.frontdoor.FrontdoorBackendPoolSettings")]
    public interface IFrontdoorBackendPoolSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#enforce_backend_pools_certificate_name_check Frontdoor#enforce_backend_pools_certificate_name_check}.</summary>
        [JsiiProperty(name: "enforceBackendPoolsCertificateNameCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object EnforceBackendPoolsCertificateNameCheck
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#backend_pools_send_receive_timeout_seconds Frontdoor#backend_pools_send_receive_timeout_seconds}.</summary>
        [JsiiProperty(name: "backendPoolsSendReceiveTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackendPoolsSendReceiveTimeoutSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFrontdoorBackendPoolSettings), fullyQualifiedName: "azurerm.frontdoor.FrontdoorBackendPoolSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.Frontdoor.IFrontdoorBackendPoolSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#enforce_backend_pools_certificate_name_check Frontdoor#enforce_backend_pools_certificate_name_check}.</summary>
            [JsiiProperty(name: "enforceBackendPoolsCertificateNameCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object EnforceBackendPoolsCertificateNameCheck
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#backend_pools_send_receive_timeout_seconds Frontdoor#backend_pools_send_receive_timeout_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backendPoolsSendReceiveTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackendPoolsSendReceiveTimeoutSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
