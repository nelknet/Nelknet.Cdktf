using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiInterface(nativeType: typeof(IBatchJobDefinitionEksPropertiesPodPropertiesInitContainersResources), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesInitContainersResources")]
    public interface IBatchJobDefinitionEksPropertiesPodPropertiesInitContainersResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#limits BatchJobDefinition#limits}.</summary>
        [JsiiProperty(name: "limits", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Limits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#requests BatchJobDefinition#requests}.</summary>
        [JsiiProperty(name: "requests", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Requests
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchJobDefinitionEksPropertiesPodPropertiesInitContainersResources), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesInitContainersResources")]
        internal sealed class _Proxy : DeputyBase, aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesInitContainersResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#limits BatchJobDefinition#limits}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "limits", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Limits
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#requests BatchJobDefinition#requests}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requests", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Requests
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
