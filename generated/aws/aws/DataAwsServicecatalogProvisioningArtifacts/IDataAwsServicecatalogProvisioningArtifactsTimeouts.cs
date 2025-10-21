using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsServicecatalogProvisioningArtifacts
{
    [JsiiInterface(nativeType: typeof(IDataAwsServicecatalogProvisioningArtifactsTimeouts), fullyQualifiedName: "aws.dataAwsServicecatalogProvisioningArtifacts.DataAwsServicecatalogProvisioningArtifactsTimeouts")]
    public interface IDataAwsServicecatalogProvisioningArtifactsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_provisioning_artifacts#read DataAwsServicecatalogProvisioningArtifacts#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsServicecatalogProvisioningArtifactsTimeouts), fullyQualifiedName: "aws.dataAwsServicecatalogProvisioningArtifacts.DataAwsServicecatalogProvisioningArtifactsTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsServicecatalogProvisioningArtifacts.IDataAwsServicecatalogProvisioningArtifactsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_provisioning_artifacts#read DataAwsServicecatalogProvisioningArtifacts#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
