using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventTarget
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetRedshiftTarget), fullyQualifiedName: "aws.cloudwatchEventTarget.CloudwatchEventTargetRedshiftTarget")]
    public interface ICloudwatchEventTargetRedshiftTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#database CloudwatchEventTarget#database}.</summary>
        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
        string Database
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#db_user CloudwatchEventTarget#db_user}.</summary>
        [JsiiProperty(name: "dbUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#secrets_manager_arn CloudwatchEventTarget#secrets_manager_arn}.</summary>
        [JsiiProperty(name: "secretsManagerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretsManagerArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#sql CloudwatchEventTarget#sql}.</summary>
        [JsiiProperty(name: "sql", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Sql
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#statement_name CloudwatchEventTarget#statement_name}.</summary>
        [JsiiProperty(name: "statementName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StatementName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#with_event CloudwatchEventTarget#with_event}.</summary>
        [JsiiProperty(name: "withEvent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WithEvent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetRedshiftTarget), fullyQualifiedName: "aws.cloudwatchEventTarget.CloudwatchEventTargetRedshiftTarget")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventTarget.ICloudwatchEventTargetRedshiftTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#database CloudwatchEventTarget#database}.</summary>
            [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
            public string Database
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#db_user CloudwatchEventTarget#db_user}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbUser
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#secrets_manager_arn CloudwatchEventTarget#secrets_manager_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretsManagerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretsManagerArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#sql CloudwatchEventTarget#sql}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sql", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Sql
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#statement_name CloudwatchEventTarget#statement_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "statementName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StatementName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#with_event CloudwatchEventTarget#with_event}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "withEvent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? WithEvent
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
