using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesEdgeNode")]
    public class HdinsightHadoopClusterRolesEdgeNode : azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNode
    {
        private object _installScriptAction;

        /// <summary>install_script_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#install_script_action HdinsightHadoopCluster#install_script_action}
        /// </remarks>
        [JsiiProperty(name: "installScriptAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesEdgeNodeInstallScriptAction\"},\"kind\":\"array\"}}]}}")]
        public object InstallScriptAction
        {
            get => _installScriptAction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNodeInstallScriptAction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNodeInstallScriptAction).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNodeInstallScriptAction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _installScriptAction = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#target_instance_count HdinsightHadoopCluster#target_instance_count}.</summary>
        [JsiiProperty(name: "targetInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public double TargetInstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#vm_size HdinsightHadoopCluster#vm_size}.</summary>
        [JsiiProperty(name: "vmSize", typeJson: "{\"primitive\":\"string\"}")]
        public string VmSize
        {
            get;
            set;
        }

        private object? _httpsEndpoints;

        /// <summary>https_endpoints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#https_endpoints HdinsightHadoopCluster#https_endpoints}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpsEndpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesEdgeNodeHttpsEndpoints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HttpsEndpoints
        {
            get => _httpsEndpoints;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNodeHttpsEndpoints[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNodeHttpsEndpoints).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _httpsEndpoints = value;
            }
        }

        private object? _uninstallScriptActions;

        /// <summary>uninstall_script_actions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#uninstall_script_actions HdinsightHadoopCluster#uninstall_script_actions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uninstallScriptActions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesEdgeNodeUninstallScriptActions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UninstallScriptActions
        {
            get => _uninstallScriptActions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNodeUninstallScriptActions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNodeUninstallScriptActions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _uninstallScriptActions = value;
            }
        }
    }
}
