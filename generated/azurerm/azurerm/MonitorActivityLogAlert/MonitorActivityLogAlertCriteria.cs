using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorActivityLogAlert
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorActivityLogAlert.MonitorActivityLogAlertCriteria")]
    public class MonitorActivityLogAlertCriteria : azurerm.MonitorActivityLogAlert.IMonitorActivityLogAlertCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#category MonitorActivityLogAlert#category}.</summary>
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public string Category
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#caller MonitorActivityLogAlert#caller}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "caller", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Caller
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#level MonitorActivityLogAlert#level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Level
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#levels MonitorActivityLogAlert#levels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "levels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Levels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#operation_name MonitorActivityLogAlert#operation_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OperationName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#recommendation_category MonitorActivityLogAlert#recommendation_category}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recommendationCategory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecommendationCategory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#recommendation_impact MonitorActivityLogAlert#recommendation_impact}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recommendationImpact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecommendationImpact
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#recommendation_type MonitorActivityLogAlert#recommendation_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recommendationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecommendationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#resource_group MonitorActivityLogAlert#resource_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#resource_groups MonitorActivityLogAlert#resource_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResourceGroups
        {
            get;
            set;
        }

        /// <summary>resource_health block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#resource_health MonitorActivityLogAlert#resource_health}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceHealth", typeJson: "{\"fqn\":\"azurerm.monitorActivityLogAlert.MonitorActivityLogAlertCriteriaResourceHealth\"}", isOptional: true)]
        public azurerm.MonitorActivityLogAlert.IMonitorActivityLogAlertCriteriaResourceHealth? ResourceHealth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#resource_id MonitorActivityLogAlert#resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#resource_ids MonitorActivityLogAlert#resource_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResourceIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#resource_provider MonitorActivityLogAlert#resource_provider}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceProvider
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#resource_providers MonitorActivityLogAlert#resource_providers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceProviders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResourceProviders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#resource_type MonitorActivityLogAlert#resource_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#resource_types MonitorActivityLogAlert#resource_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResourceTypes
        {
            get;
            set;
        }

        /// <summary>service_health block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#service_health MonitorActivityLogAlert#service_health}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceHealth", typeJson: "{\"fqn\":\"azurerm.monitorActivityLogAlert.MonitorActivityLogAlertCriteriaServiceHealth\"}", isOptional: true)]
        public azurerm.MonitorActivityLogAlert.IMonitorActivityLogAlertCriteriaServiceHealth? ServiceHealth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#status MonitorActivityLogAlert#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#statuses MonitorActivityLogAlert#statuses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "statuses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Statuses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#sub_status MonitorActivityLogAlert#sub_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubStatus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#sub_statuses MonitorActivityLogAlert#sub_statuses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subStatuses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SubStatuses
        {
            get;
            set;
        }
    }
}
