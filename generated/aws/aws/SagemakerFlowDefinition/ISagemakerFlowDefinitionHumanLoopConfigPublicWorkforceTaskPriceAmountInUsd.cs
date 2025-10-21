using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFlowDefinition
{
    [JsiiInterface(nativeType: typeof(ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd), fullyQualifiedName: "aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd")]
    public interface ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#cents SagemakerFlowDefinition#cents}.</summary>
        [JsiiProperty(name: "cents", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Cents
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#dollars SagemakerFlowDefinition#dollars}.</summary>
        [JsiiProperty(name: "dollars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Dollars
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#tenth_fractions_of_a_cent SagemakerFlowDefinition#tenth_fractions_of_a_cent}.</summary>
        [JsiiProperty(name: "tenthFractionsOfACent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TenthFractionsOfACent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd), fullyQualifiedName: "aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#cents SagemakerFlowDefinition#cents}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cents", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Cents
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#dollars SagemakerFlowDefinition#dollars}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dollars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Dollars
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#tenth_fractions_of_a_cent SagemakerFlowDefinition#tenth_fractions_of_a_cent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tenthFractionsOfACent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TenthFractionsOfACent
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
