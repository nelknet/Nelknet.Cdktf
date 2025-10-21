using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiInterface(nativeType: typeof(IAppflowFlowTriggerConfig), fullyQualifiedName: "aws.appflowFlow.AppflowFlowTriggerConfig")]
    public interface IAppflowFlowTriggerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#trigger_type AppflowFlow#trigger_type}.</summary>
        [JsiiProperty(name: "triggerType", typeJson: "{\"primitive\":\"string\"}")]
        string TriggerType
        {
            get;
        }

        /// <summary>trigger_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#trigger_properties AppflowFlow#trigger_properties}
        /// </remarks>
        [JsiiProperty(name: "triggerProperties", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowTriggerConfigTriggerProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerProperties? TriggerProperties
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowFlowTriggerConfig), fullyQualifiedName: "aws.appflowFlow.AppflowFlowTriggerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowFlow.IAppflowFlowTriggerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#trigger_type AppflowFlow#trigger_type}.</summary>
            [JsiiProperty(name: "triggerType", typeJson: "{\"primitive\":\"string\"}")]
            public string TriggerType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>trigger_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#trigger_properties AppflowFlow#trigger_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "triggerProperties", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowTriggerConfigTriggerProperties\"}", isOptional: true)]
            public aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerProperties? TriggerProperties
            {
                get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerProperties?>();
            }
        }
    }
}
