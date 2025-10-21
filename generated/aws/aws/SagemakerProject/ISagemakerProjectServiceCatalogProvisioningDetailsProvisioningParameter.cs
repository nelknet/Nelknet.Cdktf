using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerProject
{
    [JsiiInterface(nativeType: typeof(ISagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter), fullyQualifiedName: "aws.sagemakerProject.SagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter")]
    public interface ISagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#key SagemakerProject#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#value SagemakerProject#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter), fullyQualifiedName: "aws.sagemakerProject.SagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerProject.ISagemakerProjectServiceCatalogProvisioningDetailsProvisioningParameter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#key SagemakerProject#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#value SagemakerProject#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
