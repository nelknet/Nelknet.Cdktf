using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiInterface(nativeType: typeof(IEmrserverlessApplicationInitialCapacity), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacity")]
    public interface IEmrserverlessApplicationInitialCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#initial_capacity_type EmrserverlessApplication#initial_capacity_type}.</summary>
        [JsiiProperty(name: "initialCapacityType", typeJson: "{\"primitive\":\"string\"}")]
        string InitialCapacityType
        {
            get;
        }

        /// <summary>initial_capacity_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#initial_capacity_config EmrserverlessApplication#initial_capacity_config}
        /// </remarks>
        [JsiiProperty(name: "initialCapacityConfig", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfig? InitialCapacityConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrserverlessApplicationInitialCapacity), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacity")]
        internal sealed class _Proxy : DeputyBase, aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#initial_capacity_type EmrserverlessApplication#initial_capacity_type}.</summary>
            [JsiiProperty(name: "initialCapacityType", typeJson: "{\"primitive\":\"string\"}")]
            public string InitialCapacityType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>initial_capacity_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#initial_capacity_config EmrserverlessApplication#initial_capacity_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initialCapacityConfig", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfig\"}", isOptional: true)]
            public aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfig? InitialCapacityConfig
            {
                get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfig?>();
            }
        }
    }
}
