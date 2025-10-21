using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerProject
{
    [JsiiInterface(nativeType: typeof(ISagemakerProjectServiceCatalogProvisioningDetails), fullyQualifiedName: "aws.sagemakerProject.SagemakerProjectServiceCatalogProvisioningDetails")]
    public interface ISagemakerProjectServiceCatalogProvisioningDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#product_id SagemakerProject#product_id}.</summary>
        [JsiiProperty(name: "productId", typeJson: "{\"primitive\":\"string\"}")]
        string ProductId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#path_id SagemakerProject#path_id}.</summary>
        [JsiiProperty(name: "pathId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PathId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#provisioning_artifact_id SagemakerProject#provisioning_artifact_id}.</summary>
        [JsiiProperty(name: "provisioningArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProvisioningArtifactId
        {
            get
            {
                return null;
            }
        }

        /// <summary>provisioning_parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#provisioning_parameter SagemakerProject#provisioning_parameter}
        /// </remarks>
        [JsiiProperty(name: "provisioningParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerProject.SagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProvisioningParameter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerProjectServiceCatalogProvisioningDetails), fullyQualifiedName: "aws.sagemakerProject.SagemakerProjectServiceCatalogProvisioningDetails")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerProject.ISagemakerProjectServiceCatalogProvisioningDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#product_id SagemakerProject#product_id}.</summary>
            [JsiiProperty(name: "productId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProductId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#path_id SagemakerProject#path_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pathId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PathId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#provisioning_artifact_id SagemakerProject#provisioning_artifact_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "provisioningArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProvisioningArtifactId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>provisioning_parameter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#provisioning_parameter SagemakerProject#provisioning_parameter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioningParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerProject.SagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProvisioningParameter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
