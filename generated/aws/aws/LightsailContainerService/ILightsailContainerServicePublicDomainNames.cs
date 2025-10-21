using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailContainerService
{
    [JsiiInterface(nativeType: typeof(ILightsailContainerServicePublicDomainNames), fullyQualifiedName: "aws.lightsailContainerService.LightsailContainerServicePublicDomainNames")]
    public interface ILightsailContainerServicePublicDomainNames
    {
        /// <summary>certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#certificate LightsailContainerService#certificate}
        /// </remarks>
        [JsiiProperty(name: "certificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePublicDomainNamesCertificate\"},\"kind\":\"array\"}}]}}")]
        object Certificate
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILightsailContainerServicePublicDomainNames), fullyQualifiedName: "aws.lightsailContainerService.LightsailContainerServicePublicDomainNames")]
        internal sealed class _Proxy : DeputyBase, aws.LightsailContainerService.ILightsailContainerServicePublicDomainNames
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#certificate LightsailContainerService#certificate}
            /// </remarks>
            [JsiiProperty(name: "certificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePublicDomainNamesCertificate\"},\"kind\":\"array\"}}]}}")]
            public object Certificate
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
