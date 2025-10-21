using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MwaaEnvironment
{
    [JsiiInterface(nativeType: typeof(IMwaaEnvironmentLoggingConfiguration), fullyQualifiedName: "aws.mwaaEnvironment.MwaaEnvironmentLoggingConfiguration")]
    public interface IMwaaEnvironmentLoggingConfiguration
    {
        /// <summary>dag_processing_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#dag_processing_logs MwaaEnvironment#dag_processing_logs}
        /// </remarks>
        [JsiiProperty(name: "dagProcessingLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationDagProcessingLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs? DagProcessingLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>scheduler_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#scheduler_logs MwaaEnvironment#scheduler_logs}
        /// </remarks>
        [JsiiProperty(name: "schedulerLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationSchedulerLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationSchedulerLogs? SchedulerLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>task_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#task_logs MwaaEnvironment#task_logs}
        /// </remarks>
        [JsiiProperty(name: "taskLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationTaskLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationTaskLogs? TaskLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>webserver_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#webserver_logs MwaaEnvironment#webserver_logs}
        /// </remarks>
        [JsiiProperty(name: "webserverLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationWebserverLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWebserverLogs? WebserverLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>worker_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#worker_logs MwaaEnvironment#worker_logs}
        /// </remarks>
        [JsiiProperty(name: "workerLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationWorkerLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWorkerLogs? WorkerLogs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMwaaEnvironmentLoggingConfiguration), fullyQualifiedName: "aws.mwaaEnvironment.MwaaEnvironmentLoggingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dag_processing_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#dag_processing_logs MwaaEnvironment#dag_processing_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dagProcessingLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationDagProcessingLogs\"}", isOptional: true)]
            public aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs? DagProcessingLogs
            {
                get => GetInstanceProperty<aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs?>();
            }

            /// <summary>scheduler_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#scheduler_logs MwaaEnvironment#scheduler_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schedulerLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationSchedulerLogs\"}", isOptional: true)]
            public aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationSchedulerLogs? SchedulerLogs
            {
                get => GetInstanceProperty<aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationSchedulerLogs?>();
            }

            /// <summary>task_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#task_logs MwaaEnvironment#task_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taskLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationTaskLogs\"}", isOptional: true)]
            public aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationTaskLogs? TaskLogs
            {
                get => GetInstanceProperty<aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationTaskLogs?>();
            }

            /// <summary>webserver_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#webserver_logs MwaaEnvironment#webserver_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webserverLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationWebserverLogs\"}", isOptional: true)]
            public aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWebserverLogs? WebserverLogs
            {
                get => GetInstanceProperty<aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWebserverLogs?>();
            }

            /// <summary>worker_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#worker_logs MwaaEnvironment#worker_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workerLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationWorkerLogs\"}", isOptional: true)]
            public aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWorkerLogs? WorkerLogs
            {
                get => GetInstanceProperty<aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWorkerLogs?>();
            }
        }
    }
}
