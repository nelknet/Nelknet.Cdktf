using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiInterface(nativeType: typeof(IMskconnectConnectorWorkerConfiguration), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorWorkerConfiguration")]
    public interface IMskconnectConnectorWorkerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#arn MskconnectConnector#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#revision MskconnectConnector#revision}.</summary>
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
        double Revision
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskconnectConnectorWorkerConfiguration), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorWorkerConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.MskconnectConnector.IMskconnectConnectorWorkerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#arn MskconnectConnector#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#revision MskconnectConnector#revision}.</summary>
            [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
            public double Revision
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
