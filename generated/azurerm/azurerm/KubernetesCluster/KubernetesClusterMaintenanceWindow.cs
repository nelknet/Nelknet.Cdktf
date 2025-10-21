using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindow")]
    public class KubernetesClusterMaintenanceWindow : azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindow
    {
        private object? _allowed;

        /// <summary>allowed block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#allowed KubernetesCluster#allowed}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowed", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowAllowed\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Allowed
        {
            get => _allowed;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAllowed[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAllowed).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowed = value;
            }
        }

        private object? _notAllowed;

        /// <summary>not_allowed block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#not_allowed KubernetesCluster#not_allowed}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notAllowed", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNotAllowed\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNotAllowed[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNotAllowed).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _notAllowed = value;
            }
        }
    }
}
