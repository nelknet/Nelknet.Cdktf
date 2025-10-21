using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codedeployDeploymentGroup.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo")]
    public class CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo : aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo
    {
        /// <summary>prod_traffic_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#prod_traffic_route CodedeployDeploymentGroup#prod_traffic_route}
        /// </remarks>
        [JsiiProperty(name: "prodTrafficRoute", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute\"}")]
        public aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute ProdTrafficRoute
        {
            get;
            set;
        }

        private object _targetGroup;

        /// <summary>target_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#target_group CodedeployDeploymentGroup#target_group}
        /// </remarks>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup\"},\"kind\":\"array\"}}]}}")]
        public object TargetGroup
        {
            get => _targetGroup;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targetGroup = value;
            }
        }

        /// <summary>test_traffic_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#test_traffic_route CodedeployDeploymentGroup#test_traffic_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "testTrafficRoute", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute\"}", isOptional: true)]
        public aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute? TestTrafficRoute
        {
            get;
            set;
        }
    }
}
