using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailContainerService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lightsailContainerService.LightsailContainerServicePublicDomainNamesCertificate")]
    public class LightsailContainerServicePublicDomainNamesCertificate : aws.LightsailContainerService.ILightsailContainerServicePublicDomainNamesCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#certificate_name LightsailContainerService#certificate_name}.</summary>
        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#domain_names LightsailContainerService#domain_names}.</summary>
        [JsiiProperty(name: "domainNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] DomainNames
        {
            get;
            set;
        }
    }
}
