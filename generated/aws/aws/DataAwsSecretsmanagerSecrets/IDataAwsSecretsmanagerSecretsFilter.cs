using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSecretsmanagerSecrets
{
    [JsiiInterface(nativeType: typeof(IDataAwsSecretsmanagerSecretsFilter), fullyQualifiedName: "aws.dataAwsSecretsmanagerSecrets.DataAwsSecretsmanagerSecretsFilter")]
    public interface IDataAwsSecretsmanagerSecretsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secrets#name DataAwsSecretsmanagerSecrets#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secrets#values DataAwsSecretsmanagerSecrets#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsSecretsmanagerSecretsFilter), fullyQualifiedName: "aws.dataAwsSecretsmanagerSecrets.DataAwsSecretsmanagerSecretsFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsSecretsmanagerSecrets.IDataAwsSecretsmanagerSecretsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secrets#name DataAwsSecretsmanagerSecrets#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secrets#values DataAwsSecretsmanagerSecrets#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
