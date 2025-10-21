using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazoneEnvironmentProfile
{
    [JsiiByValue(fqn: "aws.datazoneEnvironmentProfile.DatazoneEnvironmentProfileUserParameters")]
    public class DatazoneEnvironmentProfileUserParameters : aws.DatazoneEnvironmentProfile.IDatazoneEnvironmentProfileUserParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_profile#name DatazoneEnvironmentProfile#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_profile#value DatazoneEnvironmentProfile#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
