using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowTriggerConfig")]
    public class AppflowFlowTriggerConfig : aws.AppflowFlow.IAppflowFlowTriggerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#trigger_type AppflowFlow#trigger_type}.</summary>
        [JsiiProperty(name: "triggerType", typeJson: "{\"primitive\":\"string\"}")]
        public string TriggerType
        {
            get;
            set;
        }

        /// <summary>trigger_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#trigger_properties AppflowFlow#trigger_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "triggerProperties", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowTriggerConfigTriggerProperties\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerProperties? TriggerProperties
        {
            get;
            set;
        }
    }
}
