using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MwaaEnvironment
{
    [JsiiByValue(fqn: "aws.mwaaEnvironment.MwaaEnvironmentLoggingConfiguration")]
    public class MwaaEnvironmentLoggingConfiguration : aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfiguration
    {
        /// <summary>dag_processing_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#dag_processing_logs MwaaEnvironment#dag_processing_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dagProcessingLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationDagProcessingLogs\"}", isOptional: true)]
        public aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationDagProcessingLogs? DagProcessingLogs
        {
            get;
            set;
        }

        /// <summary>scheduler_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#scheduler_logs MwaaEnvironment#scheduler_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schedulerLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationSchedulerLogs\"}", isOptional: true)]
        public aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationSchedulerLogs? SchedulerLogs
        {
            get;
            set;
        }

        /// <summary>task_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#task_logs MwaaEnvironment#task_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "taskLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationTaskLogs\"}", isOptional: true)]
        public aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationTaskLogs? TaskLogs
        {
            get;
            set;
        }

        /// <summary>webserver_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#webserver_logs MwaaEnvironment#webserver_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webserverLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationWebserverLogs\"}", isOptional: true)]
        public aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWebserverLogs? WebserverLogs
        {
            get;
            set;
        }

        /// <summary>worker_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#worker_logs MwaaEnvironment#worker_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workerLogs", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationWorkerLogs\"}", isOptional: true)]
        public aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfigurationWorkerLogs? WorkerLogs
        {
            get;
            set;
        }
    }
}
