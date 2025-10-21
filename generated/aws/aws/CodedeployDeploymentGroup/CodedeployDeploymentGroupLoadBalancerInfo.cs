using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentGroup
{
    [JsiiByValue(fqn: "aws.codedeployDeploymentGroup.CodedeployDeploymentGroupLoadBalancerInfo")]
    public class CodedeployDeploymentGroupLoadBalancerInfo : aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfo
    {
        private object? _elbInfo;

        /// <summary>elb_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#elb_info CodedeployDeploymentGroup#elb_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "elbInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupLoadBalancerInfoElbInfo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ElbInfo
        {
            get => _elbInfo;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfoElbInfo[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfoElbInfo).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _elbInfo = value;
            }
        }

        private object? _targetGroupInfo;

        /// <summary>target_group_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#target_group_info CodedeployDeploymentGroup#target_group_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TargetGroupInfo
        {
            get => _targetGroupInfo;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targetGroupInfo = value;
            }
        }

        /// <summary>target_group_pair_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#target_group_pair_info CodedeployDeploymentGroup#target_group_pair_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupPairInfo", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo\"}", isOptional: true)]
        public aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo? TargetGroupPairInfo
        {
            get;
            set;
        }
    }
}
