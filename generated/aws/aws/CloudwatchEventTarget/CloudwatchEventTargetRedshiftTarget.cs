using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchEventTarget.CloudwatchEventTargetRedshiftTarget")]
    public class CloudwatchEventTargetRedshiftTarget : aws.CloudwatchEventTarget.ICloudwatchEventTargetRedshiftTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#database CloudwatchEventTarget#database}.</summary>
        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
        public string Database
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#db_user CloudwatchEventTarget#db_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbUser
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#secrets_manager_arn CloudwatchEventTarget#secrets_manager_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretsManagerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretsManagerArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#sql CloudwatchEventTarget#sql}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sql", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Sql
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#statement_name CloudwatchEventTarget#statement_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "statementName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StatementName
        {
            get;
            set;
        }

        private object? _withEvent;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#with_event CloudwatchEventTarget#with_event}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "withEvent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? WithEvent
        {
            get => _withEvent;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _withEvent = value;
            }
        }
    }
}
