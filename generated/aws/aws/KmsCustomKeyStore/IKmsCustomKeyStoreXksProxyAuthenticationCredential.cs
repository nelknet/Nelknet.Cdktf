using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KmsCustomKeyStore
{
    [JsiiInterface(nativeType: typeof(IKmsCustomKeyStoreXksProxyAuthenticationCredential), fullyQualifiedName: "aws.kmsCustomKeyStore.KmsCustomKeyStoreXksProxyAuthenticationCredential")]
    public interface IKmsCustomKeyStoreXksProxyAuthenticationCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#access_key_id KmsCustomKeyStore#access_key_id}.</summary>
        [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string AccessKeyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#raw_secret_access_key KmsCustomKeyStore#raw_secret_access_key}.</summary>
        [JsiiProperty(name: "rawSecretAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        string RawSecretAccessKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKmsCustomKeyStoreXksProxyAuthenticationCredential), fullyQualifiedName: "aws.kmsCustomKeyStore.KmsCustomKeyStoreXksProxyAuthenticationCredential")]
        internal sealed class _Proxy : DeputyBase, aws.KmsCustomKeyStore.IKmsCustomKeyStoreXksProxyAuthenticationCredential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#access_key_id KmsCustomKeyStore#access_key_id}.</summary>
            [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccessKeyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#raw_secret_access_key KmsCustomKeyStore#raw_secret_access_key}.</summary>
            [JsiiProperty(name: "rawSecretAccessKey", typeJson: "{\"primitive\":\"string\"}")]
            public string RawSecretAccessKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
