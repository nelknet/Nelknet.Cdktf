using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiInterface(nativeType: typeof(IEmrserverlessApplicationImageConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationImageConfiguration")]
    public interface IEmrserverlessApplicationImageConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#image_uri EmrserverlessApplication#image_uri}.</summary>
        [JsiiProperty(name: "imageUri", typeJson: "{\"primitive\":\"string\"}")]
        string ImageUri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrserverlessApplicationImageConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationImageConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EmrserverlessApplication.IEmrserverlessApplicationImageConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#image_uri EmrserverlessApplication#image_uri}.</summary>
            [JsiiProperty(name: "imageUri", typeJson: "{\"primitive\":\"string\"}")]
            public string ImageUri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
