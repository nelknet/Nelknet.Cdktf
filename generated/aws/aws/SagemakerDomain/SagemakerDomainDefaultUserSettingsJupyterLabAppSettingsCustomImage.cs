using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsCustomImage")]
    public class SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsCustomImage : aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettingsCustomImage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#app_image_config_name SagemakerDomain#app_image_config_name}.</summary>
        [JsiiProperty(name: "appImageConfigName", typeJson: "{\"primitive\":\"string\"}")]
        public string AppImageConfigName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#image_name SagemakerDomain#image_name}.</summary>
        [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}")]
        public string ImageName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#image_version_number SagemakerDomain#image_version_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageVersionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ImageVersionNumber
        {
            get;
            set;
        }
    }
}
