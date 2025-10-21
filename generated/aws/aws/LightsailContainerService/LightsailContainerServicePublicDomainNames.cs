using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailContainerService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lightsailContainerService.LightsailContainerServicePublicDomainNames")]
    public class LightsailContainerServicePublicDomainNames : aws.LightsailContainerService.ILightsailContainerServicePublicDomainNames
    {
        private object _certificate;

        /// <summary>certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#certificate LightsailContainerService#certificate}
        /// </remarks>
        [JsiiProperty(name: "certificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePublicDomainNamesCertificate\"},\"kind\":\"array\"}}]}}")]
        public object Certificate
        {
            get => _certificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.LightsailContainerService.ILightsailContainerServicePublicDomainNamesCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LightsailContainerService.ILightsailContainerServicePublicDomainNamesCertificate).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LightsailContainerService.ILightsailContainerServicePublicDomainNamesCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _certificate = value;
            }
        }
    }
}
