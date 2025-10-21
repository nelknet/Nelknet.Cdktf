using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorProperties")]
    public class AppflowFlowDestinationFlowConfigDestinationConnectorProperties : aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorProperties
    {
        /// <summary>custom_connector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#custom_connector AppflowFlow#custom_connector}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customConnector", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomConnector\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomConnector? CustomConnector
        {
            get;
            set;
        }

        /// <summary>customer_profiles block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#customer_profiles AppflowFlow#customer_profiles}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerProfiles", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles? CustomerProfiles
        {
            get;
            set;
        }

        /// <summary>event_bridge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#event_bridge AppflowFlow#event_bridge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eventBridge", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesEventBridge\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesEventBridge? EventBridge
        {
            get;
            set;
        }

        /// <summary>honeycode block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#honeycode AppflowFlow#honeycode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "honeycode", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycode\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycode? Honeycode
        {
            get;
            set;
        }

        /// <summary>lookout_metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#lookout_metrics AppflowFlow#lookout_metrics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lookoutMetrics", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesLookoutMetrics\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesLookoutMetrics? LookoutMetrics
        {
            get;
            set;
        }

        /// <summary>marketo block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#marketo AppflowFlow#marketo}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "marketo", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesMarketo\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesMarketo? Marketo
        {
            get;
            set;
        }

        /// <summary>redshift block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#redshift AppflowFlow#redshift}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redshift", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesRedshift\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesRedshift? Redshift
        {
            get;
            set;
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#s3 AppflowFlow#s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3? S3
        {
            get;
            set;
        }

        /// <summary>salesforce block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#salesforce AppflowFlow#salesforce}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "salesforce", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSalesforce\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSalesforce? Salesforce
        {
            get;
            set;
        }

        /// <summary>sapo_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#sapo_data AppflowFlow#sapo_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sapoData", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoData\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoData? SapoData
        {
            get;
            set;
        }

        /// <summary>snowflake block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#snowflake AppflowFlow#snowflake}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snowflake", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSnowflake\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSnowflake? Snowflake
        {
            get;
            set;
        }

        /// <summary>upsolver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#upsolver AppflowFlow#upsolver}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upsolver", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesUpsolver\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesUpsolver? Upsolver
        {
            get;
            set;
        }

        /// <summary>zendesk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#zendesk AppflowFlow#zendesk}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zendesk", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesZendesk\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesZendesk? Zendesk
        {
            get;
            set;
        }
    }
}
