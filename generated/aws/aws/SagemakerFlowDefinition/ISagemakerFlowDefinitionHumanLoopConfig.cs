using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFlowDefinition
{
    [JsiiInterface(nativeType: typeof(ISagemakerFlowDefinitionHumanLoopConfig), fullyQualifiedName: "aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfig")]
    public interface ISagemakerFlowDefinitionHumanLoopConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#human_task_ui_arn SagemakerFlowDefinition#human_task_ui_arn}.</summary>
        [JsiiProperty(name: "humanTaskUiArn", typeJson: "{\"primitive\":\"string\"}")]
        string HumanTaskUiArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_count SagemakerFlowDefinition#task_count}.</summary>
        [JsiiProperty(name: "taskCount", typeJson: "{\"primitive\":\"number\"}")]
        double TaskCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_description SagemakerFlowDefinition#task_description}.</summary>
        [JsiiProperty(name: "taskDescription", typeJson: "{\"primitive\":\"string\"}")]
        string TaskDescription
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_title SagemakerFlowDefinition#task_title}.</summary>
        [JsiiProperty(name: "taskTitle", typeJson: "{\"primitive\":\"string\"}")]
        string TaskTitle
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#workteam_arn SagemakerFlowDefinition#workteam_arn}.</summary>
        [JsiiProperty(name: "workteamArn", typeJson: "{\"primitive\":\"string\"}")]
        string WorkteamArn
        {
            get;
        }

        /// <summary>public_workforce_task_price block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#public_workforce_task_price SagemakerFlowDefinition#public_workforce_task_price}
        /// </remarks>
        [JsiiProperty(name: "publicWorkforceTaskPrice", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice? PublicWorkforceTaskPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_availability_lifetime_in_seconds SagemakerFlowDefinition#task_availability_lifetime_in_seconds}.</summary>
        [JsiiProperty(name: "taskAvailabilityLifetimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TaskAvailabilityLifetimeInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_keywords SagemakerFlowDefinition#task_keywords}.</summary>
        [JsiiProperty(name: "taskKeywords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TaskKeywords
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_time_limit_in_seconds SagemakerFlowDefinition#task_time_limit_in_seconds}.</summary>
        [JsiiProperty(name: "taskTimeLimitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TaskTimeLimitInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFlowDefinitionHumanLoopConfig), fullyQualifiedName: "aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#human_task_ui_arn SagemakerFlowDefinition#human_task_ui_arn}.</summary>
            [JsiiProperty(name: "humanTaskUiArn", typeJson: "{\"primitive\":\"string\"}")]
            public string HumanTaskUiArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_count SagemakerFlowDefinition#task_count}.</summary>
            [JsiiProperty(name: "taskCount", typeJson: "{\"primitive\":\"number\"}")]
            public double TaskCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_description SagemakerFlowDefinition#task_description}.</summary>
            [JsiiProperty(name: "taskDescription", typeJson: "{\"primitive\":\"string\"}")]
            public string TaskDescription
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_title SagemakerFlowDefinition#task_title}.</summary>
            [JsiiProperty(name: "taskTitle", typeJson: "{\"primitive\":\"string\"}")]
            public string TaskTitle
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#workteam_arn SagemakerFlowDefinition#workteam_arn}.</summary>
            [JsiiProperty(name: "workteamArn", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkteamArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>public_workforce_task_price block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#public_workforce_task_price SagemakerFlowDefinition#public_workforce_task_price}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicWorkforceTaskPrice", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice\"}", isOptional: true)]
            public aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice? PublicWorkforceTaskPrice
            {
                get => GetInstanceProperty<aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_availability_lifetime_in_seconds SagemakerFlowDefinition#task_availability_lifetime_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taskAvailabilityLifetimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TaskAvailabilityLifetimeInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_keywords SagemakerFlowDefinition#task_keywords}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taskKeywords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TaskKeywords
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_time_limit_in_seconds SagemakerFlowDefinition#task_time_limit_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taskTimeLimitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TaskTimeLimitInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
