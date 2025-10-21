using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailContainerService
{
    [JsiiInterface(nativeType: typeof(ILightsailContainerServicePublicDomainNamesCertificate), fullyQualifiedName: "aws.lightsailContainerService.LightsailContainerServicePublicDomainNamesCertificate")]
    public interface ILightsailContainerServicePublicDomainNamesCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#certificate_name LightsailContainerService#certificate_name}.</summary>
        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#domain_names LightsailContainerService#domain_names}.</summary>
        [JsiiProperty(name: "domainNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DomainNames
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILightsailContainerServicePublicDomainNamesCertificate), fullyQualifiedName: "aws.lightsailContainerService.LightsailContainerServicePublicDomainNamesCertificate")]
        internal sealed class _Proxy : DeputyBase, aws.LightsailContainerService.ILightsailContainerServicePublicDomainNamesCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#certificate_name LightsailContainerService#certificate_name}.</summary>
            [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#domain_names LightsailContainerService#domain_names}.</summary>
            [JsiiProperty(name: "domainNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DomainNames
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
