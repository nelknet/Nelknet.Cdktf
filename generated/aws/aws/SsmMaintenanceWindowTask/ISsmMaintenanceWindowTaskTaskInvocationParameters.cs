using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmMaintenanceWindowTask
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParameters), fullyQualifiedName: "aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParameters")]
    public interface ISsmMaintenanceWindowTaskTaskInvocationParameters
    {
        /// <summary>automation_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#automation_parameters SsmMaintenanceWindowTask#automation_parameters}
        /// </remarks>
        [JsiiProperty(name: "automationParameters", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters? AutomationParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#lambda_parameters SsmMaintenanceWindowTask#lambda_parameters}
        /// </remarks>
        [JsiiProperty(name: "lambdaParameters", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters? LambdaParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>run_command_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#run_command_parameters SsmMaintenanceWindowTask#run_command_parameters}
        /// </remarks>
        [JsiiProperty(name: "runCommandParameters", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters? RunCommandParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_functions_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#step_functions_parameters SsmMaintenanceWindowTask#step_functions_parameters}
        /// </remarks>
        [JsiiProperty(name: "stepFunctionsParameters", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters? StepFunctionsParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParameters), fullyQualifiedName: "aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParameters")]
        internal sealed class _Proxy : DeputyBase, aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>automation_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#automation_parameters SsmMaintenanceWindowTask#automation_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "automationParameters", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters\"}", isOptional: true)]
            public aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters? AutomationParameters
            {
                get => GetInstanceProperty<aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters?>();
            }

            /// <summary>lambda_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#lambda_parameters SsmMaintenanceWindowTask#lambda_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaParameters", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters\"}", isOptional: true)]
            public aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters? LambdaParameters
            {
                get => GetInstanceProperty<aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters?>();
            }

            /// <summary>run_command_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#run_command_parameters SsmMaintenanceWindowTask#run_command_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runCommandParameters", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters\"}", isOptional: true)]
            public aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters? RunCommandParameters
            {
                get => GetInstanceProperty<aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters?>();
            }

            /// <summary>step_functions_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_task#step_functions_parameters SsmMaintenanceWindowTask#step_functions_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepFunctionsParameters", typeJson: "{\"fqn\":\"aws.ssmMaintenanceWindowTask.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters\"}", isOptional: true)]
            public aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters? StepFunctionsParameters
            {
                get => GetInstanceProperty<aws.SsmMaintenanceWindowTask.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters?>();
            }
        }
    }
}
