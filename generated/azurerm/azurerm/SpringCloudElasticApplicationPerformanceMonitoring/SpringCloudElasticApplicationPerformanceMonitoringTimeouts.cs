using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudElasticApplicationPerformanceMonitoring
{
    [JsiiByValue(fqn: "azurerm.springCloudElasticApplicationPerformanceMonitoring.SpringCloudElasticApplicationPerformanceMonitoringTimeouts")]
    public class SpringCloudElasticApplicationPerformanceMonitoringTimeouts : azurerm.SpringCloudElasticApplicationPerformanceMonitoring.ISpringCloudElasticApplicationPerformanceMonitoringTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_elastic_application_performance_monitoring#create SpringCloudElasticApplicationPerformanceMonitoring#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_elastic_application_performance_monitoring#delete SpringCloudElasticApplicationPerformanceMonitoring#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_elastic_application_performance_monitoring#read SpringCloudElasticApplicationPerformanceMonitoring#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_elastic_application_performance_monitoring#update SpringCloudElasticApplicationPerformanceMonitoring#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
