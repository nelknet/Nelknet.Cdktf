using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Frontdoor
{
    [JsiiInterface(nativeType: typeof(IFrontdoorBackendPoolLoadBalancing), fullyQualifiedName: "azurerm.frontdoor.FrontdoorBackendPoolLoadBalancing")]
    public interface IFrontdoorBackendPoolLoadBalancing
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#name Frontdoor#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#additional_latency_milliseconds Frontdoor#additional_latency_milliseconds}.</summary>
        [JsiiProperty(name: "additionalLatencyMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AdditionalLatencyMilliseconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#sample_size Frontdoor#sample_size}.</summary>
        [JsiiProperty(name: "sampleSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SampleSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#successful_samples_required Frontdoor#successful_samples_required}.</summary>
        [JsiiProperty(name: "successfulSamplesRequired", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SuccessfulSamplesRequired
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFrontdoorBackendPoolLoadBalancing), fullyQualifiedName: "azurerm.frontdoor.FrontdoorBackendPoolLoadBalancing")]
        internal sealed class _Proxy : DeputyBase, azurerm.Frontdoor.IFrontdoorBackendPoolLoadBalancing
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#name Frontdoor#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#additional_latency_milliseconds Frontdoor#additional_latency_milliseconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalLatencyMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AdditionalLatencyMilliseconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#sample_size Frontdoor#sample_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sampleSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SampleSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#successful_samples_required Frontdoor#successful_samples_required}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "successfulSamplesRequired", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SuccessfulSamplesRequired
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
