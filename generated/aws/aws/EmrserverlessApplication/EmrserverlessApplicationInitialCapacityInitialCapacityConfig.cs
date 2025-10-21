using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfig")]
    public class EmrserverlessApplicationInitialCapacityInitialCapacityConfig : aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#worker_count EmrserverlessApplication#worker_count}.</summary>
        [JsiiProperty(name: "workerCount", typeJson: "{\"primitive\":\"number\"}")]
        public double WorkerCount
        {
            get;
            set;
        }

        /// <summary>worker_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#worker_configuration EmrserverlessApplication#worker_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workerConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration\"}", isOptional: true)]
        public aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration? WorkerConfiguration
        {
            get;
            set;
        }
    }
}
