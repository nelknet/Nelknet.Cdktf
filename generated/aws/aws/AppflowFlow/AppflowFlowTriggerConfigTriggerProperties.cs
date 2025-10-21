using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowTriggerConfigTriggerProperties")]
    public class AppflowFlowTriggerConfigTriggerProperties : aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerProperties
    {
        /// <summary>scheduled block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#scheduled AppflowFlow#scheduled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scheduled", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowTriggerConfigTriggerPropertiesScheduled\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerPropertiesScheduled? Scheduled
        {
            get;
            set;
        }
    }
}
