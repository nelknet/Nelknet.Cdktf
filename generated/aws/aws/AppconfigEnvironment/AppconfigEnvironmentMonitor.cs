using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppconfigEnvironment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appconfigEnvironment.AppconfigEnvironmentMonitor")]
    public class AppconfigEnvironmentMonitor : aws.AppconfigEnvironment.IAppconfigEnvironmentMonitor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_environment#alarm_arn AppconfigEnvironment#alarm_arn}.</summary>
        [JsiiProperty(name: "alarmArn", typeJson: "{\"primitive\":\"string\"}")]
        public string AlarmArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_environment#alarm_role_arn AppconfigEnvironment#alarm_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "alarmRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AlarmRoleArn
        {
            get;
            set;
        }
    }
}
