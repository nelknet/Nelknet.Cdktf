using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiInterface(nativeType: typeof(IAppflowFlowTriggerConfigTriggerProperties), fullyQualifiedName: "aws.appflowFlow.AppflowFlowTriggerConfigTriggerProperties")]
    public interface IAppflowFlowTriggerConfigTriggerProperties
    {
        /// <summary>scheduled block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#scheduled AppflowFlow#scheduled}
        /// </remarks>
        [JsiiProperty(name: "scheduled", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowTriggerConfigTriggerPropertiesScheduled\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerPropertiesScheduled? Scheduled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowFlowTriggerConfigTriggerProperties), fullyQualifiedName: "aws.appflowFlow.AppflowFlowTriggerConfigTriggerProperties")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>scheduled block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#scheduled AppflowFlow#scheduled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scheduled", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowTriggerConfigTriggerPropertiesScheduled\"}", isOptional: true)]
            public aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerPropertiesScheduled? Scheduled
            {
                get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerPropertiesScheduled?>();
            }
        }
    }
}
