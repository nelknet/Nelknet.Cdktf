using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFlowDefinition
{
    [JsiiInterface(nativeType: typeof(ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig), fullyQualifiedName: "aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig")]
    public interface ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#human_loop_activation_conditions SagemakerFlowDefinition#human_loop_activation_conditions}.</summary>
        [JsiiProperty(name: "humanLoopActivationConditions", typeJson: "{\"primitive\":\"string\"}")]
        string HumanLoopActivationConditions
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig), fullyQualifiedName: "aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#human_loop_activation_conditions SagemakerFlowDefinition#human_loop_activation_conditions}.</summary>
            [JsiiProperty(name: "humanLoopActivationConditions", typeJson: "{\"primitive\":\"string\"}")]
            public string HumanLoopActivationConditions
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
