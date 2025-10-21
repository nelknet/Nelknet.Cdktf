using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiInterface(nativeType: typeof(IEmrserverlessApplicationInitialCapacityInitialCapacityConfig), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfig")]
    public interface IEmrserverlessApplicationInitialCapacityInitialCapacityConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#worker_count EmrserverlessApplication#worker_count}.</summary>
        [JsiiProperty(name: "workerCount", typeJson: "{\"primitive\":\"number\"}")]
        double WorkerCount
        {
            get;
        }

        /// <summary>worker_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#worker_configuration EmrserverlessApplication#worker_configuration}
        /// </remarks>
        [JsiiProperty(name: "workerConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration? WorkerConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrserverlessApplicationInitialCapacityInitialCapacityConfig), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#worker_count EmrserverlessApplication#worker_count}.</summary>
            [JsiiProperty(name: "workerCount", typeJson: "{\"primitive\":\"number\"}")]
            public double WorkerCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>worker_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#worker_configuration EmrserverlessApplication#worker_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workerConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration\"}", isOptional: true)]
            public aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration? WorkerConfiguration
            {
                get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration?>();
            }
        }
    }
}
