using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudformationType
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudformationType.CloudformationTypeLoggingConfig")]
    public class CloudformationTypeLoggingConfig : aws.CloudformationType.ICloudformationTypeLoggingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_type#log_group_name CloudformationType#log_group_name}.</summary>
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_type#log_role_arn CloudformationType#log_role_arn}.</summary>
        [JsiiProperty(name: "logRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LogRoleArn
        {
            get;
            set;
        }
    }
}
