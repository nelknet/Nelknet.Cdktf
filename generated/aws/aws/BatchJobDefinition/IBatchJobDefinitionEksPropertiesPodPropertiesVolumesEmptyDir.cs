using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiInterface(nativeType: typeof(IBatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir")]
    public interface IBatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#size_limit BatchJobDefinition#size_limit}.</summary>
        [JsiiProperty(name: "sizeLimit", typeJson: "{\"primitive\":\"string\"}")]
        string SizeLimit
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#medium BatchJobDefinition#medium}.</summary>
        [JsiiProperty(name: "medium", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Medium
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir")]
        internal sealed class _Proxy : DeputyBase, aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#size_limit BatchJobDefinition#size_limit}.</summary>
            [JsiiProperty(name: "sizeLimit", typeJson: "{\"primitive\":\"string\"}")]
            public string SizeLimit
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#medium BatchJobDefinition#medium}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "medium", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Medium
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
