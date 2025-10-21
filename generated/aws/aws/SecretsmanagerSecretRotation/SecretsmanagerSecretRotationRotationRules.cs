using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecretsmanagerSecretRotation
{
    [JsiiByValue(fqn: "aws.secretsmanagerSecretRotation.SecretsmanagerSecretRotationRotationRules")]
    public class SecretsmanagerSecretRotationRotationRules : aws.SecretsmanagerSecretRotation.ISecretsmanagerSecretRotationRotationRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_rotation#automatically_after_days SecretsmanagerSecretRotation#automatically_after_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "automaticallyAfterDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutomaticallyAfterDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_rotation#duration SecretsmanagerSecretRotation#duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Duration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_rotation#schedule_expression SecretsmanagerSecretRotation#schedule_expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScheduleExpression
        {
            get;
            set;
        }
    }
}
