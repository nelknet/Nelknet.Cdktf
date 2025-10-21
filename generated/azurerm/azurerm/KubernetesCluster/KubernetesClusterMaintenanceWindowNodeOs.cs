using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNodeOs")]
    public class KubernetesClusterMaintenanceWindowNodeOs : azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNodeOs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#duration KubernetesCluster#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"number\"}")]
        public double Duration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#frequency KubernetesCluster#frequency}.</summary>
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}")]
        public string Frequency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#interval KubernetesCluster#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        public double Interval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#day_of_month KubernetesCluster#day_of_month}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DayOfMonth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#day_of_week KubernetesCluster#day_of_week}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DayOfWeek
        {
            get;
            set;
        }

        private object? _notAllowed;

        /// <summary>not_allowed block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#not_allowed KubernetesCluster#not_allowed}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notAllowed", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNodeOsNotAllowed\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NotAllowed
        {
            get => _notAllowed;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNodeOsNotAllowed[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNodeOsNotAllowed).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _notAllowed = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#start_date KubernetesCluster#start_date}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartDate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#start_time KubernetesCluster#start_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#utc_offset KubernetesCluster#utc_offset}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "utcOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UtcOffset
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#week_index KubernetesCluster#week_index}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weekIndex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WeekIndex
        {
            get;
            set;
        }
    }
}
