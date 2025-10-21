using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiInterface(nativeType: typeof(IBatchJobDefinitionEksProperties), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionEksProperties")]
    public interface IBatchJobDefinitionEksProperties
    {
        /// <summary>pod_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#pod_properties BatchJobDefinition#pod_properties}
        /// </remarks>
        [JsiiProperty(name: "podProperties", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodProperties\"}")]
        aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodProperties PodProperties
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchJobDefinitionEksProperties), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionEksProperties")]
        internal sealed class _Proxy : DeputyBase, aws.BatchJobDefinition.IBatchJobDefinitionEksProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>pod_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#pod_properties BatchJobDefinition#pod_properties}
            /// </remarks>
            [JsiiProperty(name: "podProperties", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodProperties\"}")]
            public aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodProperties PodProperties
            {
                get => GetInstanceProperty<aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodProperties>()!;
            }
        }
    }
}
