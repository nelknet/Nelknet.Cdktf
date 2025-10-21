using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentGroup
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption), fullyQualifiedName: "aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption")]
    public interface ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#action_on_timeout CodedeployDeploymentGroup#action_on_timeout}.</summary>
        [JsiiProperty(name: "actionOnTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActionOnTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#wait_time_in_minutes CodedeployDeploymentGroup#wait_time_in_minutes}.</summary>
        [JsiiProperty(name: "waitTimeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WaitTimeInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption), fullyQualifiedName: "aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption")]
        internal sealed class _Proxy : DeputyBase, aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#action_on_timeout CodedeployDeploymentGroup#action_on_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actionOnTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActionOnTimeout
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#wait_time_in_minutes CodedeployDeploymentGroup#wait_time_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "waitTimeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WaitTimeInMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
